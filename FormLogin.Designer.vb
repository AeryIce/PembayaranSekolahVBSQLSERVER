<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.TextBoxPassword = New System.Windows.Forms.TextBox()
		Me.TextBoxUsername = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label_Username = New System.Windows.Forms.Label()
		Me.Label_StatusDb = New System.Windows.Forms.Label()
		Me.Label_ConfirmDb = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ButtonCancel)
		Me.GroupBox1.Controls.Add(Me.ButtonLogin)
		Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
		Me.GroupBox1.Controls.Add(Me.TextBoxUsername)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label_Username)
		Me.GroupBox1.Location = New System.Drawing.Point(268, 92)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(254, 167)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Login Admin"
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Location = New System.Drawing.Point(162, 94)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCancel.TabIndex = 5
		Me.ButtonCancel.Text = "Cancel"
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'ButtonLogin
		'
		Me.ButtonLogin.Location = New System.Drawing.Point(9, 94)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(87, 23)
		Me.ButtonLogin.TabIndex = 4
		Me.ButtonLogin.Text = "Login"
		Me.ButtonLogin.UseVisualStyleBackColor = True
		'
		'TextBoxPassword
		'
		Me.TextBoxPassword.Location = New System.Drawing.Point(74, 56)
		Me.TextBoxPassword.Name = "TextBoxPassword"
		Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxPassword.Size = New System.Drawing.Size(114, 20)
		Me.TextBoxPassword.TabIndex = 3
		'
		'TextBoxUsername
		'
		Me.TextBoxUsername.Location = New System.Drawing.Point(74, 30)
		Me.TextBoxUsername.Name = "TextBoxUsername"
		Me.TextBoxUsername.Size = New System.Drawing.Size(114, 20)
		Me.TextBoxUsername.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 54)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(62, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Password  :"
		'
		'Label_Username
		'
		Me.Label_Username.AutoSize = True
		Me.Label_Username.Location = New System.Drawing.Point(6, 30)
		Me.Label_Username.Name = "Label_Username"
		Me.Label_Username.Size = New System.Drawing.Size(61, 13)
		Me.Label_Username.TabIndex = 0
		Me.Label_Username.Text = "Username :"
		'
		'Label_StatusDb
		'
		Me.Label_StatusDb.AutoSize = True
		Me.Label_StatusDb.Font = New System.Drawing.Font("Lucida Console", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_StatusDb.Location = New System.Drawing.Point(631, 292)
		Me.Label_StatusDb.Name = "Label_StatusDb"
		Me.Label_StatusDb.Size = New System.Drawing.Size(90, 8)
		Me.Label_StatusDb.TabIndex = 1
		Me.Label_StatusDb.Text = "Status Database :"
		'
		'Label_ConfirmDb
		'
		Me.Label_ConfirmDb.AutoSize = True
		Me.Label_ConfirmDb.Font = New System.Drawing.Font("Lucida Console", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_ConfirmDb.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Label_ConfirmDb.Location = New System.Drawing.Point(727, 292)
		Me.Label_ConfirmDb.Name = "Label_ConfirmDb"
		Me.Label_ConfirmDb.Size = New System.Drawing.Size(45, 8)
		Me.Label_ConfirmDb.TabIndex = 2
		Me.Label_ConfirmDb.Text = "........"
		'
		'FormLoginPS
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 326)
		Me.Controls.Add(Me.Label_ConfirmDb)
		Me.Controls.Add(Me.Label_StatusDb)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FormLoginPS"
		Me.Text = "Form_LoginPS"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label_Username As Label
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents TextBoxPassword As TextBox
	Friend WithEvents TextBoxUsername As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label_StatusDb As Label
	Public WithEvents Label_ConfirmDb As Label
End Class
