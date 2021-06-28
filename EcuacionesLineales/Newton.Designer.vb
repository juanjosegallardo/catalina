<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newton
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtValorInicial = New System.Windows.Forms.TextBox()
        Me.txtIteraciones = New System.Windows.Forms.TextBox()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(11, 162)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtValorInicial
        '
        Me.txtValorInicial.Location = New System.Drawing.Point(11, 35)
        Me.txtValorInicial.Name = "txtValorInicial"
        Me.txtValorInicial.Size = New System.Drawing.Size(100, 23)
        Me.txtValorInicial.TabIndex = 1
        '
        'txtIteraciones
        '
        Me.txtIteraciones.Location = New System.Drawing.Point(11, 85)
        Me.txtIteraciones.Name = "txtIteraciones"
        Me.txtIteraciones.Size = New System.Drawing.Size(100, 23)
        Me.txtIteraciones.TabIndex = 2
        '
        'dgvResultados
        '
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(117, 12)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowTemplate.Height = 25
        Me.dgvResultados.Size = New System.Drawing.Size(463, 173)
        Me.dgvResultados.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Iiteraciones"
        '
        'Newton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 200)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.txtIteraciones)
        Me.Controls.Add(Me.txtValorInicial)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Newton"
        Me.Text = "Newton"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtValorInicial As TextBox
    Friend WithEvents txtIteraciones As TextBox
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
