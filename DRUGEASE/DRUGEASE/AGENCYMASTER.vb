﻿Public Class AGENCYMASTER
    Dim LOC As Point
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Menu_page.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        STOCKMASTER.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        PURCHASEMASTER.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        EMPLOYEEMASTER.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        SALESMASTER.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        MEDICINEMANAGER.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.Hide()
        LOGINSINGUP.Show()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
    Private Sub Guna2Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOC = e.Location

        End If
    End Sub

    Private Sub Guna2Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Guna2Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOC

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOC

        End If
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOC = e.Location
        End If
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2GradientCircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton3.Click
        AGENCYMANAGER.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        Me.Hide()
        VIEW_AGENCY.Show()

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Menu_page.Show()
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class