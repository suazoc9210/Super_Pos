Imports System.Data.SqlClient
Public Class frmusuarios
    Dim dypl As New SqlConnection(My.Settings.SuperPos)
    ''Dim con As New SqlClient.SqlConnection(My.Settings.SuperPos)
    Dim estado As Integer
    Sub limpiar()
        txtcod_usuario.Clear()
        txtusuario.Clear()
        txtcontraseña.Clear()
        txtconfirmar.Clear()
        txtcod_permiso.Clear()
        txtcod_usuario.Focus()

    End Sub
    Sub bloquear_text()
        txtcod_usuario.Enabled = False
        txtusuario.Enabled = False
        txtcontraseña.Enabled = False
        txtconfirmar.Enabled = False
        txtcod_permiso.Enabled = False
        ckestado.Enabled = False
    End Sub
    Sub desbloquear_text()
        txtcod_usuario.Enabled = True
        txtusuario.Enabled = True
        txtcontraseña.Enabled = True
        txtconfirmar.Enabled = True
        txtcod_permiso.Enabled = True
        ckestado.Enabled = True

    End Sub
    Sub llenargridusuarios()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        dypl.Open()
        Try
            DA = New SqlDataAdapter("select*from usuario", dypl)
            DA.Fill(DT)
            dgvusuarios.DataSource = DT
            dypl.Close()
        Catch ex As Exception

        End Try
    End Sub
    Sub llenargridusuariosfiltro()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        dypl.Open()
        Try
            DA = New SqlDataAdapter("select*from usuario  where usuario Like '%" & txtbuscar.Text & "%'", dypl)
            DA.Fill(DT)
            dgvusuarios.DataSource = DT
            dypl.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub guardar()
        dypl.Open()
        Dim cmd As New SqlCommand("spusuario", dypl)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 1)
        cmd.Parameters.AddWithValue("@cod_usuario", txtcod_usuario.Text)
        cmd.Parameters.AddWithValue("@usuario", txtusuario.Text)
        cmd.Parameters.AddWithValue("@contraseña", txtcontraseña.Text)
        cmd.Parameters.AddWithValue("@cod_permiso", txtcod_permiso.Text)
        cmd.Parameters.AddWithValue("@estado", estado)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Usuario Creado Correctamente")
        dypl.Close()

    End Sub
    Sub actualizar()
        dypl.Open()
        Dim cmd As New SqlCommand("spusuario", dypl)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 2)
        cmd.Parameters.AddWithValue("@cod_usuario", txtcod_usuario.Text)
        cmd.Parameters.AddWithValue("@usuario", txtusuario.Text)
        cmd.Parameters.AddWithValue("@contraseña", txtcontraseña.Text)
        cmd.Parameters.AddWithValue("@cod_permiso", txtcod_permiso.Text)
        cmd.Parameters.AddWithValue("@estado", estado)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Usuario Actualizado Correctamente")
        dypl.Close()

    End Sub
    Private Sub frmusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenargridusuarios()
    End Sub

    Private Sub txtcod_usuario_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcod_usuario.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtusuario.Focus()
        End If
    End Sub

    Private Sub txtusuario_KeyUp(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtcontraseña.Focus()
        End If
    End Sub


    Private Sub txtcontraseña_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcontraseña.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtconfirmar.Focus()
        End If
    End Sub

    Private Sub txtconfirmar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtconfirmar.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtconfirmar.Text = txtcontraseña.Text Then
                txtcod_permiso.Focus()
            Else
                MessageBox.Show("ContraseÑa no coincide")
            End If

        End If

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        desbloquear_text()
        limpiar()
        btnactualizar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        bloquear_text()
        btnactualizar.Enabled = True
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub


    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If txtcod_permiso.Text = "" Or txtusuario.Text = "" Or txtcontraseña.Text = "" Then
            MessageBox.Show("Seleccione o Busque el registro que decea Actualizar")
        Else
            actualizar()
            limpiar()
            bloquear_text()
            btnactualizar.Enabled = True
            btnguardar.Enabled = False
            btnnuevo.Enabled = True
            'btnactualizar.Enabled = False
            llenargridusuarios()

        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtconfirmar.Text = txtcontraseña.Text Then
            guardar()
            limpiar()
            bloquear_text()
            btnactualizar.Enabled = True
            btnguardar.Enabled = False
            btnnuevo.Enabled = True
            llenargridusuarios()
        Else
            MessageBox.Show("ContraseÑa no coincide")
        End If

    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        llenargridusuariosfiltro()
    End Sub

    Private Sub ckestado_CheckedChanged(sender As Object, e As EventArgs) Handles ckestado.CheckedChanged
        If ckestado.Checked = True Then
            estado = "1"
        Else
            estado = "2"
        End If
    End Sub

    Private Sub dgvusuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuarios.CellClick
        If dgvusuarios.RowCount > 0 Then
            Dim linea As Int16 = Val(Me.dgvusuarios.CurrentRow.Index.ToString)
            txtcod_usuario.Text = Me.dgvusuarios("cod_usuario", linea).Value.ToString
            txtusuario.Text = Me.dgvusuarios("usuario", linea).Value.ToString
            txtcontraseña.Text = Me.dgvusuarios("contraseña", linea).Value.ToString
            txtcod_permiso.Text = Me.dgvusuarios("cod_permiso", linea).Value.ToString
            desbloquear_text()
            txtcod_usuario.Enabled = False
        End If
    End Sub
End Class