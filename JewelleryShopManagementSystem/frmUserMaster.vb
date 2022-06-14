Public Class frmUserMaster
    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub

    Function ValidateAll()

        If btnSave.Text = "Save" Then

            jokenfindthis("SELECT count(*) FROM tblUserMaster WHERE UserName='" & txtUserName1.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same UserName ALready Exist!")
            Else
                sql = "INSERT INTO tblUserMaster VALUES('" & txtUserType.Text & "','" & txtUserName1.Text & "', '" & txtPassword.Text & "'," & txtIsActive.Text & ",'" & txtCreatedBy.Text & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblUserMaster")
                    LoadUserMaster(DataGridView, "tblUserMaster")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblUserMaster SET UserType='" & txtUserType.Text & "',UserName='" & txtUserName1.Text & "',Password='" & txtPassword.Text & "',IsActive=" & txtIsActive.Text & ",CreatedBy='" & txtCreatedBy.Text & "',UpdatedDate=GETDATE() WHERE SrNo=" & txtSrNo.Text & ""
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblUserMaster")
                LoadUserMaster(DataGridView, "UserMaster")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Public Sub LoadUserMaster(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "UserMaster"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                        txtSearchUserName.Enabled = True
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub


    Private Sub txtSearchUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchUserName.TextChanged
        sql = "SELECT * FROM tblUserMaster WHERE UserName LIKE '%" & txtSearchUserName.Text & "%'"
        jokenfindthis(sql)
        LoadUserMaster(DataGridView, "UserMaster")
    End Sub


    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtSrNo.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If


        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtUserType.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtUserName1.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtPassword.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(4).Value) <> "" Then
            txtIsActive.Text = DataGridView.CurrentRow.Cells(4).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(5).Value) <> "" Then
            txtCreatedBy.Text = DataGridView.CurrentRow.Cells(5).Value
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub
    Function ClearAll()

        txtSrNo.Text = ""
        txtUserName1.Text = ""
        txtPassword.Text = ""
        txtIsActive.Text = ""
        txtUserType.Text = ""
        txtSearchUserName.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtSrNo.Text <> "" And txtSrNo.Text <> "0") Then
            sql = "DELETE FROM tblUserMaster WHERE  SrNo= '" & txtSrNo.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then

                txtSrNo.Text = ""
                txtUserType.Text = ""
                txtPassword.Text = ""
                txtUserName1.Text = ""
                txtIsActive.Text = ""

                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblUserMaster")
                LoadUserMaster(DataGridView, "UserMaster")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub

    Private Sub btnShow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblUserMaster")
        LoadUserMaster(DataGridView, "UserMaster")
    End Sub
End Class