Module Module1

    Public kminicial(7)
    Public kmfinal(7)
    Public kmrecorridos(7)
    Public placa(7)
    Public tipocarro(7)
    Public tipo1(7)
    Public tipo2(7)
    Public tipo3(7)
    Public tipo4(7)
    Public pkilometraje(7)
    Public pfinal(7)
    Public costobase(7)

    Public Const costtipo1 = 500
    Public Const costtipo2 = 400
    Public Const costtipo3 = 300
    Public Const costtipo4 = 200
    Public Const tarifa1 = 3
    Public Const tarifa2 = 4
    Public Const tarifa3 = 5



    Public vector As Byte = 0

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.TextBox1.Focus()
    End Sub


    Sub mostrarvectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If (placa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(placa(I), (tipocarro(I)), (costobase(I)), (kminicial(I)), (kmfinal(I)), (pfinal(I)), (pkilometraje(I)))
            Else

                Continue For
            End If
        Next

    End Sub


    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        vector = 0

        For I = 0 To 6
            '
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
        Next I

    End Sub
End Module
