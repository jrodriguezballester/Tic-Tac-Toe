Public Class Form2
    Private texto As String
    Private numero As Integer
    ' Constructor Form2
    Public Sub New(ByVal miTexto As String, ByVal miNumero As Integer)

        texto = miTexto
        numero = miNumero

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelGanador.Text = "hola"
    End Sub
End Class