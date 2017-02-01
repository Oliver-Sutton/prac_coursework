Public Class formChangePassword
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"

        Dim currentPassword As String = txtCurrentPassword.Text
        Dim newPassword As String = txtNewPassword.Text
        Dim newPasswordAgain As String = txtNewPasswordAgain.Text

        fileHandler.changeRecord(loginUrl, currentPassword, globalVariables.username, newPassword, 3, 2)

    End Sub
End Class