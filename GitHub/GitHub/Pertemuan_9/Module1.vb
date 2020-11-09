Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb

Module Module1
    Public X As Boolean
    Public S As String = ""
    Public T As String = ""
    Public OLECMD As OleDbCommand
    Public OLERDR As OleDbDataReader
    Public CNN As OleDbConnection
    Public KONEKSI As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
    Application.StartupPath & "\ADOGaji.accdb;"

End Module
