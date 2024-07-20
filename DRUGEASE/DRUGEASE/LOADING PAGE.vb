Public Class LOADING_PAGE

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.PBAR.Value = PBAR.Value + 1
        If PBAR.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            LOGINSINGUP.Show()

        End If


    End Sub

    Private Sub LOADING_PAGE_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play("D:\medical management software\loading.wav")
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class