Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration
Public Class Event_Master

    Private Sub Event_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Event_Student_Complete' table. You can move, or remove it, as needed.
        Me.Event_Student_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Student_Complete)
        If LoginForm1.Role = "Administrator" Or LoginForm1.Role = "Admin-Other" Then
            PanelAdmin.Enabled = True
        Else
            PanelAdmin.Enabled = False
        End If
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet1.Employee)
        Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        Event_MasterDataGridView.ReadOnly = True
        'Event_SchoolDataGridView.ReadOnly = True
        Visited_SchoolsDataGridView.ReadOnly = True
        Panel3.Enabled = False
        ShowButtonEvent(False)
        LoadAdapter()
        ToolStripStatusLabel2.Text = "View Mode"
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub LoadAdapter()
        Dim Xpos As Integer = Event_MasterBindingSource.Position
        Dim XESPos As Integer = Event_SchoolBindingSource.Position
        Me.Event_MasterTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_Master)
        Me.Event_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Event_School)
        ToolStripStatusLabel1.Text = Event_MasterBindingSource.Count & " Events Added"
        Event_MasterBindingSource.Position = Xpos
        Event_SchoolBindingSource.Position = XESPos
        Me.Text = "Selected Event: " & Event_NameTextBox.Text & " " & Event_SchoolBindingSource.Count & " schools added to Event"
    End Sub

    Private Sub ShowButtonEvent(Optional ByVal Show As Boolean = True)
        If Show Then
            'allow edit for Event
            SchoolPanel.Enabled = False
            EventMasterPanel.Enabled = True
            AddNewEventButton.Enabled = False
            EditEventButton.Enabled = False
            EventSaveCancelPanel.Visible = True
        Else
            SchoolPanel.Enabled = True
            EventMasterPanel.Enabled = False
            AddNewEventButton.Enabled = True
            EditEventButton.Enabled = True
            EventSaveCancelPanel.Visible = False
        End If
    End Sub
    Private Sub SaveAdapterEvent(Optional ByVal Save As Boolean = True)
        Try
            If Save Then
                'save
                Me.Validate()
                Me.Event_MasterBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
                Me.Event_MasterTableAdapter.Update(Me.Ingenium_2011DataSet.Event_Master)
                ToolStripStatusLabel2.Text = "Saved!"
                ToolStripStatusLabel2.BackColor = Color.GreenYellow
            Else
                'cancel
                Me.Event_MasterBindingSource.CancelEdit()
                ToolStripStatusLabel2.Text = "Edit Cancelled"
                ToolStripStatusLabel2.BackColor = Color.SeaShell
            End If
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "Error! Not Saved"
            ToolStripStatusLabel2.BackColor = Color.Red
        End Try
    End Sub
    Private Sub SaveAdapterES()
        Try
            Me.Validate()
            Me.Event_SchoolBindingSource.EndEdit()
            Me.Event_SchoolTableAdapter.Update(Me.Ingenium_2011DataSet.Event_School)
            ToolStripStatusLabel2.Text = School_NameTextBox.Text & " added to Event"
            ToolStripStatusLabel2.BackColor = Color.GreenYellow
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "Error! Not Saved"
            ToolStripStatusLabel2.BackColor = Color.Red
        End Try
    End Sub

    Private Sub AddNewEventButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEventButton.Click
        Event_MasterBindingSource.AddNew()
        ShowButtonEvent(True)
        ToolStripStatusLabel2.Text = "New Event Added"
    End Sub

    Private Sub EditEventButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEventButton.Click
        ShowButtonEvent(True)
        ToolStripStatusLabel2.Text = "Edit Mode"
    End Sub

    Private Sub SaveRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecordButton.Click
        SaveAdapterEvent(True)
        ShowButtonEvent(False)
        LoadAdapter()
    End Sub

    Private Sub CancelRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelRecordButton.Click
        SaveAdapterEvent(False)
        ShowButtonEvent(False)
        LoadAdapter()
    End Sub
    Private Sub CancelSearch(Optional ByVal Cancel As Boolean = True)
        If Cancel Then
            SearchSchoolNameTextBox.Text = ""
            VisitedSchoolsBindingSource.Filter = ""
            SearchCityTextBox.Text = ""
            TextBoxAddress.Text = ""
            CancelSearchButton.Enabled = False
            SearchTextBoxSchoolId.Text = ""
            ToolStripStatusLabel2.Text = "Showing All Schools"
        Else
            Dim FilterText As String
            FilterText = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If SearchCityTextBox.Text <> "" Then
                FilterText &= " AND [City] Like( '%" & SearchCityTextBox.Text & "%')"
            End If
            If TextBoxAddress.Text <> "" Then
                FilterText &= " AND [Address] Like( '%" & TextBoxAddress.Text & "%')"
            End If
            If SearchTextBoxSchoolId.Text <> "" Then
                FilterText = " [SchoolId] =(" & SearchTextBoxSchoolId.Text & ")"
            End If
            VisitedSchoolsBindingSource.Filter = FilterText
            CancelSearchButton.Enabled = True
            ToolStripStatusLabel2.Text = "Filter On " & VisitedSchoolsBindingSource.Count & " Schools Selected"

        End If
    End Sub

    Private Sub SearchSchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchoolNameTextBox.TextChanged
        CancelSearch(False)
    End Sub
    Private Sub SearchCityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCityTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub TextBoxAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAddress.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub CancelSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSearchButton.Click
        CancelSearch()
    End Sub

    Private Sub AddSchoolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSchoolButton.Click
        If SchoolIdTextBox.Text = "" Then
            MsgBox("Pl select School", MsgBoxStyle.Critical, "Error!")
            Exit Sub
        End If
        Dim UL As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        If UL.GetEventSchoolExists(SchoolIdTextBox.Text, EventIdTextBox.Text) Then
            MsgBox(School_NameTextBox.Text & " School already added to the Event", MsgBoxStyle.Critical, "Error!")
            Exit Sub
        End If
        'check school added in other event
        Dim EventDetails As String = UL.GetEventNameforSchoolId(SchoolIdTextBox.Text)
        If Not (IsNothing(EventDetails)) Then
            If MsgBox("School already added in " & EventDetails & vbCrLf & "Add Again?", MsgBoxStyle.YesNo, "Add School to Event") = MsgBoxResult.No Then Exit Sub
        End If
        UL.InsertEventSchool(SchoolIdTextBox.Text, EventIdTextBox.Text)
        'SaveAdapterES()
        ToolStripStatusLabel2.Text = School_NameTextBox.Text & " added to Event"
        'CancelSearch()
        LoadAdapter()


    End Sub

    Private Sub Event_SchoolDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Event_SchoolDataGridView.CellContentClick

    End Sub

    Private Sub Event_SchoolDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Event_SchoolDataGridView.DataError
        'MsgBox(e.ToString)
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        'Me.Visited_SchoolsTableAdapter.FillByEventId(Me.Ingenium_2011DataSet.Visited_Schools, EventIdTextBox.Text)
        'Me.CompleteSchoolTableAdapter.FillByEventId(Me.Ingenium_2011DataSet.CompleteSchool, EventIdTextBox.Text)
        'Me.CompleteSchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.CompleteSchool)
        'Me.Complete_School_in_EventTableAdapter.Fill(Me.Ingenium_2011DataSet.Complete_School_in_Event)
        Me.Complete_School_in_EventTableAdapter.FillByEventId(Me.Ingenium_2011DataSet.Complete_School_in_Event, EventIdTextBox.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TabPage2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Leave
        ' Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
    End Sub


    Private Sub UpdateStudentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentButton.Click
        UpdateStudentList()
    End Sub

    Private Sub UpdateStudentList()
        Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
        Dim ConString = COn.ConnectionString
        Dim Cn As New OleDbConnection(ConString)
        Dim Cmd As New OleDbCommand
        Cmd.Connection = Cn
        Dim StreamType = InputBox("Give Stream Type- 0-PCM/PCB; 1-BBA/BCA; 2-PGDM; 3-ONLY PCM; 4-ALL; 5-Only PCB; 6-10th")
        If StreamType = "0" Then
            StreamType = "(Stream = 1 OR Stream = 2 OR Stream = 5 OR Stream = 7)"
        ElseIf StreamType = "1" Then
            StreamType = "(Stream = 3 OR Stream = 4 OR Stream = 6)"
        ElseIf StreamType = "3" Then
            StreamType = "(Stream = 1)"
        ElseIf StreamType = "4" Then
            StreamType = "(Stream >0)"
        ElseIf StreamType = "3" Then
            StreamType = "(Stream >7)"
        ElseIf StreamType = "5" Then
            StreamType = "(Stream =2)"
        ElseIf StreamType = "6" Then
            StreamType = "(Stream =14)"
        End If
        Cmd.CommandText = "SELECT StuId,SchoolId FROM (Student) WHERE (SchoolId IN(SELECT SchoolId FROM [Event School] WHERE (EventId = " & EventIdTextBox.Text & "))) AND (StuId NOT IN (SELECT StudentId FROM [Event Students] WHERE (EventId =" & EventIdTextBox.Text & "))) AND " & StreamType
        Try
            Cn.Open()
            Dim adReader As OleDbDataReader = Cmd.ExecuteReader, NoRowsInsert As Integer
            Dim UL As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
            'adReader.Read()
            While adReader.Read
                UL.InsertEventStudent(EventIdTextBox.Text, adReader(1).ToString, adReader(0).ToString)
                NoRowsInsert += 1
            End While
            MsgBox(NoRowsInsert & " New Students Added Successfully", MsgBoxStyle.OkOnly, "New Students Added to Event")
        Catch ex As Exception
            MsgBox("Error in Writing")
        End Try

    End Sub

 
    Private Sub RemoveSchoolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSchoolButton.Click
        Dim Upd As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        Dim SelectedSchoolId As Integer = Event_SchoolDataGridView.SelectedCells(0).Value
        Try
            If MsgBox("Delete School & all Students of " & Upd.GetSchoolNameforId(SelectedSchoolId) & " from Event?", MsgBoxStyle.YesNo, "Delete School Module") = MsgBoxResult.Yes Then
                'delete school
                Upd.DeleteSchoolfrmEventSchools(SelectedSchoolId, EventIdTextBox.Text)
                'delete all students
                Upd.DeleteAllStudentsfrmEventStudents(EventIdTextBox.Text, SelectedSchoolId)
                MsgBox("Deleted" & Upd.GetSchoolNameforId(SelectedSchoolId), MsgBoxStyle.Information, "Delete School Module")
                LoadAdapter()
            End If
        Catch ex As Exception
            MsgBox("Error in deleting School/Students", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub SearchTextBoxSchoolId_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBoxSchoolId.TextChanged
        CancelSearch(False)
    End Sub
End Class