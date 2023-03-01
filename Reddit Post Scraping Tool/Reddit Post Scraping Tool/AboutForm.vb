Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DescriptionLabel.Text = "Given a subreddit name and a keyword,
Reddit Post Scraping Tool returns all top posts
(by default) that contain the specified keyword."
        VersionLabel.Text = $"v{My.Application.Info.Version}"
        LicenseRichTextBox.Text = StartForm.LicenseText
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WikiLinkLabel.LinkClicked
        Shell("cmd /c start https://github.com/bellingcat/reddit-post-scraping-tool/wiki")
    End Sub

End Class