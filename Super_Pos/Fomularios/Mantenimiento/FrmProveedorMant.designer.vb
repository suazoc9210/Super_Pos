<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedorMant
    Inherits FrmPlantillaMant

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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvproveedor = New System.Windows.Forms.DataGridView()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttelvendedor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtemailvendedor = New System.Windows.Forms.TextBox()
        Me.txtnombrevendedor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrtn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodproveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvproveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Escriba para buscar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Lista de Proveedores"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(141, 289)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtbuscar.TabIndex = 8
        '
        'dgvproveedor
        '
        Me.dgvproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproveedor.Location = New System.Drawing.Point(12, 315)
        Me.dgvproveedor.Name = "dgvproveedor"
        Me.dgvproveedor.Size = New System.Drawing.Size(919, 234)
        Me.dgvproveedor.TabIndex = 0
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.Super_Pos.My.Resources.Resources.salir24
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(864, 206)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 45)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Enabled = False
        Me.btncancelar.Image = Global.Super_Pos.My.Resources.Resources.descartar
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(163, 206)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 45)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Enabled = False
        Me.btnactualizar.Image = Global.Super_Pos.My.Resources.Resources.editar24
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnactualizar.Location = New System.Drawing.Point(90, 206)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(67, 45)
        Me.btnactualizar.TabIndex = 3
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Image = Global.Super_Pos.My.Resources.Resources.guardar24
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(17, 206)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(67, 45)
        Me.btnguardar.TabIndex = 2
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txttelvendedor)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtemailvendedor)
        Me.GroupBox1.Controls.Add(Me.txtnombrevendedor)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtproveedor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtrtn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcodproveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 137)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Proveedor"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(588, 50)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(320, 20)
        Me.txtCiudad.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(465, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Ciudad:"
        '
        'txttelvendedor
        '
        Me.txttelvendedor.Location = New System.Drawing.Point(588, 103)
        Me.txttelvendedor.MaxLength = 8
        Me.txttelvendedor.Name = "txttelvendedor"
        Me.txttelvendedor.Size = New System.Drawing.Size(126, 20)
        Me.txttelvendedor.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(465, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Teléfono:"
        '
        'txtemailvendedor
        '
        Me.txtemailvendedor.Location = New System.Drawing.Point(778, 103)
        Me.txtemailvendedor.Name = "txtemailvendedor"
        Me.txtemailvendedor.Size = New System.Drawing.Size(130, 20)
        Me.txtemailvendedor.TabIndex = 17
        '
        'txtnombrevendedor
        '
        Me.txtnombrevendedor.Location = New System.Drawing.Point(588, 76)
        Me.txtnombrevendedor.Name = "txtnombrevendedor"
        Me.txtnombrevendedor.Size = New System.Drawing.Size(320, 20)
        Me.txtnombrevendedor.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(734, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "E-mail:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(465, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Nombrer de Vendedor:"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(122, 102)
        Me.txttelefono.MaxLength = 8
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(126, 20)
        Me.txttelefono.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Teléfono:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(298, 102)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(130, 20)
        Me.txtemail.TabIndex = 9
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(588, 24)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(320, 20)
        Me.txtdireccion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dirección:"
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(122, 50)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(306, 20)
        Me.txtproveedor.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "E-mail:"
        '
        'txtrtn
        '
        Me.txtrtn.Location = New System.Drawing.Point(122, 76)
        Me.txtrtn.MaxLength = 14
        Me.txtrtn.Name = "txtrtn"
        Me.txtrtn.Size = New System.Drawing.Size(126, 20)
        Me.txtrtn.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DNI/RTN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombrer de Proveedor:"
        '
        'txtcodproveedor
        '
        Me.txtcodproveedor.Location = New System.Drawing.Point(122, 24)
        Me.txtcodproveedor.MaxLength = 6
        Me.txtcodproveedor.Name = "txtcodproveedor"
        Me.txtcodproveedor.Size = New System.Drawing.Size(126, 20)
        Me.txtcodproveedor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código de Proveedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento de Proveedores"
        '
        'FrmProveedorMant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 561)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvproveedor)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProveedorMant"
        Me.Text = "Mantenimiento de Proveedor"
        CType(Me.dgvproveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents txtbuscar As TextBox
    Public WithEvents dgvproveedor As DataGridView
    Public WithEvents btnsalir As Button
    Public WithEvents btncancelar As Button
    Public WithEvents btnactualizar As Button
    Public WithEvents btnguardar As Button
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents txttelefono As TextBox
    Public WithEvents Label10 As Label
    Public WithEvents txtemail As TextBox
    Public WithEvents txtdireccion As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents txtproveedor As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtrtn As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents Label3 As Label
    Public WithEvents txtcodproveedor As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents txttelvendedor As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents txtemailvendedor As TextBox
    Public WithEvents txtnombrevendedor As TextBox
    Public WithEvents Label12 As Label
    Public WithEvents Label13 As Label
    Public WithEvents txtCiudad As TextBox
    Public WithEvents Label14 As Label
End Class
