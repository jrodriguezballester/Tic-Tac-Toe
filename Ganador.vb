Public Class Ganador
    Private Sub ButtonPlayAgain_Click(sender As Object, e As EventArgs) Handles ButtonPlayAgain.Click
        Close()
        Form1.Iniciarjuego()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class