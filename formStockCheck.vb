Public Class formStockCheck
    Private Sub formStockCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelStockCheck.Left = (Me.Width / 2) - (panelStockCheck.Width / 2)
        panelStockCheck.Top = (Me.Height / 2) - (panelStockCheck.Height / 2)

        lblStockNumber.Visible = False
        lblStockNumber.Text = "Placeholder"

    End Sub

    Private Sub btnCheckStock_Click(sender As Object, e As EventArgs) Handles btnCheckStock.Click
        lblUserFeedback.Visible = False

        Dim productsUrl As String = Application.StartupPath + "/files/products.txt"

        Dim itemID As String = txtProductID.Text

        If itemID.Length <> 9 Then
            lblUserFeedback.Text = "Please enter a valid product number"
            labelPositions.center(lblUserFeedback, panelStockCheck)
            lblUserFeedback.Visible = True
            Exit Sub
        End If

        Dim products() As String = fileHandler.readFile(productsUrl)
        Array.Resize(products, products.Length - 1)

        For i = 0 To products.Length - 1
            Dim product() As String = products(i).Split(",")

            If product(0) = itemID Then
                lblStockNumber.Text = product(1)
                lblStockNumber.Visible = True
                lblInStock.Visible = True
                Exit Sub
            End If
        Next

        lblUserFeedback.Text = "Product not found"
        labelPositions.center(lblUserFeedback, panelStockCheck)
        lblUserFeedback.Visible = True

    End Sub

    Private Sub txtItemID_TextChanged(sender As Object, e As EventArgs) Handles txtProductID.TextChanged

        Dim text As String = txtProductID.Text

        If text.Length = 2 Or text.Length = 6 Then
            txtProductID.SelectedText += "-"
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Me.Close()
    End Sub
End Class