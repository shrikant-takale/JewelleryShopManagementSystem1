Public Class frmAddShop
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ValidateAll()
    End Sub
    Function ValidateAll()

        If txtShopName.Text = "" Then
            MsgBox("Enter Shop Name")
            txtShopName.Focus()
        ElseIf txtShopAddress.Text = "" Then
            MsgBox("Enter Shop Address")
            txtShopAddress.Focus()
        ElseIf txtShopPhoneNumber.Text = "" Then
            MsgBox("Enter Shope phone number")
            txtShopPhoneNumber.Focus()
        ElseIf txtShopEmail.Text = "" Then
            MsgBox("Enter Shop Emailid ")
            txtShopEmail.Focus()
        ElseIf btnSave.Text = "Save" Then
            jokenfindthis("SELECT count(*) FROM tblAddShop WHERE ShopName='" & txtShopName.Text & "'")
            If NumRows() > 0 Then
                MsgBox("Same Sope ShopName ALready Exist!")
            Else
                sql = "INSERT INTO tblAddShop VALUES('" & txtShopName.Text & "','" & txtShopAddress.Text & "','" & txtShopEmail.Text & "'," & txtShopPhoneNumber.Text & ",'" & UserName & "',GETDATE(),GETDATE())"
                issucess = jokeninsert(sql)
                If issucess = True Then
                    jokenfindthis("Select * from tblAddShop")
                    LoadShop(DataGridViewShop, "CustomerShop")
                    MsgBox("Record Succefully Inserted")
                ElseIf issucess = False Then
                    MsgBox("Record Not Inserted")
                End If
            End If
        ElseIf btnSave.Text = "Update" Then
            sql = "UPDATE tblAddShop SET ShopName='" & txtShopName.Text & "',ShopAddress='" & txtShopAddress.Text & "',ShopEmail='" & txtShopEmail.Text & "',ShopPhoneNumber=" & txtShopPhoneNumber.Text & ",CreatedBy='" & UserName & "',UpdatedDate=GETDATE() WHERE ShopId='" & TextBox1.Text & "'"
            issucess = jokenupdate(sql)
            If issucess = True Then
                jokenfindthis("Select * from tblAddShop")
                LoadShop(DataGridViewShop, "CustomerShop")
                MsgBox("Record Updated Successfully")
            ElseIf issucess = False Then
                MsgBox("Record Not Updated")
            End If
        End If
    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        jokenfindthis("Select * from tblAddShop")
        LoadShop(DataGridViewShop, "CustomerShop")
    End Sub
    Public Sub LoadShop(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "CustomerShop"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                        txtSearchShopName.Enabled = True
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewShop.CellDoubleClick
        GLOBALid = DataGridViewShop.CurrentRow.Cells(0).Value

        'MsgBox("Selected Sr. No. " + Convert.ToString(GLOBALid))

        If Convert.ToString(DataGridViewShop.CurrentRow.Cells(0).Value) <> "" Then
            TextBox1.Text = DataGridViewShop.CurrentRow.Cells(0).Value
            btnSave.Text = "Update"
            btnDelete.Enabled = True
        End If

        If Convert.ToString(DataGridViewShop.CurrentRow.Cells(1).Value) <> "" Then
            txtShopName.Text = DataGridViewShop.CurrentRow.Cells(1).Value
        End If
        

        If Convert.ToString(DataGridViewShop.CurrentRow.Cells(2).Value) <> "" Then
            txtShopAddress.Text = DataGridViewShop.CurrentRow.Cells(2).Value
        End If

        If Convert.ToString(DataGridViewShop.CurrentRow.Cells(3).Value) <> "" Then
            txtShopEmail.Text = DataGridViewShop.CurrentRow.Cells(3).Value
        End If

        If Convert.ToString(DataGridViewShop.CurrentRow.Cells(4).Value) <> "" Then
            txtShopPhoneNumber.Text = DataGridViewShop.CurrentRow.Cells(4).Value
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearAll()
    End Sub

    Function ClearAll()
        
        TextBox1.Text = ""
        txtShopName.Text = ""
        txtShopAddress.Text = ""
        txtShopEmail.Text = ""
        txtShopPhoneNumber.Text = ""
        txtSearchShopName.Enabled = False
        DataGridViewShop.Rows.Clear()
        GLOBALid = 0

        btnSave.Text = "Save"
        btnDelete.Enabled = False
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (TextBox1.Text <> "" And TextBox1.Text <> "0") Then
            sql = "DELETE FROM tblAddShop WHERE ShopId = '" & TextBox1.Text & "'"
            issucess = jokendelete(sql)

            If (issucess = True) Then
                TextBox1.Text = ""
                txtShopName.Text = ""
                txtShopEmail.Text = ""
                txtShopAddress.Text = ""
                txtShopPhoneNumber.Text = ""
                txtSearchShopName.Enabled = True
                DataGridViewShop.Rows.Clear()
                GLOBALid = 0

                btnSave.Text = "Save"
                btnDelete.Enabled = False

                jokenfindthis("Select * from tblAddShop")
                LoadShop(DataGridViewShop, "CustomerShop")

                MsgBox("Record Successfully Deleted")
            End If
        Else
            MsgBox("Select proper record for deletion")
        End If

    End Sub

    Private Sub txtSearchShopName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchShopName.TextChanged
        sql = "SELECT * FROM tblAddShop WHERE ShopName LIKE '%" & txtSearchShopName.Text & "%'"
        jokenfindthis(sql)
        LoadShop(DataGridViewShop, "CustomerShop")
    End Sub
End Class