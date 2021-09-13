Public Class Form1
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DescuentoII.Items.Clear()
        Total.Items.Clear()
        TextBox1.Clear()
        ComboBox1.SelectedItem.clear()
        Función.Items.Clear()
        Cine.Items.Clear()
        SubTotal.Items.Clear()
        DescuentoI.Items.Clear()
        ComboBox2.SelectedItem.clear()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cantidad = TextBox1.Text
        If indice < 9 Then
            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox1.SelectedItem
            vsubtotal(indice) = calcularsubtotal(vfuncion(indice), vcine(indice))
            vdescuento1(indice) = vsubtotal(indice) * calculodescuento1(vfuncion(indice), vcine(indice))

            If vsubtotal(indice) >= 100 And vsubtotal(indice) < 300 Then
                vdescuento2(indice) = vsubtotal(indice) * 0.02
            ElseIf vsubtotal(indice) >= 300 And vsubtotal(indice) < 500 Then
                vdescuento2(indice) = vsubtotal(indice) * 0.04
            ElseIf vsubtotal(indice) >= 500 And vsubtotal(indice) < 1000 Then
                vdescuento2(indice) = vsubtotal(indice) * 0.06
            End If
            vtotal(indice) = vsubtotal(indice) - vdescuento1(indice) - vdescuento2(indice)

            Cine.Items.Add(vcine(indice))
            DescuentoI.Items.Add(vdescuento1(indice))
            DescuentoII.Items.Add(vdescuento2(indice))
            Total.Items.Add(vtotal(indice))
            SubTotal.Items.Add(vsubtotal(indice))
            Función.Items.Add(vfuncion(indice))
        ElseIf indice >= 9 Then

        End If
    End Sub

End Class
