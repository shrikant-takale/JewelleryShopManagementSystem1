Imports System.Data.SqlClient
Public Class frmLogin
    Dim sql As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        sql = "SELECT count(*) as Numresult,UserName,UserType FROM tblUserMaster WITH(NOLOCK) WHERE UserName = '" & UsernameTextBox.Text & "' AND Password = '" & PasswordTextBox.Text & "' AND IsActive=1 GROUP BY UserName,UserType"

        jokenfindthis(sql)
        If NumRows() > 0 Then
            loadsingleUser("login")
            ' Main.TSUser.Text = fullname
            'Main.TLlogin.Text = "Logout"

            ' Visible_Button(True)
            'MsgBox("Login successfull!")
            Me.Hide()
            frmMain.ShowDialog()

        Else
            MsgBox("Username or Password not registered!")
        End If
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Me.Hide()
        frmUserMaster.Show()
    End Sub
End Class