Imports System.Data.SqlClient

Public Class FrmConfiguracionMant

    ''VARIABLES GLOBALES
    Dim bandera As Int16

    ''METODOS
    Sub llenardgvcai()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT A.n_cai, A.prefijo, B.correlativo, A.rango_autorizado_inicio, 
                                    A.rango_autorizado_fin, A.vencimiento
                                    FROM reg_CAI A JOIN correlativos B on A.id_correlativos = B.id 
                                    ORDER BY A.vencimiento ASC", con)
            DA.Fill(DT)
            dgvcai.DataSource = DT
            dgvcai.Columns("n_cai").HeaderText = "CAI"
            dgvcai.Columns("n_cai").Width = 200
            dgvcai.Columns("prefijo").HeaderText = "Prefijo"
            dgvcai.Columns("prefijo").Width = 80
            dgvcai.Columns("correlativo").HeaderText = "Correlativo"
            dgvcai.Columns("correlativo").Width = 80
            dgvcai.Columns("rango_autorizado_inicio").HeaderText = "Inicio"
            dgvcai.Columns("rango_autorizado_inicio").Width = 80
            dgvcai.Columns("rango_autorizado_fin").HeaderText = "Fin"
            dgvcai.Columns("rango_autorizado_fin").Width = 80
            dgvcai.Columns("vencimiento").HeaderText = "Vencimiento"
            dgvcai.Columns("vencimiento").Width = 80
        Catch ex As Exception

        End Try
    End Sub

    Sub llenardgvisv()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable
        Dim con As New SqlConnection(My.Settings.SuperPos)
        Try
            DA = New SqlDataAdapter("SELECT cod_isv, descripcion from tipo_isv", con)
            DA.Fill(DT)
            dgvisv.DataSource = DT
            dgvisv.Columns("cod_isv").HeaderText = "Código ISV"
            dgvisv.Columns("cod_isv").Width = 80
            dgvisv.Columns("descripcion").HeaderText = "Descripcion"
            dgvisv.Columns("descripcion").Width = 80
        Catch ex As Exception

        End Try
    End Sub

    Sub limpiar()
        If tbcconfig.SelectedTab Is tbpempresa Then
            comprobarempresa()
        ElseIf tbcconfig.SelectedTab Is tbpcai Then
            MessageBox.Show("estas en cai")
        ElseIf tbcconfig.SelectedTab Is tbpimpuestos Then
            txtcodisv.Clear()
            txtdescripisv.Clear()
            txtcodisv.Enabled = True
            txtcodisv.Focus()
        End If
    End Sub

    Sub comprobarempresa()
        If tbcconfig.SelectedTab Is tbpempresa Then
            Dim con As New SqlClient.SqlConnection(My.Settings.SuperPos)
            con.Open()
            Dim reader As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM empresa", con)
            reader = cmd.ExecuteReader

            If reader.Read Then
                txtempresa.Focus()
                txtcodempresa.Enabled = False
                txtcodempresa.Text = reader.Item("cod_empresa")
                txtempresa.Text = reader.Item("nombre")
                txtrtn.Text = reader.Item("rtn")
                txtpropietario.Text = reader.Item("propietario")
                txtdireccion.Text = reader.Item("direccion")
                txttelefono.Text = reader.Item("telefono")
                txtcorreo.Text = reader.Item("correo")
                txtpiefact.Text = reader.Item("pie_fact")

                bandera = 2
            ElseIf Not reader.Read Then
                btnguardar.Enabled = True
                Dim op As Integer = MessageBox.Show("No se ha creado la empresa ¿desea crearla?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If op = 7 Then
                    Me.Close()
                End If

                bandera = 1
            End If
        End If

    End Sub


    ''BOTONES
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If tbcconfig.SelectedTab Is tbpempresa Then
            Dim con As SqlConnection = New SqlConnection(My.Settings.SuperPos)
            Dim cmd As SqlCommand = New SqlCommand("spEmpresa", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            If bandera = 1 Then
                txtcodempresa.Focus()
                cmd.Parameters.AddWithValue("@bandera", bandera)
                cmd.Parameters.AddWithValue("@cod_empresa", txtcodempresa.Text)
                cmd.Parameters.AddWithValue("@nombre", txtempresa.Text)
                cmd.Parameters.AddWithValue("@rtn", txtrtn.Text)
                cmd.Parameters.AddWithValue("@propietario", txtpropietario.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
                cmd.Parameters.AddWithValue("@pie_fact", txtpiefact.Text)
                cmd.ExecuteNonQuery()
                txtcodempresa.Enabled = False
                txtempresa.Focus()
                bandera = 2
            ElseIf bandera = 2 Then
                cmd.Parameters.AddWithValue("@bandera", bandera)
                cmd.Parameters.AddWithValue("@cod_empresa", txtcodempresa.Text)
                cmd.Parameters.AddWithValue("@nombre", txtempresa.Text)
                cmd.Parameters.AddWithValue("@rtn", txtrtn.Text)
                cmd.Parameters.AddWithValue("@propietario", txtpropietario.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
                cmd.Parameters.AddWithValue("@pie_fact", txtpiefact.Text)
                cmd.ExecuteNonQuery()
                txtcodempresa.Enabled = False
                txtempresa.Focus()
            End If
        ElseIf tbcconfig.SelectedTab Is tbpcai Then
            Dim con As SqlConnection = New SqlConnection(My.Settings.SuperPos)
            Dim cmd As SqlCommand = New SqlCommand("spreg_CAI", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            If bandera = 1 Then
                txtcodempresa.Focus()
                cmd.Parameters.AddWithValue("@bandera", bandera)
                cmd.Parameters.AddWithValue("@n_cai", txtcai.Text)
                cmd.Parameters.AddWithValue("@prefijo", txtprefijo.Text)
                cmd.Parameters.AddWithValue("@rango_autorizado_inicio", txtrangautin.Text)
                cmd.Parameters.AddWithValue("@rango_autorizado_fin", txtrangautfin.Text)
                cmd.Parameters.AddWithValue("@vencimiento", dtvencimiento.Value)
                cmd.ExecuteNonQuery()
                bandera = 2
            ElseIf bandera = 2 Then
                cmd.Parameters.AddWithValue("@bandera", bandera)
                cmd.Parameters.AddWithValue("@n_cai", txtcai.Text)
                cmd.Parameters.AddWithValue("@prefijo", txtprefijo.Text)
                cmd.Parameters.AddWithValue("@rango_autorizado_inicio", txtrangautin.Text)
                cmd.Parameters.AddWithValue("@rango_autorizado_fin", txtrangautfin.Text)
                cmd.Parameters.AddWithValue("@vencimiento", dtvencimiento.Value)
                cmd.ExecuteNonQuery()
            End If
        ElseIf tbcconfig.SelectedTab Is tbpimpuestos Then
            MessageBox.Show("estas en impuestos")
            Dim con As SqlConnection = New SqlConnection(My.Settings.SuperPos)
            Dim cmd As SqlCommand = New SqlCommand("spTipoIsv", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            If bandera = 1 Then
                cmd.Parameters.AddWithValue("@bandera", bandera)
                cmd.Parameters.AddWithValue("@cod_isv", txtcodisv.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtdescripisv.Text)
                cmd.ExecuteNonQuery()
                llenardgvisv()
            ElseIf bandera = 2 Then
                cmd.Parameters.AddWithValue("@bandera", bandera)
                cmd.Parameters.AddWithValue("@cod_isv", txtcodisv.Text)
                cmd.Parameters.AddWithValue("@descripcion", txtdescripisv.Text)
                cmd.ExecuteNonQuery()
                llenardgvisv()
                bandera = 1
            End If
            limpiar()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    ''EVENTOS

    Private Sub FrmConfiguracionMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardgvcai()
        llenardgvisv()
        comprobarempresa()
    End Sub

    Private Sub tbcconfig_Selected(sender As Object, e As TabControlEventArgs) Handles tbcconfig.Selected

        If tbcconfig.SelectedTab Is tbpcai Then

            Dim con As New SqlClient.SqlConnection(My.Settings.SuperPos)
            con.Open()
            Dim reader As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM reg_CAI", con)
            reader = cmd.ExecuteReader

            If reader.Read Then
                txtcai.Focus()
                txtcai.Text = reader.Item("n_cai")
                txtprefijo.Text = reader.Item("prefijo")
                txtrangautin.Text = reader.Item("rango_autorizado_inicio")
                txtrangautfin.Text = reader.Item("rango_autorizado_fin")
                dtvencimiento.Value = reader.Item("vencimiento")
                bandera = 2
            Else
                btnguardar.Enabled = True
                Dim op As Integer = MessageBox.Show("No se ha registrado CAI de la empresa ¿desea registrarlo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If op = 7 Then
                    tbcconfig.SelectedTab = tbpempresa
                End If

                bandera = 1
            End If
        End If

    End Sub

    Private Sub dgvisv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvisv.CellClick
        If dgvisv.RowCount > 0 Then
            Dim linea As Int16 = Val(Me.dgvisv.CurrentRow.Index.ToString)
            txtcodisv.Text = Me.dgvisv("cod_isv", linea).Value.ToString
            txtdescripisv.Text = Me.dgvisv("descripcion", linea).Value.ToString
            txtcodisv.Enabled = False
            txtbuscar.Clear()
            bandera = 2
            MessageBox.Show("esto tiene bandera " & bandera)
        End If
    End Sub
End Class