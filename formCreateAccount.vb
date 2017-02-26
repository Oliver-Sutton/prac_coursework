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

        Dim validUsername As Boolean = fileHandler.isUnique(loginUrl, username, 2)

        If validUsername = False Then
            lblUserFeedback.Text = "Please enter a different username"
            positioning.labelPanelHorizontalCenter(lblUserFeedback, panelCreateAccount)
        ElseIf validUsername = True Then

            Dim encryptKey As Char = username.Substring(0, 1)

            Dim encFirstname As String = security.encrypt(firstname, encryptKey)
            Dim encLastname As String = security.encrypt(lastname, encryptKey)
            Dim encUsername As String = security.encrypt(username, encryptKey)
            Dim encPermissions As String = security.encrypt("false", encryptKey)

            Dim primaryKey As String = fileHandler.generatePrimaryKey(loginUrl, 0)

            Dim salt As String = security.generateSalt(15)
            Dim hashedPassword As String = security.hash(password, salt)

            Dim records As String() = {primaryKey, encFirstname, encLastname, encUsername, hashedPassword, salt, encPermissions}

            lblUserFeedback.Text = "Account created"
            positioning.labelPanelHorizontalCenter(lblUserFeedback, panelCreateAccount)
            fileHandler.addRecord(loginUrl, records)
            formHome.Show()
            Me.Close()
        End If
    End Sub
End Class