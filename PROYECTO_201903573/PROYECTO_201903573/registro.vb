Imports System.Data.SqlClient
Public Class registro
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTNregistro2_Click(sender As Object, e As EventArgs) Handles BTNregistro2.Click
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
        "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")

        Try
            'Open the connection.
            myConn.Open()

            If myConn.State() = 1 Then
                myCmd = New SqlCommand(registro(TXTnombre.Text, TXTapellido.Text, TXTusuario.Text, CMBtusuario.Text, DateTimePicker1.Value, TXTcontraseña.Text), myConn)
                myCmd.ExecuteNonQuery()
                MsgBox("Se registro exitosamente")
                limpiar()
            Else
                MsgBox("Algo salió mal")
            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try
    End Sub
    Private Function registro(nombre As String, apellido As String, usuario As String, admin As String, nacimiento As Date, contrasena As String)
        Dim consult As String = "INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia)
VALUES('" + nombre + "','" + apellido + " ','" + usuario + "','" + admin + "','" + nacimiento + "','" + contrasena + "');"
        Return (consult)
    End Function

    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As Form1 = New Form1
        Me.Hide()
        formPrincipal.Show()
    End Sub
    Private Sub limpiar()
        TXTapellido.Clear()
        TXTnombre.Clear()
        TXTusuario.Clear()
        TXTcontraseña.Clear()

        CMBtusuario.Text = ""

    End Sub

End Class