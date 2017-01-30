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
            labelPositions.center(lblUserFeedback, panelCreateAccount)
        ElseIf validUsername = True Then
            lblUserFeedback.Text = "Account created"
            labelPositions.center(lblUserFeedback, panelCreateAccount)
            saveNewAccount(firstname, lastname, username, password)
            formHome.Show()
            Me.Close()
        End If
    End Sub

    ''' <summary>
    '''     Inputs newAccount data into the login file when called.
    ''' </summary>
    ''' file format Firstname, Lastname, username, password, isAdmin (bool)
    ''' <param name="firstname"></param>
    ''' <param name="lastname"></param>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    Private Sub saveNewAccount(firstname As String, lastname As String, username As String, password As String)

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"
        Dim fileStream As FileStream = New FileStream(loginUrl, FileMode.Append, FileAccess.Write)
        Dim fileWriter As StreamWriter = New StreamWriter(fileStream)

        fileWriter.WriteLine(firstname & "," & lastname & "," & username & "," & password & ",false#")

        fileWriter.Flush()
        fileWriter.Close()
        fileStream.Close()

    End Sub


End Class