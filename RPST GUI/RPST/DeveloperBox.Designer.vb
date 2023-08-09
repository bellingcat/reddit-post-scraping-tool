<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeveloperBox
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DeveloperBox))
        AboutMeLinkLabel = New LinkLabel()
        LinkLabelBuyMeACoffee = New LinkLabel()
        GreetingLabel = New Label()
        SuspendLayout()
        ' 
        ' AboutMeLinkLabel
        ' 
        AboutMeLinkLabel.AutoSize = True
        AboutMeLinkLabel.BackColor = Color.White
        AboutMeLinkLabel.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AboutMeLinkLabel.Location = New Point(33, 426)
        AboutMeLinkLabel.Name = "AboutMeLinkLabel"
        AboutMeLinkLabel.Size = New Size(57, 17)
        AboutMeLinkLabel.TabIndex = 0
        AboutMeLinkLabel.TabStop = True
        AboutMeLinkLabel.Text = "About.me"
        ' 
        ' LinkLabelBuyMeACoffee
        ' 
        LinkLabelBuyMeACoffee.AutoSize = True
        LinkLabelBuyMeACoffee.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabelBuyMeACoffee.Location = New Point(33, 451)
        LinkLabelBuyMeACoffee.Name = "LinkLabelBuyMeACoffee"
        LinkLabelBuyMeACoffee.Size = New Size(101, 17)
        LinkLabelBuyMeACoffee.TabIndex = 1
        LinkLabelBuyMeACoffee.TabStop = True
        LinkLabelBuyMeACoffee.Text = "Buy Me A Coffee"
        ' 
        ' GreetingLabel
        ' 
        GreetingLabel.AutoSize = True
        GreetingLabel.Font = New Font("Ink Free", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        GreetingLabel.Location = New Point(62, 22)
        GreetingLabel.Name = "GreetingLabel"
        GreetingLabel.Size = New Size(355, 46)
        GreetingLabel.TabIndex = 3
        GreetingLabel.Text = "👋🏾Hello, I'm Ritchie"
        ' 
        ' DeveloperForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(510, 510)
        Controls.Add(LinkLabelBuyMeACoffee)
        Controls.Add(AboutMeLinkLabel)
        Controls.Add(GreetingLabel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "DeveloperForm"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Developer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AboutMeLinkLabel As LinkLabel
    Friend WithEvents LinkLabelBuyMeACoffee As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GreetingLabel As Label
End Class
