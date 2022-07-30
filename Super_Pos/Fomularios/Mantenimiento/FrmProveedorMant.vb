Imports System.Data.SqlClient
Public Class FrmProveedorMant

    Inherits FrmPlantillaMant
    Dim estado As Int16

    Private Sub FrmProveedorMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenargridproveedores()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Sub limpiarcontroles()

        txtcodproveedor.Clear()
        txtproveedor.Clear()
        txtrtn.Clear()
        txttelefono.Clear()
        txtemail.Clear()
        'ckestado.Checked = False
        txtcodproveedor.Focus()
        txtCiudad.Clear()
        txtdireccion.Clear()
        estado = 0
        txtnombrevendedor.Clear()
        txttelvendedor.Clear()
        txtemailvendedor.Clear()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarcontroles()
        btnactualizar.Enabled = False
        btnguardar.Enabled = False
        txtcodproveedor.Enabled = True
        txtcodproveedor.Focus()
    End Sub

    Sub conexion()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT cod_proveedor,rtn,nombre,direccion,telefono,ciudad,email,vendedor,tel_vendedor,email_vendedor FROM proveedor", con)
            DA.Fill(DT)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim con As SqlConnection = New SqlConnection(My.Settings.SuperPos)
        Dim cmd As SqlCommand = New SqlCommand("spProveedor", con)
        con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 1)
        cmd.Parameters.AddWithValue("@cod_proveedor", txtcodproveedor.Text)
        cmd.Parameters.AddWithValue("@rtn", txtrtn.Text)
        cmd.Parameters.AddWithValue("@nombre", txtproveedor.Text)
        cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
        cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
        cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text)
        cmd.Parameters.AddWithValue("@email", txtemail.Text)
        cmd.Parameters.AddWithValue("@vendedor", txtnombrevendedor.Text)
        cmd.Parameters.AddWithValue("@tel_vendedor", txttelvendedor.Text)
        cmd.Parameters.AddWithValue("@email_vendedor", txtemailvendedor.Text)
        ' cmd.Parameters.AddWithValue("@estado", estado)'
        cmd.ExecuteNonQuery()
        MessageBox.Show("Departamento Creado Correctamente")
        limpiarcontroles()
        llenargridproveedores()

    End Sub

    Private Sub txtcodproveedor_Leave(sender As Object, e As EventArgs) Handles txtcodproveedor.Leave
        Dim con As New SqlClient.SqlConnection(My.Settings.SuperPos)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM proveedor where cod_proveedor = '" & txtcodproveedor.Text & "' ", con)
        reader = cmd.ExecuteReader
        If reader.Read Then
            btnactualizar.Enabled = True
            txtcodproveedor.Enabled = False
            txtproveedor.Text = reader.Item("nombre")
            txtrtn.Text = reader.Item("rtn")
            txtdireccion.Text = reader.Item("direccion")
            txttelefono.Text = reader.Item("telefono")
            txtemail.Text = reader.Item("email")
            txtnombrevendedor.Text = reader.Item("vendedor")
            txttelvendedor.Text = reader.Item("tel_vendedor")
            txtemailvendedor.Text = reader.Item("email_vendedor")
            txtrtn.Text = reader.Item("rtn")
            txtCiudad.Text = reader.Item("ciudad")

            '    If reader.Item("estado") = True Then
            '        ckestado.Checked = True
            '    Else
            '        ckestado.Checked = False
            '    End If
            'Else
            '    btnguardar.Enabled = True
            '    txtcodproveedor.Enabled = False
        End If

    End Sub

    Private Sub txtcodproveedor_TextChanged(sender As Object, e As EventArgs) Handles txtcodproveedor.TextChanged
        If txtcodproveedor.TextLength > 0 Then
            btncancelar.Enabled = True
            btnguardar.Enabled = True
        ElseIf txtcodproveedor.TextLength = 0 Then
            btncancelar.Enabled = False
        End If
    End Sub

    Private Sub txtcodproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodproveedor.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ckestado_CheckedChanged(sender As Object, e As EventArgs)
        'If ckestado.Checked = True Then
        '    estado = 1
        'Else
        '    estado = 0
        'End If
    End Sub

    Private Sub txtrtn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrtn.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttelvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelvendedor.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Dim con As SqlConnection = New SqlConnection(My.Settings.SuperPos)
        Dim cmd As SqlCommand = New SqlCommand("spProveedor", con)
        con.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@bandera", 2)
        cmd.Parameters.AddWithValue("@cod_proveedor", txtcodproveedor.Text)
        cmd.Parameters.AddWithValue("@rtn", txtrtn.Text)
        cmd.Parameters.AddWithValue("@nombre", txtproveedor.Text)
        cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
        cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
        cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text)
        cmd.Parameters.AddWithValue("@email", txtemail.Text)
        cmd.Parameters.AddWithValue("@vendedor", txtnombrevendedor.Text)
        cmd.Parameters.AddWithValue("@tel_vendedor", txttelvendedor.Text)
        cmd.Parameters.AddWithValue("@email_vendedor", txtemailvendedor.Text)
        ' cmd.Parameters.AddWithValue("@estado", estado)'
        cmd.ExecuteNonQuery()
        MessageBox.Show("Actualziado Correctamente")
        limpiarcontroles()
        llenargridproveedores()
    End Sub

    Sub llenargridproveedores()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT * FROM proveedor", con)
            DA.Fill(DT)
            dgvproveedor.DataSource = DT
        Catch ex As Exception

        End Try
    End Sub

    Sub llenargridfiltrado()
        Dim DA As New SqlDataAdapter()
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT * FROM proveedor where nombre like '%" & txtbuscar.Text & "%'", con)
            DA.Fill(DT)
            dgvproveedor.DataSource = DT
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvproveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproveedor.CellClick
        If dgvproveedor.RowCount > 0 Then
            Dim Linea As Int16 = Val(Me.dgvproveedor.CurrentRow.Index.ToString)
            txtcodproveedor.Text = Me.dgvproveedor("cod_proveedor", Linea).Value.ToString
            txtproveedor.Text = Me.dgvproveedor("nombre", Linea).Value.ToString
            txtrtn.Text = Me.dgvproveedor("rtn", Linea).Value.ToString
            txttelefono.Text = Me.dgvproveedor("telefono", Linea).Value.ToString
            txtemail.Text = Me.dgvproveedor("email", Linea).Value.ToString
            txtdireccion.Text = Me.dgvproveedor("direccion", Linea).Value.ToString
            txtCiudad.Text = Me.dgvproveedor("ciudad", Linea).Value.ToString
            txtnombrevendedor.Text = Me.dgvproveedor("vendedor", Linea).Value.ToString
            txttelvendedor.Text = Me.dgvproveedor("tel_vendedor", Linea).Value.ToString
            txtemailvendedor.Text = Me.dgvproveedor("email_vendedor", Linea).Value.ToString
            btnactualizar.Enabled = True
            btnguardar.Enabled = False

        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        llenargridfiltrado()
    End Sub
End Class