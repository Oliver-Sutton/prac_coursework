Imports System.IO
Public Class formCreateOrder
    Private Sub formCreateOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelCreateOrder.Left = (Me.Width / 2) - (panelCreateOrder.Width / 2)
        panelCreateOrder.Top = (Me.Height / 2) - (panelCreateOrder.Height / 2)

        labelPositions.center(lblCreateOrder, panelCreateOrder)
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

        Dim itemNumber As String = txtProductID.Text
        Dim itemAmount As String = txtItemAmount.Text

        Dim orderID As String = createOrderID()

        Dim orderFileUrl As String = Application.StartupPath + "/files/orders.txt"

        If itemNumber.Length <> 9 Then
            lblUserFeedback.Text = "Please enter a valid item number"
            labelPositions.center(lblUserFeedback, panelCreateOrder)
            lblUserFeedback.Visible = True
        ElseIf itemAmount.Length = 0 Or itemAmount = "0" Or Not IsNumeric(itemAmount) Then
            lblUserFeedback.Text = "Please enter a valid item quantity"
            labelPositions.center(lblUserFeedback, panelCreateOrder)
            lblUserFeedback.Visible = True
        Else
            lblUserFeedback.Visible = False
        End If

        If fileHandler.isUnique(orderID, orderFileUrl, 0) Then
            Do Until fileHandler.isUnique(orderID, orderFileUrl, 0)
                orderID = createOrderID()
            Loop
            fileHandler.addRecord(orderFileUrl, orderID & "," & itemNumber & "," & itemAmount)
            txtProductID.Clear()
            txtItemAmount.Clear()
            lblUserFeedback.Text = "Order ID = " & orderID
            labelPositions.center(lblUserFeedback, panelCreateOrder)
            lblUserFeedback.Visible = True
        End If


    End Sub

    Private Sub txtItemNumber_TextChanged(sender As Object, e As EventArgs) Handles txtProductID.TextChanged

        Dim text As String = txtProductID.Text

        If text.Length = 2 Or text.Length = 6 Then
            txtProductID.SelectedText += "-"
        End If

    End Sub

    Function createOrderID() As String

        Dim chars() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray()
        Dim orderID As String = ""

        For i = 0 To 3
            Randomize()
            Dim intChar = Int(36 * Rnd())
            orderID += chars(intChar)
        Next

        Return orderID

    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Me.Close()
    End Sub
End Class