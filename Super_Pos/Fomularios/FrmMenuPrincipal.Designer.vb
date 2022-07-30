<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreciónDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrasladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RangoFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ToolStripSeparator2, Me.DepartamentosToolStripMenuItem, Me.ToolStripSeparator3, Me.ClientesToolStripMenuItem, Me.ToolStripSeparator4, Me.ProveedoresToolStripMenuItem, Me.ToolStripSeparator5, Me.UsuariosToolStripMenuItem, Me.ToolStripSeparator7, Me.ConfiguraciónToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.Super_Pos.My.Resources.Resources.completo
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(152, 6)
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Image = Global.Super_Pos.My.Resources.Resources.departamento161
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(152, 6)
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.Super_Pos.My.Resources.Resources.cliente16
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(152, 6)
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.Super_Pos.My.Resources.Resources.vendedor16
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(152, 6)
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(152, 6)
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.InventarioToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VentasToolStripMenuItem.Text = "Caja"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorreciónDeInventarioToolStripMenuItem, Me.EntradasToolStripMenuItem, Me.SalidasToolStripMenuItem, Me.TrasladosToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'CorreciónDeInventarioToolStripMenuItem
        '
        Me.CorreciónDeInventarioToolStripMenuItem.Name = "CorreciónDeInventarioToolStripMenuItem"
        Me.CorreciónDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CorreciónDeInventarioToolStripMenuItem.Text = "Correción de Inventario"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas "
        '
        'SalidasToolStripMenuItem
        '
        Me.SalidasToolStripMenuItem.Name = "SalidasToolStripMenuItem"
        Me.SalidasToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SalidasToolStripMenuItem.Text = "Salidas"
        '
        'TrasladosToolStripMenuItem
        '
        Me.TrasladosToolStripMenuItem.Name = "TrasladosToolStripMenuItem"
        Me.TrasladosToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TrasladosToolStripMenuItem.Text = "Traslados"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem1, Me.ComprasToolStripMenuItem1, Me.InventarioToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendedorToolStripMenuItem, Me.RangoFechasToolStripMenuItem})
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'RangoFechasToolStripMenuItem
        '
        Me.RangoFechasToolStripMenuItem.Name = "RangoFechasToolStripMenuItem"
        Me.RangoFechasToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RangoFechasToolStripMenuItem.Text = "Rango Fechas"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'InventarioToolStripMenuItem1
        '
        Me.InventarioToolStripMenuItem1.Name = "InventarioToolStripMenuItem1"
        Me.InventarioToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.InventarioToolStripMenuItem1.Text = "Inventario"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CorreciónDeInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrasladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RangoFechasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents FacturaToolStripMenuItem As ToolStripMenuItem
End Class
