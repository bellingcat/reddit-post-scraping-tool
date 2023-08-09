<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPosts
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormPosts))
        DataGridViewPosts = New DataGridView()
        CType(DataGridViewPosts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewPosts
        ' 
        DataGridViewPosts.BackgroundColor = Color.Gainsboro
        DataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPosts.Dock = DockStyle.Fill
        DataGridViewPosts.Location = New Point(0, 0)
        DataGridViewPosts.Name = "DataGridViewPosts"
        DataGridViewPosts.ReadOnly = True
        DataGridViewPosts.RowHeadersVisible = False
        DataGridViewPosts.RowTemplate.Height = 25
        DataGridViewPosts.Size = New Size(501, 365)
        DataGridViewPosts.TabIndex = 3
        ' 
        ' FormPosts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 365)
        Controls.Add(DataGridViewPosts)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormPosts"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Posts"
        CType(DataGridViewPosts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewPosts As DataGridView
End Class
