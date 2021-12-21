Imports MySql.Data.MySqlClient

Public Class MantencionFR

    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=Northwind"
    Dim conn As New MySqlConnection(connString)
    Dim dataSet As New DataSet()
    Dim tablaProveedores As DataTable
    Dim query As String


    Dim adapterGlobal As New MySqlDataAdapter()
    Dim CommandBuilder As New MySqlCommandBuilder(adapterGlobal)
    Private Sub MantencionFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSuppliers()
        cargaComboBox()

    End Sub

    Public Sub getSuppliers()

        query = "SELECT * FROM Northwind.suppliers ORDER BY SupplierID"

        Try

            adapterGlobal.SelectCommand = New MySqlCommand(query, conn)
            adapterGlobal.InsertCommand = CommandBuilder.GetInsertCommand()
            adapterGlobal.UpdateCommand = CommandBuilder.GetUpdateCommand()
            adapterGlobal.DeleteCommand = CommandBuilder.GetDeleteCommand()

            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(query, conn)
            conn.Open()

            adapter.Fill(dataSet, "Proveedores")
            tablaProveedores = dataSet.Tables("Proveedores")

            idText.DataBindings.Add("Text", tablaProveedores, "SupplierID")
            nombreTxt.DataBindings.Add("Text", tablaProveedores, "CompanyName")
            nombreContactoTxt.DataBindings.Add("Text", tablaProveedores, "ContactName")
            cargoContactoTxt.DataBindings.Add("Text", tablaProveedores, "ContactTitle")
            direccionTxt.DataBindings.Add("Text", tablaProveedores, "Address")
            ciudadTxt.DataBindings.Add("Text", tablaProveedores, "City")
            regionTxt.DataBindings.Add("Text", tablaProveedores, "Region")
            CodigoPostalTxt.DataBindings.Add("Text", tablaProveedores, "PostalCode")
            paisTxt.DataBindings.Add("Text", tablaProveedores, "Country")
            telefonoTxt.DataBindings.Add("Text", tablaProveedores, "Phone")
            faxTxt.DataBindings.Add("Text", tablaProveedores, "Fax")
            paginaWebTxt.DataBindings.Add("Text", tablaProveedores, "HomePage")


        Catch ex As Exception
            MessageBox.Show("Error getSuppliers: " + ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Public Sub cargaComboBox()
        ' Uso la data ya cargada en getSuppliers() en el load para poblar el comboBox

        Try

            Dim row As DataRow

            Dim proveedoresDictionary As New Dictionary(Of String, String)()
            For Each row In tablaProveedores.Rows
                proveedoresDictionary.Add(row.Item("SupplierID"), row.Item("CompanyName"))
            Next

            proveedoresCB.DataSource = New BindingSource(proveedoresDictionary, Nothing)
            proveedoresCB.DisplayMember = "Value"
            proveedoresCB.ValueMember = "Key"

        Catch ex As Exception

            MessageBox.Show("Error cargaComboBox: " + ex.Message)

        Finally

            conn.Close()

        End Try
    End Sub

    Private Sub proveedoresCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles proveedoresCB.SelectedIndexChanged

        If proveedoresCB.SelectedIndex > -1 Then
            Me.BindingContext(tablaProveedores).Position = proveedoresCB.SelectedIndex
            habilitado(False)
        End If

    End Sub

    Public Sub habilitado(verdadero As Boolean)

        nombreTxt.ReadOnly = Not verdadero
        nombreContactoTxt.ReadOnly = Not verdadero
        cargoContactoTxt.ReadOnly = Not verdadero
        direccionTxt.ReadOnly = Not verdadero
        ciudadTxt.ReadOnly = Not verdadero
        regionTxt.ReadOnly = Not verdadero
        CodigoPostalTxt.ReadOnly = Not verdadero
        paisTxt.ReadOnly = Not verdadero
        telefonoTxt.ReadOnly = Not verdadero
        faxTxt.ReadOnly = Not verdadero
        paginaWebTxt.ReadOnly = Not verdadero

        modificarBtn.Enabled = Not verdadero
        eliminarBtn.Enabled = Not verdadero
        guardarBtn.Enabled = verdadero
        modificarBtn.Enabled = Not verdadero

    End Sub

    Private Sub modificarBtn_Click(sender As Object, e As EventArgs) Handles modificarBtn.Click
        habilitado(True)
    End Sub

    Private Sub guardarBtn_Click(sender As Object, e As EventArgs) Handles guardarBtn.Click
        Me.BindingContext(tablaProveedores).EndCurrentEdit()
        MessageBox.Show("Registro modificado sin conexión correctamente.")
        grabarBdBtn.Enabled = True
        cargaComboBox()
    End Sub

    Private Sub grabarBdBtn_Click(sender As Object, e As EventArgs) Handles grabarBdBtn.Click

        Try

            If dataSet.HasChanges() Then

                adapterGlobal.Update(dataSet, "Proveedores")
                dataSet.AcceptChanges()
                MessageBox.Show("Base de datos actualizada")
                grabarBdBtn.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar guardar en la BBDD: " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        Try

            Dim posicion = BindingContext(tablaProveedores).Position

            dataSet.Tables("Proveedores").Rows(posicion).Delete()
            adapterGlobal.Update(dataSet, "Proveedores")
            dataSet.AcceptChanges()
            Me.BindingContext(tablaProveedores).Position = tablaProveedores.Rows.Count - 2
            MessageBox.Show("Registro eliminado correctamente")
            cargaComboBox()

            grabarBdBtn.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error: " & vbCrLf & ex.Message)
        End Try
    End Sub
End Class