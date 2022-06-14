<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSupplier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSupplierEmailId = New System.Windows.Forms.TextBox()
        Me.txtSupplierPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtSupplierCredit = New System.Windows.Forms.TextBox()
        Me.txtSupplierAddress = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSupplierId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchSupplierName = New System.Windows.Forms.TextBox()
        Me.SupplierId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 335)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Search Supplier Name"
        '
        'DataGridView
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierId, Me.SupplierName, Me.SupplierAddress, Me.SupplierEmail, Me.SupplierCredit, Me.SupplierPhoneNumber, Me.CreatedBy, Me.CreatedDate})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.Location = New System.Drawing.Point(11, 373)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView.Name = "DataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.RowTemplate.Height = 28
        Me.DataGridView.Size = New System.Drawing.Size(1105, 272)
        Me.DataGridView.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(373, 41)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Add Jewellery Supplier"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtSupplierEmailId)
        Me.GroupBox1.Controls.Add(Me.txtSupplierPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtSupplierCredit)
        Me.GroupBox1.Controls.Add(Me.txtSupplierAddress)
        Me.GroupBox1.Controls.Add(Me.txtSupplierName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSupplierId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(929, 265)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CustomerDetails"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(532, 197)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(151, 60)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "Show All Records"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(393, 197)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 60)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(256, 197)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 60)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(120, 199)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 60)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSupplierEmailId
        '
        Me.txtSupplierEmailId.Location = New System.Drawing.Point(667, 83)
        Me.txtSupplierEmailId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierEmailId.Name = "txtSupplierEmailId"
        Me.txtSupplierEmailId.Size = New System.Drawing.Size(200, 26)
        Me.txtSupplierEmailId.TabIndex = 5
        '
        'txtSupplierPhoneNumber
        '
        Me.txtSupplierPhoneNumber.Location = New System.Drawing.Point(170, 123)
        Me.txtSupplierPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber"
        Me.txtSupplierPhoneNumber.Size = New System.Drawing.Size(200, 26)
        Me.txtSupplierPhoneNumber.TabIndex = 5
        '
        'txtSupplierCredit
        '
        Me.txtSupplierCredit.Location = New System.Drawing.Point(667, 122)
        Me.txtSupplierCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierCredit.Name = "txtSupplierCredit"
        Me.txtSupplierCredit.Size = New System.Drawing.Size(200, 26)
        Me.txtSupplierCredit.TabIndex = 4
        '
        'txtSupplierAddress
        '
        Me.txtSupplierAddress.Location = New System.Drawing.Point(667, 40)
        Me.txtSupplierAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierAddress.Name = "txtSupplierAddress"
        Me.txtSupplierAddress.Size = New System.Drawing.Size(200, 26)
        Me.txtSupplierAddress.TabIndex = 4
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(170, 83)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(200, 26)
        Me.txtSupplierName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(503, 124)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Supplier Credit:"
        '
        'txtSupplierId
        '
        Me.txtSupplierId.Enabled = False
        Me.txtSupplierId.Location = New System.Drawing.Point(171, 37)
        Me.txtSupplierId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierId.Name = "txtSupplierId"
        Me.txtSupplierId.Size = New System.Drawing.Size(200, 26)
        Me.txtSupplierId.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(503, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Supplier Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(504, 82)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Supplier EmailId:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 122)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = " Supplier Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Supplier Id:"
        '
        'txtSearchSupplierName
        '
        Me.txtSearchSupplierName.Location = New System.Drawing.Point(198, 337)
        Me.txtSearchSupplierName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchSupplierName.Name = "txtSearchSupplierName"
        Me.txtSearchSupplierName.Size = New System.Drawing.Size(513, 26)
        Me.txtSearchSupplierName.TabIndex = 20
        '
        'SupplierId
        '
        Me.SupplierId.HeaderText = "SupplierId"
        Me.SupplierId.Name = "SupplierId"
        Me.SupplierId.Width = 99
        '
        'SupplierName
        '
        Me.SupplierName.HeaderText = "SupplierName"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.Width = 105
        '
        'SupplierAddress
        '
        Me.SupplierAddress.HeaderText = "SupplierAddress"
        Me.SupplierAddress.Name = "SupplierAddress"
        Me.SupplierAddress.Width = 120
        '
        'SupplierEmail
        '
        Me.SupplierEmail.HeaderText = "SupplierEmail"
        Me.SupplierEmail.Name = "SupplierEmail"
        Me.SupplierEmail.Width = 115
        '
        'SupplierCredit
        '
        Me.SupplierCredit.HeaderText = "SupplierCredit"
        Me.SupplierCredit.Name = "SupplierCredit"
        Me.SupplierCredit.Width = 115
        '
        'SupplierPhoneNumber
        '
        Me.SupplierPhoneNumber.HeaderText = "SupplierPhoneNumber"
        Me.SupplierPhoneNumber.Name = "SupplierPhoneNumber"
        Me.SupplierPhoneNumber.Width = 172
        '
        'CreatedBy
        '
        Me.CreatedBy.HeaderText = "CreatedBy"
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.Width = 98
        '
        'CreatedDate
        '
        Me.CreatedDate.HeaderText = "CreatedDate"
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.Width = 102
        '
        'frmAddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 658)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearchSupplierName)
        Me.Name = "frmAddSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Supplier"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSupplierPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierEmailId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SupplierId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierPhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
