Public Class Test_Report

    Private Sub Test_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Tested_School' table. You can move, or remove it, as needed.
        Me.Tested_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Tested_School)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
        Me.ReportViewer4.RefreshReport()
        Me.ReportViewer5.RefreshReport()
    End Sub
End Class