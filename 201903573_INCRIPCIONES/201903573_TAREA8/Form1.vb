Public Class Form1
    Private Sub BTNltotales_Click(sender As Object, e As EventArgs) Handles BTNltotales.Click
        LimpiarTotales()
    End Sub

    Private Sub BTNlentradas_Click(sender As Object, e As EventArgs) Handles BTNlentradas.Click
        LimpiarEntradas()
    End Sub

    Private Sub BTNsalir_Click(sender As Object, e As EventArgs) Handles BTNsalir.Click
        salir()
    End Sub

    Private Sub BTNaceptar_Click(sender As Object, e As EventArgs) Handles BTNaceptar.Click
        Agregar()
    End Sub

    Private Sub RDdiversificado_CheckedChanged(sender As Object, e As EventArgs) Handles RDdiversificado.CheckedChanged

    End Sub

    Private Sub BTNlmatriz_Click(sender As Object, e As EventArgs) Handles BTNlmatriz.Click
        LimpiarMatriz()
    End Sub

    Private Sub BTNtotales_Click(sender As Object, e As EventArgs) Handles BTNtotales.Click
        totales()
    End Sub
End Class
