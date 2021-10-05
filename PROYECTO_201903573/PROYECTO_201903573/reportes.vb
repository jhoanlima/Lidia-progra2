Public Class reportes

    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As administracion = New administracion
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class