Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration
Public Class Employee
    'Dim OVisit_Date As Date, OPurpose As String, ONotes As String
    Dim Xpos As Int16
    Private Sub SaveEmployeeAdapter()
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
            Me.EmployeeTableAdapter.Update(Me.Ingenium_2011DataSet.Employee)
            ToolStripStatusLabel1.Text = "Saved"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
        Catch ex As Exception
            'MsgBox("Error: Not Saved")
            ToolStripStatusLabel1.Text = "Error"
            ToolStripStatusLabel1.BackColor = Color.Red
        End Try
    End Sub
    Private Sub LoadEmployeeAdapter()
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
    End Sub
    Private Sub Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Company_Employee_Complete' table. You can move, or remove it, as needed.
        'Me.Company_Employee_CompleteTableAdapter.FillByEmployeeId(Me.Ingenium_2011DataSet.Company_Employee_Complete, EmplyIdTextBox.Text)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.School_Visit_Complete' table. You can move, or remove it, as needed.
         Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        LoadEmployeeAdapter()

        'Me.ReportViewer2.RefreshReport()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'save changes
        SaveEmployeeAdapter()
        LoadEmployeeAdapter()
    End Sub

    '###################################
    '######### School Visit
    Private Sub PurposeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurposeComboBox.SelectedIndexChanged
        PurposeTextBox.Text = PurposeComboBox.Text
    End Sub

    Private Sub PurposeTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PurposeTextBox.TextChanged
        PurposeComboBox.Text = PurposeTextBox.Text
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        TabPage2.Text = "School Visit for " & Emply_NameTextBox.Text
        'TabPage2.ForeColor = Color.DarkOliveGreen
        LoadSchoolVisitAdapter()
        ShowSVButton(False)
    End Sub
    Private Sub LoadSchoolVisitAdapter()
        Xpos = School_VisitBindingSource.Position
        Me.EmployeeSchoolVisitTableAdapter.Fill(Me.Ingenium_2011DataSet.EmployeeSchoolVisit)
        Me.School_VisitTableAdapter.FillByEmployeeId(Me.Ingenium_2011DataSet.School_Visit, EmplyIdTextBox.Text)
        'Me.School_VisitTableAdapter.Fill(Me.Ingenium_2011DataSet.School_Visit)
        ToolStripStatusLabel3.Text = "No. of School Visits: " & School_VisitBindingSource.Count & "   "
        School_VisitBindingSource.Position = Xpos
    End Sub
    Private Sub ShowSVButton(Optional ByVal Show As Boolean = True)
        If Show Then
            SaveCancelPanel.Visible = True
            SchoolVisitPanel.Enabled = True
            EmployeeSchoolVisitDataGridView.ReadOnly = False
            AddNewButton1.Enabled = False
            EditButton.Enabled = False
        Else
            SaveCancelPanel.Visible = False
            SchoolVisitPanel.Enabled = False
            EmployeeSchoolVisitDataGridView.ReadOnly = True
            AddNewButton1.Enabled = True
            EditButton.Enabled = True
        End If
    End Sub
    Private Sub SaveEVAdapter(Optional ByVal Save As Boolean = True)
        If Save Then
            Try
                Me.Validate()
                'Me.EmployeeBindingSource.EndEdit()
                'Me.School_VisitBindingSource.EndEdit()
                Me.EmployeeSchoolVisitBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
                Me.EmployeeSchoolVisitTableAdapter.Update(Me.Ingenium_2011DataSet.EmployeeSchoolVisit)

                'save using command
                Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
                Dim ConString = COn.ConnectionString
                Dim Cn As New OleDbConnection(ConString)
                'Dim cmd As New System.Data.SqlClient.SqlCommand
                Dim Cmd As New System.Data.OleDb.OleDbCommand
                cmd.CommandType = System.Data.CommandType.Text
                Cmd.CommandText = "UPDATE  [School Visit] SET  SchoolId = " & SchoolIdTextBox.Text & ", [Visit Date] = #" & Visit_DateDateTimePicker.Value & "#, Purpose = '" & PurposeComboBox.Text & "', Notes ='" & NotesTextBox.Text & "' WHERE VisitId = " & VisitIdTextBox.Text ' & "'"
                Cmd.Connection = Cn
                Cn.Open()
                cmd.ExecuteNonQuery()
                Cn.Close()

                ToolStripStatusLabel2.Text = "Saved"
                ToolStripStatusLabel2.BackColor = Color.GreenYellow
            Catch ex As Exception
                'MsgBox("Error")
                ToolStripStatusLabel2.Text = "Error: Not Saved"
                ToolStripStatusLabel2.BackColor = Color.Red
            End Try
        Else
            Me.School_VisitBindingSource.CancelEdit()
            Me.EmployeeSchoolVisitBindingSource.CancelEdit()
            ToolStripStatusLabel2.Text = "Edit Cancelled"
            ToolStripStatusLabel2.BackColor = Color.Cornsilk
        End If
    End Sub
    Private Sub AddNewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewButton1.Click
        School_VisitBindingSource.AddNew()
        'Dim nrow As New Ingenium_2011DataSet.School_VisitRow
        'nrow.SchoolId = 22
        'School_VisitBindingSource.Add(nRow)
        Try
            Dim Upd As New Ingenium_2011DataSetTableAdapters.School_VisitTableAdapter
            Dim MaxVisitId As Integer = Upd.GetMaxVisitId
            School_VisitTableAdapter.Insert(1, Today, "", "")
            School_VisitTableAdapter.Update(Ingenium_2011DataSet.School_Visit)
            'get lastest School_visit & add employee to the same
            EmployeeSchoolVisitTableAdapter.Insert(EmplyIdTextBox.Text, MaxVisitId + 1)
            SaveEVAdapter()
            LoadSchoolVisitAdapter()
            ShowSVButton()
            ToolStripStatusLabel2.Text = "New Visit Added"
            ToolStripStatusLabel2.BackColor = Color.YellowGreen
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "Error: Cannot Add New Visit. Add from School Tab"
            ToolStripStatusLabel2.BackColor = Color.Red
        End Try
        'GetOriginalValues()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        ShowSVButton()
        'GetOriginalValues()
    End Sub

    Private Sub SaveRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecordButton.Click
        If Not (CheckDataSVError()) Then
            SaveEVAdapter()
            LoadSchoolVisitAdapter()
            ShowSVButton(False)
        End If
    End Sub

    Private Sub CancelRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelRecordButton.Click
        SaveEVAdapter(False)
        LoadSchoolVisitAdapter()
        ShowSVButton(False)
    End Sub
    Private Function CheckDataSVError()
        ErrorProvider1.SetError(Me.Visit_DateDateTimePicker, "")
        ErrorProvider1.SetError(Me.PurposeComboBox, "")
        'start checking
        CheckDataSVError = True
        If PurposeComboBox.Text = "" Then
            'no school name
            ErrorProvider1.SetError(Me.PurposeComboBox, "Select Purpose")
            Exit Function
        End If
        If Visit_DateDateTimePicker.Value > Today Then
            'no address
            ErrorProvider1.SetError(Me.Visit_DateDateTimePicker, "Select Proper Date")
            Exit Function
        End If
        'no error
        CheckDataSVError = False
    End Function

    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        Me.School_Visit_CompleteTableAdapter.FillByEmployeeId(Me.Ingenium_2011DataSet.School_Visit_Complete, EmplyIdTextBox.Text)
        Me.ReportViewer1.RefreshReport()
        TabPage3.Text = "School Visit Report for " & Emply_NameTextBox.Text
    End Sub
    Private Sub EmployeeWorkAdapter()
        Try
            Dim Emplyid As Integer = EmplyIdTextBox.Text
            Dim ur As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
            NoSchoolVisitTextBox.Text = ur.EmployeeNoofSchoolVisited(Emplyid)
            NoStudentTextBox.Text = ur.EmployeeNoofStudents(Emplyid)
            PCMTextBox.Text = ur.EmployeeNoofStudentsPCM(Emplyid)
            PCBTextBox.Text = ur.EmployeeNoofStudentsPCB(Emplyid)
            CommerceTextBox.Text = ur.EmployeeNoofStudentsCOmmerce(Emplyid)
            ArtTextBox.Text = ur.EmployeeNoofStudentsArt(Emplyid)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub EmployeeBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmployeeBindingSource.PositionChanged
        EmployeeWorkAdapter()
    End Sub

    Private Sub TabPage4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage4.Enter
        Me.Company_Employee_CompleteTableAdapter.FillByEmployeeId(Me.Ingenium_2011DataSet.Company_Employee_Complete, EmplyIdTextBox.Text)
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class