Public Class frmAddItems

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub

    Function ValidateAll()
        If txtItemName.Text = "" Then
            MsgBox("Enter Item Name")
            txtItemName.Focus()
        ElseIf txtQuantity.Text = "" Then
            MsgBox("Enter Item Quantity")
            txtQuantity.Focus()
        ElseIf txtQuantity.Text = "0" Then
            MsgBox("Enter Item Quantity Greater Than Zero")
            txtQuantity.Focus()
        ElseIf txtItemPrice.Text = "" Then
            MsgBox("Enter Item Price")
            txtItemPrice.Focus()
        ElseIf txtItemPrice.Text = "0" Then
            MsgBox("Enter Item Price Greater Than Zero")
            txtItemPrice.Focus()
        ElseIf btnSave.Text = "Save" Then

            jokenfindthis("SELECT count(*) FROM tblAddItems WHERE ItemsName='" & txtItemName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same ItemId ALready Exist!")
            Else
                sql = "INSERT INTO tblAddItems VALUES( '" & txtItemName.Text & "'," & txtQuantity.Text & ", " & txtItemPrice.Text & ",'" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddItems")
                    LoadItems(DataGridView, "Items")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddItems SET ItemsName='" & txtItemName.Text & "',ItemsQuantity=" & txtQuantity.Text & ",ItemsPrice=" & txtItemPrice.Text & ",CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE ItemsId='" & txtItemId.Text & "'"
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddItems")
                LoadItems(DataGridView, "Items")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddItems")
        LoadItems(DataGridView, "Items")
    End Sub

    Public Sub LoadItems(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Items"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
                        txtSearchItemName.Enabled = True
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub txtSearchItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchItemName.TextChanged
        sql = "SELECT * FROM tblAddItems WHERE ItemsName LIKE '%" & txtSearchItemName.Text & "%'"
        jokenfindthis(sql)
        LoadItems(DataGridView, "Items")
    End Sub

    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        GLOBALid = DataGridView.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridView.CurrentRow.Cells(0).Value) <> "" Then
            txtItemId.Text = DataGridView.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If
      
        If Convert.ToString(DataGridView.CurrentRow.Cells(1).Value) <> "" Then
            txtItemName.Text = DataGridView.CurrentRow.Cells(1).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(2).Value) <> "" Then
            txtQuantity.Text = DataGridView.CurrentRow.Cells(2).Value
        End If
        If Convert.ToString(DataGridView.CurrentRow.Cells(3).Value) <> "" Then
            txtItemPrice.Text = DataGridView.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub

    Function ClearAll()
        txtItemId.Text = ""
        txtItemName.Text = ""
        txtQuantity.Text = ""
        txtItemPrice.Text = ""
        txtSearchItemName.Enabled = False
        DataGridView.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtItemId.Text <> "" And txtItemId.Text <> "0") Then
            sql = "DELETE FROM tblAddItems WHERE ItemsId = '" & txtItemId.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                txtItemId.Text = ""
                txtItemName.Text = ""
                txtQuantity.Text = ""
                txtItemPrice.Text = ""
                txtSearchItemName.Enabled = True
                DataGridView.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddItems")
                LoadItems(DataGridView, "Items")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub

  
End Class