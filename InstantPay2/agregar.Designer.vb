<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ag_nombre = New System.Windows.Forms.TextBox()
        Me.ag_identidad = New System.Windows.Forms.TextBox()
        Me.ag_puesto = New System.Windows.Forms.TextBox()
        Me.ag_sueldobase = New System.Windows.Forms.TextBox()
        Me.ag_fecha = New System.Windows.Forms.DateTimePicker()
        Me.ag_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 41)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "AGREGAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(219, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 41)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "COLABORADOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(12, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Identidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(12, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sueldo Base"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(12, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(12, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Puesto"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(193, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ag_nombre
        '
        Me.ag_nombre.Location = New System.Drawing.Point(145, 97)
        Me.ag_nombre.Name = "ag_nombre"
        Me.ag_nombre.Size = New System.Drawing.Size(360, 20)
        Me.ag_nombre.TabIndex = 15
        '
        'ag_identidad
        '
        Me.ag_identidad.Location = New System.Drawing.Point(145, 145)
        Me.ag_identidad.Name = "ag_identidad"
        Me.ag_identidad.Size = New System.Drawing.Size(360, 20)
        Me.ag_identidad.TabIndex = 16
        '
        'ag_puesto
        '
        Me.ag_puesto.Location = New System.Drawing.Point(145, 249)
        Me.ag_puesto.Name = "ag_puesto"
        Me.ag_puesto.Size = New System.Drawing.Size(360, 20)
        Me.ag_puesto.TabIndex = 17
        '
        'ag_sueldobase
        '
        Me.ag_sueldobase.Location = New System.Drawing.Point(145, 297)
        Me.ag_sueldobase.Name = "ag_sueldobase"
        Me.ag_sueldobase.Size = New System.Drawing.Size(360, 20)
        Me.ag_sueldobase.TabIndex = 18
        '
        'ag_fecha
        '
        Me.ag_fecha.Location = New System.Drawing.Point(235, 195)
        Me.ag_fecha.Name = "ag_fecha"
        Me.ag_fecha.Size = New System.Drawing.Size(263, 20)
        Me.ag_fecha.TabIndex = 19
        '
        'ag_salir
        '
        Me.ag_salir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ag_salir.Location = New System.Drawing.Point(386, 372)
        Me.ag_salir.Name = "ag_salir"
        Me.ag_salir.Size = New System.Drawing.Size(119, 39)
        Me.ag_salir.TabIndex = 20
        Me.ag_salir.Text = "SALIR"
        Me.ag_salir.UseVisualStyleBackColor = True
        '
        'agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 450)
        Me.Controls.Add(Me.ag_salir)
        Me.Controls.Add(Me.ag_fecha)
        Me.Controls.Add(Me.ag_sueldobase)
        Me.Controls.Add(Me.ag_puesto)
        Me.Controls.Add(Me.ag_identidad)
        Me.Controls.Add(Me.ag_nombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "agregar"
        Me.Text = "agregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ag_nombre As TextBox
    Friend WithEvents ag_identidad As TextBox
    Friend WithEvents ag_puesto As TextBox
    Friend WithEvents ag_sueldobase As TextBox
    Friend WithEvents ag_fecha As DateTimePicker
    Friend WithEvents ag_salir As Button
End Class
