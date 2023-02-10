Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class StartForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ApiHandler As New ApiHandler
        Dim Keyword As String = KeywordTextBox.Text
        Dim Subreddit As String = SubredditTextBox.Text
        Dim Listing As String = ListingComboBox.Text.ToLower()
        Dim Limit As String = LimitTextBox.Text
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

        If Limit = "" Then
            Limit = "10"
        ElseIf Limit > 100 Then
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
            MessageBox.Show($"Keyword `{Keyword}` was found in {FoundPosts}/" + Posts("data")("children").Count.ToString _
                                    + $" {Listing} posts from r/{Subreddit}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PostsForm.Show()
            If SaveResultsJsonToolStripMenuItem.Checked Then
                Dim saveFileDialog As New SaveFileDialog()

                saveFileDialog.Filter = "JSON files (*.json)|*.json"
                saveFileDialog.Title = "Save JSON File"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim fileName As String = saveFileDialog.FileName
                    Dim serializerSettings As New JsonSerializerSettings()
                    serializerSettings.Formatting = Formatting.Indented
                    Dim json As String = JsonConvert.SerializeObject(Posts("data")("children")(0), serializerSettings)

                    System.IO.File.WriteAllText(fileName, json)

                    MessageBox.Show($"Results saved to {fileName} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItemExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemExit.Click
        Dim result As DialogResult = MessageBox.Show("This will close the program, continue?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"Reddit Post Scraping Tool v{My.Application.Info.Version.ToString}"
    End Sub
End Class
