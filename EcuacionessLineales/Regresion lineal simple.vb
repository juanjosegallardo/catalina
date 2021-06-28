Public Class Regresion_lineal_simple
    Dim a, b As Double
    Dim x, Correlacion, Mediax, Mediay, M1, M2, Sumaxy, Vx, Sx2, Vy, Sy2, raiz, Multxy As Double

    Private Sub btnIngresaValoraX_Click(sender As Object, e As EventArgs) Handles btnIngresaValoraX.Click
        lstValoresX.Items.Add(txtIngresaValores.Text)
        txtIngresaValores.Text = ""
        txtIngresaValores.Focus()
    End Sub

    Private Sub btnIngresaValoraY_Click(sender As Object, e As EventArgs) Handles btnIngresaValoraY.Click
        lstValoresY.Items.Add(txtIngresaValores.Text)
        txtIngresaValores.Text = ""
        txtIngresaValores.Focus()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Media de los valores en los lst
        For x = 0 To (lstValoresX.Items.Count - 1 And lstValoresY.Items.Count - 1)
            Mediax = Mediax + Val(lstValoresX.Items(x)) / lstValoresX.Items.Count
            Mediay = Mediay + Val(lstValoresY.Items(x)) / lstValoresY.Items.Count
            'Media de la suma de x y
            Sumaxy = 0
            For i = 0 To (lstValoresX.Items.Count - 1 And lstValoresY.Items.Count - 1)
                M1 = (Val(lstValoresX.Items(x)) - Mediax)
                lstResultadoa.Items.Add(M1)
                M2 = (Val(lstValoresY.Items(x)) - Mediay)
                lstResultadob.Items.Add(M2)
                Sumaxy = Sumaxy + (M1 * M2)
            Next
            'Formula de medias elevadas al cuadrado
            For i = 0 To lstValoresX.Items.Count - 1
                Vx = (Val(lstValoresX.Items(x)) - Mediax) ^ 2
                Sx2 = Sx2 + Vx
                Vy = (Val(lstValoresY.Items(x)) - Mediay) ^ 2
                Sy2 = Sy2 + Vy
            Next
            'Formulas a,b y correlacion 
            If Sumaxy = 0.0 Then
                lblResultadodeb.Text = "0"
            Else
                b = (Sumaxy) / Sx2
                txtResultadodeb.Text = FormatNumber(b, 2)
            End If
            a = Mediay - (b * Mediax)
            txtResultadodea.Text = FormatNumber(a, 2)
            Multxy = (Sx2 * Sy2)
            If Multxy = 0.0 Then
                txtCorrelacion.Text = Multxy
            Else
                raiz = Multxy ^ (1 / 2)
                Correlacion = (Sumaxy) / raiz
                txtCorrelacion.Text = FormatNumber(Correlacion, 2)
            End If
            txtIngresaValores.Focus()

        Next


    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lstValoresX.Items.Clear()
        lstValoresY.Items.Clear()
        lstResultadoa.Items.Clear()
        lstResultadob.Items.Clear()
        txtIngresaValores.Focus()
        txtCorrelacion.Text = ""
        txtResultadodea.Text = ""
        txtResultadodeb.Text = ""

    End Sub

    Private Sub Regresion_lineal_simple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class