Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CBefectivo_CheckedChanged(sender As Object, e As EventArgs) Handles CBefectivo.CheckedChanged
        If CBefectivo.Checked Then
            TXTporcentajeEfectivo.Enabled = True
        Else
            TXTporcentajeEfectivo.Enabled = False
        End If
    End Sub

    Private Sub CBtarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles CBtarjeta.CheckedChanged
        If CBtarjeta.Checked Then
            TXTporcentajeTarjeta.Enabled = True
        Else
            TXTporcentajeTarjeta.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNcalcular.Click

        Calcular(CMBmarca.Text, Val(TXTdías.Text), Val(TXTporcentajeEfectivo.Text), Val(TXTporcentajeTarjeta.Text))
        verificar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiarvector()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiarentradas()
    End Sub
End Class
