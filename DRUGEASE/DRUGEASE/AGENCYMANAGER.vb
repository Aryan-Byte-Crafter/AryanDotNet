Imports System.Text.RegularExpressions

Public Class AGENCYMANAGER
    Dim LOC As Point
    Public Sub Company_Name()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ALL")
        OpenConn()
        SQL = "Select A_NAME from AGENCYMANAGER"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()
    End Sub
    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Guna2ImageButton8_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton8.Click
        If ListView1.SelectedItems.Count > 0 Then
            Guna2TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
            Guna2TextBox2.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(1).Text
            Guna2TextBox7.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(2).Text

            Guna2TextBox4.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(3).Text
            Guna2TextBox5.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(4).Text
            Guna2TextBox6.Text = ListView1.SelectedItems.Item(ListView1.SelectedItems.Count - 1).SubItems(5).Text


            Guna2ImageButton1.Enabled = False

        End If
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter Agency Name......")
            Exit Sub
        End If
        If Trim(Guna2TextBox7.Text) = "" Then
            MsgBox("Please Enter Agency Dl No.")
            Exit Sub
        End If

        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Agency Address......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Mobile Number......")
            Exit Sub
        End If
        If Trim(Guna2TextBox6.Text) = "" Then
            MsgBox("Please Enter Mail......")
            Exit Sub
        End If


        OpenConn()
        SQL = "Delete from AGENCYMANAGER where AID=" & Guna2TextBox1.Text & ""
        ExecuteIUD(SQL)
        CloseConn()

        Guna2TextBox2.Clear()

        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ListView1.Items.Clear()


        AutoAID()
        Company_Name()
        Guna2ImageButton1.Enabled = True
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter Agency Name......")
            Exit Sub
        End If
        If Trim(Guna2TextBox7.Text) = "" Then
            MsgBox("Please Enter Agency Dl No.")
            Exit Sub
        End If

        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Agency Address......")
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Mobile Number......")
            Exit Sub
        End If
        If Trim(Guna2TextBox6.Text) = "" Then
            MsgBox("Please Enter Mail......")
            Exit Sub
        End If
        Dim DLNUM = Trim(Guna2TextBox7.Text)
        Dim PATER As String = "^\d{2}[A-Z]/\d{4}/\d{2}/\d{4}$"
        Dim DLNUMMatch As Match = Regex.Match(DLNUM, PATER)

        'MsgBox("data saved")
        Dim phone = Trim(Guna2TextBox5.Text)
        Dim pat As String = "^(\ +91[\-\s]?)?[0]?(91)?[6789]\d{9}$"
        Dim phoneMatch As Match = Regex.Match(phone, pat)


        Dim emailaddress = Trim(Guna2TextBox6.Text)
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success And phoneMatch.Success And DLNUMMatch.Success Then
            OpenConn()
            SQL = "insert into AGENCYMANAGER values('" & Guna2TextBox1.Text & "' , '" & Guna2TextBox2.Text & "','" & Guna2TextBox7.Text & "','" & Guna2TextBox4.Text & "' ,'" & Guna2TextBox5.Text & "' ,'" & Guna2TextBox6.Text & "' )"
            ExecuteRead(SQL)
            CloseConn()
            Guna2TextBox2.Clear()

            Guna2TextBox4.Clear()
            Guna2TextBox5.Clear()
            Guna2TextBox6.Clear()
            Guna2TextBox7.Clear()
            AutoAID()
            Company_Name()
        Else


            'emailaddresscheck = False
            MsgBox("Invalid Email address or Phone number.", MsgBoxStyle.Information)

                AutoAID()
                Company_Name()
            End If

    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        AGENCYMASTER.Show()
        Me.Hide()

        Guna2TextBox2.Clear()

        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox2.Focus()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Guna2TextBox7.Clear()


        ListView1.Items.Clear()
        AutoAID()
        Company_Name()
        Guna2ImageButton1.Enabled = True
        Guna2TextBox2.Focus()

    End Sub

    Private Sub Guna2ImageButton6_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton6.Click
        LOGINSINGUP.Show()
        Me.Hide()
        Guna2TextBox2.Clear()

        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox2.Focus()
        ComboBox1.Items.Clear()
        Guna2TextBox7.Clear()


        ListView1.Items.Clear()
        AutoAID()
        Company_Name()
        Guna2ImageButton1.Enabled = True
        Guna2TextBox2.Focus()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Me.Hide()
        Menu_page.Show()

        Guna2TextBox2.Clear()

        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox2.Focus()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Guna2TextBox7.Clear()

        ListView1.Items.Clear()
        AutoAID()
        Company_Name()
        Guna2ImageButton1.Enabled = True
        Guna2TextBox2.Focus()
    End Sub





    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox5.TextChanged
        Dim strAllowedChars As String = "0123456789() -+ "
        If Len(Guna2TextBox5.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox5.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox5.Text(i)) = 0 Then
                    MsgBox("Please Enter Number.")
                    Guna2TextBox5.Clear()
                    Guna2TextBox5.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub AGENCYMANAGER_Load(sender As Object, e As EventArgs) Handles Me.Load
        Company_Name()


        AutoAID()
        Guna2TextBox2.Focus()



    End Sub
    Public Sub AutoAID()

        OpenConn()
        SQL = "Select Max(AID) From AGENCYMANAGER"
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

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        Guna2TextBox2.Clear()

        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox2.Focus()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Guna2TextBox7.Clear()

        ListView1.Items.Clear()
        AutoAID()
        Company_Name()
        Guna2ImageButton1.Enabled = True
        Guna2TextBox2.Focus()

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub




    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter Dealer Name")
            Guna2TextBox2.Focus()
        End If

        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter Company Address....")
            Guna2TextBox4.Focus()
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter Mobile No....")
            Guna2TextBox5.Focus()
            Exit Sub
        End If
        If Trim(Guna2TextBox6.Text) = "" Then

            Guna2TextBox6.Text = "-"
            Exit Sub
        End If
        OpenConn()
        SQL = "Select * from AGENCYMANAGER"
        ExecuteRead(SQL)
        While Dr.Read
            If Trim(Guna2TextBox2.Text) = Dr.GetString(1) And Trim(Guna2TextBox7.Text) = Dr.GetString(2) And Guna2TextBox4.Text = Dr.GetString(3) And Trim(Guna2TextBox5.Text) = Dr.GetValue(4) And Trim(Guna2TextBox6.Text) = Dr.GetString(5) Then
                MsgBox("Data Already Exixst......")
                Guna2TextBox2.Clear()

                Guna2TextBox4.Clear()
                Guna2TextBox5.Clear()
                Guna2TextBox7.Clear()
                Guna2TextBox6.Clear()
                Guna2TextBox2.Focus()
                CloseConn()

            End If
        End While
        CloseConn()

        OpenConn()
        SQL = "Update  AGENCYMANAGER set A_NAME='" & Guna2TextBox2.Text & "', A_DL_NO='" & Guna2TextBox7.Text & "',A_ADDRESS='" & Guna2TextBox4.Text & "',CONTACT_NO=" & Guna2TextBox5.Text & ",EMAIL_ID='" & Guna2TextBox6.Text & "' where AID=" & Guna2TextBox1.Text & ""

        ExecuteIUD(SQL)
        CloseConn()
        MsgBox("Data Updated..")
        Guna2TextBox2.Clear()

        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox2.Focus()
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Guna2TextBox7.Clear()

        ListView1.Items.Clear()
        AutoAID()
        Company_Name()
        Guna2ImageButton1.Enabled = True
    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
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



    Private Sub Guna2TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox5.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox6.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox6.TextChanged

    End Sub

    Private Sub Guna2TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ImageButton1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        OpenConn()
        If ComboBox1.Text = "ALL" Then
            SQL = " Select * from AGENCYMANAGER"
        Else
            SQL = " Select * from AGENCYMANAGER where A_NAME='" & ComboBox1.Text & "'"
        End If
        ExecuteRead(SQL)
        While Dr.Read
            ListView1.Items.Add(Dr.GetValue(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetValue(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Dr.GetString(5))

        End While

        CloseConn()
    End Sub

    Private Sub Guna2TextBox2_TabIndexChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TabIndexChanged

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ImageButton8.Focus()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class