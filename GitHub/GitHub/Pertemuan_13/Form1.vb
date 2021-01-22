Imports System.Data.OleDb
Public Class Form13a
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap, silahkan isi semua form !")
        Else
            Call Koneksi13()
            Module13.Cmd = New OleDbCommand("select * from Tb_user where Username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", Module13.conn)
            Module13.Rd = Module13.Cmd.ExecuteReader
            Module13.Rd.Read()
            If Module13.Rd.HasRows Then
                Me.Hide()

            Else
                MsgBox("User atau Password salah!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
