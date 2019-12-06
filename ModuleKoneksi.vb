Imports System.Data.SqlClient

Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet
	Public Cmd As SqlCommand

	Sub Koneksi()
		Try
			Conn = New SqlConnection("DATA SOURCE=DESKTOP-5A499D7\MSSQLSERVER01;INITIAL CATALOG=pembayaranspp;INTEGRATED SECURITY=true")
			Conn.Open()
			FormLogin.Label_ConfirmDb.Text = "Connected"
		Catch ex As Exception
			FormLogin.Label_ConfirmDb.Text = "Not Connected"

		End Try

	End Sub

End Module
