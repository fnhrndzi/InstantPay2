<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opciones
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_registrohoras = New System.Windows.Forms.Button()
        Me.btn_calcularpago = New System.Windows.Forms.Button()
        Me.btn_agregarcolab = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(91, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "INICIO DE SESIÓN"
        '
        'btn_registrohoras
        '
        Me.btn_registrohoras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrohoras.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_registrohoras.Location = New System.Drawing.Point(113, 86)
        Me.btn_registrohoras.Name = "btn_registrohoras"
        Me.btn_registrohoras.Size = New System.Drawing.Size(138, 49)
        Me.btn_registrohoras.TabIndex = 4
        Me.btn_registrohoras.Text = "REGISTRO HORAS"
        Me.btn_registrohoras.UseVisualStyleBackColor = True
        '
        'btn_calcularpago
        '
        Me.btn_calcularpago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcularpago.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_calcularpago.Location = New System.Drawing.Point(113, 171)
        Me.btn_calcularpago.Name = "btn_calcularpago"
        Me.btn_calcularpago.Size = New System.Drawing.Size(138, 49)
        Me.btn_calcularpago.TabIndex = 5
        Me.btn_calcularpago.Text = "CALCULAR PAGO"
        Me.btn_calcularpago.UseVisualStyleBackColor = True
        '
        'btn_agregarcolab
        '
        Me.btn_agregarcolab.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarcolab.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_agregarcolab.Location = New System.Drawing.Point(113, 257)
        Me.btn_agregarcolab.Name = "btn_agregarcolab"
        Me.btn_agregarcolab.Size = New System.Drawing.Size(138, 49)
        Me.btn_agregarcolab.TabIndex = 6
        Me.btn_agregarcolab.Text = "AGREGAR COLABORADOR"
        Me.btn_agregarcolab.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_salir.Location = New System.Drawing.Point(113, 340)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(138, 49)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(387, 413)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_agregarcolab)
        Me.Controls.Add(Me.btn_calcularpago)
        Me.Controls.Add(Me.btn_registrohoras)
        Me.Controls.Add(Me.Label3)
        Me.Name = "opciones"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btn_registrohoras As Button
    Friend WithEvents btn_calcularpago As Button
    Friend WithEvents btn_agregarcolab As Button
    Friend WithEvents btn_salir As Button
End Class
