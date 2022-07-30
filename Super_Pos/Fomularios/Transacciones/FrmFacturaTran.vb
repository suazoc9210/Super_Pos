Public Class FrmFacturaTran


    Private Sub txtcodproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodproducto.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtcodproducto.Text.Length > 1 Then
                Dim con As New SqlClient.SqlConnection(My.Settings.SuperPos)
                con.Open()
                Dim reader As SqlClient.SqlDataReader
                Dim cmd As New SqlClient.SqlCommand("SELECT * FROM productos WHERE cod_barra = '" & txtcodproducto.Text & "'", con)
                reader = cmd.ExecuteReader

                If reader.Read Then
                    txtproducto.Text = reader.Item("nombre")
                    txtprecio.Text = reader.Item("precio")

                    Dim tipoisv As String = reader.Item("tipo_isv")
                    If tipoisv = "1" Then
                        lbltipoisv.Text = "E"
                    ElseIf tipoisv = "2" Then
                        lbltipoisv.Text = "G-15%"
                    ElseIf tipoisv = "3" Then
                        lbltipoisv.Text = "G-18%"
                    ElseIf tipoisv = "4" Then
                        lbltipoisv.Text = "Exo"
                    End If
                Else

                End If
            End If
        End If
    End Sub

    'Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
    '    Dim valordup As Boolean
    '    If dgvfact.RowCount > 0 Then
    '        For Each linea As DataGridViewRow In Me.dgvfact.Rows
    '            If linea.Cells(0).Value.ToString() = txtcodproducto.Text Then
    '                valordup = True
    '                linea.Cells(3).Value = linea.Cells(3).Value + Val(txtcantprod.Text)
    '                linea.Cells(4).Value = linea.Cells(3).Value * linea.Cells(2).Value
    '                calcularsubtot()
    '                limpiarpdocuto()
    '            Else
    '                valordup = False
    '            End If
    '        Next
    '        If valordup = False Then
    '            dgvfactura.Rows.Add(txtcodprod.Text, txtdescripprod.Text, txtprecioprod.Text, txtcantprod.Text, Val(txtprecioprod.Text) * Val(txtcantprod.Text))
    '            limpiarpdocuto()
    '        End If
    '    Else
    '        dgvfactura.Rows.Add(txtcodprod.Text, txtdescripprod.Text, txtprecioprod.Text, txtcantprod.Text, Val(txtprecioprod.Text) * Val(txtcantprod.Text))
    '        limpiarpdocuto()
    '    End If
    'End Sub
End Class