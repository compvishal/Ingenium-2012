Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration

Public Class Change_Password
    Public PasswordChanged As Boolean = False

    Private Sub ConfirmPassTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ConfirmPassTextBox.Validating
        ' If Not IsNumeric(TextBox1.Text) Then
        If NewPasswordTextBox.Text <> ConfirmPassTextBox.Text Then
            ErrorProvider1.SetError(ConfirmPassTextBox, "Password Not Matching")
            ChangeButton.Enabled = False
        Else
            ' Clear the error.
            ErrorProvider1.SetError(ConfirmPassTextBox, "")
            ChangeButton.Enabled = True
        End If
    End Sub
    Private Sub OldPassTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles OldPassTextBox.Validated
        If Me.OldPassTextBox.Text = "" Then
            ErrorProvider1.SetError(Me.OldPassTextBox, "Can't be left Blank")
            ChangeButton.Enabled = False
        Else
            ' Clear the error.
            ErrorProvider1.SetError(Me.OldPassTextBox, "")
            ChangeButton.Enabled = True
        End If
    End Sub

    Private Sub ChangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeButton.Click
        'reset all errors
        ErrorProvider1.SetError(Me.NewPasswordTextBox, "")
        ErrorProvider1.SetError(Me.OldPassTextBox, "")
        'check new & old pasword differ
        If OldPassTextBox.Text = NewPasswordTextBox.Text Then
            ErrorProvider1.SetError(Me.NewPasswordTextBox, "Old & New Password cannot be same")
            Exit Sub
        End If
        'ok...continue

        Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
        Dim ConString = COn.ConnectionString
        Dim FFlag As Boolean = False
        Dim Cn As New OleDbConnection(ConString)
        Dim userName = LoginForm1.UserName
        Dim Cmd As New OleDbCommand
        Cmd.Connection = Cn
        Cmd.CommandText = "Select Password from [Employee] where UserId='" & userName & "'"
        Try
            Cn.Open()
            Dim adReader As OleDbDataReader = Cmd.ExecuteReader
            'MsgBox(adReader.FieldCount)
            adReader.Read()
            If OldPassTextBox.Text = adReader.Item(0) Then
                'now update password
                ' userName = NewPasswordTextBox.Text
                Dim Upd As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
                Upd.UpdatePassword(NewPasswordTextBox.Text, userName)
                MsgBox("Password Changed successfully", , "Password Change Module")
                PasswordChanged = True
                Cn.Close()
                Me.Dispose()

            Else
                ErrorProvider1.SetError(Me.OldPassTextBox, "Incorrect Old Password")
                Cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Cn.Close()
        End Try

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Dispose()
    End Sub

    Private Sub NewPasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPasswordTextBox.TextChanged

    End Sub

    Private Sub NewPasswordTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewPasswordTextBox.Validated
        If Me.NewPasswordTextBox.Text = "" Then
            ErrorProvider1.SetError(Me.NewPasswordTextBox, "Can't be left Blank")
            ChangeButton.Enabled = False
        Else
            ' Clear the error.
            ErrorProvider1.SetError(Me.NewPasswordTextBox, "")
            ChangeButton.Enabled = True
        End If
    End Sub

    Private Sub Change_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class