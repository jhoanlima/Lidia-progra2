Imports System.Math
Module Module1
    Public nit(6) As Integer
    Public placa(6) As String
    Public dias(6) As Integer
    Public marca(6) As String
    Public pagoParcial(6) As Double
    Public descuento(6) As Double
    Public recargo(6) As Double
    Public pagoFinal(6) As Double

    Public Hondapago As Integer = 250
    Public Mercedespago As Integer = 450
    Public Toyotapago As Integer = 325
    Public Mazdapago As Integer = 300

    Public porcentajeTotal As Double
    Public porcentajeEfectivo As Double
    Public porcentajeTarjeta As Double

    Public fila As Byte = 0

    Sub Calcular(TipoMarca As String, NoDias As Integer, efectivo As Double, tarjeta As Double)
        porcentajeEfectivo = Val(Form1.TXTporcentajeEfectivo.Text)
        porcentajeTarjeta = Val(Form1.TXTporcentajeTarjeta.Text)

        porcentajeTotal = porcentajeEfectivo + porcentajeTarjeta
        If fila < 6 Then
            If Val(Form1.TXTnit.Text) > 0 Then
                nit(fila) = Val(Form1.TXTnit.Text)
            Else
                MsgBox("ERROR, no ingreso Nit")
                Form1.TXTnit.Focus() : Exit Sub
            End If
            If Form1.TXTplaca.Text <> "" Then
                placa(fila) = Form1.TXTplaca.Text
            Else
                MsgBox("ERROR, no ingreso la placa")
                Form1.TXTplaca.Focus() : Exit Sub
            End If
            If Val(Form1.TXTdías.Text) > 0 Then
                dias(fila) = Val(Form1.TXTdías.Text)
            Else
                MsgBox("ERROR, no ingreso numero de dias")
                Form1.TXTdías.Focus() : Exit Sub
            End If
            If Form1.CMBmarca.Text <> "" Then
                marca(fila) = Form1.CMBmarca.Text
            Else
                MsgBox("ERROR, no selecciono la marca")
                Form1.CMBmarca.Focus() : Exit Sub
            End If
            If porcentajeTotal > 100 Or porcentajeTotal < 100 Then
                MsgBox("ERROR, ingreso incorrecto del porcentaje de forma de pago")
                Form1.TXTporcentajeEfectivo.Focus() : Exit Sub
            End If

        End If
        fila = fila + 1

        Select Case TipoMarca
            Case "Honda"
                pagoParcial(fila) = NoDias * Hondapago
            Case "Mercedes Benz"
                pagoParcial(fila) = NoDias * Mercedespago
            Case "Toyota"
                pagoParcial(fila) = NoDias * Toyotapago
            Case "Mazda"
                pagoParcial(fila) = NoDias * Mazdapago
            Case ""
                MsgBox("Disculpe no selecciono marca")
        End Select

        If efectivo = 100 Then
            descuento(fila) = (pagoParcial(fila) * 0.05)
        Else
            descuento(fila) = 0
        End If

        If tarjeta = 100 Then
            recargo(fila) = (pagoParcial(fila) * 0.025)
        Else
            recargo(fila) = 0
        End If

        pagoFinal(fila) = pagoParcial(fila) - descuento(fila) + recargo(fila)
        ' Para mostrar los datos
        Form1.DataGridView1.Rows.Add(placa(fila), marca(fila), dias(fila), pagoParcial(fila), descuento(fila), recargo(fila), pagoFinal(fila))
    End Sub

    Sub limpiarvector()
        Form1.DataGridView1.Rows.Clear()
    End Sub
    Sub limpiarentradas()
        Form1.TXTnit.Clear()
        Form1.TXTplaca.Clear()
        Form1.TXTdías.Clear()
        Form1.TXTporcentajeEfectivo.Clear()
        Form1.TXTporcentajeTarjeta.Clear()

        Form1.CMBmarca.Text = ""

        Form1.CBefectivo.Checked = False
        Form1.CBtarjeta.Checked = False

    End Sub
End Module
