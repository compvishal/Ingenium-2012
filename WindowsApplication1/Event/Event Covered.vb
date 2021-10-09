Public Class Event_Covered

    Private Sub Event_Covered_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Event_MasterTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Master)
        Me.Event_Student_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Student_Complete)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer3.RefreshReport()
        Me.ReportViewer5.RefreshReport
    End Sub

    Private Sub TabPagenotcovered_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPagenotcovered.Enter
        Me.Not_Covered_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Not_Covered_Schools)
        Me.ReportViewer2.RefreshReport()

    End Sub

    Private Sub TabPageNotCoveredCity_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageNotCoveredCity.Enter
        Me.Not_Covered_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Not_Covered_Schools)
        Me.ReportViewer4.RefreshReport()
    End Sub

    Private Sub EventMasterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventMasterComboBox.SelectedIndexChanged
        Try
            Me.Event_Student_Complete2TableAdapter.FillByEventId(Me.Ingenium_2011DataSet.Event_Student_Complete2, EventMasterComboBox.SelectedValue)
            ReportViewer5.RefreshReport()
            ReportViewer6.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class