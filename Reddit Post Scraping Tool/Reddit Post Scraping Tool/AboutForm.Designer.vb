﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AboutForm))
        PictureBox1 = New PictureBox()
        LicenseRichTextBox = New RichTextBox()
        Label1 = New Label()
        Label2 = New Label()
        DescriptionLabel = New Label()
        VersionLabel = New Label()
        WikiLinkLabel = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(28, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 88)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LicenseRichTextBox
        ' 
        LicenseRichTextBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LicenseRichTextBox.Location = New Point(28, 170)
        LicenseRichTextBox.Name = "LicenseRichTextBox"
        LicenseRichTextBox.ReadOnly = True
        LicenseRichTextBox.Size = New Size(513, 342)
        LicenseRichTextBox.TabIndex = 1
        LicenseRichTextBox.Text = ""' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(28, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 17)
        Label1.TabIndex = 2
        Label1.Text = "License"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(126, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 24)
        Label2.TabIndex = 3
        Label2.Text = "Reddit Post Scraping Tool"' 
        ' DescriptionLabel
        ' 
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DescriptionLabel.Location = New Point(126, 81)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New Size(0, 15)
        DescriptionLabel.TabIndex = 4
        ' 
        ' VersionLabel
        ' 
        VersionLabel.AutoSize = True
        VersionLabel.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        VersionLabel.Location = New Point(500, 54)
        VersionLabel.Name = "VersionLabel"
        VersionLabel.Size = New Size(42, 15)
        VersionLabel.TabIndex = 5
        VersionLabel.Text = "Label4"' 
        ' WikiLinkLabel
        ' 
        WikiLinkLabel.AutoSize = True
        WikiLinkLabel.Location = New Point(511, 81)
        WikiLinkLabel.Name = "WikiLinkLabel"
        WikiLinkLabel.Size = New Size(30, 15)
        WikiLinkLabel.TabIndex = 6
        WikiLinkLabel.TabStop = True
        WikiLinkLabel.Text = "Wiki"' 
        ' AboutForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(569, 541)
        Controls.Add(WikiLinkLabel)
        Controls.Add(VersionLabel)
        Controls.Add(DescriptionLabel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LicenseRichTextBox)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "About - Reddit Post Scraping Tool"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LicenseRichTextBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents WikiLinkLabel As LinkLabel
End Class
