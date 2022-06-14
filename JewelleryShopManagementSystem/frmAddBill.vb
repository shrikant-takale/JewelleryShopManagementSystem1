Public Class frmAddBill

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub
    Function ValidateAll()

        If txtCustomerId.Text = "" Then
            MsgBox("Enter Customer id ")
            txtCustomerId.Focus()
        ElseIf txtCustomerName.Text = "" Then
            MsgBox("Enter  Customer Name ")
            txtCustomerName.Focus()
        ElseIf txtItemRate.Text = "" Then
            MsgBox("Enter Item Rate ")
            txtItemRate.Focus()
        ElseIf txtItemName.Text = "" Then
            MsgBox("Enter Item Name ")
            txtItemName.Focus()
        ElseIf txtGST.Text = "" Then
            MsgBox("Enter Gst ")
            txtGST.Focus()
        ElseIf txtItemQuantity.Text = "" Then
            MsgBox("Enter Item Quantity ")
            txtItemQuantity.Focus()
        ElseIf txtCustomerCredit.Text = "" Then
            MsgBox("Enter Item Credit ")
            txtCustomerCredit.Focus()
        ElseIf txtBillAmount.Text = "" Then
            MsgBox("Enter Bill Amount ")
            txtBillAmount.Focus()
        ElseIf btnSave.Text = "Save" Then
            jokenfindthis("SELECT count(*) FROM tblAddBill WHERE CustomerName='" & txtCustomerName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same  Customer Name ALready Exist!")
            Else
                sql = "INSERT INTO tblAddBill VALUES(GETDATE()," & txtCustomerId.Text & ",'" & txtCustomerName.Text & "'," & txtItemRate.Text & ",'" & txtItemName.Text & "'," & txtGST.Text & "," & txtItemQuantity.Text & "," & txtCustomerCredit.Text & "," & txtBillAmount.Text & ",'" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddBill")
                    LoadBill(DataGridView, "Bill")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddBill SET BillDate=GETDATE(),CustomerId='" & txtCustomerId.Text & "',CustomerName='" & txtCustomerName.Text & "',ItemRate='" & txtItemRate.Text & "',ItemName='" & txtItemName.Text & "',GST=" & txtGST.Text & ",ItemQuantity=" & txtItemQuantity.Text & ",CustomerCredit=" & txtCustomerCredit.Text & ",BillAmount=" & txtBillAmount.Text & ",CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE BillId='" & txtBillId.Text & "'"
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddBill")
                LoadBill(DataGridView, "Bill")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddBill")
        LoadBill(DataGridView, "Bill")
    End Sub
    Public Sub LoadBill(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Bill"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9))
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


    Private Sub txtSearchBillDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchCustomerName.TextChanged
        sql = "SELECT * FROM tblAddBill WHERE CustomerName LIKE '%" & txtSearchCustomerName.Text & "%'"
        jokenfindthis(sql)
        LoadBill(DataGridView, "Bill")
    End Sub


    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtBillId.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If

        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtBillDate.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtCustomerId.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtCustomerName.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(4).Value) <> "" Then
            txtItemRate.Text = DataGridView.CurrentRow.Cells(4).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(5).Value) <> "" Then
            txtItemName.Text = DataGridView.CurrentRow.Cells(5).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(6).Value) <> "" Then
            txtGST.Text = DataGridView.CurrentRow.Cells(6).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(7).Value) <> "" Then
            txtItemQuantity.Text = DataGridView.CurrentRow.Cells(7).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(8).Value) <> "" Then
            txtCustomerCredit.Text = DataGridView.CurrentRow.Cells(8).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(9).Value) <> "" Then
            txtBillAmount.Text = DataGridView.CurrentRow.Cells(9).Value
        End If
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub
    Function ClearAll()
        txtBillId.Text = ""
        txtBillDate.Text = ""
        txtCustomerId.Text = ""
        txtCustomerName.Text = ""
        txtItemRate.Text = ""
        txtItemName.Text = ""
        txtGST.Text = ""
        txtItemQuantity.Text = ""
        txtCustomerCredit.Text = ""
        txtBillAmount.Text = ""
        txtSearchCustomerName.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtBillId.Text <> "" And txtBillId.Text <> "0") Then
            sql = "DELETE FROM tblAddBill WHERE CustomerId = '" & txtCustomerId.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                txtBillId.Text = ""
                txtBillDate.Text = ""
                txtCustomerId.Text = ""
                txtCustomerName.Text = ""
                txtItemRate.Text = ""
                txtItemName.Text = ""
                txtGST.Text = ""
                txtItemQuantity.Text = ""
                txtCustomerCredit.Text = ""
                txtBillAmount.Text = ""
                txtSearchCustomerName.Enabled = True
                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddCustomer")
                LoadBill(DataGridView, "Bill")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim n As Integer
        n = CInt(txtItemRate.Text) * CInt(txtItemQuantity.Text)
        txtGST.Text = (n / 100) * 18
        txtBillAmount.Text = n + CInt(txtCustomerCredit.Text) + CInt(txtGST.Text)
    End Sub

End Class