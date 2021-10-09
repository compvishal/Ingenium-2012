Imports System.Windows.Forms

Public Class Ingenium2012

    Private Sub Ingenium2011_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StudentDataToolStripMenuItem.Enabled = False
        If LoginForm1.Role = "Administrator" Or LoginForm1.Role = "Admin-Other" Then
            AdminToolStripMenuItem.Enabled = True
            EventMasterToolStripMenuItem.Enabled = True
            EventStudentReportToolStripMenuItem.Enabled = True
            EventReportToolStripMenuItem.Enabled = True
            If LoginForm1.UserName = "Vishal" Then
                EventReportToolStripMenuItem.Enabled = True
                StudentDataToolStripMenuItem.Enabled = True
            End If
        End If
        'ElseIf LoginForm1.Role = "DataOperator" Or LoginForm1.Role = "TeleOperator" Then
        'DataToolStripMenuItem.Enabled = False  '   allow to add Data
        'EmployeeToolStripMenuItem.Enabled = False
        'EventsToolStripMenuItem.Enabled = True
        'Marks.MdiParent = Me
        '   Marks.Show()
        'EventMasterToolStripMenuItem.Enabled = False
        'EmployeeNameToolStripMenuItem.Enabled = False
        'Exit Sub
        'End If
        'ShowSchool()
    End Sub

    Private Sub SchoolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolsToolStripMenuItem.Click
        ShowSchool()
    End Sub
    Private Sub ShowSchool()
        School.MdiParent = Me
        School.Show()
    End Sub

    Private Sub EmployeeNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeNameToolStripMenuItem.Click
        Employee.MdiParent = Me
        Employee.Show()
    End Sub

    Private Sub SchoolVisitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolVisitToolStripMenuItem.Click
        School_Visit.MdiParent = Me
        School_Visit.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        'Students.MdiParent = Me
        'Students.Show()
        Students2.MdiParent = Me
        Students2.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        Users.MdiParent = Me
        Users.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LogOff()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Change_Password.ShowDialog()
        If Change_Password.PasswordChanged Then LogOff()
    End Sub
    Private Sub LogOff()
        Me.Dispose()
        LoginForm1.Show()
    End Sub

    Private Sub TestsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestsToolStripMenuItem.Click
        Company.MdiParent = Me
        Company.Show()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        LogOff()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        School_Test.MdiParent = Me
        School_Test.Show()
    End Sub

    Private Sub BirthDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthDayToolStripMenuItem.Click
        Birthday.MdiParent = Me
        Birthday.Show()
    End Sub

    Private Sub MarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksToolStripMenuItem.Click
        Marks.MdiParent = Me
        Marks.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Student_Data_Report.MdiParent = Me
        Student_Data_Report.Show()
    End Sub

    Private Sub WorkDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkDetailsToolStripMenuItem.Click
        Day_Sheet.MdiParent = Me
        Day_Sheet.Show()
    End Sub

    Private Sub EventMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventMasterToolStripMenuItem.Click
        Event_Master.MdiParent = Me
        Event_Master.Show()
    End Sub

    Private Sub EventTelecallingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventTelecallingToolStripMenuItem.Click
        'Event_Telecalling2.MdiParent = Me
        'Event_Telecalling2.Show()

        Events_Students_Telecalling.MdiParent = Me
        Events_Students_Telecalling.Show()
    End Sub

    Private Sub EventReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventReportToolStripMenuItem.Click
        'Event_Report.MdiParent = Me
        'Event_Report.Show()
        Event_Covered.MdiParent = Me
        Event_Covered.Show()
    End Sub

    Private Sub InterestedStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterestedStudentsToolStripMenuItem.Click
        Interested_Students.MdiParent = Me
        Interested_Students.Show()
    End Sub

    Private Sub SMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSToolStripMenuItem.Click
        SMS.MdiParent = Me
        SMS.Show()
    End Sub

    Private Sub TestReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestReportToolStripMenuItem.Click
        Test_Report.MdiParent = Me
        Test_Report.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Students2.MdiParent = Me
        Students2.Show()
    End Sub

    Private Sub TelecallingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelecallingToolStripMenuItem.Click
        Events_Students_Telecalling.MdiParent = Me
        Events_Students_Telecalling.Show()
    End Sub

    Private Sub TopperStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopperStudentToolStripMenuItem.Click
        Topper_Students.MdiParent = Me
        Topper_Students.Show()
    End Sub

    Private Sub AdminFunctionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminFunctionsToolStripMenuItem.Click
        Admin_Functions.MdiParent = Me
        Admin_Functions.Show()
    End Sub

    Private Sub CompleteDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteDataToolStripMenuItem.Click
        Complete_Data.MdiParent = Me
        Complete_Data.Show()
    End Sub

    Private Sub EventStudentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventStudentReportToolStripMenuItem.Click
        Event_Student_Report.MdiParent = Me
        Event_Student_Report.Show()
    End Sub

    Private Sub DailyEntryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyEntryReportToolStripMenuItem.Click
        ShowForm(Daily_Entry_Report)
    End Sub
    Private Sub ShowForm(frm As Form)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DOBReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOBReportToolStripMenuItem.Click
        ShowForm(Birthday_record)
    End Sub

    Private Sub StudentDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDataToolStripMenuItem.Click
        ShowForm(Student_Data_Complete)
    End Sub

    Private Sub CityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CityToolStripMenuItem.Click
        ShowForm(City)
    End Sub

    Private Sub CityToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CityToolStripMenuItem1.Click
        ShowForm(City)
    End Sub

    Private Sub SectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectorToolStripMenuItem.Click
        ShowForm(Sector_Segment)
    End Sub

    Private Sub ContactEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactEntryToolStripMenuItem.Click
        ShowForm(Contacts)
    End Sub



    Private Sub SchoolToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SchoolToolStripMenuItem1.Click
        ShowForm(School_Azure)
    End Sub

    Private Sub EmployeeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem1.Click
        ShowForm(Employee_Azure)
    End Sub
End Class
