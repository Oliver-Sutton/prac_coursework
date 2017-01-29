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
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCreateAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateAccount.Click

        Dim firstname = txtFirstname.Text
        Dim lastname = txtLastname.Text
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        Dim passwordAgain = txtPasswordAgain.Text

        If firstname.Length <> 0 And lastname.Length <> 0 And username.Length <> 0 And password = passwordAgain Then
            saveAdminAccount(firstname, lastname, username, password)
        Else
            If firstname.Length = 0 Or lastname.Length = 0 Then
                lblUserFeedback.Text = "Please enter a first and last name"
                labelPositions.center(lblUserFeedback, panelCreateAccount)
            ElseIf username.Length <= 0 Then
                lblUserFeedback.Text = "Please enter a valid username."
                labelPositions.center(lblUserFeedback, panelCreateAccount)
            ElseIf password <> passwordAgain Then
                lblUserFeedback.Text = "Please make sure your passwords match"
                labelPositions.center(lblUserFeedback, panelCreateAccount)
            End If
        End If
    End Sub

    ''' <summary>
    '''     When called inserts admin account into the login file.
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    Private Sub saveAdminAccount(firstname As String, lastname As String, username As String, password As String)

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"
        Dim fileStream As FileStream = New FileStream(loginUrl, FileMode.Append, FileAccess.Write)
        Dim fileWriter As StreamWriter = New StreamWriter(fileStream)

        fileWriter.WriteLine(firstname & "," & lastname & "," & username & "," & password & ",true" & "#")

        lblUserFeedback.Text = "Account created"
        labelPositions.center(lblUserFeedback, panelCreateAccount)

        fileWriter.Flush()
        fileWriter.Close()
        fileStream.Close()

    End Sub
End Class