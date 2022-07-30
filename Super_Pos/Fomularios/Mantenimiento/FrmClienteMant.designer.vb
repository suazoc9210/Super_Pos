<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClienteMant
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
        Me.dgvcliente = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrtn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        CType(Me.dgvcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Escriba para buscar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Lista de Clientes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(141, 271)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtbuscar.TabIndex = 8
        '
        'dgvcliente
        '
        Me.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcliente.Location = New System.Drawing.Point(12, 297)
        Me.dgvcliente.Name = "dgvcliente"
        Me.dgvcliente.Size = New System.Drawing.Size(919, 253)
        Me.dgvcliente.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtrtn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcodcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 133)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'txttelefono
        '
        Me.txttelefono.Enabled = False
        Me.txttelefono.Location = New System.Drawing.Point(108, 102)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(137, 20)
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
        Me.txtemail.Enabled = False
        Me.txtemail.Location = New System.Drawing.Point(526, 13)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(137, 20)
        Me.txtemail.TabIndex = 9
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Location = New System.Drawing.Point(526, 43)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(382, 49)
        Me.txtdireccion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dirección:"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(108, 50)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(306, 20)
        Me.txtnombre.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "E-mail:"
        '
        'txtrtn
        '
        Me.txtrtn.Enabled = False
        Me.txtrtn.Location = New System.Drawing.Point(108, 76)
        Me.txtrtn.Name = "txtrtn"
        Me.txtrtn.Size = New System.Drawing.Size(137, 20)
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
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de cliente:"
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Enabled = False
        Me.txtcodcliente.Location = New System.Drawing.Point(108, 24)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(137, 20)
        Me.txtcodcliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código de Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento de Clientes"
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.Super_Pos.My.Resources.Resources.salir24
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(864, 194)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 45)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.Super_Pos.My.Resources.Resources.descartar
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(252, 194)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 45)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Image = Global.Super_Pos.My.Resources.Resources.editar24
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnactualizar.Location = New System.Drawing.Point(179, 194)
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
        Me.btnguardar.Location = New System.Drawing.Point(106, 194)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(67, 45)
        Me.btnguardar.TabIndex = 2
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Image = Global.Super_Pos.My.Resources.Resources.nuevo24
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(33, 195)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(67, 45)
        Me.btnnuevo.TabIndex = 21
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'FrmClienteMant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 561)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvcliente)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmClienteMant"
        Me.Text = "Mantenimiento de Cliente"
        CType(Me.dgvcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents txtbuscar As TextBox
    Public WithEvents dgvcliente As DataGridView
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
    Public WithEvents txtnombre As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtrtn As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents Label3 As Label
    Public WithEvents txtcodcliente As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents btnnuevo As Button
End Class
