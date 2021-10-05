Public Class cliente
    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As administracion = New administracion
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim formPrincipal As Form1 = New Form1
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNprestados_Click(sender As Object, e As EventArgs) Handles BTNprestados.Click
        Dim formPrincipal As Prestados = New Prestados
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNprestar_Click(sender As Object, e As EventArgs) Handles BTNprestar.Click
        Dim formPrincipal As presor = New presor
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNeditarPerfil_Click(sender As Object, e As EventArgs) Handles BTNeditarPerfil.Click
        Dim formPrincipal As perfil = New perfil
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class