<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.components = New System.ComponentModel.Container()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager()
        Me.Emply_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ControlButtonPanel = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ControlButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(365, 358)
        Me.EmployeeDataGridView.TabIndex = 1
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 64)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Generate UserName Password"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 59)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ReSet Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 61)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "Save Edits"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 358)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(501, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "User Module"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(147, 81)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 14
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "UserId", True))
        Me.UserIdTextBox.Location = New System.Drawing.Point(117, 81)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIdTextBox.TabIndex = 15
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.Event_MasterTableAdapter = Nothing
        Me.TableAdapterManager.Event_SchoolTableAdapter = Nothing
        Me.TableAdapterManager.Event_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Interested_StudentTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.SMS_TextTableAdapter = Nothing
        Me.TableAdapterManager.StreamTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Nothing
        '
        'Emply_NameTextBox
        '
        Me.Emply_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Emply Name", True))
        Me.Emply_NameTextBox.Location = New System.Drawing.Point(147, 101)
        Me.Emply_NameTextBox.Name = "Emply_NameTextBox"
        Me.Emply_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Emply_NameTextBox.TabIndex = 16
        '
        'ControlButtonPanel
        '
        Me.ControlButtonPanel.Controls.Add(Me.SaveButton)
        Me.ControlButtonPanel.Controls.Add(Me.Button1)
        Me.ControlButtonPanel.Controls.Add(Me.Button4)
        Me.ControlButtonPanel.Enabled = False
        Me.ControlButtonPanel.Location = New System.Drawing.Point(399, 34)
        Me.ControlButtonPanel.Name = "ControlButtonPanel"
        Me.ControlButtonPanel.Size = New System.Drawing.Size(90, 240)
        Me.ControlButtonPanel.TabIndex = 17
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Emply Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Emply Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Role"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Role"
        Me.DataGridViewTextBoxColumn6.Items.AddRange(New Object() {"Marketing Manager", "Marketing Excutive", "DataOperator", "TeleOperator", "Administrator", "Admin-Other"})
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 380)
        Me.Controls.Add(Me.ControlButtonPanel)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Controls.Add(Me.Emply_NameTextBox)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Users"
        Me.Text = "Users"
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ControlButtonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emply_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ControlButtonPanel As Panel
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
End Class
