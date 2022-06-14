<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Me.EmployeeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeerCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEmployeePhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtEmployeeCredit = New System.Windows.Forms.TextBox()
        Me.txtEmployeeAddress = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmployeeEmail = New System.Windows.Forms.TextBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchEmployeeName = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Search Employee Name"
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
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeId, Me.EmployeeName, Me.EmployeeAddress, Me.EmployeeEmail, Me.EmployeerCredit, Me.EmployeePhoneNumber, Me.CreatedBy, Me.CreatedDate})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.Location = New System.Drawing.Point(11, 334)
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
        Me.DataGridView.Size = New System.Drawing.Size(930, 239)
        Me.DataGridView.TabIndex = 12
        '
        'EmployeeId
        '
        Me.EmployeeId.HeaderText = "EmployeeId"
        Me.EmployeeId.Name = "EmployeeId"
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "EmployeeName"
        Me.EmployeeName.Name = "EmployeeName"
        '
        'EmployeeAddress
        '
        Me.EmployeeAddress.HeaderText = "EmployeeAddress"
        Me.EmployeeAddress.Name = "EmployeeAddress"
        '
        'EmployeeEmail
        '
        Me.EmployeeEmail.HeaderText = "EmployeeEmail"
        Me.EmployeeEmail.Name = "EmployeeEmail"
        '
        'EmployeerCredit
        '
        Me.EmployeerCredit.HeaderText = "EmployeerCredit"
        Me.EmployeerCredit.Name = "EmployeerCredit"
        '
        'EmployeePhoneNumber
        '
        Me.EmployeePhoneNumber.HeaderText = "EmployeePhoneNumber"
        Me.EmployeePhoneNumber.Name = "EmployeePhoneNumber"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 41)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Add Jewellery Employee"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtEmployeePhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeCredit)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeAddress)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeEmail)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(719, 215)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EmployeeDetails"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(481, 156)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(116, 51)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(342, 156)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 51)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(205, 157)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 51)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(69, 158)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 51)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEmployeePhoneNumber
        '
        Me.txtEmployeePhoneNumber.Location = New System.Drawing.Point(139, 109)
        Me.txtEmployeePhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber"
        Me.txtEmployeePhoneNumber.Size = New System.Drawing.Size(196, 26)
        Me.txtEmployeePhoneNumber.TabIndex = 4
        '
        'txtEmployeeCredit
        '
        Me.txtEmployeeCredit.Location = New System.Drawing.Point(512, 111)
        Me.txtEmployeeCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeCredit.Name = "txtEmployeeCredit"
        Me.txtEmployeeCredit.Size = New System.Drawing.Size(196, 26)
        Me.txtEmployeeCredit.TabIndex = 5
        '
        'txtEmployeeAddress
        '
        Me.txtEmployeeAddress.Location = New System.Drawing.Point(512, 30)
        Me.txtEmployeeAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeAddress.Name = "txtEmployeeAddress"
        Me.txtEmployeeAddress.Size = New System.Drawing.Size(196, 26)
        Me.txtEmployeeAddress.TabIndex = 3
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(139, 73)
        Me.txtEmployeeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(197, 26)
        Me.txtEmployeeName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Employee Credit:"
        '
        'txtEmployeeEmail
        '
        Me.txtEmployeeEmail.Location = New System.Drawing.Point(512, 73)
        Me.txtEmployeeEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeEmail.Name = "txtEmployeeEmail"
        Me.txtEmployeeEmail.Size = New System.Drawing.Size(196, 26)
        Me.txtEmployeeEmail.TabIndex = 6
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Enabled = False
        Me.txtEmployeeId.Location = New System.Drawing.Point(139, 30)
        Me.txtEmployeeId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(196, 26)
        Me.txtEmployeeId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Employee Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 115)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Employee Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(361, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Employee EmailId:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = " Employee Id:"
        '
        'txtSearchEmployeeName
        '
        Me.txtSearchEmployeeName.Location = New System.Drawing.Point(203, 295)
        Me.txtSearchEmployeeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchEmployeeName.Name = "txtSearchEmployeeName"
        Me.txtSearchEmployeeName.Size = New System.Drawing.Size(528, 26)
        Me.txtSearchEmployeeName.TabIndex = 2
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 584)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearchEmployeeName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Employee"
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
    Friend WithEvents txtEmployeePhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EmployeeId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeerCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeePhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
