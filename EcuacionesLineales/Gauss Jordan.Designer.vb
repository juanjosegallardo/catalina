<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gauss_Jordan
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
        Me.dgvOriginal = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOriginal
        '
        Me.dgvOriginal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOriginal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOriginal.ColumnHeadersVisible = False
        Me.dgvOriginal.Location = New System.Drawing.Point(299, 172)
        Me.dgvOriginal.Name = "dgvOriginal"
        Me.dgvOriginal.RowHeadersVisible = False
        Me.dgvOriginal.RowHeadersWidth = 62
        Me.dgvOriginal.RowTemplate.Height = 33
        Me.dgvOriginal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvOriginal.Size = New System.Drawing.Size(214, 130)
        Me.dgvOriginal.TabIndex = 3
        '
        'Gauss_Jordan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(819, 628)
        Me.Controls.Add(Me.dgvOriginal)
        Me.Name = "Gauss_Jordan"
        Me.Text = "Gauss_Jordan"
        CType(Me.dgvOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvOriginal As DataGridView
End Class
