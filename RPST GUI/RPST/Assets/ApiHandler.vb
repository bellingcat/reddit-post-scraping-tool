﻿Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

''' <summary>
''' Handles requests to Reddit and Github APIs.
''' </summary>
Public Class ApiHandler
    Public Property LogFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedditPostScrapingTool", "logs", $"debug.log")
    Public Property Headers As String = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.1.2 Safari/605.1.15"
    Public Property UpdatesEndpoint As String = "https://api.github.com/repos/bellingcat/reddit-post-scraping-tool/releases/latest"

    ''' <summary>
    ''' Asyncrosnously scrape Reddit data.
    ''' </summary>
    ''' <returns>Json object containing scraped data.</returns>
    Public Async Function AsyncGetPosts(subreddit As String, listing As String, limit As Integer, timeframe As String) As Task(Of JArray)
        Dim PostsEndpoint As String = $"https://www.reddit.com/r/{subreddit}/{listing}.json?limit={limit}&t={timeframe}"
        Return Await PaginatedPosts(endpoint:=PostsEndpoint, limit:=limit)
    End Function

    ''' <summary>
    ''' Retrieves posts in a paginated manner until the specified limit is reached.
    ''' </summary>
    ''' <param name="endpoint">The API endpoint for retrieving posts.</param>
    ''' <param name="limit">The limit on the number of posts to retrieve.</param>
    ''' <returns>A Task(Of JArray) representing the asynchronous operation, which upon completion returns a JArray of posts.</returns>
    Private Async Function PaginatedPosts(endpoint As String, limit As Integer) As Task(Of JArray)
        Dim allPosts As New JArray()
        Dim lastPostId As String = ""
        Dim useAfter As Boolean = limit > 100

        While allPosts.Count < limit
            Dim endpointWithAfter As String = If(useAfter And Not String.IsNullOrEmpty(lastPostId), $"{endpoint}&after={lastPostId}", endpoint)
            Dim postsData As JObject = Await AsyncGetData(endpoint:=endpointWithAfter)
            Dim postsChildren As JArray = postsData("data")("children")

            If postsChildren.Count = 0 Then
                Exit While
            End If

            allPosts.Merge(postsChildren)

            lastPostId = postsChildren.Last("data")("id").ToString()
        End While

        Return allPosts
    End Function


    ''' <summary>
    ''' Asyncrosnously gets remote version information from the repository release page.
    ''' </summary>
    ''' <returns>Json object containing update data.</returns>
    Public Async Function CheckUpdatesAsync() As Task(Of JObject)
        Return Await AsyncGetData(endpoint:=UpdatesEndpoint)
    End Function

    ''' <summary>
    ''' Asyncronously retrieves a JObject from the specified endpoint.
    ''' </summary>
    ''' <param name="endpoint">The URL endpoint to retrieve data from.</param>
    ''' <returns>A JObject containing the retrieved data.</returns>
    Private Async Function AsyncGetData(endpoint As String) As Task(Of JObject)
        Try
            Using httpClient As New HttpClient()
                httpClient.DefaultRequestHeaders.Add("User-Agent", Headers)
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(endpoint)
                If response.IsSuccessStatusCode Then
                    Dim json As String = response.Content.ReadAsStringAsync().Result
                    Dim data As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
                    Return data
                Else
                    MessageBox.Show(response.ReasonPhrase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(LogFile, $"{DateTime.Now}: {ex}{Environment.NewLine}", True)
            MessageBox.Show($"{ex.Message}. Please see the debug log '{LogFile}' for more information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return New JObject()
    End Function
End Class
