Public Class entry_data_mahasiswa
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "Selamat Datang, " & TextBox2.Text
        Label6.Text = "Anda Masuk Jurusan " & ComboBox1.Text
        If RadioButton1.Checked = True Then
            Label7.Text = "Anda Laki-laki"
        Else
            Label7.Text = "Anda Perempuan"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Sistem Informasi")
        ComboBox1.Items.Add("Teknik Informatika")
        ComboBox1.Items.Add("Teknik Industri")
        ComboBox1.Items.Add("Akuntansi")
    End Sub
End Class
