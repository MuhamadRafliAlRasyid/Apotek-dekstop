Imports MySql.Data.MySqlClient

Public Class Form5

    Private Sub kelolalalog_Click(sender As Object, e As EventArgs) Handles kelolalalog.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub kelolauser_Click(sender As Object, e As EventArgs) Handles kelolauser.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub kelolaobat_Click(sender As Object, e As EventArgs) Handles kelolaobat.Click
        Me.Hide()
        Form4.Show()
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

    Private Sub daritgl_ValueChanged(sender As Object, e As EventArgs) Handles daritgl.ValueChanged
        daritgl.Format = DateTimePickerFormat.Custom
        daritgl.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub sampaitgl_ValueChanged(sender As Object, e As EventArgs) Handles sampaitgl.ValueChanged
        sampaitgl.Format = DateTimePickerFormat.Custom
        sampaitgl.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilLaporan()
        Call aturDgv()
    End Sub

    Sub tampilLaporan()
        Call koneksi()
        DA = New MySqlDataAdapter("select tgl_transaksi, total_transaksi from tbl_transaksi", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_transaksi")
        dg_laporan.DataSource = DS.Tables("tbl_transaksi")
        DA.Dispose()
    End Sub

    Sub aturDgv()
        dg_laporan.Columns(0).Width = 200
        dg_laporan.Columns(1).Width = 200
        dg_laporan.Columns(0).HeaderText = "TANGGAL TRANSAKSI"
        dg_laporan.Columns(1).HeaderText = "TOTAL BAYAR"
    End Sub

    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        Call chartJB()
    End Sub

    Sub chartJB()
        koneksi()
        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT SUM(total_transaksi) as penjualan, Month(tgl_transaksi) as bulan from tbl_transaksi where Year(tgl_transaksi)=Year(Now()) group by Month(tgl_transaksi)"
        RD = CMD.ExecuteReader()
        While RD.Read()
            Chart1().Series("Omset").Points.AddXY(RD.Item("bulan"), RD.Item("penjualan"))
        End While
        RD.Close()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        koneksi()
        CMD = New MySqlCommand("SELECT tgl_transaksi, total_transaksi FROM tbl_transaksi WHERE tgl_transaksi BETWEEN '" & daritgl.Value.ToString("yyyy-MM-dd") & "' AND '" & sampaitgl.Value.ToString("yyyy-MM-dd") & "'", CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "tbl_transaksi")
        dg_laporan.DataSource = DS.Tables("tbl_transaksi")
        DA.Dispose()
        RD.Close()
    End Sub

End Class