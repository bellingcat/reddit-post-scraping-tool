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
        ButtonScrape = New Button()
        TimeframeComboBox = New ComboBox()
        ListingComboBox = New ComboBox()
        LabelKeyword = New Label()
        LabelSubreddit = New Label()
        LabelLimit = New Label()
        LabelListing = New Label()
        LabelTimeframe = New Label()
        ContextMenuStripRightClick = New ContextMenuStrip(components)
        ToolStripMenuItemDarkMode = New ToolStripMenuItem()
        ToolStripMenuItemSavePosts = New ToolStripMenuItem()
        ToolStripMenuItemtoJSON = New ToolStripMenuItem()
        ToolStripMenuItemtoCSV = New ToolStripMenuItem()
        ToolStripMenuItemAbout = New ToolStripMenuItem()
        ToolStripMenuItemDeveloper = New ToolStripMenuItem()
        ToolStripMenuItemCheckUpdates = New ToolStripMenuItem()
        ToolStripMenuItemQuit = New ToolStripMenuItem()
        LimitNumericUpDown = New NumericUpDown()
        PictureBoxLogo = New PictureBox()
        LabelRPST = New Label()
        ContextMenuStripRightClick.SuspendLayout()
        CType(LimitNumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' KeywordTextBox
        ' 
        KeywordTextBox.BackColor = SystemColors.Window
        KeywordTextBox.ForeColor = SystemColors.WindowText
        KeywordTextBox.Location = New Point(159, 75)
        KeywordTextBox.Name = "KeywordTextBox"
        KeywordTextBox.PlaceholderText = "Keyword"
        KeywordTextBox.Size = New Size(100, 23)
        KeywordTextBox.TabIndex = 0
        ' 
        ' SubredditTextBox
        ' 
        SubredditTextBox.Location = New Point(159, 106)
        SubredditTextBox.Name = "SubredditTextBox"
        SubredditTextBox.PlaceholderText = "Subreddit"
        SubredditTextBox.Size = New Size(100, 23)
        SubredditTextBox.TabIndex = 4
        ' 
        ' ButtonScrape
        ' 
        ButtonScrape.Location = New Point(208, 29)
        ButtonScrape.Name = "ButtonScrape"
        ButtonScrape.Size = New Size(51, 28)
        ButtonScrape.TabIndex = 6
        ButtonScrape.Text = "Scrape"
        ButtonScrape.UseVisualStyleBackColor = True
        ' 
        ' TimeframeComboBox
        ' 
        TimeframeComboBox.FormattingEnabled = True
        TimeframeComboBox.Items.AddRange(New Object() {"Hour", "Day", "Week", "Month", "Year"})
        TimeframeComboBox.Location = New Point(159, 200)
        TimeframeComboBox.Name = "TimeframeComboBox"
        TimeframeComboBox.Size = New Size(100, 23)
        TimeframeComboBox.TabIndex = 8
        TimeframeComboBox.Text = "All"
        ' 
        ' ListingComboBox
        ' 
        ListingComboBox.FormattingEnabled = True
        ListingComboBox.Items.AddRange(New Object() {"Controversial", "Hot", "Best", "New", "Rising"})
        ListingComboBox.Location = New Point(159, 168)
        ListingComboBox.Name = "ListingComboBox"
        ListingComboBox.Size = New Size(100, 23)
        ListingComboBox.TabIndex = 9
        ListingComboBox.Text = "Top"
        ' 
        ' LabelKeyword
        ' 
        LabelKeyword.AutoEllipsis = True
        LabelKeyword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelKeyword.ForeColor = Color.Black
        LabelKeyword.Location = New Point(19, 78)
        LabelKeyword.Name = "LabelKeyword"
        LabelKeyword.Size = New Size(71, 20)
        LabelKeyword.TabIndex = 10
        LabelKeyword.Text = "Keyword:"
        ' 
        ' LabelSubreddit
        ' 
        LabelSubreddit.AutoEllipsis = True
        LabelSubreddit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelSubreddit.ForeColor = Color.Black
        LabelSubreddit.Location = New Point(19, 109)
        LabelSubreddit.Name = "LabelSubreddit"
        LabelSubreddit.Size = New Size(71, 23)
        LabelSubreddit.TabIndex = 11
        LabelSubreddit.Text = "Subreddit:"
        ' 
        ' LabelLimit
        ' 
        LabelLimit.AutoEllipsis = True
        LabelLimit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelLimit.ForeColor = Color.Black
        LabelLimit.Location = New Point(19, 137)
        LabelLimit.Name = "LabelLimit"
        LabelLimit.Size = New Size(56, 23)
        LabelLimit.TabIndex = 12
        LabelLimit.Text = "Limit:"
        ' 
        ' LabelListing
        ' 
        LabelListing.AutoEllipsis = True
        LabelListing.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelListing.ForeColor = Color.Black
        LabelListing.Location = New Point(19, 168)
        LabelListing.Name = "LabelListing"
        LabelListing.Size = New Size(56, 23)
        LabelListing.TabIndex = 13
        LabelListing.Text = "Listing:"
        ' 
        ' LabelTimeframe
        ' 
        LabelTimeframe.AutoEllipsis = True
        LabelTimeframe.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelTimeframe.ForeColor = Color.Black
        LabelTimeframe.Location = New Point(19, 200)
        LabelTimeframe.Name = "LabelTimeframe"
        LabelTimeframe.Size = New Size(81, 23)
        LabelTimeframe.TabIndex = 14
        LabelTimeframe.Text = "Timeframe:"
        ' 
        ' ContextMenuStripRightClick
        ' 
        ContextMenuStripRightClick.Items.AddRange(New ToolStripItem() {ToolStripMenuItemDarkMode, ToolStripMenuItemSavePosts, ToolStripMenuItemAbout, ToolStripMenuItemDeveloper, ToolStripMenuItemCheckUpdates, ToolStripMenuItemQuit})
        ContextMenuStripRightClick.Name = "ContextMenuStrip1"
        ContextMenuStripRightClick.Size = New Size(154, 136)
        ' 
        ' ToolStripMenuItemDarkMode
        ' 
        ToolStripMenuItemDarkMode.AutoToolTip = True
        ToolStripMenuItemDarkMode.CheckOnClick = True
        ToolStripMenuItemDarkMode.Image = CType(resources.GetObject("ToolStripMenuItemDarkMode.Image"), Image)
        ToolStripMenuItemDarkMode.Name = "ToolStripMenuItemDarkMode"
        ToolStripMenuItemDarkMode.Size = New Size(153, 22)
        ToolStripMenuItemDarkMode.Text = "Dark Mode"
        ' 
        ' ToolStripMenuItemSavePosts
        ' 
        ToolStripMenuItemSavePosts.AutoToolTip = True
        ToolStripMenuItemSavePosts.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItemtoJSON, ToolStripMenuItemtoCSV})
        ToolStripMenuItemSavePosts.Image = CType(resources.GetObject("ToolStripMenuItemSavePosts.Image"), Image)
        ToolStripMenuItemSavePosts.Name = "ToolStripMenuItemSavePosts"
        ToolStripMenuItemSavePosts.Size = New Size(153, 22)
        ToolStripMenuItemSavePosts.Text = "Save Posts"
        ToolStripMenuItemSavePosts.ToolTipText = "Save found posts to..."
        ' 
        ' ToolStripMenuItemtoJSON
        ' 
        ToolStripMenuItemtoJSON.AutoToolTip = True
        ToolStripMenuItemtoJSON.CheckOnClick = True
        ToolStripMenuItemtoJSON.Image = CType(resources.GetObject("ToolStripMenuItemtoJSON.Image"), Image)
        ToolStripMenuItemtoJSON.Name = "ToolStripMenuItemtoJSON"
        ToolStripMenuItemtoJSON.Size = New Size(116, 22)
        ToolStripMenuItemtoJSON.Text = "to JSON"
        ' 
        ' ToolStripMenuItemtoCSV
        ' 
        ToolStripMenuItemtoCSV.AutoToolTip = True
        ToolStripMenuItemtoCSV.Enabled = False
        ToolStripMenuItemtoCSV.Image = CType(resources.GetObject("ToolStripMenuItemtoCSV.Image"), Image)
        ToolStripMenuItemtoCSV.Name = "ToolStripMenuItemtoCSV"
        ToolStripMenuItemtoCSV.Size = New Size(116, 22)
        ToolStripMenuItemtoCSV.Text = "to CSV"
        ' 
        ' ToolStripMenuItemAbout
        ' 
        ToolStripMenuItemAbout.AutoToolTip = True
        ToolStripMenuItemAbout.Image = CType(resources.GetObject("ToolStripMenuItemAbout.Image"), Image)
        ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout"
        ToolStripMenuItemAbout.Size = New Size(153, 22)
        ToolStripMenuItemAbout.Text = "About"
        ' 
        ' ToolStripMenuItemDeveloper
        ' 
        ToolStripMenuItemDeveloper.AutoToolTip = True
        ToolStripMenuItemDeveloper.Image = CType(resources.GetObject("ToolStripMenuItemDeveloper.Image"), Image)
        ToolStripMenuItemDeveloper.Name = "ToolStripMenuItemDeveloper"
        ToolStripMenuItemDeveloper.Size = New Size(153, 22)
        ToolStripMenuItemDeveloper.Text = "Developer"
        ' 
        ' ToolStripMenuItemCheckUpdates
        ' 
        ToolStripMenuItemCheckUpdates.AutoToolTip = True
        ToolStripMenuItemCheckUpdates.Image = CType(resources.GetObject("ToolStripMenuItemCheckUpdates.Image"), Image)
        ToolStripMenuItemCheckUpdates.Name = "ToolStripMenuItemCheckUpdates"
        ToolStripMenuItemCheckUpdates.Size = New Size(153, 22)
        ToolStripMenuItemCheckUpdates.Text = "Check Updates"
        ' 
        ' ToolStripMenuItemQuit
        ' 
        ToolStripMenuItemQuit.AutoToolTip = True
        ToolStripMenuItemQuit.Image = CType(resources.GetObject("ToolStripMenuItemQuit.Image"), Image)
        ToolStripMenuItemQuit.Name = "ToolStripMenuItemQuit"
        ToolStripMenuItemQuit.Size = New Size(153, 22)
        ToolStripMenuItemQuit.Text = "Quit"
        ' 
        ' LimitNumericUpDown
        ' 
        LimitNumericUpDown.Location = New Point(159, 137)
        LimitNumericUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        LimitNumericUpDown.Name = "LimitNumericUpDown"
        LimitNumericUpDown.ReadOnly = True
        LimitNumericUpDown.Size = New Size(100, 23)
        LimitNumericUpDown.TabIndex = 15
        LimitNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.Location = New Point(19, 12)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(41, 45)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogo.TabIndex = 17
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelRPST
        ' 
        LabelRPST.AutoSize = True
        LabelRPST.BackColor = Color.Transparent
        LabelRPST.Font = New Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LabelRPST.Location = New Point(50, 51)
        LabelRPST.Name = "LabelRPST"
        LabelRPST.Size = New Size(36, 15)
        LabelRPST.TabIndex = 18
        LabelRPST.Text = "RPST"
        ' 
        ' StartForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(281, 244)
        ContextMenuStrip = ContextMenuStripRightClick
        Controls.Add(LabelRPST)
        Controls.Add(PictureBoxLogo)
        Controls.Add(TimeframeComboBox)
        Controls.Add(KeywordTextBox)
        Controls.Add(LabelTimeframe)
        Controls.Add(LabelKeyword)
        Controls.Add(ListingComboBox)
        Controls.Add(LimitNumericUpDown)
        Controls.Add(LabelListing)
        Controls.Add(ButtonScrape)
        Controls.Add(LabelLimit)
        Controls.Add(LabelSubreddit)
        Controls.Add(SubredditTextBox)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "StartForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProgramName ProgramVersion"
        ContextMenuStripRightClick.ResumeLayout(False)
        CType(LimitNumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KeywordTextBox As TextBox
    Friend WithEvents SubredditTextBox As TextBox
    Friend WithEvents ButtonScrape As Button
    Friend WithEvents TimeframeComboBox As ComboBox
    Friend WithEvents ListingComboBox As ComboBox
    Friend WithEvents LabelKeyword As Label
    Friend WithEvents LabelSubreddit As Label
    Friend WithEvents LabelLimit As Label
    Friend WithEvents LabelListing As Label
    Friend WithEvents LabelTimeframe As Label
    Friend WithEvents ContextMenuStripRightClick As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemSavePosts As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemtoJSON As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemtoCSV As ToolStripMenuItem
    Friend WithEvents LimitNumericUpDown As NumericUpDown
    Friend WithEvents ToolStripMenuItemDarkMode As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAbout As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDeveloper As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemCheckUpdates As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemQuit As ToolStripMenuItem
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelRPST As Label
End Class
