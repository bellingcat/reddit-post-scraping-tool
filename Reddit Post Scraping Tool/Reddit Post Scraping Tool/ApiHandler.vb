Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ApiHandler
    Public headers As String = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.1.2 Safari/605.1.15"
    Public Function ScrapeReddit(subreddit, listing, limit, timeframe) As JObject
        Try
            Dim ApiEndpoint As String = $"https://reddit.com/r/{subreddit}/{listing}.json?limit={limit}&t={timeframe}').json()"
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
            Dim logfile As String = "debuglog.txt"
            My.Computer.FileSystem.WriteAllText(logfile, DateTime.Now.ToString() + ": " + ex.ToString() & Environment.NewLine, True)
            MessageBox.Show(ex.Message + $". Please see the debug log file '{logfile}' for more information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return New JObject()
    End Function
End Class
