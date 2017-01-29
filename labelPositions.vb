Module labelPositions
    Public Sub center(label As Label, panel As Panel)

        label.Left = (panel.Width / 2) - (label.Width / 2)
        label.Visible = True

    End Sub
End Module
