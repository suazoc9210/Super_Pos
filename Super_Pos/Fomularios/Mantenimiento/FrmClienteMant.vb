Imports System.Data.SqlClient

Public Class FrmClienteMant

    Inherits FrmPlantillaMant
    Dim dypl As New SqlConnection(My.Settings.SuperPos)
    'Dim dypl As New SqlConnection("Data Source=LAPTOP-S4BOKKCN\SQLEXPRESS;Initial Catalog=SuperPos;Integrated Security=True")
    Sub limpiar()
        txtcodcliente.Clear()
        txtrtn.Clear()
        txtnombre.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()
        txtemail.Clear()
        txtcodcliente.Focus()
    End Sub
    Sub bloquear_text()
        txtcodcliente.Enabled = False
        txtrtn.Enabled = False
        txtnombre.Enabled = False
        txtdireccion.Enabled = False
        txttelefono.Enabled = False
        txtemail.Enabled = False
    End Sub
    Sub desbloquear_text()
        txtrtn.Enabled = True
        txtcodcliente.Enabled = True
        txtnombre.Enabled = True
        txtdireccion.Enabled = True
        txttelefono.Enabled = True
        txtemail.Enabled = True

    End Sub
    Sub llenargridclientes()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        dypl.Open()
        Try
            DA = New SqlDataAdapter("select*from cliente", dypl)
            DA.Fill(DT)
            dgvcliente.DataSource = DT
            dypl.Close()
        Catch ex As Exception

        End Try
    End Sub
    Sub llenargridfiltro()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        dypl.Open()
        Try
            DA = New SqlDataAdapter("select * from cliente where nombre like '%" & txtbuscar.Text & "%'", dypl)
            DA.Fill(DT)
            dgvcliente.DataSource = DT
            dypl.Close()
        Catch ex As Exception

        End Try
    End Sub
    Sub guardar()
        dypl.Open()
        Dim cmd As New SqlCommand("spcliente", dypl)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 1)
        cmd.Parameters.AddWithValue("@cod_cliente", txtcodcliente.Text)
        cmd.Parameters.AddWithValue("@rtn", txtrtn.Text)
        cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
        cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
        cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
        cmd.Parameters.AddWithValue("@email", txtemail.Text)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Cliente Creado Correctamente")
        dypl.Close()
    End Sub
    Sub actualizar()
        dypl.Open()
        Dim cmd As New SqlCommand("spcliente", dypl)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 2)
        cmd.Parameters.AddWithValue("@cod_cliente", txtcodcliente.Text)
        cmd.Parameters.AddWithValue("@rtn", txtrtn.Text)
        cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
        cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
        cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
        cmd.Parameters.AddWithValue("@email", txtemail.Text)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Cliente Actualizado Correctamente")
        dypl.Close()
    End Sub


    Private Sub FrmClienteMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenargridclientes()
    End Sub

    Private Sub dgvcliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcliente.CellContentClick
        If dgvcliente.RowCount > 0 Then
            Dim linea As Int16 = Val(Me.dgvcliente.CurrentRow.Index.ToString)
            txtcodcliente.Text = Me.dgvcliente("cod_cliente", linea).Value.ToString
            txtrtn.Text = Me.dgvcliente("rtn", linea).Value.ToString
            txtnombre.Text = Me.dgvcliente("nombre", linea).Value.ToString
            txtdireccion.Text = dgvcliente("Direccion", linea).Value.ToString
            txttelefono.Text = Me.dgvcliente("telefono", linea).Value.ToString
            txtemail.Text = dgvcliente("email", linea).Value.ToString
            desbloquear_text()
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        desbloquear_text()
        limpiar()
        btnactualizar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        guardar()
        limpiar()
        bloquear_text()
        btnactualizar.Enabled = True
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
        llenargridclientes()


    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If txtcodcliente.Text = "" Or txtnombre.Text = "" Then
            MessageBox.Show("Seleccione o Busque el registro que decea Actualizar")
        Else
            actualizar()
            limpiar()
            bloquear_text()
            btnactualizar.Enabled = True
            btnguardar.Enabled = False
            btnnuevo.Enabled = True
            btnactualizar.Enabled = False
            llenargridclientes()

        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        bloquear_text()
        btnactualizar.Enabled = True
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub txtcodcliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcodcliente.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtnombre.Focus()
        End If
    End Sub

    Private Sub txtnombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtrtn.Focus()
        End If
    End Sub


    Private Sub txtrtn_KeyUp(sender As Object, e As KeyEventArgs) Handles txtrtn.KeyUp
        If e.KeyCode = Keys.Enter Then
            txttelefono.Focus()
        End If
    End Sub


    Private Sub txttelefono_KeyUp(sender As Object, e As KeyEventArgs) Handles txttelefono.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtemail.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtdireccion.Focus()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        llenargridfiltro()
    End Sub
End Class