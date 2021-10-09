Public Class Student_Data_Complete
    Private Sub Student_Data_Complete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Complete_Student' table. You can move, or remove it, as needed.
        Me.Complete_StudentTableAdapter.Fill(Me.Ingenium_2011DataSet.Complete_Student)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class