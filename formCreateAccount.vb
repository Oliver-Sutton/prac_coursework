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
            positioning.labelPanel(lblUserFeedback, panelCreateAccount, 0, -1)
        ElseIf validUsername = True Then

            Dim encryptKey As Char = username.Substring(0, 1)

            Dim encFirstname As String = security.encrypt(firstname, encryptKey)
            Dim encLastname As String = security.encrypt(lastname, encryptKey)
            Dim encUsername As String = security.encrypt(username, encryptKey)

            Dim salt As String = security.generateSalt(15)
            Dim hashedPassword As String = security.hash(password, salt)

            lblUserFeedback.Text = "Account created"
            positioning.labelPanel(lblUserFeedback, panelCreateAccount, 0, -1)
            fileHandler.addRecord(loginUrl, encFirstname & "," & encLastname & "," & encUsername & "," & hashedPassword & "," & salt & ",false")
            formHome.Show()
            Me.Close()
        End If
    End Sub
End Class