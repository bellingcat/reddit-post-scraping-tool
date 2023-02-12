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
        Me.LimitTextBox = New System.Windows.Forms.TextBox()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChekUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KeywordTextBox
        '
        Me.KeywordTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.KeywordTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.KeywordTextBox.Location = New System.Drawing.Point(89, 96)
        Me.KeywordTextBox.Name = "KeywordTextBox"
        Me.KeywordTextBox.PlaceholderText = "Keyword"
        Me.KeywordTextBox.Size = New System.Drawing.Size(100, 23)
        Me.KeywordTextBox.TabIndex = 0
        '
        'LimitTextBox
        '
        Me.LimitTextBox.Location = New System.Drawing.Point(89, 154)
        Me.LimitTextBox.Name = "LimitTextBox"
        Me.LimitTextBox.PlaceholderText = "Limit (1-100)"
        Me.LimitTextBox.Size = New System.Drawing.Size(100, 23)
        Me.LimitTextBox.TabIndex = 3
        '
        'SubredditTextBox
        '
        Me.SubredditTextBox.Location = New System.Drawing.Point(89, 125)
        Me.SubredditTextBox.Name = "SubredditTextBox"
        Me.SubredditTextBox.PlaceholderText = "Subreddit"
        Me.SubredditTextBox.Size = New System.Drawing.Size(100, 23)
        Me.SubredditTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 215)
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
        Me.TimeframeComboBox.Location = New System.Drawing.Point(89, 212)
        Me.TimeframeComboBox.Name = "TimeframeComboBox"
        Me.TimeframeComboBox.Size = New System.Drawing.Size(100, 23)
        Me.TimeframeComboBox.TabIndex = 8
        Me.TimeframeComboBox.Text = "All"
        '
        'ListingComboBox
        '
        Me.ListingComboBox.FormattingEnabled = True
        Me.ListingComboBox.Items.AddRange(New Object() {"Controversial", "Hot", "Best", "New", "Rising"})
        Me.ListingComboBox.Location = New System.Drawing.Point(89, 183)
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
        Me.Label1.Location = New System.Drawing.Point(12, 96)
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
        Me.Label2.Location = New System.Drawing.Point(12, 125)
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
        Me.Label3.Location = New System.Drawing.Point(12, 154)
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
        Me.Label4.Location = New System.Drawing.Point(12, 183)
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
        Me.Label5.Location = New System.Drawing.Point(12, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Timeframe"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveResultsJSONToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 26)
        '
        'SaveResultsJSONToolStripMenuItem
        '
        Me.SaveResultsJSONToolStripMenuItem.CheckOnClick = True
        Me.SaveResultsJSONToolStripMenuItem.Image = CType(resources.GetObject("SaveResultsJSONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveResultsJSONToolStripMenuItem.Name = "SaveResultsJSONToolStripMenuItem"
        Me.SaveResultsJSONToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SaveResultsJSONToolStripMenuItem.Text = "Save results (JSON)"
        Me.SaveResultsJSONToolStripMenuItem.ToolTipText = "Save results to a JSON file"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuTools})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(355, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuTools
        '
        Me.ToolsToolStripMenuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.DeveloperToolStripMenuItem, Me.ChekUpdatesToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitToolStripMenuItem})
        Me.ToolsToolStripMenuTools.Image = CType(resources.GetObject("ToolsToolStripMenuTools.Image"), System.Drawing.Image)
        Me.ToolsToolStripMenuTools.Name = "ToolsToolStripMenuTools"
        Me.ToolsToolStripMenuTools.Size = New System.Drawing.Size(62, 20)
        Me.ToolsToolStripMenuTools.Text = "Tools"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.ToolTipText = "About program"
        '
        'DeveloperToolStripMenuItem
        '
        Me.DeveloperToolStripMenuItem.Image = CType(resources.GetObject("DeveloperToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        Me.DeveloperToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeveloperToolStripMenuItem.Text = "Developer"
        Me.DeveloperToolStripMenuItem.ToolTipText = "About developer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = CType(resources.GetObject("QuitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        Me.QuitToolStripMenuItem.ToolTipText = "Quit program"
        '
        'ChekUpdatesToolStripMenuItem
        '
        Me.ChekUpdatesToolStripMenuItem.Image = CType(resources.GetObject("ChekUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChekUpdatesToolStripMenuItem.Name = "ChekUpdatesToolStripMenuItem"
        Me.ChekUpdatesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChekUpdatesToolStripMenuItem.Text = "Check updates"
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(355, 255)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListingComboBox)
        Me.Controls.Add(Me.TimeframeComboBox)
        Me.Controls.Add(Me.SubredditTextBox)
        Me.Controls.Add(Me.LimitTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KeywordTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reddit Post Scraping Tool"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KeywordTextBox As TextBox
    Friend WithEvents LimitTextBox As TextBox
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuTools As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveResultsJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChekUpdatesToolStripMenuItem As ToolStripMenuItem
End Class
