Imports System.IO

' Within the login file primary key will be the username.

Public Class formCreateAdmin

    Private Sub createAdminAccount_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        panelCreateAccount.Left = (Me.Width / 2) - (panelCreateAccount.Width / 2)
        panelCreateAccount.Top = (Me.Height / 2) - (panelCreateAccount.Height / 2)

    End Sub

    ''' <summary>
    '''     On button click validates all information in the inputs depending on outcome does action.
    ''' </summary>
    Private Sub btnCreateAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateAccount.Click

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"

        Dim firstname = txtFirstname.Text
        Dim lastname = txtLastname.Text
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        Dim passwordAgain = txtPasswordAgain.Text

        If firstname.Length <> 0 And lastname.Length <> 0 And username.Length <> 0 And password = passwordAgain Then
            fileHandler.addRecord(loginUrl, firstname & "," & lastname & "," & username & "," & password & ",true")
            formHome.Show()
            Me.Close()
        Else
            If firstname.Length = 0 Or lastname.Length = 0 Then
                lblUserFeedback.Text = "Please enter a first and last name"
                positioning.lblCenter(lblUserFeedback, panelCreateAccount, 0)
            ElseIf username.Length <= 0 Then
                lblUserFeedback.Text = "Please enter a valid username."
                positioning.lblCenter(lblUserFeedback, panelCreateAccount, 0)
            ElseIf password <> passwordAgain Then
                lblUserFeedback.Text = "Please make sure your passwords match"
                positioning.lblCenter(lblUserFeedback, panelCreateAccount, 0)
            End If
        End If
    End Sub
End Class