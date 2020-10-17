Public Class select_case_01
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Jeruk")
        ListBox1.Items.Add("Alpukat")
        ListBox1.Items.Add("Strawberry")
        ListBox1.Items.Add("Semangka")
        ListBox1.Items.Add("Lengkeng")
        ListBox1.Items.Add("Kedondong")
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Select Case ListBox1.SelectedIndex
            Case 0
                Label2.Text = "Banyak Mengandung Vitamin C"
            Case 1
                Label2.Text = "Salah satu buah yang mengandung lemak"
            Case 2
                Label2.Text = "Hanya tumbuh di dataran tinggi"
            Case 3
                Label2.Text = "Buah berair ... Enak dimakan kalau cuaca panas"
            Case 4
                Label2.Text = "Pasti buah yang satu ini rasanya manis"
            Case 5
                Label2.Text = "Enak kalau dibikin rujak"
        End Select
    End Sub
End Class
