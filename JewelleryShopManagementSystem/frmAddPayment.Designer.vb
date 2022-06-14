<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPayment
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEmailId = New System.Windows.Forms.TextBox()
        Me.txtEmployeeSalary = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPaymentDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPaymentId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchPaymentDate = New System.Windows.Forms.TextBox()
        Me.txtSrNo = New System.Windows.Forms.TextBox()
        Me.PaymentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeEmailId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Search Payment Date"
        '
        'DataGridView
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentId, Me.PaymentDate, Me.EmployeeId, Me.EmployeeEmailId, Me.EmployeeName, Me.EmployeeSalary, Me.CreatedBy, Me.CreatedDate, Me.UpdatedDate})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView.Location = New System.Drawing.Point(7, 369)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView.Name = "DataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView.RowTemplate.Height = 28
        Me.DataGridView.Size = New System.Drawing.Size(964, 317)
        Me.DataGridView.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(378, 41)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Add Jewellery Payment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtEmailId)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeSalary)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeName)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPaymentDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPaymentId)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 59)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(735, 261)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PaymentDetails"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(533, 190)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(116, 60)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(289, 190)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 60)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(411, 190)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 60)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(167, 190)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 60)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEmailId
        '
        Me.txtEmailId.Location = New System.Drawing.Point(123, 121)
        Me.txtEmailId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(231, 26)
        Me.txtEmailId.TabIndex = 5
        '
        'txtEmployeeSalary
        '
        Me.txtEmployeeSalary.Location = New System.Drawing.Point(516, 122)
        Me.txtEmployeeSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeSalary.Name = "txtEmployeeSalary"
        Me.txtEmployeeSalary.Size = New System.Drawing.Size(212, 26)
        Me.txtEmployeeSalary.TabIndex = 4
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(516, 79)
        Me.txtEmployeeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(212, 26)
        Me.txtEmployeeName.TabIndex = 4
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Location = New System.Drawing.Point(123, 84)
        Me.txtEmployeeId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(231, 26)
        Me.txtEmployeeId.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(376, 127)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = " Employee Salary:"
        '
        'txtPaymentDate
        '
        Me.txtPaymentDate.Enabled = False
        Me.txtPaymentDate.Location = New System.Drawing.Point(516, 41)
        Me.txtPaymentDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaymentDate.Name = "txtPaymentDate"
        Me.txtPaymentDate.Size = New System.Drawing.Size(212, 26)
        Me.txtPaymentDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 84)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = " Employee Name:"
        '
        'txtPaymentId
        '
        Me.txtPaymentId.Enabled = False
        Me.txtPaymentId.Location = New System.Drawing.Point(123, 43)
        Me.txtPaymentId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaymentId.Name = "txtPaymentId"
        Me.txtPaymentId.Size = New System.Drawing.Size(231, 26)
        Me.txtPaymentId.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 126)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Email Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "  Employee Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "  Payment Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PaymentId:"
        '
        'txtSearchPaymentDate
        '
        Me.txtSearchPaymentDate.Location = New System.Drawing.Point(193, 328)
        Me.txtSearchPaymentDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchPaymentDate.Name = "txtSearchPaymentDate"
        Me.txtSearchPaymentDate.Size = New System.Drawing.Size(546, 26)
        Me.txtSearchPaymentDate.TabIndex = 25
        '
        'txtSrNo
        '
        Me.txtSrNo.Enabled = False
        Me.txtSrNo.Location = New System.Drawing.Point(123, 43)
        Me.txtSrNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSrNo.Name = "txtSrNo"
        Me.txtSrNo.Size = New System.Drawing.Size(231, 26)
        Me.txtSrNo.TabIndex = 1
        '
        'PaymentId
        '
        Me.PaymentId.HeaderText = "PaymentId"
        Me.PaymentId.Name = "PaymentId"
        '
        'PaymentDate
        '
        Me.PaymentDate.HeaderText = "PaymentDate"
        Me.PaymentDate.Name = "PaymentDate"
        '
        'EmployeeId
        '
        Me.EmployeeId.HeaderText = "EmployeeId"
        Me.EmployeeId.Name = "EmployeeId"
        '
        'EmployeeEmailId
        '
        Me.EmployeeEmailId.HeaderText = "EmployeeEmailId"
        Me.EmployeeEmailId.Name = "EmployeeEmailId"
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "EmployeeName"
        Me.EmployeeName.Name = "EmployeeName"
        '
        'EmployeeSalary
        '
        Me.EmployeeSalary.HeaderText = "EmployeeSalary"
        Me.EmployeeSalary.Name = "EmployeeSalary"
        '
        'CreatedBy
        '
        Me.CreatedBy.HeaderText = "CreatedBy"
        Me.CreatedBy.Name = "CreatedBy"
        '
        'CreatedDate
        '
        Me.CreatedDate.HeaderText = "CreatedDate"
        Me.CreatedDate.Name = "CreatedDate"
        '
        'UpdatedDate
        '
        Me.UpdatedDate.HeaderText = "UpdatedDate"
        Me.UpdatedDate.Name = "UpdatedDate"
        '
        'frmAddPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 697)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearchPaymentDate)
        Me.Name = "frmAddPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddPayment"
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
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtEmailId As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentDate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchPaymentDate As System.Windows.Forms.TextBox
    Friend WithEvents txtSrNo As System.Windows.Forms.TextBox
    Friend WithEvents PaymentId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmailId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeSalary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
