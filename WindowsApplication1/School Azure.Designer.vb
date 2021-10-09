<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class School_Azure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(School_Azure))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Visited_SchoolsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Visited_SchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AzureSQLDataset = New WindowsApplication1.AzureSQLDataset()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Visited_SchoolsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Visited_SchoolsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.AzureSQLDatasetTableAdapters.Visited_SchoolsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AzureSQLDatasetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Visited_SchoolsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Visited_SchoolsBindingNavigator.SuspendLayout()
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AzureSQLDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Visited_SchoolsBindingNavigator
        '
        Me.Visited_SchoolsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Visited_SchoolsBindingNavigator.BindingSource = Me.Visited_SchoolsBindingSource
        Me.Visited_SchoolsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Visited_SchoolsBindingNavigator.DeleteItem = Nothing
        Me.Visited_SchoolsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Visited_SchoolsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Visited_SchoolsBindingNavigatorSaveItem})
        Me.Visited_SchoolsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Visited_SchoolsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Visited_SchoolsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Visited_SchoolsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Visited_SchoolsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Visited_SchoolsBindingNavigator.Name = "Visited_SchoolsBindingNavigator"
        Me.Visited_SchoolsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Visited_SchoolsBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.Visited_SchoolsBindingNavigator.TabIndex = 0
        Me.Visited_SchoolsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Visited_SchoolsBindingSource
        '
        Me.Visited_SchoolsBindingSource.DataMember = "Visited Schools"
        Me.Visited_SchoolsBindingSource.DataSource = Me.AzureSQLDataset
        '
        'AzureSQLDataset
        '
        Me.AzureSQLDataset.DataSetName = "AzureSQLDataset"
        Me.AzureSQLDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Visited_SchoolsBindingNavigatorSaveItem
        '
        Me.Visited_SchoolsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Visited_SchoolsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Visited_SchoolsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Visited_SchoolsBindingNavigatorSaveItem.Name = "Visited_SchoolsBindingNavigatorSaveItem"
        Me.Visited_SchoolsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Visited_SchoolsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Visited_SchoolsDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Visited_SchoolsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Visited_SchoolsDataGridView.AutoGenerateColumns = False
        Me.Visited_SchoolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Visited_SchoolsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Visited_SchoolsDataGridView.DataSource = Me.Visited_SchoolsBindingSource
        Me.Visited_SchoolsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Visited_SchoolsDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.Visited_SchoolsDataGridView.Name = "Visited_SchoolsDataGridView"
        Me.Visited_SchoolsDataGridView.RowHeadersWidth = 51
        Me.Visited_SchoolsDataGridView.RowTemplate.Height = 24
        Me.Visited_SchoolsDataGridView.Size = New System.Drawing.Size(800, 423)
        Me.Visited_SchoolsDataGridView.TabIndex = 1
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AzureSQLDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Me.Visited_SchoolsTableAdapter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SchoolId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SchoolId"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "School Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "School Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 165
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 105
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Attached Employee"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Attached Employee"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'School_Azure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Visited_SchoolsDataGridView)
        Me.Controls.Add(Me.Visited_SchoolsBindingNavigator)
        Me.Name = "School_Azure"
        Me.Text = "School_Azure"
        CType(Me.Visited_SchoolsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Visited_SchoolsBindingNavigator.ResumeLayout(False)
        Me.Visited_SchoolsBindingNavigator.PerformLayout()
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AzureSQLDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AzureSQLDataset As AzureSQLDataset
    Friend WithEvents Visited_SchoolsBindingSource As BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As AzureSQLDatasetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents TableAdapterManager As AzureSQLDatasetTableAdapters.TableAdapterManager
    Friend WithEvents Visited_SchoolsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Visited_SchoolsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Visited_SchoolsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
