Public Class Event_Student_Report
    Private Sub Event_Student_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Event_Student_Complete' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Event_Master' table. You can move, or remove it, as needed.
        Me.Event_MasterTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Master)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Event_Student_Complete1' table. You can move, or remove it, as needed.


    End Sub

    Private Sub EventMasterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventMasterComboBox.SelectedIndexChanged
        LoadReportAdapter()

    End Sub
    Private Sub LoadReportAdapter()
        If AllEventsCheckBox.Checked Then
            Me.Event_Student_Complete1TableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Student_Complete1)
            Me.Event_Student_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Student_Complete)
        Else
            Me.Event_Student_Complete1TableAdapter.FillByEventId(Me.Ingenium_2011DataSet.Event_Student_Complete1, EventMasterComboBox.SelectedValue)
            Me.Event_Student_CompleteTableAdapter.FillByEventId(Me.Ingenium_2011DataSet.Event_Student_Complete, EventMasterComboBox.SelectedValue)
        End If
        Me.ReportViewer6.RefreshReport()
        Me.ReportViewer5.RefreshReport()
    End Sub

    Private Sub AllEventsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AllEventsCheckBox.CheckedChanged
        LoadReportAdapter()
    End Sub
End Class