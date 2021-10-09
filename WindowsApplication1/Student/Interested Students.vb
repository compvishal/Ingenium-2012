Public Class Interested_Students

    Private Sub Interested_Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Interested_Complete' table. You can move, or remove it, as needed.
        'Me.Interested_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Interested_Complete)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Interested_Complete' table. You can move, or remove it, as needed.
        ' Me.Interested_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Interested_Complete)
        LoadAdapter()
        ShowButton(False)
        If LoginForm1.Role <> "Administrator" Then
            ReportViewer1.ShowExportButton = False
            ReportViewer1.ShowPrintButton = False
            ReportViewer2.ShowExportButton = False
            ReportViewer2.ShowPrintButton = False
        End If

    End Sub
    Private Sub LoadAdapter()
        Dim Xpos As Integer = Interested_CompleteBindingSource.Position
        Me.Interested_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Interested_Complete)
        ToolStripStatusLabel1.Text = Interested_CompleteBindingSource.Count & " Students Added"
        ToolStripStatusLabel1.BackColor = Color.Aquamarine
        Me.StreamTableAdapter.Fill(Me.Ingenium_2011DataSet.Stream)
        Interested_CompleteBindingSource.Position = Xpos
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Sub LoadChangedAdapter()
        Me.StudentTableAdapter.FillByStudentId(Me.Ingenium_2011DataSet.Student, StuIdTextBox2.Text)
        Me.Interested_StudentTableAdapter.FillByStudentId(Me.Ingenium_2011DataSet.Interested_Student, StuIdTextBox2.Text)
        Me.Event_StudentsTableAdapter.FillByStudentId(Me.Ingenium_2011DataSet.Event_Students, StuIdTextBox2.Text)
    End Sub

    Private Sub StuIdTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuIdTextBox2.TextChanged
        LoadChangedAdapter()
    End Sub
    Private Sub ShowButton(ByVal show As Boolean)
        If show Then
            EditEventsButton.Enabled = False
            EditStudentButton.Enabled = False
            EventSavePanel.Visible = True
            StuSavePanel.Visible = True
            Panel1.Enabled = True
            Panel2.Enabled = True
            Panel4.Enabled = False
        Else
            EditEventsButton.Enabled = True
            EditStudentButton.Enabled = True
            EventSavePanel.Visible = False
            StuSavePanel.Visible = False
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel4.Enabled = True
        End If
    End Sub
    Private Sub SaveInterestedAdapter()
        Try
            Me.Validate()
            Me.Interested_StudentBindingSource.EndEdit()
            'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
            Me.Interested_StudentTableAdapter.Update(Me.Ingenium_2011DataSet.Interested_Student)
            ToolStripStatusLabel2.Text = "Comments Saved"
            ToolStripStatusLabel2.BackColor = Color.GreenYellow
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "Error! Not Saved"
            ToolStripStatusLabel2.BackColor = Color.Red
        End Try
    End Sub
    Private Sub SaveAdapter(ByVal save As Boolean)
        If save Then
            Try
                Me.Validate()
                'Me.Interested_StudentBindingSource.EndEdit()
                Me.Event_StudentsBindingSource.EndEdit()
                Me.StudentBindingSource.EndEdit()
                Me.StudentTableAdapter.Update(Me.Ingenium_2011DataSet.Student)
                Me.Event_StudentsTableAdapter.Update(Me.Ingenium_2011DataSet.Event_Students)
                'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
                ToolStripStatusLabel2.Text = "Saved"
                ToolStripStatusLabel2.BackColor = Color.GreenYellow
            Catch ex As Exception
                ToolStripStatusLabel2.Text = "Error! Not Saved"
                ToolStripStatusLabel2.BackColor = Color.Red
            End Try
        Else
            Me.Event_StudentsBindingSource.CancelEdit()
            Me.StudentBindingSource.CancelEdit()
            ToolStripStatusLabel2.Text = "Edit Cancelled"
            ToolStripStatusLabel2.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub EditEventsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEventsButton.Click
        ShowButton(True)
        ToolStripStatusLabel2.Text = "Edit Mode"
        ToolStripStatusLabel2.BackColor = Color.AliceBlue
    End Sub

    Private Sub EditStudentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditStudentButton.Click
        ShowButton(True)
        ToolStripStatusLabel2.Text = "Edit Mode"
        ToolStripStatusLabel2.BackColor = Color.AliceBlue
    End Sub

    Private Sub SaveEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEditButton.Click
        SaveAdapter(True)
        LoadChangedAdapter()
        ShowButton(False)
    End Sub

    Private Sub SaveStuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveStuButton.Click
        SaveAdapter(True)
        LoadChangedAdapter()
        ShowButton(False)
    End Sub

    Private Sub CancelEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEditButton.Click
        SaveAdapter(False)
        LoadChangedAdapter()
        ShowButton(False)
    End Sub

    Private Sub CancelStuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelStuButton.Click
        SaveAdapter(False)
        LoadChangedAdapter()
        ShowButton(False)
    End Sub

    Private Sub AddStudentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentButton.Click
        Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        Try
            If IsNumeric(StudentIdTextBox1.Text) Then
                If IsNothing(Url.GetStudentIdfrmStudentTable(StudentIdTextBox1.Text)) Then
                    MsgBox("No Such Student!", MsgBoxStyle.Critical, "Add Student as Interested")
                    Exit Sub
                End If
                If Url.GetStudentinInterested(StudentIdTextBox1.Text) <> 0 Then
                    MsgBox("Student already added!", MsgBoxStyle.Critical, "Add Student as Interested")
                    Exit Sub
                End If
                ' now add student
                Try
                    Url.InsertInterestedStudentbyId(StudentIdTextBox1.Text, Today)
                    ToolStripStatusLabel2.Text = "Student Added"
                    ToolStripStatusLabel2.BackColor = Color.GreenYellow
                    LoadAdapter()
                    MsgBox("Student Added", MsgBoxStyle.OkOnly, "Add Student as Interested")
                Catch ex As Exception
                    ToolStripStatusLabel2.Text = "Error! Student Not Added"
                    ToolStripStatusLabel2.BackColor = Color.Red
                End Try
            Else
                ToolStripStatusLabel2.Text = "Enter correct value!"
                ToolStripStatusLabel2.BackColor = Color.Red
            End If

        Catch ex As Exception
            MsgBox("Error in Student Value", MsgBoxStyle.Critical, "Add Student as Interested")
        End Try

    End Sub

    Private Sub SaveCommentsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommentsButton.Click
        SaveInterestedAdapter()
    End Sub

    Private Sub CancelSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSearchButton.Click
        CancelSearch(True)
        'LoadAdapter()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If MsgBox("Delete Student from Interested?", MsgBoxStyle.YesNo, "Remove Stu frm Interested") = MsgBoxResult.Yes Then
            DeleteAdapter()
            LoadAdapter()
            MsgBox("Deleted")
        End If
    End Sub
    Private Sub DeleteAdapter()
        Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        Url.DeleteStuInterested(InterestedIdTextBox.Text)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'SMS.SendSms("trying all new....", Mobile_PersonalTextBox.Text)
        Dim MNumber As String = ""
        If Mobile_PersonalTextBox.Text.Length = 10 Then MNumber = Mobile_PersonalTextBox.Text & ", "
        If Mobile_GuardianTextBox.Text.Length = 10 Then MNumber &= Mobile_GuardianTextBox.Text
        SMS.LoadSMSForm(MNumber)
    End Sub

    Private Sub CancelSearch(Optional ByVal Cancel As Boolean = True)
        Dim FilterText As String = ""
        If Cancel Then
            SearchSchoolNameTextBox.Text = ""
            SearchStuNameTextBox.Text = ""
            Interested_CompleteBindingSource.Filter = ""
            SearchStuIdTextBox.Text = ""
            CallStatusComboBox.Text = "All"
            CancelSearchButton.Enabled = False
            ToolStripStatusLabel1.Text = "Showing All Schools"
        Else
            Interested_CompleteBindingSource.Filter = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If SearchStuNameTextBox.Text <> "" Then
                Interested_CompleteBindingSource.Filter &= " AND [Student Name] Like( '%" & SearchStuNameTextBox.Text & "%')"
            End If
            If SearchStuIdTextBox.Text <> "" Then
                Interested_CompleteBindingSource.Filter &= " AND [StuId] =" & SearchStuIdTextBox.Text
            End If

            If CallStatusComboBox.Text <> "All" Then
                FilterText = Interested_CompleteBindingSource.Filter
                If CallStatusComboBox.Text = "B.Tech/BCA" Then
                    FilterText &= " AND Stream ='1'"
                ElseIf CallStatusComboBox.Text = "B.Tech AG/BBA" Then
                    FilterText &= " AND(Stream ='2' OR Stream='5') "
                ElseIf CallStatusComboBox.Text = "BBA" Then
                    FilterText &= " AND (Stream ='3' OR Stream='4' OR Stream='6' OR Stream='7')"
                Else
                    FilterText &= " AND Stream >'7'"
                End If

                'FilterText = IIf(FilterText <> "", Mid(FilterText, 5, Len(FilterText)), "") 'remove AND
                Interested_CompleteBindingSource.Filter = FilterText
            End If
            CancelSearchButton.Enabled = True
            ToolStripStatusLabel1.Text = "Filter On " & Interested_CompleteBindingSource.Count & " Students Selected"
            
        End If
    End Sub

    Private Sub SearchStuNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchSchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchoolNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub CallStatusComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallStatusComboBox.SelectedIndexChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchStuIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuIdTextBox.TextChanged
        CancelSearch(False)
    End Sub
End Class