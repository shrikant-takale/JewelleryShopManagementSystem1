Public Class frmAddCustomer

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub
    Function ValidateAll()
     
        If txtCustomerName.Text = "" Then
            MsgBox("Enter Customer Name")
            txtCustomerName.Focus()
        ElseIf txtCustomerAddress.Text = "" Then
            MsgBox("Enter  Customer Address number")
            txtCustomerAddress.Focus()
        ElseIf txtCustomerEmail.Text = "" Then
            MsgBox("Enter Customer Emailid ")
            txtCustomerEmail.Focus()
        ElseIf txtCustomerCredit.Text = "" Then
            MsgBox("Enter  Customer Credit ")
            txtCustomerCredit.Focus()
        ElseIf txtCustomerPhoneNumber.Text = "" Then
            MsgBox("Enter Customer PhoneNumber ")
            txtCustomerPhoneNumber.Focus()
        ElseIf btnSave.Text = "Save" Then
            jokenfindthis("SELECT count(*) FROM tblAddCustomer WHERE CustomerName='" & txtCustomerName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same  Customer Name ALready Exist!")
            Else
                sql = "INSERT INTO tblAddCustomer VALUES('" & txtCustomerName.Text & "','" & txtCustomerAddress.Text & "','" & txtCustomerEmail.Text & "','" & txtCustomerCredit.Text & "'," & txtCustomerPhoneNumber.Text & ",'" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddCustomer")
                    LoadCustomer(DataGridView, "Customer")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddCustomer SET CustomerName='" & txtCustomerName.Text & "',CustomerAddress='" & txtCustomerAddress.Text & "',CustomerEmail='" & txtCustomerEmail.Text & "',CustomerCredit='" & txtCustomerCredit.Text & "',CustomerPhoneNumber=" & txtCustomerPhoneNumber.Text & ",CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE CustomerId='" & txtCustomerId.Text & "'"
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddCustomer")
                LoadCustomer(DataGridView, "Customer")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddCustomer")
        LoadCustomer(DataGridView, "Customer")
    End Sub
    Public Sub LoadCustomer(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Customer"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                        txtSearchCustomerName.Enabled = True
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub txtSearchCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchCustomerName.TextChanged
        sql = "SELECT * FROM tblAddCustomer WHERE CustomerName LIKE '%" & txtSearchCustomerName.Text & "%'"
        jokenfindthis(sql)
        LoadCustomer(DataGridView, "Customer")
    End Sub


    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtCustomerId.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If
       
        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtCustomerName.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtCustomerAddress.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtCustomerEmail.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(4).Value) <> "" Then
            txtCustomerCredit.Text = DataGridView.CurrentRow.Cells(4).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(5).Value) <> "" Then
            txtCustomerPhoneNumber.Text = DataGridView.CurrentRow.Cells(5).Value
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub
    Function ClearAll()
        txtCustomerId.Text = ""
        txtCustomerName.Text = ""
        txtCustomerAddress.Text = ""
        txtCustomerEmail.Text = ""
        txtCustomerCredit.Text = ""
        txtCustomerPhoneNumber.Text = ""
        txtSearchCustomerName.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtCustomerId.Text <> "" And txtCustomerId.Text <> "0") Then
            sql = "DELETE FROM tblAddCustomer WHERE CustomerId = '" & txtCustomerId.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                txtCustomerId.Text = ""
                txtCustomerName.Text = ""
                txtCustomerAddress.Text = ""
                txtCustomerEmail.Text = ""
                txtCustomerCredit.Text = ""
                txtCustomerPhoneNumber.Text = ""
                txtSearchCustomerName.Enabled = True
                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddCustomer")
                LoadCustomer(DataGridView, "Customer")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub

End Class