<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AboutBox))
        PictureBoxLogo = New PictureBox()
        LabelProgramName = New Label()
        LabelDescription = New Label()
        TabControl1 = New TabControl()
        TabPageAbout = New TabPage()
        LabelCopyright = New Label()
        LinkLabelLicense = New LinkLabel()
        LinkLabelReadtheWiki = New LinkLabel()
        TabPageAuthor = New TabPage()
        LinkLabelEmail = New LinkLabel()
        LinkLabelBMC = New LinkLabel()
        LinkLabelAboutMe = New LinkLabel()
        LabelAuthor = New Label()
        LabelVersion = New Label()
        ButtonClose = New Button()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPageAbout.SuspendLayout()
        TabPageAuthor.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.Location = New Point(12, 12)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(62, 64)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelProgramName
        ' 
        LabelProgramName.AutoSize = True
        LabelProgramName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelProgramName.ForeColor = SystemColors.ControlText
        LabelProgramName.Location = New Point(80, 33)
        LabelProgramName.Name = "LabelProgramName"
        LabelProgramName.Size = New Size(44, 17)
        LabelProgramName.TabIndex = 3
        LabelProgramName.Text = "Name"
        ' 
        ' LabelDescription
        ' 
        LabelDescription.AutoSize = True
        LabelDescription.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDescription.ForeColor = SystemColors.ControlText
        LabelDescription.Location = New Point(6, 7)
        LabelDescription.Name = "LabelDescription"
        LabelDescription.Size = New Size(67, 15)
        LabelDescription.TabIndex = 4
        LabelDescription.Text = "Description"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPageAbout)
        TabControl1.Controls.Add(TabPageAuthor)
        TabControl1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.Location = New Point(12, 91)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(322, 152)
        TabControl1.TabIndex = 8
        ' 
        ' TabPageAbout
        ' 
        TabPageAbout.BackColor = Color.Transparent
        TabPageAbout.Controls.Add(LabelCopyright)
        TabPageAbout.Controls.Add(LinkLabelLicense)
        TabPageAbout.Controls.Add(LabelDescription)
        TabPageAbout.Controls.Add(LinkLabelReadtheWiki)
        TabPageAbout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TabPageAbout.Location = New Point(4, 24)
        TabPageAbout.Name = "TabPageAbout"
        TabPageAbout.Padding = New Padding(3)
        TabPageAbout.Size = New Size(314, 124)
        TabPageAbout.TabIndex = 0
        TabPageAbout.Text = "About"
        ' 
        ' LabelCopyright
        ' 
        LabelCopyright.AutoSize = True
        LabelCopyright.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LabelCopyright.Location = New Point(6, 97)
        LabelCopyright.Name = "LabelCopyright"
        LabelCopyright.Size = New Size(60, 15)
        LabelCopyright.TabIndex = 7
        LabelCopyright.Text = "Copyright"
        ' 
        ' LinkLabelLicense
        ' 
        LinkLabelLicense.AutoSize = True
        LinkLabelLicense.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabelLicense.Location = New Point(6, 52)
        LinkLabelLicense.Name = "LinkLabelLicense"
        LinkLabelLicense.Size = New Size(84, 15)
        LinkLabelLicense.TabIndex = 5
        LinkLabelLicense.TabStop = True
        LinkLabelLicense.Text = "🗒️ MIT License"
        ' 
        ' LinkLabelReadtheWiki
        ' 
        LinkLabelReadtheWiki.AutoSize = True
        LinkLabelReadtheWiki.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabelReadtheWiki.Location = New Point(6, 74)
        LinkLabelReadtheWiki.Name = "LinkLabelReadtheWiki"
        LinkLabelReadtheWiki.Size = New Size(94, 15)
        LinkLabelReadtheWiki.TabIndex = 6
        LinkLabelReadtheWiki.TabStop = True
        LinkLabelReadtheWiki.Text = "📖 Read the Wiki"
        ' 
        ' TabPageAuthor
        ' 
        TabPageAuthor.BackColor = Color.Transparent
        TabPageAuthor.Controls.Add(LinkLabelEmail)
        TabPageAuthor.Controls.Add(LinkLabelBMC)
        TabPageAuthor.Controls.Add(LinkLabelAboutMe)
        TabPageAuthor.Controls.Add(LabelAuthor)
        TabPageAuthor.ForeColor = SystemColors.ControlText
        TabPageAuthor.Location = New Point(4, 24)
        TabPageAuthor.Name = "TabPageAuthor"
        TabPageAuthor.Padding = New Padding(3)
        TabPageAuthor.Size = New Size(314, 124)
        TabPageAuthor.TabIndex = 1
        TabPageAuthor.Text = "Author"
        ' 
        ' LinkLabelEmail
        ' 
        LinkLabelEmail.AutoSize = True
        LinkLabelEmail.Location = New Point(6, 89)
        LinkLabelEmail.Name = "LinkLabelEmail"
        LinkLabelEmail.Size = New Size(51, 15)
        LinkLabelEmail.TabIndex = 3
        LinkLabelEmail.TabStop = True
        LinkLabelEmail.Text = "📧 Email"
        ' 
        ' LinkLabelBMC
        ' 
        LinkLabelBMC.AutoSize = True
        LinkLabelBMC.Location = New Point(3, 66)
        LinkLabelBMC.Name = "LinkLabelBMC"
        LinkLabelBMC.Size = New Size(111, 15)
        LinkLabelBMC.TabIndex = 2
        LinkLabelBMC.TabStop = True
        LinkLabelBMC.Text = "🍵 Buy Me A Coffee"
        ' 
        ' LinkLabelAboutMe
        ' 
        LinkLabelAboutMe.AutoSize = True
        LinkLabelAboutMe.Location = New Point(6, 43)
        LinkLabelAboutMe.Name = "LinkLabelAboutMe"
        LinkLabelAboutMe.Size = New Size(75, 15)
        LinkLabelAboutMe.TabIndex = 1
        LinkLabelAboutMe.TabStop = True
        LinkLabelAboutMe.Text = "🔗 About.me"
        ' 
        ' LabelAuthor
        ' 
        LabelAuthor.AutoSize = True
        LabelAuthor.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LabelAuthor.Location = New Point(6, 15)
        LabelAuthor.Name = "LabelAuthor"
        LabelAuthor.Size = New Size(96, 15)
        LabelAuthor.TabIndex = 0
        LabelAuthor.Text = "Richard Mwewa"
        ' 
        ' LabelVersion
        ' 
        LabelVersion.AutoSize = True
        LabelVersion.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelVersion.Location = New Point(80, 53)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(45, 13)
        LabelVersion.TabIndex = 9
        LabelVersion.Text = "Version"
        ' 
        ' ButtonClose
        ' 
        ButtonClose.Location = New Point(275, 249)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(61, 23)
        ButtonClose.TabIndex = 6
        ButtonClose.Text = "&Close"
        ButtonClose.UseVisualStyleBackColor = True
        ' 
        ' AboutBox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        CancelButton = ButtonClose
        ClientSize = New Size(346, 285)
        Controls.Add(ButtonClose)
        Controls.Add(LabelVersion)
        Controls.Add(TabControl1)
        Controls.Add(LabelProgramName)
        Controls.Add(PictureBoxLogo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutBox"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "About"
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPageAbout.ResumeLayout(False)
        TabPageAbout.PerformLayout()
        TabPageAuthor.ResumeLayout(False)
        TabPageAuthor.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelProgramName As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LicenseRichTextBox As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageAbout As TabPage
    Friend WithEvents TabPageAuthor As TabPage
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LinkLabelLicense As LinkLabel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LinkLabelReadtheWiki As LinkLabel
    Friend WithEvents LabelAuthor As Label
    Friend WithEvents LinkLabelAboutMe As LinkLabel
    Friend WithEvents LinkLabelEmail As LinkLabel
    Friend WithEvents LinkLabelBMC As LinkLabel
End Class
