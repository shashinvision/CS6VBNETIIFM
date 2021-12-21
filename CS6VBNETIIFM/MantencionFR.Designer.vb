<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantencionFR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.guardarBtn = New System.Windows.Forms.Button()
        Me.modificarBtn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grabarBdBtn = New System.Windows.Forms.Button()
        Me.eliminarBtn = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.faxTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.paginaWebTxt = New System.Windows.Forms.TextBox()
        Me.telefonoTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cargoContactoTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nombreContactoTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.proveedoresCB = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.direccionTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.paisTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ciudadTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CodigoPostalTxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.regionTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'guardarBtn
        '
        Me.guardarBtn.Location = New System.Drawing.Point(196, 35)
        Me.guardarBtn.Name = "guardarBtn"
        Me.guardarBtn.Size = New System.Drawing.Size(148, 23)
        Me.guardarBtn.TabIndex = 7
        Me.guardarBtn.Text = "Guardar"
        Me.guardarBtn.UseVisualStyleBackColor = True
        '
        'modificarBtn
        '
        Me.modificarBtn.Location = New System.Drawing.Point(41, 35)
        Me.modificarBtn.Name = "modificarBtn"
        Me.modificarBtn.Size = New System.Drawing.Size(135, 23)
        Me.modificarBtn.TabIndex = 4
        Me.modificarBtn.Text = "Modificar"
        Me.modificarBtn.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grabarBdBtn)
        Me.GroupBox4.Controls.Add(Me.eliminarBtn)
        Me.GroupBox4.Controls.Add(Me.guardarBtn)
        Me.GroupBox4.Controls.Add(Me.modificarBtn)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(30, 432)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(827, 92)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro"
        '
        'grabarBdBtn
        '
        Me.grabarBdBtn.Enabled = False
        Me.grabarBdBtn.Location = New System.Drawing.Point(510, 35)
        Me.grabarBdBtn.Name = "grabarBdBtn"
        Me.grabarBdBtn.Size = New System.Drawing.Size(148, 23)
        Me.grabarBdBtn.TabIndex = 9
        Me.grabarBdBtn.Text = "Grabar en BD"
        Me.grabarBdBtn.UseVisualStyleBackColor = True
        '
        'eliminarBtn
        '
        Me.eliminarBtn.Location = New System.Drawing.Point(358, 35)
        Me.eliminarBtn.Name = "eliminarBtn"
        Me.eliminarBtn.Size = New System.Drawing.Size(135, 23)
        Me.eliminarBtn.TabIndex = 8
        Me.eliminarBtn.Text = "Eliminar"
        Me.eliminarBtn.UseVisualStyleBackColor = True
        '
        'faxTxt
        '
        Me.faxTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.faxTxt.Location = New System.Drawing.Point(19, 217)
        Me.faxTxt.Name = "faxTxt"
        Me.faxTxt.ReadOnly = True
        Me.faxTxt.Size = New System.Drawing.Size(316, 23)
        Me.faxTxt.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(19, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(19, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Página web"
        '
        'paginaWebTxt
        '
        Me.paginaWebTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.paginaWebTxt.Location = New System.Drawing.Point(19, 282)
        Me.paginaWebTxt.Name = "paginaWebTxt"
        Me.paginaWebTxt.ReadOnly = True
        Me.paginaWebTxt.Size = New System.Drawing.Size(316, 23)
        Me.paginaWebTxt.TabIndex = 9
        '
        'telefonoTxt
        '
        Me.telefonoTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.telefonoTxt.Location = New System.Drawing.Point(19, 163)
        Me.telefonoTxt.Name = "telefonoTxt"
        Me.telefonoTxt.ReadOnly = True
        Me.telefonoTxt.Size = New System.Drawing.Size(316, 23)
        Me.telefonoTxt.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.faxTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.paginaWebTxt)
        Me.GroupBox1.Controls.Add(Me.telefonoTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cargoContactoTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.nombreContactoTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nombreTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.idText)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 328)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(19, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Teléfono"
        '
        'cargoContactoTxt
        '
        Me.cargoContactoTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cargoContactoTxt.Location = New System.Drawing.Point(196, 104)
        Me.cargoContactoTxt.Name = "cargoContactoTxt"
        Me.cargoContactoTxt.ReadOnly = True
        Me.cargoContactoTxt.Size = New System.Drawing.Size(139, 23)
        Me.cargoContactoTxt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(196, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cargo de contacto"
        '
        'nombreContactoTxt
        '
        Me.nombreContactoTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nombreContactoTxt.Location = New System.Drawing.Point(19, 104)
        Me.nombreContactoTxt.Name = "nombreContactoTxt"
        Me.nombreContactoTxt.ReadOnly = True
        Me.nombreContactoTxt.Size = New System.Drawing.Size(139, 23)
        Me.nombreContactoTxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(19, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre de contacto"
        '
        'nombreTxt
        '
        Me.nombreTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nombreTxt.Location = New System.Drawing.Point(196, 49)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.ReadOnly = True
        Me.nombreTxt.Size = New System.Drawing.Size(139, 23)
        Me.nombreTxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(196, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Compañia"
        '
        'idText
        '
        Me.idText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.idText.Location = New System.Drawing.Point(19, 49)
        Me.idText.Name = "idText"
        Me.idText.ReadOnly = True
        Me.idText.Size = New System.Drawing.Size(82, 23)
        Me.idText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Proveedor"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.proveedoresCB)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 424)
        Me.Panel1.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(28, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Proveedor"
        '
        'proveedoresCB
        '
        Me.proveedoresCB.FormattingEnabled = True
        Me.proveedoresCB.Location = New System.Drawing.Point(28, 42)
        Me.proveedoresCB.Name = "proveedoresCB"
        Me.proveedoresCB.Size = New System.Drawing.Size(176, 23)
        Me.proveedoresCB.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.direccionTxt)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.paisTxt)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ciudadTxt)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.CodigoPostalTxt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.regionTxt)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(469, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 301)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'direccionTxt
        '
        Me.direccionTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.direccionTxt.Location = New System.Drawing.Point(15, 49)
        Me.direccionTxt.Name = "direccionTxt"
        Me.direccionTxt.ReadOnly = True
        Me.direccionTxt.Size = New System.Drawing.Size(320, 23)
        Me.direccionTxt.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(15, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Dirección"
        '
        'paisTxt
        '
        Me.paisTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.paisTxt.Location = New System.Drawing.Point(15, 159)
        Me.paisTxt.Name = "paisTxt"
        Me.paisTxt.ReadOnly = True
        Me.paisTxt.Size = New System.Drawing.Size(143, 23)
        Me.paisTxt.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(15, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "País"
        '
        'ciudadTxt
        '
        Me.ciudadTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ciudadTxt.Location = New System.Drawing.Point(196, 105)
        Me.ciudadTxt.Name = "ciudadTxt"
        Me.ciudadTxt.ReadOnly = True
        Me.ciudadTxt.Size = New System.Drawing.Size(139, 23)
        Me.ciudadTxt.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(196, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Ciudad"
        '
        'CodigoPostalTxt
        '
        Me.CodigoPostalTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CodigoPostalTxt.Location = New System.Drawing.Point(196, 159)
        Me.CodigoPostalTxt.Name = "CodigoPostalTxt"
        Me.CodigoPostalTxt.ReadOnly = True
        Me.CodigoPostalTxt.Size = New System.Drawing.Size(139, 23)
        Me.CodigoPostalTxt.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(196, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Código postal"
        '
        'regionTxt
        '
        Me.regionTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.regionTxt.Location = New System.Drawing.Point(15, 105)
        Me.regionTxt.Name = "regionTxt"
        Me.regionTxt.ReadOnly = True
        Me.regionTxt.Size = New System.Drawing.Size(143, 23)
        Me.regionTxt.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(15, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Región"
        '
        'MantencionFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 538)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MantencionFR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MantencionFR"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents guardarBtn As Button
    Friend WithEvents modificarBtn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents faxTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents paginaWebTxt As TextBox
    Friend WithEvents telefonoTxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cargoContactoTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nombreContactoTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents idText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents direccionTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents paisTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ciudadTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CodigoPostalTxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents regionTxt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents proveedoresCB As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grabarBdBtn As Button
End Class
