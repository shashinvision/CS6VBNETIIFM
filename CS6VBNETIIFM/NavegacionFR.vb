Imports MySql.Data.MySqlClient
Public Class NavegacionFR


    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=Northwind"
    Dim conn As New MySqlConnection(connString)
    Dim dataSet As New DataSet()
    Dim tablaProveedores As DataTable
    Dim query As String
    Dim numReg As Integer

    Dim adapterGlobal As New MySqlDataAdapter()
    Dim CommandBuilder As New MySqlCommandBuilder(adapterGlobal)

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

    Private Sub NavegacionFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSuppliers()

    End Sub

    Private Sub primeroBtn_Click(sender As Object, e As EventArgs) Handles primeroBtn.Click
        habilitado(False)
        numReg = 0
        Me.BindingContext(tablaProveedores).Position = numReg
    End Sub


    Private Sub ultimoBtn_Click(sender As Object, e As EventArgs) Handles ultimoBtn.Click
        habilitado(False)
        numReg = tablaProveedores.Rows.Count - 1
        Me.BindingContext(tablaProveedores).Position = numReg
    End Sub

    Private Sub anteriorBtn_Click(sender As Object, e As EventArgs) Handles anteriorBtn.Click
        habilitado(False)
        numReg -= 1
        If numReg < 0 Then
            numReg = 0
            MessageBox.Show("No existe el registro con número: " + (numReg - 1).ToString)
        End If
        Me.BindingContext(tablaProveedores).Position = numReg
    End Sub

    Private Sub siguienteBtn_Click(sender As Object, e As EventArgs) Handles siguienteBtn.Click
        habilitado(False)
        numReg += 1
        If numReg > tablaProveedores.Rows.Count - 1 Then
            numReg = tablaProveedores.Rows.Count - 1
            MessageBox.Show("No existe el registro con número: " + (numReg + 2).ToString)
        End If
        Me.BindingContext(tablaProveedores).Position = numReg
    End Sub

    Private Sub nuevoBtn_Click(sender As Object, e As EventArgs) Handles nuevoBtn.Click
        habilitado(True)
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

        guardarBtn.Enabled = verdadero

    End Sub
End Class