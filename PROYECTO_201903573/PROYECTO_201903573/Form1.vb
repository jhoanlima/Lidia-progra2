Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data

Public Class Form1
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private myAdapter As SqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BTNlogin_Click(sender As Object, e As EventArgs) Handles BTNlogin.Click
        Try
            myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
          "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
            myConn.Open()
            Dim userid As String = TXTnombre.Text
            Dim password As String = TXTcontraseña.Text
            Dim myCmd1 As SqlCommand = New SqlCommand("select usuario,contrasenia from Usuario where usuario='" + TXTnombre.Text + "'and contrasenia='" + TXTcontraseña.Text + "'", myConn)
            Dim myReader1 As SqlDataReader = myCmd1.ExecuteReader



            If myReader1.HasRows = True Then
                myReader1.Close()
                Dim myCmd2 As SqlCommand = New SqlCommand("select usuario, tipo_usr from Usuario where tipo_usr = 'Administrador' and usuario='" + TXTnombre.Text + "'", myConn)
                Dim myReader2 As SqlDataReader = myCmd2.ExecuteReader
                If myReader2.HasRows = True Then
                    Dim formPrincipal As administracion = New administracion
                    Me.Hide()
                    formPrincipal.Show()
                Else
                    Dim formPrincipal As cliente = New cliente
                    Me.Hide()
                    formPrincipal.Show()
                End If
                myReader2.Close()
            Else
                MsgBox("Contraseña invalida")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BTNverificar_Click(sender As Object, e As EventArgs) Handles BTNverificar.Click
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
        "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")

        Try
            'Open the connection.
            myConn.Open()

            If myConn.State() = 1 Then
                MsgBox("Se conectó exitosamente a la base de datos")
            Else
                MsgBox("Algo salió mal :(")
            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo salio mal")
        End Try
    End Sub

    Private Sub BTNregistrarse_Click(sender As Object, e As EventArgs) Handles BTNregistrarse.Click
        Dim formPrincipal As registro = New registro
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNsalir_Click(sender As Object, e As EventArgs) Handles BTNsalir.Click
        Dim formPrincipal As salir = New salir
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class
