<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dg_laporan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.kelolalalog = New System.Windows.Forms.Button()
        Me.kelolaobat = New System.Windows.Forms.Button()
        Me.kelolauser = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.daritgl = New System.Windows.Forms.DateTimePicker()
        Me.sampaitgl = New System.Windows.Forms.DateTimePicker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btngenerate = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        CType(Me.dg_laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_laporan
        '
        Me.dg_laporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_laporan.Location = New System.Drawing.Point(220, 110)
        Me.dg_laporan.Name = "dg_laporan"
        Me.dg_laporan.Size = New System.Drawing.Size(531, 120)
        Me.dg_laporan.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kelola Laporan"
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
        'kelolalalog
        '
        Me.kelolalalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolalalog.Location = New System.Drawing.Point(14, 361)
        Me.kelolalalog.Name = "kelolalalog"
        Me.kelolalalog.Size = New System.Drawing.Size(180, 40)
        Me.kelolalalog.TabIndex = 5
        Me.kelolalalog.Text = "Kelola Activity"
        Me.kelolalalog.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.logout)
        Me.GroupBox1.Controls.Add(Me.kelolalalog)
        Me.GroupBox1.Controls.Add(Me.kelolaobat)
        Me.GroupBox1.Controls.Add(Me.kelolauser)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 467)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(389, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Laporan Penjualan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(217, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Dari Tgl."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(462, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Sampai Tgl."
        '
        'daritgl
        '
        Me.daritgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daritgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.daritgl.Location = New System.Drawing.Point(294, 78)
        Me.daritgl.Name = "daritgl"
        Me.daritgl.Size = New System.Drawing.Size(85, 22)
        Me.daritgl.TabIndex = 36
        Me.daritgl.Value = New Date(2023, 4, 5, 0, 0, 0, 0)
        '
        'sampaitgl
        '
        Me.sampaitgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sampaitgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sampaitgl.Location = New System.Drawing.Point(563, 76)
        Me.sampaitgl.Name = "sampaitgl"
        Me.sampaitgl.Size = New System.Drawing.Size(85, 22)
        Me.sampaitgl.TabIndex = 36
        Me.sampaitgl.Value = New Date(2023, 4, 5, 0, 0, 0, 0)
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(236, 250)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Omset"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(441, 191)
        Me.Chart1.TabIndex = 37
        Me.Chart1.Text = "Chart1"
        '
        'btngenerate
        '
        Me.btngenerate.Location = New System.Drawing.Point(665, 326)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(86, 23)
        Me.btngenerate.TabIndex = 38
        Me.btngenerate.Text = "Generate"
        Me.btngenerate.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(665, 76)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(86, 24)
        Me.btnload.TabIndex = 39
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btngenerate)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.sampaitgl)
        Me.Controls.Add(Me.daritgl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg_laporan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.dg_laporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_laporan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents logout As Button
    Friend WithEvents kelolalalog As Button
    Friend WithEvents kelolaobat As Button
    Friend WithEvents kelolauser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents daritgl As DateTimePicker
    Friend WithEvents sampaitgl As DateTimePicker
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btngenerate As Button
    Friend WithEvents btnload As Button
End Class
