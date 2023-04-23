<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.logout = New System.Windows.Forms.Button()
        Me.kelolalaporan = New System.Windows.Forms.Button()
        Me.kelolaobat = New System.Windows.Forms.Button()
        Me.kelolauser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dg_log = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.load = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log Activity"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.logout)
        Me.GroupBox1.Controls.Add(Me.kelolalaporan)
        Me.GroupBox1.Controls.Add(Me.kelolaobat)
        Me.GroupBox1.Controls.Add(Me.kelolauser)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 474)
        Me.GroupBox1.TabIndex = 2
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
        'kelolauser
        '
        Me.kelolauser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolauser.Location = New System.Drawing.Point(14, 269)
        Me.kelolauser.Name = "kelolauser"
        Me.kelolauser.Size = New System.Drawing.Size(180, 40)
        Me.kelolauser.TabIndex = 5
        Me.kelolauser.Text = "Kelola User"
        Me.kelolauser.UseVisualStyleBackColor = True
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
        'dg_log
        '
        Me.dg_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_log.Location = New System.Drawing.Point(236, 53)
        Me.dg_log.Name = "dg_log"
        Me.dg_log.Size = New System.Drawing.Size(540, 326)
        Me.dg_log.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tampilan Per"
        '
        'dtp
        '
        Me.dtp.Checked = False
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(340, 390)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 22)
        Me.dtp.TabIndex = 4
        '
        'load
        '
        Me.load.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.load.Location = New System.Drawing.Point(626, 389)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(85, 25)
        Me.load.TabIndex = 5
        Me.load.Text = "Load"
        Me.load.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.load)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.dg_log)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents logout As Button
    Friend WithEvents kelolalaporan As Button
    Friend WithEvents kelolaobat As Button
    Friend WithEvents kelolauser As Button
    Friend WithEvents dg_log As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents load As Button
End Class
