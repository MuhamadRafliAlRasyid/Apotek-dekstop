<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.dg_resep = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.logout = New System.Windows.Forms.Button()
        Me.nama_obat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nama_dokter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.TextBox()
        Me.nama_pasien = New System.Windows.Forms.TextBox()
        Me.tglresep = New System.Windows.Forms.DateTimePicker()
        CType(Me.dg_resep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_resep
        '
        Me.dg_resep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_resep.Location = New System.Drawing.Point(239, 265)
        Me.dg_resep.Name = "dg_resep"
        Me.dg_resep.Size = New System.Drawing.Size(531, 171)
        Me.dg_resep.TabIndex = 34
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(377, 224)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 30)
        Me.btnhapus.TabIndex = 33
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(267, 224)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 30)
        Me.edit.TabIndex = 32
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Location = New System.Drawing.Point(572, 229)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(160, 22)
        Me.cari.TabIndex = 27
        '
        'jumlah
        '
        Me.jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(623, 178)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(109, 22)
        Me.jumlah.TabIndex = 26
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
        'nama_obat
        '
        Me.nama_obat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nama_obat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_obat.Location = New System.Drawing.Point(623, 132)
        Me.nama_obat.Name = "nama_obat"
        Me.nama_obat.Size = New System.Drawing.Size(109, 22)
        Me.nama_obat.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Jumlah"
        '
        'nama_dokter
        '
        Me.nama_dokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nama_dokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_dokter.Location = New System.Drawing.Point(623, 90)
        Me.nama_dokter.Name = "nama_dokter"
        Me.nama_dokter.Size = New System.Drawing.Size(109, 22)
        Me.nama_dokter.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Nama Dokter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(529, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nama Obat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(520, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tgl Resep"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nama Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "No Resep"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kelola Resep"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.logout)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 471)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Apotek.My.Resources.Resources.apoteker
        Me.PictureBox1.Location = New System.Drawing.Point(34, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(56, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 48)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "KELOLA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESEP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(46, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "APOTEKER"
        '
        'no
        '
        Me.no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.Location = New System.Drawing.Point(377, 92)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(109, 22)
        Me.no.TabIndex = 28
        '
        'nama_pasien
        '
        Me.nama_pasien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nama_pasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_pasien.Location = New System.Drawing.Point(377, 178)
        Me.nama_pasien.Name = "nama_pasien"
        Me.nama_pasien.Size = New System.Drawing.Size(109, 22)
        Me.nama_pasien.TabIndex = 28
        '
        'tglresep
        '
        Me.tglresep.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglresep.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglresep.Location = New System.Drawing.Point(377, 138)
        Me.tglresep.Name = "tglresep"
        Me.tglresep.Size = New System.Drawing.Size(109, 20)
        Me.tglresep.TabIndex = 35
        Me.tglresep.Value = New Date(2023, 4, 5, 0, 0, 0, 0)
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tglresep)
        Me.Controls.Add(Me.dg_resep)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.nama_obat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nama_dokter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nama_pasien)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.dg_resep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_resep As DataGridView
    Friend WithEvents btnhapus As Button
    Friend WithEvents edit As Button
    Friend WithEvents cari As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents logout As Button
    Friend WithEvents nama_obat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nama_dokter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents no As TextBox
    Friend WithEvents nama_pasien As TextBox
    Friend WithEvents tglresep As DateTimePicker
End Class
