<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dg_transaksi = New System.Windows.Forms.DataGridView()
        Me.kosongkan = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.nm_obat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nmdokter = New System.Windows.Forms.TextBox()
        Me.nm_dokter = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nm_pasien = New System.Windows.Forms.TextBox()
        Me.tglresep = New System.Windows.Forms.TextBox()
        Me.nama_pasien = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.no = New System.Windows.Forms.TextBox()
        Me.tgl_resep = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        CType(Me.dg_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_transaksi
        '
        Me.dg_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_transaksi.Location = New System.Drawing.Point(241, 232)
        Me.dg_transaksi.Name = "dg_transaksi"
        Me.dg_transaksi.Size = New System.Drawing.Size(531, 109)
        Me.dg_transaksi.TabIndex = 53
        '
        'kosongkan
        '
        Me.kosongkan.Location = New System.Drawing.Point(572, 197)
        Me.kosongkan.Name = "kosongkan"
        Me.kosongkan.Size = New System.Drawing.Size(124, 29)
        Me.kosongkan.TabIndex = 52
        Me.kosongkan.Text = "Kosongkan"
        Me.kosongkan.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(315, 197)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(124, 29)
        Me.tambah.TabIndex = 51
        Me.tambah.Text = "Tambahkan"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'harga
        '
        Me.harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.Location = New System.Drawing.Point(623, 136)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(109, 22)
        Me.harga.TabIndex = 45
        '
        'nm_obat
        '
        Me.nm_obat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nm_obat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_obat.Location = New System.Drawing.Point(623, 104)
        Me.nm_obat.Name = "nm_obat"
        Me.nm_obat.Size = New System.Drawing.Size(109, 22)
        Me.nm_obat.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Harga"
        '
        'nmdokter
        '
        Me.nmdokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nmdokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmdokter.Location = New System.Drawing.Point(623, 70)
        Me.nmdokter.Name = "nmdokter"
        Me.nmdokter.Size = New System.Drawing.Size(109, 22)
        Me.nmdokter.TabIndex = 44
        '
        'nm_dokter
        '
        Me.nm_dokter.AutoSize = True
        Me.nm_dokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_dokter.Location = New System.Drawing.Point(529, 72)
        Me.nm_dokter.Name = "nm_dokter"
        Me.nm_dokter.Size = New System.Drawing.Size(88, 16)
        Me.nm_dokter.TabIndex = 42
        Me.nm_dokter.Text = "Nama Dokter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(529, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Nama Obat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(43, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 48)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "KELOLA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRANSAKSI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(58, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "KASIR"
        '
        'nm_pasien
        '
        Me.nm_pasien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nm_pasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_pasien.Location = New System.Drawing.Point(377, 136)
        Me.nm_pasien.Name = "nm_pasien"
        Me.nm_pasien.Size = New System.Drawing.Size(109, 22)
        Me.nm_pasien.TabIndex = 47
        '
        'tglresep
        '
        Me.tglresep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tglresep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglresep.Location = New System.Drawing.Point(377, 106)
        Me.tglresep.Name = "tglresep"
        Me.tglresep.Size = New System.Drawing.Size(109, 22)
        Me.tglresep.TabIndex = 48
        '
        'nama_pasien
        '
        Me.nama_pasien.AutoSize = True
        Me.nama_pasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_pasien.Location = New System.Drawing.Point(263, 142)
        Me.nama_pasien.Name = "nama_pasien"
        Me.nama_pasien.Size = New System.Drawing.Size(90, 16)
        Me.nama_pasien.TabIndex = 39
        Me.nama_pasien.Text = "Nama Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "No Resep"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Kelola Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.logout)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 483)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'logout
        '
        Me.logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.Location = New System.Drawing.Point(14, 407)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(180, 40)
        Me.logout.TabIndex = 5
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apotek.My.Resources.Resources.Kasir2
        Me.PictureBox1.Location = New System.Drawing.Point(6, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'no
        '
        Me.no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.Location = New System.Drawing.Point(377, 76)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(109, 22)
        Me.no.TabIndex = 49
        '
        'tgl_resep
        '
        Me.tgl_resep.AutoSize = True
        Me.tgl_resep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_resep.Location = New System.Drawing.Point(263, 112)
        Me.tgl_resep.Name = "tgl_resep"
        Me.tgl_resep.Size = New System.Drawing.Size(72, 16)
        Me.tgl_resep.TabIndex = 38
        Me.tgl_resep.Text = "Tgl Resep"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(620, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Kasir1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(529, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Jumlah"
        '
        'jumlah
        '
        Me.jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(623, 167)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(109, 22)
        Me.jumlah.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LawnGreen
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "TtlHarga"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(677, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 55
        '
        'btnbayar
        '
        Me.btnbayar.Location = New System.Drawing.Point(287, 374)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(75, 23)
        Me.btnbayar.TabIndex = 56
        Me.btnbayar.Text = "Bayar"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(377, 374)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(109, 22)
        Me.TextBox6.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(301, 409)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Kembali"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Chartreuse
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(374, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Kembalian"
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(623, 374)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 56
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(697, 374)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 56
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnbayar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dg_transaksi)
        Me.Controls.Add(Me.kosongkan)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.nm_obat)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nmdokter)
        Me.Controls.Add(Me.nm_dokter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nm_pasien)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.tglresep)
        Me.Controls.Add(Me.nama_pasien)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tgl_resep)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.dg_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_transaksi As DataGridView
    Friend WithEvents kosongkan As Button
    Friend WithEvents tambah As Button
    Friend WithEvents harga As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nm_obat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nmdokter As TextBox
    Friend WithEvents nm_dokter As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nm_pasien As TextBox
    Friend WithEvents tglresep As TextBox
    Friend WithEvents nama_pasien As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents logout As Button
    Friend WithEvents no As TextBox
    Friend WithEvents tgl_resep As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents jumlah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnbayar As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnprint As Button
    Friend WithEvents btnsave As Button
End Class
