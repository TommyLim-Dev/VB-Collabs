Public Class Latihan_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim awal, akhir, stp, i As Integer
        awal = TextBox1.Text
        akhir = TextBox2.Text
        stp = TextBox3.Text
        ListBox1.Items.Clear()
        If awal < akhir Then
            For i = awal To akhir Step stp
                ListBox1.Items.Add(i)
            Next
        ElseIf awal > akhir Then
            For i = awal To akhir Step -stp
                ListBox1.Items.Add(i)
            Next
        ElseIf awal = akhir Then
            MsgBox("Angka awal dan akhir sama!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim awal, akhir, stp As Integer
        awal = TextBox1.Text
        akhir = TextBox2.Text
        stp = TextBox3.Text
        ListBox1.Items.Clear()
        If awal < akhir Then
            Do While awal < akhir
                ListBox1.Items.Add(awal)
                awal += stp
            Loop
        ElseIf awal > akhir Then
            Do While awal > akhir
                ListBox1.Items.Add(awal)
                awal -= stp
            Loop
        ElseIf awal = akhir Then
            MsgBox("Angka awal dan akhir sama!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim awal, akhir, stp As Integer
        awal = TextBox1.Text
        akhir = TextBox2.Text
        stp = TextBox3.Text
        ListBox1.Items.Clear()
        If awal < akhir Then
            Do Until awal > akhir
                ListBox1.Items.Add(awal)
                awal += stp
            Loop
        ElseIf awal > akhir Then
            Do Until awal < akhir
                ListBox1.Items.Add(awal)
                awal -= stp
            Loop
        ElseIf awal = akhir Then
            MsgBox("Angka awal dan akhir sama!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim awal, akhir, stp As Integer
        awal = TextBox1.Text
        akhir = TextBox2.Text
        stp = TextBox3.Text
        ListBox1.Items.Clear()
        If awal < akhir Then
            While awal < akhir
                ListBox1.Items.Add(awal)
                awal += stp
            End While
        ElseIf awal > akhir Then
            While awal > akhir
                ListBox1.Items.Add(awal)
                awal -= stp
            End While
        ElseIf awal = akhir Then
            MsgBox("Angka awal dan akhir sama!")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
