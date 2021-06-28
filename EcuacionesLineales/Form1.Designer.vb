<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArchivoSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCramer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCramerE1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEM = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGaussjordann = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegresionLS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGaussJordan = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesNoLinealesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PollinomioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuCramer, Me.mnuGaussJordan, Me.NewtonToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivoSalir})
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(60, 22)
        Me.mnuArchivo.Text = "Archivo"
        '
        'mnuArchivoSalir
        '
        Me.mnuArchivoSalir.Name = "mnuArchivoSalir"
        Me.mnuArchivoSalir.Size = New System.Drawing.Size(96, 22)
        Me.mnuArchivoSalir.Text = "Salir"
        '
        'mnuCramer
        '
        Me.mnuCramer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCramerE1, Me.mnuEM, Me.mnuGaussjordann, Me.mnuRegresionLS})
        Me.mnuCramer.Name = "mnuCramer"
        Me.mnuCramer.Size = New System.Drawing.Size(103, 22)
        Me.mnuCramer.Text = "Método Cramer"
        '
        'mnuCramerE1
        '
        Me.mnuCramerE1.Name = "mnuCramerE1"
        Me.mnuCramerE1.Size = New System.Drawing.Size(232, 22)
        Me.mnuCramerE1.Text = "Ejemplo 1"
        '
        'mnuEM
        '
        Me.mnuEM.Name = "mnuEM"
        Me.mnuEM.Size = New System.Drawing.Size(232, 22)
        Me.mnuEM.Text = "Principal Metodo de crammer"
        '
        'mnuGaussjordann
        '
        Me.mnuGaussjordann.Name = "mnuGaussjordann"
        Me.mnuGaussjordann.Size = New System.Drawing.Size(232, 22)
        Me.mnuGaussjordann.Text = "Metodo de Gauss Jordan "
        '
        'mnuRegresionLS
        '
        Me.mnuRegresionLS.Name = "mnuRegresionLS"
        Me.mnuRegresionLS.Size = New System.Drawing.Size(232, 22)
        Me.mnuRegresionLS.Text = "Regresion Lineal simple "
        '
        'mnuGaussJordan
        '
        Me.mnuGaussJordan.Name = "mnuGaussJordan"
        Me.mnuGaussJordan.Size = New System.Drawing.Size(152, 22)
        Me.mnuGaussJordan.Text = "Metodo de Gauss Jordan "
        '
        'NewtonToolStripMenuItem
        '
        Me.NewtonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EcuacionesNoLinealesToolStripMenuItem, Me.PollinomioToolStripMenuItem})
        Me.NewtonToolStripMenuItem.Name = "NewtonToolStripMenuItem"
        Me.NewtonToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.NewtonToolStripMenuItem.Text = "Newton"
        '
        'EcuacionesNoLinealesToolStripMenuItem
        '
        Me.EcuacionesNoLinealesToolStripMenuItem.Name = "EcuacionesNoLinealesToolStripMenuItem"
        Me.EcuacionesNoLinealesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EcuacionesNoLinealesToolStripMenuItem.Text = "Ecuaciones no lineales"
        '
        'PollinomioToolStripMenuItem
        '
        Me.PollinomioToolStripMenuItem.Name = "PollinomioToolStripMenuItem"
        Me.PollinomioToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PollinomioToolStripMenuItem.Text = "Polinomio"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EcuacionesLineales.My.Resources.Resources.cramer
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(150, 64)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 176)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(560, 270)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Ecuaciones Lineales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuArchivo As ToolStripMenuItem
    Friend WithEvents mnuArchivoSalir As ToolStripMenuItem
    Friend WithEvents mnuCramer As ToolStripMenuItem
    Friend WithEvents mnuCramerE1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mnuEM As ToolStripMenuItem
    Friend WithEvents mnuGaussJordan As ToolStripMenuItem
    Friend WithEvents mnuGaussjordann As ToolStripMenuItem
    Friend WithEvents mnuRegresionLS As ToolStripMenuItem
    Friend WithEvents NewtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesNoLinealesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PollinomioToolStripMenuItem As ToolStripMenuItem
End Class
