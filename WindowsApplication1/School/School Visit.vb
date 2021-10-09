Public Class School_Visit


   
    Private Sub School_Visit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.School_Visit_Complete' table. You can move, or remove it, as needed.
        AllSchoolsCheckBox.Checked = True
        LoadAdapter()

    End Sub
    Private Sub LoadAdapter()
        If AllSchoolsCheckBox.Checked Then
            'all school
            Me.School_Visit_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.School_Visit_Complete)
        Else
            'select school
            Me.School_Visit_CompleteTableAdapter.FillBySchoolId(Me.Ingenium_2011DataSet.School_Visit_Complete, SchoolComboBox.SelectedValue)
        End If
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
        Me.ReportViewer4.RefreshReport()
    End Sub

    Private Sub SchoolComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolComboBox.SelectedIndexChanged
        AllSchoolsCheckBox.Checked = False
        LoadAdapter()
    End Sub

    Private Sub AllSchoolsCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllSchoolsCheckBox.CheckedChanged
        LoadAdapter()
    End Sub
End Class