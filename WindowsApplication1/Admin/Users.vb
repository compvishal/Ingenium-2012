Public Class Users

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAdapter()
        If LoginForm1.Role = "Administrator" Then
            ControlButtonPanel.Enabled = True
        End If
    End Sub
    Private Sub LoadAdapter()
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
    End Sub
    Private Sub SaveAdapter(Optional ByVal Save As Boolean = True)
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
            ToolStripStatusLabel1.Text = "Saved"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Error: Not Saved"
            ToolStripStatusLabel1.BackColor = Color.Crimson
        End Try

    End Sub
    Private Sub ReSetPassword()
        PasswordTextBox.Text = "1234"
    End Sub
    Private Sub SetUserName()
        If UserIdTextBox.Text = "" Then
            UserIdTextBox.Text = GenerateUserName(Emply_NameTextBox.Text)
            ToolStripStatusLabel1.Text = "Userid Generated"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
        Else
            ToolStripStatusLabel1.Text = "UserId Exists"
            ToolStripStatusLabel1.BackColor = Color.Crimson
        End If
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        SaveAdapter()
        LoadAdapter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReSetPassword()
        SaveAdapter()
        LoadAdapter()
        ToolStripStatusLabel1.Text = "Password Reset"
        ToolStripStatusLabel1.BackColor = Color.GreenYellow
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReSetPassword()
        SetUserName()
        SaveAdapter()
        LoadAdapter()
    End Sub
    Function GenerateUserName(ByVal OUserName As String) As String
        Dim StuName As String = OUserName, Stu2 As String = ""
        Dim Pos As Int16
        Pos = Rnd() * (StuName.Length - 1)
        Stu2 = StuName.Substring(Pos, 1)
        StuName = StuName.Substring(0, 5) & Stu2
        Stu2 = ""
        For i = 0 To 5
            If StuName.Substring(i, 1) <> " " Then
                Stu2 = Stu2 & StuName.Substring(i, 1)
            End If
        Next
        Stu2.ToLower()
        GenerateUserName = Stu2.ToLower & Int(Rnd() * 1000)
    End Function
End Class