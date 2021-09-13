Imports System.Math
Module Module1
    Public funcion(9) As String
    Public cine(9) As String
    Public entradas(9) As Integer
    Public subtotal(9) As Double
    Public descuento1(9) As Double
    Public descuento2(9) As Double
    Public total(9) As Double

    Public tarifa1A As Integer = 30
    Public tarifa2A As Integer = 35
    Public tarifa3A As Integer = 40
    Public tarifa4A As Integer = 40

    Public tarifa1B As Integer = 24
    Public tarifa2B As Integer = 34
    Public tarifa3B As Integer = 44
    Public tarifa4B As Integer = 44

    Public tarifa1C As Integer = 35
    Public tarifa2C As Integer = 40
    Public tarifa3C As Integer = 50
    Public tarifa4C As Integer = 50




    Public fila As Byte = 0

    Sub verificar()
        If fila < 9 Then

            If Form1.CMBfuncion.Text <> "" Then
            funcion(fila) = Form1.CMBfuncion.Text
        Else
            MsgBox("ERROR, no selecciono funcion")
        End If
        If Form1.CMBcine.Text <> "" Then
            cine(fila) = Form1.CMBcine.Text
        Else
            MsgBox("ERROR, no selecciono el cine")
        End If
            If IsNumeric(Form1.TXTentrada.Text) And Val(Form1.TXTentrada.Text) > 0 Then
                entradas(fila) = Val(Form1.TXTentrada.Text)
            Else
                MsgBox("ERROR, no ingreso el numero de entradas")
            End If
            'para mostrar los datos
            Form1.DataGridView1.Rows.Add(Str(funcion(fila)), cine(fila), Str(entradas(fila)), subtotal(fila),descuento1(fila),descuento2(fila),total(fila))

        Else
            MsgBox("Lo sentimos, los vectores estan llenos")
        End If
        fila = fila + 1
        Form1.TXTentrada.Clear()

        Form1.CMBfuncion.Text = ""
        Form1.CMBcine.Text = ""
    End Sub

    Sub calcular(funcionEntrada As Integer, cineEntrada As String, noEntradas As Integer)
        Select Case funcionEntrada
            Case 1
                Select Case cineEntrada
                    Case "A"
                        subtotal(fila) = noEntradas * tarifa1A
                    Case "B"
                        subtotal(fila) = noEntradas * tarifa1B
                        descuento1(fila) = subtotal(fila) * 0.03
                    Case "C"
                        subtotal(fila) = noEntradas * tarifa1C
                        descuento1(fila) = subtotal(fila) * 0.03
                    Case Else
                        MsgBox("Disculpe sus selecciones no estan contempladas")
                End Select
            Case 2
                Select Case cineEntrada
                    Case "A"
                        subtotal(fila) = noEntradas * tarifa2A
                        descuento1(fila) = subtotal(fila) * 0.015
                    Case "B"
                        subtotal(fila) = noEntradas * tarifa2B
                    Case "C"
                        subtotal(fila) = noEntradas * tarifa2C
                    Case Else
                        MsgBox("Disculpe sus selecciones no estan contempladas")
                End Select
            'el 3 y el 4 van juntos porque tienen los mismos precios
            Case 3 To 4
                Select Case cineEntrada
                    Case "A"
                        subtotal(fila) = noEntradas * tarifa3A
                    Case "B"
                        subtotal(fila) = noEntradas * tarifa3B
                        descuento1(fila) = subtotal(fila) * 0.055
                    Case "C"
                        subtotal(fila) = noEntradas * tarifa3C
                        descuento1(fila) = subtotal(fila) * 0.055
                    Case Else
                        MsgBox("Disculpe sus selecciones no estan contempladas")
                End Select
            Case Else
                MsgBox("Disculpe sus selecciones no estan contempladas")
        End Select

        Select Case subtotal(fila)
            Case 100 To 300
                descuento2(fila) = subtotal(fila) * 0.02
            Case 300 To 500
                descuento2(fila) = subtotal(fila) * 0.04
            Case 500 To 1000
                descuento2(fila) = subtotal(fila) * 0.6
        End Select

        total(fila) = subtotal(fila) - descuento1(fila) - descuento2(fila)
    End Sub

    Sub limpiar()
        Form1.TXTentrada.Clear()

        Form1.CMBfuncion.Text = ""
        Form1.CMBcine.Text = ""

        Form1.DataGridView1.Rows.Clear()

    End Sub

End Module
