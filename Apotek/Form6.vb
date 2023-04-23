Imports MySql.Data.MySqlClient

Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilResep()
        Call aturDGV()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Try
            Call koneksi()
            Dim edit As String = "update tbl_resep set tgl_resep='" & tglresep.Value.ToString("yyyy-MM-dd") & "', Nama_Dokter ='" & nama_dokter.Text & "', Nama_ObatDiBeli ='" & nama_obat.Text & "', Jumlah_ObatDibeli='" & jumlah.Text & "' where No_Resep = '" & no.Text & "'"
            CMD = New MySqlCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update data user berhasil dilakukan!")
            Call kosong()
            Call tampilResep()
        Catch ex As Exception
            MessageBox.Show("Update data user gagal dilakukan!")
        End Try
    End Sub

    Sub kosong()
        nama_dokter.Text = ""
        nama_obat.Text = ""
        jumlah.Text = ""
        no.Text = ""
    End Sub

    Sub tampilResep()
        Call koneksi()
        DA = New MySqlDataAdapter("select * from tbl_resep", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_resep")
        dg_resep.DataSource = DS.Tables("tbl_resep")
    End Sub

    Sub aturDGV()
        Try
            dg_resep.Columns(0).Width = 70
            dg_resep.Columns(1).Width = 70
            dg_resep.Columns(2).Width = 70
            dg_resep.Columns(3).Width = 70
            dg_resep.Columns(4).Width = 70
            dg_resep.Columns(5).Width = 70
            dg_resep.Columns(6).Width = 70
            dg_resep.Columns(0).HeaderText = "ID RESEP"
            dg_resep.Columns(1).HeaderText = "NO RESEP"
            dg_resep.Columns(2).HeaderText = "TANGGAL RESEP"
            dg_resep.Columns(3).HeaderText = "NAMA DOKTER"
            dg_resep.Columns(4).HeaderText = "NAMA PASIEN"
            dg_resep.Columns(5).HeaderText = "NAMA OBAT DI BELI"
            dg_resep.Columns(6).HeaderText = "JUMLAH"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_resep_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_resep.CellMouseClick
        no.Text = dg_resep.Rows(e.RowIndex).Cells(1).Value
        tglresep.Text = dg_resep.Rows(e.RowIndex).Cells(2).Value
        nama_dokter.Text = dg_resep.Rows(e.RowIndex).Cells(3).Value
        nama_pasien.Text = dg_resep.Rows(e.RowIndex).Cells(4).Value
        nama_obat.Text = dg_resep.Rows(e.RowIndex).Cells(5).Value
        jumlah.Text = dg_resep.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            Call koneksi()
            Dim hapus As String = "delete from tbl_resep where No_resep ='" & no.Text & "'"
            CMD = New MySqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data telah berhasil dihapus!")
            Call kosong()
            Call tampilResep()
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus!")
        End Try
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