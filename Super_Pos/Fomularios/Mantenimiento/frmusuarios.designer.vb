<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusuarios
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvusuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtconfirmar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcod_permiso = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckestado = New System.Windows.Forms.CheckBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcod_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Escriba para buscar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Lista de Clientes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(137, 243)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtbuscar.TabIndex = 18
        '
        'dgvusuarios
        '
        Me.dgvusuarios.AllowUserToAddRows = False
        Me.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuarios.Location = New System.Drawing.Point(8, 269)
        Me.dgvusuarios.Name = "dgvusuarios"
        Me.dgvusuarios.Size = New System.Drawing.Size(564, 283)
        Me.dgvusuarios.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtconfirmar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtcod_permiso)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ckestado)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtcontraseña)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcod_usuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 111)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                                                                                 " &
    "                     "
        '
        'txtconfirmar
        '
        Me.txtconfirmar.Enabled = False
        Me.txtconfirmar.Location = New System.Drawing.Point(416, 50)
        Me.txtconfirmar.Name = "txtconfirmar"
        Me.txtconfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmar.Size = New System.Drawing.Size(137, 20)
        Me.txtconfirmar.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(287, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Confirmar Contraseña"
        '
        'txtcod_permiso
        '
        Me.txtcod_permiso.Enabled = False
        Me.txtcod_permiso.Location = New System.Drawing.Point(120, 76)
        Me.txtcod_permiso.Name = "txtcod_permiso"
        Me.txtcod_permiso.Size = New System.Drawing.Size(137, 20)
        Me.txtcod_permiso.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(287, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Estado:"
        '
        'ckestado
        '
        Me.ckestado.AutoSize = True
        Me.ckestado.Enabled = False
        Me.ckestado.Location = New System.Drawing.Point(336, 79)
        Me.ckestado.Name = "ckestado"
        Me.ckestado.Size = New System.Drawing.Size(217, 17)
        Me.ckestado.TabIndex = 12
        Me.ckestado.Text = "Marcado: Activo - Desmarcado: Inactivo"
        Me.ckestado.UseVisualStyleBackColor = True
        '
        'txtusuario
        '
        Me.txtusuario.Enabled = False
        Me.txtusuario.Location = New System.Drawing.Point(120, 50)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(137, 20)
        Me.txtusuario.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Codigo de Permiso:"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Enabled = False
        Me.txtcontraseña.Location = New System.Drawing.Point(416, 24)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(137, 20)
        Me.txtcontraseña.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'txtcod_usuario
        '
        Me.txtcod_usuario.Enabled = False
        Me.txtcod_usuario.Location = New System.Drawing.Point(120, 24)
        Me.txtcod_usuario.Name = "txtcod_usuario"
        Me.txtcod_usuario.Size = New System.Drawing.Size(137, 20)
        Me.txtcod_usuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Registrar Usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.Super_Pos.My.Resources.Resources.salir24
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(317, 166)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 45)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.Super_Pos.My.Resources.Resources.descartar
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(244, 166)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 45)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Image = Global.Super_Pos.My.Resources.Resources.editar24
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnactualizar.Location = New System.Drawing.Point(171, 166)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(67, 45)
        Me.btnactualizar.TabIndex = 13
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Image = Global.Super_Pos.My.Resources.Resources.guardar24
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(98, 166)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(67, 45)
        Me.btnguardar.TabIndex = 12
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Image = Global.Super_Pos.My.Resources.Resources.nuevo24
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(26, 166)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(67, 45)
        Me.btnnuevo.TabIndex = 20
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'frmusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvusuarios)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmusuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Usuarios"
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents txtbuscar As TextBox
    Public WithEvents dgvusuarios As DataGridView
    Public WithEvents btnsalir As Button
    Public WithEvents btncancelar As Button
    Public WithEvents btnactualizar As Button
    Public WithEvents btnguardar As Button
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents txtconfirmar As TextBox
    Public WithEvents Label10 As Label
    Public WithEvents txtcod_permiso As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents ckestado As CheckBox
    Public WithEvents txtusuario As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtcontraseña As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents Label3 As Label
    Public WithEvents txtcod_usuario As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents btnnuevo As Button
End Class
