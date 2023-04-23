Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub kelolauser_Click(sender As Object, e As EventArgs) Handles kelolauser.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub kelolaobat_Click(sender As Object, e As EventArgs) Handles kelolaobat.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub kelolalaporan_Click(sender As Object, e As EventArgs) Handles kelolalaporan.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilLog()
        Call aturDGV()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim pesan As String
        pesan = MsgBox("Anda yakin ingin logout?", vbYesNo + vbQuestion, "Logout")
        If pesan = vbYes Then
            Call insertlogout()
            Me.Hide()
            Form1.Visible = True
            Form1.username.Focus()
        End If
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

    Sub tampilLog()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT a.id_log,b.username,a.waktu,a.aktivitas FROM tbl_log AS a inner JOIN tbl_user AS b ON a.id_user = b.id_user ", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_log")
        dg_log.DataSource = DS.Tables("tbl_log")
        DA.Dispose()
    End Sub

    Sub aturDGV()
        Try
            dg_log.Columns(0).Width = 70
            dg_log.Columns(1).Width = 130
            dg_log.Columns(2).Width = 180
            dg_log.Columns(3).Width = 150
            dg_log.Columns(0).HeaderText = "Id Log"
            dg_log.Columns(1).HeaderText = "Username"
            dg_log.Columns(2).HeaderText = "Waktu"
            dg_log.Columns(3).HeaderText = "Aktivitas"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        koneksi()
        CMD = New MySqlCommand("SELECT a.id_log,b.username,a.waktu,a.aktivitas FROM tbl_log AS a INNER JOIN tbl_user AS b ON a.id_user = b.id_user WHERE waktu LIKE '%" & dtp.Value.ToString("yyyy-MM-dd") & "%'", CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbl_log")
        dg_log.DataSource = DS.Tables("tbl_log")
        DA.Dispose()
        RD.Close()
    End Sub

End Class