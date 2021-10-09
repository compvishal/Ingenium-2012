Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration
Public Class Events_Students_Telecalling

    Private Sub LoadAdapter()
        ' Exit Sub
        Dim Xpos As Integer = Event_Student_CompleteBindingSource.Position
        'Me.StudentTableAdapter.Fill(Me.Ingenium_2011DataSet.Student)
        Me.Event_StudentsTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Students)
        If AllEventsCheckBox.Checked Then
            Me.Event_Student_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Student_Complete)
        Else
            Me.Event_Student_CompleteTableAdapter.FillByEventId(Me.Ingenium_2011DataSet.Event_Student_Complete, EventMasterComboBox.SelectedValue)
        End If
        Event_Student_CompleteBindingSource.Position = Xpos
    End Sub
    Private Sub CancelSearch(Optional ByVal Cancel As Boolean = True)
        Dim FilterText As String = ""
        If Cancel Then
            SearchSchoolNameTextBox.Text = ""
            SearchStuNameTextBox.Text = ""
            Event_Student_CompleteBindingSource.Filter = ""
            SearchStuIdTextBox.Text = ""
            CallStatusComboBox.Text = "All"
            CancelSearchButton.Enabled = False
            ToolStripStatusLabel1.Text = "Showing All " & Event_Student_CompleteBindingSource.Count & " Students"
        Else
            Event_Student_CompleteBindingSource.Filter = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If SearchStuNameTextBox.Text <> "" Then
                Event_Student_CompleteBindingSource.Filter &= " AND [Student Name] Like( '%" & SearchStuNameTextBox.Text & "%')"
            End If
            If SearchStuIdTextBox.Text <> "" Then
                Event_Student_CompleteBindingSource.Filter &= " AND [StuId] =" & SearchStuIdTextBox.Text
            End If

            If CallStatusComboBox.Text <> "All" Then
                FilterText = Event_Student_CompleteBindingSource.Filter
                If CallStatusComboBox.Text = "Called" Then
                    FilterText &= " AND Called =TRUE"
                ElseIf CallStatusComboBox.Text = "Not-Called" Then
                    FilterText &= " AND Called =FALSE"
                ElseIf CallStatusComboBox.Text = "Expected" Then
                    FilterText &= " AND Expected =TRUE"
                ElseIf CallStatusComboBox.Text = "Called-Not Expected" Then
                    FilterText &= " AND Called =TRUE AND Expected =FALSE"
                ElseIf CallStatusComboBox.Text = "Present" Then
                    FilterText &= " AND Present=TRUE"
                ElseIf CallStatusComboBox.Text = "Expected-Not Present" Then
                    FilterText &= " AND Expected =TRUE AND Present=FALSE"
                ElseIf CallStatusComboBox.Text = "Present-Not Expected" Then
                    FilterText &= " AND Expected =FALSE AND Present=TRUE"
                ElseIf CallStatusComboBox.Text = "Not Present" Then
                    FilterText &= " AND Present=FALSE"
                ElseIf CallStatusComboBox.Text = "Admission Not Taken" Then
                    FilterText &= " AND [Admission Taken]=FALSE"
                ElseIf CallStatusComboBox.Text = "Admission Taken" Then
                    FilterText &= " AND [Admission Taken]=TRUE"
                ElseIf CallStatusComboBox.Text = "Called-Not Present" Then
                    FilterText &= " AND Present=FALSE  AND Called =TRUE"
                End If

                'FilterText = IIf(FilterText <> "", Mid(FilterText, 5, Len(FilterText)), "") 'remove AND
                Event_Student_CompleteBindingSource.Filter = FilterText
            End If
            CancelSearchButton.Enabled = True
            ToolStripStatusLabel1.Text = "Filter On " & Event_Student_CompleteBindingSource.Count & " Students Selected"
            'refresh report
            If Not (ReportCheckBox.Checked) Then Exit Sub
            Dim CmdText As String
            If FilterText <> "" Then
                If Not (AllEventsCheckBox.Checked) Then FilterText &= " AND EventId =" & EventMasterComboBox.SelectedValue
                CmdText = "SELECT [Event Students].EventStuId, [Event Students].EventId, [Event Students].SchoolId, [Event Students].StudentId, [Event Students].Called,[Event Students].[Call Details], [Event Students].Expected, [Event Students].[Expected Details], [Event Students].Present, [Event Students].[Present Details],[Event Students].[Admission Taken], [Event Students].[Follow-up Details], [Visited Schools].[School Name], [Visited Schools].City, Student.StuId,Student.SchoolId AS Expr1, Student.Stream, Student.[Student Name], Student.[Father Name], Student.Address, Student.[Mobile Personal], Student.[Mobile Guardian], Student.[Other No], Student.DOB,Student.[Father Occupation], Student.BPL, Student.Category, Student.[10th Grade], Student.[Ingenium%], Student.[Discount offered],[Event Students].[Present Timer],Stream.Stream AS StreamName FROM((([Event Students] INNER JOIN [Visited Schools] ON [Event Students].SchoolId = [Visited Schools].SchoolId) INNER JOIN Student ON [Visited Schools].SchoolId = Student.SchoolId AND [Event Students].StudentId = Student.StuId) INNER JOIN Stream ON Student.Stream = Stream.StreamId) Where " & FilterText & " ORDER BY [Event Students].[Present Timer]"
            Else
                CmdText = "SELECT [Event Students].EventStuId, [Event Students].EventId, [Event Students].SchoolId, [Event Students].StudentId, [Event Students].Called,[Event Students].[Call Details], [Event Students].Expected, [Event Students].[Expected Details], [Event Students].Present, [Event Students].[Present Details],[Event Students].[Admission Taken], [Event Students].[Follow-up Details], [Visited Schools].[School Name], [Visited Schools].City, Student.StuId,Student.SchoolId AS Expr1, Student.Stream, Student.[Student Name], Student.[Father Name], Student.Address, Student.[Mobile Personal], Student.[Mobile Guardian], Student.[Other No], Student.DOB,Student.[Father Occupation], Student.BPL, Student.Category, Student.[10th Grade], Student.[Ingenium%], Student.[Discount offered],[Event Students].[Present Timer],Stream.Stream AS StreamName FROM((([Event Students] INNER JOIN [Visited Schools] ON [Event Students].SchoolId = [Visited Schools].SchoolId) INNER JOIN Student ON [Visited Schools].SchoolId = Student.SchoolId AND [Event Students].StudentId = Student.StuId) INNER JOIN Stream ON Student.Stream = Stream.StreamId)"
                If Not (AllEventsCheckBox.Checked) Then CmdText &= " Where EventId =" & EventMasterComboBox.SelectedValue
                CmdText &= " ORDER BY [Event Students].[Present Timer]"
            End If
            Dim DSet As New DataSet
            Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
            Dim ConString = COn.ConnectionString
            Dim Cn As New OleDbConnection(ConString)
            'Cn.Open()
            Dim ADDapter As New OleDbDataAdapter()
            'Fill Type
            ADDapter.SelectCommand = New OleDbCommand(CmdText, Cn)
            Try
                ADDapter.Fill(DSet)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "Ingenium_2011DataSet_Event_Student_Complete"
                ReportDataSource1.Value = DSet.Tables(0)
                Me.ReportViewer5.LocalReport.DataSources.RemoveAt(0)    'remove existing
                Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource1)
                Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Certificate2.rdlc"
                Me.ReportViewer5.RefreshReport()
                With ReportViewer6
                    .LocalReport.DataSources.RemoveAt(0)
                    .LocalReport.DataSources.Add(ReportDataSource1)
                    .LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers.rdlc"
                    '.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers-new.rdlc"
                    .RefreshReport()
                End With
                With ReportViewerSMS
                    .LocalReport.DataSources.RemoveAt(0)
                    .LocalReport.DataSources.Add(ReportDataSource1)
                    .LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers-SMS.rdlc"
                    .RefreshReport()
                End With
                With ReportViewer7
                    .LocalReport.DataSources.RemoveAt(0)
                    .LocalReport.DataSources.Add(ReportDataSource1)
                    .LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Criterion Summary-by School.rdlc"
                    .RefreshReport()
                End With
            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub SearchStuNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchSchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchoolNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub CancelSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSearchButton.Click
        CancelSearch()
    End Sub

    Private Sub StudentBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolStripStatusLabel2.Text = "  Selected Student:" & Student_NameTextBox.Text
    End Sub

    Private Sub SaveEventAdapter(Optional ByVal Save As Boolean = True)
        Try
            If Save Then
                Event_StudentsBindingSource.EndEdit()
                Event_StudentsTableAdapter.Update(Ingenium_2011DataSet.Event_Students)
                ToolStripStatusLabel3.Text = "  Event Details Saved"
                ToolStripStatusLabel3.BackColor = Color.GreenYellow
            Else
                Event_StudentsBindingSource.CancelEdit()
                ToolStripStatusLabel3.Text = "  Events Edit Cancelled"
                ToolStripStatusLabel3.BackColor = Color.Turquoise
            End If
        Catch ex As Exception
            ToolStripStatusLabel3.Text = "  Error! Not Saved."
            ToolStripStatusLabel3.BackColor = Color.Red
        End Try

    End Sub
    Private Sub ShowEventButton(Optional ByVal Show As Boolean = True)
        If Show Then
            'edit
            Panel1.Enabled = True
            EventSavePanel.Enabled = True
            Event_Student_CompleteDataGridView.Enabled = False
            Panel5.Enabled = False
            Panel4.Enabled = False    'Filter Panel
        Else
            Panel1.Enabled = False
            EventSavePanel.Enabled = False
            Event_Student_CompleteDataGridView.Enabled = True
            Panel5.Enabled = True
            Panel4.Enabled = True   'Filter Panel
        End If
    End Sub
    Private Sub EditEventsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEventsButton.Click
        ShowEventButton()
    End Sub
    Private Sub SaveEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEditButton.Click
        SaveEventAdapter()
        ShowEventButton(False)
        LoadAdapter()
    End Sub
    Private Sub CancelEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEditButton.Click
        SaveEventAdapter(False)
        ShowEventButton(False)
        LoadAdapter()
    End Sub


    Private Sub SaveStuAdapter(Optional ByVal Save As Boolean = True)
        Try
            If Save Then
                StudentBindingSource.EndEdit()
                StudentTableAdapter.Update(Ingenium_2011DataSet.Student)
                ToolStripStatusLabel3.Text = "  Student Details Saved"
                ToolStripStatusLabel3.BackColor = Color.GreenYellow
            Else
                StudentBindingSource.CancelEdit()
                ToolStripStatusLabel3.Text = "  Edit Cancelled"
                ToolStripStatusLabel3.BackColor = Color.Turquoise
            End If
        Catch ex As Exception
            ToolStripStatusLabel3.Text = "  Error! Not Saved."
            ToolStripStatusLabel3.BackColor = Color.Red
        End Try

    End Sub
    Private Sub ShowStuButton(Optional ByVal Show As Boolean = True)
        If Show Then
            'edit
            Panel2.Enabled = True
            StuSavePanel.Enabled = True
            Event_Student_CompleteDataGridView.Enabled = False
            Panel3.Enabled = False
            Panel4.Enabled = False    'Filter Panel
        Else
            Panel2.Enabled = False
            StuSavePanel.Enabled = False
            Event_Student_CompleteDataGridView.Enabled = True
            Panel3.Enabled = True
            Panel4.Enabled = True   'Filter Panel
        End If
    End Sub

    Private Sub EditStudentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditStudentButton.Click
        ShowStuButton()
    End Sub

    Private Sub SaveStuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveStuButton.Click
        Dim MsReply As MsgBoxResult
        MsReply = MsgBox("Do you want to Save Edits? This will change Data for Student.", MsgBoxStyle.YesNoCancel, "Edit Student Data")
        If MsReply = MsgBoxResult.Yes Then
            SaveStuAdapter()
            ShowStuButton(False)
            LoadAdapter()
        ElseIf MsReply = MsgBoxResult.No Then
            SaveStuAdapter(False)
            ShowStuButton(False)
            LoadAdapter()
        End If
    End Sub

    Private Sub CancelStuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelStuButton.Click
        SaveStuAdapter(False)
        ShowStuButton(False)
        LoadAdapter()
    End Sub

    Private Sub Event_MasterBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Event_MasterBindingSource.CurrentChanged
        Me.Text = EventMasterComboBox.Text & " Event Selected which has " & Event_Student_CompleteBindingSource.Count & " Students"
    End Sub

    Private Sub EventMasterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventMasterComboBox.SelectedIndexChanged
        LoadAdapter()
        CancelSearch(False)
    End Sub

    Private Sub TabPagePresentCertificate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPagePresentCertificate.Enter
        CheckBoxAllPresent.Checked = False
        LoadPresentCertificateAdapter()
    End Sub
    Private Sub LoadPresentCertificateAdapter()
        If CheckBoxAllPresent.Checked Then
            Me.Event_Student_CompleteTableAdapter.FillByPresent(Me.Ingenium_2011DataSet.Event_Student_Complete)
        Else
            Me.Event_Student_CompleteTableAdapter.FillByPresentEventId(Me.Ingenium_2011DataSet.Event_Student_Complete, EventMasterComboBox.SelectedValue)

        End If
        'Present Certificate
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TabPage2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPagePresentCertificate.Leave
        'leave present certificate tab
        LoadAdapter()
    End Sub

    Private Sub CallStatusComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallStatusComboBox.SelectedIndexChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchStuIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuIdTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub AllEventsCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllEventsCheckBox.CheckedChanged
        LoadAdapter()
    End Sub

    Private Sub PresentCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresentCheckBox.CheckedChanged
        If PresentCheckBox.Checked Then
            Present_TimerDateTimePicker.Value = Now
        End If
    End Sub

    Private Sub ReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportButton.Click
        Try
            Me.Event_Student_CompleteTableAdapter.FillByPresentDate(Me.Ingenium_2011DataSet.Event_Student_Complete, ReportTextBox.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub Add2InterestedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add2InterestedButton.Click
        Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        If Url.GetStudentinInterested(StuIdTextBox1.Text) <> 0 Then
            MsgBox("Student already added!", MsgBoxStyle.Critical, "Add Student as Interested")
            Exit Sub
        End If
        ' now add student
        Try
            Url.InsertInterestedStudentbyId(StuIdTextBox1.Text, Today)
            ToolStripStatusLabel3.Text = "Student Added"
            ToolStripStatusLabel3.BackColor = Color.GreenYellow
            LoadAdapter()
            MsgBox("Student Added", MsgBoxStyle.OkOnly, "Add Student as Interested")
        Catch ex As Exception
            ToolStripStatusLabel3.Text = "Error! Student Not Added"
            ToolStripStatusLabel3.BackColor = Color.Red
        End Try

    End Sub

    Private Sub EleventhButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwelthButton.Click
        If MsgBox("Transfer to 12th Student?", MsgBoxStyle.YesNo, "Student in 12") = MsgBoxResult.Yes Then
            Try
                'add to 12th
                Dim StuRow As Ingenium_2011DataSet._12thRow
                StuRow = Ingenium_2011DataSet._12th.New_12thRow
                With StuRow
                    .SchoolId = SchoolIdTextBox.Text
                    .Stream = ComboBox2.SelectedValue
                    .Student_Name = Student_NameTextBox.Text
                    .Father_Name = Father_NameTextBox.Text
                    .Address_Permanent = Address_PermanentTextBox.Text
                    '.Address_Correspondance = Address_CorrespondanceTextBox.Text
                    .Mobile_Personal = Mobile_PersonalTextBox.Text
                    .Mobile_Guardian = Mobile_GuardianTextBox.Text
                    .Other_No = Other_NoTextBox.Text
                    '.EmailId = EmailIdTextBox.Text
                    .DOB = DOBTextBox.Text
                    .Father_Occupation = Father_OccupationTextBox.Text
                    .BPL = BPLCheckBox.Checked
                    .Category = CategoryTextBox.Text
                    ._10th_Grade = _10th_GradeTextBox.Text
                    ._Ingenium_ = Ingenium_TextBox.Text
                End With
                Ingenium_2011DataSet._12th.Rows.Add(StuRow)
                '_12thTableAdapter.Update(Ingenium_2011DataSet._12th)

                Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
                'delete from event student
                Url.DeleteEventStudent(EventStuIdTextBox.Text)

                'delete student
                Url.DeleteStudent(StuIdTextBox1.Text)
                LoadAdapter()
                MsgBox("Done")
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
            End Try
        End If
    End Sub

    Private Sub SMSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSButton.Click
        Dim MNumber As String = ""
        If Mobile_PersonalTextBox.Text.Length = 10 Then MNumber = Mobile_PersonalTextBox.Text & ", "
        If Mobile_GuardianTextBox.Text.Length = 10 Then MNumber &= Mobile_GuardianTextBox.Text
        SMS.LoadSMSForm(MNumber)
    End Sub

    Private Sub Events_Students_Telecalling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Student' table. You can move, or remove it, as needed.
        'Me.StudentTableAdapter.Fill(Me.Ingenium_2011DataSet.Student)
        If LoginForm1.Role = "Administrator" Or LoginForm1.Role = "Admin-Other" Then
            ReportCheckBox.Enabled = True
        Else
            ReportCheckBox.Enabled = False
        End If
        Me.Event_MasterTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Master)
        'Me.Event_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_School)
        Me.StreamTableAdapter.Fill(Me.Ingenium_2011DataSet.Stream)
        LoadAdapter()
        ShowEventButton(False)
        ShowStuButton(False)
    End Sub

   
    Private Sub StuIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuIdTextBox.TextChanged
        StudentTableAdapter.FillByStudentId(Ingenium_2011DataSet.Student, StuIdTextBox.Text)
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        LoadPresentCertificateAdapter()
    End Sub

    Private Sub Father_OccupationTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Father_OccupationTextBox.TextChanged
        Father_OccupationComboBox.SelectedItem = Father_OccupationTextBox.Text
    End Sub
    Private Sub Father_OccupationComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Father_OccupationComboBox.SelectedIndexChanged
        Father_OccupationTextBox.Text = Father_OccupationComboBox.SelectedItem
    End Sub
    Private Sub CategoryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryTextBox.TextChanged
        CategoryComboBox.SelectedItem = CategoryTextBox.Text
    End Sub
    Private Sub CategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        CategoryTextBox.Text = CategoryComboBox.SelectedItem
    End Sub

    Private Sub TabPagecertificateCRT_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPagecertificateCRT.Enter
        CancelSearch(False)
    End Sub

    Private Sub TabPageCRTCallDetails_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageCRTCallDetails.Enter
        CancelSearch(False)
    End Sub

    Private Sub TabPageCallDetails_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageCallDetails.Enter
        Me.ReportViewer8.RefreshReport()
    End Sub

    Private Sub TabPageSchoolDetails_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageSchoolDetails.Enter
        Me.ReportViewer9.RefreshReport()
    End Sub

    Private Sub TabPagePresentDetails_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPagePresentDetails.Enter
        Me.ReportViewer10.RefreshReport()
    End Sub

    Private Sub TabPageCallSummary_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageCallSummary.Enter
        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub TabPageSchoolSummary_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageSchoolSummary.Enter
        Me.ReportViewer4.RefreshReport()
    End Sub

    Private Sub TabPagePresentSummary_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPagePresentSummary.Enter
        Me.ReportViewer5.RefreshReport()
    End Sub
End Class