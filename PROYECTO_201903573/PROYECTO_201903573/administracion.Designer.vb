<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administracion
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
        Me.BTNgestionEditorial = New System.Windows.Forms.Button()
        Me.BTNgestionarLibros = New System.Windows.Forms.Button()
        Me.BTNreportes = New System.Windows.Forms.Button()
        Me.BTNcerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNgestionEditorial
        '
        Me.BTNgestionEditorial.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BTNgestionEditorial.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNgestionEditorial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNgestionEditorial.Location = New System.Drawing.Point(302, 122)
        Me.BTNgestionEditorial.Name = "BTNgestionEditorial"
        Me.BTNgestionEditorial.Size = New System.Drawing.Size(292, 95)
        Me.BTNgestionEditorial.TabIndex = 0
        Me.BTNgestionEditorial.Text = "Gestionar Editoriales"
        Me.BTNgestionEditorial.UseVisualStyleBackColor = False
        '
        'BTNgestionarLibros
        '
        Me.BTNgestionarLibros.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BTNgestionarLibros.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNgestionarLibros.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNgestionarLibros.Location = New System.Drawing.Point(302, 246)
        Me.BTNgestionarLibros.Name = "BTNgestionarLibros"
        Me.BTNgestionarLibros.Size = New System.Drawing.Size(292, 95)
        Me.BTNgestionarLibros.TabIndex = 1
        Me.BTNgestionarLibros.Text = "Gestionar Libros"
        Me.BTNgestionarLibros.UseVisualStyleBackColor = False
        '
        'BTNreportes
        '
        Me.BTNreportes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BTNreportes.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNreportes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BTNreportes.Location = New System.Drawing.Point(302, 373)
        Me.BTNreportes.Name = "BTNreportes"
        Me.BTNreportes.Size = New System.Drawing.Size(292, 95)
        Me.BTNreportes.TabIndex = 2
        Me.BTNreportes.Text = "Reportes"
        Me.BTNreportes.UseVisualStyleBackColor = False
        '
        'BTNcerrar
        '
        Me.BTNcerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNcerrar.ForeColor = System.Drawing.Color.Red
        Me.BTNcerrar.Location = New System.Drawing.Point(713, 506)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(203, 56)
        Me.BTNcerrar.TabIndex = 5
        Me.BTNcerrar.Text = "Cerrar Sesión"
        Me.BTNcerrar.UseVisualStyleBackColor = False
        '
        'administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.aministracion_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 598)
        Me.Controls.Add(Me.BTNcerrar)
        Me.Controls.Add(Me.BTNreportes)
        Me.Controls.Add(Me.BTNgestionarLibros)
        Me.Controls.Add(Me.BTNgestionEditorial)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "administracion"
        Me.Text = "administracion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNgestionEditorial As Button
    Friend WithEvents BTNgestionarLibros As Button
    Friend WithEvents BTNreportes As Button
    Friend WithEvents BTNcerrar As Button
End Class
