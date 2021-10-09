Imports System.Management

Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration
Public Class School
    Dim Xpos As Int16, Xpos2 As Int16
    Private Sub School_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Student_School_COmplete' table. You can move, or remove it, as needed.
        'Me.Student_School_COmpleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Student_School_COmplete)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Stream' table. You can move, or remove it, as needed.
        Me.StreamTableAdapter.Fill(Me.Ingenium_2011DataSet.Stream)
        ' Me.StudentTableAdapter.Fill(Me.Ingenium_2011DataSet.Student)
        Me.EmployeeTableAdapter.FillByNotDataOperator(Me.Ingenium_2011DataSet.Employee)
        'Me.EmployeeSchoolVisitTableAdapter.Fill(Me.Ingenium_2011DataSet.EmployeeSchoolVisit)
        LoadAdapter()
        ShowButton(False)

        If LoginForm1.Role <> "Administrator" And LoginForm1.Role <> "Admin-Other" Then
            ReportViewer1.ShowExportButton = False
            ReportViewer1.ShowPrintButton = False
            'ReportViewer3.ShowExportButton = False
            'ReportViewer3.ShowPrintButton = False
            'ReportViewer2.ShowExportButton = False
            'ReportViewer2.ShowPrintButton = False
            'disable column recorder
            Visited_SchoolsDataGridView.ReadOnly = True
            'Dim col As DataGridViewColumn
            'For Each col In Visited_SchoolsDataGridView.Columns
            'col.SortMode = DataGridViewColumnSortMode.NotSortable
            'Next
            ReportCheckBox.Enabled = False
            ReportCheckBox.Checked = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False
        Else
            If LoginForm1.UserName = "Vishal" Or LoginForm1.UserName = "rehanvit" Or LoginForm1.UserName = "Arunesh" Then
                DeleteButton.Enabled = True
            Else
                DeleteButton.Enabled = False
            End If

            ReportCheckBox.Enabled = True
            EditButton.Enabled = True
        End If
        CancelSearch(True)
    End Sub
    Private Sub LoadAdapter()
        Dim Xop As Int16
        If SchoolIdTextBox3.Text <> "" Then
            Xop = Int(SchoolIdTextBox3.Text)
            If Xop < 0 Then
                Dim Ur As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
                Xop = Ur.GetMaxSchoolId
            End If
        Else
            Xop = 1
        End If
        Me.School_ContactsTableAdapter.Fill(Me.Ingenium_2011DataSet.School_Contacts)
        ' Me.Visited_SchoolsTableAdapter.FillBySchool(Me.Ingenium_2011DataSet.Visited_Schools)    ' ##########this was original
        Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        ToolStripStatusLabel5.Text = "Total School Added- " & Visited_SchoolsBindingSource.Count & "  "
        If Xop <> 0 Then
            Visited_SchoolsBindingSource.Position = Visited_SchoolsBindingSource.Find("SchoolId", Xop)
        End If
    End Sub
    Private Sub ShowButton(Optional ByVal Show As Boolean = True)
        Xpos = Visited_SchoolsBindingSource.Position
        If Show Then
            'edit mode
            SaveCancelPanel.Visible = True
            School_ContactsDataGridView.ReadOnly = False
            SchoolDetailsPanel.Enabled = True
            AddNewButton1.Enabled = False
            EditButton.Enabled = False
        Else
            SaveCancelPanel.Visible = False
            School_ContactsDataGridView.ReadOnly = True
            SchoolDetailsPanel.Enabled = False
            AddNewButton1.Enabled = True
            EditButton.Enabled = True
        End If
    End Sub
    Private Sub SaveAdapter(Optional ByVal Save As Boolean = True)
        If Save Then
            '####just for checking
            Me.Validate()
            Me.Visited_SchoolsBindingSource.EndEdit()
            Me.School_ContactsBindingSource.EndEdit()
            Me.Visited_SchoolsTableAdapter.Update(Me.Ingenium_2011DataSet.Visited_Schools)
            '####just for checking
            Try
                Me.Validate()
                Me.Visited_SchoolsBindingSource.EndEdit()
                Me.School_ContactsBindingSource.EndEdit()
                Me.Visited_SchoolsTableAdapter.Update(Me.Ingenium_2011DataSet.Visited_Schools)
                'Me.Visited_SchoolsTableAdapter.Update(Me.Ingenium_2011DataSet.Visited_Schools)
                Me.School_ContactsTableAdapter.Update(Me.Ingenium_2011DataSet.School_Contacts)
                'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
            Catch ex As Exception
                MsgBox(ex.ToString)
                ToolStripStatusLabel1.Text = ex.ToString
                ToolStripStatusLabel1.BackColor = Color.Red
            End Try
            ToolStripStatusLabel1.Text = "Saved"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
        Else
            Me.Visited_SchoolsBindingSource.CancelEdit()
            Me.School_ContactsBindingSource.CancelEdit()
            ToolStripStatusLabel1.Text = "Edit Canceled"
            ToolStripStatusLabel1.BackColor = Color.Yellow
        End If
    End Sub
    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        ToolStripStatusLabel1.Text = "Edit Mode"
        ShowButton()
        School_NameTextBox.Focus()
    End Sub

    Private Sub SaveRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecordButton.Click
        SaveSchoolDetails()
    End Sub
    Private Sub SaveSchoolDetails()
        If Not (CheckSaveRecordError()) Then
            SaveAdapter()
            LoadAdapter()
            'Visited_SchoolsBindingSource.Position = Xpos
            ShowButton(False)
        End If
    End Sub
    Private Function CheckSaveRecordError() As Boolean
        ErrorProvider1.SetError(Me.School_NameTextBox, "")
        ErrorProvider1.SetError(Me.CityTextBox, "")
        ErrorProvider1.SetError(Me.AddressTextBox, "")
        ErrorProvider1.SetError(Me.PCM_StudentsTextBox, "")
        'start checking
        CheckSaveRecordError = True
        If School_NameTextBox.Text = "" Then
            'no school name
            ErrorProvider1.SetError(Me.School_NameTextBox, "No School Name")
            School_NameTextBox.Focus()
            Exit Function
        End If
        If CityTextBox.Text = "" Then
            'no city
            ErrorProvider1.SetError(Me.CityTextBox, "No City")
            CityTextBox.Focus()
            Exit Function
        End If
        If AddressTextBox.Text = "" Then
            'no address
            ErrorProvider1.SetError(Me.AddressTextBox, "No School Address")
            AddressTextBox.Focus()
            Exit Function
        End If
        If (PCM_StudentsTextBox.Text + PCB_StudentsTextBox.Text + Arts_StudentsTextBox.Text + Commerce__StudentsTextBox.Text) * 1 = 0 Then
            'no address
            ErrorProvider1.SetError(Me.PCM_StudentsTextBox, "No Students")
            PCM_StudentsTextBox.Focus()
            Exit Function
        End If
        'check School Name & Address
        Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        Dim SchoolNameExists As Boolean = Not (IsNothing(Url.GetSchoolNameExists(SchoolIdTextBox3.Text, School_NameTextBox.Text)))
        If SchoolNameExists Then
            Dim OldAddress As String = Url.GetAddressforSchoolName(School_NameTextBox.Text, SchoolIdTextBox3.Text)
            If OldAddress = AddressTextBox.Text Then
                'same address
                ErrorProvider1.SetError(Me.AddressTextBox, "School with same Address Exists!")
                'School_NameTextBox.Focus()
                CancelRecordButton.Focus()
                Exit Function
            Else
                If MsgBox("Another school with same name & address as '" & OldAddress & "' already Exists!" & vbCrLf & "Add this school?", MsgBoxStyle.YesNo, " Schools with same name!") = MsgBoxResult.No Then
                    CancelRecordButton.Focus()
                    'School_NameTextBox.Focus()
                    Exit Function
                End If
            End If
        End If
        'no error
        CheckSaveRecordError = False
    End Function


    Private Sub CancelRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelRecordButton.Click
        SaveAdapter(False)
        LoadAdapter()
        Visited_SchoolsBindingSource.Position = Xpos
        ShowButton(False)
    End Sub

    Private Sub AddNewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewButton1.Click
        CancelSearch(True)
        Me.Visited_SchoolsBindingSource.AddNew()
        TypeTextBox.Text = "School"
        'SaveAdapter()
        'LoadAdapter()
        'Me.Visited_SchoolsBindingSource.MoveFirst()
        ToolStripStatusLabel1.Text = "New Record Added"
        'enable edit mode
        ShowButton()
        School_NameTextBox.Focus()
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        Me.CompleteSchoolTableAdapter.FillBySchool(Me.Ingenium_2011DataSet.CompleteSchool)
        Me.ReportViewer1.RefreshReport()
    End Sub

    '###############################################################################################
    '############ Students  ########################################################################
    '###############################################################################################

    Private Sub LoadStuAdapter()
        Try
            Dim XposStu As Int16 = StudentBindingSource.Position
            Me.StudentTableAdapter.FillBySchoolId(Me.Ingenium_2011DataSet.Student, SchoolIdTextBox3.Text)
            ToolStripStatusLabel3.Text = "No of Students- " & StudentBindingSource.Count & "  "
            StudentBindingSource.Position = XposStu
        Catch ex As Exception

        End Try

    End Sub
    Private Sub SaveStuAdapter(Optional ByVal Save As Boolean = True)
        If Save Then
            Try
                StudentBindingSource.EndEdit()
                StudentTableAdapter.Update(Ingenium_2011DataSet.Student)
                'update Entry Id
                If ToolStripStatusLabel4.Text = "New Student" Then
                    Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
                    Dim MaxStuId As Integer = Url.GetMaxStuId
                    Url.UpdateEntryIdforStuId(LoginForm1.EmplyId, MaxStuId)
                End If

                ToolStripStatusLabel4.Text = "Saved"
                ToolStripStatusLabel4.BackColor = Color.GreenYellow
                Exit Sub
            Catch ex As Exception
                'MsgBox(ex.ToString)
                ToolStripStatusLabel4.Text = "Error:" ' & ex.ToString
                ToolStripStatusLabel4.BackColor = Color.Red
            Finally

            End Try
        End If
    End Sub
    Private Sub ShowStuButton(Optional ByVal Show As Boolean = True)
        If Show Then
            StuSavePanel.Visible = True
            StuAddNewButton.Enabled = False
            StuEditButton.Enabled = False
            StuRecordPanel.Enabled = True
            StudentDataGridView.ReadOnly = False
        Else
            StuSavePanel.Visible = False
            StuAddNewButton.Enabled = True
            StuEditButton.Enabled = True
            StuRecordPanel.Enabled = False
            StudentDataGridView.ReadOnly = True
        End If
    End Sub

    Private Sub TabPage5_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage5.Enter
        LoadStuAdapter()
        ShowStuButton(False)
    End Sub

    Private Sub StuAddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuAddNewButton.Click
        'addnew
        CancelStuSearch(True)
        StudentBindingSource.AddNew()
        Entry_DateDateTimePicker.Value = "01/01/1997"
        Entry_DateDateTimePicker.Value = Today
        SchoolIdTextBox2.Text = SchoolIdTextBox3.Text
        DOBTextBox.Text = "01/01/1997"
        StreamComboBox.Text = "PCM"
        TopperCheckBox.Checked = True
        TopperCheckBox.Checked = False
        ToolStripStatusLabel4.Text = "New Student"
        'IdTextBox.Text = LoginForm1.EmplyId
        'StudentBindingSource.AddNew()
        'StudentTableAdapter.Insert(SchoolIdTextBox3.Text, 1, " ", "", "", "", "", "", "", "", "1/1/1986", "", False, "General", "0", 0, "0")
        'save new
        'StudentTableAdapter.Update(Ingenium_2011DataSet.Student)
        'LoadStuAdapter()
        'StudentBindingSource.MoveFirst()
        ShowStuButton()
        StreamComboBox.Focus()
    End Sub

    Private Sub StuEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuEditButton.Click
        ShowStuButton()
        StreamComboBox.Focus()
    End Sub
    Private Function CheckStu() As Boolean
        CheckStu = True
        ErrorProvider1.SetError(Me.StreamComboBox, "")
        ErrorProvider1.SetError(Me.Student_NameTextBox, "")
        ErrorProvider1.SetError(Me.Father_NameTextBox, "")
        ErrorProvider1.SetError(Me.DOBTextBox, "")
        ErrorProvider1.SetError(Me.Mobile_PersonalTextBox, "")
        ErrorProvider1.SetError(Me.Mobile_GuardianTextBox, "")
        If StreamComboBox.Text = "" Then
            ErrorProvider1.SetError(Me.StreamComboBox, "Select Stream")
            Exit Function
        End If
        If Student_NameTextBox.Text = " " Or Student_NameTextBox.Text = "" Then
            ErrorProvider1.SetError(Me.Student_NameTextBox, "Student Name cannot be Blank")
            Student_NameTextBox.Focus()
            Exit Function
        End If
        If Father_NameTextBox.Text = "" Then
            ErrorProvider1.SetError(Me.Father_NameTextBox, "Father Name cannot be Blank")
            Father_NameTextBox.Focus()
            Exit Function
        End If
        If Not (IsDate(DOBTextBox.Text)) Then
            ErrorProvider1.SetError(Me.DOBTextBox, "Incorrect DOB")
            DOBTextBox.Focus()
            Exit Function
        End If
        ' Check for Mobile Number
        If Mobile_PersonalTextBox.Text = "" And Mobile_GuardianTextBox.Text = "" Then
            ErrorProvider1.SetError(Me.Mobile_PersonalTextBox, "Atleast one Mobile No Needed")
            Mobile_PersonalTextBox.Focus()
            Exit Function
        End If
        'check for Mobile No. length & duplication
        Dim Url As New Common_Functions
        Dim Url2 As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter, StuId As Integer
        If Mobile_PersonalTextBox.Text <> "" Then
            If Url.CheckMob(Mobile_PersonalTextBox.Text) Then
                ErrorProvider1.SetError(Me.Mobile_PersonalTextBox, "Incorrect Mobile No")
                Mobile_PersonalTextBox.Focus()
                Exit Function
            End If

            If Not (IsNothing(Url2.CheckMobileNoExists(Mobile_PersonalTextBox.Text, Mobile_PersonalTextBox.Text, Mobile_PersonalTextBox.Text))) Then
                StuId = Url2.CheckMobileNoExists(Mobile_PersonalTextBox.Text, Mobile_PersonalTextBox.Text, Mobile_PersonalTextBox.Text)
                If StuId <> StuIdTextBox.Text Then
                    ErrorProvider1.SetError(Me.Mobile_PersonalTextBox, " Mobile No already for Student Id:" & StuId)
                    Mobile_PersonalTextBox.Focus()
                    Exit Function
                End If
            End If
        End If
        If Mobile_GuardianTextBox.Text <> "" Then
            If Url.CheckMob(Mobile_GuardianTextBox.Text) Then
                ErrorProvider1.SetError(Me.Mobile_GuardianTextBox, "Incorrect Mobile No")
                Mobile_GuardianTextBox.Focus()
                Exit Function
            End If
            If Not (IsNothing(Url2.CheckMobileNoExists(Mobile_GuardianTextBox.Text, Mobile_GuardianTextBox.Text, Mobile_GuardianTextBox.Text))) Then
                StuId = Url2.CheckMobileNoExists(Mobile_GuardianTextBox.Text, Mobile_GuardianTextBox.Text, Mobile_GuardianTextBox.Text)
                If StuId <> StuIdTextBox.Text Then
                    ErrorProvider1.SetError(Me.Mobile_GuardianTextBox, " Mobile No already for Student Id:" & StuId)
                    Mobile_GuardianTextBox.Focus()
                    Exit Function
                End If

            End If
        End If


        CheckStu = False
    End Function

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEditButton.Click
        'save edits
        If Not (CheckStu()) Then    'check Data filled
            SaveStuAdapter()
            'check school tested
            If Test_ConductedCheckBox1.Checked = False Then
                Test_ConductedCheckBox1.Checked = True
                SaveAdapter()
            End If
            If ToolStripStatusLabel4.Text = "Saved" Then    'check Save successful
                LoadStuAdapter()
                ShowStuButton(False)
                StuAddNewButton.Focus()
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'cancel edits
        SaveStuAdapter(False)
        LoadStuAdapter()
        ShowStuButton(False)
    End Sub

    Private Sub StreamTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreamTextBox.TextChanged
        StreamComboBox.Text = StreamTextBox.Text
    End Sub

    Private Sub CategoryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryTextBox.TextChanged
        CategoryComboBox.Text = CategoryTextBox.Text
    End Sub

    Private Sub Father_OccupationTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Father_OccupationTextBox.TextChanged
        Father_OccupationComboBox.Text = Father_OccupationTextBox.Text
    End Sub

    Private Sub Discount_offeredTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Discount_offeredTextBox.LostFocus
        ' SaveEditButton.Focus()
    End Sub


    Private Sub TypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeComboBox.SelectedIndexChanged
        TypeTextBox.Text = TypeComboBox.Text
    End Sub
    Private Sub TypeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeTextBox.TextChanged
        TypeComboBox.Text = TypeTextBox.Text
    End Sub

    Private Sub CancelSearch(Optional ByVal Cancel As Boolean = True)
        If Cancel Then
            SearchSchoolNameTextBox.Text = ""
            testedComboBox.Text = "All"
            SearchCityTextBox.Text = ""
            Visited_SchoolsBindingSource.Filter = ""
            TextBoxAddress.Text = ""
            SearchEmployeeComboBox.Text = "All"
            CancelSearchButton.Enabled = False
            SearchSchoolIdTextBox.Text = ""
            ToolStripStatusLabel1.Text = "Showing All Schools"
        Else
            Dim FilterText As String
            FilterText = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If testedComboBox.Text <> "All" Then
                If testedComboBox.Text = "Yes" Then
                    FilterText &= " AND [Test Conducted]=TRUE"
                Else
                    FilterText &= " AND [Test Conducted]=FALSE"
                End If
            End If
            If SearchCityTextBox.Text <> "" Then
                FilterText &= " AND [City] Like( '%" & SearchCityTextBox.Text & "%')"
            End If
            If TextBoxAddress.Text <> "" Then
                FilterText &= " AND [Address] Like( '%" & TextBoxAddress.Text & "%')"
            End If
            If SearchEmployeeComboBox.Text <> "All" And SearchEmployeeComboBox.Text <> "" Then
                FilterText &= " AND [Attached Employee]=" & SearchEmployeeComboBox.SelectedValue
            End If

            If SearchSchoolIdTextBox.Text <> "" Then
                FilterText = " [SchoolId]=" & SearchSchoolIdTextBox.Text
            End If
            Visited_SchoolsBindingSource.Filter = FilterText
            CancelSearchButton.Enabled = True
            ToolStripStatusLabel1.Text = "Filter On " & Visited_SchoolsBindingSource.Count & " Schools Selected"

        End If
    End Sub

    Private Sub SearchSchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchoolNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub CancelSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSearchButton.Click
        CancelSearch()
    End Sub

    Private Sub Test_ConductedCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CancelSearch(False)
    End Sub

    Private Sub SchoolDetailsPanel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SchoolDetailsPanel.Leave
        If ToolStripStatusLabel1.Text = "New Record Added" And CancelRecordButton.Focus = False Then
            SaveSchoolDetails()
        End If

    End Sub

    '###############################################################################################
    '############ Test Summary  ########################################################################
    '###############################################################################################
    Private Sub TabPageTestSummary_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageTestSummary.Enter
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Tested_School' table. You can move, or remove it, as needed.
        'Me.Tested_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Tested_School)
        'Me.Tested_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Tested_School)
             'Me.Student_School_COmpleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Student_School_COmplete)
        'FillTestmarksReport()
    End Sub
    Private Sub FillReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillReportButton.Click
        FillTestmarksReport()
    End Sub
    Private Sub FillTestmarksReport()
        'fills report as per Filter
        Dim FilterText As String
        If ToolStripStatusLabel1.Text = "Showing All Schools" Or ShowAllCheckBox.Checked = False Then
            FilterText = ""
            Me.Student_School_COmpleteTableAdapter.FillBySchoolId(Me.Ingenium_2011DataSet.Student_School_COmplete, SchoolIdTextBox3.Text)
        Else
            FilterText = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If testedComboBox.Text <> "All" Then
                If testedComboBox.Text = "Yes" Then
                    FilterText &= " AND [Test Conducted]=TRUE"
                Else
                    FilterText &= " AND [Test Conducted]=FALSE"
                End If
            End If
            If SearchCityTextBox.Text <> "" Then
                FilterText &= " AND [City] Like( '%" & SearchCityTextBox.Text & "%')"
            End If
            If SearchEmployeeComboBox.Text <> "All" And SearchEmployeeComboBox.Text <> "" Then
                FilterText &= " AND [Attached Employee]=" & SearchEmployeeComboBox.SelectedValue
            End If
            'now refresh string
            If FilterText <> "" Then
                Dim DSet As New DataSet
                Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
                Dim ConString = COn.ConnectionString
                Dim Cn As New OleDbConnection(ConString)
                'Cn.Open()
                Dim ADDapter As New OleDbDataAdapter()
                'Fill Type
                ADDapter.SelectCommand = New OleDbCommand("SELECT Student.*, [Visited Schools].*, Stream.Stream AS Expr1 FROM ((Student INNER JOIN [Visited Schools] ON Student.SchoolId = [Visited Schools].SchoolId) INNER JOIN Stream ON Student.Stream = Stream.StreamId) Where " & FilterText, Cn)
                ADDapter.Fill(DSet)
                Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource3.Name = "Ingenium_2011DataSet_Student_School_COmplete"
                ReportDataSource3.Value = DSet.Tables(0)
                Me.ReportViewer3.LocalReport.DataSources.RemoveAt(0)    'remove existing
                Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
                Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School-Test-Report.rdlc"
            End If
        End If
        Me.ReportViewer3.RefreshReport()



    End Sub

    Private Sub SchoolIdTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolIdTextBox3.TextChanged
        If SchoolIdTextBox3.Text = "" Then
            EditButton.Enabled = False
        Else
            EditButton.Enabled = True
            If SchoolIdTextBox3.Text < 0 Then
                StuAddNewButton.Enabled = False
                StuEditButton.Enabled = False
            Else
                StuAddNewButton.Enabled = True
                StuEditButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub StuIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuIdTextBox.TextChanged
        If StuIdTextBox.Text = "" Then
            StuEditButton.Enabled = False
        Else
            StuEditButton.Enabled = True
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If SchoolIdTextBox3.Text < 0 Then
            MsgBox("Please save School before adding Students", MsgBoxStyle.Critical, "School Not Saved!")
            TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub testedComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testedComboBox.SelectedIndexChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchCityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCityTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub AllEmplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllEmplyButton.Click
        SearchEmployeeComboBox.Text = "All"
        CancelSearch(False)
    End Sub

    Private Sub SearchEmployeeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchEmployeeComboBox.SelectedIndexChanged
        CancelSearch(False)
    End Sub
    Private Sub CancelStuSearch(Optional ByVal Cancel As Boolean = True)
        Dim FilterText As String = "", StreamF As Boolean = False
        If Cancel Then
            SearchStuNameTextBox.Text = ""
            SearchStuIdTextBox.Text = ""
            'CancelSearchButton.Enabled = False
            MobileTextBox.Text = ""
            ToolStripStatusLabel4.Text = "Showing All Students"
        Else

            'If SearchStuNameTextBox.Text <> "" Then
            FilterText &= "  [Student Name] Like( '%" & SearchStuNameTextBox.Text & "%')"
            'End If
            If SearchStuIdTextBox.Text <> "" Then
                FilterText &= " AND [StuId] =" & SearchStuIdTextBox.Text
            End If
            If MobileTextBox.Text <> "" Then
                FilterText &= " AND ([Mobile Personal] Like( '%" & MobileTextBox.Text & "%') OR [Mobile Guardian] Like( '%" & MobileTextBox.Text & "%') OR [Other No] Like( '%" & MobileTextBox.Text & "%'))"
            End If
            StudentBindingSource.Filter = FilterText
            'Student_School_COmpleteBindingSource.Filter = FilterText
            ToolStripStatusLabel1.Text = "Showing " & Student_School_COmpleteBindingSource.Count & " Students"
            If LoginForm1.Role = "Administrator" Then
                If StreamF Then
                    'FilterText = FilterText.Replace("StreamName", "Stream.Stream")
                End If
                'Fillreport(FilterText)
            End If
        End If
    End Sub

    Private Sub SearchStuNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuNameTextBox.TextChanged
        CancelStuSearch(False)
    End Sub

    Private Sub SearchStuIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuIdTextBox.TextChanged
        CancelStuSearch(False)
    End Sub

    Private Sub MobileTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MobileTextBox.TextChanged
        CancelStuSearch(False)
    End Sub

    Private Sub ButtonCancelStuFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelStuFilter.Click
        CancelStuSearch(True)
    End Sub

    Private Sub TextBoxAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAddress.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub FillStudentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillStudentButton.Click
        If ReportCheckBox.Checked Then
            FillStudentReport()
        End If

    End Sub
    Private Sub FillStudentReport()
        'fills report as per Filter
        Dim FilterText As String
        If ToolStripStatusLabel1.Text = "Showing All Schools" Then
            FilterText = ""
            Me.Student_School_COmpleteTableAdapter.FillBySchoolId(Me.Ingenium_2011DataSet.Student_School_COmplete, SchoolIdTextBox3.Text)
        Else
            FilterText = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If testedComboBox.Text <> "All" Then
                If testedComboBox.Text = "Yes" Then
                    FilterText &= " AND [Test Conducted]=TRUE"
                Else
                    FilterText &= " AND [Test Conducted]=FALSE"
                End If
            End If
            If SearchCityTextBox.Text <> "" Then
                FilterText &= " AND [City] Like( '%" & SearchCityTextBox.Text & "%')"
            End If
            If SearchEmployeeComboBox.Text <> "All" And SearchEmployeeComboBox.Text <> "" Then
                FilterText &= " AND [Attached Employee]=" & SearchEmployeeComboBox.SelectedValue
            End If
            'now refresh string
            If FilterText <> "" Then
                Dim DSet As New DataSet
                Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
                Dim ConString = COn.ConnectionString
                Dim Cn As New OleDbConnection(ConString)
                'Cn.Open()
                Dim ADDapter As New OleDbDataAdapter()
                'Fill Type
                ADDapter.SelectCommand = New OleDbCommand("SELECT        Student.StuId, Student.SchoolId, Student.Stream, Student.[Student Name], Student.[Father Name], Student.Address, Student.[Mobile Personal],Student.[Mobile Guardian], Student.[Other No], Student.DOB, Student.Category, Student.[Father Occupation], Student.BPL, Student.[10th Grade], Student.[Ingenium%], Student.[Discount offered], Student.[Entry Date], [Visited Schools].SchoolId AS Expr2, [Visited Schools].[School Name], [Visited Schools].City, [Visited Schools].Address AS Expr3, [Visited Schools].Tel, [Visited Schools].[PCM Students], [Visited Schools].[PCB Students],[Visited Schools].[Commerce  Students], [Visited Schools].[Arts Students], [Visited Schools].[PGDM Students], [Visited Schools].[AG Students],[Visited Schools].Type, [Visited Schools].[Test Conducted], [Visited Schools].[Attached Employee], [Visited Schools].[Test Date], Stream.Stream AS Expr1,Employee.[Emply Name] FROM (((Student INNER JOIN [Visited Schools] ON Student.SchoolId = [Visited Schools].SchoolId) INNER JOIN Stream ON Student.Stream = Stream.StreamId) INNER JOIN Employee ON [Visited Schools].[Attached Employee] = Employee.EmplyId) Where (" & FilterText & ")", Cn)
                ADDapter.Fill(DSet)
                Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource3.Name = "Ingenium_2011DataSet_Student_School_COmplete"
                ReportDataSource3.Value = DSet.Tables(0)
                Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)    'remove existing
                Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource3)
                Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School Student Complete.rdlc"
            End If
        End If
        Me.ReportViewer2.RefreshReport()

    End Sub

    Private Sub TopperCheckBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TopperCheckBox.Leave
        SaveEditButton.Focus()
    End Sub



    Private Sub TopperCheckBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TopperCheckBox.LostFocus
        SaveEditButton.Focus()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MsgBox("This will delete School " & School_NameTextBox.Text & vbCrLf & "Sure?", MsgBoxStyle.YesNo, "Delete School Module") = MsgBoxResult.Yes Then
            Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
            Try
                'delete
                Url.DeleteSchool(SchoolIdTextBox3.Text)
                MsgBox("School Deleted Successfully", MsgBoxStyle.Information, "School Delete Module")
                LoadAdapter()
            Catch ex As Exception
                MsgBox("Error! School Not Deleted ", MsgBoxStyle.Information, "School Delete Module")
            End Try
        End If
    End Sub

    Private Sub SearchSchoolIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchSchoolIdTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        CategoryTextBox.Text = CategoryComboBox.Text
    End Sub
End Class
