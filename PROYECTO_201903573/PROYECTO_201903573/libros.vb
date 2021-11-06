Imports System.Data.SqlClient
Public Class libros
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myCmd1 As SqlCommand
    Private myCmd2 As SqlCommand
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As administracion = New administracion
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub BTNlimpiar_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        TXTautor.Clear()
        CMBgenero.Text = ""
        TXTtitulo.Clear()
        TXTcantidad.Clear()
        CMBeditorial.Text = ""
    End Sub

    Private Sub libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarLibros()
    End Sub

    Private Sub MostrarLibros()
        Try
            myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
              "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
            myConn.Open()
            Dim myCmd1 As SqlCommand = New SqlCommand("select genero.nombre,titulo,autor,editorial.nombre from libro,editorial,genero where libro.genero = genero.id_genero and libro.id_editorial = editorial.id_editorial;", myConn)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(myCmd1)
            Dim dataTable As DataTable = New DataTable()
            adapter.Fill(dataTable)
            For Each row As DataRow In dataTable.Rows
                Dim genero = row.ItemArray(0)
                Dim titulo = row.ItemArray(1)
                Dim autor = row.ItemArray(2)
                Dim editorial = row.ItemArray(3)
                DATAlibros.Rows.Add(titulo, autor, genero, editorial)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub AgregarLibro()
        myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
                                  "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
        Dim editorial As String = CMBeditorial.Text
        Dim genero As String = CMBgenero.Text
        Dim titulo As String = TXTtitulo.Text
        Dim autor As String = TXTautor.Text
        Dim cantidad As String = TXTcantidad.Text

        Try
            myConn.Open()
            Dim consultaEditorial As String = "select id_editorial from editorial where nombre = '" + editorial + "'"
            Dim consultaGenero As String = "select id_genero from genero where nombre = '" + genero + "'"

            myCmd1 = myConn.CreateCommand
            myCmd1.CommandText = consultaEditorial
            myCmd2 = myConn.CreateCommand
            myCmd2.CommandText = consultaGenero

            Dim adapterEditorial As New SqlDataAdapter(myCmd1)
            Dim tableEditorial As New DataTable()
            adapterEditorial.Fill(tableEditorial)
            Dim adapterGenero As New SqlDataAdapter(myCmd2)
            Dim tableGenero As New DataTable()
            adapterGenero.Fill(tableGenero)

            Dim idEditorial As String = ""
            For Each row As DataRow In tableEditorial.Rows
                idEditorial = row.ItemArray(0)
            Next
            Dim idGenero As String = ""
            For Each row As DataRow In tableGenero.Rows
                idGenero = row.ItemArray(0)
            Next
            If idEditorial <> "" And idGenero <> "" Then
                Dim consulta As String = "insert into libro (id_editorial, genero, titulo, autor, cantidad) values (" + idEditorial + "," + idGenero + ",'" + titulo + "','" + autor + "'," + cantidad + ")"
                myCmd = New SqlCommand(consulta, myConn)
                myCmd.ExecuteNonQuery()
            End If
            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateLibro()
        myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
                                  "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")
        Dim editorial As String = CMBeditorial.Text
        Dim genero As String = CMBgenero.Text
        Dim titulo As String = TXTtitulo.Text
        Dim autor As String = TXTautor.Text
        Dim cantidad As String = TXTcantidad.Text

        Try
            myConn.Open()
            Dim consultaEditorial As String = "select id_editorial from editorial where nombre = '" + editorial + "'"
            Dim consultaGenero As String = "select id_genero from genero where nombre = '" + genero + "'"

            myCmd1 = myConn.CreateCommand
            myCmd1.CommandText = consultaEditorial
            myCmd2 = myConn.CreateCommand
            myCmd2.CommandText = consultaGenero

            Dim adapterEditorial As New SqlDataAdapter(myCmd1)
            Dim tableEditorial As New DataTable()
            adapterEditorial.Fill(tableEditorial)
            Dim adapterGenero As New SqlDataAdapter(myCmd2)
            Dim tableGenero As New DataTable()
            adapterGenero.Fill(tableGenero)

            Dim idEditorial As String = ""
            For Each row As DataRow In tableEditorial.Rows
                idEditorial = row.ItemArray(0)
            Next
            Dim idGenero As String = ""
            For Each row As DataRow In tableGenero.Rows
                idGenero = row.ItemArray(0)
            Next
            If idEditorial <> "" And idGenero <> "" Then
                Dim consulta As String = "update libro set id_editorial =" + idEditorial + ", genero = " + idGenero + ", autor = '" + autor + "', cantidad = " + cantidad + " where titulo = '" + titulo + "'"
                myCmd = New SqlCommand(consulta, myConn)
                myCmd.ExecuteNonQuery()
            End If
            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BTNagregar_Click(sender As Object, e As EventArgs) Handles BTNagregar.Click
        AgregarLibro()
        DATAlibros.Rows.Clear()
        MostrarLibros()
    End Sub

    Private Sub BTNmodificar_Click(sender As Object, e As EventArgs) Handles BTNmodificar.Click
        UpdateLibro()
        DATAlibros.Rows.Clear()
        MostrarLibros()
    End Sub
End Class