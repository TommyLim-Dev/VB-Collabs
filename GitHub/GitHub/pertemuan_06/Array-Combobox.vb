Public Class Array_Combobox
    Private Sub Array_Combobox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a() As String = {"faiz", "fadly", "farida", "Yuli"}
        ComboBox1.Items.Add(a(3))

        For i As Integer = 0 To 3
            ComboBox2.Items.Add(a(i))
        Next
    End Sub
End Class