<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCreateAccount
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
        Me.panelCreateAccount = New System.Windows.Forms.Panel()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.txtPasswordAgain = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblUserFeedback = New System.Windows.Forms.Label()
        Me.lblPasswordAgain = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.panelCreateAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCreateAccount
        '
        Me.panelCreateAccount.Controls.Add(Me.btnCreateAccount)
        Me.panelCreateAccount.Controls.Add(Me.txtPasswordAgain)
        Me.panelCreateAccount.Controls.Add(Me.txtPassword)
        Me.panelCreateAccount.Controls.Add(Me.txtUsername)
        Me.panelCreateAccount.Controls.Add(Me.txtLastname)
        Me.panelCreateAccount.Controls.Add(Me.txtFirstname)
        Me.panelCreateAccount.Controls.Add(Me.lblUserFeedback)
        Me.panelCreateAccount.Controls.Add(Me.lblPasswordAgain)
        Me.panelCreateAccount.Controls.Add(Me.lblPassword)
        Me.panelCreateAccount.Controls.Add(Me.lblUsername)
        Me.panelCreateAccount.Controls.Add(Me.lblLastname)
        Me.panelCreateAccount.Controls.Add(Me.lblFirstname)
        Me.panelCreateAccount.Location = New System.Drawing.Point(268, 160)
        Me.panelCreateAccount.Name = "panelCreateAccount"
        Me.panelCreateAccount.Size = New System.Drawing.Size(311, 177)
        Me.panelCreateAccount.TabIndex = 0
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(6, 133)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(299, 23)
        Me.btnCreateAccount.TabIndex = 11
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'txtPasswordAgain
        '
        Me.txtPasswordAgain.Location = New System.Drawing.Point(61, 107)
        Me.txtPasswordAgain.Name = "txtPasswordAgain"
        Me.txtPasswordAgain.Size = New System.Drawing.Size(244, 20)
        Me.txtPasswordAgain.TabIndex = 10
        Me.txtPasswordAgain.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(61, 81)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(244, 20)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(61, 55)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(244, 20)
        Me.txtUsername.TabIndex = 8
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(61, 29)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(244, 20)
        Me.txtLastname.TabIndex = 7
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(61, 3)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(244, 20)
        Me.txtFirstname.TabIndex = 6
        '
        'lblUserFeedback
        '
        Me.lblUserFeedback.AutoSize = True
        Me.lblUserFeedback.Location = New System.Drawing.Point(119, 159)
        Me.lblUserFeedback.Name = "lblUserFeedback"
        Me.lblUserFeedback.Size = New System.Drawing.Size(63, 13)
        Me.lblUserFeedback.TabIndex = 5
        Me.lblUserFeedback.Text = "Placeholder"
        Me.lblUserFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPasswordAgain
        '
        Me.lblPasswordAgain.AutoSize = True
        Me.lblPasswordAgain.Location = New System.Drawing.Point(3, 110)
        Me.lblPasswordAgain.Name = "lblPasswordAgain"
        Me.lblPasswordAgain.Size = New System.Drawing.Size(53, 13)
        Me.lblPasswordAgain.TabIndex = 4
        Me.lblPasswordAgain.Text = "Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(3, 84)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(3, 58)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Location = New System.Drawing.Point(3, 32)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(53, 13)
        Me.lblLastname.TabIndex = 1
        Me.lblLastname.Text = "Lastname"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(3, 6)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(52, 13)
        Me.lblFirstname.TabIndex = 0
        Me.lblFirstname.Text = "Firstname"
        '
        'formCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 535)
        Me.Controls.Add(Me.panelCreateAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formCreateAccount"
        Me.Text = "a"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelCreateAccount.ResumeLayout(False)
        Me.panelCreateAccount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCreateAccount As Panel
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents txtPasswordAgain As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents lblUserFeedback As Label
    Friend WithEvents lblPasswordAgain As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblFirstname As Label
End Class
