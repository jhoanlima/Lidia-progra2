Imports System.Math
Module Module1
    Public nombre(12) As String
    Public nit(12) As Integer
    Public saldoAnterior(12) As Double
    Public consumo(12) As Double
    Public servicio(12) As String
    Public tipoTraifa(12) As String
    Public pagoInicial(12) As Double
    Public pagoTotal(12) As Double
    Public descuento(12) As Double
    Public tarifaMenorResindencial As Double = 0.99
    Public tarifaMediaResindencial As Double = 1.2
    Public tarifaMayorResindencial As Double = 3
    Public tarifaMenorIndustrial As Double = 1.99
    Public tarifaMediaIndustrial As Double = 2.2
    Public tarifaMayorIndustrial As Double = 4

    Public fila As Byte = 0
    Sub errores()
        'Instrucciones de los errores de ingreso de texto 
        If fila < 11 Then
            If (Form1.TXTnombre.Text <> "") Then
                nombre(fila) = Form1.TXTnombre.Text
            Else
                MsgBox("ERROR, no ingreso nombre del trbajador")

            End If
            If (IsNumeric(Form1.TXTnit.Text)) And Val(Form1.TXTnit.Text) > 0 Then
                'Se utiliza la funcion Val para convertir el string en valor numerico
                nit(fila) = Val(Form1.TXTnit.Text)
            Else
                MsgBox("ERROR,dato de Nit no valido")

            End If
            If (IsNumeric(Form1.TXTsaldoAnterior.Text)) And Val(Form1.TXTsaldoAnterior.Text) >= 0 Then
                saldoAnterior(fila) = Val(Form1.TXTsaldoAnterior.Text)
            Else
                MsgBox("ERROR,dato de Saldo Anterior no valido")

            End If
            If IsNumeric(Form1.TXTconsumo.Text) And Val(Form1.TXTconsumo.Text) > 0 Then
                consumo(fila) = Val(Form1.TXTconsumo.Text)
            Else
                MsgBox("ERROR,dato de Consumo no valido")

            End If
            ' Instrucciones de la seleccion de combobox
            servicio(fila) = Form1.CMBservicio.Text
            tipoTraifa(fila) = Form1.CMBtarifa.Text

            'Calculos de los vectores
            Dim Social As Boolean
            Dim resindencial As Boolean
            If Form1.CMBtarifa.Text = "Social" Then
                Social = True
            Else
                Social = False
            End If
            If Form1.CMBservicio.Text = "Residencial" Then
                resindencial = True
            Else
                resindencial = False
            End If

            calculos(resindencial, consumo(fila), social)

            'Mostrar los datos correspondiente 
            Form1.DataGridView1.Rows.Add(nombre(fila), Str(nit(fila)), servicio(fila), tipoTraifa(fila), Round(pagoInicial(fila), 2), Round(descuento(fila), 2), Round(pagoTotal(fila), 2))
            limpiarEntrada()
        Else
            MsgBox("Lo sentimos, los vectores estan llenos")
        End If
        fila = fila + 1
    End Sub

    Sub calculos(resindencial As Boolean, consumo As Double, social As Boolean)
        Dim saldoAnterior As Double = Form1.TXTsaldoAnterior.Text()
        Dim descuentoo As Double
        Dim pagoIniciall As Double
        Dim pagoAtrasado As Double
        Dim pagoTotall As Double

        pagoAtrasado = saldoAnterior + (saldoAnterior * 0.02)

        If resindencial Then
            Select Case consumo
                Case Is > 301
                    pagoIniciall = consumo * tarifaMenorResindencial
                Case Is > 101
                    pagoIniciall = consumo * tarifaMediaResindencial
                Case Is < 101
                    pagoIniciall = consumo * tarifaMayorResindencial
            End Select
        Else
            Select Case consumo
                Case Is > 301
                    pagoIniciall = consumo * tarifaMenorIndustrial
                Case Is > 101
                    pagoIniciall = consumo * tarifaMediaIndustrial
                Case Is < 101
                    pagoIniciall = consumo * tarifaMayorIndustrial
            End Select
        End If

        pagoTotall = pagoAtrasado + pagoIniciall
        If social Then
            descuentoo = pagoTotall * 0.2
        Else
            descuentoo = pagoIniciall * 0.1
        End If

        pagoInicial(fila) = pagoIniciall
        pagoTotal(fila) = pagoTotall
        descuento(fila) = descuentoo
    End Sub
    Sub limpiar()
        Form1.TXTnombre.Clear()
        Form1.TXTnit.Clear()
        Form1.TXTsaldoAnterior.Clear()
        Form1.TXTconsumo.Clear()

        Form1.CMBservicio.Text = ""
        Form1.CMBtarifa.Text = ""

        Form1.DataGridView1.Rows.Clear()
    End Sub
    Sub limpiarEntrada()
        Form1.TXTnombre.Clear()
        Form1.TXTnit.Clear()
        Form1.TXTsaldoAnterior.Clear()
        Form1.TXTconsumo.Clear()

        Form1.CMBservicio.Text = ""
        Form1.CMBtarifa.Text = ""
    End Sub
End Module
