Public Class Form1

    Dim N As String
    Private Sub ENTRAR_Click(sender As Object, e As EventArgs) Handles ENTRAR.Click
        N = textNombre.Text
        SALUDO.Text = ("Hola, ") & N & (",ten un buen día.")
    End Sub
End Class
