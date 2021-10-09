Public Class Rough

   

    Private Sub Rough_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Event_Student_Complete' table. You can move, or remove it, as needed.
        Me.Event_Student_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Student_Complete)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class