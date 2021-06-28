Public Class EM
    Dim matriz(4, 3), m As String
    Dim i As Integer


    Private Sub EM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvO.ColumnCount = 4
        dgvO.Rows.Add(3)

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x1, x2, x3, y1, y2, y3, z1, z2, z3, r1, r2, r3, MP, M1, M2, M3, ResultadoX, ResultadoY, ResultadoZ As Decimal
        fc()
        x1 = 2
        y1 = -1
        z1 = -2
        x2 = -1
        y2 = 1
        z2 = 1
        x3 = 1
        y3 = -2
        z3 = 1
        r1 = -2
        r2 = 0
        r3 = 8



        dgvO(0, 0).Value = x1
        dgvO(0, 1).Value = x2
        dgvO(0, 2).Value = x3

        dgvO(1, 0).Value = y1
        dgvO(1, 1).Value = y2
        dgvO(1, 2).Value = y3

        dgvO(2, 0).Value = z1
        dgvO(2, 1).Value = z2
        dgvO(2, 2).Value = z3

        dgvO(3, 0).Value = r1
        dgvO(3, 1).Value = r2
        dgvO(3, 2).Value = r3


        dgvMP(0, 0).Value = x1
        dgvMP(0, 1).Value = x2
        dgvMP(0, 2).Value = x3
        dgvMP(1, 0).Value = y1
        dgvMP(1, 1).Value = y2
        dgvMP(1, 2).Value = y3
        dgvMP(2, 0).Value = z1
        dgvMP(2, 1).Value = z2
        dgvMP(2, 2).Value = z3

        dgvM1(0, 0).Value = r1
        dgvM1(0, 1).Value = r2
        dgvM1(0, 2).Value = r3
        dgvM1(1, 0).Value = y1
        dgvM1(1, 1).Value = y2
        dgvM1(1, 2).Value = y3
        dgvM1(2, 0).Value = z1
        dgvM1(2, 1).Value = z2
        dgvM1(2, 2).Value = z3

        dgvM2(0, 0).Value = x1
        dgvM2(0, 1).Value = x2
        dgvM2(0, 2).Value = x3
        dgvM2(1, 0).Value = r1
        dgvM2(1, 1).Value = r2
        dgvM2(1, 2).Value = r3
        dgvM2(2, 0).Value = z1
        dgvM2(2, 1).Value = z2
        dgvM2(2, 2).Value = z3

        dgvM3(0, 0).Value = x1
        dgvM3(0, 1).Value = x2
        dgvM3(0, 2).Value = x3
        dgvM3(1, 0).Value = y1
        dgvM3(1, 1).Value = y2
        dgvM3(1, 2).Value = y3
        dgvM3(2, 0).Value = r1
        dgvM3(2, 1).Value = r2
        dgvM3(2, 2).Value = r3




        lblD_1.Text = lblMP.Text
        lblD_2.Text = lblMP.Text
        lblD_3.Text = lblMP.Text
        lblD1.Text = lblM1.Text
        lblD2.Text = lblM2.Text
        lblD3.Text = lblM3.Text

        dgvO.Rows.Insert(0, New Object)

        MP = ((x1 * y2 * z3) + (y1 * z2 * x3) + (z1 * x2 * y3) - (y1 * x2 * z3) - (x1 * z2 * y3) - (z1 * y2 * x3))
        lblMP.Text = MP
        M1 = ((r1 * y2 * z3) + (y1 * z2 * r3) + (z1 * r2 * y3) - (y1 * r2 * z3) - (r1 * z2 * y3) - (z1 * y2 * r3))
        lblM1.Text = M1
        M2 = ((x1 * r2 * z3) + (r1 * z2 * x3) + (z1 * x2 * r3) - (r1 * x2 * z3) - (x1 * z2 * r3) - (z1 * r2 * x3))
        lblM2.Text = M2
        M3 = ((x1 * y2 * r3) + (y1 * r2 * x3) + (r1 * x2 * y3) - (y1 * x2 * r3) - (x1 * r2 * y3) - (r1 * y2 * x3))
        lblM3.Text = M3


        ResultadoX = (M1 / MP)
        lblResultadoX.Text = ResultadoX
        ResultadoY = (M2 / MP)
        lblResultadoY.Text = ResultadoY
        ResultadoZ = (M3 / MP)
        lblResultadoZ.Text = ResultadoZ



    End Sub

    Sub fc()
        dgvO.ColumnCount = 4
        dgvO.Rows.Add(3)
        dgvMP.ColumnCount = 3
        dgvMP.Rows.Add(3)
        dgvM1.ColumnCount = 3
        dgvM1.Rows.Add(3)
        dgvM2.ColumnCount = 3
        dgvM2.Rows.Add(3)
        dgvM3.ColumnCount = 3
        dgvM3.Rows.Add(3)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lblResultadoX.Text = “ ”
        lblResultadoY.Text = “ ”
        lblResultadoZ.Text = “ ”
        lblMP.Text = “ ”
        lblM1.Text = “ ”
        lblM2.Text = “ ”
        lblM3.Text = “ ”


    End Sub

    Private Sub lblMatriz_Click(sender As Object, e As EventArgs) Handles lblMatriz.Click
        i = 1
        lblMatriz.Text = “..ingresando  datos..“
        For f = 0 To 2
            For c = 0 To 3
                m = InputBox(“Dato“,, “llenando matriz“)
                matriz(c, f) = m
                dgvO(c, f).Value = m
                Select Case i
                    Case 1
                        Label1.Text = m
                    Case 2
                        Label2.Text = m
                    Case 3
                        Label3.Text = m
                    Case 4
                        Label4.Text = m
                    Case 5
                        Label5.Text = m
                    Case 6
                        Label6.Text = m
                    Case 7
                        Label7.Text = m
                    Case 8
                        Label8.Text = m
                    Case 9
                        Label9.Text = m
                    Case 10
                        Label10.Text = m
                    Case 11
                        Label11.Text = m
                    Case 12
                        Label12.Text = m

                End Select
                i = i + 1
            Next
        Next


    End Sub
End Class
