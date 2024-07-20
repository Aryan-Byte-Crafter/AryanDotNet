Public Class VIEW_SALE
    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from SALE"
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
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(13))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(14))


        End While
        CloseConn()
    End Sub
    Public Sub SALEID()


        ComboBox1.Items.Clear()

        OpenConn()
        SQL = "Select distinct(SID) from SALE"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox1.Items.Add(Dr(0))
        End While
        CloseConn()

    End Sub
    Public Sub SALEDATE()

    End Sub
    Public Sub MEDName()


        ComboBox2.Items.Clear()

        OpenConn()
        SQL = "Select distinct(MNAME) from SALE"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox2.Items.Add(Dr(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDComp()
        ComboBox3.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MCOMPANY) from SALE "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox3.Items.Add(Dr(0))
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

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Me.Hide()
        SALESMASTER.Show()
        ComboBox1.Items.Clear()

        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        ListView1.Items.Clear()
        Disp()


        MEDComp()
        MEDName()
        SALEDATE()
        SALEID()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Menu_page.Show()
        Me.Hide()
        ComboBox1.Items.Clear()

        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        ListView1.Items.Clear()
        Disp()


        MEDComp()
        MEDName()
        SALEDATE()
        SALEID()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.Hide()
        LOGINSINGUP.Show()
        ComboBox1.Items.Clear()

        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        ListView1.Items.Clear()
        Disp()


        MEDComp()
        MEDName()
        SALEDATE()
        SALEID()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub

    Private Sub VIEW_SALE_Load(sender As Object, e As EventArgs) Handles Me.Load
        Disp()
        MEDComp()
        SALEDATE()
        SALEID()


        MEDName()
    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ComboBox1.Items.Clear()

        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        ListView1.Items.Clear()
        Disp()


        MEDComp()
        MEDName()
        SALEDATE()
        SALEID()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from SALE where SDATE=#" & DateTimePicker1.Text & "#"
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
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(13))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(14))
        End While
        CloseConn()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from SALE where SID=" & ComboBox1.Text & " "
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
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(13))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(14))
        End While
        CloseConn()
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()

        MEDComp()
        MEDName()
        SALEDATE()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()

        SQL = "Select * from SALE where MNAME='" & ComboBox2.Text & "'"
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
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(13))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(14))

        End While
        CloseConn()
        ComboBox1.Text = ""
        ComboBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        MEDComp()

        SALEDATE()
        SALEID()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from SALE where MCOMPANY='" & ComboBox3.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(7))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(8))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(9))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(10))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(11))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(12))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(13))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr(14))

        End While
        CloseConn()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        MEDName()
        SALEDATE()
        SALEID()
    End Sub
End Class