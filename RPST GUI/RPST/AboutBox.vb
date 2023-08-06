Public Class AboutBox
    Public Property LicenseText As String = "MIT License

Copyright (c) 2023-2024 Richard Mwewa

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

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgramNameLabel.Text = My.Application.Info.AssemblyName
        DescriptionLabel.Text = "Given a subreddit name and a keyword,
RPST returns all top posts
(by default) that contain the specified keyword."
        VersionLabel.Text = $"v{My.Application.Info.Version}"
        LicenseRichTextBox.Text = LicenseText
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WikiLinkLabel.LinkClicked
        Shell("cmd /c start https://github.com/bellingcat/reddit-post-scraping-tool/wiki")
    End Sub
End Class