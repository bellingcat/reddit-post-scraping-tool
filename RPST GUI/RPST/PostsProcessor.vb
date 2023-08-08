Imports Newtonsoft.Json.Linq

Public Class PostsProcessor
    Private ReadOnly ApiHandler As New ApiHandler

    ''' <summary>
    ''' Fetches Reddit posts based on the given parameters and returns them as a JObject.
    ''' </summary>
    ''' <param name="subreddit">The subreddit to fetch posts from.</param>
    ''' <param name="listing">The type of listing (e.g., "new", "top", etc.).</param>
    ''' <param name="limit">The maximum number of posts to fetch.</param>
    ''' <param name="timeframe">The timeframe to consider for the posts (e.g., "day", "week", "month", "year", "all").</param>
    ''' <returns>A JObject containing the fetched Reddit posts.</returns>
    Public Function FetchPosts(subreddit As String, listing As String, limit As Integer, timeframe As String) As JObject
        Dim posts As JObject = ApiHandler.ScrapeReddit(subreddit, listing, limit, timeframe)
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

End Class
