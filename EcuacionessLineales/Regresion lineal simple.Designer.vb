<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regresion_lineal_simple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Regresion_lineal_simple))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIngresaValores = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnIngresaValoraX = New System.Windows.Forms.Button()
        Me.btnIngresaValoraY = New System.Windows.Forms.Button()
        Me.lstValoresX = New System.Windows.Forms.ListBox()
        Me.lstValoresY = New System.Windows.Forms.ListBox()
        Me.lstResultadoa = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResultadodea = New System.Windows.Forms.TextBox()
        Me.txtResultadodeb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorrelacion = New System.Windows.Forms.TextBox()
        Me.lstResultadob = New System.Windows.Forms.ListBox()
        Me.lblResultadodeb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresa Valor "
        '
        'txtIngresaValores
        '
        Me.txtIngresaValores.Location = New System.Drawing.Point(309, 56)
        Me.txtIngresaValores.Name = "txtIngresaValores"
        Me.txtIngresaValores.Size = New System.Drawing.Size(151, 31)
        Me.txtIngresaValores.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(622, 111)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(109, 57)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnIngresaValoraX
        '
        Me.btnIngresaValoraX.Location = New System.Drawing.Point(21, 108)
        Me.btnIngresaValoraX.Name = "btnIngresaValoraX"
        Me.btnIngresaValoraX.Size = New System.Drawing.Size(137, 74)
        Me.btnIngresaValoraX.TabIndex = 3
        Me.btnIngresaValoraX.Text = "Ingresa valores a X "
        Me.btnIngresaValoraX.UseVisualStyleBackColor = True
        '
        'btnIngresaValoraY
        '
        Me.btnIngresaValoraY.Location = New System.Drawing.Point(184, 111)
        Me.btnIngresaValoraY.Name = "btnIngresaValoraY"
        Me.btnIngresaValoraY.Size = New System.Drawing.Size(133, 71)
        Me.btnIngresaValoraY.TabIndex = 4
        Me.btnIngresaValoraY.Text = "Ingresa Valores a Y "
        Me.btnIngresaValoraY.UseVisualStyleBackColor = True
        '
        'lstValoresX
        '
        Me.lstValoresX.FormattingEnabled = True
        Me.lstValoresX.ItemHeight = 25
        Me.lstValoresX.Location = New System.Drawing.Point(21, 228)
        Me.lstValoresX.Name = "lstValoresX"
        Me.lstValoresX.Size = New System.Drawing.Size(72, 204)
        Me.lstValoresX.TabIndex = 5
        '
        'lstValoresY
        '
        Me.lstValoresY.FormattingEnabled = True
        Me.lstValoresY.ItemHeight = 25
        Me.lstValoresY.Location = New System.Drawing.Point(126, 228)
        Me.lstValoresY.Name = "lstValoresY"
        Me.lstValoresY.Size = New System.Drawing.Size(75, 204)
        Me.lstValoresY.TabIndex = 6
        '
        'lstResultadoa
        '
        Me.lstResultadoa.FormattingEnabled = True
        Me.lstResultadoa.ItemHeight = 25
        Me.lstResultadoa.Location = New System.Drawing.Point(595, 285)
        Me.lstResultadoa.Name = "lstResultadoa"
        Me.lstResultadoa.Size = New System.Drawing.Size(77, 204)
        Me.lstResultadoa.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Resultado de a "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Resultado de b "
        '
        'btnRegresar
        '
        Me.btnRegresar.BackgroundImage = CType(resources.GetObject("btnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.Location = New System.Drawing.Point(230, 503)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(112, 75)
        Me.btnRegresar.TabIndex = 68
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Location = New System.Drawing.Point(372, 503)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 77)
        Me.btnLimpiar.TabIndex = 69
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 25)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Y= "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 25)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(491, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 25)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "X"
        '
        'txtResultadodea
        '
        Me.txtResultadodea.Location = New System.Drawing.Point(309, 296)
        Me.txtResultadodea.Name = "txtResultadodea"
        Me.txtResultadodea.Size = New System.Drawing.Size(52, 31)
        Me.txtResultadodea.TabIndex = 73
        '
        'txtResultadodeb
        '
        Me.txtResultadodeb.Location = New System.Drawing.Point(414, 299)
        Me.txtResultadodeb.Name = "txtResultadodeb"
        Me.txtResultadodeb.Size = New System.Drawing.Size(52, 31)
        Me.txtResultadodeb.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Correlacion "
        '
        'txtCorrelacion
        '
        Me.txtCorrelacion.Location = New System.Drawing.Point(356, 407)
        Me.txtCorrelacion.Name = "txtCorrelacion"
        Me.txtCorrelacion.Size = New System.Drawing.Size(52, 31)
        Me.txtCorrelacion.TabIndex = 76
        '
        'lstResultadob
        '
        Me.lstResultadob.FormattingEnabled = True
        Me.lstResultadob.ItemHeight = 25
        Me.lstResultadob.Location = New System.Drawing.Point(700, 285)
        Me.lstResultadob.Name = "lstResultadob"
        Me.lstResultadob.Size = New System.Drawing.Size(77, 204)
        Me.lstResultadob.TabIndex = 77
        '
        'lblResultadodeb
        '
        Me.lblResultadodeb.AutoSize = True
        Me.lblResultadodeb.Location = New System.Drawing.Point(595, 239)
        Me.lblResultadodeb.Name = "lblResultadodeb"
        Me.lblResultadodeb.Size = New System.Drawing.Size(0, 25)
        Me.lblResultadodeb.TabIndex = 78
        '
        'Regresion_lineal_simple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 693)
        Me.Controls.Add(Me.lblResultadodeb)
        Me.Controls.Add(Me.lstResultadob)
        Me.Controls.Add(Me.txtCorrelacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtResultadodeb)
        Me.Controls.Add(Me.txtResultadodea)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstResultadoa)
        Me.Controls.Add(Me.lstValoresY)
        Me.Controls.Add(Me.lstValoresX)
        Me.Controls.Add(Me.btnIngresaValoraY)
        Me.Controls.Add(Me.btnIngresaValoraX)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtIngresaValores)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Regresion_lineal_simple"
        Me.Text = "Regresion_lineal_simple"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIngresaValores As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnIngresaValoraX As Button
    Friend WithEvents btnIngresaValoraY As Button
    Friend WithEvents lstValoresX As ListBox
    Friend WithEvents lstValoresY As ListBox
    Friend WithEvents lstResultadoa As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtResultadodea As TextBox
    Friend WithEvents txtResultadodeb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorrelacion As TextBox
    Friend WithEvents lstResultadob As ListBox
    Friend WithEvents lblResultadodeb As Label
End Class
