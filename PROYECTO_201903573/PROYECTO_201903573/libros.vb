Public Class libros
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As administracion = New administracion
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNlimpiar_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        TXTautor.Clear()
        TXTgenero.Clear()
        TXTtitulo.Clear()

        CMBeditorial.Text = ""
    End Sub
End Class