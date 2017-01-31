Public Class formHome
    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If globalVariables.isAdmin = True Then
            panelAdmin.Visible = True
            labelPositions.center(lblAdminPanel, panelAdmin)
        End If
        labelPositions.center(lblUserPanel, panelUser)
        labelPositions.center(lblUserSettings, panelUserSettings)

        fillOrderList()
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
        Dim loginUrl = Application.StartupPath & "/files/login.txt"
        fileHandler.backupFile(loginUrl)
    End Sub

    Private Sub btnCreateOrder_Click(sender As Object, e As EventArgs) Handles btnCreateOrder.Click
        formCreateOrder.show()
        Me.Close()
    End Sub

    Private Sub btnRefreshOrders_Click(sender As Object, e As EventArgs) Handles btnRefreshOrders.Click
        fillOrderList()
    End Sub

    Private Sub fillOrderList()
        listOrders.Items.Clear()
        Dim orderUrl As String = Application.StartupPath + "/files/orders.txt"
        Dim orders As String = fileHandler.readFile(orderUrl)

        Dim ordersSplit() As String = orders.Split("#")
        Array.Resize(ordersSplit, ordersSplit.Length - 1)

        For i = 0 To ordersSplit.Length - 1
            Dim order() As String = ordersSplit(i).Split(",")
            listOrders.Items.Add(order(0) & "              " & order(1) & "            " & order(2))
        Next
    End Sub

    Private Sub btnFulfilOrder_Click(sender As Object, e As EventArgs) Handles btnFulfilOrder.Click

        Dim fileUrl As String = Application.StartupPath + "/files/orders.txt"

        Dim selectedOrder As String = listOrders.SelectedItem.ToString.Replace(" ", vbNullString)

        Dim orderID As String = selectedOrder.Substring(0, 4)
        Dim itemID As String = selectedOrder.Substring(4, 9)
        Dim itemAmount As String = selectedOrder.Substring(13, selectedOrder.Length - 13)

        listOrders.Items.RemoveAt(listOrders.SelectedIndex)

        fileHandler.removeRecord(fileUrl, orderID, 0)

    End Sub
End Class