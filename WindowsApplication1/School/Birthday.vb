Public Class Birthday

    Private Sub Birthday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill Combobox
        For i = 1 To 12
            MonthNameComboBox.Items.Add(MonthName(i))
        Next
    End Sub

    Private Sub MonthNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthNameComboBox.SelectedIndexChanged
        'MsgBox(MonthNameComboBox.SelectedIndex+1)
    End Sub
End Class