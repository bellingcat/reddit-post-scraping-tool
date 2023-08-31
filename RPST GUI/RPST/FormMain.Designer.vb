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
        ButtonSearch = New Button()
        ComboBoxTimeframe = New ComboBox()
        ComboBoxListing = New ComboBox()
        LabelKeyword = New Label()
        LabelSubreddit = New Label()
        LabelLimit = New Label()
        LabelListing = New Label()
        LabelTimeframe = New Label()
        ContextMenuStripRightClick = New ContextMenuStrip(components)
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        DarkModeToolStripMenuItem = New ToolStripMenuItem()
        SavePostsToolStripMenuItem = New ToolStripMenuItem()
        ToJSONToolStripMenuItem = New ToolStripMenuItem()
        ToCSVToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        CheckForUpdatesToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
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
        TextBoxKeyword.PlaceholderText = "*Keyword"
        TextBoxKeyword.Size = New Size(100, 23)
        TextBoxKeyword.TabIndex = 0
        ToolTip.SetToolTip(TextBoxKeyword, "[required] The keyword to search for.")
        ' 
        ' TextBoxSubreddit
        ' 
        TextBoxSubreddit.Location = New Point(118, 49)
        TextBoxSubreddit.Name = "TextBoxSubreddit"
        TextBoxSubreddit.PlaceholderText = "*Subreddit"
        TextBoxSubreddit.Size = New Size(100, 23)
        TextBoxSubreddit.TabIndex = 4
        ToolTip.SetToolTip(TextBoxSubreddit, "[required] The subreddit to search in.")
        ' 
        ' ButtonSearch
        ' 
        ButtonSearch.Location = New Point(165, 165)
        ButtonSearch.Name = "ButtonSearch"
        ButtonSearch.Size = New Size(55, 28)
        ButtonSearch.TabIndex = 6
        ButtonSearch.Text = "Search"
        ToolTip.SetToolTip(ButtonSearch, "Hitting ENTER will also start the scraping process.")
        ButtonSearch.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxTimeframe
        ' 
        ComboBoxTimeframe.AutoCompleteCustomSource.AddRange(New String() {"Hour", "Day", "Week", "Month", "Year"})
        ComboBoxTimeframe.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxTimeframe.FormattingEnabled = True
        ComboBoxTimeframe.Items.AddRange(New Object() {"Hour", "Day", "Week", "Month", "Year"})
        ComboBoxTimeframe.Location = New Point(118, 136)
        ComboBoxTimeframe.Name = "ComboBoxTimeframe"
        ComboBoxTimeframe.Size = New Size(100, 23)
        ComboBoxTimeframe.TabIndex = 8
        ComboBoxTimeframe.Text = "All"
        ToolTip.SetToolTip(ComboBoxTimeframe, "The time period for the posts. Default value is `All`.")
        ' 
        ' ComboBoxListing
        ' 
        ComboBoxListing.AutoCompleteCustomSource.AddRange(New String() {"Controversial", "Hot", "Best", "New", "Rising"})
        ComboBoxListing.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxListing.BackColor = SystemColors.Window
        ComboBoxListing.FormattingEnabled = True
        ComboBoxListing.Items.AddRange(New Object() {"Controversial", "Hot", "Best", "New", "Rising"})
        ComboBoxListing.Location = New Point(118, 107)
        ComboBoxListing.Name = "ComboBoxListing"
        ComboBoxListing.Size = New Size(100, 23)
        ComboBoxListing.TabIndex = 9
        ComboBoxListing.Text = "Top"
        ToolTip.SetToolTip(ComboBoxListing, "The type of post listings. Default value is `Top`.")
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
        LabelSubreddit.Location = New Point(19, 51)
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
        LabelLimit.Location = New Point(19, 80)
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
        LabelListing.Location = New Point(19, 108)
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
        LabelTimeframe.Location = New Point(19, 137)
        LabelTimeframe.Name = "LabelTimeframe"
        LabelTimeframe.Size = New Size(81, 23)
        LabelTimeframe.TabIndex = 14
        LabelTimeframe.Text = "Timeframe:"
        ' 
        ' ContextMenuStripRightClick
        ' 
        ContextMenuStripRightClick.Items.AddRange(New ToolStripItem() {SettingsToolStripMenuItem, AboutToolStripMenuItem, CheckForUpdatesToolStripMenuItem, QuitToolStripMenuItem})
        ContextMenuStripRightClick.Name = "ContextMenuStrip1"
        ContextMenuStripRightClick.Size = New Size(181, 114)
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DarkModeToolStripMenuItem, SavePostsToolStripMenuItem})
        SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), Image)
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(180, 22)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' DarkModeToolStripMenuItem
        ' 
        DarkModeToolStripMenuItem.CheckOnClick = True
        DarkModeToolStripMenuItem.Image = CType(resources.GetObject("DarkModeToolStripMenuItem.Image"), Image)
        DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        DarkModeToolStripMenuItem.Size = New Size(132, 22)
        DarkModeToolStripMenuItem.Text = "Dark Mode"
        ' 
        ' SavePostsToolStripMenuItem
        ' 
        SavePostsToolStripMenuItem.AutoToolTip = True
        SavePostsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToJSONToolStripMenuItem, ToCSVToolStripMenuItem})
        SavePostsToolStripMenuItem.Image = CType(resources.GetObject("SavePostsToolStripMenuItem.Image"), Image)
        SavePostsToolStripMenuItem.Name = "SavePostsToolStripMenuItem"
        SavePostsToolStripMenuItem.Size = New Size(132, 22)
        SavePostsToolStripMenuItem.Text = "Save posts"
        ' 
        ' ToJSONToolStripMenuItem
        ' 
        ToJSONToolStripMenuItem.AutoToolTip = True
        ToJSONToolStripMenuItem.CheckOnClick = True
        ToJSONToolStripMenuItem.Image = CType(resources.GetObject("ToJSONToolStripMenuItem.Image"), Image)
        ToJSONToolStripMenuItem.Name = "ToJSONToolStripMenuItem"
        ToJSONToolStripMenuItem.Size = New Size(116, 22)
        ToJSONToolStripMenuItem.Text = "to JSON"
        ' 
        ' ToCSVToolStripMenuItem
        ' 
        ToCSVToolStripMenuItem.AutoToolTip = True
        ToCSVToolStripMenuItem.CheckOnClick = True
        ToCSVToolStripMenuItem.Image = CType(resources.GetObject("ToCSVToolStripMenuItem.Image"), Image)
        ToCSVToolStripMenuItem.Name = "ToCSVToolStripMenuItem"
        ToCSVToolStripMenuItem.Size = New Size(116, 22)
        ToCSVToolStripMenuItem.Text = "to CSV"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.AutoToolTip = True
        AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), Image)
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "About RPST"
        ' 
        ' CheckForUpdatesToolStripMenuItem
        ' 
        CheckForUpdatesToolStripMenuItem.AutoToolTip = True
        CheckForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdatesToolStripMenuItem.Image"), Image)
        CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        CheckForUpdatesToolStripMenuItem.Size = New Size(180, 22)
        CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.AutoToolTip = True
        QuitToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        QuitToolStripMenuItem.Image = CType(resources.GetObject("QuitToolStripMenuItem.Image"), Image)
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(180, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' NumericUpDownLimit
        ' 
        NumericUpDownLimit.Location = New Point(118, 78)
        NumericUpDownLimit.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        NumericUpDownLimit.Name = "NumericUpDownLimit"
        NumericUpDownLimit.ReadOnly = True
        NumericUpDownLimit.Size = New Size(100, 23)
        NumericUpDownLimit.TabIndex = 15
        ToolTip.SetToolTip(NumericUpDownLimit, "Number of posts to go through. Default value is `10`.")
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
        ClientSize = New Size(239, 211)
        ContextMenuStrip = ContextMenuStripRightClick
        Controls.Add(ComboBoxTimeframe)
        Controls.Add(TextBoxKeyword)
        Controls.Add(LabelTimeframe)
        Controls.Add(LabelKeyword)
        Controls.Add(ComboBoxListing)
        Controls.Add(NumericUpDownLimit)
        Controls.Add(LabelListing)
        Controls.Add(ButtonSearch)
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
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ComboBoxTimeframe As ComboBox
    Friend WithEvents ComboBoxListing As ComboBox
    Friend WithEvents LabelKeyword As Label
    Friend WithEvents LabelSubreddit As Label
    Friend WithEvents LabelLimit As Label
    Friend WithEvents LabelListing As Label
    Friend WithEvents LabelTimeframe As Label
    Friend WithEvents ContextMenuStripRightClick As ContextMenuStrip
    Friend WithEvents SavePostsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericUpDownLimit As NumericUpDown
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFoundPostsToolStripMenuItem As ToolStripMenuItem
End Class
