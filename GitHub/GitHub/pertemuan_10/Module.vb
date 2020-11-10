Imports System.Data.OleDb
Module Modules

    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Dim LokasiDB As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=DBAplikasi.accdb"
    Public CNN1 As OleDbConnection = New OleDbConnection(LokasiDB)


End Module
