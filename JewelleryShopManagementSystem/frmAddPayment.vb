Public Class frmAddPayment

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub
    Function ValidateAll()

        If txtEmployeeId.Text = "" Then
            MsgBox("Enter EmployeeId")
            txtEmployeeId.Focus()
        ElseIf txtEmailId.Text = "" Then
            MsgBox("Enter  Email Id")
            txtEmailId.Focus()
        ElseIf txtEmployeeName.Text = "" Then
            MsgBox("Enter Employee Name ")
            txtEmployeeName.Focus()
        ElseIf txtEmployeeSalary.Text = "" Then
            MsgBox("Enter Employee Salary ")
            txtEmployeeSalary.Focus()
        ElseIf btnSave.Text = "Save" Then
            jokenfindthis("SELECT count(*) FROM tblAddPayment WHERE EmployeeName ='" & txtEmployeeName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same  Customer Name ALready Exist!")
            Else
                sql = "INSERT INTO tblAddPayment VALUES(GETDATE()," & txtEmployeeId.Text & ",'" & txtEmailId.Text & "','" & txtEmployeeName.Text & "'," & txtEmployeeSalary.Text & ",'" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddPayment")
                    LoadPayment(DataGridView, "Payment")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddPayment SET PaymentDate=GETDATE(),EmployeeId='" & txtEmployeeId.Text & "',EmployeeEmailId='" & txtEmailId.Text & "',EmployeeName='" & txtEmployeeName.Text & "',EmployeeSalary='" & txtEmployeeSalary.Text & "',CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE PaymentId='" & txtPaymentId.Text & "'"
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddPayment")
                LoadPayment(DataGridView, "Payment")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddPayment")
        LoadPayment(DataGridView, "Payment")
    End Sub

    Public Sub LoadPayment(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Payment"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                        txtSearchPaymentDate.Enabled = True
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub


    Private Sub txtSearchPaymentDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchPaymentDate.TextChanged
        sql = "SELECT * FROM tblAddPayment WHERE CustomerName LIKE '%" & txtSearchPaymentDate.Text & "%'"
        jokenfindthis(sql)
        LoadPayment(DataGridView, "Payment")
    End Sub



    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtPaymentId.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If

        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtPaymentDate.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtEmailId.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtEmailId.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(4).Value) <> "" Then
            txtEmployeeName.Text = DataGridView.CurrentRow.Cells(4).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(5).Value) <> "" Then
            txtEmployeeSalary.Text = DataGridView.CurrentRow.Cells(5).Value
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub
    Function ClearAll()
        txtPaymentId.Text = ""
        txtPaymentDate.Text = ""
        txtEmployeeId.Text = ""
        txtEmailId.Text = ""
        txtEmployeeName.Text = ""
        txtEmployeeSalary.Text = ""
        txtSearchPaymentDate.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtPaymentId.Text <> "" And txtPaymentId.Text <> "0") Then
            sql = "DELETE FROM tblAddPaymentId WHERE PaymentId = '" & txtPaymentId.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                txtPaymentId.Text = ""
                txtPaymentDate.Text = ""
                txtEmployeeId.Text = ""
                txtEmailId.Text = ""
                txtEmployeeName.Text = ""
                txtEmployeeSalary.Text = ""
                txtSearchPaymentDate.Enabled = True
                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddPayment")
                LoadPayment(DataGridView, "Payment")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub

End Class