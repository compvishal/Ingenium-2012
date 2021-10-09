Public Class Daily_Entry_Report
    Private Sub Daily_Entry_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Data_Entry' table. You can move, or remove it, as needed.
        Me.Data_EntryTableAdapter.Fill(Me.Ingenium_2011DataSet.Data_Entry)
        Me.ReportViewerSMS.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class