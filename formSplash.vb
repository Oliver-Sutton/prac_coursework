Imports System.IO
Public Class formSplash

    Dim loginUrl = Application.StartupPath + "/files/login.txt"

    Private Sub formSplash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        panelSplash.Left = (Me.Width / 2) - (panelSplash.Width / 2)
        panelSplash.Top = (Me.Height / 2) - (panelSplash.Height / 2)


    End Sub

    Private Sub tmrSplash_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSplash.Tick

        If File.Exists(loginUrl) Then
            formLogin.Show()
            tmrSplash.Enabled = False
            Me.Close()
        Else
            formCreateAdmin.show()
            tmrSplash.Enabled = False
            Me.Close()
        End If

    End Sub
End Class