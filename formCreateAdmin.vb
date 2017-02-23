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

            Dim encryptKey As Char = username.Substring(0, 1)

            Dim encFirstname As String = security.encryptKey(firstname, encryptKey)
            Dim encLastname As String = security.encryptKey(lastname, encryptKey)
            Dim encUsername As String = security.encryptKey(username, encryptKey)
            Dim encPermissions As String = security.encryptKey("true", encryptKey)

            Dim primaryKey As String = fileHandler.generatePrimaryKey(loginUrl, 0)

            Dim salt As String = security.generateSalt(15)
            Dim hashedPassword As String = security.hash(password, salt)

            Dim records As String() = {primaryKey, encFirstname, encLastname, encUsername, hashedPassword, salt, encPermissions}

            fileHandler.addRecord(loginUrl, records)
            formLogin.Show()
            Me.Close()
        Else
            If firstname.Length = 0 Or lastname.Length = 0 Then
                lblUserFeedback.Text = "Please enter a first and last name"
                positioning.labelPanel(lblUserFeedback, panelCreateAccount, 0, -1)
            ElseIf username.Length <= 0 Then
                lblUserFeedback.Text = "Please enter a valid username."
                positioning.labelPanel(lblUserFeedback, panelCreateAccount, 0, -1)
            ElseIf password <> passwordAgain Then
                lblUserFeedback.Text = "Please make sure your passwords match"
                positioning.labelPanel(lblUserFeedback, panelCreateAccount, 0, -1)
            End If
        End If
    End Sub
End Class