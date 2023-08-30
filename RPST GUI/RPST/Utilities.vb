Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Utilities

    ''' <summary>
    ''' Checks for the existence of the 'logs' directory under the 'RPST' directory within the user's AppData\Roaming folder. 
    ''' If the directory does not exist, it creates one.
    ''' </summary>
    ''' <remarks>
    ''' The directory path is 'C:\Users\<username>\AppData\Roaming\RPST\logs'.
    ''' If the 'RPST' or 'logs' directories do not exist, the function will create them.
    ''' If the directories already exist, the function will not perform any actions.
    ''' </remarks>
    Public Shared Sub PathFinder()
        Dim directoryPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RPST", "logs")

        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
    End Sub


    ''' <summary>
    ''' Collects and validates user inputs from StartForm and returns them as a Tuple.
    ''' </summary>
    ''' <returns>
    ''' Tuple containing:
    ''' Keyword (String) - Keyword entered by user in theFormMain.
    ''' Subreddit (String) - Subreddit entered by user in theFormMain.
    ''' Listing (String) - Listing chosen by user in the StartForm, defaults to 'top' if none is selected.
    ''' Limit (Integer) - Limit entered by user in the StartForm, defaults to 10 if the entered value is over 100.
    ''' Timeframe (String) - Timeframe chosen by user in the StartForm, defaults to 'all' if none is selected.
    ''' </returns>
    ''' <remarks>
    ''' If keyword or subreddit are empty, Displays a warning and returns nothing.
    ''' </remarks>
    Public Shared Function CollectInputs() As (Keyword As String, Subreddit As String, Listing As String, Limit As Integer, Timeframe As String)?
        Dim keyword As String = FormMain.TextBoxKeyword.Text.Trim()
        Dim subreddit As String = FormMain.TextBoxSubreddit.Text.Trim()
        ''' <summary>
        ''' Convert the Listing and Subreddit to lowercase using InvariantCulture.
        ''' <summary>
        Dim listing As String = If(String.IsNullOrEmpty(FormMain.ComboBoxListing.Text), "top", FormMain.ComboBoxListing.Text.ToLower(Globalization.CultureInfo.InvariantCulture).Trim())
        Dim timeframe As String = If(String.IsNullOrEmpty(FormMain.ComboBoxTimeframe.Text), "all", FormMain.ComboBoxTimeframe.Text.ToLower(Globalization.CultureInfo.InvariantCulture).Trim())
        Dim limit As Integer = FormMain.NumericUpDownLimit.Value

        ''' <summary>
        ''' Validate inputs.
        ''' <summary>
        If String.IsNullOrEmpty(keyword) AndAlso String.IsNullOrEmpty(subreddit) Then
            MessageBox.Show("Keyword and Subreddit should not be empty.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        ElseIf String.IsNullOrEmpty(keyword) Then
            MessageBox.Show("Keyword field should not be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        ElseIf String.IsNullOrEmpty(subreddit) Then
            MessageBox.Show("Subreddit field should not be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If
        Return (keyword, subreddit, listing, limit, timeframe)
    End Function


    ''' <summary>
    ''' Saves the gives posts' data to a JSON file.
    ''' </summary>
    ''' <param name="Posts">The object containing posts to be saved.</param>
    ''' <remarks>
    ''' This function allows the user to select a location to save the posts. 
    ''' If the user confirms the save location, the posts will be serialized 
    ''' to JSON with an indented format and written to the chosen file. 
    ''' A success message will be displayed to the user upon successful save.
    ''' </remarks>
    Public Shared Sub SavePostsToJson(Posts As Object)
        Dim saveFileDialog As New SaveFileDialog With {
                    .Filter = "JSON files (*.json)|*.json",
                    .Title = "Save posts to JSON"
                }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog.FileName
            Dim serializerSettings As New JsonSerializerSettings With {
                .Formatting = Formatting.Indented
            }
            Dim json As String = JsonConvert.SerializeObject(Posts, serializerSettings)

            File.WriteAllText(fileName, json)

            MessageBox.Show($"Posts saved to {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    ''' <summary>
    ''' Saves Reddit posts contained in a JArray to a CSV file.
    ''' </summary>
    ''' <param name="posts">A JArray containing the Reddit posts to be saved.</param>
    ''' <remarks>
    ''' This function displays a SaveFileDialog to allow the user to specify the file name and location.
    ''' It then iterates through the JArray to write each post's details (totalPosts, title, subreddit, author, score) into the selected CSV file.
    ''' </remarks>
    Public Shared Sub SavePostsToCSV(posts As JArray)
        Dim saveFileDialog As New SaveFileDialog With {
        .Filter = "CSV files (*.csv)|*.csv",
        .Title = "Save posts to CSV"
    }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog.FileName
            Using csvWriter As New StreamWriter(fileName)
                ''' <summary>
                ''' Write the header.
                ''' <summary>
                csvWriter.WriteLine("Index,Author,ID,Subreddit,Visibility,Thumbnail,NSFW,Gilded,Upvotes,Upvote Ratio,Downvotes,Award,Top Award,Is cross-postable?,Score,Category,Text,Domain,Permalink,Created At,Approved At,Approved By")

                Dim postCount As Integer = 0
                For Each post In posts
                    postCount += 1
                    csvWriter.WriteLine($"{postCount},{post("data")("author")},{post("data")("id")},{post("data")("subreddit_name_prefixed")},{post("data")("subreddit_type")},{post("data")("thumbnail")},{post("data")("over_18")},{post("data")("gilded")},{post("data")("ups")},{post("data")("upvote_ratio")},{post("data")("downs")},{post("data")("total_awards_received")},{post("data")("top_awarded_type")},{post("data")("is_crosspostable")},{post("data")("score")},{post("data")("category")},{post("data")("selftext")},{post("data")("domain")},{post("data")("permalink")},{post("data")("created")},{post("data")("approved_at_utc")},{post("data")("approved_by")}")
                Next
            End Using

            MessageBox.Show($"Posts saved to {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    ''' <summary>
    ''' Shows the license notice in a messagebox.
    ''' </summary>
    ''' <remarks>
    ''' The license text is retrieved from the AboutBox.LicenseText property.
    ''' The messagebox is displayed with the title "License" and an information icon.
    ''' </remarks>
    Public Shared Sub LicenseNotice()
        MessageBox.Show(AboutBox.LicenseText, "License", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    ''' <summary>
    ''' Checks if the "first-launch.log" file exists in the directory: C:\Users\<username>\AppData\Roaming\RedditPostScrapingTool\logs.
    ''' If the file doesn't exist, it creates one. This file is used to determine whether the program has been run before.
    ''' If the program is being run for the first time, a license notice will be displayed.
    ''' </summary>
    Public Shared Sub LogFirstTimeLaunch()
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RPST", "logs", "first-launch.log")
        Dim textToWrite As String = $"
{My.Application.Info.AssemblyName}
-------------------------


User: {Environment.UserName}
Host: {Environment.MachineName}
OS: {Environment.OSVersion}
x64: {Environment.Is64BitOperatingSystem}
First launched on: {DateTime.Now}"
        If Not File.Exists(filePath) Then
            LicenseNotice()
            File.WriteAllText(filePath, textToWrite)
        Else
        End If
    End Sub
End Class
