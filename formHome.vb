Public Class formHome
    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If globalVariables.isAdmin = True Then
            panelAdmin.Visible = True
            labelPositions.center(lblAdminPanel, panelAdmin)
        End If
        labelPositions.center(lblUserPanel, panelUser)
        labelPositions.center(lblUserSettings, panelUserSettings)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        globalVariables.isAdmin = False
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        formCreateAccount.Show()
        Me.Close()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        formChangePassword.Show()
        Me.Close()
    End Sub

    Private Sub btnBackupLogins_Click(sender As System.Object, e As System.EventArgs) Handles btnBackupLogins.Click
        Dim loginUrl = Application.StartupPath + "/files/login.txt"
        fileHandler.backupFile(loginUrl)
    End Sub

    Private Sub btnCreateOrder_Click(sender As Object, e As EventArgs) Handles btnCreateOrder.Click
        formCreateOrder.show()
        Me.Close()
    End Sub
End Class