<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStripHeader = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemAddCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemAddEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMastersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppierReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripHeader
        '
        Me.MenuStripHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStripHeader.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripHeader.Name = "MenuStripHeader"
        Me.MenuStripHeader.Size = New System.Drawing.Size(1228, 33)
        Me.MenuStripHeader.TabIndex = 0
        Me.MenuStripHeader.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAddCustomer, Me.ToolStripMenuItemAddEmployee, Me.AddShopToolStripMenuItem, Me.AddItemsToolStripMenuItem, Me.AddSupplierToolStripMenuItem, Me.ExitMastersToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(86, 29)
        Me.ToolStripMenuItem1.Text = "Masters"
        '
        'ToolStripMenuItemAddCustomer
        '
        Me.ToolStripMenuItemAddCustomer.Name = "ToolStripMenuItemAddCustomer"
        Me.ToolStripMenuItemAddCustomer.ShortcutKeyDisplayString = "Ctrl+C"
        Me.ToolStripMenuItemAddCustomer.Size = New System.Drawing.Size(262, 30)
        Me.ToolStripMenuItemAddCustomer.Text = "Add Customer"
        Me.ToolStripMenuItemAddCustomer.ToolTipText = "This option used for adding new customer"
        '
        'ToolStripMenuItemAddEmployee
        '
        Me.ToolStripMenuItemAddEmployee.Name = "ToolStripMenuItemAddEmployee"
        Me.ToolStripMenuItemAddEmployee.ShortcutKeyDisplayString = "Ctrl+E"
        Me.ToolStripMenuItemAddEmployee.Size = New System.Drawing.Size(262, 30)
        Me.ToolStripMenuItemAddEmployee.Text = "Add Employee"
        '
        'AddShopToolStripMenuItem
        '
        Me.AddShopToolStripMenuItem.Name = "AddShopToolStripMenuItem"
        Me.AddShopToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.AddShopToolStripMenuItem.Text = "Add Shop"
        '
        'AddItemsToolStripMenuItem
        '
        Me.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem"
        Me.AddItemsToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.AddItemsToolStripMenuItem.Text = "Add Items"
        '
        'AddSupplierToolStripMenuItem
        '
        Me.AddSupplierToolStripMenuItem.Name = "AddSupplierToolStripMenuItem"
        Me.AddSupplierToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.AddSupplierToolStripMenuItem.Text = "Add Supplier"
        '
        'ExitMastersToolStripMenuItem
        '
        Me.ExitMastersToolStripMenuItem.Name = "ExitMastersToolStripMenuItem"
        Me.ExitMastersToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.ExitMastersToolStripMenuItem.Text = "ExitMasters"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPaymentToolStripMenuItem, Me.AddPurchaseToolStripMenuItem, Me.AddBillToolStripMenuItem, Me.ExitTransactionToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'AddPaymentToolStripMenuItem
        '
        Me.AddPaymentToolStripMenuItem.Name = "AddPaymentToolStripMenuItem"
        Me.AddPaymentToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.AddPaymentToolStripMenuItem.Text = "Add Payment"
        '
        'AddPurchaseToolStripMenuItem
        '
        Me.AddPurchaseToolStripMenuItem.Name = "AddPurchaseToolStripMenuItem"
        Me.AddPurchaseToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.AddPurchaseToolStripMenuItem.Text = "Add Purchase"
        '
        'AddBillToolStripMenuItem
        '
        Me.AddBillToolStripMenuItem.Name = "AddBillToolStripMenuItem"
        Me.AddBillToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.AddBillToolStripMenuItem.Text = "Add Bill"
        '
        'ExitTransactionToolStripMenuItem
        '
        Me.ExitTransactionToolStripMenuItem.Name = "ExitTransactionToolStripMenuItem"
        Me.ExitTransactionToolStripMenuItem.Size = New System.Drawing.Size(199, 30)
        Me.ExitTransactionToolStripMenuItem.Text = "ExitTransaction"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.EmployeeReportToolStripMenuItem, Me.ItemReportToolStripMenuItem, Me.ShopReportToolStripMenuItem, Me.SuppierReportToolStripMenuItem, Me.PaymentReportToolStripMenuItem, Me.PurchaseReportToolStripMenuItem, Me.BillReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.CustomerToolStripMenuItem.Text = "CustomerReport"
        '
        'EmployeeReportToolStripMenuItem
        '
        Me.EmployeeReportToolStripMenuItem.Name = "EmployeeReportToolStripMenuItem"
        Me.EmployeeReportToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.EmployeeReportToolStripMenuItem.Text = "EmployeeReport"
        '
        'ItemReportToolStripMenuItem
        '
        Me.ItemReportToolStripMenuItem.Name = "ItemReportToolStripMenuItem"
        Me.ItemReportToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.ItemReportToolStripMenuItem.Text = "itemReport"
        '
        'ShopReportToolStripMenuItem
        '
        Me.ShopReportToolStripMenuItem.Name = "ShopReportToolStripMenuItem"
        Me.ShopReportToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.ShopReportToolStripMenuItem.Text = "ShopReport"
        '
        'SuppierReportToolStripMenuItem
        '
        Me.SuppierReportToolStripMenuItem.Name = "SuppierReportToolStripMenuItem"
        Me.SuppierReportToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.SuppierReportToolStripMenuItem.Text = "SuppierReport"
        '
        'PaymentReportToolStripMenuItem
        '
        Me.PaymentReportToolStripMenuItem.Name = "PaymentReportToolStripMenuItem"
        Me.PaymentReportToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.PaymentReportToolStripMenuItem.Text = "PaymentReport"
        '
        'PurchaseReportToolStripMenuItem
        '
        Me.PurchaseReportToolStripMenuItem.Name = "PurchaseReportToolStripMenuItem"
        Me.PurchaseReportToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.PurchaseReportToolStripMenuItem.Text = "PurchaseReport"
        '
        'BillReportToolStripMenuItem
        '
        Me.BillReportToolStripMenuItem.Name = "BillReportToolStripMenuItem"
        Me.BillReportToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.BillReportToolStripMenuItem.Text = "BillReport"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JewelleryShopManagementSystem.My.Resources.Resources.MainFrmBackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1228, 844)
        Me.Controls.Add(Me.MenuStripHeader)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripHeader
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Renuka Jewellery Shop "
        Me.MenuStripHeader.ResumeLayout(False)
        Me.MenuStripHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripHeader As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAddCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAddEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddShopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitMastersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShopReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppierReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
