﻿Imports MySql.Data.MySqlClient

Module Module1

    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Public loggedInUser = Form1.username.Text

    Sub koneksi()
        Try
            Dim STR As String = "userid=root;server=localhost;database=sistem_apotek"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
