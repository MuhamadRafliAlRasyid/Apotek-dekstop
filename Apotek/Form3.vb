Imports MySql.Data.MySqlClient

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call editfalse()
    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click
        Call tambahtrue()
        Call editfalse()
    End Sub

    Sub tambahfalse()
        btntambah.Enabled = False
    End Sub

    Sub tambahtrue()
        btntambah.Enabled = True
    End Sub

    Sub editfalse()
        btnedit.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Sub edittrue()
        btnedit.Enabled = True
        btnhapus.Enabled = True
    End Sub

    Sub tampilUser()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from tbl_user", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_user")
        dg_user.DataSource = DS.Tables("tbl_user")
        DA.Dispose()
    End Sub

    Sub aturDGV()
        Try
            dg_user.Columns(0).Width = 70
            dg_user.Columns(1).Width = 130
            dg_user.Columns(2).Width = 100
            dg_user.Columns(3).Width = 150
            dg_user.Columns(4).Width = 70
            dg_user.Columns(5).Width = 100
            dg_user.Columns(6).Width = 100
            dg_user.Columns(0).HeaderText = "ID USER"
            dg_user.Columns(1).HeaderText = "TIPE USER"
            dg_user.Columns(2).HeaderText = "NAMA"
            dg_user.Columns(3).HeaderText = "ALAMAT"
            dg_user.Columns(4).HeaderText = "TELEPON"
            dg_user.Columns(5).HeaderText = "USERNAME"
            dg_user.Columns(6).HeaderText = "PASSWORD"
        Catch ex As Exception
        End Try
    End Sub

    Sub updateUser()
        Try
            Call koneksi()
            Dim str As String
            str = "update tbl_user set Tipe_User ='" & tipe.Text & "',Nama_User ='" & nama.Text & "', Username ='" & username.Text & "', Password ='" & password.Text & "', Alamat ='" & alamat.Text & "', Telpon ='" & telepon.Text & "' where id_user ='" & id.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update data user berhasil dilakukan!")
            Call kosong()
            Call tampilUser()
            Call tambahtrue()
            Call editfalse()
        Catch ex As Exception
            MessageBox.Show("Update data user gagal dilakukan!")
        End Try
    End Sub

    Sub hapusUser()
        Try
            Call koneksi()
            Dim HapusData As String = "delete from tbl_user where Nama_User= '" & nama.Text & "'"
            CMD = New MySqlCommand(HapusData, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            Call kosong()
            Call tampilUser()
            Call tambahtrue()
            Call editfalse()
        Catch ex As Exception
            MessageBox.Show("Data User Gagal Dihapus.")
        End Try
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call updateUser()
        Call aturDGV()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Call hapusUser()
        Call aturDGV()
        Call tambahtrue()
        Call editfalse()
    End Sub

    Private Sub dg_user_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_user.CellMouseClick
        id.Text = dg_user.Rows(e.RowIndex).Cells(0).Value
        tipe.Text = dg_user.Rows(e.RowIndex).Cells(1).Value
        nama.Text = dg_user.Rows(e.RowIndex).Cells(2).Value
        alamat.Text = dg_user.Rows(e.RowIndex).Cells(3).Value
        telepon.Text = dg_user.Rows(e.RowIndex).Cells(4).Value
        username.Text = dg_user.Rows(e.RowIndex).Cells(5).Value
        password.Text = dg_user.Rows(e.RowIndex).Cells(6).Value
        Call tambahfalse()
        Call edittrue()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call koneksi()
        Dim InputData As String = "insert into tbl_user (Tipe_User, Nama_User, Alamat, Telpon, Username, Password) values ('" & tipe.Text & "', '" & nama.Text & "', '" & alamat.Text & "', '" & telepon.Text & "', '" & username.Text & "', '" & password.Text & "')"
        CMD = New MySqlCommand(InputData, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Input Data Berhasil")
        Call kosong()
        Call tampilUser()
    End Sub

    Sub kosong()
        tipe.Text = ""
        nama.Text = ""
        alamat.Text = ""
        telepon.Text = ""
        username.Text = ""
        password.Text = ""
    End Sub

    Private Sub kelolalog_Click(sender As Object, e As EventArgs) Handles kelolalog.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub kelolaobat_Click(sender As Object, e As EventArgs) Handles kelolaobat.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub kelolalaporan_Click(sender As Object, e As EventArgs) Handles kelolalaporan.Click
        Me.Hide()
        Form5.Show()
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
        Dim pesan As String
        pesan = MsgBox("Anda yakin ingin logout?", vbYesNo + vbQuestion, "Logout")
        If pesan = vbYes Then
            Call insertlogout()
            Me.Hide()
            Form1.Visible = True
            Form1.username.Focus()
        End If
    End Sub

    Sub carinama()
        Try
            Call koneksi()
            DA = New MySqlDataAdapter("select * from tbl_user where Nama_User like '%" & cari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            dg_user.DataSource = DS.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cari.KeyPress
        Call carinama()
    End Sub

End Class