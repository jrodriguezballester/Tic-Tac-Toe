Public Class Opciones


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Poner_icono_por_defecto1(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        ' gamer1_imagen = Global.Tic_Tac_Toe.My.Resources.Resources._69jYqiBt
        If CheckBox1.Checked Then
            PictureBoxGamer1.Image = Global.Tic_Tac_Toe.My.Resources.Resources.Alphabet_150787_640
        Else
            PictureBoxGamer2.Image = Global.Tic_Tac_Toe.My.Resources.Resources._3077_png_860
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call ShowDialog.
        Dim opf1 = New OpenFileDialog()
        opf1.Title = "Please select Avatar"
        opf1.InitialDirectory = "D:\proyectosVB\Tic-Tac-Toe\recursos"
        '  opf1.InitialDirectory = "."
        opf1.Filter = "Image Files(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*"
        Dim result As DialogResult = opf1.ShowDialog()
        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            Try
                PictureBoxGamer1.Image = Image.FromFile(opf1.FileName)
            Catch ex As Exception
                PictureBoxGamer1.Image = Global.Tic_Tac_Toe.My.Resources.Resources.Alphabet_150787_640
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opf1 = New OpenFileDialog()
        opf1.Title = "Please select Avatar"
        opf1.InitialDirectory = "D:\proyectosVB\Tic-Tac-Toe\recursos"
        '  opf1.InitialDirectory = "."
        opf1.Filter = "Image Files(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*"
        Dim result As DialogResult = opf1.ShowDialog()
        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            Try
                PictureBoxGamer2.Image = Image.FromFile(opf1.FileName)
            Catch ex As Exception
                PictureBoxGamer2.Image = Global.Tic_Tac_Toe.My.Resources.Resources._3077_png_860
            End Try
        End If
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Close()
        Dim filas As Integer
        If RadioButton3.Checked Then
            filas = 3
        ElseIf RadioButton4.Checked Then
            filas = 4
        ElseIf RadioButton5.Checked Then
            filas = 5

        End If
        Form1.Nivel_juego(filas)
        Form1.iniciarjuego()

    End Sub
End Class