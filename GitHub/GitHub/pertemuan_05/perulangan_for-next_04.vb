Public Class for_next_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim teks As String
        Dim jumlah, i As Integer
        teks = TextBox1.Text
        jumlah = TextBox2.Text
        For i = 1 To jumlah
            ListBox1.Items.Add(i & ". " & teks)
        Next
    End Sub
End Class
