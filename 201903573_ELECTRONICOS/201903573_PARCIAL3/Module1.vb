Imports System.Math
Module Module1
    Dim matriz(6, 9) As String
    ' codigo
    ' nombre
    ' precio
    ' cantidad defectuosas
    ' cantidad aprobadas
    ' ganancias
    ' perdidas
    ' total
    ' sello de calidad
    Dim index As Integer = 0
    Sub LimpiarEntradas()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""

        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
    End Sub
    Sub LimpiarEstadisitca()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
    End Sub
    Sub LimpiarMatriz()
        For i As Integer = 0 To 6
            For j As Integer = 0 To 9
                matriz(i, j) = Nothing
            Next j
        Next i
        Form1.DataGridView1.Rows.Clear()
        index = 0
    End Sub

    Function calcularGanancias(precio As Integer, cAprobadas As Integer)
        Return precio * cAprobadas
    End Function
    Function calcularPerdidas(precio As Integer, cDefectuosas As Integer)
        Return precio * 0.75 * cDefectuosas
    End Function
    Function calcularTotal(precio As Integer, cAprobadas As Integer, cDefectuosas As Integer)
        Return calcularGanancias(precio, cAprobadas) + (precio * cDefectuosas * 0.25)
    End Function
    Function selloCalidad(cDefectuosas As Integer)
        If (cDefectuosas = 0) Then
            Return "Si"
        End If
        Return "No"
    End Function

    Sub llenarMatriz()
        matriz(index, 0) = Form1.ComboBox1.Text
        matriz(index, 1) = Form1.ComboBox2.Text
        matriz(index, 2) = Form1.TextBox1.Text
        matriz(index, 3) = Form1.TextBox2.Text
        matriz(index, 4) = Form1.TextBox3.Text
        matriz(index, 5) = calcularGanancias(Val(Form1.TextBox1.Text), Val(Form1.TextBox3.Text))
        matriz(index, 6) = calcularPerdidas(Val(Form1.TextBox1.Text), Val(Form1.TextBox2.Text))
        matriz(index, 7) = calcularTotal(Val(Form1.TextBox1.Text), Val(Form1.TextBox3.Text), Val(Form1.TextBox2.Text))
        matriz(index, 8) = selloCalidad(Val(Form1.TextBox2.Text))
        If index >= 5 Then
            MsgBox("ya se alcanzo el limite")
        Else
            index = index + 1
        End If
    End Sub

    Sub estadisticas()
        Dim sellos As Integer = 0
        Dim defectuosas As Integer = 0
        Dim noSello As Integer = 0
        For i As Integer = 0 To 6
            If matriz(i, 8) = "Si" Then
                sellos = sellos + 1
            Else
                noSello = noSello + 1
            End If
            If (Val(matriz(i, 3)) > Val(matriz(i, 4))) Then
                defectuosas = defectuosas + 1
            End If
        Next i
        Form1.TextBox4.Text = sellos
        Form1.TextBox5.Text = defectuosas
        Form1.TextBox6.Text = noSello

    End Sub

    Sub mostrar()
        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 6
            If matriz(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(matriz(i, 0), matriz(i, 1), matriz(i, 2), matriz(i, 3), matriz(i, 4), matriz(i, 5), matriz(i, 6), matriz(i, 7), matriz(i, 8))
            End If
        Next
    End Sub

    Sub consultar()
        For i As Integer = 0 To 6
            If (matriz(i, 0) = Form1.ComboBox1.Text) Then
                Form1.ComboBox2.Text = matriz(i, 1)
                Form1.TextBox1.Text = matriz(i, 2)
                Form1.TextBox2.Text = matriz(i, 3)
                Form1.TextBox3.Text = matriz(i, 4)
                MsgBox("se encontro el producto")
                Return
            End If
        Next i
        MsgBox("no se encontro el producto")
    End Sub

    Sub Salir()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            LimpiarEntradas()
            LimpiarMatriz()
            LimpiarEstadisitca()
        End If
    End Sub

End Module

