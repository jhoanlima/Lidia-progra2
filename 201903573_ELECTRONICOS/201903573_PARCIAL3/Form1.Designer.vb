﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1143, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1178, 292)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(53, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(943, 138)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(53, 533)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.LimpiarEstadisticasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1289, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperarToolStripMenuItem
        '
        Me.OperarToolStripMenuItem.Name = "OperarToolStripMenuItem"
        Me.OperarToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.OperarToolStripMenuItem.Text = "Operar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'LimpiarEstadisticasToolStripMenuItem
        '
        Me.LimpiarEstadisticasToolStripMenuItem.Name = "LimpiarEstadisticasToolStripMenuItem"
        Me.LimpiarEstadisticasToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.LimpiarEstadisticasToolStripMenuItem.Text = "Limpiar Estadisticas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"L01", "L02", "L03", "L04", "L05", "L06"})
        Me.ComboBox1.Location = New System.Drawing.Point(95, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del producto:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Memoria RAM", "Disco Duro", "Procesador", "Motherboard", "Tarjeta Grafica", "SSD"})
        Me.ComboBox2.Location = New System.Drawing.Point(403, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(226, 25)
        Me.ComboBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(670, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio por unidad:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(798, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad de unidades:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Defectuosas:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 24)
        Me.TextBox2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Aprobadas:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(352, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 24)
        Me.TextBox3.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio por Unidad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad de unidades defectuosas"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cantidad de unidades aprobadas"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Ganacias"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Perdidas"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Total"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Sello de Calidad"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Lotes con sello de calidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(326, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Lotes con mas unidades defectuosas que aprobadas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Lotes con almenos una defectuosa:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(205, 41)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 24)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(365, 86)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 24)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(261, 127)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 24)
        Me.TextBox6.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1289, 715)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
