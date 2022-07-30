Imports System.Data.SqlClient
Public Class FrmDepartamentoMant


    Inherits FrmPlantillaMant
    Dim estado As Int16

    Private Sub FrmDepartamentoMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardatagriddepartamento()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Sub limpiarcontroles()

        txtcoddepartamento.Enabled = True
        txtcoddepartamento.Clear()
        txtbuscar.Clear()
        txtdescripcion.Clear()
        ckestado.Checked = False

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarcontroles()
        btnactualizar.Enabled = False
        btnguardar.Enabled = False
        txtcoddepartamento.Enabled = True
        txtcoddepartamento.Focus()
    End Sub

    Sub conexion()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT cod_departamento,nom_grupo,estado FROM departamento", con)
            DA.Fill(DT)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim con As SqlConnection = New SqlConnection(My.Settings.SuperPos)
        Dim cmd As SqlCommand = New SqlCommand("spDepartamento", con)
        con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 1)
        cmd.Parameters.AddWithValue("@cod_departamento", txtcoddepartamento.Text)
        cmd.Parameters.AddWithValue("@nom_grupo", txtdescripcion.Text)
        cmd.Parameters.AddWithValue("@estado", estado)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Departamento Creado Correctamente")
        limpiarcontroles()
        llenardatagriddepartamento()

    End Sub

    Private Sub txtcoddepartamento_Leave(sender As Object, e As EventArgs) Handles txtcoddepartamento.Leave


        Dim con As New SqlClient.SqlConnection(My.Settings.SuperPos)
            con.Open()
            Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM departamento where cod_departamento = '" & txtcoddepartamento.Text & "' ", con)
        reader = cmd.ExecuteReader

        If reader.Read Then
            btnactualizar.Enabled = True
            txtcoddepartamento.Enabled = False
            txtdescripcion.Text = reader.Item("nom_grupo")
            If reader.Item("estado") = True Then
                ckestado.Checked = True
            Else
                ckestado.Checked = False
            End If
        Else
            btnguardar.Enabled = True
            txtcoddepartamento.Enabled = False
        End If
    End Sub

    Private Sub txtcoddepartamento_TextChanged(sender As Object, e As EventArgs) Handles txtcoddepartamento.TextChanged
        If txtcoddepartamento.TextLength > 0 Then
            btncancelar.Enabled = True
        ElseIf txtcoddepartamento.TextLength = 0 Then
            btncancelar.Enabled = False
        End If
    End Sub

    Private Sub txtcoddepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoddepartamento.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ckestado_CheckedChanged(sender As Object, e As EventArgs) Handles ckestado.CheckedChanged
        If ckestado.Checked = True Then
            estado = 1
        Else
            estado = 0
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Dim con As SqlConnection = New SqlConnection(My.Settings.SuperPos)
        Dim cmd As SqlCommand = New SqlCommand("spDepartamento", con)
        con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 2)
        cmd.Parameters.AddWithValue("@cod_departamento", txtcoddepartamento.Text)
        cmd.Parameters.AddWithValue("@nom_grupo", txtdescripcion.Text)
        cmd.Parameters.AddWithValue("@estado", estado)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Actualizo Correctamente")
        limpiarcontroles()
        llenardatagriddepartamento()
        btnactualizar.Enabled = False
    End Sub

    Sub llenardatagriddepartamento()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT cod_departamento,nom_grupo,estado FROM departamento", con)
            DA.Fill(DT)
            dgvDepartamento.DataSource = DT
        Catch ex As Exception

        End Try
    End Sub

    Sub llenardatagridFiltrado()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT cod_departamento,nom_grupo,estado FROM departamento  where nom_grupo like '%" & txtbuscar.Text & "%'", con)
            DA.Fill(DT)
            dgvDepartamento.DataSource = DT
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDepartamento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartamento.CellClick
        If dgvDepartamento.RowCount > 0 Then
            Dim Linea As Int16 = Val(Me.dgvDepartamento.CurrentRow.Index.ToString)
            txtcoddepartamento.Text = Me.dgvDepartamento("cod_departamento", Linea).Value.ToString
            txtdescripcion.Text = Me.dgvDepartamento("nom_grupo", Linea).Value.ToString
            If Me.dgvDepartamento("estado", Linea).Value = True Then
                ckestado.Checked = True
            Else
                ckestado.Checked = False
            End If
            btnguardar.Enabled = False
            btnactualizar.Enabled = True
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        llenardatagridFiltrado()
    End Sub
End Class