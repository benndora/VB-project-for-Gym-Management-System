Imports System.Data.OleDb

Public Class Form16
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim c, c2 As Integer
    Dim coa As String
    Dim acc1, acc2 As Long
    Public myconnection As OleDbConnection = New OleDbConnection
    Public myconnection2 As OleDbConnection = New OleDbConnection
    Public myconnection3 As OleDbConnection = New OleDbConnection
    Public myconnection4 As OleDbConnection = New OleDbConnection
    Public myconnection5 As OleDbConnection = New OleDbConnection

    Public dr As OleDbDataReader
    Public dr2 As OleDbDataReader
    Public dr3 As OleDbDataReader
    Public dr4 As OleDbDataReader


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\plan.mdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "SELECT * FROM plans WHERE ([Name] = '" & TextBox1.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Cost").ToString
            TextBox5.Text = dr("Coach").ToString
        End While
        c = Long.Parse(TextBox4.Text)
        coa = (TextBox5.Text)
        dr.Close()
        myconnection.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\creditcard.mdb"
        connstring = provider & datafile
        myconnection3.ConnectionString = connstring
        myconnection3.Open()

        Dim str As String
        Dim str3 As String
        str = "SELECT * FROM creditcards WHERE cardno = " & TextBox3.Text
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection3)

        'procedure 1
        acc1 = acc1 - c
        str3 = "Update creditcards Set balance='" & acc1 & "' where cardno=  " & TextBox3.Text
        Dim cmd3 As OleDbCommand = New OleDbCommand(str3, myconnection3)
        Try
            cmd3.ExecuteNonQuery()
            MsgBox("amount taken from user")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        myconnection3.Close()

            'procedure 2
        myconnection5.ConnectionString = connstring
        myconnection5.Open()
        Dim str4 As String
        acc2 = acc2 + c
        str4 = "Update creditcards Set balance='" & acc2 & "' where ([username]=  '" & TextBox5.Text & "')"
        Dim cmd4 As OleDbCommand = New OleDbCommand(str4, myconnection5)
        Try
            cmd4.ExecuteNonQuery()
            MsgBox("amount deposited to coach")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconnection5.Close()


    End Sub

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\creditcard.mdb"
        connstring = provider & datafile

        myconnection2.ConnectionString = connstring
        myconnection4.ConnectionString = connstring

        Try
            myconnection2.Open()
            Dim str5 As String
            str5 = "SELECT * FROM creditcards WHERE ([username] = '" & TextBox2.Text & "')"
            Dim cmd5 As OleDbCommand = New OleDbCommand(str5, myconnection2)
            dr4 = cmd5.ExecuteReader
            While dr4.Read()
                TextBox6.Text = dr4("balance").ToString
            End While
            acc1 = Long.Parse(TextBox6.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr4.Close()
        myconnection2.Close()

        Try
            myconnection4.Open()
            Dim str2 As String
            str2 = "SELECT * FROM creditcards WHERE ([username] = '" & TextBox5.Text & "')"
            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myconnection4)
            dr3 = cmd2.ExecuteReader
            While dr3.Read()
                TextBox7.Text = dr3("balance").ToString
            End While
            acc2 = Long.Parse(TextBox7.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr3.Close()
        myconnection4.Close()
    End Sub


End Class