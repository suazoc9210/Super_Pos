<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimiento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckestado = New System.Windows.Forms.CheckBox()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnumempleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvasignaciones = New System.Windows.Forms.DataGridView()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvasignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mantenimiento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtserie)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ckestado)
        Me.GroupBox1.Controls.Add(Me.txtcomentario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtmarca)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtmodelo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnumempleado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 133)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del mantenimiento"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(124, 102)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(137, 20)
        Me.txtserie.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(513, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Estado:"
        '
        'ckestado
        '
        Me.ckestado.AutoSize = True
        Me.ckestado.Location = New System.Drawing.Point(583, 105)
        Me.ckestado.Name = "ckestado"
        Me.ckestado.Size = New System.Drawing.Size(217, 17)
        Me.ckestado.TabIndex = 12
        Me.ckestado.Text = "Marcado: Activo - Desmarcado: Inactivo"
        Me.ckestado.UseVisualStyleBackColor = True
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(582, 50)
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(326, 49)
        Me.txtcomentario.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(513, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Comentario:"
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(124, 50)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(137, 20)
        Me.txtmarca.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Serie:"
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(124, 76)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(137, 20)
        Me.txtmodelo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Modelo:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtname.Location = New System.Drawing.Point(267, 24)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(641, 20)
        Me.txtname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca:"
        '
        'txtnumempleado
        '
        Me.txtnumempleado.Location = New System.Drawing.Point(124, 24)
        Me.txtnumempleado.Name = "txtnumempleado"
        Me.txtnumempleado.Size = New System.Drawing.Size(137, 20)
        Me.txtnumempleado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Numero de Empleado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Escriba para buscar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Lista"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(141, 270)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtbuscar.TabIndex = 30
        '
        'dgvasignaciones
        '
        Me.dgvasignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvasignaciones.Location = New System.Drawing.Point(12, 296)
        Me.dgvasignaciones.Name = "dgvasignaciones"
        Me.dgvasignaciones.Size = New System.Drawing.Size(919, 253)
        Me.dgvasignaciones.TabIndex = 31
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.Super_Pos.My.Resources.Resources.salir24
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(864, 193)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 45)
        Me.btnsalir.TabIndex = 28
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Enabled = False
        Me.btncancelar.Image = Global.Super_Pos.My.Resources.Resources.descartar
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(163, 193)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 45)
        Me.btncancelar.TabIndex = 27
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Enabled = False
        Me.btnactualizar.Image = Global.Super_Pos.My.Resources.Resources.editar24
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnactualizar.Location = New System.Drawing.Point(90, 193)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(67, 45)
        Me.btnactualizar.TabIndex = 26
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Image = Global.Super_Pos.My.Resources.Resources.guardar24
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(17, 193)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(67, 45)
        Me.btnguardar.TabIndex = 25
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'FrmMantenimiento
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(943, 561)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvasignaciones)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimiento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvasignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label1 As Label
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents btnsalir As Button
    Public WithEvents btncancelar As Button
    Public WithEvents btnactualizar As Button
    Public WithEvents btnguardar As Button
    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents txtbuscar As TextBox
    Public WithEvents dgvasignaciones As DataGridView
    Public WithEvents txtcomentario As TextBox
    Public WithEvents txtserie As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents ckestado As CheckBox
    Public WithEvents Label5 As Label
    Public WithEvents txtmarca As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtmodelo As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtname As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtnumempleado As TextBox
    Public WithEvents Label2 As Label
End Class
