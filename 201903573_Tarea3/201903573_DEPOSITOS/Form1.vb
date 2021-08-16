Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GBtipoDeposito.Enter
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBmPremier.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CBcheque.CheckedChanged
        'Para habilitar el textbox con el checkbox
        If CBcheque.Checked = True Then
            TXTcheque.Enabled = True
        Else
            TXTcheque.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CBefectivo.CheckedChanged
        'Para habilitar el textbox con el checkbox
        If CBefectivo.Checked = True Then
            TXTefectivo.Enabled = True
        Else
            TXTefectivo.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lcheque.Click

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GBsaldo.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTsaldoAnterior.TextChanged

    End Sub

    Private Sub GBmetodo_Enter(sender As Object, e As EventArgs) Handles GBmetodo.Enter

    End Sub

    Private Sub CBotros_CheckedChanged(sender As Object, e As EventArgs) Handles CBotros.CheckedChanged
        'Para habilitar el textbox con el checkbox
        If CBotros.Checked = True Then
            TXTotro.Enabled = True
        Else
            TXTotro.Enabled = False
        End If
    End Sub

    Private Sub BTNcalcular_Click(sender As Object, e As EventArgs) Handles BTNcalcular.Click
        Dim saldoAnterior As Double
        Dim saldoNuevo As Double
        Dim chequePropio As Double
        Dim chequeOtro As Double
        Dim efectivo As Double
        Dim interes As Double
        saldoAnterior = TXTsaldoAnterior.Text
        chequePropio = TXTcheque.Text
        chequeOtro = TXTotro.Text
        efectivo = TXTefectivo.Text
        saldoNuevo = saldoAnterior + chequePropio + chequeOtro + efectivo

        'Calculos de interes para deposito de ahorro
        If RBahorros.Checked = True Then
            seleccion = RBahorros.Text
            Select Case saldoNuevo

                Case 1 To 1001
                    interes = saldoNuevo * 0.015
                Case 1001 To 5001
                    interes = saldoNuevo * 0.025
                Case 5001 To 15001
                    interes = saldoNuevo * 0.075
                Case Else
                    interes = saldoNuevo * 0.1

            End Select
        End If
        'Calculo de interes para deposito monetario premier
        If RBmPremier.Checked = True Then
            seleccion = RBmPremier.Text
            Select Case saldoAnterior
                Case 1 To 10001
                    interes = saldoAnterior * 0.025
                Case 10001 To 15001
                    interes = saldoAnterior * 0.03
                Case Else
                    interes = saldoAnterior * 0.045
            End Select
        End If
        TXTsaldoNuevo.Text = saldoNuevo
        TXTinteres.Text = interes


    End Sub

    Private Sub GroupBox1_Enter_2(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        ' Para limpiar los textbox
        TXTcheque.Clear()
        TXTotro.Clear()
        TXTefectivo.Clear()
        TXTsaldoAnterior.Clear()
        TXTsaldoNuevo.Clear()
        TXTinteres.Clear()
        ' para limpiar los checkbox
        CBcheque.Checked = False
        CBotros.Checked = False
        CBefectivo.Checked = False





    End Sub

    Private Sub BTNsalir_Click(sender As Object, e As EventArgs) Handles BTNsalir.Click
        Dim formSalida As Salirform = New Salirform
        Me.Hide()
        formSalida.Show()
    End Sub
End Class
