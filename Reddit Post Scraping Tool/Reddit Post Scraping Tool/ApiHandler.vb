Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ApiHandler
    Public logfile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedditPostScrapingTool", "logs", $"debug.log")
    Public headers As String = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.1.2 Safari/605.1.15"
    Public UpdatesEndpoint As String = "https://api.github.com/repos/bellingcat/reddit-post-scraping-tool/releases/latest"

    Public Function ScrapeReddit(subreddit, listing, limit, timeframe) As JObject
        Dim ApiEndpoint As String = $"https://reddit.com/r/{subreddit}/{listing}.json?limit={limit}&t={timeframe}').json()"
        Try
            Dim httpClient As New HttpClient()
            httpClient.DefaultRequestHeaders.Add("User-Agent", headers)
            Dim response As HttpResponseMessage = httpClient.GetAsync(ApiEndpoint).Result
            If response.IsSuccessStatusCode Then
                Dim json As String = response.Content.ReadAsStringAsync().Result
                Dim data As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
                Return data
            Else
                ' handle the case when the response status is not successful
                ' return an empty JObject or throw an exception
                Return New JObject()
                MessageBox.Show(response.ReasonPhrase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' handle the exception
            ' return an empty JObject or throw an exception
            Return New JObject()
            My.Computer.FileSystem.WriteAllText(logfile, $"{DateTime.Now}: {ex}{Environment.NewLine}", True)
            MessageBox.Show($"{ex.Message}. Please see the debug log '{logfile}' for more information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return New JObject()
    End Function


    ' Gets remote version information from the repository release page
    Public Function CheckUpdates() As JObject
        Try
            Dim httpClient As New HttpClient()
            httpClient.DefaultRequestHeaders.Add("User-Agent", headers)
            Dim response As HttpResponseMessage = httpClient.GetAsync(UpdatesEndpoint).Result
            If response.IsSuccessStatusCode Then
                Dim json As String = response.Content.ReadAsStringAsync().Result
                Dim data As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
                Return data
            Else
                'Return New JObject()
                MessageBox.Show(response.ReasonPhrase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            'Return New JObject()
            My.Computer.FileSystem.WriteAllText(logfile, $"{DateTime.Now}: {ex}{Environment.NewLine}", True)
            MessageBox.Show($"{ex.Message}. Please see the debug log '{logfile}' for more information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return New JObject()
    End Function
End Class
