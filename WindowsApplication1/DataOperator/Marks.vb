Public Class Marks

    Private Sub Marks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Stream' table. You can move, or remove it, as needed.
        Me.StreamTableAdapter.Fill(Me.Ingenium_2011DataSet.Stream)
        LoadAdapter()
        ShowButton(False)
        CancelSearch()
        'StudentDataGridView.Columns(1).SortMode = DataGridViewColumnSortMode.Automati
    End Sub

    Private Sub LoadAdapter()

        Dim XShoolPos As Integer = VisitedSchoolsBindingSource.Position
        Dim XStuPos As Integer = StudentBindingSource.Position
        Try
            Me.StudentTableAdapter.Fill(Me.Ingenium_2011DataSet.Student)
            'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Visited_Schools' table. You can move, or remove it, as needed.
            Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
            VisitedSchoolsBindingSource.Position = XShoolPos
            StudentBindingSource.Position = XStuPos
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CancelSearch(Optional ByVal Cancel As Boolean = True)
        If Cancel Then
            SearchSchoolNameTextBox.Text = ""
            Test_ConductedCheckBox.Checked = False
            VisitedSchoolsBindingSource.Filter = ""
            CancelSearchButton.Enabled = False
            ToolStripStatusLabel1.Text = "Showing All Schools"
        Else
            VisitedSchoolsBindingSource.Filter = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If Test_ConductedCheckBox.Checked Then
                VisitedSchoolsBindingSource.Filter &= " AND [Test Conducted]=TRUE"
            End If
            CancelSearchButton.Enabled = True
            ToolStripStatusLabel1.Text = "Filter On " & VisitedSchoolsBindingSource.Count & " Schools Selected"

        End If
    End Sub

    Private Sub CancelSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSearchButton.Click
        CancelSearch()
    End Sub

    Private Sub SearchSchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchoolNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub Test_ConductedCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Test_ConductedCheckBox.CheckedChanged
        CancelSearch(False)
    End Sub

    Private Sub ShowButton(Optional ByVal Show As Boolean = True)
        If Show Then
            'allow edit
            StudentDataGridView.ReadOnly = False
            StuSavePanel.Visible = True
            Visited_SchoolsDataGridView.Enabled = False
            Panel2.Enabled = False
            StuAddNewButton.Enabled = True
            ToolStripStatusLabel4.Text = "Edit Mode "
        Else
            'end edit
            StudentDataGridView.ReadOnly = True
            StuSavePanel.Visible = False
            Visited_SchoolsDataGridView.Enabled = True
            Panel2.Enabled = True
            StuAddNewButton.Enabled = False
            ToolStripStatusLabel4.Text = "View Mode "
        End If
    End Sub

    Private Sub StuEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuEditButton.Click
        ShowButton()
    End Sub

    Private Sub VisitedSchoolsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VisitedSchoolsBindingSource.CurrentItemChanged
        ToolStripStatusLabel2.Text = "Selected School: " & School_NameTextBox.Text
        ToolStripStatusLabel3.Text = "No. of Students: " & StudentBindingSource.Count
    End Sub

    Private Sub SaveAdapter(Optional ByVal Save As Boolean = True)
        Try
            If Save Then
                StudentBindingSource.EndEdit()
                StudentTableAdapter.Update(Ingenium_2011DataSet.Student)
                ToolStripStatusLabel4.Text = "Edit Saved "
            Else
                StudentBindingSource.CancelEdit()
                ToolStripStatusLabel4.Text = "Edit Cancelled "
            End If
        Catch ex As Exception
            ToolStripStatusLabel4.Text = "Error..could not save "
        End Try

    End Sub

    Private Sub SaveEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEditButton.Click
        ShowButton(False)
        SaveAdapter()
        LoadAdapter()
    End Sub

    Private Sub CancelEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEditButton.Click
        ShowButton(False)
        SaveAdapter(False)
        LoadAdapter()
    End Sub

    Private Sub StuAddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuAddNewButton.Click
        StudentBindingSource.AddNew()
    End Sub
End Class