Public Class Form11
    Private Property Sql As Object
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand



        'Dim s1, s2,s3,s4 As String
        's1 = Me.TextBox1.Text
        's2 = Me.TextBox2.Text
        's3 = Me.TextBox3.Text
        's4 = Me.TextBox4.Text
        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source ='" & Application.StartupPath & "\equipment.mdb'"

        '"PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source = .mdb"

        con.Open()
        Sql = "INSERT INTO equipments ([Name],[Date installed],[benefits],cost) VALUES ('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "')"
        cmd = New OleDb.OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Inserted", "add equipments Msg")

        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class