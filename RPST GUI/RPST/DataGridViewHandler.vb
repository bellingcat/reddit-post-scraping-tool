Imports Newtonsoft.Json.Linq

Public Class DataGridViewHandler
    ''' <summary>
    ''' Initializes the DataGridView by clearing any existing data and setting up the necessary columns.
    ''' </summary>
    ''' <param name="dataGridView">The DataGridView to be initialized.</param>
    Public Shared Sub AddColumn(dataGridView As DataGridView)
        ' Clear the Columns and Rows before adding Items to them 
        PostsForm.DataGridViewPosts.Rows.Clear()
        PostsForm.DataGridViewPosts.Columns.Clear()

        PostsForm.DataGridViewPosts.Columns.Add("PostCount", "Post Number")
        PostsForm.DataGridViewPosts.Columns.Add("PostAuthor", "Author")
        PostsForm.DataGridViewPosts.Columns.Add("PostID", "ID")
        PostsForm.DataGridViewPosts.Columns.Add("PostSubreddit", "Subreddit")
        PostsForm.DataGridViewPosts.Columns.Add("SubredditVisibility", "Subreddit Visibility")
        PostsForm.DataGridViewPosts.Columns.Add("PostThumbnail", "Thumbnail")
        PostsForm.DataGridViewPosts.Columns.Add("PostIsNSFW", "NSFW")
        PostsForm.DataGridViewPosts.Columns.Add("PostIsGilded", "Gilded")
        PostsForm.DataGridViewPosts.Columns.Add("PostUpvotes", "Upvotes")
        PostsForm.DataGridViewPosts.Columns.Add("PostUpvoteRatio", "Upvote Ratio")
        PostsForm.DataGridViewPosts.Columns.Add("PostDownvotes", "Downvotes")
        PostsForm.DataGridViewPosts.Columns.Add("PostAwards", "Awards")
        PostsForm.DataGridViewPosts.Columns.Add("PostTopAward", "Top Award")
        PostsForm.DataGridViewPosts.Columns.Add("PostIsCrosspostable", "Is Crosspostable?")
        PostsForm.DataGridViewPosts.Columns.Add("PostScore", "Score")
        PostsForm.DataGridViewPosts.Columns.Add("PostText", "Text")
        PostsForm.DataGridViewPosts.Columns.Add("PostCategory", "Category")
        PostsForm.DataGridViewPosts.Columns.Add("PostDomain", "Domain")
        PostsForm.DataGridViewPosts.Columns.Add("PostPermalink", "Permalink")
        PostsForm.DataGridViewPosts.Columns.Add("PostCreatedAt", "Created At")
        PostsForm.DataGridViewPosts.Columns.Add("PostApprovedAt", "Approved At")
        PostsForm.DataGridViewPosts.Columns.Add("PostApprovedBy", "Approved By")
    End Sub

    Public Shared Sub AddRow(dataGridView As DataGridView, post As JObject, postNumber As Integer)
        ''' <summary>
        ''' Adds a row to the DataGridView based on the data from a Reddit post.
        ''' </summary>
        ''' <param name="dataGridView">The DataGridView to which the row will be added.</param>
        ''' <param name="post">A JObject representing the Reddit post.</param>
        ''' <param name="postNumber">The number of the post.</param>
        PostsForm.DataGridViewPosts.Rows.Add(postNumber,
                              post("data")("author"),
                              post("data")("id"),
                              post("data")("subreddit_name_prefixed"),
                              post("data")("subreddit_type"),
                              post("data")("thumbnail"),
                              post("data")("over_18"),
                              post("data")("gilded"),
                              post("data")("ups"),
                              post("data")("upvote_ratio"),
                              post("data")("downs"),
                              post("data")("total_awards_received"),
                              post("data")("top_awarded_type"),
                              post("data")("is_crosspostable"),
                              post("data")("score"),
                              post("data")("selftext"),
                              post("data")("category"),
                              post("data")("domain"),
                              post("data")("permalink"),
                              post("data")("created"),
                              post("data")("approved_at_utc"),
                              post("data")("approved_by"))
    End Sub
End Class
