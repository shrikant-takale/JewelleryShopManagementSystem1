Public Class frmAddEmployee

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub
    Function ValidateAll()

        If txtEmployeeName.Text = "" Then
            MsgBox("Enter Employee Name")
            txtEmployeeName.Focus()
        ElseIf txtEmployeeAddress.Text = "" Then
            MsgBox("Enter  Employee Address number")
            txtEmployeeAddress.Focus()
        ElseIf txtEmployeeEmail.Text = "" Then
            MsgBox("Enter Employee Emailid ")
            txtEmployeeEmail.Focus()
        ElseIf txtEmployeeCredit.Text = "" Then
            MsgBox("Enter  Employee Credit ")
            txtEmployeeCredit.Focus()
        ElseIf txtEmployeePhoneNumber.Text = "" Then
            MsgBox("Enter Employee PhoneNumber ")
            txtEmployeePhoneNumber.Focus()
        ElseIf btnSave.Text = "Save" Then
            jokenfindthis("SELECT count(*) FROM tblAddEmployee WHERE EmployeeName='" & txtEmployeeName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same  Employee Name ALready Exist!")
            Else
                sql = "INSERT INTO tblAddEmployee VALUES('" & txtEmployeeName.Text & "','" & txtEmployeeAddress.Text & "','" & txtEmployeeEmail.Text & "','" & txtEmployeeCredit.Text & "'," & txtEmployeePhoneNumber.Text & ",'" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddEmployee")
                    LoadEmployee(DataGridView, "Employee")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddEmployee SET EmployeeName='" & txtEmployeeName.Text & "',EmployeeAddress='" & txtEmployeeAddress.Text & "',EmployeeEmail='" & txtEmployeeEmail.Text & "',EmployeerCredit='" & txtEmployeeCredit.Text & "',EmployeePhoneNumber=" & txtEmployeePhoneNumber.Text & ",CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE EmployeeId='" & txtEmployeeId.Text & "'"
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddEmployee")
                LoadEmployee(DataGridView, "Employee")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddEmployee")
        LoadEmployee(DataGridView, "Employee")
    End Sub
    Public Sub LoadEmployee(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Employee"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                        txtSearchEmployeeName.Enabled = True
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub
    Function ClearAll()
       
        txtEmployeeId.Text = ""
        txtEmployeeName.Text = ""
        txtEmployeeAddress.Text = ""
        txtEmployeeEmail.Text = ""
        txtEmployeeCredit.Text = ""
        txtEmployeePhoneNumber.Text = ""
        txtSearchEmployeeName.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function



    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtEmployeeId.Text <> "" And txtEmployeeId.Text <> "0") Then
            sql = "DELETE FROM tblAddEmployee WHERE EmployeeId = '" & txtEmployeeId.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                
                txtEmployeeId.Text = ""
                txtEmployeeName.Text = ""
                txtEmployeeAddress.Text = ""
                txtEmployeeEmail.Text = ""
                txtEmployeeCredit.Text = ""
                txtEmployeePhoneNumber.Text = ""
                txtSearchEmployeeName.Enabled = True
                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddEmployee")
                LoadEmployee(DataGridView, "Employee")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub


    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtEmployeeId.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtEmployeeName.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtEmployeeAddress.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtEmployeeEmail.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(4).Value) <> "" Then
            txtEmployeeCredit.Text = DataGridView.CurrentRow.Cells(4).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(5).Value) <> "" Then
            txtEmployeePhoneNumber.Text = DataGridView.CurrentRow.Cells(5).Value
        End If
    End Sub

    Private Sub txtSearchEmployeeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchEmployeeName.TextChanged
        sql = "SELECT * FROM tblAddEmployee WHERE EmployeeName LIKE '%" & txtSearchEmployeeName.Text & "%'"
        jokenfindthis(sql)
        LoadEmployee(DataGridView, "Employee")
    End Sub


End Class