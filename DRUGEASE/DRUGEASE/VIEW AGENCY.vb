Public Class VIEW_AGENCY
    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()
        SQL = " Select * from AGENCYMANAGER"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
        End While

        CloseConn()
    End Sub
    Public Sub Company_Name()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ALL")
        OpenConn()
        SQL = "Select A_COMPANY from AGENCYMANAGER"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Company_Name()
        Disp()

        Me.Hide()
        AGENCYMASTER.Show()

    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Company_Name()
        Disp()

        Me.Hide()
        Menu_page.Show()

    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Company_Name()

        Disp()

        Me.Hide()
        LOGINSINGUP.Show()

    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub


    Private Sub VIEW_AGENCY_Load(sender As Object, e As EventArgs) Handles Me.Load
        Company_Name()
        Disp()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Company_Name()
        Disp()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        If ComboBox1.Text = "ALL" Then
            SQL = " Select * from AGENCYMANAGER"
        Else
            SQL = " Select * from AGENCYMANAGER where A_COMPANY='" & ComboBox1.Text & "'"
        End If
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
        End While

        CloseConn()
    End Sub
End Class