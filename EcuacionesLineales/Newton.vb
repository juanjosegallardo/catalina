Public Class Newton

    Function f(x As Double) As Double
        Return Math.Cos(x) - x * x * x
    End Function


    Private Function df(x As Double) As Double
        Return -Math.Sin(x) - 3 * x * x
    End Function


    Private Function calcularSiguienteX(x As Double) As Double
        Return x - f(x) / df(x)

    End Function


    Private Sub CalcularNewton(inicio As Double, n As Integer, error_minimo As Double)
        Dim i As Integer
        Dim xn As Double
        xn = inicio
        Dim error_relativo As Double

        For i = 1 To n

            error_relativo = Math.Abs(calcularSiguienteX(xn) - xn) / Math.Abs(calcularSiguienteX(xn))
            imprimir(xn, f(xn), error_relativo)
            xn = calcularSiguienteX(xn)

            If (error_relativo < error_minimo) Then
                Exit For
            End If

        Next i

    End Sub

    Private Sub Imprimir(xn As Double, fx As Double, error_relativo As Double)
        dgvResultados.Rows.Add({xn.ToString(), fx.ToString(), error_relativo.ToString()})
    End Sub

    Private Sub btnCalcular_Clic8k(sender As Object, e As EventArgs) Handles btnCalcular.Click
        dgvResultados.Columns.Clear()
        dgvResultados.Columns.Add("xn", "xn")
        dgvResultados.Columns.Add("fx", "fx")
        dgvResultados.Columns.Add("error_relativo", "error_relativo")
        dgvResultados.Rows.Clear()
        CalcularNewton(Double.Parse(txtValorInicial.Text), Integer.Parse(txtIteraciones.Text), 0)
    End Sub
End Class