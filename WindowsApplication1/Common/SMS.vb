Public Class SMS

    Private Sub SMSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSButton.Click
        If MobileTextBox.Text.Length < 10 Then
            ErrorProvider1.SetError(Me.MobileTextBox, "Incorrect Mobile Number")
        Else
            ErrorProvider1.SetError(Me.MobileTextBox, "")
            SendSms(MsgTextBox.Text, MobileTextBox.Text)
        End If

    End Sub
    Public Sub SendSms(ByVal Msg As String, ByVal Number As String)
        Try
            WebBrowser1.Navigate(New Uri("http://sms.suresoftsolutions.co.cc/WebServiceSMS.aspx?User=vision&passwd=vision&mobilenumber=" & Number & "&message=" & Msg & "&sid =vision&mtype=N"))
        Catch ex As System.UriFormatException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MsgTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsgTextBox.LostFocus
        If MsgTextBox.Text.Length > 159 Then
            ErrorProvider1.SetError(Me.MsgTextBox, "Message is more than 160 characters")
        Else
            ErrorProvider1.SetError(Me.MsgTextBox, "")
        End If
    End Sub
    Public Sub LoadSMSForm(ByVal Number As String)
        MobileTextBox.Text = Number
        Me.Show()
    End Sub
    Private Sub SMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAdapter()
        ShowAdapter(False)
    End Sub
    Private Sub MessageTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageTextBox.TextChanged
        CharactersTextBox.Text = MessageTextBox.Text.Length
    End Sub
    Private Sub LoadAdapter()
        Dim Xpos As Integer = SMS_TextBindingSource.Position
        Me.SMS_TextTableAdapter.Fill(Me.Ingenium_2011DataSet.SMS_Text)
        SMS_TextBindingSource.Position = Xpos
        ToolStripStatusLabel1.Text = SMS_TextBindingSource.Count & " Saved SMS"
    End Sub
    Private Sub ShowAdapter(ByVal show As Boolean)
        If show Then
            'edit mode
            SMS_TextDataGridView.ReadOnly = False
            DataPanel.Enabled = True
            acceptcancelPanel.Visible = True
            ToolStripStatusLabel2.Text = "Edit Mode"
        Else
            SMS_TextDataGridView.ReadOnly = True
            DataPanel.Enabled = False
            acceptcancelPanel.Visible = False
        End If
    End Sub
    Private Sub SaveAdapter(ByVal save As Boolean)
        If save Then
            Try
                Me.Validate()
                Me.SMS_TextBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
                ToolStripStatusLabel2.Text = "Saved"
                ToolStripStatusLabel2.BackColor = Color.GreenYellow
            Catch ex As Exception
                ToolStripStatusLabel2.Text = "Error. Not Saved!"
                ToolStripStatusLabel2.BackColor = Color.Red
            End Try
        Else
            Me.SMS_TextBindingSource.CancelEdit()
            ToolStripStatusLabel2.Text = "Edit Cancelled"
            ToolStripStatusLabel2.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub EditSMSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSMSButton.Click
        ShowAdapter(True)
    End Sub

    Private Sub SaveEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEditButton.Click
        SaveAdapter(True)
        LoadAdapter()
        ShowAdapter(False)
    End Sub

    Private Sub CancelEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEditButton.Click
        SaveAdapter(False)
        LoadAdapter()
        ShowAdapter(False)
    End Sub
    Private Sub SMS_TextDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SMS_TextDataGridView.DoubleClick
        MsgTextBox.Text = MessageTextBox.Text
    End Sub

    Private Sub MsgTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgTextBox.TextChanged
        MsgLengthTextBox.Text = MsgTextBox.Text.Length
    End Sub

    Private Sub MsgLengthTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgLengthTextBox.TextChanged
        If CInt(MsgLengthTextBox.Text) > 159 Then
            MsgLengthTextBox.BackColor = Color.Red
        Else
            MsgLengthTextBox.BackColor = Color.GreenYellow
        End If
    End Sub
End Class