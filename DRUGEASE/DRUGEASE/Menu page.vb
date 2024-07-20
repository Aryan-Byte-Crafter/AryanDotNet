Public Class Menu_page
    Dim LOC As Point
    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.Close()
        LOGINSINGUP.Show()
    End Sub
    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        Me.Hide()
        STOCKMASTER.Show()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        Me.Hide()
        SALESMASTER.Show()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Me.Hide()
        PURCHASEMASTER.Show()

    End Sub

    Private Sub Guna2ImageButton6_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton6.Click
        Me.Hide()
        MEDICINEMANAGER.Show()
    End Sub

    Private Sub Guna2ImageButton8_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton8.Click
        AGENCYMASTER.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        EMPLOYEEMASTER.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2GradientButton3_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub
    Private Sub Menu_page_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim W, H As Integer
        W = Me.Width
        H = Me.Height
        Guna2Panel1.Location = New Point(W * 100 / 100, H * 35 / 100)
    End Sub
    Private Sub Guna2Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOC = e.Location

        End If
    End Sub
    Private Sub Guna2Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Guna2Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - Loc

        End If
    End Sub
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - Loc

        End If
    End Sub
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Loc = e.Location
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        End
    End Sub
End Class