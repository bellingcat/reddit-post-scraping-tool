<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeveloperForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeveloperForm))
        Me.AboutMeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BuyMeACoffeeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GreetingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AboutMeLinkLabel
        '
        Me.AboutMeLinkLabel.AutoSize = True
        Me.AboutMeLinkLabel.BackColor = System.Drawing.Color.White
        Me.AboutMeLinkLabel.Location = New System.Drawing.Point(33, 426)
        Me.AboutMeLinkLabel.Name = "AboutMeLinkLabel"
        Me.AboutMeLinkLabel.Size = New System.Drawing.Size(60, 15)
        Me.AboutMeLinkLabel.TabIndex = 0
        Me.AboutMeLinkLabel.TabStop = True
        Me.AboutMeLinkLabel.Text = "About.me"
        '
        'BuyMeACoffeeLinkLabel
        '
        Me.BuyMeACoffeeLinkLabel.AutoSize = True
        Me.BuyMeACoffeeLinkLabel.Location = New System.Drawing.Point(33, 451)
        Me.BuyMeACoffeeLinkLabel.Name = "BuyMeACoffeeLinkLabel"
        Me.BuyMeACoffeeLinkLabel.Size = New System.Drawing.Size(96, 15)
        Me.BuyMeACoffeeLinkLabel.TabIndex = 1
        Me.BuyMeACoffeeLinkLabel.TabStop = True
        Me.BuyMeACoffeeLinkLabel.Text = "Buy Me A Coffee"
        '
        'GreetingLabel
        '
        Me.GreetingLabel.AutoSize = True
        Me.GreetingLabel.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GreetingLabel.Location = New System.Drawing.Point(62, 22)
        Me.GreetingLabel.Name = "GreetingLabel"
        Me.GreetingLabel.Size = New System.Drawing.Size(382, 45)
        Me.GreetingLabel.TabIndex = 3
        Me.GreetingLabel.Text = "Hello, I'm Ritchie"
        '
        'DeveloperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(510, 510)
        Me.Controls.Add(Me.BuyMeACoffeeLinkLabel)
        Me.Controls.Add(Me.AboutMeLinkLabel)
        Me.Controls.Add(Me.GreetingLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DeveloperForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Developer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutMeLinkLabel As LinkLabel
    Friend WithEvents BuyMeACoffeeLinkLabel As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GreetingLabel As Label
End Class
