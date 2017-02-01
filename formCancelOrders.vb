Public Class formCancelOrders
    Private Sub formCancelOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelCancelOrders.Left = (Me.Width / 2) - (panelCancelOrders.Width / 2)
        panelCancelOrders.Top = (Me.Height / 2) - (panelCancelOrders.Height / 2)

        labelPositions.center(lblCancelOrder, panelCancelOrders)

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

    End Sub
End Class