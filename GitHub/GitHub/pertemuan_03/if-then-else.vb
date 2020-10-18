Public Class ifthenelse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CInt(TextBox1.Text) >= 56 Then
            TextBox2.Text = "LULUS"
        Else
            TextBox2.Text = "GAGAL"
        End If
    End Sub
End Class
