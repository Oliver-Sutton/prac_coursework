Public Class formHome
    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If globalVariables.isAdmin = True Then
            panelAdmin.Visible = True
            positioning.labelPanelHorizontalCenter(lblAdminPanel, panelAdmin)
        End If
        positioning.labelPanelHorizontalCenter(lblUserPanel, panelUser)
        positioning.labelPanelHorizontalCenter(lblUserSettings, panelUserSettings)

        panelNav.Left = Me.Width - (panelNav.Width + 20)

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
        Dim orders() As String = fileHandler.readFile(orderUrl)

        For i = 0 To orders.Length - 1
            Dim order() As String = orders(i).Split(",")
            listOrders.Items.Add(New ListViewItem({order(0), order(1), order(2)}))
        Next
    End Sub

    Private Sub btnFulfilOrder_Click(sender As Object, e As EventArgs) Handles btnFulfilOrder.Click

        Dim ordersUrl As String = Application.StartupPath + "/files/orders.txt"
        Dim productsUrl As String = Application.StartupPath + "/files/products.txt"

        Dim orderID As String = listOrders.Items(listOrders.FocusedItem.Index).SubItems(0).Text
        Dim productID As String = listOrders.Items(listOrders.FocusedItem.Index).SubItems(1).Text
        Dim amount As String = listOrders.Items(listOrders.FocusedItem.Index).SubItems(2).Text

        Dim product() As String = fileHandler.getRecord(productsUrl, productID, 0).Split(",")

        Dim productAmountNew As Integer = CInt(product(1))

        productAmountNew -= CInt(amount)

        If productAmountNew < 0 Then
            MsgBox("Product out of stock or not enough to fulfil order")
            Exit Sub
        End If

        fileHandler.removeRecord(ordersUrl, orderID, 0)
        fileHandler.changeRecord(productsUrl, product(1), productID, productAmountNew, 1, 0)

        listOrders.Items.RemoveAt(listOrders.FocusedItem.Index)

    End Sub

    Private Sub btnBackupOrders_Click(sender As Object, e As EventArgs) Handles btnBackupOrders.Click
        Dim ordersUrl As String = Application.StartupPath + "/files/orders.txt"
        fileHandler.backupFile(ordersUrl)
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        formCancelOrders.show()
        Me.Close()
    End Sub

    Private Sub btnStockCheck_Click(sender As Object, e As EventArgs) Handles btnStockCheck.Click
        formStockCheck.show()
        Me.Close()
    End Sub

    Private Sub btnBackupProducts_Click(sender As Object, e As EventArgs) Handles btnBackupProducts.Click
        Dim productsUrl As String = Application.StartupPath + "/files/products.txt"
        fileHandler.backupFile(productsUrl)
    End Sub

    Private Sub btnBackupAll_Click(sender As Object, e As EventArgs) Handles btnBackupAll.Click

        Dim loginUrl As String = Application.StartupPath + "/files/login.txt"
        Dim ordersUrl As String = Application.StartupPath + "/files/orders.txt"
        Dim productsUrl As String = Application.StartupPath + "/files/products.txt"

        fileHandler.backupFile(loginUrl)
        fileHandler.backupFile(ordersUrl)
        fileHandler.backupFile(productsUrl)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnRemoveAccount_Click(sender As Object, e As EventArgs) Handles btnRemoveAccount.Click
        formRemoveAccount.show()
        Me.Close()
    End Sub
End Class