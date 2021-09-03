Imports System.Math
Module Module1
    Public nombre(11) As String
    Public nit(11) As Integer
    Public saldoAnterior(11) As Double
    Public consumo(11) As Double
    Public servicio(11) As Double

    Public fila As Byte = 0
    Sub calcular()
        'Instrucciones de los errores de ingreso de texto 
        If fila < 11 Then
            If (Form1.TXTnombre.Text <> "") Then
                nombre(fila) = Form1.TXTnombre.Text
            Else
                MsgBox("ERROR, no ingreso nombre del trbajador")
                'falta una istruccion 
            End If
            If (IsNumeric(Form1.TXTnit.Text)) And Val(Form1.TXTnit.Text) > 0 Then
                'Se utiliza la funcion Val para convertir el string en valor numerico
                nit(11) = Val(Form1.TXTnit.Text)
            Else
                MsgBox("ERROR,dato de Nit no valido")
                'falta una istruccion 
            End If
            If (IsNumeric(Form1.TXTsaldoAnterior.Text)) And Val(Form1.TXTsaldoAnterior.Text) > 0 Then
                saldoAnterior(11) = Val(Form1.TXTsaldoAnterior.Text)
            Else
                MsgBox("ERROR,dato de Saldo Anterior no valido")
                'falta una istruccion 
            End If
            If IsNumeric(Form1.TXTconsumo.Text) And Val(Form1.TXTconsumo.Text) > 0 Then
                consumo(11) = Val(Form1.TXTconsumo.Text)
            Else
                MsgBox("ERROR,dato de Consumo no valido")
                'falta una istruccion
            End If
            ' Instrucciones de la seleccion de combobox

            Form1.DataGridView1.Rows.Add(nombre(fila))
        End If


    End Sub


End Module
