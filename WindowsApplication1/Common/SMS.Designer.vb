<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SmsIdLabel As System.Windows.Forms.Label
        Dim HeaderLabel As System.Windows.Forms.Label
        Dim MessageLabel As System.Windows.Forms.Label
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.MsgTextBox = New System.Windows.Forms.TextBox
        Me.SMSButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.acceptcancelPanel = New System.Windows.Forms.Panel
        Me.CancelEditButton = New System.Windows.Forms.Button
        Me.SaveEditButton = New System.Windows.Forms.Button
        Me.EditSMSButton = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.DataPanel = New System.Windows.Forms.Panel
        Me.CharactersTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SmsIdTextBox = New System.Windows.Forms.TextBox
        Me.SMS_TextBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.HeaderTextBox = New System.Windows.Forms.TextBox
        Me.MessageTextBox = New System.Windows.Forms.TextBox
        Me.SMS_TextDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SMS_TextTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.SMS_TextTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        Me.MsgLengthTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        SmsIdLabel = New System.Windows.Forms.Label
        HeaderLabel = New System.Windows.Forms.Label
        MessageLabel = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.acceptcancelPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.DataPanel.SuspendLayout()
        CType(Me.SMS_TextBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_TextDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SmsIdLabel
        '
        SmsIdLabel.AutoSize = True
        SmsIdLabel.Location = New System.Drawing.Point(8, 10)
        SmsIdLabel.Name = "SmsIdLabel"
        SmsIdLabel.Size = New System.Drawing.Size(42, 13)
        SmsIdLabel.TabIndex = 0
        SmsIdLabel.Text = "Sms Id:"
        '
        'HeaderLabel
        '
        HeaderLabel.AutoSize = True
        HeaderLabel.Location = New System.Drawing.Point(106, 10)
        HeaderLabel.Name = "HeaderLabel"
        HeaderLabel.Size = New System.Drawing.Size(45, 13)
        HeaderLabel.TabIndex = 2
        HeaderLabel.Text = "Header:"
        '
        'MessageLabel
        '
        MessageLabel.AutoSize = True
        MessageLabel.Location = New System.Drawing.Point(3, 37)
        MessageLabel.Name = "MessageLabel"
        MessageLabel.Size = New System.Drawing.Size(53, 13)
        MessageLabel.TabIndex = 4
        MessageLabel.Text = "Message:"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(8, 141)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(374, 258)
        Me.WebBrowser1.TabIndex = 7
        '
        'MobileTextBox
        '
        Me.MobileTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.MobileTextBox.Location = New System.Drawing.Point(55, 86)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(227, 20)
        Me.MobileTextBox.TabIndex = 6
        '
        'MsgTextBox
        '
        Me.MsgTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.MsgTextBox.ForeColor = System.Drawing.Color.DarkRed
        Me.MsgTextBox.Location = New System.Drawing.Point(55, 6)
        Me.MsgTextBox.Multiline = True
        Me.MsgTextBox.Name = "MsgTextBox"
        Me.MsgTextBox.Size = New System.Drawing.Size(227, 74)
        Me.MsgTextBox.TabIndex = 5
        '
        'SMSButton
        '
        Me.SMSButton.Location = New System.Drawing.Point(288, 6)
        Me.SMSButton.Name = "SMSButton"
        Me.SMSButton.Size = New System.Drawing.Size(74, 74)
        Me.SMSButton.TabIndex = 4
        Me.SMSButton.Text = "Send SMS"
        Me.SMSButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mobile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Separate Mobile Numbers by , All mobile numbers should be 10 digit"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.acceptcancelPanel)
        Me.Panel1.Controls.Add(Me.EditSMSButton)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.DataPanel)
        Me.Panel1.Controls.Add(Me.SMS_TextDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(388, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 411)
        Me.Panel1.TabIndex = 11
        '
        'acceptcancelPanel
        '
        Me.acceptcancelPanel.Controls.Add(Me.CancelEditButton)
        Me.acceptcancelPanel.Controls.Add(Me.SaveEditButton)
        Me.acceptcancelPanel.Location = New System.Drawing.Point(112, 341)
        Me.acceptcancelPanel.Name = "acceptcancelPanel"
        Me.acceptcancelPanel.Size = New System.Drawing.Size(179, 45)
        Me.acceptcancelPanel.TabIndex = 12
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Location = New System.Drawing.Point(86, 3)
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(75, 32)
        Me.CancelEditButton.TabIndex = 1
        Me.CancelEditButton.Text = "&Cancel"
        Me.CancelEditButton.UseVisualStyleBackColor = True
        '
        'SaveEditButton
        '
        Me.SaveEditButton.Location = New System.Drawing.Point(5, 3)
        Me.SaveEditButton.Name = "SaveEditButton"
        Me.SaveEditButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveEditButton.TabIndex = 0
        Me.SaveEditButton.Text = "&Save"
        Me.SaveEditButton.UseVisualStyleBackColor = True
        '
        'EditSMSButton
        '
        Me.EditSMSButton.Location = New System.Drawing.Point(31, 344)
        Me.EditSMSButton.Name = "EditSMSButton"
        Me.EditSMSButton.Size = New System.Drawing.Size(75, 35)
        Me.EditSMSButton.TabIndex = 11
        Me.EditSMSButton.Text = "Edit SMS"
        Me.EditSMSButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 387)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(334, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel2.Text = "View Mode"
        '
        'DataPanel
        '
        Me.DataPanel.Controls.Add(Me.CharactersTextBox)
        Me.DataPanel.Controls.Add(Me.Label4)
        Me.DataPanel.Controls.Add(SmsIdLabel)
        Me.DataPanel.Controls.Add(Me.SmsIdTextBox)
        Me.DataPanel.Controls.Add(HeaderLabel)
        Me.DataPanel.Controls.Add(Me.HeaderTextBox)
        Me.DataPanel.Controls.Add(MessageLabel)
        Me.DataPanel.Controls.Add(Me.MessageTextBox)
        Me.DataPanel.Location = New System.Drawing.Point(0, 226)
        Me.DataPanel.Name = "DataPanel"
        Me.DataPanel.Size = New System.Drawing.Size(329, 109)
        Me.DataPanel.TabIndex = 1
        '
        'CharactersTextBox
        '
        Me.CharactersTextBox.BackColor = System.Drawing.Color.YellowGreen
        Me.CharactersTextBox.Location = New System.Drawing.Point(11, 83)
        Me.CharactersTextBox.Name = "CharactersTextBox"
        Me.CharactersTextBox.ReadOnly = True
        Me.CharactersTextBox.Size = New System.Drawing.Size(34, 20)
        Me.CharactersTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Characters"
        '
        'SmsIdTextBox
        '
        Me.SmsIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SMS_TextBindingSource, "SmsId", True))
        Me.SmsIdTextBox.Location = New System.Drawing.Point(67, 7)
        Me.SmsIdTextBox.Name = "SmsIdTextBox"
        Me.SmsIdTextBox.Size = New System.Drawing.Size(21, 20)
        Me.SmsIdTextBox.TabIndex = 1
        '
        'SMS_TextBindingSource
        '
        Me.SMS_TextBindingSource.DataMember = "SMS Text"
        Me.SMS_TextBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderTextBox
        '
        Me.HeaderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SMS_TextBindingSource, "Header", True))
        Me.HeaderTextBox.Location = New System.Drawing.Point(165, 7)
        Me.HeaderTextBox.Name = "HeaderTextBox"
        Me.HeaderTextBox.Size = New System.Drawing.Size(152, 20)
        Me.HeaderTextBox.TabIndex = 3
        '
        'MessageTextBox
        '
        Me.MessageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SMS_TextBindingSource, "Message", True))
        Me.MessageTextBox.Location = New System.Drawing.Point(67, 33)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(255, 72)
        Me.MessageTextBox.TabIndex = 5
        '
        'SMS_TextDataGridView
        '
        Me.SMS_TextDataGridView.AutoGenerateColumns = False
        Me.SMS_TextDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SMS_TextDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SMS_TextDataGridView.DataSource = Me.SMS_TextBindingSource
        Me.SMS_TextDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.SMS_TextDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.SMS_TextDataGridView.Name = "SMS_TextDataGridView"
        Me.SMS_TextDataGridView.RowHeadersWidth = 21
        Me.SMS_TextDataGridView.Size = New System.Drawing.Size(334, 220)
        Me.SMS_TextDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Header"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Header"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Message"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 170
        '
        'SMS_TextTableAdapter
        '
        Me.SMS_TextTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._12thTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.Employee_Day_SheetTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.Event_MasterTableAdapter = Nothing
        Me.TableAdapterManager.Event_SchoolTableAdapter = Nothing
        Me.TableAdapterManager.Event_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Interested_StudentTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.SMS_TextTableAdapter = Me.SMS_TextTableAdapter
        Me.TableAdapterManager.StreamTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Nothing
        '
        'MsgLengthTextBox
        '
        Me.MsgLengthTextBox.BackColor = System.Drawing.Color.YellowGreen
        Me.MsgLengthTextBox.Location = New System.Drawing.Point(8, 49)
        Me.MsgLengthTextBox.Name = "MsgLengthTextBox"
        Me.MsgLengthTextBox.ReadOnly = True
        Me.MsgLengthTextBox.Size = New System.Drawing.Size(34, 20)
        Me.MsgLengthTextBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Char"
        '
        'SMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 411)
        Me.Controls.Add(Me.MsgLengthTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(Me.MsgTextBox)
        Me.Controls.Add(Me.SMSButton)
        Me.Name = "SMS"
        Me.Text = "SMS"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.acceptcancelPanel.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.DataPanel.ResumeLayout(False)
        Me.DataPanel.PerformLayout()
        CType(Me.SMS_TextBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_TextDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MsgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SMSButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SMS_TextBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SMS_TextTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.SMS_TextTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SMS_TextDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataPanel As System.Windows.Forms.Panel
    Friend WithEvents acceptcancelPanel As System.Windows.Forms.Panel
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents SaveEditButton As System.Windows.Forms.Button
    Friend WithEvents EditSMSButton As System.Windows.Forms.Button
    Friend WithEvents SmsIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CharactersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MsgLengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
