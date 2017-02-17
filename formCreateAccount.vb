Imports System.IO
Public Class formCreateAccount
    Private Sub formCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelCreateAccount.Left = (Me.Width / 2) - (panelCreateAccount.Width / 2)
        panelCreateAccount.Top = (Me.Height / 2) - (panelCreateAccount.Height / 2)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"

        Dim firstname As String = txtFirstname.Text
        Dim lastname As String = txtLastname.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim passwordAgain As String = txtPasswordAgain.Text

        Dim validUsername As Boolean = fileHandler.isUnique(username, loginUrl, 2)

        If validUsername = False Then
            lblUserFeedback.Text = "Please enter a different username"
            positioning.lblCenter(lblUserFeedback, panelCreateAccount, 0)
        ElseIf validUsername = True Then
            lblUserFeedback.Text = "Account created"
            positioning.lblCenter(lblUserFeedback, panelCreateAccount, 0)
            fileHandler.addRecord(loginUrl, firstname & "," & lastname & "," & username & "," & password & ",false")
            formHome.Show()
            Me.Close()
        End If
    End Sub
End Class