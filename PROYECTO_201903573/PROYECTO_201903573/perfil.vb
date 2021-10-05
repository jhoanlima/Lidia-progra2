Public Class perfil
    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As cliente = New cliente
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class