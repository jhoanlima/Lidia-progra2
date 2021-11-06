Imports System.Data.SqlClient
Public Class perfil
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As cliente = New cliente
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class