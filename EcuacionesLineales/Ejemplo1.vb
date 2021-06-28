Public Class Ejemplo1
    Dim matriz
    Private Sub Ejemplo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInicia_Click(sender As Object, e As EventArgs) Handles btnInicia.Click
        Dim x1, x2, x3, y1, y2, y3, z1, z2, z3, r1, r2, r3, DP, D1, D2, D3, ResultadoX, ResultadoY, ResultadoZ As Decimal
        fc()
        x1 = 1
        y1 = 1
        z1 = 1
        x2 = 1
        y2 = -2
        z2 = 3
        x3 = 1
        y3 = 0
        z3 = 1
        r1 = 1
        r2 = 2
        r3 = 5

        dgvOriginal(0, 0).Value = x1
        dgvOriginal(0, 1).Value = x2
        dgvOriginal(0, 2).Value = x3

        dgvOriginal(1, 0).Value = y1
        dgvOriginal(1, 1).Value = y2
        dgvOriginal(1, 2).Value = y3

        dgvOriginal(2, 0).Value = z1
        dgvOriginal(2, 1).Value = z2
        dgvOriginal(2, 2).Value = z3

        dgvOriginal(3, 0).Value = r1
        dgvOriginal(3, 1).Value = r2
        dgvOriginal(3, 2).Value = r3


        dgvDP(0, 0).Value = x1
        dgvDP(0, 1).Value = x2
        dgvDP(0, 2).Value = x3
        dgvDP(1, 0).Value = y1
        dgvDP(1, 1).Value = y2
        dgvDP(1, 2).Value = y3
        dgvDP(2, 0).Value = z1
        dgvDP(2, 1).Value = z2
        dgvDP(2, 2).Value = z3

        dgvD1(0, 0).Value = r1
        dgvD1(0, 1).Value = r2
        dgvD1(0, 2).Value = r3
        dgvD1(1, 0).Value = y1
        dgvD1(1, 1).Value = y2
        dgvD1(1, 2).Value = y3
        dgvD1(2, 0).Value = z1
        dgvD1(2, 1).Value = z2
        dgvD1(2, 2).Value = z3

        dgvD2(0, 0).Value = x1
        dgvD2(0, 1).Value = x2
        dgvD2(0, 2).Value = x3
        dgvD2(1, 0).Value = r1
        dgvD2(1, 1).Value = r2
        dgvD2(1, 2).Value = r3
        dgvD2(2, 0).Value = z1
        dgvD2(2, 1).Value = z2
        dgvD2(2, 2).Value = z3

        dgvD3(0, 0).Value = x1
        dgvD3(0, 1).Value = x2
        dgvD3(0, 2).Value = x3
        dgvD3(1, 0).Value = y1
        dgvD3(1, 1).Value = y2
        dgvD3(1, 2).Value = y3
        dgvD3(2, 0).Value = r1
        dgvD3(2, 1).Value = r2
        dgvD3(2, 2).Value = r3


        dgvOriginal.Rows.Insert(0, New Object)

        DP = ((x1 * y2 * z3) + (y1 * z2 * x3) + (z1 * x2 * y3) - (y1 * x2 * z3) - (x1 * z2 * y3) - (z1 * y2 * x3))
        lblDP.Text = DP
        D1 = ((r1 * y2 * z3) + (y1 * z2 * r3) + (z1 * r2 * y3) - (y1 * r2 * z3) - (r1 * z2 * y3) - (z1 * y2 * r3))
        lblD1.Text = D1
        D2 = ((x1 * r2 * z3) + (r1 * z2 * x3) + (z1 * x2 * r3) - (r1 * x2 * z3) - (x1 * z2 * r3) - (z1 * r2 * x3))
        lblD2.Text = D2
        D3 = ((x1 * y2 * r3) + (y1 * r2 * x3) + (r1 * x2 * y3) - (y1 * x2 * r3) - (x1 * r2 * y3) - (r1 * y2 * x3))
        lblD3.Text = D3


        ResultadoX = (D1 / DP)
        lblResultadoX.Text = ResultadoX
        ResultadoY = (D2 / DP)
        lblResultadoY.Text = ResultadoY
        ResultadoZ = (D3 / DP)
        lblResultadoZ.Text = ResultadoZ

    End Sub

    Sub fc()
        dgvOriginal.ColumnCount = 4
        dgvOriginal.Rows.Add(3)
        dgvDP.ColumnCount = 3
        dgvDP.Rows.Add(3)
        dgvD1.ColumnCount = 3
        dgvD1.Rows.Add(3)
        dgvD2.ColumnCount = 3
        dgvD2.Rows.Add(3)
        dgvD3.ColumnCount = 3
        dgvD3.Rows.Add(3)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lblResultadoX.Text = “ ”
        lblResultadoY.Text = “ ”
        lblResultadoZ.Text = “ ”
        lblDP.Text = “ ”
        lblD1.Text = “ ”
        lblD2.Text = “ ”
        lblD3.Text = “ ”

    End Sub

End Class