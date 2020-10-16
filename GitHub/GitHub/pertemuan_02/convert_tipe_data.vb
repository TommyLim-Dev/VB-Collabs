Public Class convert_tipe_data
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim harga, jumlah, total As Integer
        harga = CInt(TextBox2.Text)
        jumlah = CInt(TextBox3.Text)

        total = harga * jumlah

        TextBox4.Text = CStr(total)
    End Sub
End Class
