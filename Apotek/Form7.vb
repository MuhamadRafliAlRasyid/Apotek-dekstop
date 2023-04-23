Imports MySql.Data.MySqlClient

Public Class Form7
    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilTransaksi()
    End Sub

    Sub tampilTransaksi()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM tbl_resep inner JOIN tbl_obat", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_transaksi")
        dg_transaksi.DataSource = DS.Tables("tbl_transaksi")
        DA.Dispose()
    End Sub

    Sub insertlogout()
        koneksi()
        Dim userid As Integer
        CMD = New MySqlCommand("select id_user from tbl_user where username = '" & loggedInUser & "'", CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            userid = RD("id_user")
            RD.Close()
            Dim datenow As DateTime = DateTime.Now
            CMD = New MySqlCommand("insert into tbl_log (waktu, aktivitas, id_user) values ('" & datenow.ToString("yyyy/MM/dd HH:mm:ss") & "', 'Logout', " & userid & ")", CONN)
            CMD.ExecuteNonQuery()
        End If
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Call insertlogout()
        Me.Hide()
        Form1.Visible = True
        Form1.username.Focus()
    End Sub
End Class