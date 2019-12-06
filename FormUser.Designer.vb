<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ButtonCari = New System.Windows.Forms.Button()
		Me.TextBoxStatusUser = New System.Windows.Forms.TextBox()
		Me.TextBoxPasswordUser = New System.Windows.Forms.TextBox()
		Me.TextBoxNamaUser = New System.Windows.Forms.TextBox()
		Me.TextBoxKodeUser = New System.Windows.Forms.TextBox()
		Me.LabelStatusUser = New System.Windows.Forms.Label()
		Me.LabelPasswordUser = New System.Windows.Forms.Label()
		Me.LabelNamaUser = New System.Windows.Forms.Label()
		Me.LabelKodeUser = New System.Windows.Forms.Label()
		Me.GroupBoxCrudData = New System.Windows.Forms.GroupBox()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonDelete = New System.Windows.Forms.Button()
		Me.ButtonUpdate = New System.Windows.Forms.Button()
		Me.ButtonInput = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.DGVUser = New System.Windows.Forms.DataGridView()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBoxCrudData.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ButtonCari)
		Me.GroupBox1.Controls.Add(Me.TextBoxStatusUser)
		Me.GroupBox1.Controls.Add(Me.TextBoxPasswordUser)
		Me.GroupBox1.Controls.Add(Me.TextBoxNamaUser)
		Me.GroupBox1.Controls.Add(Me.TextBoxKodeUser)
		Me.GroupBox1.Controls.Add(Me.LabelStatusUser)
		Me.GroupBox1.Controls.Add(Me.LabelPasswordUser)
		Me.GroupBox1.Controls.Add(Me.LabelNamaUser)
		Me.GroupBox1.Controls.Add(Me.LabelKodeUser)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(753, 144)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "User"
		'
		'ButtonCari
		'
		Me.ButtonCari.Image = CType(resources.GetObject("ButtonCari.Image"), System.Drawing.Image)
		Me.ButtonCari.Location = New System.Drawing.Point(432, 23)
		Me.ButtonCari.Name = "ButtonCari"
		Me.ButtonCari.Size = New System.Drawing.Size(143, 98)
		Me.ButtonCari.TabIndex = 8
		Me.ButtonCari.UseVisualStyleBackColor = True
		'
		'TextBoxStatusUser
		'
		Me.TextBoxStatusUser.Location = New System.Drawing.Point(105, 101)
		Me.TextBoxStatusUser.Name = "TextBoxStatusUser"
		Me.TextBoxStatusUser.Size = New System.Drawing.Size(294, 20)
		Me.TextBoxStatusUser.TabIndex = 7
		'
		'TextBoxPasswordUser
		'
		Me.TextBoxPasswordUser.Location = New System.Drawing.Point(106, 77)
		Me.TextBoxPasswordUser.Name = "TextBoxPasswordUser"
		Me.TextBoxPasswordUser.Size = New System.Drawing.Size(294, 20)
		Me.TextBoxPasswordUser.TabIndex = 6
		'
		'TextBoxNamaUser
		'
		Me.TextBoxNamaUser.Location = New System.Drawing.Point(106, 51)
		Me.TextBoxNamaUser.Name = "TextBoxNamaUser"
		Me.TextBoxNamaUser.Size = New System.Drawing.Size(294, 20)
		Me.TextBoxNamaUser.TabIndex = 5
		'
		'TextBoxKodeUser
		'
		Me.TextBoxKodeUser.Location = New System.Drawing.Point(106, 25)
		Me.TextBoxKodeUser.Name = "TextBoxKodeUser"
		Me.TextBoxKodeUser.Size = New System.Drawing.Size(294, 20)
		Me.TextBoxKodeUser.TabIndex = 4
		'
		'LabelStatusUser
		'
		Me.LabelStatusUser.AutoSize = True
		Me.LabelStatusUser.Location = New System.Drawing.Point(16, 104)
		Me.LabelStatusUser.Name = "LabelStatusUser"
		Me.LabelStatusUser.Size = New System.Drawing.Size(83, 13)
		Me.LabelStatusUser.TabIndex = 3
		Me.LabelStatusUser.Text = "Status User      :"
		'
		'LabelPasswordUser
		'
		Me.LabelPasswordUser.AutoSize = True
		Me.LabelPasswordUser.Location = New System.Drawing.Point(16, 79)
		Me.LabelPasswordUser.Name = "LabelPasswordUser"
		Me.LabelPasswordUser.Size = New System.Drawing.Size(84, 13)
		Me.LabelPasswordUser.TabIndex = 2
		Me.LabelPasswordUser.Text = "Password User :"
		'
		'LabelNamaUser
		'
		Me.LabelNamaUser.AutoSize = True
		Me.LabelNamaUser.Location = New System.Drawing.Point(16, 53)
		Me.LabelNamaUser.Name = "LabelNamaUser"
		Me.LabelNamaUser.Size = New System.Drawing.Size(84, 13)
		Me.LabelNamaUser.TabIndex = 1
		Me.LabelNamaUser.Text = "Nama User       :"
		'
		'LabelKodeUser
		'
		Me.LabelKodeUser.AutoSize = True
		Me.LabelKodeUser.Location = New System.Drawing.Point(16, 28)
		Me.LabelKodeUser.Name = "LabelKodeUser"
		Me.LabelKodeUser.Size = New System.Drawing.Size(84, 13)
		Me.LabelKodeUser.TabIndex = 0
		Me.LabelKodeUser.Text = "Kode User        :"
		'
		'GroupBoxCrudData
		'
		Me.GroupBoxCrudData.Controls.Add(Me.ButtonCancel)
		Me.GroupBoxCrudData.Controls.Add(Me.ButtonExit)
		Me.GroupBoxCrudData.Controls.Add(Me.ButtonDelete)
		Me.GroupBoxCrudData.Controls.Add(Me.ButtonUpdate)
		Me.GroupBoxCrudData.Controls.Add(Me.ButtonInput)
		Me.GroupBoxCrudData.Location = New System.Drawing.Point(12, 162)
		Me.GroupBoxCrudData.Name = "GroupBoxCrudData"
		Me.GroupBoxCrudData.Size = New System.Drawing.Size(753, 80)
		Me.GroupBoxCrudData.TabIndex = 1
		Me.GroupBoxCrudData.TabStop = False
		Me.GroupBoxCrudData.Text = " CRUD DATA"
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
		Me.ButtonCancel.Location = New System.Drawing.Point(432, 10)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(58, 55)
		Me.ButtonCancel.TabIndex = 13
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Image = CType(resources.GetObject("ButtonExit.Image"), System.Drawing.Image)
		Me.ButtonExit.Location = New System.Drawing.Point(517, 10)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(58, 55)
		Me.ButtonExit.TabIndex = 12
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonDelete
		'
		Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
		Me.ButtonDelete.Location = New System.Drawing.Point(320, 10)
		Me.ButtonDelete.Name = "ButtonDelete"
		Me.ButtonDelete.Size = New System.Drawing.Size(79, 55)
		Me.ButtonDelete.TabIndex = 11
		Me.ButtonDelete.UseVisualStyleBackColor = True
		'
		'ButtonUpdate
		'
		Me.ButtonUpdate.Image = CType(resources.GetObject("ButtonUpdate.Image"), System.Drawing.Image)
		Me.ButtonUpdate.Location = New System.Drawing.Point(210, 10)
		Me.ButtonUpdate.Name = "ButtonUpdate"
		Me.ButtonUpdate.Size = New System.Drawing.Size(86, 55)
		Me.ButtonUpdate.TabIndex = 10
		Me.ButtonUpdate.UseVisualStyleBackColor = True
		'
		'ButtonInput
		'
		Me.ButtonInput.Image = CType(resources.GetObject("ButtonInput.Image"), System.Drawing.Image)
		Me.ButtonInput.Location = New System.Drawing.Point(106, 10)
		Me.ButtonInput.Name = "ButtonInput"
		Me.ButtonInput.Size = New System.Drawing.Size(84, 55)
		Me.ButtonInput.TabIndex = 9
		Me.ButtonInput.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.DGVUser)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 248)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(753, 190)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Data User"
		'
		'DGVUser
		'
		Me.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVUser.Location = New System.Drawing.Point(106, 19)
		Me.DGVUser.Name = "DGVUser"
		Me.DGVUser.Size = New System.Drawing.Size(469, 144)
		Me.DGVUser.TabIndex = 0
		'
		'FormUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBoxCrudData)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FormUser"
		Me.Text = "FormUser"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBoxCrudData.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents ButtonInput As Button
	Friend WithEvents ButtonCari As Button
	Friend WithEvents TextBoxStatusUser As TextBox
	Friend WithEvents TextBoxPasswordUser As TextBox
	Friend WithEvents TextBoxNamaUser As TextBox
	Friend WithEvents TextBoxKodeUser As TextBox
	Friend WithEvents LabelStatusUser As Label
	Friend WithEvents LabelPasswordUser As Label
	Friend WithEvents LabelNamaUser As Label
	Friend WithEvents LabelKodeUser As Label
	Friend WithEvents GroupBoxCrudData As GroupBox
	Friend WithEvents ButtonUpdate As Button
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonDelete As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents DGVUser As DataGridView
End Class
