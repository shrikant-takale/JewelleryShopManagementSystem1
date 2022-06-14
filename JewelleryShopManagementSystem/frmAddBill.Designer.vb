<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBill
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCustomerCredit = New System.Windows.Forms.TextBox()
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.txtItemQuantity = New System.Windows.Forms.TextBox()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.txtItemRate = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBillDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBillId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearchCustomerName = New System.Windows.Forms.TextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.BillId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 41)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Add Jewellery Bill"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btnTotal)
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtCustomerCredit)
        Me.GroupBox1.Controls.Add(Me.txtBillAmount)
        Me.GroupBox1.Controls.Add(Me.txtItemQuantity)
        Me.GroupBox1.Controls.Add(Me.txtGST)
        Me.GroupBox1.Controls.Add(Me.txtItemRate)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerId)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtBillDate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBillId)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 51)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(702, 318)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EmployeeDetails"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(294, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "18"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(568, 249)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(110, 58)
        Me.btnTotal.TabIndex = 25
        Me.btnTotal.Text = "Totale"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(428, 249)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(116, 60)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(289, 249)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 60)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(152, 249)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 60)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(16, 251)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 60)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCustomerCredit
        '
        Me.txtCustomerCredit.Location = New System.Drawing.Point(156, 189)
        Me.txtCustomerCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerCredit.Name = "txtCustomerCredit"
        Me.txtCustomerCredit.Size = New System.Drawing.Size(197, 26)
        Me.txtCustomerCredit.TabIndex = 4
        '
        'txtBillAmount
        '
        Me.txtBillAmount.Enabled = False
        Me.txtBillAmount.Location = New System.Drawing.Point(482, 186)
        Me.txtBillAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(208, 26)
        Me.txtBillAmount.TabIndex = 4
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Location = New System.Drawing.Point(483, 143)
        Me.txtItemQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.Size = New System.Drawing.Size(208, 26)
        Me.txtItemQuantity.TabIndex = 4
        '
        'txtGST
        '
        Me.txtGST.Enabled = False
        Me.txtGST.Location = New System.Drawing.Point(155, 143)
        Me.txtGST.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(129, 26)
        Me.txtGST.TabIndex = 4
        '
        'txtItemRate
        '
        Me.txtItemRate.Location = New System.Drawing.Point(155, 102)
        Me.txtItemRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemRate.Name = "txtItemRate"
        Me.txtItemRate.Size = New System.Drawing.Size(195, 26)
        Me.txtItemRate.TabIndex = 4
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(482, 104)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(208, 26)
        Me.txtItemName.TabIndex = 5
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(483, 63)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(208, 26)
        Me.txtCustomerName.TabIndex = 3
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(155, 65)
        Me.txtCustomerId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(195, 26)
        Me.txtCustomerId.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 194)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "CustomerCredit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 108)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ItemName"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(361, 192)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "BillAmount:"
        '
        'txtBillDate
        '
        Me.txtBillDate.Enabled = False
        Me.txtBillDate.Location = New System.Drawing.Point(482, 23)
        Me.txtBillDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBillDate.Name = "txtBillDate"
        Me.txtBillDate.Size = New System.Drawing.Size(208, 26)
        Me.txtBillDate.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(362, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ItemQuantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CustomerName"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 149)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "GST:"
        '
        'txtBillId
        '
        Me.txtBillId.Enabled = False
        Me.txtBillId.Location = New System.Drawing.Point(155, 26)
        Me.txtBillId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBillId.Name = "txtBillId"
        Me.txtBillId.Size = New System.Drawing.Size(195, 26)
        Me.txtBillId.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ItemRate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CustomerId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BillDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BillId:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 378)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "SearchCustomerName"
        '
        'txtSearchCustomerName
        '
        Me.txtSearchCustomerName.Location = New System.Drawing.Point(193, 378)
        Me.txtSearchCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchCustomerName.Name = "txtSearchCustomerName"
        Me.txtSearchCustomerName.Size = New System.Drawing.Size(528, 26)
        Me.txtSearchCustomerName.TabIndex = 22
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillId, Me.BillDate, Me.CustomerID, Me.CustomerName, Me.ItemRate, Me.ItemName, Me.GST, Me.ItemQuantity, Me.CustomerCredit, Me.BillAmount})
        Me.DataGridView.Location = New System.Drawing.Point(10, 414)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 28
        Me.DataGridView.Size = New System.Drawing.Size(974, 283)
        Me.DataGridView.TabIndex = 24
        '
        'BillId
        '
        Me.BillId.HeaderText = "BillId"
        Me.BillId.Name = "BillId"
        '
        'BillDate
        '
        Me.BillDate.HeaderText = "BillDate"
        Me.BillDate.Name = "BillDate"
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "CustomerID"
        Me.CustomerID.Name = "CustomerID"
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "CustomerName"
        Me.CustomerName.Name = "CustomerName"
        '
        'ItemRate
        '
        Me.ItemRate.HeaderText = "ItemRate"
        Me.ItemRate.Name = "ItemRate"
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        '
        'GST
        '
        Me.GST.HeaderText = "GST"
        Me.GST.Name = "GST"
        '
        'ItemQuantity
        '
        Me.ItemQuantity.HeaderText = "ItemQuantity"
        Me.ItemQuantity.Name = "ItemQuantity"
        '
        'CustomerCredit
        '
        Me.CustomerCredit.HeaderText = "CustomerCredit"
        Me.CustomerCredit.Name = "CustomerCredit"
        '
        'BillAmount
        '
        Me.BillAmount.HeaderText = "BillAmount"
        Me.BillAmount.Name = "BillAmount"
        '
        'frmAddBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 704)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSearchCustomerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtItemRate As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBillDate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBillId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearchCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtCustomerCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtBillAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtItemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BillId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillAmount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
