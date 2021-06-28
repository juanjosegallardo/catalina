<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejemplo1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejemplo1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvOriginal = New System.Windows.Forms.DataGridView()
        Me.btnInicia = New System.Windows.Forms.Button()
        Me.dgvDP = New System.Windows.Forms.DataGridView()
        Me.dgvD1 = New System.Windows.Forms.DataGridView()
        Me.dgvD2 = New System.Windows.Forms.DataGridView()
        Me.dgvD3 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblD1 = New System.Windows.Forms.Label()
        Me.lblD2 = New System.Windows.Forms.Label()
        Me.lblD3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblResultadoX = New System.Windows.Forms.Label()
        Me.lblResultadoY = New System.Windows.Forms.Label()
        Me.lblResultadoZ = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lblDP = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EcuacionesLineales.My.Resources.Resources.ejC
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(489, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 88)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell Extra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(114, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resuelve el siguiente ejemplo:"
        '
        'dgvOriginal
        '
        Me.dgvOriginal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOriginal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOriginal.ColumnHeadersVisible = False
        Me.dgvOriginal.Location = New System.Drawing.Point(315, 147)
        Me.dgvOriginal.Name = "dgvOriginal"
        Me.dgvOriginal.RowHeadersVisible = False
        Me.dgvOriginal.RowHeadersWidth = 62
        Me.dgvOriginal.RowTemplate.Height = 33
        Me.dgvOriginal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvOriginal.Size = New System.Drawing.Size(214, 130)
        Me.dgvOriginal.TabIndex = 2
        '
        'btnInicia
        '
        Me.btnInicia.Location = New System.Drawing.Point(315, 113)
        Me.btnInicia.Name = "btnInicia"
        Me.btnInicia.Size = New System.Drawing.Size(112, 34)
        Me.btnInicia.TabIndex = 3
        Me.btnInicia.Text = "Iniciar"
        Me.btnInicia.UseVisualStyleBackColor = True
        '
        'dgvDP
        '
        Me.dgvDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDP.Location = New System.Drawing.Point(50, 342)
        Me.dgvDP.Name = "dgvDP"
        Me.dgvDP.RowHeadersVisible = False
        Me.dgvDP.RowHeadersWidth = 62
        Me.dgvDP.RowTemplate.Height = 33
        Me.dgvDP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvDP.Size = New System.Drawing.Size(138, 111)
        Me.dgvDP.TabIndex = 4
        '
        'dgvD1
        '
        Me.dgvD1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvD1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvD1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvD1.Location = New System.Drawing.Point(248, 342)
        Me.dgvD1.Name = "dgvD1"
        Me.dgvD1.RowHeadersVisible = False
        Me.dgvD1.RowHeadersWidth = 62
        Me.dgvD1.RowTemplate.Height = 33
        Me.dgvD1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvD1.Size = New System.Drawing.Size(132, 111)
        Me.dgvD1.TabIndex = 5
        '
        'dgvD2
        '
        Me.dgvD2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvD2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvD2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvD2.Location = New System.Drawing.Point(489, 342)
        Me.dgvD2.Name = "dgvD2"
        Me.dgvD2.RowHeadersVisible = False
        Me.dgvD2.RowHeadersWidth = 62
        Me.dgvD2.RowTemplate.Height = 33
        Me.dgvD2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvD2.Size = New System.Drawing.Size(132, 111)
        Me.dgvD2.TabIndex = 6
        '
        'dgvD3
        '
        Me.dgvD3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvD3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvD3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvD3.Location = New System.Drawing.Point(708, 342)
        Me.dgvD3.Name = "dgvD3"
        Me.dgvD3.RowHeadersVisible = False
        Me.dgvD3.RowHeadersWidth = 62
        Me.dgvD3.RowTemplate.Height = 33
        Me.dgvD3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvD3.Size = New System.Drawing.Size(120, 111)
        Me.dgvD3.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EcuacionesLineales.My.Resources.Resources.delta
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(50, 497)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.EcuacionesLineales.My.Resources.Resources.delta
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(272, 497)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.EcuacionesLineales.My.Resources.Resources.delta
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(507, 497)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.EcuacionesLineales.My.Resources.Resources.delta
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(742, 497)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'lblD1
        '
        Me.lblD1.AutoSize = True
        Me.lblD1.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblD1.Location = New System.Drawing.Point(340, 515)
        Me.lblD1.Name = "lblD1"
        Me.lblD1.Size = New System.Drawing.Size(32, 31)
        Me.lblD1.TabIndex = 12
        Me.lblD1.Text = "1"
        '
        'lblD2
        '
        Me.lblD2.AutoSize = True
        Me.lblD2.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblD2.Location = New System.Drawing.Point(575, 515)
        Me.lblD2.Name = "lblD2"
        Me.lblD2.Size = New System.Drawing.Size(32, 31)
        Me.lblD2.TabIndex = 13
        Me.lblD2.Text = "2"
        '
        'lblD3
        '
        Me.lblD3.AutoSize = True
        Me.lblD3.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblD3.Location = New System.Drawing.Point(819, 515)
        Me.lblD3.Name = "lblD3"
        Me.lblD3.Size = New System.Drawing.Size(32, 31)
        Me.lblD3.TabIndex = 14
        Me.lblD3.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(48, 607)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 31)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "x = "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(309, 613)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 31)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "y ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(544, 619)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 31)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "z ="
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.EcuacionesLineales.My.Resources.Resources.linea
        Me.PictureBox6.Location = New System.Drawing.Point(114, 586)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(57, 75)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.EcuacionesLineales.My.Resources.Resources.linea
        Me.PictureBox7.Location = New System.Drawing.Point(370, 586)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(57, 75)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.EcuacionesLineales.My.Resources.Resources.linea
        Me.PictureBox8.Location = New System.Drawing.Point(605, 597)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(57, 75)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(132, 586)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 27)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "x"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(132, 634)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 27)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(384, 586)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 27)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "x"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(384, 634)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 27)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "x"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(617, 597)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 27)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "x"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(617, 645)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 27)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "x"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(177, 611)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 31)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "="
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(433, 613)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 31)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "="
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(671, 619)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 31)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "="
        '
        'lblResultadoX
        '
        Me.lblResultadoX.AutoSize = True
        Me.lblResultadoX.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResultadoX.Location = New System.Drawing.Point(215, 603)
        Me.lblResultadoX.Name = "lblResultadoX"
        Me.lblResultadoX.Size = New System.Drawing.Size(31, 31)
        Me.lblResultadoX.TabIndex = 30
        Me.lblResultadoX.Text = "?"
        '
        'lblResultadoY
        '
        Me.lblResultadoY.AutoSize = True
        Me.lblResultadoY.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResultadoY.Location = New System.Drawing.Point(470, 613)
        Me.lblResultadoY.Name = "lblResultadoY"
        Me.lblResultadoY.Size = New System.Drawing.Size(31, 31)
        Me.lblResultadoY.TabIndex = 31
        Me.lblResultadoY.Text = "?"
        '
        'lblResultadoZ
        '
        Me.lblResultadoZ.AutoSize = True
        Me.lblResultadoZ.Font = New System.Drawing.Font("Rockwell Extra Bold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResultadoZ.Location = New System.Drawing.Point(708, 619)
        Me.lblResultadoZ.Name = "lblResultadoZ"
        Me.lblResultadoZ.Size = New System.Drawing.Size(31, 31)
        Me.lblResultadoZ.TabIndex = 32
        Me.lblResultadoZ.Text = "?"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackgroundImage = CType(resources.GetObject("btnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.Location = New System.Drawing.Point(849, 559)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(112, 75)
        Me.btnRegresar.TabIndex = 33
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Location = New System.Drawing.Point(849, 645)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 77)
        Me.btnLimpiar.TabIndex = 34
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(449, 113)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(109, 28)
        Me.btnMostrar.TabIndex = 35
        Me.btnMostrar.Text = "Mostrar matriz"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lblDP
        '
        Me.lblDP.AutoSize = True
        Me.lblDP.Location = New System.Drawing.Point(132, 520)
        Me.lblDP.Name = "lblDP"
        Me.lblDP.Size = New System.Drawing.Size(35, 25)
        Me.lblDP.TabIndex = 36
        Me.lblDP.Text = "DP"
        '
        'Ejemplo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(973, 758)
        Me.Controls.Add(Me.lblDP)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblResultadoZ)
        Me.Controls.Add(Me.lblResultadoY)
        Me.Controls.Add(Me.lblResultadoX)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblD3)
        Me.Controls.Add(Me.lblD2)
        Me.Controls.Add(Me.lblD1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvD3)
        Me.Controls.Add(Me.dgvD2)
        Me.Controls.Add(Me.dgvD1)
        Me.Controls.Add(Me.dgvDP)
        Me.Controls.Add(Me.btnInicia)
        Me.Controls.Add(Me.dgvOriginal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Ejemplo1"
        Me.Text = "Ejemplo1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvOriginal As DataGridView
    Friend WithEvents btnInicia As Button
    Friend WithEvents dgvDP As DataGridView
    Friend WithEvents dgvD1 As DataGridView
    Friend WithEvents dgvD2 As DataGridView
    Friend WithEvents dgvD3 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblD1 As Label
    Friend WithEvents lblD2 As Label
    Friend WithEvents lblD3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblResultadoX As Label
    Friend WithEvents lblResultadoY As Label
    Friend WithEvents lblResultadoZ As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents lblDP As Label
End Class
