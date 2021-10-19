Imports System.Math
Module Module1
    Public inscripcionBasico As Double = 350
    Public inscripcionDiversificado As Double = 450

    Public primerBasico As Double = 250
    Public primerDiversificado As Double = 350

    Public alumnos(7, 8) As String
    Public fila As Byte = 0

    Sub Agregar()
        Dim nombre As String = Form1.TXTnombre.Text
        Dim carnet As Integer = Val(Form1.TXTcarnet.Text)
        Dim diversificado As Boolean = Form1.RDdiversificado.Checked
        Dim carrera As String = Form1.CMBcarreras.Text
        Dim forma As String = Form1.CMBformaPago.Text

        Dim tarjeta As Double = False
        If forma = "Tarjeta de credito" Then
            tarjeta = True
        End If

        alumnos(fila, 0) = nombre
        alumnos(fila, 1) = CStr(carnet)
        If diversificado Then
            alumnos(fila, 2) = "diversificado"
            alumnos(fila, 3) = CStr(inscripcionDiversificado)
            alumnos(fila, 4) = CStr(primerDiversificado)
            alumnos(fila, 5) = forma
            alumnos(fila, 6) = calcularRecargo(tarjeta, calcularInicial(diversificado))
            alumnos(fila, 7) = carrera
        Else
            alumnos(fila, 2) = "basicos"
            alumnos(fila, 3) = CStr(inscripcionBasico)
            alumnos(fila, 4) = CStr(primerBasico)
            alumnos(fila, 5) = forma
            alumnos(fila, 6) = calcularRecargo(tarjeta, calcularInicial(diversificado))
            alumnos(fila, 7) = "basicos"
        End If
        Mostrar()
        fila = fila + 1
    End Sub

    Sub totales()
        Dim nombre As String = Form1.TXTnombre.Text
        Dim carnet As Integer = Val(Form1.TXTcarnet.Text)
        Dim diversificado As Boolean = Form1.RDdiversificado.Checked
        Dim carrera As String = Form1.CMBcarreras.Text
        Dim forma As String = Form1.CMBformaPago.Text

        Dim totalGeneral As Double = 0
        Dim totalForma As Double = 0
        Dim totalCarrera As Integer = 0
        Dim totalNivel As Double = 0

        For i As Integer = 0 To 7
            If alumnos(i, 0) <> "" And alumnos(i, 0) <> Nothing Then
                totalGeneral = totalGeneral + Val(alumnos(i, 3)) + Val(alumnos(i, 4))
                If forma = alumnos(i, 5) Then
                    totalForma = totalForma + Val(alumnos(i, 6))
                End If
                If (diversificado And alumnos(i, 2) = "diversificado") Or ((Not diversificado) And alumnos(i, 2) <> "diversificado") Then
                    totalNivel = totalNivel + Val(alumnos(i, 6))
                End If
                If carrera = alumnos(i, 7) Then
                    totalCarrera = totalCarrera + 1
                End If
            End If
        Next i

        Form1.TXTtgeneral.Text = totalGeneral
        Form1.TXTtformaPago.Text = totalForma
        Form1.TXTnivelBueno.Text = totalNivel
        Form1.TXTtinscritos.Text = totalCarrera
    End Sub

    Sub Mostrar()

        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 7
            If alumnos(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(alumnos(i, 0), alumnos(i, 1), alumnos(i, 2), alumnos(i, 3), alumnos(i, 4), alumnos(i, 5), alumnos(i, 6), alumnos(i, 7))
            End If
        Next
    End Sub

    Function calcularInicial(diversificado As Boolean)
        Dim total As Double = 0
        If diversificado Then
            total = inscripcionDiversificado + primerDiversificado
        Else
            total = inscripcionBasico + primerBasico
        End If
        Return total
    End Function

    Function calcularRecargo(tarjeta As Boolean, inicial As Double)
        If tarjeta Then
            Return inicial * 1.1
        End If
        Return inicial
    End Function

    Sub LimpiarEntradas()
        Form1.TXTnombre.Clear()
        Form1.TXTcarnet.Clear()

        Form1.RDbasico.Checked = False
        Form1.RDdiversificado.Checked = False

        Form1.CMBcarreras.Text = ""
        Form1.CMBformaPago.Text = ""
    End Sub

    Sub LimpiarMatriz()
        Dim i As Byte
        Dim j As Byte
        For i = 0 To 7
            For j = 0 To 6
                alumnos(i, j) = ""
            Next j
        Next i
        Mostrar()
        fila = 0
    End Sub

    Sub LimpiarTotales()
        Form1.TXTtformaPago.Clear()
        Form1.TXTtgeneral.Clear()
        Form1.TXTtinscritos.Clear()
        Form1.TXTnivelBueno.Clear()
    End Sub
    Sub salir()

        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            LimpiarEntradas()
            LimpiarMatriz()
            LimpiarTotales()
        End If
    End Sub

End Module
