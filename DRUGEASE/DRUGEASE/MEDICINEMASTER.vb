Public Class MEDICINEMASTER
    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()

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
        ComboBox1.Items.Add("ALL")
        OpenConn()
        SQL = "Select distinct(MEDICINENAME) from MEDICINEMASTER"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDComp()
        Guna2ComboBox2.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MEDICINECOMPANY) from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            Guna2ComboBox2.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDType()
        Guna2ComboBox3.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MEDICINETYPE) from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "' AND MEDICINECOMPANY='" & Guna2ComboBox2.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            Guna2ComboBox3.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDSIZE()
        Guna2ComboBox4.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MEDICINESIZEPOWER) from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "' AND MEDICINECOMPANY='" & Guna2ComboBox2.Text & "' AND MEDICINETYPE='" & Guna2ComboBox3.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            Guna2ComboBox4.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2ImageButton6_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton6.Click
        Me.Hide()
        LOGINSINGUP.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()

        ComboBox1.Items.Clear()
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""
        Guna2ImageButton1.Enabled = True
        AutoMID()
        MEDName()
    End Sub


    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter  Name......")
            Exit Sub
        End If


        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter Company......")
            Exit Sub
        End If
        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Type......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Size/Power......")
            Exit Sub
        End If

        OpenConn()
        SQL = "Select * from MEDICINEMASTER"
        ExecuteRead(SQL)
        While Dr.Read
            If Trim(Guna2TextBox2.Text) = Dr.GetString(1) And Trim(Guna2TextBox3.Text) = Dr.GetString(2) And Guna2TextBox4.Text = Dr.GetString(3) And Trim(Guna2TextBox5.Text) = Dr.GetValue(4) Then
                MsgBox("Data Already Exixst......")
                Guna2TextBox2.Clear()
                Guna2TextBox3.Clear()
                Guna2TextBox4.Clear()
                Guna2TextBox5.Clear()

                Guna2TextBox2.Focus()
                CloseConn()

            End If
        End While
        CloseConn()

        OpenConn()
        SQL = "Update  MEDICINEMASTER set MEDICINENAME='" & Guna2TextBox2.Text & "', MEDICINECOMPANY='" & Guna2TextBox3.Text & "',MEDICINETYPE='" & Guna2TextBox4.Text & "',MEDICINESIZEPOWER='" & Guna2TextBox5.Text & "' where MID=" & Guna2TextBox1.Text & ""

        ExecuteIUD(SQL)
        CloseConn()
        MsgBox("Data Updated..")
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()

        Guna2TextBox2.Focus()
        ComboBox1.Items.Clear()
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()

        ComboBox1.Text = ""
        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""

        ListView1.Items.Clear()
        AutoMID()
        MEDName()
        Guna2ImageButton1.Enabled = True
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter  Name......")
            Exit Sub
        End If


        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter Company......")
            Exit Sub
        End If
        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Type......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Size/Power......")
            Exit Sub
        End If
        OpenConn()
        SQL = "insert into MEDICINEMASTER values('" & Guna2TextBox1.Text & "' , '" & Guna2TextBox2.Text & "','" & Guna2TextBox3.Text & "','" & Guna2TextBox4.Text & "' ,'" & Guna2TextBox5.Text & "' )"
        ExecuteRead(SQL)
        CloseConn()
        'MsgBox("data saved")

        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        AutoMID()

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Me.Hide()
        Menu_page.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()

        ComboBox1.Items.Clear()
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""
        Guna2ImageButton1.Enabled = True
        AutoMID()
        MEDName()
    End Sub


    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Me.Hide()
        MEDICINEMANAGER.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()

        ComboBox1.Items.Clear()
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""
        Guna2ImageButton1.Enabled = True
        AutoMID()
        MEDName()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub MEDICINEMASTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AutoMID()
        Guna2TextBox2.Focus()

        MEDName()

    End Sub
    Public Sub AutoMID()
        OpenConn()
        SQL = "Select Max(MID) From MEDICINEMASTER"
        ExecuteRead(SQL)
        While Dr.Read
            If IsDBNull(Dr.GetValue(0)) Then
                Guna2TextBox1.Text = 1
            Else
                Guna2TextBox1.Text = Dr.GetValue(0) + 1
            End If
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

    Private Sub Label7Click(sender As Object, e As EventArgs) Handles Label7.Click

        Guna2ImageButton1.PerformClick()

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "'"
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""

        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()
        Disp()
        MEDType()
    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox3.SelectedIndexChanged
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME ='" & ComboBox1.Text & "' And MEDICINECOMPANY='" & Guna2ComboBox2.Text & "'"

        Guna2ComboBox4.Text = ""


        Guna2ComboBox4.Items.Clear()
        Disp()
        MEDSIZE()

    End Sub

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox4.SelectedIndexChanged
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME ='" & ComboBox1.Text & "' And MEDICINECOMPANY='" & Guna2ComboBox2.Text & "' And MEDICINESIZEPOWER='" & Guna2ComboBox3.Text & "'"
        Disp()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter Name......")
            Exit Sub
        End If


        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter Company......")
            Exit Sub
        End If
        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Type......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Size/Power......")
            Exit Sub
        End If



        OpenConn()
        SQL = "Delete from MEDICINEMASTER where MID=" & Guna2TextBox1.Text & ""
        ExecuteIUD(SQL)
        CloseConn()

        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()

        ComboBox1.Items.Clear()
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""

        AutoMID()
        MEDName()
        Guna2ImageButton1.Enabled = True
    End Sub

    Private Sub Guna2ImageButton8_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton8.Click
        If ListView1.SelectedItems.Count > 0 Then
            Guna2TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
            Guna2TextBox2.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(1).Text

            Guna2TextBox3.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(2).Text
            Guna2TextBox4.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(3).Text
            Guna2TextBox5.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(4).Text


            Guna2ImageButton1.Enabled = False

        End If
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click

        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()

        ComboBox1.Items.Clear()
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()
        ListView1.Items.Clear()
        ComboBox1.Text = ""
        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""
        Guna2ImageButton1.Enabled = True
        AutoMID()
        MEDName()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox3.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged

    End Sub

    Private Sub Guna2TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox4.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged

    End Sub

    Private Sub Guna2TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox5.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox5.TextChanged

    End Sub

    Private Sub Guna2TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ImageButton1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "ALL" Then
            SQL = "Select * from MEDICINEMASTER"
        Else
            SQL = "Select * from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "'"
        End If

        Guna2ComboBox2.Text = ""
        Guna2ComboBox3.Text = ""
        Guna2ComboBox4.Text = ""
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox3.Items.Clear()
        Guna2ComboBox4.Items.Clear()
        Disp()
        MEDComp()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ComboBox2.Focus()
        End If
    End Sub

    Private Sub Guna2ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ComboBox3.Focus()
        End If
    End Sub

    Private Sub Guna2ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2ComboBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ComboBox4.Focus()
        End If
    End Sub

    Private Sub Guna2ComboBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2ComboBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox2.Focus()
        End If
    End Sub
End Class