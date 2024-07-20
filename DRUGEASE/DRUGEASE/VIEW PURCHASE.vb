Public Class VIEW_PURCHASE
    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from PURCHASE"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(13))


        End While
        CloseConn()
    End Sub
    Public Sub PID()


        ComboBox2.Items.Clear()

        OpenConn()
        SQL = "Select distinct(PURID) from PURCHASE"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox2.Items.Add(Dr.GetValue(0))
        End While
        CloseConn()

    End Sub

    Public Sub MEDNAME()
        ComboBox3.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MNAME) from PURCHASE "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox3.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDCOM()
        ComboBox1.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MCOMPANY) from PURCHASE "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub AGENCY()
        ComboBox4.Items.Clear()
        OpenConn()
        SQL = "Select distinct(AGENCY) from PURCHASE "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox4.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Me.Hide()
        PURCHASEMASTER.Show()
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        Disp()

        AGENCY()
        MEDCOM()
        MEDNAME()

        PID()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Menu_page.Show()
        Me.Hide()
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        Disp()

        AGENCY()
        MEDCOM()
        MEDNAME()

        PID()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.Hide()
        LOGINSINGUP.Show()
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        Disp()

        AGENCY()
        MEDCOM()
        MEDNAME()

        PID()
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

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub

    Private Sub VIEW_PURCHASE_Load(sender As Object, e As EventArgs) Handles Me.Load
        Disp()
        AGENCY()
        MEDCOM()
        MEDNAME()
        PID()

    End Sub



    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Guna2ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        Disp()

        AGENCY()
        MEDCOM()
        MEDNAME()

        PID()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from PURCHASE where PDATE =#" & DateTimePicker1.Text & "#"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(13))
        End While
        CloseConn()
    End Sub

    Private Sub DateTimePicker1_StyleChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.StyleChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from PURCHASE where MCOMPANY='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(13))
        End While
        CloseConn()
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        ComboBox4.Items.Clear()
        ComboBox4.Text = ""
        AGENCY()

        MEDNAME()
        PID()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from PURCHASE where PURID=" & ComboBox2.Text & " "
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(13))
        End While
        CloseConn()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        ComboBox4.Items.Clear()
        ComboBox4.Text = ""
        AGENCY()
        MEDCOM()
        MEDNAME()


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from PURCHASE where MNAME='" & ComboBox3.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(13))
        End While
        CloseConn()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox4.Items.Clear()
        ComboBox4.Text = ""
        AGENCY()
        MEDCOM()

        PID()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from PURCHASE where AGENCY='" & ComboBox4.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(9))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(13))
        End While
        CloseConn()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""

        MEDCOM()
        MEDNAME()
        PID()
    End Sub
End Class