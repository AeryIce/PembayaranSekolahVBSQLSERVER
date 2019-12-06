<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.WaliKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Labelaplikasipembayaran = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(954, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'MasterToolStripMenuItem
		'
		Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.SiswaToolStripMenuItem, Me.GuruToolStripMenuItem, Me.WaliKelasToolStripMenuItem})
		Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
		Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
		Me.MasterToolStripMenuItem.Text = "Master"
		'
		'UserToolStripMenuItem
		'
		Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
		Me.UserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.UserToolStripMenuItem.Text = "User"
		'
		'SiswaToolStripMenuItem
		'
		Me.SiswaToolStripMenuItem.Name = "SiswaToolStripMenuItem"
		Me.SiswaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.SiswaToolStripMenuItem.Text = "Siswa"
		'
		'GuruToolStripMenuItem
		'
		Me.GuruToolStripMenuItem.Name = "GuruToolStripMenuItem"
		Me.GuruToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.GuruToolStripMenuItem.Text = "Guru"
		'
		'WaliKelasToolStripMenuItem
		'
		Me.WaliKelasToolStripMenuItem.Name = "WaliKelasToolStripMenuItem"
		Me.WaliKelasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.WaliKelasToolStripMenuItem.Text = "Wali Kelas"
		'
		'TransaksiToolStripMenuItem
		'
		Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
		Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.TransaksiToolStripMenuItem.Text = "Transaksi"
		'
		'LaporanToolStripMenuItem
		'
		Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
		Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
		Me.LaporanToolStripMenuItem.Text = "Laporan"
		'
		'KeluarToolStripMenuItem
		'
		Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.KeluarToolStripMenuItem.Text = "Keluar"
		'
		'Labelaplikasipembayaran
		'
		Me.Labelaplikasipembayaran.AutoSize = True
		Me.Labelaplikasipembayaran.BackColor = System.Drawing.Color.Transparent
		Me.Labelaplikasipembayaran.Font = New System.Drawing.Font("Sylfaen", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Labelaplikasipembayaran.Location = New System.Drawing.Point(331, 43)
		Me.Labelaplikasipembayaran.Name = "Labelaplikasipembayaran"
		Me.Labelaplikasipembayaran.Size = New System.Drawing.Size(282, 39)
		Me.Labelaplikasipembayaran.TabIndex = 1
		Me.Labelaplikasipembayaran.Text = "Aplikasi Pembayaran "
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(338, 135)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(259, 248)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'FormHomePS
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.ClientSize = New System.Drawing.Size(954, 449)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Labelaplikasipembayaran)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Name = "FormHomePS"
		Me.Text = "FormHomePS"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SiswaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GuruToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WaliKelasToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Labelaplikasipembayaran As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
