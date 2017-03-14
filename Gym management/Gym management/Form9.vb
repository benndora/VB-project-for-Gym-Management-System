Public Class Form9
    Private Property Sql As Object
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim provider As String
        Dim datafile As String
        Dim connstring As String


        'Dim s1, s2,s3,s4,s5 As String
        's1 = Me.TextBox1.Text
        's2 = Me.TextBox2.Text
        's3 = Me.TextBox3.Text
        's4 = Me.TextBox4.Text
        's5 = Me.Textbox5.Text
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        datafile = "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\creditcard.mdb"
        connstring = provider & datafile
        con.ConnectionString = connstring
        '"PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source = .mdb"

        con.Open()
        Sql = "INSERT INTO creditcards ([username],cardno,[cardtype],balance,pin no) VALUES ('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "')"
        cmd = New OleDb.OleDbCommand(Sql, con)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Inserted", "Sign Up Msg")
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        con.Close()
    End Sub
End Class