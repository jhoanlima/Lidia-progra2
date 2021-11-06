Imports System.Data.SqlClient
Public Class presor
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myCmd1 As SqlCommand
    Private myCmd2 As SqlCommand
    Private Sub BTNregresar_Click(sender As Object, e As EventArgs) Handles BTNregresar.Click
        Dim formPrincipal As cliente = New cliente
        Me.Hide()
        formPrincipal.Show()
    End Sub

    Private Sub presor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub buscar()
        DATAprestor.Rows.Clear()

        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try
            myCmd = myConn.CreateCommand
            If CMBbuscar.SelectedIndex <> -1 And TXTbuscar.Text = Nothing Then
                myCmd.CommandText = "SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
                                FROM Libro, Prestamo, Genero, Editorial																	 
                                WHERE Prestamo.id_libro = Libro.id_libro																 
                                AND Libro.id_editorial = Editorial.id_editorial															
                                AND Libro.genero = Genero.id_genero
                                AND Genero.nombre = @genero
                                GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre"
                myCmd.Parameters.AddWithValue("@genero", CMBbuscar.Text)
            ElseIf TXTbuscar.Text <> Nothing And CMBbuscar.SelectedIndex = -1 Then
                myCmd.CommandText = "SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
                                FROM Libro, Prestamo, Genero, Editorial																	 
                                WHERE Prestamo.id_libro = Libro.id_libro																 
                                AND Libro.id_editorial = Editorial.id_editorial															
                                AND Libro.genero = Genero.id_genero
                                AND Libro.titulo LIKE @titulo
                                GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre"
                myCmd.Parameters.AddWithValue("@titulo", "%" + TXTbuscar.Text + "%")
            Else
                MsgBox("Solo está permitido un tipo de búsqueda")
                Exit Sub
            End If

            myConn.Open()

            Dim adapter As New SqlDataAdapter(myCmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows

                Dim titulo = row.ItemArray(0)
                Dim autor = row.ItemArray(1)
                Dim genero = row.ItemArray(2)
                Dim editorial = row.ItemArray(3)
                Dim disp = row.ItemArray(4)
                If disp > 0 Then
                    DATAprestor.Rows.Add(titulo, autor, genero, editorial, disp)
                End If
            Next

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo salio mal")
        End Try

    End Sub

    Private Sub mostrar()

    End Sub
    Private Sub BTNbuscar_Click(sender As Object, e As EventArgs) Handles BTNbuscar.Click
        buscar()
    End Sub
End Class