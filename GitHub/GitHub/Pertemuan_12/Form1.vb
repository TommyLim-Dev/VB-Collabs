Imports System.Data
Imports System.Data.OleDb
Public Class Pert12
    Sub kosongkan()
        txtnim.Text = ""
        txtnama.Text = ""
        cmbjurusan.Text = ""
        txtalamat.Text = ""
        txtnim.Focus()
    End Sub
    Sub matikan()
        txtnim.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        cmbjurusan.Enabled = False
    End Sub
    Sub hidupkan()
        txtnim.Enabled = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        cmbjurusan.Enabled = True
    End Sub
    Sub tampil()
        Call Koneksi12()
        Dim Da = New OleDb.OleDbDataAdapter("select * from data", ModulePert12.conn)
        Dim Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call matikan()
        Call tampil()
    End Sub

    Private Sub binput_Click(sender As Object, e As EventArgs) Handles binput.Click
        Call hidupkan()
        Call kosongkan()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        If txtnim.Text = "" Or txtnama.Text = "" Then
            MsgBox("Lengkapi Data...!!")
            Exit Sub
        Else
            Call Koneksi12()
            ModulePert12.Cmd = New OleDb.OleDbCommand("select * From data where NIM = '" & txtnim.Text & "'", ModulePert12.conn)
            Dim Rd = Module13.Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("Data sudah ada...")
            Else
                Dim simpan As String
                simpan = "Insert into data values('" & txtnim.Text & "', '" & txtnama.Text & "','" & txtalamat.Text & "','" & cmbjurusan.Text & "')"
                Module13.Cmd = New OleDb.OleDbCommand(simpan, ModulePert12.conn)
                Module13.Cmd.ExecuteNonQuery()
                MsgBox("input data berhasil..")
            End If
            Call matikan()
            Call kosongkan()
            Call tampil()
        End If
    End Sub

    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        If txtnim.Text = "" Or txtnama.Text = "" Then
            MsgBox("Data Belum lengkap")
            Exit Sub
        Else
            Call Koneksi12()
            ModulePert12.Cmd = New OleDb.OleDbCommand("update data set Nama= '" & txtnama.Text & "', Jurusan='" & cmbjurusan.Text & "', Alamat= '" & txtalamat.Text & "'where NIM='" & txtnim.Text & "'", ModulePert12.conn)
            ModulePert12.Cmd.ExecuteNonQuery()
            MsgBox("Update Data Berhasil..")
        End If
        Call matikan()
        Call kosongkan()
        Call tampil()

    End Sub


    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        If txtnim.Text = "" Then
            MsgBox("Tidak Ada Data Yang Akan Dihapus")
            Exit Sub
        Else
            Call ModulePert12.Koneksi12()
            ModulePert12.Cmd = New OleDb.OleDbCommand("delete from data where NIM='" & txtnim.Text & "'", ModulePert12.conn)
            ModulePert12.Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Sukses..")
            Call matikan()
            Call kosongkan()
            Call tampil()
        End If
    End Sub

    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim RowCount, RowIndex As Integer
        RowCount = DataGridView1.Rows.Count - 1
        RowIndex = DataGridView1.CurrentRow.Index
        If RowCount = RowIndex Then
            DataGridView1.ClearSelection()
            txtnim.Text = ""
            txtnama.Text = ""
            txtalamat.Text = ""
            cmbjurusan.Text = ""
        Else
            txtnim.Text = DataGridView1.Item(0, RowIndex).Value
            txtnama.Text = DataGridView1.Item(1, RowIndex).Value
            txtalamat.Text = DataGridView1.Item(2, RowIndex).Value
            cmbjurusan.Text = DataGridView1.Item(3, RowIndex).Value
        End If
        Call hidupkan()
    End Sub
End Class
