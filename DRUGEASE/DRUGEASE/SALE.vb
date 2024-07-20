Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Globalization
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class SALE
    Dim LOC As Point
    Dim NAME As String
    Dim Sn As Integer
    Dim MID As Integer
    Dim MRPS As String
    Dim PRPS As String
    Dim QUANT As Integer
    Dim MRATE As Integer
    Dim MTOTAL As Integer
    Dim TOTAL As Integer
    Dim ATOTAL As Integer
    Public Property BNAME As String



    Public Sub AutoSn()
        OpenConn()
        SQL = "Select Max(SNO) from SALE"
        ExecuteRead(SQL)
        While Dr.Read
            If IsDBNull(Dr.GetValue(0)) Then
                Sn = 1
            Else
                Sn = Dr.GetValue(0) + 1

            End If
        End While
        CloseConn()
        BNAME = NAME


    End Sub

    Public Sub SID()

        OpenConn()
        SQL = "Select Max(SID) From SALE"
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
        SQL = "Select distinct(MNAME) from STOCK"
        ExecuteRead(SQL)
        While Dr.Read()
            ComboBox1.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDComp()
        ComboBox2.Items.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        OpenConn()
        SQL = "Select distinct(MCOMPANY) from STOCK where MNAME='" & ComboBox1.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox2.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDType()
        ComboBox3.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MTYPE) from STOCK where MNAME='" & ComboBox1.Text & "' AND MCOMPANY='" & ComboBox2.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox3.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub MEDSIZE()
        ComboBox4.Items.Clear()
        OpenConn()
        SQL = "Select distinct(MSIZEPOWER) from STOCK where MNAME='" & ComboBox1.Text & "' AND MCOMPANY='" & ComboBox2.Text & "' AND MTYPE='" & ComboBox3.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox4.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub
    Public Sub EXPDATE()
        ComboBox5.Items.Clear()
        OpenConn()
        SQL = "Select distinct(EXPDATE) from STOCK where MNAME='" & ComboBox1.Text & "' AND MCOMPANY='" & ComboBox2.Text & "' AND MTYPE='" & ComboBox3.Text & "'AND MSIZEPOWER='" & ComboBox4.Text & "' "
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox5.Items.Add(Dr(0))
        End While
        CloseConn()

    End Sub
    Public Sub BATCHNO()
        ComboBox6.Items.Clear()
        OpenConn()
        SQL = "Select distinct(BATCHNO) from STOCK where MNAME='" & ComboBox1.Text & "' AND MCOMPANY='" & ComboBox2.Text & "' AND MTYPE='" & ComboBox3.Text & "'AND MSIZEPOWER='" & ComboBox4.Text & "' AND EXPDATE=#" & ComboBox5.Text & "#"
        ExecuteRead(SQL)
        While Dr.Read
            ComboBox6.Items.Add(Dr.GetString(0))
        End While
        CloseConn()

    End Sub


    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2ImageButton6_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton6.Click
        Me.Hide()
        LOGINSINGUP.Show()
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox8.Clear()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        OpenConn()
        SQL = "Delete * FROM BILL"
        ExecuteIUD(SQL)
        CloseConn()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        Guna2TextBox7.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ListView1.Items.Clear()
        Guna2TextBox2.Enabled = True
        Guna2TextBox3.Enabled = True
        MEDName()
        SID()
    End Sub

    Private Sub Guna2ImageButton9_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton9.Click
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        Me.Hide()
        Guna2TextBox8.Clear()
        Menu_page.Show()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        Guna2TextBox7.Clear()
        ListView1.Items.Clear()
        Guna2TextBox2.Enabled = True
        Guna2TextBox3.Enabled = True
        MEDName()
        SID()
        OpenConn()
        SQL = "Delete * FROM BILL"
        ExecuteIUD(SQL)
        CloseConn()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        Me.Hide()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        SALESMASTER.Show()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox8.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        Guna2TextBox7.Clear()
        ListView1.Items.Clear()
        Guna2TextBox2.Enabled = True
        Guna2TextBox3.Enabled = True
        MEDName()
        SID()
        OpenConn()
        SQL = "Delete * FROM BILL"
        ExecuteIUD(SQL)
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

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub SALE_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConn()
        SQL = "Delete * FROM BILL"
        ExecuteIUD(SQL)
        CloseConn()

        MEDName()
        AutoSn()

        SID()


    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click

        'Dim myReport As New ReportDocument()
        'myReport.Load("D:\medical management software\DRUGEASE\DRUGEASE\CrystalReport2.rpt")
        ''Pass database and Parameter info here
        'myReport.PrintToPrinter(1, True, 0, 0) 'This prints one copy of all pages to the default printer, and collates them

    End Sub

    Private Sub Guna2ImageButton8_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton8.Click

        If Trim(Guna2TextBox2.Text) = "" Then
            MsgBox("Please Enter coustomer name..")
            Guna2TextBox2.Focus()
            Exit Sub
        End If
        If Trim(Guna2TextBox3.Text) = "" Then
            MsgBox("Please Enter coustomer no...")
            Guna2TextBox3.Focus()
            Exit Sub
        End If
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please Select Product Name..")
            ComboBox1.Focus()
            Exit Sub
        End If
        If Trim(ComboBox2.Text) = "" Then
            MsgBox("Please Select Product Company Name..")
            ComboBox2.Focus()
            Exit Sub
        End If
        If Trim(ComboBox3.Text) = "" Then
            MsgBox("Please Select Product Type..")
            ComboBox3.Focus()
            Exit Sub
        End If
        If Trim(ComboBox4.Text) = "" Then
            MsgBox("Please Select Product Size/power..")
            ComboBox4.Focus()
            Exit Sub
        End If
        If Trim(ComboBox6.Text) = "" Then
            MsgBox("Please Enter batch no. ...")
            ComboBox6.Focus()
            Exit Sub
        End If
        If Trim(Guna2TextBox5.Text) = "" Then
            MsgBox("Please Enter MRP...")
            Guna2TextBox5.Focus()
            Exit Sub
        End If
        If Trim(Guna2TextBox6.Text) = "" Then
            MsgBox("Please Enter RATE ...")
            Guna2TextBox6.Focus()
            Exit Sub
        End If
        If Trim(Guna2TextBox7.Text) = "" Then
            MsgBox("Please Enter QUANTITY...")
            Guna2TextBox7.Focus()
            Exit Sub
        End If

        QUANT = Guna2TextBox7.Text
        MRATE = Guna2TextBox6.Text
        MTOTAL = MRATE * QUANT
        If ATOTAL = 0 Then
            ATOTAL = MTOTAL
        Else
            ATOTAL = MTOTAL + ATOTAL
        End If
        Dim phone = Trim(Guna2TextBox3.Text)
        Dim pat As String = "^(\ +91[\-\s]?)?[0]?(91)?[6789]\d{9}$"
        Dim phoneMatch As Match = Regex.Match(phone, pat)
        If phoneMatch.Success Then

            OpenConn()
            SQL = "insert into BILL values (" & Sn & " , " & Guna2TextBox1.Text & ", #" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "# , '" & Guna2TextBox2.Text & "' , '" & ComboBox1.Text & "' ,'" & ComboBox5.Text & "' ,'" & ComboBox6.Text & "','" & Guna2TextBox5.Text & "'," & Guna2TextBox7.Text & " , " & MTOTAL & ", '" & NAME & "'," & ATOTAL & ")"
            ExecuteRead(SQL)
            CloseConn()
            OpenConn()
            SQL = "insert into SALE values (" & Sn & " , " & Guna2TextBox1.Text & ", #" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "# , '" & Guna2TextBox2.Text & "' ,'" & Guna2TextBox3.Text & " ', '" & ComboBox1.Text & "' , '" & ComboBox2.Text & "', '" & ComboBox3.Text & "', '" & ComboBox4.Text & "', '" & ComboBox5.Text & "' ,'" & ComboBox6.Text & "','" & Guna2TextBox5.Text & "','" & Guna2TextBox6.Text & "'," & Guna2TextBox7.Text & " , " & M_ID & ")"
            ExecuteRead(SQL)
            CloseConn()

            PQTY = Guna2TextBox7.Text
            IC = 0
            OpenConn()
            SQL = "SELECT QUANTITY FROM STOCK WHERE MID=" & M_ID & " AND BATCHNO ='" & ComboBox6.Text & "'"
            ExecuteNonQueryRead(SQL)
            While Dr.Read
                IC = 1
                DQTY = Dr.GetValue(0)
            End While
            CloseConn()
            If IC = 0 Then

            ElseIf IC = 1 Then
                TQTY = DQTY - PQTY
                OpenConn()
                SQL = "UPDATE STOCK SET QUANTITY=" & TQTY & " WHERE MID=" & M_ID & " AND BATCHNO ='" & ComboBox6.Text & "'"
                ExecuteNonQueryQueryIUD(SQL)
                CloseConn()
            End If
            If TQTY = 0 Then

                OpenConn()
                SQL = "Delete from STOCK where MID=" & M_ID & " AND BATCHNO ='" & ComboBox6.Text & "'"
                ExecuteIUD(SQL)
                CloseConn()

            End If
            Guna2TextBox3.Enabled = False
            Guna2TextBox2.Enabled = False
            ListView1.Items.Add(Sn)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox1.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(DateTimePicker1.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox2.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox3.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox1.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox2.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox3.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox4.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox5.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(ComboBox6.Text)

            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox5.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox6.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Guna2TextBox7.Text)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(M_ID)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(MTOTAL)
            Sn = Sn + 1
            Guna2TextBox2.Enabled = False
            Guna2TextBox3.Enabled = False
            Guna2TextBox5.Enabled = True
            Guna2TextBox8.Enabled = True
            Guna2TextBox4.Enabled = True
            Guna2TextBox4.Clear()
            ComboBox5.Items.Clear()
            ComboBox6.Items.Clear()
            Guna2TextBox5.Clear()
            Guna2TextBox6.Clear()
            Guna2TextBox7.Clear()
            Guna2TextBox8.Clear()
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox4.Items.Clear()
            ComboBox5.Items.Clear()
            ComboBox6.Items.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            ComboBox5.Text = ""
            ComboBox6.Text = ""
            MEDName()
            SID()

        Else
            MsgBox("Invalid Email address or Phone number.", MsgBoxStyle.Information)
            Guna2TextBox3.Focus()
            MEDName()

        End If

        'End If


    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox8.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        Guna2TextBox7.Clear()
        ListView1.Items.Clear()
        Guna2TextBox2.Enabled = True
        Guna2TextBox3.Enabled = True
        MEDName()
        SID()
        OpenConn()
        SQL = "Delete * FROM BILL"
        ExecuteIUD(SQL)
        CloseConn()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ImageButton10_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton10.Click

        OpenConn()
        SQL = "Delete from SALE where SID=" & Guna2TextBox1.Text & ""
        ExecuteIUD(SQL)
        CloseConn()
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        Guna2TextBox7.Clear()
        Guna2TextBox8.Clear()
        ListView1.Items.Clear()
        Guna2TextBox2.Enabled = True
        Guna2TextBox3.Enabled = True
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        MEDName()
        OpenConn()
        SQL = "Delete * FROM BILL"
        ExecuteIUD(SQL)
        CloseConn()
    End Sub

    Private Sub Guna2ComboBox1_StyleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True



        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        ComboBox4.Items.Clear()
        ComboBox4.Text = ""
        ComboBox5.Items.Clear()
        ComboBox5.Text = ""
        ComboBox6.Items.Clear()
        ComboBox6.Text = ""
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        MEDComp()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        ComboBox4.Items.Clear()
        ComboBox4.Text = ""
        ComboBox5.Items.Clear()
        ComboBox5.Text = ""
        ComboBox6.Items.Clear()
        ComboBox6.Text = ""
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        MEDType()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        ComboBox4.Items.Clear()
        ComboBox4.Text = ""
        ComboBox5.Items.Clear()
        ComboBox5.Text = ""
        ComboBox6.Items.Clear()
        ComboBox6.Text = ""
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        MEDSIZE()

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        ComboBox5.Items.Clear()
        ComboBox5.Text = ""
        ComboBox6.Items.Clear()
        ComboBox6.Text = ""
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()
        EXPDATE()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        ComboBox6.Items.Clear()
        ComboBox6.Text = ""
        Guna2TextBox4.Enabled = True
        Guna2TextBox4.Clear()

        BATCHNO()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Guna2TextBox5.Clear()
        Guna2TextBox8.Clear()
        Guna2TextBox5.Enabled = True
        Guna2TextBox8.Enabled = True
        Guna2TextBox4.Clear()
        Guna2TextBox4.Enabled = True
        OpenConn()
        SQL = "SELECT MID  from PURCHASE where MNAME ='" & ComboBox1.Text & "'AND MCOMPANY='" & ComboBox2.Text & "' AND MTYPE='" & ComboBox3.Text & "' AND MSIZEPOWER='" & ComboBox4.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            M_ID = Dr.GetValue(0)
        End While
        CloseConn()

        OpenConn()

        SQL = "select Sum(QUANTITY) FROM STOCK where MID=" & M_ID & " AND EXPDATE=#" & ComboBox5.Text & "# AND BATCHNO ='" & ComboBox6.Text & "'"
        ExecuteRead(SQL)
        While Dr.Read
            If IsDBNull(Dr.GetValue(0)) Then
                SQTY = 0
            Else
                SQTY = Dr.GetValue(0)
            End If
        End While
        CloseConn()
        OpenConn()
        SQL = "Select distinct(MRP) from STOCK where MID = " & M_ID & " AND EXPDATE=#" & ComboBox5.Text & "# AND BATCHNO ='" & ComboBox6.Text & "'    "
        ExecuteRead(SQL)
        While Dr.Read

            MRPS = Dr.GetString(0)
        End While
        CloseConn()
        OpenConn()
        SQL = "Select distinct(pur_price) from STOCK where MID = " & M_ID & " AND EXPDATE=#" & ComboBox5.Text & "# AND BATCHNO ='" & ComboBox6.Text & "'    "
        ExecuteRead(SQL)
        While Dr.Read

            PRPS = Dr.GetString(0)
        End While
        CloseConn()

        Guna2TextBox5.Enabled = False
        Guna2TextBox5.Text = MRPS
        Guna2TextBox8.Enabled = False
        Guna2TextBox8.Text = SQTY
        Guna2TextBox4.Enabled = False
        Guna2TextBox4.Text = PRPS

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox3.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox2.Focus()
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
            ComboBox5.Focus()
        End If
    End Sub

    Private Sub ComboBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox6.Focus()
        End If
    End Sub

    Private Sub ComboBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2TextBox6.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox7_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox7.TextChanged
        Dim strAllowedChars As String = "0123456789() -+ "
        If Len(Guna2TextBox7.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(Guna2TextBox7.Text) - 1
                If InStr(1, strAllowedChars, Guna2TextBox7.Text(i)) = 0 Then
                    MsgBox("Please Enter Number.")
                    Guna2TextBox7.Clear()
                    Guna2TextBox7.Focus()
                    Exit Sub
                End If
            Next
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

    Private Sub Guna2TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2ImageButton8.Focus()
        End If
    End Sub


End Class