Public Class Salirform
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNsi.Click
        End
    End Sub

    Private Sub BTNno_Click(sender As Object, e As EventArgs) Handles BTNno.Click
        Dim formPrincipal As Form1 = New Form1
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class