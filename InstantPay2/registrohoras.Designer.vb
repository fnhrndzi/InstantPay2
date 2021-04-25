<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrohoras
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.regi_idcolab = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.regi_dia = New System.Windows.Forms.TextBox()
        Me.regi_entrada = New System.Windows.Forms.TextBox()
        Me.regi_salida = New System.Windows.Forms.TextBox()
        Me.regi_mes = New System.Windows.Forms.TextBox()
        Me.regi_anio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.regi_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(359, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HORAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "REGISTRO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID Colaborador"
        '
        'regi_idcolab
        '
        Me.regi_idcolab.Location = New System.Drawing.Point(170, 94)
        Me.regi_idcolab.Name = "regi_idcolab"
        Me.regi_idcolab.Size = New System.Drawing.Size(130, 20)
        Me.regi_idcolab.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Día"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(12, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hora de entrada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(352, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Hora de salida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(202, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Mes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(409, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Año"
        '
        'regi_dia
        '
        Me.regi_dia.Location = New System.Drawing.Point(66, 162)
        Me.regi_dia.Name = "regi_dia"
        Me.regi_dia.Size = New System.Drawing.Size(97, 20)
        Me.regi_dia.TabIndex = 13
        '
        'regi_entrada
        '
        Me.regi_entrada.Location = New System.Drawing.Point(187, 235)
        Me.regi_entrada.Name = "regi_entrada"
        Me.regi_entrada.Size = New System.Drawing.Size(130, 20)
        Me.regi_entrada.TabIndex = 16
        '
        'regi_salida
        '
        Me.regi_salida.Location = New System.Drawing.Point(518, 233)
        Me.regi_salida.Name = "regi_salida"
        Me.regi_salida.Size = New System.Drawing.Size(130, 20)
        Me.regi_salida.TabIndex = 17
        '
        'regi_mes
        '
        Me.regi_mes.Location = New System.Drawing.Point(270, 162)
        Me.regi_mes.Name = "regi_mes"
        Me.regi_mes.Size = New System.Drawing.Size(97, 20)
        Me.regi_mes.TabIndex = 18
        '
        'regi_anio
        '
        Me.regi_anio.Location = New System.Drawing.Point(473, 160)
        Me.regi_anio.Name = "regi_anio"
        Me.regi_anio.Size = New System.Drawing.Size(97, 20)
        Me.regi_anio.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(270, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 40)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'regi_salir
        '
        Me.regi_salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regi_salir.Location = New System.Drawing.Point(509, 299)
        Me.regi_salir.Name = "regi_salir"
        Me.regi_salir.Size = New System.Drawing.Size(139, 40)
        Me.regi_salir.TabIndex = 21
        Me.regi_salir.Text = "SALIR"
        Me.regi_salir.UseVisualStyleBackColor = True
        '
        'registrohoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 378)
        Me.Controls.Add(Me.regi_salir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.regi_anio)
        Me.Controls.Add(Me.regi_mes)
        Me.Controls.Add(Me.regi_salida)
        Me.Controls.Add(Me.regi_entrada)
        Me.Controls.Add(Me.regi_dia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.regi_idcolab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "registrohoras"
        Me.Text = "registrohoras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents regi_idcolab As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents regi_dia As TextBox
    Friend WithEvents regi_entrada As TextBox
    Friend WithEvents regi_salida As TextBox
    Friend WithEvents regi_mes As TextBox
    Friend WithEvents regi_anio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents regi_salir As Button
End Class
