﻿Imports Newtonsoft.Json.Linq

Public Class PostsProcessor
    Private Shared ReadOnly ApiHandler As New ApiHandler()

    ''' <summary>
    ''' Checks if the given Reddit post contains the given keyword in its text.
    ''' </summary>
    ''' <param name="post">The Reddit post to check.</param>
    ''' <param name="keyword">The keyword to check for.</param>
    ''' <returns>True if the post contains the keyword, False otherwise.</returns>
    Public Shared Function PostContainsKeyword(post As JObject, keyword As String) As Boolean
        Return post("data")("selftext").ToString.ToLower(Globalization.CultureInfo.InvariantCulture).Contains(keyword.ToLower(System.Globalization.CultureInfo.InvariantCulture))
    End Function


    ''' <summary>
    ''' Collects user inputs, fetches Reddit posts based on the inputs, checks if posts contain the keyword, and saves posts to a JSON file if necessary.
    ''' </summary>
    ''' <param name="JSONToolStripMenuItem">Indicates whether to save the posts to a JSON file.</param>
    ''' <remarks>
    ''' This function initializes the DataGridView, iterates over each post, adds the posts containing the keyword to the DataGridView and updates the UI.
    ''' It also shows a message if the keyword was not found in any of the posts or if the inputs are empty.
    ''' </remarks>
    Public Shared Async Sub ProcessRedditPosts(settings)
        ' Collect inputs from the user.
        Dim inputs = Utilities.CollectInputs()

        If inputs.HasValue Then
            ' Fetch Reddit posts based on the inputs.
            Dim processor As New PostsProcessor()
            Dim posts As JArray = Await ApiHandler.AsyncGetPosts(subreddit:=inputs.Value.Subreddit, listing:=inputs.Value.Listing, limit:=inputs.Value.Limit, timeframe:=inputs.Value.Timeframe)
            Dim totalPosts As Integer = 0
            Dim keywordFound As Boolean = False
            Dim foundPosts As Integer = 0
            Dim foundPostsList As New JArray

            PostsWindow.DataGridViewPosts.Rows.Clear()
            PostsWindow.DataGridViewPosts.Columns.Clear()

            PostsWindow.DataGridViewPosts.Columns.Add("PostCount", "Index")
            PostsWindow.DataGridViewPosts.Columns.Add("PostAuthor", "Author")
            PostsWindow.DataGridViewPosts.Columns.Add("PostID", "ID")
            PostsWindow.DataGridViewPosts.Columns.Add("PostTitle", "Title")
            PostsWindow.DataGridViewPosts.Columns.Add("PostText", "Text")
            PostsWindow.DataGridViewPosts.Columns.Add("PostSubreddit", "Subreddit")
            PostsWindow.DataGridViewPosts.Columns.Add("SubredditVisibility", "Subreddit Type")
            PostsWindow.DataGridViewPosts.Columns.Add("PostThumbnail", "Thumbnail")
            PostsWindow.DataGridViewPosts.Columns.Add("PostIsNSFW", "NSFW")
            PostsWindow.DataGridViewPosts.Columns.Add("PostIsGilded", "Is Gilded")
            PostsWindow.DataGridViewPosts.Columns.Add("PostUpvotes", "Upvotes")
            PostsWindow.DataGridViewPosts.Columns.Add("PostUpvoteRatio", "Upvote Ratio")
            PostsWindow.DataGridViewPosts.Columns.Add("PostDownvotes", "Downvotes")
            PostsWindow.DataGridViewPosts.Columns.Add("PostIsCrosspostable", "↪️ Is Shareable")
            PostsWindow.DataGridViewPosts.Columns.Add("PostScore", "Score")
            PostsWindow.DataGridViewPosts.Columns.Add("PostCategory", "Category")
            PostsWindow.DataGridViewPosts.Columns.Add("PostDomain", "Domain")
            PostsWindow.DataGridViewPosts.Columns.Add("PostPermalink", "Permalink")
            PostsWindow.DataGridViewPosts.Columns.Add("PostCreatedAt", "Created At")

            ' Iterate over each post.
            For Each post In posts
                totalPosts += 1
                ' Check if the post contains the keyword
                If PostsProcessor.PostContainsKeyword(post, inputs.Value.Keyword.ToLower(Globalization.CultureInfo.InvariantCulture)) Then
                    foundPosts += 1
                    foundPostsList.Add(post)

                    PostsWindow.DataGridViewPosts.Rows.Add(totalPosts,
                              post("data")("author"),
                              post("data")("id"),
                              post("data")("title"),
                              post("data")("selftext"),
                              post("data")("subreddit_name_prefixed"),
                              post("data")("subreddit_type"),
                              post("data")("thumbnail"),
                              post("data")("over_18"),
                              post("data")("gilded"),
                              post("data")("ups"),
                              post("data")("upvote_ratio"),
                              post("data")("downs"),
                              post("data")("is_crosspostable"),
                              post("data")("score"),
                              post("data")("category"),
                              post("data")("domain"),
                              post("data")("permalink"),
                              post("data")("created"))

                    PostsWindow.Text = $"Showing {foundPosts}/{inputs.Value.Limit} {inputs.Value.Listing} posts containing the word {inputs.Value.Keyword}, from r/{inputs.Value.Subreddit}"
                    PostsWindow.Show()
                    keywordFound = True
                End If
            Next

            ' Check if the keyword was found in any posts
            If Not keywordFound Then
                MessageBox.Show($"Keyword `{inputs.Value.Keyword}` was not found in any of the " + posts("data")("children").Count.ToString(Globalization.CultureInfo.InvariantCulture) _
                                + $" {inputs.Value.Listing} posts from r/{inputs.Value.Subreddit}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


            If settings.SaveToJson Then
                ' Save posts to a JSON file if SaveToJson is True.
                Utilities.SavePostsToJson(posts:=foundPostsList)
            End If

            If settings.SaveToCsv Then
                ' Save posts to a CSV file if SaveToCsv is True.
                Utilities.SavePostsToCSV(posts:=foundPostsList)
            End If
        Else
        End If
    End Sub

End Class
