Public Class select_case_02
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Paket 1")
        ComboBox1.Items.Add("Paket 2")
        ComboBox1.Items.Add("Paket 3")
        ComboBox1.Items.Add("Paket 4")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case (ComboBox1.Text)
            Case "Paket 1"
                TextBox1.Text = "Nasi Goreng"
                TextBox2.Text = "Teh Obeng"
                TextBox3.Text = "25000"
            Case "Paket 2"
                TextBox1.Text = "Ayam Goreng"
                TextBox2.Text = "Jus Jeruk"
                TextBox3.Text = "35000"
            Case "Paket 3"
                TextBox1.Text = "Ayam Bakar"
                TextBox2.Text = "Es Milo"
                TextBox3.Text = "30000"
            Case Else
                TextBox1.Text = "Nasi Bakar"
                TextBox2.Text = "Kopi"
                TextBox3.Text = "40000"
        End Select
    End Sub
End Class
