Public Class School_Test

    Private Sub School_Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Tested_School' table. You can move, or remove it, as needed.
        Me.Tested_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Tested_School)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Visited_Schools' table. You can move, or remove it, as needed.
        Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        ToolStripStatusLabel1.Text = "No. of Schools " & Visited_SchoolsBindingSource.Count
        If LoginForm1.Role <> "Administrator" Then
            ReportViewer1.ShowExportButton = False
            ReportViewer1.ShowPrintButton = False
            ReportViewer2.ShowExportButton = False
            ReportViewer2.ShowPrintButton = False
            ReportViewer3.ShowExportButton = False
            ReportViewer3.ShowPrintButton = False
        End If
    End Sub
    Private Sub RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
    End Sub
    Private Sub SaveAdapter()
        Me.Validate()
        Me.Visited_SchoolsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
    End Sub
    Private Sub FillStudentsinSchool()
        Dim NoSchoolTest As Integer, TotalTest As Integer
        Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        Dim Drow As DataGridViewRow
        For Each Drow In Visited_SchoolsDataGridView.Rows
            Drow.Cells(4).Value = Url.GetNoofStudentsforSchoolId(Drow.Cells(0).Value)
            If Drow.Cells(4).Value <> 0 Then
                NoSchoolTest += 1
                TotalTest += Drow.Cells(4).Value
            End If


        Next
        ToolStripStatusLabel2.Text = "Total School Test:" & NoSchoolTest & " Total Student" & TotalTest
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        FillStudentsinSchool()
        RefreshReport()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        SaveAdapter()
        SaveButton.BackColor = Color.GreenYellow
        RefreshReport()
    End Sub

    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        Me.Visited_SchoolsTableAdapter.FillByNoTest(Me.Ingenium_2011DataSet.Visited_Schools)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub TabPage3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Leave
        Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        RefreshReport()

    End Sub
End Class