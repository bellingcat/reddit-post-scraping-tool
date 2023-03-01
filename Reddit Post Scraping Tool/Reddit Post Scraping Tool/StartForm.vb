Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class StartForm

    ' Create the program's directory
    ' We will store information about the user and current machine in it
    Public LicenseText As String = "MIT License

Copyright (c) 2023 Richard Mwewa

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE."
    Private Sub PathFinder()
        Dim directoryPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedditPostScrapingTool", "logs")

        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        Else
            ' DO NOTHING
        End If
    End Sub


    Private Sub LicenseNotice()
        MessageBox.Show(LicenseText, "License", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    ' Create a file in C:\Users\<username>\AppData\Roaming\RedditPostScrapingTool, this will be used to determine
    ' Whether the program has been run before
    ' If it has not been run before, display the license notice
    Private Sub LogFirstTimeLaunch()
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedditPostScrapingTool", "logs", "first_launch.log")
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


    ' Check the current time
    ' add a dark background to the program if it's evening
    ' This is my way of implementing auto dark-mode (you could help if you know a better way :) )
    Private Sub DarkModeProperties()
        Dim currentHour As Integer = DateTime.Now.Hour
        If currentHour >= 6 And currentHour < 18 Then
            Me.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")

            ToolsToolStripMenuTools.ForeColor = ColorTranslator.FromHtml("#FF121212")
            KeywordTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            KeywordTextBox.ForeColor = ColorTranslator.FromHtml("#FF121212")

            SubredditTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            SubredditTextBox.ForeColor = ColorTranslator.FromHtml("#FF121212")

            LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FF121212")

            LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FF121212")

            ListingComboBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            ListingComboBox.ForeColor = ColorTranslator.FromHtml("#FF121212")

            TimeframeComboBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            TimeframeComboBox.ForeColor = ColorTranslator.FromHtml("#FF121212")

            Label1.ForeColor = ColorTranslator.FromHtml("#FF121212")
            Label2.ForeColor = ColorTranslator.FromHtml("#FF121212")
            Label3.ForeColor = ColorTranslator.FromHtml("#FF121212")
            Label4.ForeColor = ColorTranslator.FromHtml("#FF121212")
            Label5.ForeColor = ColorTranslator.FromHtml("#FF121212")
        Else
            Me.BackColor = ColorTranslator.FromHtml("#FF121212")

            ToolsToolStripMenuTools.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            KeywordTextBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            KeywordTextBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")

            SubredditTextBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            SubredditTextBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")

            LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")

            ListingComboBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            ListingComboBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")

            TimeframeComboBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            TimeframeComboBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")

            Label1.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            Label2.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            Label3.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            Label4.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            Label5.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
        End If
    End Sub


    Private Sub ScrapeButton_Click(sender As Object, e As EventArgs) Handles ScrapeButton.Click
        Dim ApiHandler As New ApiHandler
        Dim Keyword As String = KeywordTextBox.Text
        Dim Subreddit As String = SubredditTextBox.Text
        Dim Listing As String = ListingComboBox.Text.ToLower()
        Dim Limit As Integer = LimitNumericUpDown.Value
        Dim Timeframe As String = TimeframeComboBox.Text.ToLower()
        Dim FoundPosts As Integer = 0
        Dim TotalPosts As Integer = 0

        ' Clear the Columns and Rows before adding Items to them 
        PostsForm.DataGridViewPosts.Rows.Clear()
        PostsForm.DataGridViewPosts.Columns.Clear()

        PostsForm.DataGridViewPosts.Columns.Add("PostCount", "Post Number")
        PostsForm.DataGridViewPosts.Columns.Add("PostAuthor", "Author")
        PostsForm.DataGridViewPosts.Columns.Add("PostID", "ID")
        PostsForm.DataGridViewPosts.Columns.Add("PostSubreddit", "Subreddit")
        PostsForm.DataGridViewPosts.Columns.Add("SubredditVisibility", "Subreddit Visibility")
        PostsForm.DataGridViewPosts.Columns.Add("PostThumbnail", "Thumbnail")
        PostsForm.DataGridViewPosts.Columns.Add("PostIsNSFW", "NSFW")
        PostsForm.DataGridViewPosts.Columns.Add("PostIsGilded", "Gilded")
        PostsForm.DataGridViewPosts.Columns.Add("PostUpvotes", "Upvotes")
        PostsForm.DataGridViewPosts.Columns.Add("PostUpvoteRatio", "Upvote Ratio")
        PostsForm.DataGridViewPosts.Columns.Add("PostDownvotes", "Downvotes")
        PostsForm.DataGridViewPosts.Columns.Add("PostAwards", "Awards")
        PostsForm.DataGridViewPosts.Columns.Add("PostTopAward", "Top Award")
        PostsForm.DataGridViewPosts.Columns.Add("PostIsCrosspostable", "Is Crosspostable?")
        PostsForm.DataGridViewPosts.Columns.Add("PostScore", "Score")
        PostsForm.DataGridViewPosts.Columns.Add("PostText", "Text")
        PostsForm.DataGridViewPosts.Columns.Add("PostCategory", "Category")
        PostsForm.DataGridViewPosts.Columns.Add("PostDomain", "Domain")
        PostsForm.DataGridViewPosts.Columns.Add("PostPermalink", "Permalink")
        PostsForm.DataGridViewPosts.Columns.Add("PostCreatedAt", "Created At")
        PostsForm.DataGridViewPosts.Columns.Add("PostApprovedAt", "Approved At")
        PostsForm.DataGridViewPosts.Columns.Add("PostApprovedBy", "Approved By")

        If Limit > 100 Then
            MessageBox.Show("Limit should not be over 100. Defaulting to 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Listing = "" Then
            Listing = "top"
        End If

        If Timeframe = "" Then
            Timeframe = "all"
        End If

        If Keyword = "" Then
            MessageBox.Show("Keyword should not be emtpy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Subreddit = "" Then
            MessageBox.Show("Subreddit should not be emtpy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            PostsForm.Text = $"Reddit Post Scraping Tool - {Keyword}"
            Dim Posts As JObject = ApiHandler.ScrapeReddit(Subreddit, Listing, Limit, Timeframe)
            For Each Post In Posts("data")("children")
                TotalPosts += 1
                If Post("data")("selftext").ToString.ToLower().Contains(KeywordTextBox.Text.ToLower()) Then
                    FoundPosts += 1
                    PostsForm.DataGridViewPosts.Rows.Add(TotalPosts, Post("data")("author"), Post("data")("id"), Post("data")("subreddit_name_prefixed"),
                                                                 Post("data")("subreddit_type"), Post("data")("thumbnail"), Post("data")("over_18"), Post("data")("gilded"),
                                                                 Post("data")("ups"), Post("data")("upvote_ratio"), Post("data")("downs"), Post("data")("total_awards_received"),
                                                                 Post("data")("top_awarded_type"), Post("data")("is_crosspostable"), Post("data")("score"), Post("data")("selftext"),
                                                                 Post("data")("category"), Post("data")("domain"), Post("data")("permalink"), Post("data")("created"),
                                                                 Post("data")("approved_at_utc"), Post("data")("approved_by"))
                End If
            Next

            'Don't show the results form if found posts are not greater than 0
            If FoundPosts > 0 Then
                MessageBox.Show($"Keyword `{Keyword}` was found in {FoundPosts}/" + Posts("data")("children").Count.ToString _
                                   + $" {Listing} posts from r/{Subreddit}", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PostsForm.Show()
            Else
                MessageBox.Show($"Keyword `{Keyword}` was not found in either one of the  " + Posts("data")("children").Count.ToString _
                                    + $" {Listing} posts from r/{Subreddit}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


            If JSONToolStripMenuItem.Checked Then
                Dim saveFileDialog As New SaveFileDialog()

                saveFileDialog.Filter = "JSON files (*.json)|*.json"
                saveFileDialog.Title = "Save posts to JSON"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim fileName As String = saveFileDialog.FileName
                    Dim serializerSettings As New JsonSerializerSettings()
                    serializerSettings.Formatting = Formatting.Indented
                    Dim json As String = JsonConvert.SerializeObject(Posts("data"), serializerSettings)

                    System.IO.File.WriteAllText(fileName, json)

                    MessageBox.Show($"Results saved to {fileName} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    ' StartForm load event
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PathFinder()
        LogFirstTimeLaunch()
        DarkModeProperties()
        ToolsToolStripMenuTools.Text = Environment.UserName
        Me.Text = $"{My.Application.Info.AssemblyName} v{My.Application.Info.Version}"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("This will close the program, continue?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperToolStripMenuItem.Click
        DeveloperForm.ShowDialog()
    End Sub

    Private Sub ChekUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChekUpdatesToolStripMenuItem.Click
        Dim ApiHandler As New ApiHandler()
        Dim data As JObject = ApiHandler.CheckUpdates()
        If data("tag_name").ToString = $"{My.Application.Info.Version}" Then
            MessageBox.Show($"You're running the current version v{My.Application.Info.Version} of {My.Application.Info.ProductName}. Check again soon! :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim confirm As DialogResult = MessageBox.Show($"A new version v{data("tag_name")} of {My.Application.Info.ProductName} is availble, would you like to get it?

What's new in v{data("tag_name")}?
{data("body")}
", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                Shell($"cmd /c start https://github.com/bellingcat/reddit-post-scraping-tool/releases/tag/{data("tag_name")}")
            End If
        End If

    End Sub

    Private Sub ToolsToolStripMenuTools_Click(sender As Object, e As EventArgs) Handles ToolsToolStripMenuTools.Click
        ToolsToolStripMenuTools.ForeColor = ColorTranslator.FromHtml("#FF121212")
    End Sub

    Private Sub ToolsToolStripMenuTools_DropDownClosed(sender As Object, e As EventArgs) Handles ToolsToolStripMenuTools.DropDownClosed
        ToolsToolStripMenuTools.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
    End Sub

End Class
