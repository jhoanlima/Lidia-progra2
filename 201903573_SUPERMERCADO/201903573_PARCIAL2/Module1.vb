Imports System.Math
Module Module1
    'No se le cambio los nombres logicos porque en el anunciado asi decia
    Public nombre(6) As String
    Public nit(6) As Integer
    Public direccion(6) As String
    Public formapago(6) As String
    Public pagoparcial(6) As Double
    Public recargo(6) As Double
    Public descuento(6) As Double
    Public PagoTotal(6) As Double

    Public Producto(6) As String
    Public cantidad(6) As Integer

    Public fila As Byte = 0

    Sub Proceso(TipoProducto As String, Numero As Integer, pago As String)

        If fila < 6 Then
            If Form1.TextBox1.Text <> "" Then
                nombre(fila) = Form1.TextBox1.Text
            Else
                MsgBox("Error, no ingreso el nombre")
                Form1.TextBox1.Focus() : Exit Sub
            End If
            If Val(Form1.TextBox2.Text) > 0 Then
                nit(fila) = Val(Form1.TextBox2.Text)
            Else
                MsgBox("Error, no ingreso el Nit")
                Form1.TextBox2.Focus() : Exit Sub
            End If
            If Form1.TextBox3.Text <> "" Then
                direccion(fila) = Form1.TextBox3.Text
            Else
                MsgBox("Error, no ingreso la direccion")
                Form1.TextBox3.Focus() : Exit Sub
            End If
            If Form1.ComboBox1.Text <> "" Then
                formapago(fila) = Form1.ComboBox1.Text
            Else
                MsgBox("Error, no ingreso la forma de pago")
                Form1.ComboBox1.Focus() : Exit Sub
            End If
            If Form1.ComboBox2.Text <> "" Then
                Producto(fila) = Form1.ComboBox2.Text
            Else
                MsgBox("Error, no ingreso el producto")
                Form1.ComboBox1.Focus() : Exit Sub
            End If
            If Val(Form1.TextBox4.Text) > 0 Then
                cantidad(fila) = Val(Form1.TextBox4.Text)
            Else
                MsgBox("Error, no ingreso la cantidad")
                Form1.TextBox4.Focus() : Exit Sub
            End If
            Select Case TipoProducto
                Case "Palomitas"
                    pagoparcial(fila) = Numero * 4.9
                Case "Desinfectante"
                    pagoparcial(fila) = Numero * 11.9
                Case "Servilletas"
                    pagoparcial(fila) = Numero * 10
                Case "Salsa"
                    pagoparcial(fila) = Numero * 7
                Case "Detergente"
                    pagoparcial(fila) = Numero * 33
                Case "Cloro"
                    pagoparcial(fila) = Numero * 9
            End Select
            Select Case pago
                Case "Tarjeta"
                    recargo(fila) = pagoparcial(fila) * 0.08
            End Select
            Select Case Numero
                Case Is > 5
                    descuento(fila) = pagoparcial(fila) * 0.05
            End Select
            PagoTotal(fila) = pagoparcial(fila) - descuento(fila) + recargo(fila)
            Form1.DataGridView1.Rows.Add(nombre(fila), nit(fila), direccion(fila), formapago(fila), Producto(fila), cantidad(fila), Round(pagoparcial(fila), 2), Round(descuento(fila), 2), Round(recargo(fila), 2), Round(PagoTotal(fila), 2))
        Else
            MsgBox("Vectores llenos")
        End If
        fila = fila + 1
    End Sub
    Sub limpiarentradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()

        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
    End Sub
    Sub limpiarvector()
        Form1.DataGridView1.Rows.Clear()
        fila = 0
    End Sub


End Module
