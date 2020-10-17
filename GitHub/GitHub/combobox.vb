Public Class combobox
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Paket 1" Then
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Rendang"
            TextBox2.Text = "Teh Manis"
            TextBox3.Text = "110000"
        ElseIf ComboBox1.Text = "Paket 2" Then
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Ayam Goreng"
            TextBox2.Text = "Jus Jeruk"
            TextBox3.Text = "150000"
        ElseIf ComboBox1.Text = "Paket 3" Then
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Nasi Goreng"
            TextBox2.Text = "Es Teh"
            TextBox3.Text = "80000"
        ElseIf ComboBox1.Text = "Paket 4" Then
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Nasi Bakar"
            TextBox2.Text = "Kopi"
            TextBox3.Text = "170000"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Paket 1")
        ComboBox1.Items.Add("Paket 2")
        ComboBox1.Items.Add("Paket 3")
        ComboBox1.Items.Add("Paket 4")
    End Sub
End Class
