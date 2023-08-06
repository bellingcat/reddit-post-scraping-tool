Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Utilities
    ''' <summary>
    ''' Collects user inputs, fetches Reddit posts based on the inputs, checks if posts contain the keyword, and saves posts to a JSON file if necessary.
    ''' </summary>
    ''' <param name="JSONToolStripMenuItem">Indicates whether to save the posts to a JSON file.</param>
    ''' <remarks>
    ''' This function initializes the DataGridView, iterates over each post, adds the posts containing the keyword to the DataGridView and updates the UI.
    ''' It also shows a message if the keyword was not found in any of the posts or if the inputs are empty.
    ''' </remarks>
    Public Shared Sub ProcessRedditPosts(JSONToolStripMenuItem As ToolStripMenuItem)
        ' Collect inputs from the user
        Dim inputs = CollectInputs()

        If inputs.HasValue Then
            ' Initialize the DataGridView
            DataGridViewHandler.AddColumn(PostsForm.DataGridViewPosts)

            ' Fetch Reddit posts based on the inputs
            Dim processor As New PostsProcessor()
            Dim posts As JObject = processor.FetchPosts(inputs.Value.Subreddit, inputs.Value.Listing, inputs.Value.Limit, inputs.Value.Timeframe)
            Dim totalPosts As Integer = 0
            Dim keywordFound As Boolean = False

            ' Iterate over each post
            For Each post In posts("data")("children")
                totalPosts += 1
                ' Check if the post contains the keyword
                If PostsProcessor.PostContainsKeyword(post, inputs.Value.Keyword.ToLower(System.Globalization.CultureInfo.InvariantCulture)) Then
                    ' Add the post to the DataGridView
                    DataGridViewHandler.AddRow(PostsForm.DataGridViewPosts, post, totalPosts)
                    PostsForm.Show()
                    keywordFound = True
                End If
            Next

            ' Check if the keyword was found in any posts
            If Not keywordFound Then
                MessageBox.Show($"Keyword `{inputs.Value.Keyword}` was not found in any of the " + posts("data")("children").Count.ToString(System.Globalization.CultureInfo.InvariantCulture) _
                                + $" {inputs.Value.Listing} posts from r/{inputs.Value.Subreddit}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            If JSONToolStripMenuItem.Checked Then
                ' Save posts to a JSON file if the JSONToolStripMenuItem is checked
                Utilities.SavePostsToJson(posts("data"))
            End If
        Else
            MessageBox.Show("Inputs cannot be empty. Please enter a keyword and a subreddit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


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
    ''' Keyword (String) - Keyword entered by user in the StartForm.
    ''' Subreddit (String) - Subreddit entered by user in the StartForm.
    ''' Listing (String) - Listing chosen by user in the StartForm, defaults to 'top' if none is selected.
    ''' Limit (Integer) - Limit entered by user in the StartForm, defaults to 10 if the entered value is over 100.
    ''' Timeframe (String) - Timeframe chosen by user in the StartForm, defaults to 'all' if none is selected.
    ''' </returns>
    ''' <remarks>
    ''' If keyword or subreddit are empty, Displays a warning and returns nothing.
    ''' </remarks>
    Public Shared Function CollectInputs() As (Keyword As String, Subreddit As String, Listing As String, Limit As Integer, Timeframe As String)?
        Dim keyword As String = StartForm.KeywordTextBox.Text.Trim()
        Dim subreddit As String = StartForm.SubredditTextBox.Text.Trim()
        ' Convert the Keyword and Subreddit to lowercase using InvariantCulture
        Dim listing As String = If(String.IsNullOrEmpty(StartForm.ListingComboBox.Text), "top", StartForm.ListingComboBox.Text.ToLower(System.Globalization.CultureInfo.InvariantCulture).Trim())
        Dim limit As Integer = StartForm.LimitNumericUpDown.Value
        Dim timeframe As String = If(String.IsNullOrEmpty(StartForm.TimeframeComboBox.Text), "all", StartForm.TimeframeComboBox.Text.ToLower(System.Globalization.CultureInfo.InvariantCulture).Trim())

        ' Validate inputs
        If String.IsNullOrEmpty(keyword) Then
            MessageBox.Show("Keyword should not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If
        If String.IsNullOrEmpty(subreddit) Then
            MessageBox.Show("Subreddit should not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If
        If limit > 100 Then
            MessageBox.Show("Limit should not be over 100. Defaulting to 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            limit = 10
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
            ' DO NOTHING
        End If
    End Sub
End Class
