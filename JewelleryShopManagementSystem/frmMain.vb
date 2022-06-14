Public Class frmMain

    Private Sub ToolStripMenuItemAddCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAddCustomer.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Customer" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmAddCstmr As New frmAddCustomer
            frmAddCstmr.MdiParent = Me
            frmAddCstmr.Show()
        End If
    End Sub


    Private Sub ToolStripMenuItemAddEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAddEmployee.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Employee" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmAddEmpl As New frmAddEmployee
            frmAddEmpl.MdiParent = Me
            frmAddEmpl.Show()
        End If
    End Sub

  

    Private Sub AddShopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddShopToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Shop" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmAddSP As New frmAddShop
            frmAddSP.MdiParent = Me
            frmAddSP.Show()
        End If
    End Sub

 
    
    Private Sub AddItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemsToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Items" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmItm As New frmAddItems
            frmItm.MdiParent = Me
            frmItm.Show()
        End If
    End Sub

   
    Private Sub AddSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSupplierToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Supplier" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddSupplier As New frmAddSupplier
            AddSupplier.MdiParent = Me
            AddSupplier.Show()
        End If
    End Sub

    Private Sub AddPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPaymentToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Payment" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddPayment As New frmAddPayment
            AddPayment.MdiParent = Me
            AddPayment.Show()
        End If
    End Sub

    Private Sub AddPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPurchaseToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Purchase" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddPurchase As New frmAddPurchase
            AddPurchase.MdiParent = Me
            AddPurchase.Show()
        End If
    End Sub

    Private Sub AddBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBillToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Bill" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddBill As New frmAddBill
            AddBill.MdiParent = Me
            AddBill.Show()
        End If
    End Sub

    Private Sub ExitMastersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMastersToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExitTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTransactionToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        cust.Show()
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        Emp.Show()
    End Sub

    Private Sub SuppierReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppierReportToolStripMenuItem.Click
        Supp.Show()
    End Sub

    Private Sub ItemReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemReportToolStripMenuItem.Click
        Itm.Show()
    End Sub

    Private Sub ShopReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopReportToolStripMenuItem.Click
        ShopR.Show()
    End Sub

    Private Sub PaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentReportToolStripMenuItem.Click
        Pmt.Show()
    End Sub

    Private Sub BillReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillReportToolStripMenuItem.Click
        BillR.Show()
    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        Pur.Show()
    End Sub
End Class
