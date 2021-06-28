Public Class PolinomioNewton
    Private Sub PolinomioNewton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function calcularCelda(columna As Integer, renglon As Integer) As Double
        Dim fx0, fx1, x0, x1 As Double
        Dim separacion As Integer = columna
        fx0 = Double.Parse(dgvSalidas.Rows(renglon).Cells(columna - 1).Value)
        fx1 = Double.Parse(dgvSalidas.Rows(renglon + 1).Cells(columna - 1).Value)
        x0 = Double.Parse(dgvEntradas.Rows(renglon).Cells(0).Value)
        x1 = Double.Parse(dgvEntradas.Rows(renglon + separacion).Cells(0).Value)

        Return (fx1 - fx0) / (x1 - x0)
    End Function


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click


        dgvSalidas.Columns.Clear()
        dgvSalidas.Rows.Clear()
        For i As Integer = 0 To dgvEntradas.Rows.Count - 2

            dgvSalidas.Columns.Add("", "")
            dgvSalidas.Rows.Add()
            dgvSalidas.Rows(i).Cells(0).Value = dgvEntradas.Rows(i).Cells(1).Value
        Next


        For i As Integer = 1 To dgvEntradas.Rows.Count - 2 'columnas


            Dim separacion As Integer = i

            For j As Integer = 0 To dgvEntradas.Rows.Count - 2 - separacion ' renglones

                dgvSalidas.Rows(j).Cells(i).Value = calcularCelda(i, j)

            Next
        Next
        lblPolinomio.Text = "f(x)="

        For i = 0 To dgvSalidas.Rows.Count - 1
            Dim texto As String
            Dim coeficiente As Double = dgvSalidas.Rows(0).Cells(i).Value


            texto = $"({coeficiente}"

            For j = 0 To i - 1
                Dim x As String = dgvEntradas.Rows(j).Cells(0).Value.ToString()
                texto = texto & $"(x - {x} )"
            Next

            texto = texto & ") +"
            lblPolinomio.Text = lblPolinomio.Text & texto
        Next
        lblPolinomio.Text = lblPolinomio.Text & "0"
    End Sub
End Class