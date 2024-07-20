Public Class LOGIN


    Dim LOC As Point



    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        OpenConn()

        SQL = "SELECT bussiness_name FROM SIGNUP_PAGE WHERE User_d='" & TextBox1.Text & "' AND password='" & TextBox2.Text & "' "
        ExecuteRead(SQL)
        While Dr.Read
            If IsDBNull(Dr) Then
                MsgBox("NO DATA EXIST")
            Else
                SALE.BNAME = Dr(0)

            End If
        End While
        CloseConn()

        If Trim(TextBox1.Text) = "" Then
            MsgBox("Please Enter User Name")
            TextBox1.Focus()
        End If
        If Trim(TextBox2.Text) = "" Then
            MsgBox("Please Enter Passowrd....")
            TextBox2.Focus()
            Exit Sub
        End If
        OpenConn()
        SQL = "Select * from SIGNUP_PAGE"
        ExecuteRead(SQL)
        While Dr.Read
            If Trim(TextBox1.Text) = Dr.GetString(1) And Trim(TextBox2.Text) = Dr.GetString(7) Then
                CloseConn()
                Me.Hide()
                Menu_page.Show()

                Exit Sub

                TextBox1.Clear()
                TextBox2.Clear()

            End If

        End While
        CloseConn()

        TextBox1.Focus()


        TextBox1.Clear()
        TextBox2.Clear()
        MsgBox("Please Enter Valid User Name & Password")


    End Sub




    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        LOGINSINGUP.Show()
        TextBox1.Clear()
        TextBox2.Clear()



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

    Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        End
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Focus()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        ' Determine whether the key entered is the F1 key. If it is, display Help.
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub textBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        ' Determine whether the key entered is the F1 key. If it is, display Help.
        If e.KeyCode = Keys.Enter Then
            Guna2GradientButton3.Focus()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SIGNUP_PAGE.Show()
        Me.Hide()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub LOGIN_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox1.Focus()

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class