<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.logout = New System.Windows.Forms.Button()
        Me.kelolalaporan = New System.Windows.Forms.Button()
        Me.kelolaobat = New System.Windows.Forms.Button()
        Me.kelolalog = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.telepon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.tipe = New System.Windows.Forms.ComboBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.dg_user = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.logout)
        Me.GroupBox1.Controls.Add(Me.kelolalaporan)
        Me.GroupBox1.Controls.Add(Me.kelolaobat)
        Me.GroupBox1.Controls.Add(Me.kelolalog)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, -9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 461)
        Me.GroupBox1.TabIndex = 8
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
        'kelolalaporan
        '
        Me.kelolalaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolalaporan.Location = New System.Drawing.Point(14, 361)
        Me.kelolalaporan.Name = "kelolalaporan"
        Me.kelolalaporan.Size = New System.Drawing.Size(180, 40)
        Me.kelolalaporan.TabIndex = 5
        Me.kelolalaporan.Text = "Kelola Laporan"
        Me.kelolalaporan.UseVisualStyleBackColor = True
        '
        'kelolaobat
        '
        Me.kelolaobat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaobat.Location = New System.Drawing.Point(14, 315)
        Me.kelolaobat.Name = "kelolaobat"
        Me.kelolaobat.Size = New System.Drawing.Size(180, 40)
        Me.kelolaobat.TabIndex = 5
        Me.kelolaobat.Text = "Kelola Obat"
        Me.kelolaobat.UseVisualStyleBackColor = True
        '
        'kelolalog
        '
        Me.kelolalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolalog.Location = New System.Drawing.Point(14, 269)
        Me.kelolalog.Name = "kelolalog"
        Me.kelolalog.Size = New System.Drawing.Size(180, 40)
        Me.kelolalog.TabIndex = 5
        Me.kelolalog.Text = "Kelola Activity"
        Me.kelolalog.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apotek.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(30, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(432, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kelola User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipe User"
        '
        'nama
        '
        Me.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(260, 136)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(160, 22)
        Me.nama.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Telepon"
        '
        'telepon
        '
        Me.telepon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telepon.Location = New System.Drawing.Point(260, 180)
        Me.telepon.Name = "telepon"
        Me.telepon.Size = New System.Drawing.Size(160, 22)
        Me.telepon.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(573, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(573, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Username"
        '
        'alamat
        '
        Me.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(565, 90)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(160, 22)
        Me.alamat.TabIndex = 11
        '
        'username
        '
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(565, 134)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(160, 22)
        Me.username.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(573, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Password"
        '
        'password
        '
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(565, 180)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(160, 22)
        Me.password.TabIndex = 11
        '
        'tipe
        '
        Me.tipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe.FormattingEnabled = True
        Me.tipe.Items.AddRange(New Object() {"Admin", "Apoteker", "Kasir"})
        Me.tipe.Location = New System.Drawing.Point(260, 90)
        Me.tipe.Name = "tipe"
        Me.tipe.Size = New System.Drawing.Size(160, 24)
        Me.tipe.TabIndex = 12
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(252, 226)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 30)
        Me.btntambah.TabIndex = 13
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(333, 226)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 30)
        Me.btnedit.TabIndex = 13
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(414, 226)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 30)
        Me.btnhapus.TabIndex = 13
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(495, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Cari User"
        '
        'cari
        '
        Me.cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Location = New System.Drawing.Point(565, 231)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(160, 22)
        Me.cari.TabIndex = 11
        '
        'dg_user
        '
        Me.dg_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_user.Location = New System.Drawing.Point(242, 267)
        Me.dg_user.Name = "dg_user"
        Me.dg_user.Size = New System.Drawing.Size(531, 171)
        Me.dg_user.TabIndex = 14
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BackColor = System.Drawing.Color.White
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.Location = New System.Drawing.Point(207, 9)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(9, 13)
        Me.id.TabIndex = 15
        Me.id.Text = "l"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.dg_user)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.tipe)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.telepon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents kelolalaporan As Button
    Friend WithEvents kelolaobat As Button
    Friend WithEvents kelolalog As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents telepon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents alamat As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents tipe As ComboBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cari As TextBox
    Friend WithEvents dg_user As DataGridView
    Friend WithEvents logout As Button
    Friend WithEvents id As Label
End Class
