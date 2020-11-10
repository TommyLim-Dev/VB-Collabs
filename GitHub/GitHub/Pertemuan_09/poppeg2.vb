Imports System.Data.OleDb
Imports System.Data
Public Class poppegs
    Public colNIP, colNama, colbgn, coltgllhr, colAlamat, colPend, colstatus As String
    Dim cnn As OleDbConnection
    Dim cmmd As OleDbCommand
    Dim dReader As OleDbDataReader
    Private Sub clear_list()
        While Val(counter.Text) > 0
            ListView1.Items(0).Remove()
            counter.Text = Val(counter.Text) - 1
        End While
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        Call List_data()
    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged
        Call list_data2()
    End Sub

    Private Sub pilih()

        Try

            colNIP = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            colNama = ListView1.SelectedItems(0).SubItems(1).Text.ToString
            colbgn = ListView1.SelectedItems(0).SubItems(2).Text.ToString
            coltgllhr = ListView1.SelectedItems(0).SubItems(3).Text.ToString
            colAlamat = ListView1.SelectedItems(0).SubItems(4).Text.ToString
            colPend = ListView1.SelectedItems(0).SubItems(5).Text.ToString
            colstatus = ListView1.SelectedItems(0).SubItems(6).Text.ToString
            Me.Close()
        Catch ex As Exception
            MsgBox("pilih salah satu data", MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub list_data2()
        Call clear_list()
        Dim test As String
        Dim x As Integer
        test = "SELECT * FROM Pegawai WHERE NIP like '%" &
            Trim(txtNIP.Text) & "%' ORDER BY NIP ASC"

        cnn = New OleDbConnection(KONEKSI)
        If cnn.State <> ConnectionState.Closed Then cnn.Close()
        cnn.Open()
        cmmd = New OleDbCommand(test, cnn)
        dReader = cmmd.ExecuteReader
        Try
            While dReader.Read = True
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1) & " Record"

                With ListView1
                    .Items.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(x).SubItems(0).Text = dReader.GetString(0)
                    .Items(x).SubItems(1).Text = dReader.GetString(1)
                    .Items(x).SubItems(2).Text = dReader.GetString(2)
                    .Items(x).SubItems(3).Text = dReader.GetDateTime(3)
                    .Items(x).SubItems(4).Text = dReader.GetString(4)
                    .Items(x).SubItems(5).Text = dReader.GetString(5)
                    .Items(x).SubItems(6).Text = dReader.GetString(6)
                End With
            End While
        Finally
            dReader.Close()
        End Try
        cnn.Close()
    End Sub
    Public Sub List_data()
        Call clear_list()

        Dim sqlx As String
        Dim x As Integer
        sqlx = "select NIP,NamaPGW,Bagian,TglLhr,Alamat,Pendidikan,Status from Pegawai where NamaPGW like '%" &
        Trim(txtNama.Text) & "%' order by NamaPgw asc"

        cnn = New OleDbConnection(KONEKSI)
        If cnn.State <> ConnectionState.Closed Then cnn.Close()
        cnn.Open()
        cmmd = New OleDbCommand(sqlx, cnn)
        dReader = cmmd.ExecuteReader
        Try
            While dReader.Read = True
                x = Val(counter.Text)
                counter.Text = Str(Val(counter.Text) + 1) & "Record"

                With ListView1
                    .Items.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(x).SubItems(0).Text = dReader.GetString(0)
                    .Items(x).SubItems(1).Text = dReader.GetString(1)
                    .Items(x).SubItems(2).Text = dReader.GetString(2)
                    .Items(x).SubItems(3).Text = dReader.GetDateTime(3)
                    .Items(x).SubItems(4).Text = dReader.GetString(4)
                    .Items(x).SubItems(5).Text = dReader.GetString(5)
                    .Items(x).SubItems(6).Text = dReader.GetString(6)
                End With
            End While
        Finally
            dReader.Close()
        End Try
        cnn.Close()
    End Sub



    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call pilih()
    End Sub


    Private Sub counter_TextChanged(sender As Object, e As EventArgs) Handles counter.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Call pilih()
    End Sub

    Private Sub poppeg2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call List_data()
    End Sub
End Class