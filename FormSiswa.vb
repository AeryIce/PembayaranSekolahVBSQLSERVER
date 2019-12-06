Imports System.Data.SqlClient
Public Class FormSiswa

	Sub Nis()
		Call Koneksi()
		Cmd = New SqlCommand("SELECT * FROM tbsiswa WHERE NIS in(SELECT MAX(NIS) FROM tbsiswa)", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Not Dr.HasRows Then
			TextBoxNIS.Text = Format(Now, "yy") + "001"
		Else
			If Microsoft.VisualBasic.Left(Dr.Item("NIS"), 2) = Format(Now, "yy") Then
				TextBoxNIS.Text = Dr.Item("NIS") + 1
			Else
				TextBoxNIS.Text = Format(Now, "yy") + "001"
			End If
		End If
		TextBoxNIS.ReadOnly = True
	End Sub

	Sub RefreshDGVSiswa()
		Call Koneksi()
		Da = New SqlDataAdapter("SELECT * FROM tbsiswa", Conn)
		Ds = New DataSet
		Da.Fill(Ds)
		DGVSiswa.DataSource = Ds.Tables(0)
		DGVSiswa.ReadOnly = True
	End Sub

	Sub Kelas()
		Call Koneksi()
		Cmd = New SqlCommand("SELECT COUNT(*) FROM tbsiswa", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.Item(0) <= 5 Then
			TextBoxKelasSiswa.Text = "1A"

		ElseIf Dr.Item(0) <= 10 Then
			TextBoxKelasSiswa.Text = "1B"
		ElseIf Dr.Item(0) <= 15 Then
			TextBoxKelasSiswa.Text = "1C"
		ElseIf Dr.Item(0) <= 20 Then
			TextBoxKelasSiswa.Text = "1D"
		Else
			TextBoxKelasSiswa.Text = "1Z"
		End If

	End Sub
	Private Sub FormSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Nis()
		Call RefreshDGVSiswa()
		TextBoxTempoPertama.Text = DateValue("11/28/" & Year(Today) & "")
		Dim TahunAjaran As String = Format(Today, "yyyy") & "-" & Format(Today, "yyyy") + 1
		TextBoxTahunAjaran.Text = TahunAjaran
		If Microsoft.VisualBasic.Left(TextBoxTahunAjaran.Text, 4) = "2019" Then
			TextBoxBiaya.Text = 150000
			TextBoxBiaya.Text = FormatNumber(TextBoxBiaya.Text, 0)
		ElseIf Microsoft.VisualBasic.Left(TextBoxBiaya.Text, 4) = "2020" Then
			TextBoxBiaya.Text = "200000"
			TextBoxBiaya.Text = FormatNumber(TextBoxBiaya.Text, 0)
		End If
		Call Kelas()



	End Sub


	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		Close()
		FormLogin.Close()
	End Sub

	Private Sub ButtonInput_Click(sender As Object, e As EventArgs) Handles ButtonInput.Click
		If TextBoxNamaSiswa.Text = "" Then
			MsgBox("Nama Siswa Belum Diisi")
		Else
			Call Koneksi()
			Cmd = New SqlCommand("SELECT * FROM tbsiswa WHERE NIS='" & TextBoxNIS.Text & "' ", Conn)
			Dr = Cmd.ExecuteReader
			Dr.Read()
			If Not Dr.HasRows Then
				Call Koneksi()

				Dim Simpan As String = "INSERT INTO tbsiswa VALUES('" & TextBoxNIS.Text & "','" & TextBoxNamaSiswa.Text & "','" & TextBoxKelasSiswa.Text & "','" & TextBoxTahunAjaran.Text & "','" & Microsoft.VisualBasic.Str(TextBoxBiaya.Text) & "')"
				Cmd = New SqlCommand(Simpan, Conn)
				Cmd.ExecuteNonQuery()
				Call RefreshDGVSiswa()
				MsgBox("Data Sudah Tersimpan")

				For i As Integer = 1 To 12

					Dim Tempo As Date = DateAdd(DateInterval.Month, i - 1, DateValue(TextBoxTempoPertama.Text))
					Call Koneksi()
					Dim Hasil As String = TextBoxNIS.Text
					Dim SimpanDetail As String = "INSERT INTO tbspp VALUES ('" & TextBoxNIS.Text & i & "',0,'" & Format(Tempo, "MM/dd/yyyy") & "','" & Format(Tempo, "MMMM") + " " + Format(Tempo, "yyyy") & "','" & TextBoxNIS.Text & "',0,'-','-' )"
					Cmd = New SqlCommand(SimpanDetail, Conn)
					Cmd.ExecuteNonQuery()


				Next
				Cmd = New SqlCommand("SELECT * FROM tbspp ORDER BY 1,2", Conn)
				Dr = Cmd.ExecuteReader
				Dr.Read()
			Else
				Call Koneksi()
				Dim Edit As String = "UPDATE tbsiswa SET Nama_Siswa='" & TextBoxNamaSiswa.Text & "',Kelas = '" & TextBoxKelasSiswa.Text & "',Kelas='" & TextBoxKelasSiswa.Text & "', Tahun_Ajaran='" & TextBoxTahunAjaran.Text & "',Biaya = '" & TextBoxBiaya.Text & "' WHERE NIS='" & TextBoxNIS.Text & "'  "
				Cmd = New SqlCommand(Edit, Conn)
				Cmd.ExecuteNonQuery()
			End If


		End If
		Call RefreshDGVSiswa()
		Call Nis()
		Call Kelas()

	End Sub
End Class