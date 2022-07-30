Public Class FrmMenuPrincipal
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmClienteMant.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        FrmProductoMant.ShowDialog()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        FrmDepartamentoMant.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FrmProveedorMant.ShowDialog()
    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        FrmAlmacenMant.ShowDialog()
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        FrmConfiguracionMant.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmusuarios.ShowDialog()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        FrmFacturaTran.ShowDialog()
    End Sub
End Class