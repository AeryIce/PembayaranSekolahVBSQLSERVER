Imports System.Data.SqlClient

Public Class FormHomePS

	Private Sub ButtonExit_FormPS_Click(sender As Object, e As EventArgs)
		Close()
		FormLoginPS.Close()
	End Sub

	Private Sub DataGridViewHomePS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

	End Sub

	Private Sub FormHomePS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
		Close()
		FormLoginPS.Close()
	End Sub

	Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
		FormUser.Show()

	End Sub

	Private Sub SiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaToolStripMenuItem.Click

	End Sub

	Private Sub GuruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuruToolStripMenuItem.Click

	End Sub

	Private Sub WaliKelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaliKelasToolStripMenuItem.Click

	End Sub

	Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click

	End Sub
	Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click

	End Sub
End Class
