<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCancelOrders
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
        Me.panelCancelOrders = New System.Windows.Forms.Panel()
        Me.lblCancelOrder = New System.Windows.Forms.Label()
        Me.btnRefreshOrders = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.listOrders = New System.Windows.Forms.ListView()
        Me.panelCancelOrders.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCancelOrders
        '
        Me.panelCancelOrders.Controls.Add(Me.lblCancelOrder)
        Me.panelCancelOrders.Controls.Add(Me.btnRefreshOrders)
        Me.panelCancelOrders.Controls.Add(Me.btnCancelOrder)
        Me.panelCancelOrders.Controls.Add(Me.listOrders)
        Me.panelCancelOrders.Location = New System.Drawing.Point(99, 94)
        Me.panelCancelOrders.Name = "panelCancelOrders"
        Me.panelCancelOrders.Size = New System.Drawing.Size(306, 277)
        Me.panelCancelOrders.TabIndex = 0
        '
        'lblCancelOrder
        '
        Me.lblCancelOrder.AutoSize = True
        Me.lblCancelOrder.Location = New System.Drawing.Point(126, 3)
        Me.lblCancelOrder.Name = "lblCancelOrder"
        Me.lblCancelOrder.Size = New System.Drawing.Size(69, 13)
        Me.lblCancelOrder.TabIndex = 3
        Me.lblCancelOrder.Text = "Cancel Order"
        '
        'btnRefreshOrders
        '
        Me.btnRefreshOrders.Location = New System.Drawing.Point(3, 251)
        Me.btnRefreshOrders.Name = "btnRefreshOrders"
        Me.btnRefreshOrders.Size = New System.Drawing.Size(300, 23)
        Me.btnRefreshOrders.TabIndex = 2
        Me.btnRefreshOrders.Text = "Refresh Order"
        Me.btnRefreshOrders.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(3, 222)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(300, 23)
        Me.btnCancelOrder.TabIndex = 1
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'listOrders
        '
        Me.listOrders.FullRowSelect = True
        Me.listOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listOrders.Location = New System.Drawing.Point(3, 26)
        Me.listOrders.Name = "listOrders"
        Me.listOrders.Size = New System.Drawing.Size(300, 190)
        Me.listOrders.TabIndex = 0
        Me.listOrders.UseCompatibleStateImageBehavior = False
        Me.listOrders.View = System.Windows.Forms.View.Details
        '
        'formCancelOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 442)
        Me.Controls.Add(Me.panelCancelOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formCancelOrders"
        Me.Text = "formCancelOrders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelCancelOrders.ResumeLayout(False)
        Me.panelCancelOrders.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCancelOrders As Panel
    Friend WithEvents btnRefreshOrders As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents listOrders As ListView
    Friend WithEvents lblCancelOrder As Label
End Class
