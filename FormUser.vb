Imports System.Data.SqlClient

Public Class FormUser

	Sub Bersihkan()
		TextBoxKodeUser.Clear()
		TextBoxNamaUser.Clear()
		TextBoxPasswordUser.Clear()
		TextBoxStatusUser.Clear()
		TextBoxKodeUser.Focus()
	End Sub

	Sub RefreshDGV()
		Call Koneksi()
		Da = New SqlDataAdapter("SELECT * FROM tbuser", Conn)
		Ds = New DataSet
		Da.Fill(Ds)
		DGVUser.DataSource = Ds.Tables(0)
		DGVUser.ReadOnly = True
	End Sub
	Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call RefreshDGV()

	End Sub

	Private Sub ButtonInput_Click(sender As Object, e As EventArgs) Handles ButtonInput.Click
		If TextBoxKodeUser.Text = "" Then
			MsgBox("Masukan Kode user terlebih dahulu")
		Else
			Call Koneksi()
			Cmd = New SqlCommand("SELECT * FROM tbuser WHERE Kode_User='" & TextBoxKodeUser.Text & "' ", Conn)
			Dr = Cmd.ExecuteReader
			Dr.Read()
			If Dr.HasRows Then
				MsgBox("Maaf Kode user Sudah Ada")
				TextBoxKodeUser.Clear()
				TextBoxKodeUser.Focus()
			Else
				Call Koneksi()
				Dim Input As String = "INSERT INTO tbuser VALUES ('" & TextBoxKodeUser.Text & "','" & TextBoxNamaUser.Text & "','" & TextBoxPasswordUser.Text & "', '" & TextBoxStatusUser.Text & "' )"
				Cmd = New SqlCommand(Input, Conn)
				Cmd.ExecuteNonQuery()
				MsgBox("Data Sudah Diinput")
				Call Bersihkan()
				Call RefreshDGV()
			End If


		End If


	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Close()
		FormLogin.Close()
	End Sub

	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
		Call Bersihkan()

	End Sub

	Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
		If TextBoxKodeUser.Text = "" Then
			MsgBox("Cari Terlebih dahulu Kode User yang akan di delete")
		Else
			Call Koneksi()
			Dim Hapus As String = "DELETE FROM tbuser WHERE Kode_User='" & TextBoxKodeUser.Text & "' "
			Cmd = New SqlCommand(Hapus, Conn)
			Cmd.ExecuteNonQuery()
			MsgBox("Data Sudah Di Hapus")
			Call Bersihkan()
			Call RefreshDGV()
			TextBoxKodeUser.ReadOnly = False


		End If

	End Sub

	Private Sub TextBoxKodeUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxKodeUser.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxNamaUser.Focus()

	End Sub
	Private Sub TextBoxNamaUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNamaUser.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxPasswordUser.Focus()

	End Sub
	Private Sub TextBoxPasswordUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPasswordUser.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxStatusUser.Focus()

	End Sub

	Private Sub ButtonCari_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
		If TextBoxKodeUser.Text = "" Then
			MsgBox("Masukan Kode User yg akan di cari")
		Else
			Call Koneksi()
			Cmd = New SqlCommand("SELECT * FROM tbuser WHERE Kode_User='" & TextBoxKodeUser.Text & "' ", Conn)
			Dr = Cmd.ExecuteReader
			Dr.Read()
			If Dr.HasRows Then
				TextBoxKodeUser.Text = Dr.Item("Kode_User")
				TextBoxNamaUser.Text = Dr.Item("Nama_User")
				TextBoxPasswordUser.Text = Dr.Item("Pwd_User")
				TextBoxStatusUser.Text = Dr.Item("Status_User")
				TextBoxKodeUser.ReadOnly = True
			Else
				MsgBox("Kode User Tidak Ada")
				TextBoxKodeUser.Clear()
			End If
		End If
	End Sub

	Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
		If TextBoxKodeUser.Text = "" Then
			MsgBox("Cari Terlebih Dahulu Kode User yg akan di edit")
		Else
			Call Koneksi()
			Dim Edit As String = "UPDATE tbuser SET Nama_User = '" & TextBoxNamaUser.Text & "', Pwd_User ='" & TextBoxPasswordUser.Text & "',Status_User='" & TextBoxStatusUser.Text & "'  WHERE Kode_User='" & TextBoxKodeUser.Text & "' "
			Cmd = New SqlCommand(Edit, Conn)
			Cmd.ExecuteNonQuery()
			MsgBox("Data Sudah Di update")
			Call Bersihkan()
			Call RefreshDGV()
			TextBoxKodeUser.ReadOnly = False

		End If
	End Sub
End Class