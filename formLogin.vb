Imports System.IO
Public Class formLogin

    Private Sub formLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        panelLogin.Left = (Me.Width / 2) - (panelLogin.Width / 2)
        panelLogin.Top = (Me.Height / 2) - (panelLogin.Height / 2)
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click

        Dim loggedIn As Boolean = False
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"

        Dim users() As String = fileHandler.readFile(loginUrl)

        '' file format Firstname, Lastname, username, password, isAdmin (bool)

        For i = 0 To users.Length - 1
            Dim userInfo() As String
            userInfo = users(i).Split(",")
            If username = userInfo(2) And password = userInfo(3) Then
                lblUserFeedback.Text = "Logged in"
                loggedIn = True
                globalVariables.username = username
                If userInfo(4) = "true" Then
                    globalVariables.isAdmin = True
                End If
                formHome.Show()
                Me.Close()
                Exit For
            End If
        Next

        If loggedIn = False Then
            lblUserFeedback.Text = "Account not found"
        End If

        positioning.lblCenter(lblUserFeedback, panelLogin, 0)

    End Sub
End Class
