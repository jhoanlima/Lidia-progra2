<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BTNltotales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RDdiversificado = New System.Windows.Forms.RadioButton()
        Me.RDbasico = New System.Windows.Forms.RadioButton()
        Me.CMBcarreras = New System.Windows.Forms.ComboBox()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.TXTcarnet = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNlmatriz = New System.Windows.Forms.Button()
        Me.BTNlentradas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNsalir = New System.Windows.Forms.Button()
        Me.BTNmostraar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMBformaPago = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTtnivel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTtgeneral = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TXTtformaPago = New System.Windows.Forms.TextBox()
        Me.TXTtinscritos = New System.Windows.Forms.TextBox()
        Me.BTNtotales = New System.Windows.Forms.Button()
        Me.BTNaceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(571, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Carnet:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel de Estudio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carreras de diversificado:"
        '
        'RDdiversificado
        '
        Me.RDdiversificado.AutoSize = True
        Me.RDdiversificado.Checked = True
        Me.RDdiversificado.Location = New System.Drawing.Point(241, 104)
        Me.RDdiversificado.Name = "RDdiversificado"
        Me.RDdiversificado.Size = New System.Drawing.Size(134, 25)
        Me.RDdiversificado.TabIndex = 4
        Me.RDdiversificado.TabStop = True
        Me.RDdiversificado.Text = "Diversificado"
        Me.RDdiversificado.UseVisualStyleBackColor = True
        '
        'RDbasico
        '
        Me.RDbasico.AutoSize = True
        Me.RDbasico.Location = New System.Drawing.Point(241, 148)
        Me.RDbasico.Name = "RDbasico"
        Me.RDbasico.Size = New System.Drawing.Size(82, 25)
        Me.RDbasico.TabIndex = 5
        Me.RDbasico.Text = "Basico"
        Me.RDbasico.UseVisualStyleBackColor = True
        '
        'CMBcarreras
        '
        Me.CMBcarreras.FormattingEnabled = True
        Me.CMBcarreras.Items.AddRange(New Object() {"Perito Contador", "Bachillerato", "Electronico", "Diseno Grafico"})
        Me.CMBcarreras.Location = New System.Drawing.Point(646, 103)
        Me.CMBcarreras.Name = "CMBcarreras"
        Me.CMBcarreras.Size = New System.Drawing.Size(207, 28)
        Me.CMBcarreras.TabIndex = 6
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(128, 34)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(437, 27)
        Me.TXTnombre.TabIndex = 7
        '
        'TXTcarnet
        '
        Me.TXTcarnet.Location = New System.Drawing.Point(646, 34)
        Me.TXTcarnet.Name = "TXTcarnet"
        Me.TXTcarnet.Size = New System.Drawing.Size(207, 27)
        Me.TXTcarnet.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.CMBformaPago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTcarnet)
        Me.GroupBox1.Controls.Add(Me.TXTnombre)
        Me.GroupBox1.Controls.Add(Me.CMBcarreras)
        Me.GroupBox1.Controls.Add(Me.RDbasico)
        Me.GroupBox1.Controls.Add(Me.RDdiversificado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(918, 177)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos"
        '
        'BTNlmatriz
        '
        Me.BTNlmatriz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNlmatriz.Location = New System.Drawing.Point(1027, 111)
        Me.BTNlmatriz.Name = "BTNlmatriz"
        Me.BTNlmatriz.Size = New System.Drawing.Size(160, 68)
        Me.BTNlmatriz.TabIndex = 10
        Me.BTNlmatriz.Text = "Limpiar Matriz"
        Me.BTNlmatriz.UseVisualStyleBackColor = False
        '
        'BTNlentradas
        '
        Me.BTNlentradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNlentradas.Location = New System.Drawing.Point(1027, 190)
        Me.BTNlentradas.Name = "BTNlentradas"
        Me.BTNlentradas.Size = New System.Drawing.Size(160, 68)
        Me.BTNlentradas.TabIndex = 11
        Me.BTNlentradas.Text = "Limpiar Entradas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNlentradas.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1027, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 68)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Limpiar Totales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNsalir
        '
        Me.BTNsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNsalir.Location = New System.Drawing.Point(1027, 526)
        Me.BTNsalir.Name = "BTNsalir"
        Me.BTNsalir.Size = New System.Drawing.Size(160, 68)
        Me.BTNsalir.TabIndex = 13
        Me.BTNsalir.Text = "Salir"
        Me.BTNsalir.UseVisualStyleBackColor = False
        '
        'BTNmostraar
        '
        Me.BTNmostraar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNmostraar.Location = New System.Drawing.Point(1027, 357)
        Me.BTNmostraar.Name = "BTNmostraar"
        Me.BTNmostraar.Size = New System.Drawing.Size(160, 68)
        Me.BTNmostraar.TabIndex = 14
        Me.BTNmostraar.Text = "Mostrar Datos Almacenados"
        Me.BTNmostraar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(906, 219)
        Me.DataGridView1.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MediumOrchid
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(918, 271)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Generales:"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carnet"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nivel de Estudio"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cuota de Inscripción"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "1era Cuota Mensual"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Forma de Pago"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(500, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Forma de pago:"
        '
        'CMBformaPago
        '
        Me.CMBformaPago.FormattingEnabled = True
        Me.CMBformaPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de credito", "Trasferencia por ACH", "Deposito bancario"})
        Me.CMBformaPago.Location = New System.Drawing.Point(646, 138)
        Me.CMBformaPago.Name = "CMBformaPago"
        Me.CMBformaPago.Size = New System.Drawing.Size(206, 28)
        Me.CMBformaPago.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox3.Controls.Add(Me.TXTtinscritos)
        Me.GroupBox3.Controls.Add(Me.TXTtformaPago)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TXTtgeneral)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TXTtnivel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(50, 538)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(912, 170)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total general:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total por forma de pago:"
        '
        'TXTtnivel
        '
        Me.TXTtnivel.AutoSize = True
        Me.TXTtnivel.Location = New System.Drawing.Point(508, 108)
        Me.TXTtnivel.Name = "TXTtnivel"
        Me.TXTtnivel.Size = New System.Drawing.Size(132, 21)
        Me.TXTtnivel.TabIndex = 2
        Me.TXTtnivel.Text = "Total por nivel:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(423, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(217, 21)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Total inscritos por carrera:"
        '
        'TXTtgeneral
        '
        Me.TXTtgeneral.Location = New System.Drawing.Point(173, 42)
        Me.TXTtgeneral.Name = "TXTtgeneral"
        Me.TXTtgeneral.Size = New System.Drawing.Size(221, 27)
        Me.TXTtgeneral.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(646, 102)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(221, 27)
        Me.TextBox2.TabIndex = 5
        '
        'TXTtformaPago
        '
        Me.TXTtformaPago.Location = New System.Drawing.Point(257, 102)
        Me.TXTtformaPago.Name = "TXTtformaPago"
        Me.TXTtformaPago.Size = New System.Drawing.Size(221, 27)
        Me.TXTtformaPago.TabIndex = 6
        '
        'TXTtinscritos
        '
        Me.TXTtinscritos.Location = New System.Drawing.Point(646, 39)
        Me.TXTtinscritos.Name = "TXTtinscritos"
        Me.TXTtinscritos.Size = New System.Drawing.Size(221, 27)
        Me.TXTtinscritos.TabIndex = 7
        '
        'BTNtotales
        '
        Me.BTNtotales.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNtotales.Location = New System.Drawing.Point(1027, 441)
        Me.BTNtotales.Name = "BTNtotales"
        Me.BTNtotales.Size = New System.Drawing.Size(160, 68)
        Me.BTNtotales.TabIndex = 19
        Me.BTNtotales.Text = "Totales"
        Me.BTNtotales.UseVisualStyleBackColor = False
        '
        'BTNaceptar
        '
        Me.BTNaceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNaceptar.Location = New System.Drawing.Point(1027, 32)
        Me.BTNaceptar.Name = "BTNaceptar"
        Me.BTNaceptar.Size = New System.Drawing.Size(160, 68)
        Me.BTNaceptar.TabIndex = 20
        Me.BTNaceptar.Text = "Aceptar"
        Me.BTNaceptar.UseVisualStyleBackColor = False
        '
        'BTNltotales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201903573_Tarea8.My.Resources.Resources.istockphoto_1246548171_640x640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1227, 719)
        Me.Controls.Add(Me.BTNaceptar)
        Me.Controls.Add(Me.BTNtotales)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTNmostraar)
        Me.Controls.Add(Me.BTNsalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNlentradas)
        Me.Controls.Add(Me.BTNlmatriz)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BTNltotales"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RDdiversificado As RadioButton
    Friend WithEvents RDbasico As RadioButton
    Friend WithEvents CMBcarreras As ComboBox
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents TXTcarnet As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTNlmatriz As Button
    Friend WithEvents BTNlentradas As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BTNsalir As Button
    Friend WithEvents BTNmostraar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CMBformaPago As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTtinscritos As TextBox
    Friend WithEvents TXTtformaPago As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TXTtgeneral As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTtnivel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNtotales As Button
    Friend WithEvents BTNaceptar As Button
End Class
