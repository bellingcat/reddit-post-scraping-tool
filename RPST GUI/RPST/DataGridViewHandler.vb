Imports Newtonsoft.Json.Linq

Public Class DataGridViewHandler
    ''' <summary>
    ''' Initializes the DataGridView by clearing any existing data and setting up the necessary columns.
    ''' </summary>
    ''' <param name="dataGridView">The DataGridView to be initialized.</param>
    Public Shared Sub AddColumn(dataGridView As DataGridView)
        ' Clear the Columns and Rows before adding Items to them 
        dataGridView.Rows.Clear()
        dataGridView.Columns.Clear()

        dataGridView.Columns.Add("PostCount", "INDEX")
        dataGridView.Columns.Add("PostAuthor", "AUTHOR")
        dataGridView.Columns.Add("PostID", "ID")
        dataGridView.Columns.Add("PostText", "TEXT")
        dataGridView.Columns.Add("PostSubreddit", "SUBREDDIT")
        dataGridView.Columns.Add("SubredditVisibility", "VISIBILITY")
        dataGridView.Columns.Add("PostThumbnail", "THUMBNAIL")
        dataGridView.Columns.Add("PostIsNSFW", "NSFW")
        dataGridView.Columns.Add("PostIsGilded", "GILDED")
        dataGridView.Columns.Add("PostUpvotes", "UPVOTES")
        dataGridView.Columns.Add("PostUpvoteRatio", "UPVOTE RATIO")
        dataGridView.Columns.Add("PostDownvotes", "DOWNVOTES")
        dataGridView.Columns.Add("PostAwards", "AWARDS")
        dataGridView.Columns.Add("PostTopAward", "TOP AWARD")
        dataGridView.Columns.Add("PostIsCrosspostable", "IS CROSS-POSTABLE?")
        dataGridView.Columns.Add("PostScore", "SCORE")
        dataGridView.Columns.Add("PostCategory", "CATEGORY")
        dataGridView.Columns.Add("PostDomain", "DOMAIN")
        dataGridView.Columns.Add("PostPermalink", "PERMALINK")
        dataGridView.Columns.Add("PostCreatedAt", "CREATED AT")
        dataGridView.Columns.Add("PostApprovedAt", "APPROVED ATt")
        dataGridView.Columns.Add("PostApprovedBy", "APPROVED BY")
    End Sub

    Public Shared Sub AddRow(dataGridView As DataGridView, post As JObject, postNumber As Integer)
        ''' <summary>
        ''' Adds a row to the DataGridView based on the data from a Reddit post.
        ''' </summary>
        ''' <param name="dataGridView">The DataGridView to which the row will be added.</param>
        ''' <param name="post">A JObject representing the Reddit post.</param>
        ''' <param name="postNumber">The number of the post.</param>
        dataGridView.Rows.Add(postNumber,
                              post("data")("author"),
                              post("data")("id"),
                              post("data")("selftext"),
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
                              post("data")("category"),
                              post("data")("domain"),
                              post("data")("permalink"),
                              post("data")("created"),
                              post("data")("approved_at_utc"),
                              post("data")("approved_by"))
    End Sub
End Class
