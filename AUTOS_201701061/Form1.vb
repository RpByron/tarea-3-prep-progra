Public Class Form1


    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If vector <= 6 Then

            If (IsNumeric(TextBox1.Text) And Val(TextBox1.Text <> "")) Then
                placa(vector) = Val(TextBox1.Text)
            Else
                MsgBox("Error, ingresar placa")
                TextBox1.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text <> "")) Then
                kminicial(vector) = Val(TextBox2.Text)
            Else
                MsgBox("Error, ingresar kilometraje inicial")
                TextBox2.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text <> "")) Then
                kmfinal(vector) = Val(TextBox3.Text)
            Else
                MsgBox("Error, ingresar kilometraje final")
                TextBox2.Focus() : Exit Sub
            End If


            kmrecorridos(vector) = (Val(kmfinal(vector)) - Val(kminicial(vector)))
            TextBox4.Text = kmrecorridos(vector)


            If Val(kmrecorridos(vector)) <= 50 Then
                pkilometraje(vector) = kmrecorridos(vector) * tarifa1
            End If
            If Val(kmrecorridos(vector)) <= 70 And Val(TextBox4.Text) > 50 Then
                pkilometraje(vector) = kmrecorridos(vector) * tarifa2
            End If
            If Val(kmrecorridos(vector)) > 70 Then
                pkilometraje(vector) = kmrecorridos(vector) * tarifa3
            End If





            Select Case ComboBox1.SelectedIndex
                Case 0
                    pfinal(vector) = Val(pkilometraje(vector)) + costtipo1
                Case 1
                    pfinal(vector) = Val(pkilometraje(vector)) + costtipo2
                Case 2
                    pfinal(vector) = Val(pkilometraje(vector)) + costtipo3
                Case 3
                    pfinal(vector) = Val(pkilometraje(vector)) + costtipo4
                Case Else
                    MsgBox("No se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select




            Select Case ComboBox1.SelectedIndex
                Case 0
                    costobase(vector) = costtipo1
                Case 1
                    costobase(vector) = costtipo2
                Case 2
                    costobase(vector) = costtipo3
                Case 3
                    costobase(vector) = costtipo4
                Case Else
                    MsgBox("No se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select


            tipocarro(vector) = ComboBox1.Text
            vector = vector + 1
            limpiar_entradas()
        End If
        If vector = 7 Then
            MsgBox("Almacenamiento lleno")

        End If
    End Sub



    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrarvectores()
    End Sub

    Private Sub ConsularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsularToolStripMenuItem.Click
        Dim existe As Boolean = False

        Dim I As Byte
        I = 0
        While (I <= 6) And Not (existe)

            If (placa(I) = Val(TextBox5.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = Str(placa(I))
            TextBox2.Text = Str(kminicial(I))
            TextBox3.Text = Str(kmfinal(I))
            TextBox4.Text = Str(kmrecorridos(I))
            ComboBox1.Text = tipocarro(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(placa(I), (tipocarro(I)), (costobase(I)), (kminicial(I)), (kmfinal(I)), (pfinal(I)), (pkilometraje(I)))

            vector = I
        Else
            MsgBox("Dato no encontrado")
            TextBox5.Focus()
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        placa(vector) = Val(TextBox1.Text)
        tipocarro(vector) = ComboBox1.Text
        kminicial(vector) = Val(TextBox2.Text)
        kmfinal(vector) = Val(TextBox3.Text)
        kmrecorridos(vector) = Val(TextBox4.Text)


        MsgBox("Registro actualizado correctamente")

        vector = 6
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim I As Byte

        kminicial(vector) = Nothing
        kmfinal(vector) = Nothing
        kmrecorridos(vector) = Nothing
        placa(vector) = Nothing
        tipocarro(vector) = Nothing
        tipo1(vector) = Nothing
        tipo2(vector) = Nothing
        tipo3(vector) = Nothing
        tipo4(vector) = Nothing
        pkilometraje(vector) = Nothing
        pfinal(vector) = Nothing
        costobase(vector) = Nothing

        For I = vector To 6

            kminicial(I) = kminicial(I + 1)
            kmfinal(I) = kmfinal(I + 1)
            kmrecorridos(I) = kmrecorridos(I + 1)
            placa(I) = placa(I + 1)
            tipocarro(I) = tipocarro(vector)
            tipo1(I) = tipo1(I + 1)
            tipo2(I) = tipo2(I + 1)
            tipo3(I) = tipo3(I + 1)
            tipo4(I) = tipo4(I + 1)
            tipo1(I) = tipo1(I + 1)
            pkilometraje(I) = pkilometraje(I + 1)
            pfinal(I) = pfinal(I + 1)
            costobase(I) = costobase(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        kminicial(vector) = Nothing
        kmfinal(vector) = Nothing
        kmrecorridos(vector) = Nothing
        placa(vector) = Nothing
        tipocarro(vector) = Nothing
        tipo1(vector) = Nothing
        tipo2(vector) = Nothing
        tipo3(vector) = Nothing
        tipo4(vector) = Nothing
        pkilometraje(vector) = Nothing
        pfinal(vector) = Nothing
        costobase(vector) = Nothing

        vector = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox(" ¿ Desea salir del programa ? ", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        End If

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub
End Class
