<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PostsWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostsWindow))
        DataGridViewPosts = New DataGridView()
        postIndex = New DataGridViewTextBoxColumn()
        postAuthor = New DataGridViewTextBoxColumn()
        postId = New DataGridViewTextBoxColumn()
        postTitle = New DataGridViewTextBoxColumn()
        postText = New DataGridViewTextBoxColumn()
        postSubreddit = New DataGridViewTextBoxColumn()
        postSubredditType = New DataGridViewTextBoxColumn()
        postThumbnail = New DataGridViewTextBoxColumn()
        postIsNSFW = New DataGridViewTextBoxColumn()
        postIsGilded = New DataGridViewTextBoxColumn()
        postUpvotes = New DataGridViewTextBoxColumn()
        postUpvoteRatio = New DataGridViewTextBoxColumn()
        postIsShareable = New DataGridViewTextBoxColumn()
        postScore = New DataGridViewTextBoxColumn()
        postCategory = New DataGridViewTextBoxColumn()
        postDomain = New DataGridViewTextBoxColumn()
        postPermalink = New DataGridViewTextBoxColumn()
        postCreatedAt = New DataGridViewTextBoxColumn()
        CType(DataGridViewPosts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewPosts
        ' 
        DataGridViewPosts.BackgroundColor = Color.Gainsboro
        DataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPosts.Columns.AddRange(New DataGridViewColumn() {postIndex, postAuthor, postId, postTitle, postText, postSubreddit, postSubredditType, postThumbnail, postIsNSFW, postIsGilded, postUpvotes, postUpvoteRatio, postIsShareable, postScore, postCategory, postDomain, postPermalink, postCreatedAt})
        DataGridViewPosts.Dock = DockStyle.Fill
        DataGridViewPosts.Location = New Point(0, 0)
        DataGridViewPosts.Name = "DataGridViewPosts"
        DataGridViewPosts.ReadOnly = True
        DataGridViewPosts.RowHeadersVisible = False
        DataGridViewPosts.RowTemplate.Height = 25
        DataGridViewPosts.Size = New Size(501, 365)
        DataGridViewPosts.TabIndex = 3
        ' 
        ' postIndex
        ' 
        postIndex.HeaderText = "Index"
        postIndex.Name = "postIndex"
        postIndex.ReadOnly = True
        ' 
        ' postAuthor
        ' 
        postAuthor.HeaderText = "Author"
        postAuthor.Name = "postAuthor"
        postAuthor.ReadOnly = True
        ' 
        ' postId
        ' 
        postId.HeaderText = "ID"
        postId.Name = "postId"
        postId.ReadOnly = True
        ' 
        ' postTitle
        ' 
        postTitle.HeaderText = "Title"
        postTitle.Name = "postTitle"
        postTitle.ReadOnly = True
        ' 
        ' postText
        ' 
        postText.HeaderText = "Text"
        postText.Name = "postText"
        postText.ReadOnly = True
        ' 
        ' postSubreddit
        ' 
        postSubreddit.HeaderText = "Subreddit"
        postSubreddit.Name = "postSubreddit"
        postSubreddit.ReadOnly = True
        ' 
        ' postSubredditType
        ' 
        postSubredditType.HeaderText = "Subreddit Type"
        postSubredditType.Name = "postSubredditType"
        postSubredditType.ReadOnly = True
        ' 
        ' postThumbnail
        ' 
        postThumbnail.HeaderText = "Thumbnail"
        postThumbnail.Name = "postThumbnail"
        postThumbnail.ReadOnly = True
        ' 
        ' postIsNSFW
        ' 
        postIsNSFW.HeaderText = "Is NSFW"
        postIsNSFW.Name = "postIsNSFW"
        postIsNSFW.ReadOnly = True
        ' 
        ' postIsGilded
        ' 
        postIsGilded.HeaderText = "Is Gilded"
        postIsGilded.Name = "postIsGilded"
        postIsGilded.ReadOnly = True
        ' 
        ' postUpvotes
        ' 
        postUpvotes.HeaderText = "Upvotes"
        postUpvotes.Name = "postUpvotes"
        postUpvotes.ReadOnly = True
        ' 
        ' postUpvoteRatio
        ' 
        postUpvoteRatio.HeaderText = "Upvote Ratio"
        postUpvoteRatio.Name = "postUpvoteRatio"
        postUpvoteRatio.ReadOnly = True
        ' 
        ' postIsShareable
        ' 
        postIsShareable.HeaderText = "Is Shareable"
        postIsShareable.Name = "postIsShareable"
        postIsShareable.ReadOnly = True
        ' 
        ' postScore
        ' 
        postScore.HeaderText = "Score"
        postScore.Name = "postScore"
        postScore.ReadOnly = True
        ' 
        ' postCategory
        ' 
        postCategory.HeaderText = "Category"
        postCategory.Name = "postCategory"
        postCategory.ReadOnly = True
        ' 
        ' postDomain
        ' 
        postDomain.HeaderText = "Domain"
        postDomain.Name = "postDomain"
        postDomain.ReadOnly = True
        ' 
        ' postPermalink
        ' 
        postPermalink.HeaderText = "Permalink"
        postPermalink.Name = "postPermalink"
        postPermalink.ReadOnly = True
        ' 
        ' postCreatedAt
        ' 
        postCreatedAt.HeaderText = "Created At"
        postCreatedAt.Name = "postCreatedAt"
        postCreatedAt.ReadOnly = True
        ' 
        ' PostsWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 365)
        Controls.Add(DataGridViewPosts)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "PostsWindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Posts"
        CType(DataGridViewPosts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewPosts As DataGridView
    Friend WithEvents postIndex As DataGridViewTextBoxColumn
    Friend WithEvents postAuthor As DataGridViewTextBoxColumn
    Friend WithEvents postId As DataGridViewTextBoxColumn
    Friend WithEvents postTitle As DataGridViewTextBoxColumn
    Friend WithEvents postText As DataGridViewTextBoxColumn
    Friend WithEvents postSubreddit As DataGridViewTextBoxColumn
    Friend WithEvents postSubredditType As DataGridViewTextBoxColumn
    Friend WithEvents postThumbnail As DataGridViewTextBoxColumn
    Friend WithEvents postIsNSFW As DataGridViewTextBoxColumn
    Friend WithEvents postIsGilded As DataGridViewTextBoxColumn
    Friend WithEvents postUpvotes As DataGridViewTextBoxColumn
    Friend WithEvents postUpvoteRatio As DataGridViewTextBoxColumn
    Friend WithEvents postIsShareable As DataGridViewTextBoxColumn
    Friend WithEvents postScore As DataGridViewTextBoxColumn
    Friend WithEvents postCategory As DataGridViewTextBoxColumn
    Friend WithEvents postDomain As DataGridViewTextBoxColumn
    Friend WithEvents postPermalink As DataGridViewTextBoxColumn
    Friend WithEvents postCreatedAt As DataGridViewTextBoxColumn
End Class
