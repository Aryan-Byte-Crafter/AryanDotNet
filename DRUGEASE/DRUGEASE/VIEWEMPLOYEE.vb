Public Class VIEWEMPLOYEE
    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()

        SQL = " Select * from EMPLOYEEMANAGER"

        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))


        End While
        CloseConn()
    End Sub

    Public Sub EGENDER()
        ComboBox1.Items.Clear()
        OpenConn()
        SQL = "Select distinct(GENDER) from EMPLOYEEMANAGER "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.Hide()
        LOGINSINGUP.Show()

        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Disp()

        EGENDER()

    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Menu_page.Show()
        Me.Hide()

        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Disp()

        EGENDER()

    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Me.Hide()
        EMPLOYEEMASTER.Show()

        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Disp()

        EGENDER()
    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub

    Private Sub VIEWEMPLOYEE_Load(sender As Object, e As EventArgs) Handles Me.Load
        Disp()

        EGENDER()
    End Sub



    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Disp()

        EGENDER()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from EMPLOYEEMANAGER where GENDER='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))


        End While
        CloseConn()
    End Sub
End Class