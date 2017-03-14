Imports System.Data.OleDb

Public Class Form12
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim loginerror As String
    Dim str2 As String
    Dim a1 As Long
    Dim a2 As Long
    Public myconnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\creditcard.mdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        a2 = (TextBox1.Text)
        str = "SELECT * FROM creditcards WHERE cardno =" & a2
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Try
            dr = cmd.ExecuteReader
            While dr.Read()
                TextBox3.Text = dr("balance").ToString
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconnection.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\creditcard.mdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()

        a1 = Long.Parse(TextBox3.Text)
        a1 = a1 + (Long.Parse(TextBox4.Text))

        str2 = "Update creditcards Set balance='" & a1 & "' where cardno= " & TextBox1.Text
        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myconnection)
        Try
            cmd2.ExecuteNonQuery()
            Me.Hide()
            MsgBox("stats updated successfully")
            myconnection.Close()
            'TextBox1.Clear()
            'TextBox2.Clear()
            'TextBox3.Clear()
            'TextBox4.Clear()
            TextBox1.Text = " "
            TextBox3.Text = " "
            TextBox4.Text = " "

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconnection.Close()
    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\creditcard.mdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()

        a1 = Long.Parse(TextBox3.Text)
        a1 = a1 - (Long.Parse(TextBox4.Text))

        str2 = "Update creditcards Set balance='" & a1 & "' where cardno=  " & TextBox1.Text
        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myconnection)
        Try
            cmd2.ExecuteNonQuery()
            Me.Hide()
            MsgBox("stats updated successfully")
            myconnection.Close()
            'TextBox1.Clear()
            'TextBox2.Clear()
            'TextBox3.Clear()
            'TextBox4.Clear()
            TextBox1.Text = " "
            TextBox3.Text = " "
            TextBox4.Text = " "

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class