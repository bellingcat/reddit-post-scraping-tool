Imports Newtonsoft.Json.Linq

Public Class DataGridViewHandler
    ''' <summary>
    ''' Initializes the DataGridView by clearing any existing data and setting up the necessary columns.
    ''' </summary>
    ''' <param name="dataGridView">The DataGridView to be initialized.</param>
    Public Shared Sub AddColumn(dataGridView As DataGridView)
        ''' <summary>
        ''' Clear the Columns and Rows before adding Items to them.
        ''' <summary>
        dataGridView.Rows.Clear()
        dataGridView.Columns.Clear()

        dataGridView.Columns.Add("PostCount", "🔢 Index")
        dataGridView.Columns.Add("PostAuthor", "👤 Author")
        dataGridView.Columns.Add("PostID", "🆔 ID")
        dataGridView.Columns.Add("PostText", "📝 Text")
        dataGridView.Columns.Add("PostSubreddit", "🫂 Subreddit")
        dataGridView.Columns.Add("SubredditVisibility", "🫣 Visibility")
        dataGridView.Columns.Add("PostThumbnail", "🖼️ Thumbnail")
        dataGridView.Columns.Add("PostIsNSFW", "🔞 NSFW")
        dataGridView.Columns.Add("PostIsGilded", "🥇 Gilded")
        dataGridView.Columns.Add("PostUpvotes", "⬆️ Upvotes")
        dataGridView.Columns.Add("PostUpvoteRatio", "📊 Upvote Ratio")
        dataGridView.Columns.Add("PostDownvotes", "⬇️ Downvotes")
        dataGridView.Columns.Add("PostAwards", "🏆 Awards")
        dataGridView.Columns.Add("PostTopAward", "🏆 Top Award")
        dataGridView.Columns.Add("PostIsCrosspostable", "↪️ Is cross-postable?")
        dataGridView.Columns.Add("PostScore", "📈 Score")
        dataGridView.Columns.Add("PostCategory", "🟢 Category")
        dataGridView.Columns.Add("PostDomain", "🌐 Domain")
        dataGridView.Columns.Add("PostPermalink", "🔗 Permalink")
        dataGridView.Columns.Add("PostCreatedAt", "📅 Created At")
        dataGridView.Columns.Add("PostApprovedAt", "📅 Approved At")
        dataGridView.Columns.Add("PostApprovedBy", "👤 Approved By")
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
