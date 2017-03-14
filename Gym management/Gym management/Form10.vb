Imports System.Data.OleDb
Public Class Form10
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim c As Integer
    Public myconnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\healthinfo.mdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Dim str As String
        str = "SELECT * FROM healthinfos WHERE (username = '" & TextBox1.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox2.Text = dr("height").ToString
            TextBox3.Text = dr("weight").ToString
            TextBox4.Text = dr("BMI").ToString
            TextBox5.Text = dr("Fitness").ToString


        End While
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class


