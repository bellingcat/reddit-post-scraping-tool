<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostsForm
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
        DataGridViewPosts.Size = New Size(800, 450)
        DataGridViewPosts.TabIndex = 3
        ' 
        ' PostsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridViewPosts)
        Name = "PostsForm"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "PostsForm"
        CType(DataGridViewPosts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewPosts As DataGridView
End Class
