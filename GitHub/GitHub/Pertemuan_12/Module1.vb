Imports System.Data.OleDb
Module ModulePert12
    Public conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Dim lokasiDB As String

    Public Sub Koneksi12()
        lokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\tbl_mhs.accdb;"
        conn = New OleDbConnection(lokasiDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module