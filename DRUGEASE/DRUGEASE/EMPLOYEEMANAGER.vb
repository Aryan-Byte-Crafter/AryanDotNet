Imports System.Text.RegularExpressions
Public Class EMPLOYEEMANAGER
    Dim LOC As Point
    Public Sub Disp()
        ListView1.Items.Clear()
        OpenConn()
        If ComboBox1.Text = "ALL" Then
            SQL = " Select * from EMPLOYEEMANAGER"
        Else
            SQL = " Select * from EMPLOYEEMANAGER where ENAME='" & ComboBox1.Text & "'"
        End If
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
    Public Sub EName()


        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ALL")
        OpenConn()
        SQL = "Select distinct(ENAME) from EMPLOYEEMANAGER"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub EGENDER()
        ComboBox2.Items.Clear()
        OpenConn()
        SQL = "Select distinct(GENDER) from EMPLOYEEMANAGER where ENAME='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox2.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub FNAME()
        ComboBox3.Items.Clear()
        OpenConn()
        SQL = "Select distinct(FNAME) from EMPLOYEEMANAGER where ENAME='" & ComboBox1.Text & "' AND GENDER='" & ComboBox2.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox3.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub Guna2ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Me.Hide()
        Menu_page.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()
        Guna2TextBox9.Clear()
        DateTimePicker1.ResetText()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ListView1.Items.Clear()

        EName()
        Guna2ImageButton1.Enabled = True

        AutoEID()
    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Me.Hide()
        EMPLOYEEMASTER.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()
        Guna2TextBox9.Clear()
        DateTimePicker1.ResetText()

        ListView1.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        EName()
        Guna2ImageButton1.Enabled = True

        AutoEID()
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Guna2ImageButton1.PerformClick()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
    Public Sub AutoEID()
        OpenConn()
        SQL = "Select Max(EID) From EMPLOYEEMANAGER"
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

    Private Sub EMPLOYEEMANAGER_Load(sender As Object, e As EventArgs) Handles Me.Load
        AutoEID()
        EName()

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter  Name......")
            Exit Sub
        End If


        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter Father Name......")
            Exit Sub
        End If
        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Address......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Gender......")
            Exit Sub
        End If
        If Trim(Guna2TextBox6.Text) = "" Then
            MsgBox("Please Enter Contact Number......")
            Exit Sub
        End If
        If Trim(Guna2TextBox7.Text) = "" Then
            MsgBox("Please Enter Email......")
            Exit Sub
        End If
        If Trim(Guna2TextBox8.Text) = "" Then
            MsgBox("Please Enter ID Proof......")
            Exit Sub
        End If
        If Trim(Guna2TextBox9.Text) = "" Then
            MsgBox("Please Enter POLICE VARIFICATION STATE......")
            Exit Sub
        End If

        Dim phone = Trim(Guna2TextBox6.Text)
        Dim pat As String = "^(\ +91[\-\s]?)?[0]?(91)?[789]\d{9}$"
        Dim phoneMatch As Match = Regex.Match(phone, pat)


        Dim emailaddress = Trim(Guna2TextBox7.Text)
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success And phoneMatch.Success Then
            OpenConn()
            SQL = "insert into EMPLOYEEMANAGER values('" & Guna2TextBox1.Text & "' , '" & Guna2TextBox2.Text & "','" & DateTimePicker1.Text & "','" & Guna2TextBox5.Text & "' ,'" & Guna2TextBox3.Text & "','" & Guna2TextBox8.Text & "','" & Guna2TextBox9.Text & "','" & Guna2TextBox6.Text & "','" & Guna2TextBox7.Text & "','" & Guna2TextBox4.Text & "' )"
            ExecuteRead(SQL)
            CloseConn()
            'MsgBox("data saved")

            Guna2TextBox2.Clear()
            Guna2TextBox3.Clear()
            Guna2TextBox4.Clear()
            Guna2TextBox5.Clear()
            Guna2TextBox8.Clear()
            Guna2TextBox6.Clear()
            Guna2TextBox7.Clear()
            Guna2TextBox9.Clear()
            DateTimePicker1.ResetText()
            EName()

            AutoEID()
        Else
            MsgBox("Invalid Email address or Phone number.", MsgBoxStyle.Information)

            EName()

            AutoEID()
        End If
        EName()

        AutoEID()



    End Sub

    Private Sub Guna2ImageButton6_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton6.Click
        Me.Hide()
        LOGINSINGUP.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()
        Guna2TextBox9.Clear()
        DateTimePicker1.ResetText()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ListView1.Items.Clear()

        EName()
        Guna2ImageButton1.Enabled = True

        AutoEID()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Guna2ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        FNAME()
        Disp()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        EGENDER()
        Disp()

    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
        Disp()

    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()
        Guna2TextBox9.Clear()
        DateTimePicker1.ResetText()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ListView1.Items.Clear()

        EName()
        Guna2ImageButton1.Enabled = True

        AutoEID()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter  Name......")
            Exit Sub
        End If


        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter Father Name......")
            Exit Sub
        End If
        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Address......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Gender......")
            Exit Sub
        End If
        If Trim(Guna2TextBox6.Text) = "" Then
            MsgBox("Please Enter Contact Number......")
            Exit Sub
        End If
        If Trim(Guna2TextBox7.Text) = "" Then
            MsgBox("Please Enter Email......")
            Exit Sub
        End If
        If Trim(Guna2TextBox8.Text) = "" Then
            MsgBox("Please Enter ID Proof......")
            Exit Sub
        End If
        OpenConn()
        SQL = "Delete from EMPLOYEEMANAGER where EID=" & Guna2TextBox1.Text & ""
        ExecuteIUD(SQL)
        CloseConn()

        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()
        Guna2TextBox9.Clear()
        DateTimePicker1.ResetText()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ListView1.Items.Clear()

        EName()
        Guna2ImageButton1.Enabled = True

        AutoEID()
    End Sub

    Private Sub Guna2ImageButton8_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton8.Click
        If ListView1.SelectedItems.Count > 0 Then
            Guna2TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
            Guna2TextBox2.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(1).Text

            'DateTimePicker1.ResetText = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(2).Text
            Guna2TextBox5.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(3).Text
            Guna2TextBox3.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(4).Text
            Guna2TextBox8.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(5).Text
            Guna2TextBox9.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(6).Text
            Guna2TextBox6.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(7).Text
            Guna2TextBox7.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(8).Text
            Guna2TextBox4.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(9).Text


            Guna2ImageButton1.Enabled = False

        End If
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter  Name......")
            Exit Sub
        End If


        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter Father Name......")
            Exit Sub
        End If
        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Address......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Gender......")
            Exit Sub
        End If
        If Trim(Guna2TextBox6.Text) = "" Then
            MsgBox("Please Enter Contact Number......")
            Exit Sub
        End If
        If Trim(Guna2TextBox7.Text) = "" Then
            MsgBox("Please Enter Email......")
            Exit Sub
        End If
        If Trim(Guna2TextBox8.Text) = "" Then
            MsgBox("Please Enter ID Proof......")
            Exit Sub
        End If
        OpenConn()
        SQL = "Select * from EMPLOYEEMANAGER"
        ExecuteRead(SQL)
        While Dr.Read
            If Trim(Guna2TextBox2.Text) = Dr.GetString(1) And Trim(Guna2TextBox3.Text) = Dr.GetString(4) And Guna2TextBox4.Text = Dr.GetString(9) And Trim(Guna2TextBox5.Text) = Dr.GetString(3) And Trim(Guna2TextBox6.Text) = Dr.GetValue(7) And Trim(Guna2TextBox7.Text) = Dr.GetString(8) And Trim(Guna2TextBox8.Text) = Dr.GetString(5) And Trim(Guna2TextBox9.Text) = Dr.GetString(6) Then
                MsgBox("Data Already Exixst......")
                Guna2TextBox2.Clear()
                Guna2TextBox3.Clear()
                Guna2TextBox4.Clear()
                Guna2TextBox5.Clear()

                Guna2TextBox2.Focus()


            End If
        End While
        CloseConn()

        OpenConn()
        SQL = "Update  EMPLOYEEMANAGER set ENAME='" & Guna2TextBox2.Text & "', DOB='" & DateTimePicker1.Text & "', GENDER='" & Guna2TextBox5.Text & "',FNAME='" & Guna2TextBox3.Text & "',IDPROOF='" & Guna2TextBox8.Text & "',POLICEVARIFICATIONSTATE='" & Guna2TextBox9.Text & "',CONTACTNO='" & Guna2TextBox6.Text & "',EMAILID='" & Guna2TextBox7.Text & "',ADDRESS='" & Guna2TextBox4.Text & "' where EID=" & Guna2TextBox1.Text & ""

        ExecuteIUD(SQL)
        CloseConn()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()
        Guna2TextBox9.Clear()
        DateTimePicker1.ResetText()
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ListView1.Items.Clear()

        EName()
        Guna2ImageButton1.Enabled = True

        AutoEID()
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox5.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox5.TextChanged
        Dim strAllowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZadcdefghijklmnopqrstuvwxyz"
        If Len(Guna2TextBox5.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox5.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox5.Text(i)) = 0 Then
                    MsgBox("Please Enter char.")
                    Guna2TextBox5.Clear()
                    Guna2TextBox5.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub Guna2TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox3.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged

    End Sub

    Private Sub Guna2TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox8.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox8_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox8.TextChanged

    End Sub

    Private Sub Guna2TextBox8_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox9.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox9_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox9.TextChanged
        Dim strAllowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZadcdefghijklmnopqrstuvwxyz"
        If Len(Guna2TextBox9.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox9.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox9.Text(i)) = 0 Then
                    MsgBox("Please Enter char.")
                    Guna2TextBox9.Clear()
                    Guna2TextBox9.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub Guna2TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox6.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox6.TextChanged
        Dim strAllowedChars As String = "0123456789() -+ "
        If Len(Guna2TextBox6.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox6.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox6.Text(i)) = 0 Then
                    MsgBox("Please Enter Number.")
                    Guna2TextBox6.Clear()
                    Guna2TextBox6.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub Guna2TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox7.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox7_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox7.TextChanged

    End Sub

    Private Sub Guna2TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox4.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged

    End Sub

    Private Sub Guna2TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ImageButton1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        EGENDER()
        Disp()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        ComboBox3.Text = ""

        ComboBox3.Items.Clear()
        FNAME()
        Disp()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Disp()

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox3.Focus()
        End If
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ImageButton8.Focus()
        End If
    End Sub
End Class