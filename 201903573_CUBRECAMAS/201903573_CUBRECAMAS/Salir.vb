Public Class Salir
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTNno_Click(sender As Object, e As EventArgs) Handles BTNno.Click
        Dim formPrincipal As Form1 = New Form1
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNsi_Click(sender As Object, e As EventArgs) Handles BTNsi.Click
        End
    End Sub
End Class