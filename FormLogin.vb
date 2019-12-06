Imports System.Data.SqlClient

Public Class FormLogin 'pendeklarasian FormLoginPS sebagai class yang bersifat publik atau bisa diakses oleh siapa saja
	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
		Close()
	End Sub

	Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Koneksi()
	End Sub

	Private Sub TextBoxUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUsername.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxPassword.Focus()

	End Sub
	Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
		If e.KeyChar = Chr(13) Then ButtonLogin.Focus()

	End Sub

	Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
		Call Koneksi()
		Cmd = New SqlCommand("SELECT * FROM tbuser WHERE Nama_User ='" & TextBoxUsername.Text & "' AND Pwd_User='" & TextBoxPassword.Text & "' ", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			FormHome.Show()
			Visible = False
		Else
			MsgBox("Username Dan Password Salah")
			TextBoxUsername.Clear()
			TextBoxPassword.Clear()
			TextBoxUsername.Focus()
		End If
	End Sub
End Class
