Public Class PURCHASE
    Dim LOC As Point
    Dim Sn As Integer
    Dim MID As Integer
    Dim AID As Integer
    Dim SnO As Integer
    Public Sub AutoSn()
        OpenConn()
        SQL = "Select Max(SN) from PURCHASE"
        ExecuteRead(SQL)
        While Dr.Read
            If IsDBNull(Dr.GetValue(0)) Then
                Sn = 1
            Else
                Sn = Dr.GetValue(0) + 1

            End If
        End While
        CloseConn()


    End Sub

    Public Sub PURID()

        OpenConn()
        SQL = "Select Max(PURID) From PURCHASE"
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
        SQL = "Select distinct(MEDICINECOMPANY) from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox2.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDType()
        ComboBox3.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MEDICINETYPE) from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "' AND MEDICINECOMPANY='" & ComboBox2.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox3.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDSIZE()
        ComboBox4.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MEDICINESIZEPOWER) from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "' AND MEDICINECOMPANY='" & ComboBox2.Text & "' AND MEDICINETYPE='" & ComboBox3.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox4.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub Company_Name()
        ComboBox5.Items.Clear()
        OpenConn()
        SQL = "Select distinct(A_NAME) from AGENCYMANAGER"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox5.Items.Add(Dr.GetString(0))
        End While
        CloseConn()
    End Sub
    Public Sub ADDRESS()
        Guna2ComboBox6.Items.Clear()
        OpenConn()
        SQL = "Select distinct(A_ADDRESS) from AGENCYMANAGER where A_NAME='" & ComboBox5.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            Guna2ComboBox6.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub CNT()
        Guna2ComboBox7.Items.Clear()
        OpenConn()
        SQL = "Select distinct(CONTACT_NO) from AGENCYMANAGER where A_NAME='" & ComboBox5.Text & "' AND A_ADDRESS='" & Guna2ComboBox6.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            Guna2ComboBox7.Items.Add(Dr.GetValue(0))
        End While
        CloseConn()

    End Sub
    Public Sub DL()
        Guna2ComboBox8.Items.Clear()
        OpenConn()
        SQL = "Select distinct(A_DL_NO) from AGENCYMANAGER where A_NAME='" & ComboBox5.Text & "' AND A_ADDRESS='" & Guna2ComboBox6.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            Guna2ComboBox8.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        Me.Hide()
        PURCHASEMASTER.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        Guna2TextBox5.Clear()

        ComboBox5.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        Guna2ComboBox6.Items.Clear()
        Guna2ComboBox7.Items.Clear()
        Guna2ComboBox8.Items.Clear()
        Guna2TextBox5.Clear()
        ListView1.Items.Clear()
        ComboBox5.Enabled = True
        Guna2ComboBox6.Enabled = True
        Guna2ComboBox7.Enabled = True
        Guna2ComboBox8.Enabled = True
        PURID()
        Company_Name()
        MEDName()
    End Sub



    Private Sub Guna2ImageButton6_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton6.Click
        Me.Hide()
        LOGINSINGUP.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        Guna2ComboBox6.Items.Clear()
        Guna2ComboBox7.Items.Clear()
        Guna2ComboBox8.Items.Clear()
        Guna2TextBox5.Clear()
        ListView1.Items.Clear()
        Guna2TextBox5.Clear()

        ComboBox5.Enabled = True
        Guna2ComboBox6.Enabled = True
        Guna2ComboBox7.Enabled = True
        Guna2ComboBox8.Enabled = True
        PURID()
        Company_Name()
        MEDName()
    End Sub

    Private Sub Guna2ImageButton9_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton9.Click
        Me.Hide()
        Menu_page.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        Guna2TextBox5.Clear()

        ComboBox5.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        Guna2ComboBox6.Items.Clear()
        Guna2ComboBox7.Items.Clear()
        Guna2ComboBox8.Items.Clear()
        Guna2TextBox5.Clear()
        ListView1.Items.Clear()
        ComboBox5.Enabled = True
        Guna2ComboBox6.Enabled = True
        Guna2ComboBox7.Enabled = True
        Guna2ComboBox8.Enabled = True
        PURID()
        Company_Name()
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

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "'"


        MEDType()
    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME ='" & ComboBox1.Text & "' And MEDICINECOMPANY='" & ComboBox2.Text & "'"

        MEDSIZE()

    End Sub

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME ='" & ComboBox1.Text & "' And MEDICINECOMPANY='" & ComboBox2.Text & "' And MEDICINETYPE='" & ComboBox3.Text & "'"

        OpenConn()
        SQL = "Select MID from MEDICINEMASTER where MEDICINENAME ='" & ComboBox1.Text & "' And MEDICINECOMPANY='" & ComboBox2.Text & "' And MEDICINETYPE='" & ComboBox3.Text & "'"

        ExecuteRead(SQL)
        While Dr.Read
            MID = Dr.GetValue(0)
        End While
        CloseConn()

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub Guna2ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)
        OpenConn()

        SQL = " Select * from AGENCYMANAGER where A_NAME='" & ComboBox5.Text & "'"
        ExecuteRead(SQL)
        CloseConn()
        ADDRESS()

    End Sub

    Private Sub PURCHASE_Load(sender As Object, e As EventArgs) Handles Me.Load
        MEDName()
        Company_Name()
        PURID()
        AutoSn()


    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME='" & ComboBox1.Text & "'"


        MEDComp()
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
    End Sub



    Private Sub Guna2ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox7.SelectedIndexChanged
        Guna2ComboBox8.Items.Clear()
        Guna2ComboBox8.Text = ""
        DL()

    End Sub

    Private Sub Guna2ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox6.SelectedIndexChanged
        Guna2ComboBox7.Items.Clear()
        Guna2ComboBox7.Text = ""
        Guna2ComboBox8.Items.Clear()
        Guna2ComboBox8.Text = ""
        CNT()
    End Sub

    Private Sub Guna2ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox8.SelectedIndexChanged


        SQL = "Select distinct(A_DL_NO) from AGENCYMANAGER where A_NAME='" & ComboBox5.Text & "' AND A_ADDRESS='" & Guna2ComboBox6.Text & "' AND CONTACT_NO='" & Guna2ComboBox7.Text & "'"

        OpenConn()
        SQL = "Select AID from AGENCYMANAGER where A_NAME='" & ComboBox5.Text & "'AND A_DL_NO='" & Guna2ComboBox8.Text & "'"

        ExecuteRead(SQL)

        While Dr.Read
            AID = Dr.GetValue(0)
        End While
        CloseConn()
    End Sub

    Private Sub Guna2ImageButton8_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton8.Click
        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter  Quentity......")
            Exit Sub
        End If


        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter Purchase Price......")
            Exit Sub
        End If
        If Trim(Guna2TextBox4.Text) = "" Then
            MsgBox("Please Enter MRP......")
            Exit Sub
        End If
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please Enter MEDname......")
            Exit Sub
        End If
        If Trim(ComboBox2.Text) = "" Then
            MsgBox("Please Enter MEDcompany......")
            Exit Sub
        End If
        If Trim(ComboBox3.Text) = "" Then
            MsgBox("Please MEDtype......")
            Exit Sub
        End If
        If Trim(ComboBox4.Text) = "" Then
            MsgBox("Please Enter MEDpower/SIZE......")
            Exit Sub
        End If

        If Trim(ComboBox5.Text) = "" Then
            MsgBox("Please Enter AGENCY NAME......")
            Exit Sub
        End If
        If Trim(Guna2ComboBox6.Text) = "" Then
            MsgBox("Please Enter AGENCY ADDRESS......")
            Exit Sub
        End If
        If Trim(Guna2ComboBox7.Text) = "" Then
            MsgBox("Please Enter AGENCY CONTACT NO........")
            Exit Sub
        End If
        If Trim(Guna2ComboBox8.Text) = "" Then
            MsgBox("Please Enter AGENCY DL.NO.......")
            Exit Sub
        End If
        OpenConn()
        SQL = "insert into PURCHASE VALUES(" & Sn & " ," & Guna2TextBox1.Text & " ,'" & ComboBox5.Text & "' ,'" & ComboBox1.Text & "' ,'" & ComboBox2.Text & "' ,'" & ComboBox3.Text & "' ,'" & ComboBox4.Text & "' , " & Guna2TextBox2.Text & " ," & Guna2TextBox3.Text & " ," & Guna2TextBox4.Text & " ,'" & DateTimePicker2.Value.ToString("dd/MM/yy") & "' , " & MID & ", " & AID & " , '" & DateTimePicker1.Value.ToString("dd/MM/yyyyyy") & "', '" & Guna2TextBox5.Text & "')"
        ExecuteIUD(SQL)
        CloseConn()
        'OpenConn()
        'SQL = "SELECT * FROM STOCK"
        'ExecuteRead(SQL)
        ''While Dr.Read

        'If Dr.HasRows = 0 Then

        '    SQL = "INSERT INTO STOCK VALUES( '" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "', " & Guna2TextBox2.Text & " , '" & Guna2TextBox3.Text & "', '" & Guna2TextBox4.Text & "' ,  " & MID & ",'" & Guna2TextBox5.Text & "' , #" & DateTimePicker1.Value.ToString("dd/MM/yy") & "#)"
        '    ExecuteIUD(SQL)
        '    CloseConn()
        'Else
        '    CloseConn()
        '    OpenConn()
        '    SQL = "SELECT * FROM STOCK"
        '    ExecuteRead(SQL)
        '    While Dr.Read

        '        If Trim(ComboBox1.Text) = Dr.GetString(0) And Trim(ComboBox2.Text) = Dr.GetString(1) And Trim(ComboBox3.Text) = Dr.GetString(2) And Trim(ComboBox4.Text) = Dr.GetString(3) And Trim(Guna2TextBox5.Text) = Dr.GetString(8) And DateTimePicker1.Value = Dr.GetValue(9) Then
        '            CloseConn()

        '            OpenConn()
        '            SQL = "Select Sum(QUANTITY) from PURCHASE where MID = " & MID & " AND EXPDATE=#" & DateTimePicker1.Value & "# AND BATCHNO ='" & Guna2TextBox5.Text & "'"
        '            ExecuteRead(SQL)
        '            While Dr.Read
        '                If IsDBNull(Dr.GetValue(0)) Then
        '                    MsgBox("MEDICINE NOT AVAILABLE...")
        '                    ComboBox1.Items.Clear()
        '                    ComboBox2.Items.Clear()
        '                    ComboBox3.Items.Clear()
        '                    ComboBox4.Items.Clear()
        '                    Guna2TextBox4.Clear()

        '                    CloseConn()
        '                    MEDName()
        '                    ComboBox1.Focus()
        '                    Exit Sub
        '                Else
        '                    PURQTY = Dr.GetValue(0)

        '                End If

        '            End While

        '            CloseConn()



        '            OpenConn()

        '            SQL = "select Sum(QUANTITY) FROM STOCK where MID=" & MID & " AND EXPDATE=#" & DateTimePicker1.Value & "# AND BATCHNO ='" & Guna2TextBox5.Text & "'"
        '            ExecuteRead(SQL)
        '            While Dr.Read
        '                If IsDBNull(Dr.GetValue(0)) Then
        '                    SQTY = 0
        '                Else
        '                    SQTY = Dr.GetValue(0)
        '                End If
        '            End While
        '            CloseConn()

        '            LQTY = PURQTY + SQTY
        '            OpenConn()
        '            SQL = "UPDATE STOCK SET QUANTITY =" & LQTY & " WHERE MID =" & MID & " AND EXPDATE=#" & DateTimePicker1.Value & "# AND BATCHNO ='" & Guna2TextBox5.Text & "'"
        '            ExecuteIUD(SQL)
        '            CloseConn()

        '            MsgBox("njjh")
        '        Else


        '            CloseConn()

        '            OpenConn()
        '            SQL = "INSERT INTO STOCK VALUES( '" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "', " & Guna2TextBox2.Text & " , '" & Guna2TextBox3.Text & "', '" & Guna2TextBox4.Text & "' ,  " & MID & ",'" & Guna2TextBox5.Text & "' , #" & DateTimePicker1.Value.ToString("dd/MM/yy") & "#)"
        '            ExecuteRead(SQL)


        '        End If

        '    End While


        'End If

        'CloseConn()
        PQTY = Guna2TextBox2.Text
        IC = 0

        OpenConn()

        SQL = "SELECT QUANTITY FROM STOCK WHERE MID=" & MID & " AND BATCHNO ='" & Guna2TextBox5.Text & "'"
        ExecuteNonQueryRead(SQL)
        While Dr.Read
            IC = 1
            DQTY = Dr.GetValue(0)
        End While
        CloseConn()
        If IC = 0 Then
            'INSERT INTO STOCK_DETAILS

            OpenConn()
            SQL = "INSERT INTO STOCK VALUES( '" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "', " & Guna2TextBox2.Text & " , '" & Guna2TextBox3.Text & "', '" & Guna2TextBox4.Text & "' ,  " & MID & ",'" & Guna2TextBox5.Text & "' , '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "')"

            ExecuteNonQueryQueryIUD(SQL)
            CloseConn()
        ElseIf IC = 1 Then
            TQTY = DQTY + PQTY
            OpenConn()
            SQL = "UPDATE STOCK SET QUANTITY=" & TQTY & " WHERE MID=" & MID & "AND BATCHNO ='" & Guna2TextBox5.Text & "'"
            ExecuteNonQueryQueryIUD(SQL)
            CloseConn()
        End If
        ListView1.Items.Add(Sn)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox1.Text)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(AID)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox1.Text)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox2.Text)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox3.Text)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox4.Text)

        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox2.Text)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox3.Text)


        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox4.Text)


        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DateTimePicker2.Text)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(MID)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DateTimePicker1.Text)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox5.Text)
        Sn = Sn + 1
        ComboBox5.Enabled = False
        Guna2ComboBox6.Enabled = False
        Guna2ComboBox7.Enabled = False
        Guna2ComboBox8.Enabled = False
        Guna2TextBox5.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""

        MEDName()

    End Sub

    Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        Guna2TextBox5.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        Guna2ComboBox6.Items.Clear()
        Guna2ComboBox7.Items.Clear()
        Guna2ComboBox8.Items.Clear()

        ListView1.Items.Clear()
        ComboBox5.Enabled = True
        Guna2ComboBox6.Enabled = True
        Guna2ComboBox7.Enabled = True
        Guna2ComboBox8.Enabled = True
        PURID()
        Company_Name()
        MEDName()
    End Sub

    Private Sub Guna2ImageButton10_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton10.Click
        OpenConn()
        SQL = "Delete from PURCHASE where PURID=" & Guna2TextBox1.Text & ""
        ExecuteIUD(SQL)
        CloseConn()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        Guna2TextBox5.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        Guna2ComboBox6.Items.Clear()
        Guna2ComboBox7.Items.Clear()
        Guna2ComboBox8.Items.Clear()
        Guna2TextBox5.Clear()
        ListView1.Items.Clear()
        ComboBox5.Enabled = True
        Guna2ComboBox6.Enabled = True
        Guna2ComboBox7.Enabled = True
        Guna2ComboBox8.Enabled = True
        Company_Name()
        MEDName()
    End Sub



    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        ComboBox3.Text = ""
        ComboBox3.Items.Clear()
        ComboBox4.Text = ""
        ComboBox4.Items.Clear()
        MEDComp()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Text = ""
        ComboBox3.Items.Clear()
        ComboBox4.Text = ""
        ComboBox4.Items.Clear()
        MEDType()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.Text = ""
        ComboBox4.Items.Clear()
        MEDSIZE()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        SQL = "Select * from MEDICINEMASTER where MEDICINENAME ='" & ComboBox1.Text & "' And MEDICINECOMPANY='" & ComboBox2.Text & "' And MEDICINETYPE='" & ComboBox3.Text & "'"

        OpenConn()
        SQL = "Select MID from MEDICINEMASTER where MEDICINENAME ='" & ComboBox1.Text & "' And MEDICINECOMPANY='" & ComboBox2.Text & "' And MEDICINETYPE='" & ComboBox3.Text & "'"

        ExecuteRead(SQL)
        While Dr.Read
            MID = Dr.GetValue(0)
        End While
        CloseConn()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        OpenConn()

        SQL = " Select * from AGENCYMANAGER where A_NAME='" & ComboBox5.Text & "'"
        ExecuteRead(SQL)
        CloseConn()
        Guna2ComboBox6.Items.Clear()
        Guna2ComboBox6.Text = ""
        Guna2ComboBox7.Items.Clear()
        Guna2ComboBox7.Text = ""
        Guna2ComboBox8.Items.Clear()
        Guna2ComboBox8.Text = ""
        ADDRESS()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown

    End Sub

    Private Sub ComboBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ComboBox6.Focus()
        End If
    End Sub

    Private Sub Guna2ComboBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2ComboBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ComboBox7.Focus()
        End If
    End Sub

    Private Sub Guna2ComboBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2ComboBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ComboBox8.Focus()
        End If
    End Sub

    Private Sub Guna2ComboBox8_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2ComboBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
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
            ComboBox4.Focus()
        End If
    End Sub

    Private Sub ComboBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox2.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Dim strAllowedChars As String = "0123456789() -+ "
        If Len(Guna2TextBox2.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox2.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox2.Text(i)) = 0 Then
                    MsgBox("Please Enter Number.")
                    Guna2TextBox2.Clear()
                    Guna2TextBox2.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox3.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        Dim strAllowedChars As String = "0123456789() -+ "
        If Len(Guna2TextBox3.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox3.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox3.Text(i)) = 0 Then
                    MsgBox("Please Enter Number.")
                    Guna2TextBox3.Clear()
                    Guna2TextBox3.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub Guna2TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox4.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged
        Dim strAllowedChars As String = "0123456789() -+ "
        If Len(Guna2TextBox4.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox4.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox4.Text(i)) = 0 Then
                    MsgBox("Please Enter Number.")
                    Guna2TextBox4.Clear()
                    Guna2TextBox4.Focus()
                    Exit Sub
                End If
            Next
        End If
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
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown

        If e.KeyCode = Keys.Enter Then
            Guna2ImageButton8.Focus()
        End If
    End Sub
End Class