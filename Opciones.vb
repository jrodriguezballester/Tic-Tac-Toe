Public Class Opciones

    ''' <summary>
    ''' Cierra Opciones
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Close()
    End Sub

    ''' <summary>
    ''' recoge el valor de las filas y lanza el juego
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Close()
        ' Dim filas As Integer
        If RadioButton3.Checked Then
            Form1.filas = 3
        ElseIf RadioButton4.Checked Then
            Form1.filas = 4
        ElseIf RadioButton5.Checked Then
            Form1.filas = 5
        ElseIf RadioButton6.Checked Then
            Form1.filas = 6
        ElseIf RadioButton7.Checked Then
            Form1.filas = 7
        ElseIf RadioButton8.Checked Then
            Form1.filas = 8
        ElseIf RadioButton9.Checked Then
            Form1.filas = 9
        End If
        Form1.Iniciarjuego()
    End Sub

    ''' <summary>
    ''' Cuando esta checkeada muestra imagen jugador 1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PictureBoxGamer1.Image = Global.Tic_Tac_Toe.My.Resources.Resources.x
        End If
    End Sub

    ''' <summary>
    ''' Cuando esta checkeada muestra imagen jugador 2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            PictureBoxGamer2.Image = Global.Tic_Tac_Toe.My.Resources.Resources.O
        End If
    End Sub

    ''' <summary>
    ''' Abre un OpenFileDialog, Carga Imagen de Jugador 2 y deschekea la casilla de imagen por defecto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonImagen2_Click(sender As Object, e As EventArgs) Handles ButtonImagen2.Click
        Dim opf1 = New OpenFileDialog()
        opf1.Title = "Please select Avatar"
        ' opf1.InitialDirectory = "D:\proyectosVB\Tic-Tac-Toe\recursos"
        opf1.InitialDirectory = "."
        opf1.Filter = "Image Files(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*"
        Dim result As DialogResult = opf1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Try
                PictureBoxGamer2.Image = Image.FromFile(opf1.FileName)
                CheckBox2.Checked = False
            Catch ex As Exception
                PictureBoxGamer2.Image = Global.Tic_Tac_Toe.My.Resources.Resources.O
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Abre un OpenFileDialog, Carga Imagen de Jugador 1 y deschekea la casilla de imagen por defecto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonImagen1_Click(sender As Object, e As EventArgs) Handles ButtonImagen1.Click
        Dim opf1 = New OpenFileDialog()
        opf1.Title = "Please select Avatar"
        opf1.InitialDirectory = "D:\proyectosVB\Tic-Tac-Toe\recursos"
        '  opf1.InitialDirectory = "."
        opf1.Filter = "Image Files(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*"
        Dim result As DialogResult = opf1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Try
                PictureBoxGamer1.Image = Image.FromFile(opf1.FileName)
                CheckBox1.Checked = False
            Catch ex As Exception
                PictureBoxGamer1.Image = Global.Tic_Tac_Toe.My.Resources.Resources.x
            End Try
        End If
    End Sub


    Private Sub RadioButtonHumano_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonHumano.CheckedChanged
        EliminarOpcionesIA()
    End Sub

    Private Sub RadioButtonIA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIA.CheckedChanged
        RellenarOpciones()

    End Sub

    Private Sub RellenarOpciones()
        TextBoxGamer2_name.Text() = "HAL 9000"
        TextBoxGamer2_name.Enabled = False
        PictureBoxGamer2.Image = Global.Tic_Tac_Toe.My.Resources.Imagen_IA
        ButtonImagen2.Enabled = False
        CheckBox2.Checked = True
        CheckBox2.Enabled = False
    End Sub
    Private Sub EliminarOpcionesIA()
        TextBoxGamer2_name.Text() = ""
        TextBoxGamer2_name.Enabled = True
        PictureBoxGamer2.Image = Global.Tic_Tac_Toe.My.Resources.O
        ButtonImagen2.Enabled = True
        CheckBox2.Checked = True
        CheckBox2.Enabled = True
    End Sub

End Class