Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ProcesarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarToolStripMenuItem.Click
        Proceso(ComboBox2.Text, Val(TextBox4.Text), ComboBox1.Text)
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiarentradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiarvector()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim formSalida As Salir = New Salir
        Me.Hide()
        formSalida.Show()
    End Sub
End Class
