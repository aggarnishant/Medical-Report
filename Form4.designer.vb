<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainfieldsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRdatabaseDataSet6 = New WindowsApplication1.MRdatabaseDataSet6()
        Me.MainfieldsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRdatabaseDataSet5 = New WindowsApplication1.MRdatabaseDataSet5()
        Me.MainfieldsTableAdapter = New WindowsApplication1.MRdatabaseDataSet4TableAdapters.mainfieldsTableAdapter()
        Me.MRdatabaseDataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRdatabaseDataSet4 = New WindowsApplication1.MRdatabaseDataSet4()
        Me.MainfieldsTableAdapter1 = New WindowsApplication1.MRdatabaseDataSet5TableAdapters.mainfieldsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainfieldsTableAdapter2 = New WindowsApplication1.MRdatabaseDataSet6TableAdapters.mainfieldsTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MRdatabaseDataSet8 = New WindowsApplication1.MRdatabaseDataSet8()
        Me.MainfieldsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainfieldsTableAdapter3 = New WindowsApplication1.MRdatabaseDataSet8TableAdapters.mainfieldsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComplaintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MainfieldsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRdatabaseDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainfieldsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRdatabaseDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRdatabaseDataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRdatabaseDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MRdatabaseDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainfieldsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainfieldsBindingSource1
        '
        Me.MainfieldsBindingSource1.DataMember = "mainfields"
        Me.MainfieldsBindingSource1.DataSource = Me.MRdatabaseDataSet6
        '
        'MRdatabaseDataSet6
        '
        Me.MRdatabaseDataSet6.DataSetName = "MRdatabaseDataSet6"
        Me.MRdatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainfieldsBindingSource
        '
        Me.MainfieldsBindingSource.DataMember = "mainfields"
        Me.MainfieldsBindingSource.DataSource = Me.MRdatabaseDataSet5
        '
        'MRdatabaseDataSet5
        '
        Me.MRdatabaseDataSet5.DataSetName = "MRdatabaseDataSet5"
        Me.MRdatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainfieldsTableAdapter
        '
        Me.MainfieldsTableAdapter.ClearBeforeFill = True
        '
        'MRdatabaseDataSet4BindingSource
        '
        Me.MRdatabaseDataSet4BindingSource.DataSource = Me.MRdatabaseDataSet4
        Me.MRdatabaseDataSet4BindingSource.Position = 0
        '
        'MRdatabaseDataSet4
        '
        Me.MRdatabaseDataSet4.DataSetName = "MRdatabaseDataSet4"
        Me.MRdatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainfieldsTableAdapter1
        '
        Me.MainfieldsTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(170, 69)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainfieldsTableAdapter2
        '
        Me.MainfieldsTableAdapter2.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PnameDataGridViewTextBoxColumn, Me.PageDataGridViewTextBoxColumn, Me.DTDataGridViewTextBoxColumn, Me.ComplaintDataGridViewTextBoxColumn, Me.MoboDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MainfieldsBindingSource2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(170, 450)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1254, 360)
        Me.DataGridView2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(908, 69)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 370)
        Me.Panel1.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(122, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(319, 42)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Search Date Wise"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(26, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(26, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Date"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(275, 104)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 49)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(275, 194)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 49)
        Me.TextBox2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(275, 262)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 78)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MRdatabaseDataSet8
        '
        Me.MRdatabaseDataSet8.DataSetName = "MRdatabaseDataSet8"
        Me.MRdatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainfieldsBindingSource2
        '
        Me.MainfieldsBindingSource2.DataMember = "mainfields"
        Me.MainfieldsBindingSource2.DataSource = Me.MRdatabaseDataSet8
        '
        'MainfieldsTableAdapter3
        '
        Me.MainfieldsTableAdapter3.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'PnameDataGridViewTextBoxColumn
        '
        Me.PnameDataGridViewTextBoxColumn.DataPropertyName = "Pname"
        Me.PnameDataGridViewTextBoxColumn.HeaderText = "Pname"
        Me.PnameDataGridViewTextBoxColumn.Name = "PnameDataGridViewTextBoxColumn"
        '
        'PageDataGridViewTextBoxColumn
        '
        Me.PageDataGridViewTextBoxColumn.DataPropertyName = "Page"
        Me.PageDataGridViewTextBoxColumn.HeaderText = "Page"
        Me.PageDataGridViewTextBoxColumn.Name = "PageDataGridViewTextBoxColumn"
        '
        'DTDataGridViewTextBoxColumn
        '
        Me.DTDataGridViewTextBoxColumn.DataPropertyName = "DT"
        Me.DTDataGridViewTextBoxColumn.HeaderText = "DT"
        Me.DTDataGridViewTextBoxColumn.Name = "DTDataGridViewTextBoxColumn"
        '
        'ComplaintDataGridViewTextBoxColumn
        '
        Me.ComplaintDataGridViewTextBoxColumn.DataPropertyName = "Complaint"
        Me.ComplaintDataGridViewTextBoxColumn.HeaderText = "Complaint"
        Me.ComplaintDataGridViewTextBoxColumn.Name = "ComplaintDataGridViewTextBoxColumn"
        '
        'MoboDataGridViewTextBoxColumn
        '
        Me.MoboDataGridViewTextBoxColumn.DataPropertyName = "Mobo"
        Me.MoboDataGridViewTextBoxColumn.HeaderText = "Mobo"
        Me.MoboDataGridViewTextBoxColumn.Name = "MoboDataGridViewTextBoxColumn"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1414, 1125)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MainfieldsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRdatabaseDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainfieldsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRdatabaseDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRdatabaseDataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRdatabaseDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MRdatabaseDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainfieldsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MRdatabaseDataSet4 As WindowsApplication1.MRdatabaseDataSet4
    Friend WithEvents MainfieldsTableAdapter As WindowsApplication1.MRdatabaseDataSet4TableAdapters.mainfieldsTableAdapter
    Friend WithEvents MRdatabaseDataSet4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MRdatabaseDataSet5 As WindowsApplication1.MRdatabaseDataSet5
    Friend WithEvents MainfieldsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainfieldsTableAdapter1 As WindowsApplication1.MRdatabaseDataSet5TableAdapters.mainfieldsTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MRdatabaseDataSet6 As WindowsApplication1.MRdatabaseDataSet6
    Friend WithEvents MainfieldsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MainfieldsTableAdapter2 As WindowsApplication1.MRdatabaseDataSet6TableAdapters.mainfieldsTableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MRdatabaseDataSet8 As WindowsApplication1.MRdatabaseDataSet8
    Friend WithEvents MainfieldsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents MainfieldsTableAdapter3 As WindowsApplication1.MRdatabaseDataSet8TableAdapters.mainfieldsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComplaintDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoboDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
