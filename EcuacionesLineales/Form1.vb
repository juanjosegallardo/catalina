Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuArchivoSalir_Click(sender As Object, e As EventArgs) Handles mnuArchivoSalir.Click
        Application.Exit()
    End Sub

    Private Sub mnuCramerE1_Click(sender As Object, e As EventArgs) Handles mnuCramerE1.Click
        Ejemplo1.ShowDialog()
    End Sub

    Private Sub mnuEM_Click(sender As Object, e As EventArgs) Handles mnuEM.Click
        EM.ShowDialog()
    End Sub

    Private Sub mnuGaussjordann_Click(sender As Object, e As EventArgs) Handles mnuGaussjordann.Click
        Gauss_Jordan.ShowDialog()
    End Sub

    Private Sub mnuRegresionLS_Click(sender As Object, e As EventArgs) Handles mnuRegresionLS.Click
        Regresion_lineal_simple.ShowDialog()
    End Sub

    Private Sub EcuacionesNoLinealesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcuacionesNoLinealesToolStripMenuItem.Click
        Newton.ShowDialog()
    End Sub

    Private Sub PollinomioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PollinomioToolStripMenuItem.Click
        PolinomioNewton.ShowDialog()
    End Sub
End Class
