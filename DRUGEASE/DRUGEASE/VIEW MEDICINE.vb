Public Class VIEW_MEDICINE
    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from MEDICINEMASTER"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))

        End While
        CloseConn()
    End Sub
    Public Sub MEDName()


        ComboBox1.Items.Clear()

        OpenConn()
        SQL = "Select distinct(MEDICINENAME) from MEDICINEMASTER"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDComp()
        ComboBox2.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MEDICINECOMPANY) from MEDICINEMASTER "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox2.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub



    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VIEW_MEDICINE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Disp()
        MEDName()

        MEDComp()
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Me.Hide()
        MEDICINEMANAGER.Show()
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        Disp()
        MEDComp()
        MEDName()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Me.Hide()
        Menu_page.Show()
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        Disp()
        MEDComp()
        MEDName()
    End Sub

    Private Sub Guna2ImageButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.Hide()
        LOGINSINGUP.Show()
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        Disp()
        MEDComp()
        MEDName()
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs)


    End Sub



    Private Sub VIEW_MEDICINE_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ListView1.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        Disp()
        MEDComp()
        MEDName()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()

        SQL = "Select * from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))

        End While
        CloseConn()
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        MEDComp()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        SQL = "Select * from MEDICINEMASTER where MEDICINECOMPANY='" & ComboBox2.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(4))

        End While
        CloseConn()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        MEDName()
    End Sub
End Class