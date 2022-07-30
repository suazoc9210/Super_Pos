Imports System.Data.SqlClient

Public Class FrmProductoMant

    Inherits FrmPlantillaMant

    Private Sub FrmProductoMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardgv()
        llenarcombodpto()
        llenarcomboisv()
        cmbtipoisv.SelectedItem = Nothing
        cmbdpto.SelectedItem = Nothing
    End Sub

    '' METODOS

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

    Sub llenardgvfiltrado()

    End Sub

    Sub llenarcombodpto()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT cod_departamento, nom_grupo FROM departamento", con)
            DA.Fill(DT)
            cmbdpto.DataSource = DT
            cmbdpto.DisplayMember = "nom_grupo"
            cmbdpto.ValueMember = "cod_departamento"
        Catch ex As Exception

        End Try

    End Sub

    Sub llenarcomboisv()
        Dim DA As New SqlDataAdapter()
        Dim Dt As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT * FROM tipo_isv", con)
            DA.Fill(Dt)
            cmbtipoisv.DataSource = Dt
            cmbtipoisv.DisplayMember = "descripcion"
            cmbtipoisv.ValueMember = "cod_isv"
        Catch ex As Exception

        End Try
    End Sub


    '' EVENTOS
    Private Sub txtcodproducto_TextChanged(sender As Object, e As EventArgs) Handles txtcodproducto.TextChanged
        If txtcodproducto.TextLength > 0 Then
            btncancelar.Enabled = True
        ElseIf txtcodproducto.TextLength = 0 Then
            btncancelar.Enabled = False
        End If
    End Sub

    Private Sub txtcodproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodproducto.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodproducto_Leave(sender As Object, e As EventArgs) Handles txtcodproducto.Leave
        If txtcodproducto.TextLength = 6 Then
            Dim con As New SqlClient.SqlConnection(My.Settings.SuperPos)
            con.Open()
            Dim reader As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM productos WHERE cod_producto = '" & txtcodproducto.Text & "'", con)
            reader = cmd.ExecuteReader

            If reader.Read Then
                btnactualizar.Enabled = True
                txtcodproducto.Enabled = False
                txtdescripcion.Text = reader.Item("nombre")
                '    txtnombre.Text = reader.Item("nombre")
                '    txtidusuario.Text = reader.Item("usuario")
                '    txtcontrasena.Text = reader.Item("contrasena")
                '    If reader.Item("estado") = True Then
                '        ckestado.Checked = True
                '    Else
                '        ckestado.Checked = False
                '    End If
                '    txtcorreo.Text = reader.Item("correo")
                '    cmbNivel.SelectedValue = reader.Item("nivelacceso")
                'Else
                '    btnguardar.Enabled = True
                '    txtnumempleado.Enabled = False
            End If
        End If
    End Sub
End Class