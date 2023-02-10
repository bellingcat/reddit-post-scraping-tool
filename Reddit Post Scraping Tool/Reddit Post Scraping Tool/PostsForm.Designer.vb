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
        Me.DataGridViewPosts = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewPosts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPosts
        '
        Me.DataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPosts.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewPosts.Name = "DataGridViewPosts"
        Me.DataGridViewPosts.ReadOnly = True
        Me.DataGridViewPosts.RowTemplate.Height = 25
        Me.DataGridViewPosts.Size = New System.Drawing.Size(800, 450)
        Me.DataGridViewPosts.TabIndex = 3
        '
        'PostsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewPosts)
        Me.Name = "PostsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "PostsForm"
        CType(Me.DataGridViewPosts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewPosts As DataGridView
End Class
