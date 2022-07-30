Imports System.Data.SqlClient

Public Class FrmProductoMant

    Inherits FrmPlantillaMant

    Private Sub FrmProductoMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardgv()
    End Sub

    Sub llenardgv()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT A.cod_barra, A.nombre, A.precio, A.costo_total,
                 B.descripcion AS 'tipo_isv', A.stock FROM productos A JOIN tipo_isv B 
                on A.tipo_isv = B.cod_isv", con)
            DA.Fill(DT)
            dgvproducto.DataSource = DT
            dgvproducto.Columns("cod_barra").HeaderText = "Código de barra"
            dgvproducto.Columns("cod_barra").Width = 150
            dgvproducto.Columns("nombre").HeaderText = "Descripción"
            dgvproducto.Columns("nombre").Width = 405
            dgvproducto.Columns("precio").HeaderText = "Precio"
            dgvproducto.Columns("precio").Width = 80
            dgvproducto.Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvproducto.Columns("costo_total").HeaderText = "Costo"
            dgvproducto.Columns("costo_total").Width = 80
            dgvproducto.Columns("costo_total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvproducto.Columns("tipo_isv").HeaderText = "Tipo Isv"
            dgvproducto.Columns("tipo_isv").Width = 80
            dgvproducto.Columns("stock").HeaderText = "Existencia"
            dgvproducto.Columns("stock").Width = 80
            dgvproducto.Columns("stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception

        End Try
    End Sub

End Class