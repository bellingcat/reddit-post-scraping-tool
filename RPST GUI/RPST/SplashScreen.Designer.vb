<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        MainLayoutPanel = New TableLayoutPanel()
        DetailsLayoutPanel = New TableLayoutPanel()
        Copyright = New Label()
        Version = New Label()
        ApplicationTitle = New Label()
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackColor = Color.White
        MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), Image)
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 270F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 73F))
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1)
        MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 0)
        MainLayoutPanel.Dock = DockStyle.Fill
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 223F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 33F))
        MainLayoutPanel.Size = New Size(483, 313)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Location = New Point(273, 226)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowCount = 2
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 61.70213F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 38.29787F))
        DetailsLayoutPanel.Size = New Size(207, 84)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Copyright.Location = New Point(3, 51)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(201, 33)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright"
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Version.Location = New Point(3, 4)
        Version.Name = "Version"
        Version.Size = New Size(201, 43)
        Version.TabIndex = 1
        Version.Text = "Version"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ApplicationTitle.Location = New Point(273, 0)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(207, 223)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "Reddit Post ScrapingTool."
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(483, 313)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

End Class
