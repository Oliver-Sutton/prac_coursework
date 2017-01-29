<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.panelSplash = New System.Windows.Forms.Panel()
        Me.lblSplash = New System.Windows.Forms.Label()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.panelSplash.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSplash
        '
        Me.panelSplash.Controls.Add(Me.lblSplash)
        Me.panelSplash.Location = New System.Drawing.Point(27, 58)
        Me.panelSplash.Name = "panelSplash"
        Me.panelSplash.Size = New System.Drawing.Size(81, 14)
        Me.panelSplash.TabIndex = 0
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.Location = New System.Drawing.Point(3, 0)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(76, 13)
        Me.lblSplash.TabIndex = 0
        Me.lblSplash.Text = "Splash Screen"
        '
        'tmrSplash
        '
        Me.tmrSplash.Enabled = True
        Me.tmrSplash.Interval = 2000
        '
        'formSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.panelSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formSplash"
        Me.Text = "Splash Screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelSplash.ResumeLayout(False)
        Me.panelSplash.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelSplash As System.Windows.Forms.Panel
    Friend WithEvents lblSplash As System.Windows.Forms.Label
    Friend WithEvents tmrSplash As System.Windows.Forms.Timer
End Class
