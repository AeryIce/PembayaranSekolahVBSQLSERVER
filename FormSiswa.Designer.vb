<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiswa
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSiswa))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TextBoxTempoPertama = New System.Windows.Forms.TextBox()
		Me.LabelTempoPertama = New System.Windows.Forms.Label()
		Me.TextBoxBiaya = New System.Windows.Forms.TextBox()
		Me.LabelBiaya = New System.Windows.Forms.Label()
		Me.TextBoxTahunAjaran = New System.Windows.Forms.TextBox()
		Me.TextBoxKelasSiswa = New System.Windows.Forms.TextBox()
		Me.TextBoxNamaSiswa = New System.Windows.Forms.TextBox()
		Me.TextBoxNIS = New System.Windows.Forms.TextBox()
		Me.LabelTahunAjaran = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.ButtonCari = New System.Windows.Forms.Button()
		Me.TextBoxCariNIS = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonHapus = New System.Windows.Forms.Button()
		Me.ButtonUpdate = New System.Windows.Forms.Button()
		Me.ButtonInput = New System.Windows.Forms.Button()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.DGVSiswa = New System.Windows.Forms.DataGridView()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.DGVSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TextBoxTempoPertama)
		Me.GroupBox1.Controls.Add(Me.LabelTempoPertama)
		Me.GroupBox1.Controls.Add(Me.TextBoxBiaya)
		Me.GroupBox1.Controls.Add(Me.LabelBiaya)
		Me.GroupBox1.Controls.Add(Me.TextBoxTahunAjaran)
		Me.GroupBox1.Controls.Add(Me.TextBoxKelasSiswa)
		Me.GroupBox1.Controls.Add(Me.TextBoxNamaSiswa)
		Me.GroupBox1.Controls.Add(Me.TextBoxNIS)
		Me.GroupBox1.Controls.Add(Me.LabelTahunAjaran)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(464, 169)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Siswa"
		'
		'TextBoxTempoPertama
		'
		Me.TextBoxTempoPertama.Location = New System.Drawing.Point(328, 114)
		Me.TextBoxTempoPertama.Name = "TextBoxTempoPertama"
		Me.TextBoxTempoPertama.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxTempoPertama.TabIndex = 11
		'
		'LabelTempoPertama
		'
		Me.LabelTempoPertama.AutoSize = True
		Me.LabelTempoPertama.Location = New System.Drawing.Point(240, 121)
		Me.LabelTempoPertama.Name = "LabelTempoPertama"
		Me.LabelTempoPertama.Size = New System.Drawing.Size(82, 13)
		Me.LabelTempoPertama.TabIndex = 10
		Me.LabelTempoPertama.Text = "Tempo Pertama"
		'
		'TextBoxBiaya
		'
		Me.TextBoxBiaya.Location = New System.Drawing.Point(326, 84)
		Me.TextBoxBiaya.Name = "TextBoxBiaya"
		Me.TextBoxBiaya.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxBiaya.TabIndex = 9
		'
		'LabelBiaya
		'
		Me.LabelBiaya.AutoSize = True
		Me.LabelBiaya.Location = New System.Drawing.Point(240, 88)
		Me.LabelBiaya.Name = "LabelBiaya"
		Me.LabelBiaya.Size = New System.Drawing.Size(33, 13)
		Me.LabelBiaya.TabIndex = 8
		Me.LabelBiaya.Text = "Biaya"
		'
		'TextBoxTahunAjaran
		'
		Me.TextBoxTahunAjaran.Location = New System.Drawing.Point(80, 118)
		Me.TextBoxTahunAjaran.Name = "TextBoxTahunAjaran"
		Me.TextBoxTahunAjaran.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxTahunAjaran.TabIndex = 7
		'
		'TextBoxKelasSiswa
		'
		Me.TextBoxKelasSiswa.Location = New System.Drawing.Point(80, 81)
		Me.TextBoxKelasSiswa.Name = "TextBoxKelasSiswa"
		Me.TextBoxKelasSiswa.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxKelasSiswa.TabIndex = 6
		'
		'TextBoxNamaSiswa
		'
		Me.TextBoxNamaSiswa.Location = New System.Drawing.Point(80, 48)
		Me.TextBoxNamaSiswa.Name = "TextBoxNamaSiswa"
		Me.TextBoxNamaSiswa.Size = New System.Drawing.Size(242, 20)
		Me.TextBoxNamaSiswa.TabIndex = 5
		'
		'TextBoxNIS
		'
		Me.TextBoxNIS.Location = New System.Drawing.Point(80, 19)
		Me.TextBoxNIS.Name = "TextBoxNIS"
		Me.TextBoxNIS.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxNIS.TabIndex = 4
		'
		'LabelTahunAjaran
		'
		Me.LabelTahunAjaran.AutoSize = True
		Me.LabelTahunAjaran.Location = New System.Drawing.Point(6, 121)
		Me.LabelTahunAjaran.Name = "LabelTahunAjaran"
		Me.LabelTahunAjaran.Size = New System.Drawing.Size(71, 13)
		Me.LabelTahunAjaran.TabIndex = 3
		Me.LabelTahunAjaran.Text = "Tahun Ajaran"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(6, 84)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Kelas Siswa"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 55)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nama Siswa"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(25, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "NIS"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.ButtonCari)
		Me.GroupBox2.Controls.Add(Me.TextBoxCariNIS)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Location = New System.Drawing.Point(494, 5)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(294, 165)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Cari Data"
		'
		'ButtonCari
		'
		Me.ButtonCari.Image = CType(resources.GetObject("ButtonCari.Image"), System.Drawing.Image)
		Me.ButtonCari.Location = New System.Drawing.Point(86, 51)
		Me.ButtonCari.Name = "ButtonCari"
		Me.ButtonCari.Size = New System.Drawing.Size(100, 66)
		Me.ButtonCari.TabIndex = 13
		Me.ButtonCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ButtonCari.UseVisualStyleBackColor = True
		'
		'TextBoxCariNIS
		'
		Me.TextBoxCariNIS.Location = New System.Drawing.Point(86, 19)
		Me.TextBoxCariNIS.Name = "TextBoxCariNIS"
		Me.TextBoxCariNIS.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxCariNIS.TabIndex = 12
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(28, 22)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(25, 13)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "NIS"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Button6)
		Me.GroupBox3.Controls.Add(Me.ButtonCancel)
		Me.GroupBox3.Controls.Add(Me.ButtonHapus)
		Me.GroupBox3.Controls.Add(Me.ButtonUpdate)
		Me.GroupBox3.Controls.Add(Me.ButtonInput)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 176)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(776, 100)
		Me.GroupBox3.TabIndex = 2
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Proses Data"
		'
		'Button6
		'
		Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
		Me.Button6.Location = New System.Drawing.Point(632, 25)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(100, 62)
		Me.Button6.TabIndex = 14
		Me.Button6.UseVisualStyleBackColor = True
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
		Me.ButtonCancel.Location = New System.Drawing.Point(503, 25)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(100, 62)
		Me.ButtonCancel.TabIndex = 14
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'ButtonHapus
		'
		Me.ButtonHapus.Image = CType(resources.GetObject("ButtonHapus.Image"), System.Drawing.Image)
		Me.ButtonHapus.Location = New System.Drawing.Point(328, 25)
		Me.ButtonHapus.Name = "ButtonHapus"
		Me.ButtonHapus.Size = New System.Drawing.Size(100, 62)
		Me.ButtonHapus.TabIndex = 14
		Me.ButtonHapus.UseVisualStyleBackColor = True
		'
		'ButtonUpdate
		'
		Me.ButtonUpdate.Image = CType(resources.GetObject("ButtonUpdate.Image"), System.Drawing.Image)
		Me.ButtonUpdate.Location = New System.Drawing.Point(206, 25)
		Me.ButtonUpdate.Name = "ButtonUpdate"
		Me.ButtonUpdate.Size = New System.Drawing.Size(100, 62)
		Me.ButtonUpdate.TabIndex = 14
		Me.ButtonUpdate.UseVisualStyleBackColor = True
		'
		'ButtonInput
		'
		Me.ButtonInput.Image = CType(resources.GetObject("ButtonInput.Image"), System.Drawing.Image)
		Me.ButtonInput.Location = New System.Drawing.Point(80, 25)
		Me.ButtonInput.Name = "ButtonInput"
		Me.ButtonInput.Size = New System.Drawing.Size(100, 62)
		Me.ButtonInput.TabIndex = 14
		Me.ButtonInput.UseVisualStyleBackColor = True
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.DGVSiswa)
		Me.GroupBox4.Location = New System.Drawing.Point(12, 282)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(776, 156)
		Me.GroupBox4.TabIndex = 3
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Data Siswa"
		'
		'DGVSiswa
		'
		Me.DGVSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVSiswa.Location = New System.Drawing.Point(82, 19)
		Me.DGVSiswa.Name = "DGVSiswa"
		Me.DGVSiswa.Size = New System.Drawing.Size(650, 124)
		Me.DGVSiswa.TabIndex = 0
		'
		'FormSiswa
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FormSiswa"
		Me.Text = "FormSiswa"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		CType(Me.DGVSiswa, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents LabelTahunAjaran As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBoxTempoPertama As TextBox
	Friend WithEvents LabelTempoPertama As Label
	Friend WithEvents TextBoxBiaya As TextBox
	Friend WithEvents LabelBiaya As Label
	Friend WithEvents TextBoxTahunAjaran As TextBox
	Friend WithEvents TextBoxKelasSiswa As TextBox
	Friend WithEvents TextBoxNamaSiswa As TextBox
	Friend WithEvents TextBoxNIS As TextBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents ButtonCari As Button
	Friend WithEvents TextBoxCariNIS As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Button6 As Button
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents ButtonHapus As Button
	Friend WithEvents ButtonUpdate As Button
	Friend WithEvents ButtonInput As Button
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents DGVSiswa As DataGridView
End Class
