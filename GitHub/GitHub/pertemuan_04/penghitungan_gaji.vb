Public Class penghitungan_gaji
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("001")
        ComboBox1.Items.Add("002")
        ComboBox1.Items.Add("003")
        ComboBox1.Items.Add("004")
        ComboBox1.Items.Add("005")

        ComboBox2.Items.Add("IIIA")
        ComboBox2.Items.Add("IIIB")
        ComboBox2.Items.Add("IIIC")
        ComboBox2.Items.Add("IIID")
        ComboBox2.Items.Add("IVA")

        ComboBox3.Items.Add("KaBag")
        ComboBox3.Items.Add("KaSub")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "001"
                TextBox1.Text = "Hui Dhien Chandra"
            Case "002"
                TextBox1.Text = "Nurfitra Efriansyah Lim"
            Case "003"
                TextBox1.Text = "Junius Lindo"
            Case "004"
                TextBox1.Text = "Tommy"
            Case "005"
                TextBox1.Text = "Fernando"
            Case Else
                TextBox1.Text = "-"
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "IIIA"
                TextBox2.Text = 2500000
            Case "IIIB"
                TextBox2.Text = 2750000
            Case "IIIC"
                TextBox2.Text = 3000000
            Case "IIID"
                TextBox2.Text = 3250000
            Case "IVA"
                TextBox2.Text = 3500000
            Case Else
                TextBox2.Text = 0
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.Text
            Case "KaBag"
                TextBox3.Text = 2000000
            Case "KaSub"
                TextBox3.Text = 2500000
            Case Else
                TextBox3.Text = 0
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
