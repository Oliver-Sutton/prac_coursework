Public Class formHome
    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If globalVariables.isAdmin = True Then
            panelAdmin.Visible = True
            labelPositions.center(lblAdminPanel, panelAdmin)
        End If
        labelPositions.center(lblUserPanel, panelUser)
        labelPositions.center(lblUserSettings, panelUserSettings)

        listOrders.FullRowSelect = True

        Dim orderID, productID, amount As ColumnHeader
        orderID = New ColumnHeader
        productID = New ColumnHeader
        amount = New ColumnHeader

        orderID.Text = "Order ID"
        productID.Text = "Product ID"
        amount.Text = "Amount"

        orderID.Width = 90
        productID.Width = 90
        amount.Width = 90

        listOrders.Columns.Add(orderID)
        listOrders.Columns.Add(productID)
        listOrders.Columns.Add(amount)

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
            listOrders.Items.Add(New ListViewItem({order(0), order(1), order(2)}))
        Next
    End Sub

    Private Sub btnFulfilOrder_Click(sender As Object, e As EventArgs) Handles btnFulfilOrder.Click

        Dim fileUrl As String = Application.StartupPath + "/files/orders.txt"

        Dim orderID As String = listOrders.Items(listOrders.FocusedItem.Index).SubItems(0).Text
        Dim productID As String = listOrders.Items(listOrders.FocusedItem.Index).SubItems(1).Text
        Dim amount As String = listOrders.Items(listOrders.FocusedItem.Index).SubItems(2).Text

        listOrders.Items.RemoveAt(listOrders.FocusedItem.Index)

        fileHandler.removeRecord(fileUrl, orderID, 0)

    End Sub

    Private Sub btnBackupOrders_Click(sender As Object, e As EventArgs) Handles btnBackupOrders.Click
        Dim ordersUrl As String = Application.StartupPath + "/files/orders.txt"
        fileHandler.backupFile(ordersUrl)
    End Sub
End Class