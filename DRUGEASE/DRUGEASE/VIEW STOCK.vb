Public Class VIEW_STOCK

    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from STOCK"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(9))


        End While
        CloseConn()
    End Sub
    Public Sub MEDName()


        ComboBox1.Items.Clear()

        OpenConn()
        SQL = "Select distinct(MNAME) from STOCK"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox1.Items.Add(Dr(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDComp()
        ComboBox2.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MCOMPANY) from STOCK "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox2.Items.Add(Dr(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDTYPE()
        ComboBox3.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MTYPE) from STOCK "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox3.Items.Add(Dr(0))
        End While
        CloseConn()

    End Sub
    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.Hide()
        LOGINSINGUP.Show()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ListView1.Items.Clear()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Disp()
        MEDName()
        MEDComp()
        MEDTYPE()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Me.Hide()
        Menu_page.Show()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ListView1.Items.Clear()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Disp()
        MEDName()
        MEDComp()
        MEDTYPE()
    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Me.Hide()
        STOCKMASTER.Show()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ListView1.Items.Clear()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Disp()
        MEDName()
        MEDComp()
        MEDTYPE()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized

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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ListView1.Items.Clear()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Disp()
        MEDName()
        MEDComp()
        MEDTYPE()

    End Sub

    Private Sub VIEW_STOCK_Load(sender As Object, e As EventArgs) Handles Me.Load
        Disp()
        MEDName()
        MEDComp()
        MEDTYPE()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from STOCK where MNAME='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(9))

        End While
        CloseConn()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        MEDComp()
        MEDTYPE()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from STOCK where MCOMPANY='" & ComboBox2.Text & " '"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(9))

        End While
        CloseConn()
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox1.Text = ""
        ComboBox3.Text = ""
        MEDName()
        MEDTYPE()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from STOCK where MTYPE='" & ComboBox3.Text & "' "
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(9))

        End While
        CloseConn()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        MEDComp()
        MEDName()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from STOCK where EXPDATE=#" & DateTimePicker1.Text & "#"
        'SQL = "SELECT * FROM STOCK WHERE EXPDATE FROM " " TO #" & DateTimePicker1.Text & "#"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(9))

        End While
        CloseConn()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""

        MEDName()
        MEDComp()
        MEDTYPE()
    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub
End Class