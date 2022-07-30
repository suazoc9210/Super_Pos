<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartamentoMant
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
        Me.dgvDepartamento = New System.Windows.Forms.DataGridView()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckestado = New System.Windows.Forms.CheckBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcoddepartamento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Escriba para buscar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Lista de Departamentos"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(140, 217)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtbuscar.TabIndex = 18
        '
        'dgvDepartamento
        '
        Me.dgvDepartamento.AllowUserToAddRows = False
        Me.dgvDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartamento.Location = New System.Drawing.Point(11, 243)
        Me.dgvDepartamento.Name = "dgvDepartamento"
        Me.dgvDepartamento.Size = New System.Drawing.Size(919, 306)
        Me.dgvDepartamento.TabIndex = 19
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.Super_Pos.My.Resources.Resources.salir24
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(863, 140)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 45)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Enabled = False
        Me.btncancelar.Image = Global.Super_Pos.My.Resources.Resources.descartar
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(162, 140)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 45)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Enabled = False
        Me.btnactualizar.Image = Global.Super_Pos.My.Resources.Resources.editar24
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnactualizar.Location = New System.Drawing.Point(89, 140)
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
        Me.btnguardar.Location = New System.Drawing.Point(16, 140)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(67, 45)
        Me.btnguardar.TabIndex = 12
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ckestado)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcoddepartamento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 81)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(615, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Estado:"
        '
        'ckestado
        '
        Me.ckestado.AutoSize = True
        Me.ckestado.Location = New System.Drawing.Point(691, 53)
        Me.ckestado.Name = "ckestado"
        Me.ckestado.Size = New System.Drawing.Size(217, 17)
        Me.ckestado.TabIndex = 21
        Me.ckestado.Text = "Marcado: Activo - Desmarcado: Inactivo"
        Me.ckestado.UseVisualStyleBackColor = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(141, 50)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(335, 20)
        Me.txtdescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción:"
        '
        'txtcoddepartamento
        '
        Me.txtcoddepartamento.Location = New System.Drawing.Point(141, 24)
        Me.txtcoddepartamento.MaxLength = 6
        Me.txtcoddepartamento.Name = "txtcoddepartamento"
        Me.txtcoddepartamento.Size = New System.Drawing.Size(137, 20)
        Me.txtcoddepartamento.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código de departamento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mantenimiento de Departamentos"
        '
        'FrmDepartamentoMant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 561)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvDepartamento)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDepartamentoMant"
        Me.Text = "Mantenimiento de Deparamento"
        CType(Me.dgvDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents txtbuscar As TextBox
    Public WithEvents dgvDepartamento As DataGridView
    Public WithEvents btnsalir As Button
    Public WithEvents btncancelar As Button
    Public WithEvents btnactualizar As Button
    Public WithEvents btnguardar As Button
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents Label7 As Label
    Public WithEvents ckestado As CheckBox
    Public WithEvents txtdescripcion As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtcoddepartamento As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
End Class
