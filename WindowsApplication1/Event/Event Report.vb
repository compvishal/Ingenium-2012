Public Class Event_Report

    Private Sub Event_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Event_Student_Complete' table. You can move, or remove it, as needed.
        'Me.Event_Student_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Student_Complete)
        ShowAllCheckBox.Checked = True
        LoadAdapter()
        LoadCompleteAdapter(True)

    End Sub
    Private Sub LoadAdapter()
        Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        Me.Event_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_School)
        Me.Event_MasterTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Master)
    End Sub
    Private Sub LoadCompleteAdapter(ByVal ShowAll As Boolean)
        Try
            If ShowAll Then
                Me.Event_Student_CompleteTableAdapter.FillByEventId(Me.Ingenium_2011DataSet.Event_Student_Complete, EventIdTextBox.Text)
                Me.Text = "Showing For all shools" & SchoolIdTextBox.Text
            Else
                Me.Event_Student_CompleteTableAdapter.FillByEventIdSchoolId(Me.Ingenium_2011DataSet.Event_Student_Complete, EventIdTextBox.Text, SchoolIdTextBox.Text)
                Me.Text = "Showing For School Id:" & SchoolIdTextBox.Text
            End If
        Catch ex As Exception

        Finally
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer2.RefreshReport()
            Me.ReportViewer3.RefreshReport()
        End Try
    End Sub

    Private Sub Event_SchoolBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Event_SchoolBindingSource.CurrentChanged
        Try
            LoadCompleteAdapter(ShowAllCheckBox.Checked)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub ShowAllCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllCheckBox.CheckedChanged
        If ShowAllCheckBox.Checked Then
            Event_SchoolDataGridView.Enabled = False
        Else
            Event_SchoolDataGridView.Enabled = True
        End If
        LoadCompleteAdapter(ShowAllCheckBox.Checked)
    End Sub

    Private Sub TabPage4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage4.Enter
        Try
            If ShowAllCheckBox.Checked Then
                Me.Event_Student_CompleteTableAdapter.FillByEventIdNOTCalled(Me.Ingenium_2011DataSet.Event_Student_Complete, EventIdTextBox.Text)
                Me.Text = "Showing Not Called For all shools" & SchoolIdTextBox.Text
            Else
                Me.Event_Student_CompleteTableAdapter.FillByEventIdSchoolIdNOTCalled(Me.Ingenium_2011DataSet.Event_Student_Complete, EventIdTextBox.Text, SchoolIdTextBox.Text)
                Me.Text = "Showing Not Called For School Id:" & SchoolIdTextBox.Text
            End If
        Catch ex As Exception

        Finally
            Me.ReportViewer4.RefreshReport()
        End Try
    End Sub

    Private Sub TabPage4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage4.Leave
        LoadCompleteAdapter(ShowAllCheckBox.Checked)
    End Sub
End Class