
Imports System.Data.OleDb

Public Class Form8
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        'dataFile = "C:\Users\Admin\Documents\Visual Studio 2012\Projects\JK\JK\bin\Debug\JK.mdb"
        'connString = provider & dataFile
        'myConnection.ConnectionString = connString
        myConnection.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source ='" & Application.StartupPath & "\healthinfo.mdb'"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myConnection.Open()
        Dim str As String
        str = "Update healthinfos Set [username]='" & TextBox1.Text & "',age= '" & TextBox2.Text & "',height='" & TextBox4.Text & "',weight='" & TextBox4.Text & "' where username=  '" & TextBox1.Text & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            Me.Hide()
            MsgBox("stats updated successfully")
            myConnection.Close()
            'TextBox1.Clear()
            'TextBox2.Clear()
            'TextBox3.Clear()
            'TextBox4.Clear()
            'TextBox5.Clear()
            'TextBox6.Clear()
            TextBox1.Text = " "
            TextBox2.Text = " "
            TextBox3.Text = " "
            TextBox4.Text = " "

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myConnection.Open()
        Dim str As String
        str = "Delete [username],age,height,weight,BMI,Fitness from healthinfos where [username]='" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            Me.Hide()
            MsgBox("stats deleted successfully")
            myConnection.Close()
            'TextBox1.Clear()
            'TextBox2.Clear()
            'TextBox3.Clear()
            'TextBox4.Clear()
            TextBox1.Text = " "
            TextBox2.Text = " "
            TextBox3.Text = " "
            TextBox4.Text = " "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
