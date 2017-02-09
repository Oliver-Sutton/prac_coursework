Public Class formRemoveAccount
    Private Sub formRemoveAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelRemoveAccount.Left = (Me.Width / 2) - (panelRemoveAccount.Width / 2)
        panelRemoveAccount.Top = (Me.Height / 2) - (panelRemoveAccount.Height / 2)

        labelPositions.center(lblRemoveAccount, panelRemoveAccount)

        Dim firstname, lastname, username As ColumnHeader
        firstname = New ColumnHeader
        lastname = New ColumnHeader
        username = New ColumnHeader

        firstname.Text = "Firstname"
        lastname.Text = "Lastname"
        username.Text = "Username"

        firstname.Width = 90
        lastname.Width = 90
        username.Width = 90

        listAccounts.Columns.Add(firstname)
        listAccounts.Columns.Add(lastname)
        listAccounts.Columns.Add(username)

        fillListAccounts()
    End Sub

    Private Sub fillListAccounts()

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"
        Dim users() As String = fileHandler.readFile(loginUrl)

        Array.Resize(users, users.Length - 1)

        For i = 0 To users.Length - 1
            Dim user() As String = users(i).Split(",")
            If user(4) <> "true" Then
                listAccounts.Items.Add(New ListViewItem({user(0), user(1), user(2)}))
            End If
        Next

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"

        Dim username As String = listAccounts.Items(listAccounts.FocusedItem.Index).SubItems(2).Text

        listAccounts.Items.RemoveAt(listAccounts.FocusedItem.Index)

        fileHandler.removeRecord(loginUrl, username, 2)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Me.Close()
    End Sub
End Class