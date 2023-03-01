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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        SaveResultsJSONToolStripMenuItem = New ToolStripMenuItem()
        JSONToolStripMenuItem = New ToolStripMenuItem()
        CSVToolStripMenuItem = New ToolStripMenuItem()
        FileMenuStrip = New MenuStrip()
        ToolsToolStripMenuTools = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        DeveloperToolStripMenuItem = New ToolStripMenuItem()
        ChekUpdatesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        LimitNumericUpDown = New NumericUpDown()
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
        TimeframeComboBox.Text = "All"' 
        ' ListingComboBox
        ' 
        ListingComboBox.FormattingEnabled = True
        ListingComboBox.Items.AddRange(New Object() {"Controversial", "Hot", "Best", "New", "Rising"})
        ListingComboBox.Location = New Point(89, 157)
        ListingComboBox.Name = "ListingComboBox"
        ListingComboBox.Size = New Size(100, 23)
        ListingComboBox.TabIndex = 9
        ListingComboBox.Text = "Top"' 
        ' Label1
        ' 
        Label1.AutoEllipsis = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 23)
        Label1.TabIndex = 10
        Label1.Text = "Keyword"' 
        ' Label2
        ' 
        Label2.AutoEllipsis = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 23)
        Label2.TabIndex = 11
        Label2.Text = "Subreddit"' 
        ' Label3
        ' 
        Label3.AutoEllipsis = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 23)
        Label3.TabIndex = 12
        Label3.Text = "Limit"' 
        ' Label4
        ' 
        Label4.AutoEllipsis = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(12, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 23)
        Label4.TabIndex = 13
        Label4.Text = "Listing"' 
        ' Label5
        ' 
        Label5.AutoEllipsis = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(12, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 23)
        Label5.TabIndex = 14
        Label5.Text = "Timeframe"' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {SaveResultsJSONToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(144, 26)
        ' 
        ' SaveResultsJSONToolStripMenuItem
        ' 
        SaveResultsJSONToolStripMenuItem.AutoToolTip = True
        SaveResultsJSONToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {JSONToolStripMenuItem, CSVToolStripMenuItem})
        SaveResultsJSONToolStripMenuItem.Image = CType(resources.GetObject("SaveResultsJSONToolStripMenuItem.Image"), Image)
        SaveResultsJSONToolStripMenuItem.Name = "SaveResultsJSONToolStripMenuItem"
        SaveResultsJSONToolStripMenuItem.Size = New Size(143, 22)
        SaveResultsJSONToolStripMenuItem.Text = "Save posts to"
        SaveResultsJSONToolStripMenuItem.ToolTipText = "Save results to a JSON file"' 
        ' JSONToolStripMenuItem
        ' 
        JSONToolStripMenuItem.AutoToolTip = True
        JSONToolStripMenuItem.CheckOnClick = True
        JSONToolStripMenuItem.Image = CType(resources.GetObject("JSONToolStripMenuItem.Image"), Image)
        JSONToolStripMenuItem.Name = "JSONToolStripMenuItem"
        JSONToolStripMenuItem.Size = New Size(185, 22)
        JSONToolStripMenuItem.Text = "JSON"' 
        ' CSVToolStripMenuItem
        ' 
        CSVToolStripMenuItem.AutoToolTip = True
        CSVToolStripMenuItem.Enabled = False
        CSVToolStripMenuItem.Image = CType(resources.GetObject("CSVToolStripMenuItem.Image"), Image)
        CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        CSVToolStripMenuItem.Size = New Size(185, 22)
        CSVToolStripMenuItem.Text = "CSV (coming soon...)"' 
        ' FileMenuStrip
        ' 
        FileMenuStrip.BackColor = Color.Transparent
        FileMenuStrip.Items.AddRange(New ToolStripItem() {ToolsToolStripMenuTools})
        FileMenuStrip.Location = New Point(0, 0)
        FileMenuStrip.Name = "FileMenuStrip"
        FileMenuStrip.Size = New Size(355, 24)
        FileMenuStrip.TabIndex = 0
        FileMenuStrip.Text = "MenuStrip1"' 
        ' ToolsToolStripMenuTools
        ' 
        ToolsToolStripMenuTools.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem, DeveloperToolStripMenuItem, ChekUpdatesToolStripMenuItem, ToolStripSeparator2, QuitToolStripMenuItem})
        ToolsToolStripMenuTools.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ToolsToolStripMenuTools.ForeColor = Color.White
        ToolsToolStripMenuTools.Image = CType(resources.GetObject("ToolsToolStripMenuTools.Image"), Image)
        ToolsToolStripMenuTools.Name = "ToolsToolStripMenuTools"
        ToolsToolStripMenuTools.Size = New Size(53, 20)
        ToolsToolStripMenuTools.Text = "File"' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.AutoToolTip = True
        AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), Image)
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(152, 22)
        AboutToolStripMenuItem.Text = "About"' 
        ' DeveloperToolStripMenuItem
        ' 
        DeveloperToolStripMenuItem.AutoToolTip = True
        DeveloperToolStripMenuItem.Image = CType(resources.GetObject("DeveloperToolStripMenuItem.Image"), Image)
        DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        DeveloperToolStripMenuItem.Size = New Size(152, 22)
        DeveloperToolStripMenuItem.Text = "Developer"' 
        ' ChekUpdatesToolStripMenuItem
        ' 
        ChekUpdatesToolStripMenuItem.AutoToolTip = True
        ChekUpdatesToolStripMenuItem.Image = CType(resources.GetObject("ChekUpdatesToolStripMenuItem.Image"), Image)
        ChekUpdatesToolStripMenuItem.Name = "ChekUpdatesToolStripMenuItem"
        ChekUpdatesToolStripMenuItem.Size = New Size(152, 22)
        ChekUpdatesToolStripMenuItem.Text = "Check updates"' 
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
        QuitToolStripMenuItem.Text = "Quit"' 
        ' LimitNumericUpDown
        ' 
        LimitNumericUpDown.Location = New Point(89, 125)
        LimitNumericUpDown.Minimum = New [Decimal](New Integer() {5, 0, 0, 0})
        LimitNumericUpDown.Name = "LimitNumericUpDown"
        LimitNumericUpDown.ReadOnly = True
        LimitNumericUpDown.Size = New Size(100, 23)
        LimitNumericUpDown.TabIndex = 15
        LimitNumericUpDown.Value = New [Decimal](New Integer() {5, 0, 0, 0})
        ' 
        ' StartForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(355, 255)
        ContextMenuStrip = ContextMenuStrip1
        Controls.Add(LimitNumericUpDown)
        Controls.Add(FileMenuStrip)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
        Text = "Reddit Post Scraping Tool"
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
    Friend WithEvents JSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimitNumericUpDown As NumericUpDown
End Class
