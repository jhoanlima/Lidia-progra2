Imports System.Data.SqlClient

Public Class edtorial
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader


    'MOSTRAR DATOS PENDIENTE

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNagregar.Click
        Dim nombre As String = TXTeditNombre.Text
        Dim direccion As String = TXTeditDireccion.Text
        Dim telefono As String = TXTtelefono.Text
        Dim consulta As String = "insert into Editorial (nombre, direccion, telefono) values ('" + nombre + "','" + direccion + "'," + telefono + ");"
        Try
            myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
                                      "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
            myConn.Open()
            If myConn.State() = 1 Then
                myCmd = New SqlCommand(consulta, myConn)
                myCmd.ExecuteNonQuery()
                MsgBox("Se almaceno exitosamente")
            Else
                MsgBox("Algo salió mal")
            End If
            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As administracion = New administracion
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNeliminar_Click(sender As Object, e As EventArgs) Handles BTNeliminar.Click
        Dim nombre As String = TXTeditNombre.Text
        Dim direccion As String = TXTeditDireccion.Text
        Dim telefono As String = TXTtelefono.Text

        Dim consulta As String = "delete from Editorial where nombre = '" + nombre + "'"
        Try
            myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
                                      "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
            myConn.Open()
            If myConn.State() = 1 Then
                myCmd = New SqlCommand(consulta, myConn)
                myCmd.ExecuteNonQuery()
                MsgBox("Se elimino exitosamente")

            Else
                MsgBox("Algo salió mal")
            End If
            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNmodificar_Click(sender As Object, e As EventArgs) Handles BTNmodificar.Click
        Dim nombre As String = TXTeditNombre.Text
        Dim direccion As String = TXTeditDireccion.Text
        Dim telefono As String = TXTtelefono.Text
        Dim consulta As String = "update Editorial set direccion = '" + direccion + "' ,telefono= " + telefono + " where nombre = '" + nombre + "';"
        Try
            myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
                                      "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
            myConn.Open()
            If myConn.State() = 1 Then
                myCmd = New SqlCommand(consulta, myConn)
                myCmd.ExecuteNonQuery()
                MsgBox("Se modifico exitosamente")

            Else
                MsgBox("Algo salió mal")
            End If
            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNlimpiar_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        Limpiar()
    End Sub

    Private Sub edtorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
              "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
            myConn.Open()
            Dim myCmd1 As SqlCommand = New SqlCommand("select * from editorial;", myConn)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(myCmd1)
            Dim dataTable As DataTable = New DataTable()
            adapter.Fill(dataTable)
            For Each row As DataRow In dataTable.Rows
                Dim nombre = row.ItemArray(1)
                Dim direccion = row.ItemArray(2)
                Dim telefono = row.ItemArray(3)
                DATAeditorial.Rows.Add(nombre, direccion, telefono)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DATAeditorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATAeditorial.CellContentClick

    End Sub
    Private Sub Limpiar()
        TXTeditDireccion.Clear()
        TXTeditNombre.Clear()
        TXTtelefono.Clear()
    End Sub


End Class