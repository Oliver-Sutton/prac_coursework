<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStockCheck
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
        Me.panelStockCheck = New System.Windows.Forms.Panel()
        Me.lblUserFeedback = New System.Windows.Forms.Label()
        Me.lblStockNumber = New System.Windows.Forms.Label()
        Me.lblInStock = New System.Windows.Forms.Label()
        Me.btnCheckStock = New System.Windows.Forms.Button()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.panelNav = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelStockCheck.SuspendLayout()
        Me.panelNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelStockCheck
        '
        Me.panelStockCheck.Controls.Add(Me.lblUserFeedback)
        Me.panelStockCheck.Controls.Add(Me.lblStockNumber)
        Me.panelStockCheck.Controls.Add(Me.lblInStock)
        Me.panelStockCheck.Controls.Add(Me.btnCheckStock)
        Me.panelStockCheck.Controls.Add(Me.lblItemID)
        Me.panelStockCheck.Controls.Add(Me.txtProductID)
        Me.panelStockCheck.Location = New System.Drawing.Point(122, 132)
        Me.panelStockCheck.Name = "panelStockCheck"
        Me.panelStockCheck.Size = New System.Drawing.Size(266, 128)
        Me.panelStockCheck.TabIndex = 0
        '
        'lblUserFeedback
        '
        Me.lblUserFeedback.AutoSize = True
        Me.lblUserFeedback.Location = New System.Drawing.Point(106, 107)
        Me.lblUserFeedback.Name = "lblUserFeedback"
        Me.lblUserFeedback.Size = New System.Drawing.Size(63, 13)
        Me.lblUserFeedback.TabIndex = 9
        Me.lblUserFeedback.Text = "Placeholder"
        Me.lblUserFeedback.Visible = False
        '
        'lblStockNumber
        '
        Me.lblStockNumber.AutoSize = True
        Me.lblStockNumber.Location = New System.Drawing.Point(73, 48)
        Me.lblStockNumber.Name = "lblStockNumber"
        Me.lblStockNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblStockNumber.TabIndex = 8
        '
        'lblInStock
        '
        Me.lblInStock.AutoSize = True
        Me.lblInStock.Location = New System.Drawing.Point(3, 48)
        Me.lblInStock.Name = "lblInStock"
        Me.lblInStock.Size = New System.Drawing.Size(47, 13)
        Me.lblInStock.TabIndex = 5
        Me.lblInStock.Text = "In Stock"
        Me.lblInStock.Visible = False
        '
        'btnCheckStock
        '
        Me.btnCheckStock.Location = New System.Drawing.Point(3, 81)
        Me.btnCheckStock.Name = "btnCheckStock"
        Me.btnCheckStock.Size = New System.Drawing.Size(260, 23)
        Me.btnCheckStock.TabIndex = 2
        Me.btnCheckStock.Text = "Check Stock"
        Me.btnCheckStock.UseVisualStyleBackColor = True
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(3, 6)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(67, 13)
        Me.lblItemID.TabIndex = 1
        Me.lblItemID.Text = "Item Number"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(76, 3)
        Me.txtProductID.MaxLength = 9
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(187, 20)
        Me.txtProductID.TabIndex = 0
        '
        'panelNav
        '
        Me.panelNav.Controls.Add(Me.btnBack)
        Me.panelNav.Location = New System.Drawing.Point(12, 12)
        Me.panelNav.Name = "panelNav"
        Me.panelNav.Size = New System.Drawing.Size(81, 30)
        Me.panelNav.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(3, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'formStockCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 524)
        Me.Controls.Add(Me.panelNav)
        Me.Controls.Add(Me.panelStockCheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formStockCheck"
        Me.Text = "formStockCheck"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelStockCheck.ResumeLayout(False)
        Me.panelStockCheck.PerformLayout()
        Me.panelNav.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelStockCheck As Panel
    Friend WithEvents lblInStock As Label
    Friend WithEvents btnCheckStock As Button
    Friend WithEvents lblItemID As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblStockNumber As Label
    Friend WithEvents lblUserFeedback As Label
    Friend WithEvents panelNav As Panel
    Friend WithEvents btnBack As Button
End Class
