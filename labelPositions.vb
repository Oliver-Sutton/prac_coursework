Module positioning

    ''' <summary>
    '''     Positions a label on inside a panel.
    ''' </summary>
    ''' <param name="label">Label you want to position.</param>
    ''' <param name="panel">Panel you want the label positioned in.</param>
    ''' <param name="paddingTop">How many pixels from the top of the panel you want the label positioned from the position on design view.</param>
    ''' <param name="paddingLeft">How many pixels from the left of the panel you want the label to position from the position on design view.</param>
    Public Sub lblLeft(ByVal label As Label, ByVal panel As Panel, ByVal paddingTop As Integer, ByVal paddingLeft As Integer)



    End Sub

    ''' <summary>
    '''     Positions a label on inside a form.
    ''' </summary>
    ''' <param name="label">Label you want to position.</param>
    ''' <param name="form">Form you want the label positioned in.</param>
    ''' <param name="paddingTop">How many pixels from the top of the form you want the label positioned from the position on design view.</param>
    ''' <param name="paddingLeft">How many pixels from the left of the form you want the label to position from the position on design view.</param>
    Public Sub lblLeft(ByVal label As Label, ByVal form As Form, ByVal paddingtop As Integer, ByVal paddingleft As Integer)



    End Sub

    ''' <summary>
    '''     Positions a label in the center of a panel
    ''' </summary>
    ''' <param name="label">The label you want to center.</param>
    ''' <param name="panel">The panel you want to center the label in.</param>
    ''' <param name="paddingTop">How many pixels from the top of the panel you want the label to position from the position on design view.</param>
    Public Sub lblCenter(ByVal label As Label, ByVal panel As Panel, ByVal paddingTop As Integer)

        label.Left = (panel.Width / 2) - (label.Width / 2)
        label.Top += paddingTop
        label.Visible = True

    End Sub

    ''' <summary>
    '''     Positions a label in the center of a form.
    ''' </summary>
    ''' <param name="label">The label you want to center.</param>
    ''' <param name="form">The form you want to center the label in.</param>
    ''' <param name="paddingTop">How many pixels from the top of the form you want the label to positions from the position on design view.</param>
    Public Sub lblCenter(ByVal label As Label, ByVal form As Form, ByVal paddingTop As Integer)

        label.Left = (form.Width / 2) - (label.Width / 2)
        label.Visible = True

    End Sub
End Module
