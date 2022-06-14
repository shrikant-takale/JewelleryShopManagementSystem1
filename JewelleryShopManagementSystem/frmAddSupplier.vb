Public Class frmAddSupplier
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub

    Function ValidateAll()
       
        If btnSave.Text = "Save" Then

            jokenfindthis("SELECT count(*) FROM tblAddSupplier WHERE SupplierName='" & txtSupplierName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same ItemId ALready Exist!")
            Else
                sql = "INSERT INTO tblAddSupplier VALUES('" & txtSupplierName.Text & "','" & txtSupplierAddress.Text & "', '" & txtSupplierEmailId.Text & "'," & txtSupplierCredit.Text & "," & txtSupplierPhoneNumber.Text & ",'" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddSupplier")
                    LoadSupplier(DataGridView, "Supplier")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddSupplier SET SupplierName='" & txtSupplierName.Text & "',SupplierAddress='" & txtSupplierAddress.Text & "',SupplierPhoneNumber=" & txtSupplierPhoneNumber.Text & ",SupplierCredit=" & txtSupplierCredit.Text & ",SupplierEmail='" & txtSupplierEmailId.Text & "',CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE SupplierId=" & txtSupplierId.Text & ""
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddSupplier")
                LoadSupplier(DataGridView, "Supplier")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddSupplier")
        LoadSupplier(DataGridView, "Supplier")
    End Sub

    Public Sub LoadSupplier(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Supplier"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
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


    Private Sub txtSearchSupplierName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchSupplierName.TextChanged
        sql = "SELECT * FROM tblAddSupplier WHERE SupplierName LIKE '%" & txtSearchSupplierName.Text & "%'"
        jokenfindthis(sql)
        LoadSupplier(DataGridView, "Supplier")
    End Sub


    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtSupplierId.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If
 

        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtSupplierName.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtSupplierAddress.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtSupplierEmailId.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(4).Value) <> "" Then
            txtSupplierCredit.Text = DataGridView.CurrentRow.Cells(4).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(5).Value) <> "" Then
            txtSupplierPhoneNumber.Text = DataGridView.CurrentRow.Cells(5).Value
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub
    Function ClearAll()
       
        txtSupplierId.Text = ""
        txtSupplierName.Text = ""
        txtSupplierAddress.Text = ""
        txtSupplierEmailId.Text = ""
        txtSupplierCredit.Text = ""
        txtSupplierPhoneNumber.Text = ""
        txtSearchSupplierName.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtSupplierId.Text <> "" And txtSupplierId.Text <> "0") Then
            sql = "DELETE FROM tblAddSupplier WHERE  SupplierId= '" & txtSupplierId.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                txtSupplierId.Text = ""
                txtSupplierName.Text = ""
                txtSupplierAddress.Text = ""
                txtSupplierEmailId.Text = ""
                txtSupplierCredit.Text = ""
                txtSupplierPhoneNumber.Text = ""
                txtSearchSupplierName.Enabled = True
                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddSupplier")
                LoadSupplier(DataGridView, "Supplier")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub


End Class