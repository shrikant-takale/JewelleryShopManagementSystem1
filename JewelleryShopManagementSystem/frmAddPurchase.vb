
Public Class frmAddPurchase

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub
    Function ValidateAll()

        If txtSupplierId.Text = "" Then
            MsgBox("Enter Supplier Id")
            txtSupplierId.Focus()
        ElseIf txtSupplierName.Text = "" Then
            MsgBox("Enter  Supplier Name")
            txtSupplierName.Focus()
        ElseIf btnSave.Text = "Save" Then
            jokenfindthis("SELECT count(*) FROM tblAddPurchase WHERE SupplierName='" & txtSupplierName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same  SupplierName ALready Exist!")
            Else
                sql = "INSERT INTO tblAddPurchase VALUES(GETDATE(),'" & txtSupplierId.Text & "','" & txtSupplierName.Text & "','" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddPurchase")
                    LoadPurchase(DataGridView, "Purchase")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddPurchase SET  SupplierId=" & txtSupplierId.Text & ",SupplierName='" & txtSupplierName.Text & "',CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE PurchaseId=" & txtPurchaseId.Text & ""
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddPurchase")
                LoadPurchase(DataGridView, "Purchase")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddPurchase")
        LoadPurchase(DataGridView, "Purchase")
    End Sub

    Public Sub LoadPurchase(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Purchase"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                        txtSearchSupplierName.Enabled = True
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub


    Private Sub txtSearchPurchaseDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchSupplierName.TextChanged
        sql = "SELECT * FROM tblAddPurchase WHERE SuppierName LIKE '%" & txtSearchSupplierName.Text & "%'"
        jokenfindthis(sql)
        LoadPurchase(DataGridView, "Purchase")
    End Sub


    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtPurchaseId.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If

        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtPurchaseDate.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtSupplierId.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtSupplierName.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub
    Function ClearAll()
        txtPurchaseId.Text = ""
        txtPurchaseDate.Text = ""
        txtSupplierId.Text = ""
        txtSupplierName.Text = ""
        txtSearchSupplierName.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtPurchaseId.Text <> "" And txtPurchaseId.Text <> "0") Then
            sql = "DELETE FROM tblAddPurchase WHERE PurchaseId = '" & txtPurchaseId.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                txtSupplierName.Text = ""
                txtSupplierId.Text = ""
                txtSupplierName.Enabled = True
                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddPurchase")
                LoadPurchase(DataGridView, "Purchase")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub


End Class