<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBtipoDeposito = New System.Windows.Forms.GroupBox()
        Me.RBahorros = New System.Windows.Forms.RadioButton()
        Me.RBmPremier = New System.Windows.Forms.RadioButton()
        Me.RBmonetario = New System.Windows.Forms.RadioButton()
        Me.GBmetodo = New System.Windows.Forms.GroupBox()
        Me.CBefectivo = New System.Windows.Forms.CheckBox()
        Me.CBotros = New System.Windows.Forms.CheckBox()
        Me.CBcheque = New System.Windows.Forms.CheckBox()
        Me.GBmonto = New System.Windows.Forms.GroupBox()
        Me.TXTefectivo = New System.Windows.Forms.TextBox()
        Me.TXTotro = New System.Windows.Forms.TextBox()
        Me.TXTcheque = New System.Windows.Forms.TextBox()
        Me.Lefectivo = New System.Windows.Forms.Label()
        Me.Lpropio = New System.Windows.Forms.Label()
        Me.Lcheque = New System.Windows.Forms.Label()
        Me.GBsaldo = New System.Windows.Forms.GroupBox()
        Me.Lsaldo = New System.Windows.Forms.Label()
        Me.TXTsaldoAnterior = New System.Windows.Forms.TextBox()
        Me.BTNcalcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTsaldoNuevo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTinteres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNlimpiar = New System.Windows.Forms.Button()
        Me.BTNsalir = New System.Windows.Forms.Button()
        Me.GBtipoDeposito.SuspendLayout()
        Me.GBmetodo.SuspendLayout()
        Me.GBmonto.SuspendLayout()
        Me.GBsaldo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBtipoDeposito
        '
        Me.GBtipoDeposito.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GBtipoDeposito.Controls.Add(Me.RBahorros)
        Me.GBtipoDeposito.Controls.Add(Me.RBmPremier)
        Me.GBtipoDeposito.Controls.Add(Me.RBmonetario)
        Me.GBtipoDeposito.Location = New System.Drawing.Point(37, 77)
        Me.GBtipoDeposito.Name = "GBtipoDeposito"
        Me.GBtipoDeposito.Size = New System.Drawing.Size(218, 251)
        Me.GBtipoDeposito.TabIndex = 0
        Me.GBtipoDeposito.TabStop = False
        Me.GBtipoDeposito.Text = "Tipo de Deposito"
        '
        'RBahorros
        '
        Me.RBahorros.AutoSize = True
        Me.RBahorros.Location = New System.Drawing.Point(28, 190)
        Me.RBahorros.Name = "RBahorros"
        Me.RBahorros.Size = New System.Drawing.Size(79, 21)
        Me.RBahorros.TabIndex = 2
        Me.RBahorros.TabStop = True
        Me.RBahorros.Text = "Ahorros"
        Me.RBahorros.UseVisualStyleBackColor = True
        '
        'RBmPremier
        '
        Me.RBmPremier.AutoSize = True
        Me.RBmPremier.Location = New System.Drawing.Point(28, 117)
        Me.RBmPremier.Name = "RBmPremier"
        Me.RBmPremier.Size = New System.Drawing.Size(145, 21)
        Me.RBmPremier.TabIndex = 1
        Me.RBmPremier.TabStop = True
        Me.RBmPremier.Text = "Monetario Premier"
        Me.RBmPremier.UseVisualStyleBackColor = True
        '
        'RBmonetario
        '
        Me.RBmonetario.AutoSize = True
        Me.RBmonetario.Location = New System.Drawing.Point(28, 53)
        Me.RBmonetario.Name = "RBmonetario"
        Me.RBmonetario.Size = New System.Drawing.Size(92, 21)
        Me.RBmonetario.TabIndex = 0
        Me.RBmonetario.TabStop = True
        Me.RBmonetario.Text = "Monetario"
        Me.RBmonetario.UseVisualStyleBackColor = True
        '
        'GBmetodo
        '
        Me.GBmetodo.BackColor = System.Drawing.Color.SkyBlue
        Me.GBmetodo.Controls.Add(Me.CBefectivo)
        Me.GBmetodo.Controls.Add(Me.CBotros)
        Me.GBmetodo.Controls.Add(Me.CBcheque)
        Me.GBmetodo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GBmetodo.Location = New System.Drawing.Point(314, 78)
        Me.GBmetodo.Name = "GBmetodo"
        Me.GBmetodo.Size = New System.Drawing.Size(221, 250)
        Me.GBmetodo.TabIndex = 1
        Me.GBmetodo.TabStop = False
        Me.GBmetodo.Text = "Método de Deposito"
        '
        'CBefectivo
        '
        Me.CBefectivo.AutoSize = True
        Me.CBefectivo.Location = New System.Drawing.Point(33, 190)
        Me.CBefectivo.Name = "CBefectivo"
        Me.CBefectivo.Size = New System.Drawing.Size(80, 21)
        Me.CBefectivo.TabIndex = 3
        Me.CBefectivo.Text = "Efectivo"
        Me.CBefectivo.UseVisualStyleBackColor = True
        '
        'CBotros
        '
        Me.CBotros.AutoSize = True
        Me.CBotros.Location = New System.Drawing.Point(33, 118)
        Me.CBotros.Name = "CBotros"
        Me.CBotros.Size = New System.Drawing.Size(169, 21)
        Me.CBotros.TabIndex = 2
        Me.CBotros.Text = "Cheque Otros Bancos"
        Me.CBotros.UseVisualStyleBackColor = True
        '
        'CBcheque
        '
        Me.CBcheque.AutoSize = True
        Me.CBcheque.Location = New System.Drawing.Point(33, 53)
        Me.CBcheque.Name = "CBcheque"
        Me.CBcheque.Size = New System.Drawing.Size(124, 21)
        Me.CBcheque.TabIndex = 0
        Me.CBcheque.Text = "Cheque Propio"
        Me.CBcheque.UseVisualStyleBackColor = True
        '
        'GBmonto
        '
        Me.GBmonto.BackColor = System.Drawing.Color.PowderBlue
        Me.GBmonto.Controls.Add(Me.TXTefectivo)
        Me.GBmonto.Controls.Add(Me.TXTotro)
        Me.GBmonto.Controls.Add(Me.TXTcheque)
        Me.GBmonto.Controls.Add(Me.Lefectivo)
        Me.GBmonto.Controls.Add(Me.Lpropio)
        Me.GBmonto.Controls.Add(Me.Lcheque)
        Me.GBmonto.Location = New System.Drawing.Point(597, 82)
        Me.GBmonto.Name = "GBmonto"
        Me.GBmonto.Size = New System.Drawing.Size(221, 246)
        Me.GBmonto.TabIndex = 2
        Me.GBmonto.TabStop = False
        Me.GBmonto.Text = " Ingresar Monto"
        '
        'TXTefectivo
        '
        Me.TXTefectivo.Enabled = False
        Me.TXTefectivo.Location = New System.Drawing.Point(52, 188)
        Me.TXTefectivo.Name = "TXTefectivo"
        Me.TXTefectivo.Size = New System.Drawing.Size(100, 22)
        Me.TXTefectivo.TabIndex = 5
        Me.TXTefectivo.Text = "0"
        '
        'TXTotro
        '
        Me.TXTotro.Enabled = False
        Me.TXTotro.Location = New System.Drawing.Point(52, 118)
        Me.TXTotro.Name = "TXTotro"
        Me.TXTotro.Size = New System.Drawing.Size(100, 22)
        Me.TXTotro.TabIndex = 4
        Me.TXTotro.Text = "0"
        '
        'TXTcheque
        '
        Me.TXTcheque.Enabled = False
        Me.TXTcheque.Location = New System.Drawing.Point(52, 49)
        Me.TXTcheque.Name = "TXTcheque"
        Me.TXTcheque.Size = New System.Drawing.Size(100, 22)
        Me.TXTcheque.TabIndex = 3
        Me.TXTcheque.Text = "0"
        '
        'Lefectivo
        '
        Me.Lefectivo.AutoSize = True
        Me.Lefectivo.Location = New System.Drawing.Point(23, 188)
        Me.Lefectivo.Name = "Lefectivo"
        Me.Lefectivo.Size = New System.Drawing.Size(23, 17)
        Me.Lefectivo.TabIndex = 2
        Me.Lefectivo.Text = "Q."
        '
        'Lpropio
        '
        Me.Lpropio.AutoSize = True
        Me.Lpropio.Location = New System.Drawing.Point(23, 118)
        Me.Lpropio.Name = "Lpropio"
        Me.Lpropio.Size = New System.Drawing.Size(23, 17)
        Me.Lpropio.TabIndex = 1
        Me.Lpropio.Text = "Q."
        '
        'Lcheque
        '
        Me.Lcheque.AutoSize = True
        Me.Lcheque.Location = New System.Drawing.Point(23, 49)
        Me.Lcheque.Name = "Lcheque"
        Me.Lcheque.Size = New System.Drawing.Size(23, 17)
        Me.Lcheque.TabIndex = 0
        Me.Lcheque.Text = "Q."
        '
        'GBsaldo
        '
        Me.GBsaldo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GBsaldo.Controls.Add(Me.Lsaldo)
        Me.GBsaldo.Controls.Add(Me.TXTsaldoAnterior)
        Me.GBsaldo.Location = New System.Drawing.Point(849, 85)
        Me.GBsaldo.Name = "GBsaldo"
        Me.GBsaldo.Size = New System.Drawing.Size(227, 100)
        Me.GBsaldo.TabIndex = 3
        Me.GBsaldo.TabStop = False
        Me.GBsaldo.Text = "Ingresar Valor del Saldo Anterior"
        '
        'Lsaldo
        '
        Me.Lsaldo.AutoSize = True
        Me.Lsaldo.Location = New System.Drawing.Point(16, 49)
        Me.Lsaldo.Name = "Lsaldo"
        Me.Lsaldo.Size = New System.Drawing.Size(23, 17)
        Me.Lsaldo.TabIndex = 6
        Me.Lsaldo.Text = "Q."
        '
        'TXTsaldoAnterior
        '
        Me.TXTsaldoAnterior.Location = New System.Drawing.Point(45, 46)
        Me.TXTsaldoAnterior.Name = "TXTsaldoAnterior"
        Me.TXTsaldoAnterior.Size = New System.Drawing.Size(100, 22)
        Me.TXTsaldoAnterior.TabIndex = 0
        '
        'BTNcalcular
        '
        Me.BTNcalcular.Location = New System.Drawing.Point(224, 393)
        Me.BTNcalcular.Name = "BTNcalcular"
        Me.BTNcalcular.Size = New System.Drawing.Size(75, 23)
        Me.BTNcalcular.TabIndex = 4
        Me.BTNcalcular.Text = "Calcular"
        Me.BTNcalcular.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTsaldoNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(849, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 89)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saldo Nuevo"
        '
        'TXTsaldoNuevo
        '
        Me.TXTsaldoNuevo.Location = New System.Drawing.Point(37, 34)
        Me.TXTsaldoNuevo.Name = "TXTsaldoNuevo"
        Me.TXTsaldoNuevo.Size = New System.Drawing.Size(100, 22)
        Me.TXTsaldoNuevo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Q."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TXTinteres)
        Me.GroupBox2.Location = New System.Drawing.Point(849, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 81)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Interes a Pagar"
        '
        'TXTinteres
        '
        Me.TXTinteres.Location = New System.Drawing.Point(37, 40)
        Me.TXTinteres.Name = "TXTinteres"
        Me.TXTinteres.Size = New System.Drawing.Size(100, 22)
        Me.TXTinteres.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Q."
        '
        'BTNlimpiar
        '
        Me.BTNlimpiar.Location = New System.Drawing.Point(383, 393)
        Me.BTNlimpiar.Name = "BTNlimpiar"
        Me.BTNlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTNlimpiar.TabIndex = 7
        Me.BTNlimpiar.Text = "Limpiar"
        Me.BTNlimpiar.UseVisualStyleBackColor = True
        '
        'BTNsalir
        '
        Me.BTNsalir.Location = New System.Drawing.Point(538, 393)
        Me.BTNsalir.Name = "BTNsalir"
        Me.BTNsalir.Size = New System.Drawing.Size(75, 23)
        Me.BTNsalir.TabIndex = 8
        Me.BTNsalir.Text = "Salir"
        Me.BTNsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1079, 512)
        Me.Controls.Add(Me.BTNsalir)
        Me.Controls.Add(Me.BTNlimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNcalcular)
        Me.Controls.Add(Me.GBsaldo)
        Me.Controls.Add(Me.GBmonto)
        Me.Controls.Add(Me.GBmetodo)
        Me.Controls.Add(Me.GBtipoDeposito)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBtipoDeposito.ResumeLayout(False)
        Me.GBtipoDeposito.PerformLayout()
        Me.GBmetodo.ResumeLayout(False)
        Me.GBmetodo.PerformLayout()
        Me.GBmonto.ResumeLayout(False)
        Me.GBmonto.PerformLayout()
        Me.GBsaldo.ResumeLayout(False)
        Me.GBsaldo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBtipoDeposito As GroupBox
    Friend WithEvents RBmPremier As RadioButton
    Friend WithEvents RBmonetario As RadioButton
    Friend WithEvents RBahorros As RadioButton
    Friend WithEvents GBmetodo As GroupBox
    Friend WithEvents CBcheque As CheckBox
    Friend WithEvents CBotros As CheckBox
    Friend WithEvents CBefectivo As CheckBox
    Friend WithEvents GBmonto As GroupBox
    Friend WithEvents Lcheque As Label
    Friend WithEvents TXTefectivo As TextBox
    Friend WithEvents TXTotro As TextBox
    Friend WithEvents TXTcheque As TextBox
    Friend WithEvents Lefectivo As Label
    Friend WithEvents Lpropio As Label
    Friend WithEvents GBsaldo As GroupBox
    Friend WithEvents TXTsaldoAnterior As TextBox
    Friend WithEvents Lsaldo As Label
    Friend WithEvents BTNcalcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTsaldoNuevo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTinteres As TextBox
    Friend WithEvents BTNlimpiar As Button
    Friend WithEvents BTNsalir As Button
End Class
