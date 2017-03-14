Imports System.Data.OleDb
Public Class Form7
    Private Property Sql As Object
    Public myconnection As OleDbConnection = New OleDbConnection


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim i, n, m As Single
        Dim str1 As String
        Dim provider As String
        Dim datafile As String
        Dim connstring As String


        'Dim s1, s2,s3,s4 As String
        's1 = Me.TextBox1.Text
        's2 = Me.TextBox2.Text
        's3 = Me.TextBox3.Text
        's4 = Me.TextBox4.Text
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\healthinfo.mdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        '"PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source = .mdb"
        myconnection.Open()
        Try

            n = Single.Parse(TextBox3.Text)
            m = Single.Parse(TextBox4.Text)
            i = m / (n * n)
            If i >= 19 And i <= 26 Then
                str1 = "fit"
            Else
                str1 = "unfit"

            End If

            Sql = "INSERT INTO healthinfos ([username],age,height,weight,BMI,Fitness) VALUES ('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & n & "','" & m & "','" & i & "','" & str1 & "')"
            cmd = New OleDb.OleDbCommand(Sql, myconnection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Inserted", "Sign Up Msg")

            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconnection.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class