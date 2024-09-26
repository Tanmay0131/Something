Public Class Form4
    Public Sub from4_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.player1
        PictureBox2.Image = My.Resources.player2
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMain.Show()
    End Sub
End Class