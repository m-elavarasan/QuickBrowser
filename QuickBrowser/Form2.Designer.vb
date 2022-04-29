<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MAINDBDataSet = New QuickBrowser.MAINDBDataSet()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoryTableAdapter = New QuickBrowser.MAINDBDataSetTableAdapters.historyTableAdapter()
        Me.SkeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAINDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(448, 643)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 80)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SkeyDataGridViewTextBoxColumn, Me.DtDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HistoryBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1102, 610)
        Me.DataGridView1.TabIndex = 1
        '
        'MAINDBDataSet
        '
        Me.MAINDBDataSet.DataSetName = "MAINDBDataSet"
        Me.MAINDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataMember = "history"
        Me.HistoryBindingSource.DataSource = Me.MAINDBDataSet
        '
        'HistoryTableAdapter
        '
        Me.HistoryTableAdapter.ClearBeforeFill = True
        '
        'SkeyDataGridViewTextBoxColumn
        '
        Me.SkeyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SkeyDataGridViewTextBoxColumn.DataPropertyName = "skey"
        Me.SkeyDataGridViewTextBoxColumn.HeaderText = "Search Key"
        Me.SkeyDataGridViewTextBoxColumn.Name = "SkeyDataGridViewTextBoxColumn"
        '
        'DtDataGridViewTextBoxColumn
        '
        Me.DtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DtDataGridViewTextBoxColumn.DataPropertyName = "dt"
        Me.DtDataGridViewTextBoxColumn.HeaderText = "Date and Time"
        Me.DtDataGridViewTextBoxColumn.Name = "DtDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1102, 768)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAINDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MAINDBDataSet As QuickBrowser.MAINDBDataSet
    Friend WithEvents HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HistoryTableAdapter As QuickBrowser.MAINDBDataSetTableAdapters.historyTableAdapter
    Friend WithEvents SkeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
