Public Class Students

    Private Sub Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Student_School_COmplete' table. You can move, or remove it, as needed.
        Me.Student_School_COmpleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Student_School_COmplete)
        If LoginForm1.Role <> "Administrator" Then
            ReportViewer1.ShowExportButton = False
            ReportViewer1.ShowPrintButton = False
            ReportViewer2.ShowExportButton = False
            ReportViewer2.ShowPrintButton = False
            ReportViewer3.ShowExportButton = False
            ReportViewer3.ShowPrintButton = False
        End If
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
    End Sub
    Private Sub TabPage3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Leave
        Me.Student_School_COmpleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Student_School_COmplete)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolListBox.SelectedIndexChanged
        Me.Student_School_COmpleteTableAdapter.FillBySchoolId(Me.Ingenium_2011DataSet.Student_School_COmplete, SchoolListBox.SelectedValue)
        Me.ReportViewer3.RefreshReport()
    End Sub
End Class