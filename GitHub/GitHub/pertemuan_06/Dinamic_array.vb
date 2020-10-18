Public Class Dinamic_Array
    Private Structure DataMahasiswa
        Dim nama As String
        Dim Nomor As String
        Dim jurusan As String
        Dim tanggal As String
        Dim alamat As String
    End Structure
    Dim indeks As Integer
    Dim data() As DataMahasiswa

    Sub DaftarMahasiswa()
        data(indeks).nama = TextBox2.Text
        data(indeks).Nomor = TextBox3.Text
        data(indeks).jurusan = TextBox4.Text
        data(indeks).tanggal = TextBox5.Text
        data(indeks).alamat = TextBox6.Text
    End Sub
    Sub HapusDaftar()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox2.Focus()
    End Sub

    Sub tampilanData()
        MsgBox("Informasi Data Mahasiswa ke- " & indeks & Chr(10) &
               "Nama : " & data(indeks).nama & Chr(10) &
               "NIM  : " & data(indeks).Nomor & Chr(10) &
               "Jurusan : " & data(indeks).jurusan & Chr(10) &
               "Tanggal Lahir : " & data(indeks).tanggal & Chr(10) &
               "Alamat : " & data(indeks).alamat, , "Data Mahasiswa")
    End Sub

    Sub tampilanform()
        TextBox2.Text = data(indeks).nama
        TextBox3.Text = data(indeks).Nomor
        TextBox4.Text = data(indeks).jurusan
        TextBox5.Text = data(indeks).tanggal
        TextBox6.Text = data(indeks).alamat
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HapusDaftar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DaftarMahasiswa()
        tampilanData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If indeks = 1 Then
        ElseIf indeks > LBound(data) Then
            DaftarMahasiswa()
            indeks = indeks - 1
            tampilanform()
        End If
        If indeks = 0 Then indeks = 1
        TextBox1.Text = indeks
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If indeks = UBound(data) Then
            ReDim Preserve data(indeks + 1)
        End If
        TextBox1.Text = indeks
        DaftarMahasiswa()
        indeks = indeks + 1
        TextBox1.Text = indeks
        tampilanform()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        indeks = 1
        ReDim data(indeks)
        TextBox1.Text = indeks
    End Sub
End Class
