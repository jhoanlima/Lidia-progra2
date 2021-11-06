Imports System.Data.SqlClient
Public Class Prestados
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myCmd1 As SqlCommand
    Private myCmd2 As SqlCommand
    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As cliente = New cliente
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub Prestados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()

    End Sub

    Private Sub DATAprestados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATAprestados.CellContentClick

    End Sub
End Class