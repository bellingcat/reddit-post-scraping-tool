<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormMain))
        TextBoxKeyword = New TextBox()
        TextBoxSubreddit = New TextBox()
        ButtonScrape = New Button()
        ComboBoxTimeframe = New ComboBox()
        ComboBoxListing = New ComboBox()
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
        NumericUpDownLimit = New NumericUpDown()
        ToolTip = New ToolTip(components)
        ContextMenuStripRightClick.SuspendLayout()
        CType(NumericUpDownLimit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxKeyword
        ' 
        TextBoxKeyword.BackColor = SystemColors.Window
        TextBoxKeyword.ForeColor = SystemColors.WindowText
        TextBoxKeyword.Location = New Point(118, 20)
        TextBoxKeyword.Name = "TextBoxKeyword"
        TextBoxKeyword.PlaceholderText = "Keyword"
        TextBoxKeyword.Size = New Size(100, 23)
        TextBoxKeyword.TabIndex = 0
        ToolTip.SetToolTip(TextBoxKeyword, "Enter the keyword you want to search for.")
        ' 
        ' TextBoxSubreddit
        ' 
        TextBoxSubreddit.Location = New Point(118, 49)
        TextBoxSubreddit.Name = "TextBoxSubreddit"
        TextBoxSubreddit.PlaceholderText = "Subreddit"
        TextBoxSubreddit.Size = New Size(100, 23)
        TextBoxSubreddit.TabIndex = 4
        ToolTip.SetToolTip(TextBoxSubreddit, "Provide the subreddit to search in.")
        ' 
        ' ButtonScrape
        ' 
        ButtonScrape.Location = New Point(167, 174)
        ButtonScrape.Name = "ButtonScrape"
        ButtonScrape.Size = New Size(51, 28)
        ButtonScrape.TabIndex = 6
        ButtonScrape.Text = "Scrape"
        ToolTip.SetToolTip(ButtonScrape, "You can also just hit ENTER to start scraping.")
        ButtonScrape.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxTimeframe
        ' 
        ComboBoxTimeframe.AutoCompleteCustomSource.AddRange(New String() {"Hour", "Day", "Week", "Month", "Year"})
        ComboBoxTimeframe.AutoCompleteMode = AutoCompleteMode.Append
        ComboBoxTimeframe.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxTimeframe.FormattingEnabled = True
        ComboBoxTimeframe.Items.AddRange(New Object() {"Hour", "Day", "Week", "Month", "Year"})
        ComboBoxTimeframe.Location = New Point(118, 136)
        ComboBoxTimeframe.Name = "ComboBoxTimeframe"
        ComboBoxTimeframe.Size = New Size(100, 23)
        ComboBoxTimeframe.TabIndex = 8
        ComboBoxTimeframe.Text = "All"
        ToolTip.SetToolTip(ComboBoxTimeframe, "Select the time period for the posts. Default value is `All`.")
        ' 
        ' ComboBoxListing
        ' 
        ComboBoxListing.AutoCompleteCustomSource.AddRange(New String() {"Controversial", "Hot", "Best", "New", "Rising"})
        ComboBoxListing.AutoCompleteMode = AutoCompleteMode.Append
        ComboBoxListing.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxListing.FormattingEnabled = True
        ComboBoxListing.Items.AddRange(New Object() {"Controversial", "Hot", "Best", "New", "Rising"})
        ComboBoxListing.Location = New Point(118, 107)
        ComboBoxListing.Name = "ComboBoxListing"
        ComboBoxListing.Size = New Size(100, 23)
        ComboBoxListing.TabIndex = 9
        ComboBoxListing.Text = "Top"
        ToolTip.SetToolTip(ComboBoxListing, "Choose the type of post listings. Default value is `Top`.")
        ' 
        ' LabelKeyword
        ' 
        LabelKeyword.AutoEllipsis = True
        LabelKeyword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelKeyword.ForeColor = Color.Black
        LabelKeyword.Location = New Point(19, 23)
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
        LabelSubreddit.Location = New Point(19, 52)
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
        LabelLimit.Location = New Point(19, 75)
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
        LabelListing.Location = New Point(19, 107)
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
        LabelTimeframe.Location = New Point(19, 136)
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
        ' NumericUpDownLimit
        ' 
        NumericUpDownLimit.Location = New Point(118, 78)
        NumericUpDownLimit.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        NumericUpDownLimit.Name = "NumericUpDownLimit"
        NumericUpDownLimit.ReadOnly = True
        NumericUpDownLimit.Size = New Size(100, 23)
        NumericUpDownLimit.TabIndex = 15
        ToolTip.SetToolTip(NumericUpDownLimit, "Set how many posts you want to go through. Default value is `10`.")
        NumericUpDownLimit.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' ToolTip
        ' 
        ToolTip.AutoPopDelay = 5000
        ToolTip.BackColor = Color.Gainsboro
        ToolTip.InitialDelay = 500
        ToolTip.ReshowDelay = 100
        ToolTip.ToolTipIcon = ToolTipIcon.Info
        ToolTip.ToolTipTitle = "Tip"
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(239, 221)
        ContextMenuStrip = ContextMenuStripRightClick
        Controls.Add(ComboBoxTimeframe)
        Controls.Add(TextBoxKeyword)
        Controls.Add(LabelTimeframe)
        Controls.Add(LabelKeyword)
        Controls.Add(ComboBoxListing)
        Controls.Add(NumericUpDownLimit)
        Controls.Add(LabelListing)
        Controls.Add(ButtonScrape)
        Controls.Add(LabelLimit)
        Controls.Add(LabelSubreddit)
        Controls.Add(TextBoxSubreddit)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FormMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RPST"
        ContextMenuStripRightClick.ResumeLayout(False)
        CType(NumericUpDownLimit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxKeyword As TextBox
    Friend WithEvents TextBoxSubreddit As TextBox
    Friend WithEvents ButtonScrape As Button
    Friend WithEvents ComboBoxTimeframe As ComboBox
    Friend WithEvents ComboBoxListing As ComboBox
    Friend WithEvents LabelKeyword As Label
    Friend WithEvents LabelSubreddit As Label
    Friend WithEvents LabelLimit As Label
    Friend WithEvents LabelListing As Label
    Friend WithEvents LabelTimeframe As Label
    Friend WithEvents ContextMenuStripRightClick As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemSavePosts As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemtoJSON As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemtoCSV As ToolStripMenuItem
    Friend WithEvents NumericUpDownLimit As NumericUpDown
    Friend WithEvents ToolStripMenuItemDarkMode As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAbout As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDeveloper As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemCheckUpdates As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemQuit As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
End Class
