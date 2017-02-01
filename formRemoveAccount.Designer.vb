<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRemoveAccount
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
        Me.panelRemoveAccount = New System.Windows.Forms.Panel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.listAccounts = New System.Windows.Forms.ListView()
        Me.lblRemoveAccount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelRemoveAccount.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelRemoveAccount
        '
        Me.panelRemoveAccount.Controls.Add(Me.btnRemove)
        Me.panelRemoveAccount.Controls.Add(Me.listAccounts)
        Me.panelRemoveAccount.Controls.Add(Me.lblRemoveAccount)
        Me.panelRemoveAccount.Location = New System.Drawing.Point(83, 101)
        Me.panelRemoveAccount.Name = "panelRemoveAccount"
        Me.panelRemoveAccount.Size = New System.Drawing.Size(313, 273)
        Me.panelRemoveAccount.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(0, 247)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(310, 23)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove Account"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'listAccounts
        '
        Me.listAccounts.FullRowSelect = True
        Me.listAccounts.Location = New System.Drawing.Point(3, 19)
        Me.listAccounts.Name = "listAccounts"
        Me.listAccounts.Size = New System.Drawing.Size(307, 222)
        Me.listAccounts.TabIndex = 1
        Me.listAccounts.UseCompatibleStateImageBehavior = False
        Me.listAccounts.View = System.Windows.Forms.View.Details
        '
        'lblRemoveAccount
        '
        Me.lblRemoveAccount.AutoSize = True
        Me.lblRemoveAccount.Location = New System.Drawing.Point(109, 3)
        Me.lblRemoveAccount.Name = "lblRemoveAccount"
        Me.lblRemoveAccount.Size = New System.Drawing.Size(90, 13)
        Me.lblRemoveAccount.TabIndex = 0
        Me.lblRemoveAccount.Text = "Remove Account"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 28)
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
        'formRemoveAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelRemoveAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formRemoveAccount"
        Me.Text = "formRemoveAccount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelRemoveAccount.ResumeLayout(False)
        Me.panelRemoveAccount.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelRemoveAccount As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents listAccounts As ListView
    Friend WithEvents lblRemoveAccount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
End Class
