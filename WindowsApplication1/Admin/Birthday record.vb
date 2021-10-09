Public Class Birthday_record
    Private Sub Birthday_record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Complete_Student' table. You can move, or remove it, as needed.

    End Sub
    Private Sub LoadReportAdapter()
        Try
            Me.Complete_StudentTableAdapter.FillByDOBMonth(Me.Ingenium_2011DataSet.Complete_Student, ComboBox1.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadReportAdapter()

    End Sub
End Class