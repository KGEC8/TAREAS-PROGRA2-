Public Class Form1


    Private Sub Lino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lino.CheckedChanged
        If Lino.Checked Then
            txtLino.Visible = True
            txtLino.Clear()
            txtLino.Focus()
        Else
            txtLino.Clear()
            txtLino.Visible = False

        End If
    End Sub

    Private Sub Algodón_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Algodón.CheckedChanged
        If Algodón.Checked Then
            txtAlgodon.Visible = True
            txtAlgodon.Clear()
            txtAlgodon.Focus()
        Else
            txtAlgodon.Clear()
            txtAlgodon.Visible = False

        End If
    End Sub

    Private Sub Seda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seda.CheckedChanged
        If Seda.Checked Then
            txtSeda.Visible = True
            txtSeda.Clear()
            txtSeda.Focus()
        Else
            txtSeda.Clear()
            txtSeda.Visible = False

        End If
    End Sub

    Private Sub Hilo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hilo.CheckedChanged
        If Hilo.Checked Then
            txtHilo.Visible = True
            txtHilo.Clear()
            txtHilo.Focus()
        Else
            txtHilo.Clear()
            txtHilo.Visible = False

        End If
    End Sub

    Private Sub Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.Click
        If Lino.Checked Or Algodón.Checked Or Seda.Checked Or Hilo.Checked Then
            If Lino.Checked Then
                If (IsNumeric(txtLino.Text) And Val(txtLino.Text) > 0) Then
                    yLino = Val(txtLino.Text)
                    slino = yLino * 15.0
                Else
                    MsgBox("ERROR, CANTIDAD ERRONEA")
                    yLino = 0
                    slino = 0
                    txtLino.Clear() : txtLino.Focus() : Exit Sub
                End If
            End If
            If Algodón.Checked Then
                If (IsNumeric(txtAlgodon.Text) And Val(txtAlgodon.Text) > 0) Then
                    yalgodon = Val(txtAlgodon.Text)
                    salgodon = yalgodon * 23.99
                Else
                    MsgBox("ERROR, CANTIDAD ERRONEA")
                    yalgodon = 0
                    salgodon = 0
                    txtAlgodon.Clear() : txtAlgodon.Focus() : Exit Sub
                End If
            End If

            If Seda.Checked Then
                If (IsNumeric(txtSeda.Text) And Val(txtSeda.Text) > 0) Then
                    ySeda = Val(txtSeda.Text)
                    sseda = ySeda * 30.99
                Else
                    MsgBox("ERROR, CANTIDAD ERRONEA")
                    ySeda = 0
                    sseda = 0
                    txtSeda.Clear() : txtSeda.Focus() : Exit Sub
                End If

            End If

            If Hilo.Checked Then
                If (IsNumeric(txtHilo.Text) And Val(txtHilo.Text) > 0) Then
                    yHilo = Val(txtHilo.Text)
                    shilo = yHilo * 39.99
                Else
                    MsgBox("ERROR, CANTIDAD ERRONEA")
                    yHilo = 0
                    shilo = 0
                    txtHilo.Clear() : txtHilo.Focus() : Exit Sub
                End If
            End If
        Else
            MsgBox("ERROR NO SELECCIONO NINGÚN MATERIAL")
            Exit Sub

        End If
        yardas = yHilo + yalgodon + ySeda + yLino
        material = slino + salgodon + sseda + shilo

        If Imperial.Checked Or Matrimonial.Checked Or Queen.Checked Or King.Checked Then
            If Imperial.Checked = True Then
                If yardas = 3 Then
                    total = material + imp
                Else
                    MsgBox("EL NÚMERO DE YARDAS NO DEBE SER INFERIOR O SUPERIOR A 3")
                    Exit Sub
                End If

            ElseIf Matrimonial.Checked = True Then
                If yardas = 5 Then
                    total = material + mat
                Else
                    MsgBox("EL NÚMERO DE YARDAS NO DEBE SER INFERIOR O SUPERIOR A 5")
                End If
            ElseIf Queen.Checked Then
                If yardas = 6 Then
                    total = material + qen
                Else
                    MsgBox("EL NÚMERO DE YARDAS NO DEBE SER INFERIOR O SUPERIOR A 6")
                End If

            ElseIf King.Checked Then
                If yardas = 7 Then
                    total = material + kig
                Else
                    MsgBox("EL NÚMERO DE YARDAS NO DEBE SER INFERIOR O SUPERIOR A 7")
                End If
        Else
            MsgBox("ERROR NO SELECCIONO TAMAÑO")
            Exit Sub
            End If
        End If

        costo = total
        venta = total + total * 0.65

        TextBox2.Text = Str(costo)
        TextBox1.Text = Str(venta)





    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        txtAlgodon.Clear()
        txtHilo.Clear()
        txtSeda.Clear()
        txtLino.Clear()
        Imperial.Checked = False
        Matrimonial.Checked = False
        Queen.Checked = False
        King.Checked = False
        Lino.Checked = False
        Seda.Checked = False
        Algodón.Checked = False
        Hilo.Checked = False
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        If MsgBox("Desea salir", vbQuestion + vbYesNo, "salida") = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class
