<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddShop
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewShop = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtShopEmail = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtShopId = New System.Windows.Forms.Label()
        Me.txtShopPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtShopAddress = New System.Windows.Forms.TextBox()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchShopName = New System.Windows.Forms.TextBox()
        Me.ShopId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShopName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShopAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShopEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShopPhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewShop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 282)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Search Shop Name"
        '
        'DataGridViewShop
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewShop.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShopId, Me.ShopName, Me.ShopAddress, Me.ShopEmail, Me.ShopPhoneNumber, Me.CreatedBy, Me.CreatedDate, Me.UpdatedDate})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewShop.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewShop.Location = New System.Drawing.Point(-3, 316)
        Me.DataGridViewShop.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewShop.Name = "DataGridViewShop"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewShop.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewShop.RowTemplate.Height = 28
        Me.DataGridViewShop.Size = New System.Drawing.Size(957, 211)
        Me.DataGridViewShop.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 41)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Add Jewellery Shop"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtShopEmail)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtShopId)
        Me.GroupBox1.Controls.Add(Me.txtShopPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtShopAddress)
        Me.GroupBox1.Controls.Add(Me.txtShopName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 51)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(724, 222)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ShopDetails"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(482, 159)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(116, 60)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(343, 159)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 60)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(206, 159)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 60)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(70, 161)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 60)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtShopEmail
        '
        Me.txtShopEmail.Location = New System.Drawing.Point(109, 110)
        Me.txtShopEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopEmail.Name = "txtShopEmail"
        Me.txtShopEmail.Size = New System.Drawing.Size(231, 26)
        Me.txtShopEmail.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(112, 27)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 26)
        Me.TextBox1.TabIndex = 3
        '
        'txtShopId
        '
        Me.txtShopId.AutoSize = True
        Me.txtShopId.Location = New System.Drawing.Point(7, 31)
        Me.txtShopId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtShopId.Name = "txtShopId"
        Me.txtShopId.Size = New System.Drawing.Size(69, 20)
        Me.txtShopId.TabIndex = 0
        Me.txtShopId.Text = "Shop Id:"
        '
        'txtShopPhoneNumber
        '
        Me.txtShopPhoneNumber.Location = New System.Drawing.Point(481, 71)
        Me.txtShopPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopPhoneNumber.Name = "txtShopPhoneNumber"
        Me.txtShopPhoneNumber.Size = New System.Drawing.Size(231, 26)
        Me.txtShopPhoneNumber.TabIndex = 4
        '
        'txtShopAddress
        '
        Me.txtShopAddress.Location = New System.Drawing.Point(479, 25)
        Me.txtShopAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopAddress.Name = "txtShopAddress"
        Me.txtShopAddress.Size = New System.Drawing.Size(231, 26)
        Me.txtShopAddress.TabIndex = 3
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(111, 71)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(231, 26)
        Me.txtShopName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Phone Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Email Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(381, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Shop Name:"
        '
        'txtSearchShopName
        '
        Me.txtSearchShopName.Location = New System.Drawing.Point(164, 282)
        Me.txtSearchShopName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchShopName.Name = "txtSearchShopName"
        Me.txtSearchShopName.Size = New System.Drawing.Size(562, 26)
        Me.txtSearchShopName.TabIndex = 30
        '
        'ShopId
        '
        Me.ShopId.HeaderText = "ShopId"
        Me.ShopId.Name = "ShopId"
        Me.ShopId.Width = 80
        '
        'ShopName
        '
        Me.ShopName.HeaderText = "ShopName"
        Me.ShopName.Name = "ShopName"
        '
        'ShopAddress
        '
        Me.ShopAddress.HeaderText = "ShopAddress"
        Me.ShopAddress.Name = "ShopAddress"
        '
        'ShopEmail
        '
        Me.ShopEmail.HeaderText = "ShopEmail"
        Me.ShopEmail.Name = "ShopEmail"
        '
        'ShopPhoneNumber
        '
        Me.ShopPhoneNumber.HeaderText = "ShopPhoneNumber"
        Me.ShopPhoneNumber.Name = "ShopPhoneNumber"
        Me.ShopPhoneNumber.Width = 150
        '
        'CreatedBy
        '
        Me.CreatedBy.HeaderText = "CreatedBy"
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.Width = 90
        '
        'CreatedDate
        '
        Me.CreatedDate.HeaderText = "CreatedDate"
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.Width = 110
        '
        'UpdatedDate
        '
        Me.UpdatedDate.HeaderText = "UpdatedDate"
        Me.UpdatedDate.Name = "UpdatedDate"
        Me.UpdatedDate.Width = 110
        '
        'frmAddShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 536)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridViewShop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearchShopName)
        Me.Name = "frmAddShop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Shop"
        CType(Me.DataGridViewShop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewShop As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtShopEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtShopPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtShopAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtShopName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchShopName As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtShopId As System.Windows.Forms.Label
    Friend WithEvents ShopId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShopName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShopAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShopEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShopPhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
