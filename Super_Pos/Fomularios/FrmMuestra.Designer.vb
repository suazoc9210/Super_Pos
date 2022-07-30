<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMuestra
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
        Me.Tsp_Menu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar2 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tsp_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tsp_Menu
        '
        Me.Tsp_Menu.AllowDrop = True
        Me.Tsp_Menu.AutoSize = False
        Me.Tsp_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnEditar, Me.ToolStripSeparator2, Me.btnGuardar, Me.ToolStripSeparator3, Me.btnBuscar, Me.ToolStripSeparator4, Me.btnCancelar, Me.ToolStripSeparator5, Me.btnEliminar, Me.btnSalir})
        Me.Tsp_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Tsp_Menu.Name = "Tsp_Menu"
        Me.Tsp_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Tsp_Menu.Size = New System.Drawing.Size(1056, 44)
        Me.Tsp_Menu.TabIndex = 0
        Me.Tsp_Menu.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 44)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Otros Botones"
        '
        'btnCancelar2
        '
        Me.btnCancelar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar2.Image = Global.Super_Pos.My.Resources.Resources.descartar
        Me.btnCancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar2.Location = New System.Drawing.Point(46, 396)
        Me.btnCancelar2.Name = "btnCancelar2"
        Me.btnCancelar2.Size = New System.Drawing.Size(88, 32)
        Me.btnCancelar2.TabIndex = 6
        Me.btnCancelar2.Text = "Cancelar"
        Me.btnCancelar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.Super_Pos.My.Resources.Resources.imprimirfactura24
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(148, 358)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(88, 32)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Image = Global.Super_Pos.My.Resources.Resources.cobrar24
        Me.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCobrar.Location = New System.Drawing.Point(46, 358)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(88, 32)
        Me.btnCobrar.TabIndex = 4
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Image = Global.Super_Pos.My.Resources.Resources.quitar32
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(148, 320)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(88, 32)
        Me.btnQuitar.TabIndex = 3
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.Super_Pos.My.Resources.Resources.agregar24
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(46, 320)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(88, 32)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Super_Pos.My.Resources.Resources.nuevo24
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(68, 41)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = Global.Super_Pos.My.Resources.Resources.editar24
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 41)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Super_Pos.My.Resources.Resources.guardar24
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(77, 41)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Super_Pos.My.Resources.Resources.buscar24
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(68, 41)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.Super_Pos.My.Resources.Resources.cancelar24
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 41)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Super_Pos.My.Resources.Resources.eliminar24
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(79, 41)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Super_Pos.My.Resources.Resources.salir24
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(55, 41)
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Etiqueta para titulos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Etiqueta para control"
        '
        'FrmMuestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1056, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tsp_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMuestra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salir"
        Me.Tsp_Menu.ResumeLayout(False)
        Me.Tsp_Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tsp_Menu As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnCancelar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnCobrar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCancelar2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
