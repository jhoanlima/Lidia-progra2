Public Class Form1
    'Tengo comentarios bien tontos o "obvios" pero me sirve para estudiar luego, please ignorelos 
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RDmatrimonial.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub BTNlimpiar_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        'Metodo para usar en el boton de limpiar y para evitar que supere su maximo de yardas
        TXTlino.Clear()
        TXTalgodon.Clear()
        TXTseda.Clear()
        TXThiloCrudo.Clear()

        Lcosto.Text = ""
        Lventa.Text = ""
        LcostoLino.Text = ""
        LcostoAlgodon.Text = ""
        LcostoSeda.Text = ""
        LcostoHilo.Text = ""

        RDimperial.Checked = False
        RDmatrimonial.Checked = False
        RDqueen.Checked = False
        RDking.Checked = False

        CBlino.Checked = False
        CBalgdon.Checked = False
        CBseda.Checked = False
        CBhiloCrudo.Checked = False
    End Sub

    Private Sub BTNsalir_Click(sender As Object, e As EventArgs) Handles BTNsalir.Click
        Dim formSalida As Salir = New Salir
        Me.Hide()
        formSalida.Show()
    End Sub

    Private Sub CBlino_CheckedChanged(sender As Object, e As EventArgs) Handles CBlino.CheckedChanged
        If CBlino.Checked = True Then
            TXTlino.Enabled = True
        Else
            TXTlino.Enabled = False
        End If
    End Sub

    Private Sub CBalgdon_CheckedChanged(sender As Object, e As EventArgs) Handles CBalgdon.CheckedChanged
        If CBalgdon.Checked = True Then
            TXTalgodon.Enabled = True
        Else
            TXTlino.Enabled = False
        End If
    End Sub

    Private Sub BTNcalcular_Click(sender As Object, e As EventArgs) Handles BTNcalcular.Click
        Dim lino As Double
        Dim algodon As Double
        Dim seda As Double
        Dim hilo As Double

        '<> significa que es disitinto a 
        ' "" significa que esta vacio, y se hizo con if para que no me slaga error
        If TXTlino.Text <> "" Then
            lino = TXTlino.Text
        End If
        If TXTalgodon.Text <> "" Then
            algodon = TXTalgodon.Text
        End If
        If TXTseda.Text <> "" Then
            seda = TXTseda.Text
        End If
        If TXThiloCrudo.Text <> "" Then
            hilo = TXThiloCrudo.Text
        End If

        'en caso de checked sea true omitir es redundante, truco que aprendi despues
        If RDimperial.Checked Then
            comprobarMaterial(yardaImperia, lino, algodon, seda, hilo, costoImperial)
        End If
        If RDmatrimonial.Checked Then
            comprobarMaterial(yardaMatrimonial, lino, algodon, seda, hilo, costoMatrimonial)
        End If
        If RDqueen.Checked Then
            comprobarMaterial(yardaQueen, lino, algodon, seda, hilo, costoQueen)
        End If
        If RDking.Checked Then
            comprobarMaterial(yardaKing, lino, algodon, seda, hilo, costoKing)
        End If
    End Sub
    Private Sub comprobarMaterial(maximo As Double, lino As Double, algodon As Double, seda As Double, hilo As Double, costo As Double)
        ' el metodo comprobarMaterial fue para optimizar las instrucciones de operaciones
        LimpiarCostos()
        Dim total As Double
        Dim precioLino As Double = lino * unitarioLino
        Dim precioAlgodon As Double = algodon * unitarioAlgodon
        Dim precioSeda As Double = seda * unitarioSeda
        Dim precioHilo As Double = hilo * unitarioHilo
        Dim costoTotal As Double
        'la variable total es la cantidad ingresada de yardas
        total = lino + algodon + seda + hilo
        costoTotal = precioLino + precioAlgodon + precioSeda + precioHilo + costo
        If maximo = total Then
            Lcosto.Text = costoTotal
            LcostoLino.Text = precioLino
            LcostoAlgodon.Text = precioAlgodon
            LcostoSeda.Text = precioSeda
            LcostoHilo.Text = precioHilo
            Lventa.Text = (costoTotal * 1.65)
        Else
            TXTlino.Text = ""
            TXTalgodon.Text = ""
            TXTseda.Text = ""
            TXThiloCrudo.Text = ""
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub LimpiarCostos()
        Lcosto.Text = ""
        LcostoLino.Text = ""
        LcostoAlgodon.Text = ""
        LcostoSeda.Text = ""
        LcostoHilo.Text = ""
        Lventa.Text = ""
    End Sub

    Private Sub CBseda_CheckedChanged(sender As Object, e As EventArgs) Handles CBseda.CheckedChanged
        If CBseda.Checked Then
            TXTseda.Enabled = True
        Else
            TXTseda.Enabled = False
        End If
    End Sub

    Private Sub CBhiloCrudo_CheckedChanged(sender As Object, e As EventArgs) Handles CBhiloCrudo.CheckedChanged
        If CBhiloCrudo.Checked Then
            TXThiloCrudo.Enabled = True
        Else
            TXThiloCrudo.Enabled = False
        End If
    End Sub

    Private Sub RDimperial_CheckedChanged(sender As Object, e As EventArgs) Handles RDimperial.CheckedChanged

    End Sub
End Class
