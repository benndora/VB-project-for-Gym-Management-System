Imports System.Data
Imports System.Data.OleDb

Public Class Form13
    Private Property Sql As Object
    Private Property sql2 As Object
    Public myconnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim provider As String
        Dim datafile As String
        Dim connstring As String
        Try
            provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
            datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\plan.mdb"
            connstring = provider & datafile
            myconnection.ConnectionString = connstring
            myconnection.Open()
            Sql = "INSERT INTO plans (ID,[Name],Cost,[Benefit],[Coach],totalweeks) VALUES ('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "')"
            cmd = New OleDb.OleDbCommand(Sql, myconnection)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Inserted", "Sign Up Msg")
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox6.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source ='" & "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\plan.mdb'"
        '"PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source = .mdb"
        con.Open()
        Dim str As String
        str = "Update plans Set ID='" & TextBox1.Text & "',[Name]= '" & TextBox2.Text & "',Cost='" & TextBox3.Text & "',[Benefit]='" & TextBox4.Text & "',[Coach]='" & TextBox5.Text & "',totalweeks='" & TextBox6.Text & "' where ID= " & TextBox1.Text
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Try
            cmd.ExecuteNonQuery()
            Me.Hide()
            MsgBox("stats updated successfully")
            con.Close()
            TextBox1.Text = " "
            TextBox2.Text = " "
            TextBox3.Text = " "
            TextBox4.Text = " "

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()

    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class