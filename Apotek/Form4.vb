Imports MySql.Data.MySqlClient

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilObat()
        Call aturDgv()
    End Sub

    Sub tampilObat()
        Call koneksi()
        DA = New MySqlDataAdapter("select * from tbl_obat", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_obat")
        dg_obat.DataSource = DS.Tables("tbl_obat")
        DA.Dispose()
    End Sub

    Sub aturDgv()
        dg_obat.Columns(0).Width = 70
        dg_obat.Columns(1).Width = 130
        dg_obat.Columns(2).Width = 100
        dg_obat.Columns(3).Width = 200
        dg_obat.Columns(4).Width = 70
        dg_obat.Columns(5).Width = 100
        dg_obat.Columns(0).HeaderText = "Id Obat"
        dg_obat.Columns(1).HeaderText = "Kode Obat"
        dg_obat.Columns(2).HeaderText = "Nama Obat"
        dg_obat.Columns(3).HeaderText = "Expired Date"
        dg_obat.Columns(4).HeaderText = "Jumlah"
        dg_obat.Columns(5).HeaderText = "Harga"
    End Sub

    Sub kosong()
        kode.Text = ""
        nama.Text = ""
        expired.Text = ""
        jumlah.Text = ""
        harga.Text = ""
    End Sub

    Sub hapusObat()
        Try
            Call koneksi()
            Dim HapusObat As String = "delete from tbl_obat where Kode_Obat= '" & kode.Text & "'"
            CMD = New MySqlCommand(HapusObat, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Obat Berhasil Dihapus.")
            Call kosong()
            Call tampilObat()
        Catch ex As Exception
            MessageBox.Show("Data Obat Gagal Dihapus.")
        End Try
    End Sub

    Sub updateObat()
        Try
            Call koneksi()
            Dim UpdateObat As String = "update tbl_obat set Kode_Obat ='" & kode.Text & "', Nama_Obat ='" & nama.Text & "', Expired_Date ='" & expired.Value.ToString("yyyy-MM-dd") & "', Jumlah ='" & jumlah.Text & "', Harga ='" & harga.Text & "' where Id_Obat='" & id.Text & "'"
            CMD = New MySqlCommand(UpdateObat, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update data obat berhasil dilakukan!")
            Call kosong()
            Call tampilObat()
        Catch ex As Exception
            MessageBox.Show("Update data obat gagal dilakukan!")
        End Try
    End Sub

    Private Sub kelolalog_Click(sender As Object, e As EventArgs) Handles kelolalog.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub kelolauser_Click(sender As Object, e As EventArgs) Handles kelolauser.Click
        Me.Hide()
        Form3.Show()
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

    Private Sub dg_obat_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_obat.CellMouseClick
        id.Text = dg_obat.Rows(e.RowIndex).Cells(0).Value
        kode.Text = dg_obat.Rows(e.RowIndex).Cells(1).Value
        nama.Text = dg_obat.Rows(e.RowIndex).Cells(2).Value
        expired.Text = dg_obat.Rows(e.RowIndex).Cells(3).Value
        jumlah.Text = dg_obat.Rows(e.RowIndex).Cells(4).Value
        harga.Text = dg_obat.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Call koneksi()
        Dim InputObat As String = "insert into tbl_obat (Kode_Obat, Nama_Obat, Expired_Date, Jumlah, Harga) values ('" & kode.Text & "', '" & nama.Text & "', '" & expired.Value.ToString("yyyy-MM-dd") & "', '" & jumlah.Text & "', '" & harga.Text & "')"
        CMD = New MySqlCommand(InputObat, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Input Data Berhasil")
        Call kosong()
        Call tampilObat()
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call hapusObat()
        Call aturDgv()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call updateObat()
        Call aturDgv()
    End Sub

    Private Sub expired_ValueChanged(sender As Object, e As EventArgs) Handles expired.ValueChanged
        expired.Format = DateTimePickerFormat.Custom
        expired.CustomFormat = "dd/MM/yyyy"
    End Sub

    Sub carinama()
        Try
            Call koneksi()
            DA = New MySqlDataAdapter("select * from tbl_obat where Nama_obat like '%" & cari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            dg_obat.DataSource = DS.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cari.KeyPress
        carinama()
    End Sub

End Class