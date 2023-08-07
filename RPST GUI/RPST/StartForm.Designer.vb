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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(StartForm))
        KeywordTextBox = New TextBox()
        SubredditTextBox = New TextBox()
        ScrapeButton = New Button()
        TimeframeComboBox = New ComboBox()
        ListingComboBox = New ComboBox()
        LabelKeyword = New Label()
        LabelSubreddit = New Label()
        LabelLimit = New Label()
        LabelListing = New Label()
        LabelTimeframe = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        SaveResultsStripMenuItem = New ToolStripMenuItem()
        JSONToolStripMenuItem = New ToolStripMenuItem()
        CSVToolStripMenuItem = New ToolStripMenuItem()
        DarkModeToolStripMenuItem = New ToolStripMenuItem()
        FileMenuStrip = New MenuStrip()
        ToolsToolStripMenuTools = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        DeveloperToolStripMenuItem = New ToolStripMenuItem()
        CheckUpdatesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        LimitNumericUpDown = New NumericUpDown()
        ToolTip1 = New ToolTip(components)
        ContextMenuStrip1.SuspendLayout()
        FileMenuStrip.SuspendLayout()
        CType(LimitNumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' KeywordTextBox
        ' 
        KeywordTextBox.BackColor = SystemColors.Window
        KeywordTextBox.ForeColor = SystemColors.WindowText
        KeywordTextBox.Location = New Point(89, 60)
        KeywordTextBox.Name = "KeywordTextBox"
        KeywordTextBox.PlaceholderText = "Keyword"
        KeywordTextBox.Size = New Size(100, 23)
        KeywordTextBox.TabIndex = 0
        ' 
        ' SubredditTextBox
        ' 
        SubredditTextBox.Location = New Point(89, 92)
        SubredditTextBox.Name = "SubredditTextBox"
        SubredditTextBox.PlaceholderText = "Subreddit"
        SubredditTextBox.Size = New Size(100, 23)
        SubredditTextBox.TabIndex = 4
        ' 
        ' ScrapeButton
        ' 
        ScrapeButton.Location = New Point(257, 191)
        ScrapeButton.Name = "ScrapeButton"
        ScrapeButton.Size = New Size(76, 28)
        ScrapeButton.TabIndex = 6
        ScrapeButton.Text = "Scrape"
        ScrapeButton.UseVisualStyleBackColor = True
        ' 
        ' TimeframeComboBox
        ' 
        TimeframeComboBox.FormattingEnabled = True
        TimeframeComboBox.Items.AddRange(New Object() {"Hour", "Day", "Week", "Month", "Year"})
        TimeframeComboBox.Location = New Point(89, 191)
        TimeframeComboBox.Name = "TimeframeComboBox"
        TimeframeComboBox.Size = New Size(100, 23)
        TimeframeComboBox.TabIndex = 8
        TimeframeComboBox.Text = "All"
        ' 
        ' ListingComboBox
        ' 
        ListingComboBox.FormattingEnabled = True
        ListingComboBox.Items.AddRange(New Object() {"Controversial", "Hot", "Best", "New", "Rising"})
        ListingComboBox.Location = New Point(89, 157)
        ListingComboBox.Name = "ListingComboBox"
        ListingComboBox.Size = New Size(100, 23)
        ListingComboBox.TabIndex = 9
        ListingComboBox.Text = "Top"
        ' 
        ' LabelKeyword
        ' 
        LabelKeyword.AutoEllipsis = True
        LabelKeyword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Underline, GraphicsUnit.Point)
        LabelKeyword.ForeColor = Color.Black
        LabelKeyword.Location = New Point(12, 60)
        LabelKeyword.Name = "LabelKeyword"
        LabelKeyword.Size = New Size(56, 23)
        LabelKeyword.TabIndex = 10
        LabelKeyword.Text = "Keyword"
        ' 
        ' LabelSubreddit
        ' 
        LabelSubreddit.AutoEllipsis = True
        LabelSubreddit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Underline, GraphicsUnit.Point)
        LabelSubreddit.ForeColor = Color.Black
        LabelSubreddit.Location = New Point(12, 92)
        LabelSubreddit.Name = "LabelSubreddit"
        LabelSubreddit.Size = New Size(63, 23)
        LabelSubreddit.TabIndex = 11
        LabelSubreddit.Text = "Subreddit"
        ' 
        ' LabelLimit
        ' 
        LabelLimit.AutoEllipsis = True
        LabelLimit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelLimit.ForeColor = Color.Black
        LabelLimit.Location = New Point(12, 125)
        LabelLimit.Name = "LabelLimit"
        LabelLimit.Size = New Size(56, 23)
        LabelLimit.TabIndex = 12
        LabelLimit.Text = "Limit"
        ' 
        ' LabelListing
        ' 
        LabelListing.AutoEllipsis = True
        LabelListing.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelListing.ForeColor = Color.Black
        LabelListing.Location = New Point(12, 157)
        LabelListing.Name = "LabelListing"
        LabelListing.Size = New Size(56, 23)
        LabelListing.TabIndex = 13
        LabelListing.Text = "Listing"
        ' 
        ' LabelTimeframe
        ' 
        LabelTimeframe.AutoEllipsis = True
        LabelTimeframe.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelTimeframe.ForeColor = Color.Black
        LabelTimeframe.Location = New Point(12, 191)
        LabelTimeframe.Name = "LabelTimeframe"
        LabelTimeframe.Size = New Size(71, 23)
        LabelTimeframe.TabIndex = 14
        LabelTimeframe.Text = "Timeframe"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {SaveResultsStripMenuItem, DarkModeToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(144, 48)
        ' 
        ' SaveResultsStripMenuItem
        ' 
        SaveResultsStripMenuItem.AutoToolTip = True
        SaveResultsStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {JSONToolStripMenuItem, CSVToolStripMenuItem})
        SaveResultsStripMenuItem.Image = CType(resources.GetObject("SaveResultsStripMenuItem.Image"), Image)
        SaveResultsStripMenuItem.Name = "SaveResultsStripMenuItem"
        SaveResultsStripMenuItem.Size = New Size(143, 22)
        SaveResultsStripMenuItem.Text = "Save posts to"
        ' 
        ' JSONToolStripMenuItem
        ' 
        JSONToolStripMenuItem.AutoToolTip = True
        JSONToolStripMenuItem.CheckOnClick = True
        JSONToolStripMenuItem.Image = CType(resources.GetObject("JSONToolStripMenuItem.Image"), Image)
        JSONToolStripMenuItem.Name = "JSONToolStripMenuItem"
        JSONToolStripMenuItem.Size = New Size(185, 22)
        JSONToolStripMenuItem.Text = "JSON"
        ' 
        ' CSVToolStripMenuItem
        ' 
        CSVToolStripMenuItem.AutoToolTip = True
        CSVToolStripMenuItem.Enabled = False
        CSVToolStripMenuItem.Image = CType(resources.GetObject("CSVToolStripMenuItem.Image"), Image)
        CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        CSVToolStripMenuItem.Size = New Size(185, 22)
        CSVToolStripMenuItem.Text = "CSV (coming soon...)"
        ' 
        ' DarkModeToolStripMenuItem
        ' 
        DarkModeToolStripMenuItem.AutoToolTip = True
        DarkModeToolStripMenuItem.CheckOnClick = True
        DarkModeToolStripMenuItem.Image = CType(resources.GetObject("DarkModeToolStripMenuItem.Image"), Image)
        DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        DarkModeToolStripMenuItem.Size = New Size(143, 22)
        DarkModeToolStripMenuItem.Text = "Dark mode"
        ' 
        ' FileMenuStrip
        ' 
        FileMenuStrip.BackColor = Color.Transparent
        FileMenuStrip.Items.AddRange(New ToolStripItem() {ToolsToolStripMenuTools})
        FileMenuStrip.Location = New Point(0, 0)
        FileMenuStrip.Name = "FileMenuStrip"
        FileMenuStrip.Size = New Size(355, 24)
        FileMenuStrip.TabIndex = 0
        FileMenuStrip.Text = "MenuStrip1"
        ' 
        ' ToolsToolStripMenuTools
        ' 
        ToolsToolStripMenuTools.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem, DeveloperToolStripMenuItem, CheckUpdatesToolStripMenuItem, ToolStripSeparator2, QuitToolStripMenuItem})
        ToolsToolStripMenuTools.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ToolsToolStripMenuTools.ForeColor = Color.White
        ToolsToolStripMenuTools.Image = CType(resources.GetObject("ToolsToolStripMenuTools.Image"), Image)
        ToolsToolStripMenuTools.Name = "ToolsToolStripMenuTools"
        ToolsToolStripMenuTools.Size = New Size(28, 20)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.AutoToolTip = True
        AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), Image)
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(152, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' DeveloperToolStripMenuItem
        ' 
        DeveloperToolStripMenuItem.AutoToolTip = True
        DeveloperToolStripMenuItem.Image = CType(resources.GetObject("DeveloperToolStripMenuItem.Image"), Image)
        DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        DeveloperToolStripMenuItem.Size = New Size(152, 22)
        DeveloperToolStripMenuItem.Text = "Developer"
        ' 
        ' CheckUpdatesToolStripMenuItem
        ' 
        CheckUpdatesToolStripMenuItem.AutoToolTip = True
        CheckUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckUpdatesToolStripMenuItem.Image"), Image)
        CheckUpdatesToolStripMenuItem.Name = "CheckUpdatesToolStripMenuItem"
        CheckUpdatesToolStripMenuItem.Size = New Size(152, 22)
        CheckUpdatesToolStripMenuItem.Text = "Check updates"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(149, 6)
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.AutoToolTip = True
        QuitToolStripMenuItem.Image = CType(resources.GetObject("QuitToolStripMenuItem.Image"), Image)
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(152, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' LimitNumericUpDown
        ' 
        LimitNumericUpDown.Location = New Point(89, 125)
        LimitNumericUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        LimitNumericUpDown.Name = "LimitNumericUpDown"
        LimitNumericUpDown.ReadOnly = True
        LimitNumericUpDown.Size = New Size(100, 23)
        LimitNumericUpDown.TabIndex = 15
        LimitNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' StartForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(355, 255)
        ContextMenuStrip = ContextMenuStrip1
        Controls.Add(LimitNumericUpDown)
        Controls.Add(FileMenuStrip)
        Controls.Add(LabelTimeframe)
        Controls.Add(LabelListing)
        Controls.Add(LabelLimit)
        Controls.Add(LabelSubreddit)
        Controls.Add(LabelKeyword)
        Controls.Add(ListingComboBox)
        Controls.Add(TimeframeComboBox)
        Controls.Add(SubredditTextBox)
        Controls.Add(ScrapeButton)
        Controls.Add(KeywordTextBox)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = FileMenuStrip
        MaximizeBox = False
        Name = "StartForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProgramName ProgramVersion"
        ContextMenuStrip1.ResumeLayout(False)
        FileMenuStrip.ResumeLayout(False)
        FileMenuStrip.PerformLayout()
        CType(LimitNumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KeywordTextBox As TextBox
    Friend WithEvents SubredditTextBox As TextBox
    Friend WithEvents ScrapeButton As Button
    Friend WithEvents TimeframeComboBox As ComboBox
    Friend WithEvents ListingComboBox As ComboBox
    Friend WithEvents LabelKeyword As Label
    Friend WithEvents LabelSubreddit As Label
    Friend WithEvents LabelLimit As Label
    Friend WithEvents LabelListing As Label
    Friend WithEvents LabelTimeframe As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileMenuStrip As MenuStrip
    Friend WithEvents ToolsToolStripMenuTools As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveResultsStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimitNumericUpDown As NumericUpDown
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
