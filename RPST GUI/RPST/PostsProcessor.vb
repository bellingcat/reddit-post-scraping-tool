Imports Newtonsoft.Json.Linq

Public Class PostsProcessor
    Private ReadOnly ApiHandler As New ApiHandler

    ''' <summary>
    ''' Asyncronously fetches Reddit posts based on the given parameters and returns them as a JObject.
    ''' </summary>
    ''' <param name="subreddit">The subreddit to fetch posts from.</param>
    ''' <param name="listing">The type of listing (e.g., "new", "top", etc.).</param>
    ''' <param name="limit">The maximum number of posts to fetch.</param>
    ''' <param name="timeframe">The timeframe to consider for the posts (e.g., "day", "week", "month", "year", "all").</param>
    ''' <returns>A JObject containing the fetched Reddit posts.</returns>
    Public Async Function FetchPostsAsync(subreddit As String, listing As String, limit As Integer, timeframe As String) As Task(Of JObject)
        Dim posts As JObject = Await ApiHandler.ScrapeRedditAsync(subreddit, listing, limit, timeframe)
        Return posts
    End Function

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
            ' Initialize the DataGridView.
            DataGridViewHandler.AddColumn(FormPosts.DataGridViewPosts)

            ' Fetch Reddit posts based on the inputs.
            Dim processor As New PostsProcessor()
            Dim posts As JObject = Await processor.FetchPostsAsync(subreddit:=inputs.Value.Subreddit, listing:=inputs.Value.Listing, limit:=inputs.Value.Limit, timeframe:=inputs.Value.Timeframe)
            Dim totalPosts As Integer = 0
            Dim keywordFound As Boolean = False
            Dim foundPosts As Integer = 0
            Dim foundPostsList As New JArray

            ' Iterate over each post.
            For Each post In posts("data")("children")
                totalPosts += 1
                ' Check if the post contains the keyword
                If PostsProcessor.PostContainsKeyword(post, inputs.Value.Keyword.ToLower(Globalization.CultureInfo.InvariantCulture)) Then
                    foundPosts += 1
                    foundPostsList.Add(post)
                    ' Add the post to the DataGridView.
                    DataGridViewHandler.AddRow(FormPosts.DataGridViewPosts, post, totalPosts)
                    FormPosts.Show()
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
