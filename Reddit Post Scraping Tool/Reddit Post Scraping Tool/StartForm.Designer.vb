<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.KeywordTextBox = New System.Windows.Forms.TextBox()
        Me.SubredditTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimeframeComboBox = New System.Windows.Forms.ComboBox()
        Me.ListingComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveResultsJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicensceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChekUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimitNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.FileMenuStrip.SuspendLayout()
        CType(Me.LimitNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KeywordTextBox
        '
        Me.KeywordTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.KeywordTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.KeywordTextBox.Location = New System.Drawing.Point(89, 60)
        Me.KeywordTextBox.Name = "KeywordTextBox"
        Me.KeywordTextBox.PlaceholderText = "Keyword"
        Me.KeywordTextBox.Size = New System.Drawing.Size(100, 23)
        Me.KeywordTextBox.TabIndex = 0
        '
        'SubredditTextBox
        '
        Me.SubredditTextBox.Location = New System.Drawing.Point(89, 92)
        Me.SubredditTextBox.Name = "SubredditTextBox"
        Me.SubredditTextBox.PlaceholderText = "Subreddit"
        Me.SubredditTextBox.Size = New System.Drawing.Size(100, 23)
        Me.SubredditTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Scrape"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TimeframeComboBox
        '
        Me.TimeframeComboBox.FormattingEnabled = True
        Me.TimeframeComboBox.Items.AddRange(New Object() {"Hour", "Day", "Week", "Month", "Year"})
        Me.TimeframeComboBox.Location = New System.Drawing.Point(89, 191)
        Me.TimeframeComboBox.Name = "TimeframeComboBox"
        Me.TimeframeComboBox.Size = New System.Drawing.Size(100, 23)
        Me.TimeframeComboBox.TabIndex = 8
        Me.TimeframeComboBox.Text = "All"
        '
        'ListingComboBox
        '
        Me.ListingComboBox.FormattingEnabled = True
        Me.ListingComboBox.Items.AddRange(New Object() {"Controversial", "Hot", "Best", "New", "Rising"})
        Me.ListingComboBox.Location = New System.Drawing.Point(89, 157)
        Me.ListingComboBox.Name = "ListingComboBox"
        Me.ListingComboBox.Size = New System.Drawing.Size(100, 23)
        Me.ListingComboBox.TabIndex = 9
        Me.ListingComboBox.Text = "Top"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Keyword"
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Subreddit"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Limit"
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Listing"
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Timeframe"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveResultsJSONToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 26)
        '
        'SaveResultsJSONToolStripMenuItem
        '
        Me.SaveResultsJSONToolStripMenuItem.AutoToolTip = True
        Me.SaveResultsJSONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JSONToolStripMenuItem, Me.CSVToolStripMenuItem})
        Me.SaveResultsJSONToolStripMenuItem.Image = CType(resources.GetObject("SaveResultsJSONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveResultsJSONToolStripMenuItem.Name = "SaveResultsJSONToolStripMenuItem"
        Me.SaveResultsJSONToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveResultsJSONToolStripMenuItem.Text = "Save posts to"
        Me.SaveResultsJSONToolStripMenuItem.ToolTipText = "Save results to a JSON file"
        '
        'JSONToolStripMenuItem
        '
        Me.JSONToolStripMenuItem.AutoToolTip = True
        Me.JSONToolStripMenuItem.CheckOnClick = True
        Me.JSONToolStripMenuItem.Image = CType(resources.GetObject("JSONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JSONToolStripMenuItem.Name = "JSONToolStripMenuItem"
        Me.JSONToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.JSONToolStripMenuItem.Text = "JSON"
        '
        'CSVToolStripMenuItem
        '
        Me.CSVToolStripMenuItem.AutoToolTip = True
        Me.CSVToolStripMenuItem.Enabled = False
        Me.CSVToolStripMenuItem.Image = CType(resources.GetObject("CSVToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        Me.CSVToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CSVToolStripMenuItem.Text = "CSV (coming soon...)"
        '
        'FileMenuStrip
        '
        Me.FileMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuTools})
        Me.FileMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.FileMenuStrip.Name = "FileMenuStrip"
        Me.FileMenuStrip.Size = New System.Drawing.Size(355, 24)
        Me.FileMenuStrip.TabIndex = 0
        Me.FileMenuStrip.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuTools
        '
        Me.ToolsToolStripMenuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.LicensceToolStripMenuItem, Me.DeveloperToolStripMenuItem, Me.ChekUpdatesToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitToolStripMenuItem})
        Me.ToolsToolStripMenuTools.Image = CType(resources.GetObject("ToolsToolStripMenuTools.Image"), System.Drawing.Image)
        Me.ToolsToolStripMenuTools.Name = "ToolsToolStripMenuTools"
        Me.ToolsToolStripMenuTools.Size = New System.Drawing.Size(53, 20)
        Me.ToolsToolStripMenuTools.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.AutoToolTip = True
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LicensceToolStripMenuItem
        '
        Me.LicensceToolStripMenuItem.AutoToolTip = True
        Me.LicensceToolStripMenuItem.Image = CType(resources.GetObject("LicensceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LicensceToolStripMenuItem.Name = "LicensceToolStripMenuItem"
        Me.LicensceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LicensceToolStripMenuItem.Text = "License"
        '
        'DeveloperToolStripMenuItem
        '
        Me.DeveloperToolStripMenuItem.AutoToolTip = True
        Me.DeveloperToolStripMenuItem.Image = CType(resources.GetObject("DeveloperToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        Me.DeveloperToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeveloperToolStripMenuItem.Text = "Developer"
        '
        'ChekUpdatesToolStripMenuItem
        '
        Me.ChekUpdatesToolStripMenuItem.AutoToolTip = True
        Me.ChekUpdatesToolStripMenuItem.Image = CType(resources.GetObject("ChekUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChekUpdatesToolStripMenuItem.Name = "ChekUpdatesToolStripMenuItem"
        Me.ChekUpdatesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChekUpdatesToolStripMenuItem.Text = "Check updates"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.AutoToolTip = True
        Me.QuitToolStripMenuItem.Image = CType(resources.GetObject("QuitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'LimitNumericUpDown
        '
        Me.LimitNumericUpDown.Location = New System.Drawing.Point(89, 125)
        Me.LimitNumericUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.LimitNumericUpDown.Name = "LimitNumericUpDown"
        Me.LimitNumericUpDown.ReadOnly = True
        Me.LimitNumericUpDown.Size = New System.Drawing.Size(100, 23)
        Me.LimitNumericUpDown.TabIndex = 15
        Me.LimitNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(355, 255)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.LimitNumericUpDown)
        Me.Controls.Add(Me.FileMenuStrip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListingComboBox)
        Me.Controls.Add(Me.TimeframeComboBox)
        Me.Controls.Add(Me.SubredditTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KeywordTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.FileMenuStrip
        Me.MaximizeBox = False
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reddit Post Scraping Tool"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.FileMenuStrip.ResumeLayout(False)
        Me.FileMenuStrip.PerformLayout()
        CType(Me.LimitNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KeywordTextBox As TextBox
    Friend WithEvents SubredditTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TimeframeComboBox As ComboBox
    Friend WithEvents ListingComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileMenuStrip As MenuStrip
    Friend WithEvents ToolsToolStripMenuTools As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveResultsJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChekUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicensceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimitNumericUpDown As NumericUpDown
End Class
