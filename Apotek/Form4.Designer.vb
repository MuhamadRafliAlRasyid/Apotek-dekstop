<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dg_obat = New System.Windows.Forms.DataGridView()
        Me.hapus = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.kode = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.kelolalaporan = New System.Windows.Forms.Button()
        Me.kelolalog = New System.Windows.Forms.Button()
        Me.kelolauser = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.expired = New System.Windows.Forms.DateTimePicker()
        Me.id = New System.Windows.Forms.Label()
        CType(Me.dg_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_obat
        '
        Me.dg_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_obat.Location = New System.Drawing.Point(232, 245)
        Me.dg_obat.Name = "dg_obat"
        Me.dg_obat.Size = New System.Drawing.Size(531, 188)
        Me.dg_obat.TabIndex = 34
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(411, 209)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 30)
        Me.hapus.TabIndex = 33
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(330, 209)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 30)
        Me.edit.TabIndex = 32
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(249, 209)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(75, 30)
        Me.tambah.TabIndex = 31
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Location = New System.Drawing.Point(562, 214)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(160, 22)
        Me.cari.TabIndex = 27
        '
        'harga
        '
        Me.harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.Location = New System.Drawing.Point(562, 129)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(160, 22)
        Me.harga.TabIndex = 26
        '
        'kode
        '
        Me.kode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode.Location = New System.Drawing.Point(257, 87)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(160, 22)
        Me.kode.TabIndex = 25
        '
        'jumlah
        '
        Me.jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(562, 85)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(160, 22)
        Me.jumlah.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(570, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Harga Per Unit"
        '
        'nama
        '
        Me.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(257, 131)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(160, 22)
        Me.nama.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Expired Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nama Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Kode Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(438, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kelola Obat"
        '
        'logout
        '
        Me.logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.Location = New System.Drawing.Point(14, 405)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(180, 40)
        Me.logout.TabIndex = 5
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'kelolalaporan
        '
        Me.kelolalaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolalaporan.Location = New System.Drawing.Point(14, 359)
        Me.kelolalaporan.Name = "kelolalaporan"
        Me.kelolalaporan.Size = New System.Drawing.Size(180, 40)
        Me.kelolalaporan.TabIndex = 5
        Me.kelolalaporan.Text = "Kelola Laporan"
        Me.kelolalaporan.UseVisualStyleBackColor = True
        '
        'kelolalog
        '
        Me.kelolalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolalog.Location = New System.Drawing.Point(14, 313)
        Me.kelolalog.Name = "kelolalog"
        Me.kelolalog.Size = New System.Drawing.Size(180, 40)
        Me.kelolalog.TabIndex = 5
        Me.kelolalog.Text = "Kelola Activity"
        Me.kelolalog.UseVisualStyleBackColor = True
        '
        'kelolauser
        '
        Me.kelolauser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolauser.Location = New System.Drawing.Point(14, 267)
        Me.kelolauser.Name = "kelolauser"
        Me.kelolauser.Size = New System.Drawing.Size(180, 40)
        Me.kelolauser.TabIndex = 5
        Me.kelolauser.Text = "Kelola User"
        Me.kelolauser.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(511, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(570, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Jumlah"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.logout)
        Me.GroupBox1.Controls.Add(Me.kelolalaporan)
        Me.GroupBox1.Controls.Add(Me.kelolalog)
        Me.GroupBox1.Controls.Add(Me.kelolauser)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 473)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apotek.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(30, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'expired
        '
        Me.expired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.expired.Location = New System.Drawing.Point(257, 175)
        Me.expired.Name = "expired"
        Me.expired.Size = New System.Drawing.Size(160, 22)
        Me.expired.TabIndex = 35
        Me.expired.Value = New Date(2023, 4, 1, 0, 0, 0, 0)
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.Location = New System.Drawing.Point(207, 4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(10, 13)
        Me.id.TabIndex = 36
        Me.id.Text = "I"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.expired)
        Me.Controls.Add(Me.dg_obat)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.dg_obat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_obat As DataGridView
    Friend WithEvents hapus As Button
    Friend WithEvents edit As Button
    Friend WithEvents tambah As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cari As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents kode As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logout As Button
    Friend WithEvents kelolalaporan As Button
    Friend WithEvents kelolalog As Button
    Friend WithEvents kelolauser As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents expired As DateTimePicker
    Friend WithEvents id As Label
End Class
