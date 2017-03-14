Imports System.Data
Imports System.Data.OleDb


Public Class Form5
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyConn As New OleDb.OleDbConnection
        MyConn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source ='" & Application.StartupPath & "\equipment.mdb'"
        MyConn.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As OleDbDataAdapter
        Dim source1 As New BindingSource



        da = New OleDbDataAdapter("Select * from equipments", MyConn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        MyConn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class