Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
            Exit Sub
        End If

        If contador < 8 Then
            numeroventa(contador) = contador + 1
            tamaño(contador) = ComboBox1.SelectedItem
            material(contador) = ComboBox2.SelectedItem

            Select Case tamaño(contador)
                Case "Sofá"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomo(contador) = psofa
                            preciocosto(contador) = 8 * pcuero + preciomo(contador)
                        Case "Cuerina"
                            preciomo(contador) = psofa
                            preciocosto(contador) = 8 * pcuerina + preciomo(contador)
                    End Select

                Case "Individual"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomo(contador) = pindividual
                            preciocosto(contador) = 3.5 * pcuero + preciomo(contador)
                        Case "Cuerina"
                            preciomo(contador) = pindividual
                            preciocosto(contador) = 3.5 * pcuerina + preciomo(contador)
                    End Select
                Case "Doble"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomo(contador) = pdoble
                            preciocosto(contador) = 6 * pcuero + preciomo(contador)
                        Case "Cuerina"
                            preciomo(contador) = pdoble
                            preciocosto(contador) = 6 * pcuerina + preciomo(contador)
                    End Select

            End Select

            precioventa(contador) = preciocosto(contador) * 1.65

            ListBox1.Items.Add(numeroventa(contador))
            ListBox2.Items.Add(tamaño(contador))
            ListBox3.Items.Add(material(contador))
            ListBox4.Items.Add(preciocosto(contador))
            ListBox5.Items.Add(preciomo(contador))
            ListBox6.Items.Add(String.Format("{0:0.00}", precioventa(contador)))

            contador = contador + 1

        Else
            MsgBox("Se ha llegado al límite de registros")
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub
End Class
