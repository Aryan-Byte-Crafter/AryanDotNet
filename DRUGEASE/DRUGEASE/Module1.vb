Imports System.Data.OleDb
Module Module1
    Dim Constring As String
    Public Con As New OleDbConnection
    Public Cmd As New OleDbCommand
    Public Dr As OleDbDataReader
    Public SQL As String
    Public Sn, M_ID, A_ID, PQTY, UNITP, TOTALP, IC, TQTY, DQTY As Integer
    Public PName, PComp, PTypesize As Integer
    Public PURQTY, SQTY, LQTY As Integer




    Public Sub Connection()
        Constring = "Provider=Microsoft.jet.OLEDB.4.0; Data Source=D:\medical management software\DRUGEASE.mdb"
        Con = New OleDbConnection(Constring)
        Con.Open()
    End Sub
    Public Sub ExecuteIUD(ByVal SQLs As String)
        On Error GoTo INVENTORY_MANAGEMENT
        Cmd = New OleDbCommand(SQL, Con)
        Cmd.ExecuteNonQuery()
        Exit Sub

INVENTORY_MANAGEMENT:
        MsgBox(Err.Description)
    End Sub
    Public Sub ExecuteRead(ByVal SQLs As String)
        On Error GoTo INVENTORY_MANAGEMENT
        Cmd = New OleDbCommand(SQL, Con)
        Dr = Cmd.ExecuteReader
        Exit Sub

INVENTORY_MANAGEMENT:
        MsgBox(Err.Description)
    End Sub


    Public Sub OpenConn()
        If (Con.State = ConnectionState.Open) Then
            Con.Close()
        Else
            Connection()
        End If
    End Sub

    Public Sub CloseConn()
        If (Con.State = ConnectionState.Open) Then
            Con.Close()
        End If
    End Sub
    Public Sub ExecuteNonQueryRead(ByVal SQL As String)
        On Error GoTo INVENTORY_MANAGEMENT
        Cmd = New OleDbCommand(SQL, Con)
        Dr = Cmd.ExecuteReader
        Exit Sub

INVENTORY_MANAGEMENT:
        MsgBox(Err.Description)
    End Sub


    Public Sub ExecuteNonQueryQueryIUD(ByVal SQL As String)
        On Error GoTo INVENTORY_MANAGEMENT
        Cmd = New OleDbCommand(SQL, Con)
        Cmd.ExecuteNonQuery()
        Exit Sub

INVENTORY_MANAGEMENT:
        MsgBox(Err.Description)
    End Sub
End Module
