Imports System.Data


Public Class Form2
    Private Property Sql As Object
    Private Property Sql2 As Object

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim con2 As New OleDb.OleDbConnection


        Dim cmd As New OleDb.OleDbCommand
        Dim cmd2 As New OleDb.OleDbCommand


        'Dim s1, s2,s3,s4,s5,s6,s7,s8,s9,s10 As String
        's1 = Me.TextBox2.Text
        's2 = Me.TextBox3.Text
        's3 = Me.TextBox4.Text
        's4 = Me.TextBox5.Text
        's5 = Me.TextBox6.Text
        's6 = Me.TextBox7.Text
        's7 = Me.TextBox8.Text
        's8 = Me.TextBox9.Text
        's9 = Me.TextBox10.Text
        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source ='" & "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\register.mdb'"
        con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source ='" & "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\login.mdb'"

        '"PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source = .mdb"

        con.Open()
        con2.Open()

        Sql = "INSERT INTO registration ([Name],Age,[Residential Address],[Mailing Address],[User type],[User Name],[Password],Cardno,phone) VALUES ('" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "','" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "','" & Me.TextBox9.Text & "','" & Me.TextBox10.Text & "')"
        Sql2 = "INSERT INTO logintable([Username],[Password],[Usertype]) VALUES ('" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "','" & Me.TextBox6.Text & "')"
        cmd = New OleDb.OleDbCommand(Sql, con)
        cmd2 = New OleDb.OleDbCommand(Sql2, con2)

        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        MessageBox.Show("Inserted", "Sign Up Msg")

        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.TextBox9.Text = ""
        Me.TextBox10.Text = ""

        con.Close()
        con2.Close()
        LOGIN.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LOGIN.Show()
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class