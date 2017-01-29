Public Class formChangePassword
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"

        Dim currentPassword As String = txtCurrentPassword.Text
        Dim newPassword As String = txtNewPassword.Text
        Dim newPasswordAgain As String = txtNewPasswordAgain.Text

        fileHandler.changeUser(loginUrl, globalVariables.username, newPassword, 3)

    End Sub
End Class