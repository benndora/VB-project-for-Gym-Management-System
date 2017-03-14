Imports System.Data

Public Class LOGIN
    Dim loginerror As String
    Dim ab As Integer
    Public Function logins()
        Dim DBConn As New ADODB.Connection
        Dim user As New ADODB.Recordset
        Dim Usernam As String
        Dim UserDB As String
        Dim passDB As String
        Dim typeDB As String

        Dim userfound As Boolean
        DBConn.Open("Provider = Microsoft.Jet.OLEDB.4.0;" & _
                    "Data Source = '" & "C:\Users\Hi\Documents\Visual Studio 2010\Projects\Gym management\Gym management\login.mdb'")
        user.Open("logintable", DBConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        userfound = False
        logins = False
        Usernam = "Username ='" & usertxt.Text & "'"
        Do
            user.Find(Usernam)
            If user.BOF = False And user.EOF = False Then
                UserDB = user.Fields("Username").Value.ToString
                passDB = user.Fields("Password").Value.ToString
                typeDB = user.Fields("usertype").Value.ToString
                If UserDB <> usertxt.Text Then
                    user.MoveNext()

                Else
                    userfound = True
                    If passDB = passtxt.Text Then
                        If typeDB = typetxt.Text Then
                            If typeDB = "user" Then
                                ab = 1
                            End If
                            If typeDB = "coach" Then
                                ab = 0
                            End If
                            user.Close()
                            DBConn.Close()
                            Return True
                        Else
                            loginerror = "mismatch is usertype"
                            user.Close()
                            DBConn.Close()
                            Return False
                        End If
                        user.Close()
                        DBConn.Close()
                        Return True
                    Else
                        loginerror = "invalid password"
                        user.Close()
                        DBConn.Close()
                        Return False
                    End If
                End If


            Else
                loginerror = "invalid username"
                user.Close()
                DBConn.Close()
                Return False
            End If
        Loop Until userfound = True
        user.Close()
        DBConn.Close()
        Return False
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If logins() = True Then
            MessageBox.Show("loggedin...successfully")
            If (ab = 1) Then
                Form3.Show()
            Else
                Form4.Show()
            End If
        Else
            MessageBox.Show(loginerror, "login message")
        End If


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

