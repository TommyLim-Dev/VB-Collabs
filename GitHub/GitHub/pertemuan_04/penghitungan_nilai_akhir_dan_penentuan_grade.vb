Public Class penghitungan_nilai_akhir_dan_penentuan_grade
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = 0.25 * Val(TextBox1.Text) + 0.3 * Val(TextBox2.Text) + 0.45 * Val(TextBox3.Text)
        Select Case (TextBox1.Text)
            Case Is >= 81
                TextBox5.Text = "A"
            Case Is >= 71
                TextBox5.Text = "B"
            Case Is >= 61
                TextBox5.Text = "C"
            Case Is >= 51
                TextBox5.Text = "D"
            Case Is <= 50
                TextBox5.Text = "F"
        End Select
    End Sub
End Class
