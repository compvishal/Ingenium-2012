Imports System.Management

Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration

Public Class LoginForm1
    Public Shared UserName As String, Role As String, EmplyId As Int16

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'MsgBox(My.Computer.Name)
        'MsgBox(IIf(My.Application.IsNetworkDeployed, "By Network", "Aise hi"))
        'MsgBox(Application.StartupPath)
        'My.Application.
        'Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
        'MsgBox(COn.ConnectionString)
        'COn.ConnectionString
        'ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString") = "abc"
        'ConfigurationManager.ConnectionStrings.Remove("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
        'ConfigurationManager.ConnectionStrings.Add(COn)

        Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
        Dim ConString = COn.ConnectionString
        Dim FFlag As Boolean = False
        Dim Cn As New OleDbConnection(ConString)
        Dim Cmd As New OleDbCommand
        Cmd.Connection = Cn
        Cmd.CommandText = "SELECT EmplyId, UserId, [Password], Role FROM Employee where UserId= '" & UsernameTextBox.Text & "'"
        Try
            Cn.Open()
            Dim adReader As OleDbDataReader = Cmd.ExecuteReader
            'MsgBox(adReader.FieldCount)
            adReader.Read()
            If adReader.HasRows Then
                If UsernameTextBox.Text = adReader.Item(1) And PasswordTextBox.Text = adReader.Item(2) Then
                    ' Password Successful
                    EmplyId = adReader.Item(0)
                    UserName = UsernameTextBox.Text
                    Role = adReader.Item(3)
                    ' check is Password 1234, then show change password box
                    If PasswordTextBox.Text = "1234" Then
                        MsgBox("Hey " & UsernameTextBox.Text & "! Welcome in the League" & vbCrLf & "Small job before you proceed...change your Password" & vbCrLf & "I know no one likes any job.(I Don't!).But then this good for you", MsgBoxStyle.Exclamation, "First Time LogIn")
                        Change_Password.ShowDialog()
                        UsernameTextBox.Text = ""
                        PasswordTextBox.Text = ""
                        Exit Sub
                    End If
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Hide()
                    Ingenium2012.Show()
                Else
                    MsgBox("Hey Incorrect Password...  Snooping?", MsgBoxStyle.Critical, "Password Module")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Exit Sub
                End If
            Else
                MsgBox("Who are you???", MsgBoxStyle.Critical, "Few people come un-invited!")
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("Hey Dude u causing headache..." & vbCrLf & " Either ur Role not defined...else u a snooper!")
            'UsernameTextBox.Text = ""
            'PasswordTextBox.Text = ""
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        'try to update table
        Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
        Dim ConString = COn.ConnectionString
        Dim FFlag As Boolean = False
        Dim Cn As New OleDbConnection(ConString)
        Dim Cmd As New OleDbCommand
        Cmd.Connection = Cn
        Cmd.CommandText = "INSERT INTO Employee ([Emply Name]) Values ('New trial')"

        Try
            Cn.Open()
            Cmd.ExecuteNonQuery()
            MsgBox("Added")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'MsgBox("Why wasting my time? Eh...", MsgBoxStyle.Critical, "Few people come un-invited!")
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Url As New Common_Functions
        Me.Text &= Url.ReadHederText
        If Url.GetDriveSerialNumber = "B2BEEBE9" Then ' "80C659EC" Then
            UsernameTextBox.Text = "Vishal"
            PasswordTextBox.Text = "trip@4life"
            OK.Focus()
            'PressEnterButton()
        End If
        'UsernameTextBox.Text = "Vishal"
        'PasswordTextBox.Text = "kanpur@2"
        'UsernameTextBox.Text = "s@arunu533"
        'PasswordTextBox.Text = "4321"
        'UsernameTextBox.Text = "hyay10"
        'PasswordTextBox.Text = "76949"
    End Sub
End Class
