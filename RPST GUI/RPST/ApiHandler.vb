Imports System.IO
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
    Public Async Function ScrapeRedditAsync(subreddit As String, listing As String, limit As Integer, timeframe As String) As Task(Of JObject)
        Dim ApiEndpoint As String = $"https://reddit.com/r/{subreddit}/{listing}.json?limit={limit}&t={timeframe}"
        Return Await GetJObjectFromEndpointAsync(endpoint:=ApiEndpoint)
    End Function

    ''' <summary>
    ''' Asyncrosnously gets remote version information from the repository release page.
    ''' </summary>
    ''' <returns>Json object containing update data.</returns>
    Public Async Function CheckUpdatesAsync() As Task(Of JObject)
        Return Await GetJObjectFromEndpointAsync(endpoint:=UpdatesEndpoint)
    End Function

    ''' <summary>
    ''' Asyncronously retrieves a JObject from the specified endpoint.
    ''' </summary>
    ''' <param name="endpoint">The URL endpoint to retrieve data from.</param>
    ''' <returns>A JObject containing the retrieved data.</returns>
    Private Async Function GetJObjectFromEndpointAsync(endpoint As String) As Task(Of JObject)
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
