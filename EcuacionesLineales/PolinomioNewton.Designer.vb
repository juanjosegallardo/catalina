<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolinomioNewton
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
        Me.dgvEntradas = New System.Windows.Forms.DataGridView()
        Me.x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.dgvSalidas = New System.Windows.Forms.DataGridView()
        Me.lblPolinomio = New System.Windows.Forms.Label()
        CType(Me.dgvEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEntradas
        '
        Me.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x, Me.y})
        Me.dgvEntradas.Location = New System.Drawing.Point(12, 12)
        Me.dgvEntradas.Name = "dgvEntradas"
        Me.dgvEntradas.RowTemplate.Height = 25
        Me.dgvEntradas.Size = New System.Drawing.Size(88, 254)
        Me.dgvEntradas.TabIndex = 0
        '
        'x
        '
        Me.x.HeaderText = "x"
        Me.x.Name = "x"
        Me.x.Width = 20
        '
        'y
        '
        Me.y.HeaderText = "y"
        Me.y.Name = "y"
        Me.y.Width = 20
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(12, 272)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(88, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'dgvSalidas
        '
        Me.dgvSalidas.AllowUserToAddRows = False
        Me.dgvSalidas.AllowUserToDeleteRows = False
        Me.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalidas.Location = New System.Drawing.Point(118, 12)
        Me.dgvSalidas.Name = "dgvSalidas"
        Me.dgvSalidas.ReadOnly = True
        Me.dgvSalidas.RowTemplate.Height = 25
        Me.dgvSalidas.Size = New System.Drawing.Size(584, 254)
        Me.dgvSalidas.TabIndex = 2
        '
        'lblPolinomio
        '
        Me.lblPolinomio.AutoSize = True
        Me.lblPolinomio.Location = New System.Drawing.Point(118, 276)
        Me.lblPolinomio.Name = "lblPolinomio"
        Me.lblPolinomio.Size = New System.Drawing.Size(62, 15)
        Me.lblPolinomio.TabIndex = 3
        Me.lblPolinomio.Text = "Polinomio"
        '
        'PolinomioNewton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 310)
        Me.Controls.Add(Me.lblPolinomio)
        Me.Controls.Add(Me.dgvSalidas)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dgvEntradas)
        Me.Name = "PolinomioNewton"
        Me.Text = "PolinomioNewton"
        CType(Me.dgvEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEntradas As DataGridView
    Friend WithEvents x As DataGridViewTextBoxColumn
    Friend WithEvents y As DataGridViewTextBoxColumn
    Friend WithEvents btnCalcular As Button
    Friend WithEvents dgvSalidas As DataGridView
    Friend WithEvents lblPolinomio As Label
End Class
