Public Class for_next_3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As VariantType
        For a = 1 To 31
            ComboBox1.Items.Add(Str(a))
        Next
        For a = 1 To 12
            ComboBox2.Items.Add(MonthName(a))
        Next
        For a = 1945 To Year(Now)
            ComboBox3.Items.Add(Str(a))
        Next
    End Sub
End Class
