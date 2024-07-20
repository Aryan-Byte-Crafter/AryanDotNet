Imports System.Text.RegularExpressions
Public Class SIGNUP_PAGE
    Dim Typeofshop As String
    Dim LOC As Point




    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox("Please Enter Owner Name")
            TextBox1.Focus()
        End If
        If Trim(TextBox2.Text) = "" Then
            MsgBox("Please Enter Email Id....")
            TextBox2.Focus()
            Exit Sub
        End If
        If Trim(TextBox3.Text) = "" Then
            MsgBox("Please Enter Phone No>")
            TextBox3.Focus()
        End If
        If Trim(TextBox4.Text) = "" Then
            MsgBox("Please PAN Card NO. ....")
            TextBox4.Focus()
            Exit Sub
        End If
        If Trim(TextBox5.Text) = "" Then
            MsgBox("Please Enter Buissness Name")
            TextBox5.Focus()
        End If
        If Trim(TextBox6.Text) = "" Then
            MsgBox("Please Enter Passowrd....")
            TextBox6.Focus()
            Exit Sub
        End If
        If Trim(TextBox7.Text) = "" Then
            MsgBox("Please Enter Licence No.")
            TextBox7.Focus()
        End If
        If Trim(TextBox8.Text) = "" Then
            MsgBox("Please Enter Address....")
            TextBox8.Focus()
            Exit Sub
        End If
        If Trim(TextBox9.Text) = "" Then
            MsgBox("Please Enter TYPE OF BUSSINESS ")
            TextBox9.Focus()
        End If
        If Trim(TextBox10.Text) = "" Then
            MsgBox("Please Enter User Name/ID....")
            TextBox10.Focus()
            Exit Sub
        End If
        '
        Dim PAN = Trim(TextBox4.Text)
        Dim PART As String = "^[A-Z]{5}\d{4}[A-Z]{1}$"
        Dim PANMatch As Match = Regex.Match(PAN, PART)
        Dim DLNUM = Trim(TextBox7.Text)
        Dim PATER As String = "^\d{2}[A-Z]/\d{4}/\d{2}/\d{4}$"
        Dim DLNUMMatch As Match = Regex.Match(DLNUM, PATER)
        Dim phone = Trim(TextBox3.Text)
        Dim pat As String = "^(\ +91[\-\s]?)?[0]?(91)?[.,7896]\d{9}$"
        Dim phoneMatch As Match = Regex.Match(phone, pat)

        Dim emailaddress = Trim(TextBox2.Text)
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)

        If emailAddressMatch.Success And phoneMatch.Success And DLNUMMatch.Success And PANMatch.Success Then
            'emailaddresscheck = True
            LOGIN.Show()
            OpenConn()
            SQL = "insert into SIGNUP_PAGE values('" & TextBox1.Text & "' , '" & TextBox10.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "' ,'" & TextBox4.Text & "' ,'" & TextBox5.Text & "' ,'" & TextBox9.Text & "' ,'" & TextBox6.Text & "' ,'" & TextBox7.Text & "' , '" & Guna2DateTimePicker2.Text & "','" & TextBox8.Text & "' )"
            ExecuteRead(SQL)
            CloseConn()
            'MsgBox("data saved")
            Me.Hide()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
        Else
            If Not emailAddressMatch.Success Then
                MsgBox("Invalid Email address", MsgBoxStyle.Information)
            End If
            If Not phoneMatch.Success Then
                MsgBox("Invalid PHONE NUMBER", MsgBoxStyle.Information)
            End If
            If Not DLNUMMatch.Success Then
                MsgBox("Invalid LICENCE NUMBER", MsgBoxStyle.Information)
            End If
            If Not PANMatch.Success Then
                MsgBox("Invalid PAN NUMBER", MsgBoxStyle.Information)
            End If
        End If


    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        LOGINSINGUP.Show()

    End Sub



    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        LOGIN.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub


    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim strAllowedChars As String = "0123456789() -+ "
        If Len(TextBox3.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(TextBox3.Text) - 1
                If InStr(1, strAllowedChars, TextBox3.Text(i)) = 0 Then
                    MsgBox("Please Enter Number.")
                    TextBox3.Clear()
                    TextBox3.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub


    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox5.Focus()
        End If
    End Sub


    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox9.Focus()
        End If
    End Sub



    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox6.Focus()
        End If
    End Sub



    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.Focus()
        End If
    End Sub


    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub Guna2DateTimePicker2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2DateTimePicker2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox8.Focus()
        End If
    End Sub



    Private Sub TextBox10_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Focus()
        End If
    End Sub



    Private Sub TextBox8_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2GradientButton3.Focus()
        End If
    End Sub

End Class