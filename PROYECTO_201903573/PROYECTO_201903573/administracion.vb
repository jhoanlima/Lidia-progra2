Public Class administracion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNgestionarLibros.Click

    End Sub

    Private Sub BTNreportes_Click(sender As Object, e As EventArgs) Handles BTNreportes.Click
        Dim formPrincipal As reportes = New reportes
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim formPrincipal As Form1 = New Form1
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNgestionEditorial_Click(sender As Object, e As EventArgs) Handles BTNgestionEditorial.Click
        Dim formPrincipal As edtorial = New edtorial
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class