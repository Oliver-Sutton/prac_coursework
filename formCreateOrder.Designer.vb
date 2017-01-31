<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCreateOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelCreateOrder = New System.Windows.Forms.Panel()
        Me.lblUserFeedback = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.txtItemAmount = New System.Windows.Forms.TextBox()
        Me.lblItemAmount = New System.Windows.Forms.Label()
        Me.txtItemNumber = New System.Windows.Forms.TextBox()
        Me.lblItemNumber = New System.Windows.Forms.Label()
        Me.lblCreateOrder = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelCreateOrder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCreateOrder
        '
        Me.panelCreateOrder.Controls.Add(Me.lblUserFeedback)
        Me.panelCreateOrder.Controls.Add(Me.btnPlaceOrder)
        Me.panelCreateOrder.Controls.Add(Me.txtItemAmount)
        Me.panelCreateOrder.Controls.Add(Me.lblItemAmount)
        Me.panelCreateOrder.Controls.Add(Me.txtItemNumber)
        Me.panelCreateOrder.Controls.Add(Me.lblItemNumber)
        Me.panelCreateOrder.Controls.Add(Me.lblCreateOrder)
        Me.panelCreateOrder.Location = New System.Drawing.Point(158, 135)
        Me.panelCreateOrder.Name = "panelCreateOrder"
        Me.panelCreateOrder.Size = New System.Drawing.Size(232, 123)
        Me.panelCreateOrder.TabIndex = 0
        '
        'lblUserFeedback
        '
        Me.lblUserFeedback.AutoSize = True
        Me.lblUserFeedback.Location = New System.Drawing.Point(81, 104)
        Me.lblUserFeedback.Name = "lblUserFeedback"
        Me.lblUserFeedback.Size = New System.Drawing.Size(63, 13)
        Me.lblUserFeedback.TabIndex = 7
        Me.lblUserFeedback.Text = "Placeholder"
        Me.lblUserFeedback.Visible = False
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(6, 78)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(223, 23)
        Me.btnPlaceOrder.TabIndex = 6
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'txtItemAmount
        '
        Me.txtItemAmount.Location = New System.Drawing.Point(76, 52)
        Me.txtItemAmount.MaxLength = 3
        Me.txtItemAmount.Name = "txtItemAmount"
        Me.txtItemAmount.Size = New System.Drawing.Size(153, 20)
        Me.txtItemAmount.TabIndex = 4
        '
        'lblItemAmount
        '
        Me.lblItemAmount.AutoSize = True
        Me.lblItemAmount.Location = New System.Drawing.Point(3, 55)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Size = New System.Drawing.Size(69, 13)
        Me.lblItemAmount.TabIndex = 3
        Me.lblItemAmount.Text = "Item Quantity"
        '
        'txtItemNumber
        '
        Me.txtItemNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemNumber.Location = New System.Drawing.Point(76, 26)
        Me.txtItemNumber.MaxLength = 9
        Me.txtItemNumber.Name = "txtItemNumber"
        Me.txtItemNumber.Size = New System.Drawing.Size(153, 20)
        Me.txtItemNumber.TabIndex = 2
        '
        'lblItemNumber
        '
        Me.lblItemNumber.AutoSize = True
        Me.lblItemNumber.Location = New System.Drawing.Point(3, 29)
        Me.lblItemNumber.Name = "lblItemNumber"
        Me.lblItemNumber.Size = New System.Drawing.Size(67, 13)
        Me.lblItemNumber.TabIndex = 1
        Me.lblItemNumber.Text = "Item Number"
        '
        'lblCreateOrder
        '
        Me.lblCreateOrder.AutoSize = True
        Me.lblCreateOrder.Location = New System.Drawing.Point(81, 3)
        Me.lblCreateOrder.Name = "lblCreateOrder"
        Me.lblCreateOrder.Size = New System.Drawing.Size(67, 13)
        Me.lblCreateOrder.TabIndex = 0
        Me.lblCreateOrder.Text = "Create Order"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(81, 29)
        Me.Panel1.TabIndex = 1
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
        'formCreateOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 412)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelCreateOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formCreateOrder"
        Me.Text = "formCreateOrder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelCreateOrder.ResumeLayout(False)
        Me.panelCreateOrder.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCreateOrder As Panel
    Friend WithEvents lblCreateOrder As Label
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents txtItemAmount As TextBox
    Friend WithEvents lblItemAmount As Label
    Friend WithEvents txtItemNumber As TextBox
    Friend WithEvents lblItemNumber As Label
    Friend WithEvents lblUserFeedback As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
End Class
