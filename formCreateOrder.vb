Imports System.IO
Public Class formCreateOrder
    Private Sub formCreateOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelCreateOrder.Left = (Me.Width / 2) - (panelCreateOrder.Width / 2)
        panelCreateOrder.Top = (Me.Height / 2) - (panelCreateOrder.Height / 2)

        labelPositions.center(lblCreateOrder, panelCreateOrder)
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim itemNumber As String = txtItemNumber.Text
        Dim itemAmount As String = txtItemAmount.Text

        Dim orderID As String = Guid.NewGuid().ToString.Substring(0, 7)

        Dim orderFileUrl As String = Application.StartupPath + "/files/orders.txt"

        If itemNumber.Length <> 7 Then
            lblUserFeedback.Text = "Please enter a valid item number"
            labelPositions.center(lblUserFeedback, panelCreateOrder)
            lblUserFeedback.Visible = True
        ElseIf itemAmount.Length = 0 Or itemAmount = "0" Then
            lblUserFeedback.Text = "Please enter a valid item quantity"
            labelPositions.center(lblUserFeedback, panelCreateOrder)
            lblUserFeedback.Visible = True
        Else
            lblUserFeedback.Visible = False
        End If

        If fileHandler.isUnique(orderID, orderFileUrl, 0) Then
            Do
                orderID = Guid.NewGuid().ToString.Substring(0, 7)
            Loop Until fileHandler.isUnique(orderID, orderFileUrl, 0)
            saveOrder(orderID, itemNumber, itemAmount)
        End If
    End Sub

    Private Sub saveOrder(orderID As String, itemNumber As String, itemAmount As String)

        Dim fileUrl As String = Application.StartupPath + "/files/orders.txt"

        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Append, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStream)

        writerStream.WriteLine(orderID & "," & itemNumber & "," & itemAmount & "#")

        writerStream.Flush()
        writerStream.Close()
        fileStream.Close()

    End Sub
End Class