<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formChangePassword
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
        Me.panelChangePassword = New System.Windows.Forms.Panel()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.txtNewPasswordAgain = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPasswordAgain = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.lblUserFeedback = New System.Windows.Forms.Label()
        Me.panelChangePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelChangePassword
        '
        Me.panelChangePassword.Controls.Add(Me.lblUserFeedback)
        Me.panelChangePassword.Controls.Add(Me.btnChangePassword)
        Me.panelChangePassword.Controls.Add(Me.txtNewPasswordAgain)
        Me.panelChangePassword.Controls.Add(Me.txtNewPassword)
        Me.panelChangePassword.Controls.Add(Me.txtCurrentPassword)
        Me.panelChangePassword.Controls.Add(Me.lblNewPasswordAgain)
        Me.panelChangePassword.Controls.Add(Me.lblNewPassword)
        Me.panelChangePassword.Controls.Add(Me.lblCurrentPassword)
        Me.panelChangePassword.Location = New System.Drawing.Point(55, 121)
        Me.panelChangePassword.Name = "panelChangePassword"
        Me.panelChangePassword.Size = New System.Drawing.Size(209, 123)
        Me.panelChangePassword.TabIndex = 0
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(6, 81)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(200, 23)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'txtNewPasswordAgain
        '
        Me.txtNewPasswordAgain.Location = New System.Drawing.Point(106, 55)
        Me.txtNewPasswordAgain.Name = "txtNewPasswordAgain"
        Me.txtNewPasswordAgain.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPasswordAgain.TabIndex = 5
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(106, 29)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPassword.TabIndex = 4
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Location = New System.Drawing.Point(106, 3)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentPassword.TabIndex = 3
        '
        'lblNewPasswordAgain
        '
        Me.lblNewPasswordAgain.AutoSize = True
        Me.lblNewPasswordAgain.Location = New System.Drawing.Point(3, 58)
        Me.lblNewPasswordAgain.Name = "lblNewPasswordAgain"
        Me.lblNewPasswordAgain.Size = New System.Drawing.Size(78, 13)
        Me.lblNewPasswordAgain.TabIndex = 2
        Me.lblNewPasswordAgain.Text = "New Password"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(3, 32)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblNewPassword.TabIndex = 1
        Me.lblNewPassword.Text = "New Password"
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.Location = New System.Drawing.Point(3, 6)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(90, 13)
        Me.lblCurrentPassword.TabIndex = 0
        Me.lblCurrentPassword.Text = "Current Password"
        '
        'lblUserFeedback
        '
        Me.lblUserFeedback.AutoSize = True
        Me.lblUserFeedback.Location = New System.Drawing.Point(68, 107)
        Me.lblUserFeedback.Name = "lblUserFeedback"
        Me.lblUserFeedback.Size = New System.Drawing.Size(63, 13)
        Me.lblUserFeedback.TabIndex = 7
        Me.lblUserFeedback.Text = "Placeholder"
        '
        'formChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 439)
        Me.Controls.Add(Me.panelChangePassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formChangePassword"
        Me.Text = "formChangePassword"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelChangePassword.ResumeLayout(False)
        Me.panelChangePassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelChangePassword As Panel
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents txtNewPasswordAgain As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents lblNewPasswordAgain As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents lblUserFeedback As Label
End Class
