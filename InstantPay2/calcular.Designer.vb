<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcular
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
        Me.calc_id = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.calc_sueldobase = New System.Windows.Forms.TextBox()
        Me.calc_valor = New System.Windows.Forms.TextBox()
        Me.calc_horastrabajadas = New System.Windows.Forms.TextBox()
        Me.calc_mes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.calc_total = New System.Windows.Forms.TextBox()
        Me.calc_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(202, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PAGO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CALCULAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(21, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Colaborador"
        '
        'calc_id
        '
        Me.calc_id.Location = New System.Drawing.Point(189, 95)
        Me.calc_id.Name = "calc_id"
        Me.calc_id.Size = New System.Drawing.Size(100, 20)
        Me.calc_id.TabIndex = 8
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(95, 198)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(112, 38)
        Me.btn_calcular.TabIndex = 9
        Me.btn_calcular.Text = "ACEPTAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(22, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "HORAS TRABAJADAS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(22, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "SUELDO BASE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(22, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "VALOR POR HORA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(106, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TOTAL:"
        '
        'calc_sueldobase
        '
        Me.calc_sueldobase.Location = New System.Drawing.Point(189, 294)
        Me.calc_sueldobase.Name = "calc_sueldobase"
        Me.calc_sueldobase.Size = New System.Drawing.Size(100, 20)
        Me.calc_sueldobase.TabIndex = 14
        '
        'calc_valor
        '
        Me.calc_valor.Location = New System.Drawing.Point(189, 339)
        Me.calc_valor.Name = "calc_valor"
        Me.calc_valor.Size = New System.Drawing.Size(100, 20)
        Me.calc_valor.TabIndex = 15
        '
        'calc_horastrabajadas
        '
        Me.calc_horastrabajadas.Location = New System.Drawing.Point(189, 385)
        Me.calc_horastrabajadas.Name = "calc_horastrabajadas"
        Me.calc_horastrabajadas.Size = New System.Drawing.Size(100, 20)
        Me.calc_horastrabajadas.TabIndex = 16
        '
        'calc_mes
        '
        Me.calc_mes.Location = New System.Drawing.Point(189, 142)
        Me.calc_mes.Name = "calc_mes"
        Me.calc_mes.Size = New System.Drawing.Size(100, 20)
        Me.calc_mes.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(21, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Mes a Calcular"
        '
        'calc_total
        '
        Me.calc_total.Location = New System.Drawing.Point(189, 467)
        Me.calc_total.Name = "calc_total"
        Me.calc_total.Size = New System.Drawing.Size(100, 20)
        Me.calc_total.TabIndex = 19
        '
        'calc_salir
        '
        Me.calc_salir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_salir.Location = New System.Drawing.Point(95, 514)
        Me.calc_salir.Name = "calc_salir"
        Me.calc_salir.Size = New System.Drawing.Size(112, 38)
        Me.calc_salir.TabIndex = 20
        Me.calc_salir.Text = "SALIR"
        Me.calc_salir.UseVisualStyleBackColor = True
        '
        'calcular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 564)
        Me.Controls.Add(Me.calc_salir)
        Me.Controls.Add(Me.calc_total)
        Me.Controls.Add(Me.calc_mes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.calc_horastrabajadas)
        Me.Controls.Add(Me.calc_valor)
        Me.Controls.Add(Me.calc_sueldobase)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.calc_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "calcular"
        Me.Text = "calcular"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents calc_id As TextBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents calc_sueldobase As TextBox
    Friend WithEvents calc_valor As TextBox
    Friend WithEvents calc_horastrabajadas As TextBox
    Friend WithEvents calc_mes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents calc_total As TextBox
    Friend WithEvents calc_salir As Button
End Class
