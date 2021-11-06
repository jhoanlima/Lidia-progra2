Imports System.Data.SqlClient
Public Class reportes
    Private myConn As SqlConnection
    Private myCmd As SqlCommand

    Dim id_libro As Integer

    Dim libro As String

    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As administracion = New administracion
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reporteLibros()
        reporteEditorial()
    End Sub

    Private Sub reporteLibros()
        myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
             "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles], COUNT(Prestamo.id_libro) as [Prestados]
                                FROM Libro, Prestamo, Genero, Editorial																	 
                                WHERE Prestamo.id_libro = Libro.id_libro																 
                                AND Libro.id_editorial = Editorial.id_editorial															
                                AND Libro.genero = Genero.id_genero																				 
                                GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre"

            'Open the connection.
        Catch
            MsgBox("no se logro realizar la consulta")
        End Try

        Dim adapter As New SqlDataAdapter(myCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        For Each row As DataRow In table.Rows
            Dim titulo = row.ItemArray(0)
            Dim autor = row.ItemArray(1)
            Dim genero = row.ItemArray(2)
            Dim editorial = row.ItemArray(3)
            Dim disponibles = row.ItemArray(4)
            Dim prestados = row.ItemArray(5)
            DataGridView2.Rows.Add(titulo, autor, genero, editorial, disponibles, prestados)
        Next
    End Sub


    Private Sub reporteEditorial()
        myConn = New SqlConnection("Initial Catalog=DB_201903573;" &
             "Data Source=DESKTOP-4S91T6L\SQLEXPRESS;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Select distinct nombre,direccion,telefono, count(Libro.id_libro) from editorial, libro where libro.id_editorial = editorial.id_editorial group by editorial.nombre, editorial.direccion, editorial.telefono"

            'Open the connection.
        Catch
            MsgBox("no se logro realizar la consulta")
        End Try

        Dim adapter As New SqlDataAdapter(myCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        For Each row As DataRow In table.Rows
            Dim nombre = row.ItemArray(0)
            Dim direccion = row.ItemArray(1)
            Dim telefono = row.ItemArray(2)
            Dim libros = row.ItemArray(3)
            DataGridView1.Rows.Add(nombre, direccion, telefono, libros)
        Next

    End Sub

End Class