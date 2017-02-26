Module positioning

    ''' <summary>
    '''     Horizontally centers a label in a panel.
    ''' </summary>
    ''' <param name="label">Label you want to center.</param>
    ''' <param name="panel">Panel you want to center the label in.</param>
    Public Sub labelPanelHorizontalCenter(ByVal label As Label, ByVal panel As Panel)
        label.Left = (panel.Width / 2) - (label.Width / 2)
    End Sub

    ''' <summary>
    '''     Vertically center a label in a panel.
    ''' </summary>
    ''' <param name="label">Label you want to center.</param>
    ''' <param name="panel">Panel you want to center the label in.</param>
    Public Sub labelPanelVerticalCenter(ByVal label As Label, ByVal panel As Panel)
        label.Top = (panel.Height / 2) - (label.Height / 2)
    End Sub

    ''' <summary>
    '''     Horizontally centers a label in a form.
    ''' </summary>
    ''' <param name="label">Label you want to center.</param>
    ''' <param name="form">Form you want to center the label in. (Usally just Me)</param>
    Public Sub labelFormHorizontalCenter(ByVal label As Label, ByVal form As Form)
        label.Left = (form.Width / 2) - (label.Width / 2)
    End Sub

    ''' <summary>
    '''     Verically center a label in a form.
    ''' </summary>
    ''' <param name="label">Label you want to center.</param>
    ''' <param name="form">Form you want to center the label in. (Usally just Me)</param>
    Public Sub labelFormVerticalCenter(ByVal label As Label, ByVal form As Form)
        label.Top = (form.Height / 2) - (label.Height / 2)
    End Sub

    ''' <summary>
    '''     Horizontally center a panel in a form.
    ''' </summary>
    ''' <param name="panel">Panel you want to center.</param>
    ''' <param name="form">Form you want to center the panel in. (Usally juse Me)</param>
    Public Sub panelFormHorizontalCenter(ByVal panel As Panel, ByVal form As Form)
        panel.Top = (form.Height / 2) - (panel.Height / 2)
    End Sub

    ''' <summary>
    '''     Vertically center a panel in a form.
    ''' </summary>
    ''' <param name="panel">Panel you want to center.</param>
    ''' <param name="form">Form you want to center the panel in. (Usally juse Me)</param>
    Public Sub panelFormVerticalCenter(ByVal panel As Panel, ByVal form As Form)
        panel.Left = (form.Width / 2) - (panel.Width / 2)
    End Sub

End Module
