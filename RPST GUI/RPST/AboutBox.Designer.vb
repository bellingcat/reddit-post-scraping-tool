﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        LabelProgramDescription = New Label()
        LabelVersion = New Label()
        LinkLabelReadtheWiki = New LinkLabel()
        Panel1 = New Panel()
        LicenseRichTextBox = New RichTextBox()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.Location = New Point(12, 12)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(99, 111)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelProgramName
        ' 
        LabelProgramName.AutoSize = True
        LabelProgramName.Font = New Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LabelProgramName.ForeColor = SystemColors.ControlText
        LabelProgramName.Location = New Point(4, 11)
        LabelProgramName.Name = "LabelProgramName"
        LabelProgramName.Size = New Size(60, 23)
        LabelProgramName.TabIndex = 3
        LabelProgramName.Text = "Name"
        ' 
        ' LabelProgramDescription
        ' 
        LabelProgramDescription.AutoSize = True
        LabelProgramDescription.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LabelProgramDescription.ForeColor = SystemColors.ControlText
        LabelProgramDescription.Location = New Point(4, 54)
        LabelProgramDescription.Name = "LabelProgramDescription"
        LabelProgramDescription.Size = New Size(73, 17)
        LabelProgramDescription.TabIndex = 4
        LabelProgramDescription.Text = "Description"
        ' 
        ' LabelVersion
        ' 
        LabelVersion.AutoSize = True
        LabelVersion.Font = New Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point)
        LabelVersion.ForeColor = SystemColors.ControlText
        LabelVersion.Location = New Point(372, 17)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(50, 17)
        LabelVersion.TabIndex = 5
        LabelVersion.Text = "Version"
        ' 
        ' LinkLabelReadtheWiki
        ' 
        LinkLabelReadtheWiki.AutoSize = True
        LinkLabelReadtheWiki.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabelReadtheWiki.Location = New Point(337, 54)
        LinkLabelReadtheWiki.Name = "LinkLabelReadtheWiki"
        LinkLabelReadtheWiki.Size = New Size(85, 17)
        LinkLabelReadtheWiki.TabIndex = 6
        LinkLabelReadtheWiki.TabStop = True
        LinkLabelReadtheWiki.Text = "Read the Wiki"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(LabelProgramDescription)
        Panel1.Controls.Add(LabelProgramName)
        Panel1.Controls.Add(LinkLabelReadtheWiki)
        Panel1.Controls.Add(LabelVersion)
        Panel1.Location = New Point(117, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 111)
        Panel1.TabIndex = 7
        ' 
        ' LicenseRichTextBox
        ' 
        LicenseRichTextBox.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LicenseRichTextBox.Location = New Point(12, 135)
        LicenseRichTextBox.Name = "LicenseRichTextBox"
        LicenseRichTextBox.ReadOnly = True
        LicenseRichTextBox.Size = New Size(545, 305)
        LicenseRichTextBox.TabIndex = 1
        LicenseRichTextBox.Text = "License notice"
        ' 
        ' AboutBox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(569, 454)
        Controls.Add(LicenseRichTextBox)
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelProgramName As Label
    Friend WithEvents LabelProgramDescription As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LinkLabelReadtheWiki As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LicenseRichTextBox As RichTextBox
End Class
