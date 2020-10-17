Public Class program_spbu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Mobil")
        ComboBox1.Items.Add("Motor")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "Mobil"
                Label8.Text = ": 4"
            Case "Motor"
                Label8.Text = ": 2"
            Case Else
                Label8.Text = ": "
        End Select
        If RadioButton1.Checked = True Then
            Label9.Text = ": " & Val(TextBox2.Text) * Val(TextBox1.Text)
            Label10.Text = ": " & TextBox2.Text
        ElseIf RadioButton2.Checked = True Then
            Label9.Text = ": " & TextBox2.Text
            Label10.Text = ": " & Val(TextBox2.Text) / Val(TextBox1.Text)
        End If
    End Sub
End Class
