﻿Imports System.Runtime

Public Class AboutBox
    ReadOnly settings As New SettingsManager()
    Public Property LicenseText As String = $"MIT License

{My.Application.Info.Copyright}

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
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE."


    ''' <summary>
    ''' Handles the Load event for the AboutBox form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        settings.LoadSettings()
        settings.ToggleSettings(settings.DarkMode, "darkmode")

        LabelProgramName.Text = My.Application.Info.ProductName
        LabelProgramDescription.Text = "Given a subreddit name and a keyword,
RPST returns all top posts (by default)
that contain the specified keyword."
        LinkLabelVersion.Text = $"v{My.Application.Info.Version}"
        LicenseRichTextBox.Text = LicenseText
    End Sub

    ''' <summary>
    ''' Handles the LinkClicked event for the LinkLabelReadtheWiki control. 
    ''' Opens the Wiki URL in the default browser.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub LinkLabelReadtheWiki_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelReadtheWiki.LinkClicked
        Shell("cmd /c start https://github.com/bellingcat/reddit-post-scraping-tool/wiki")
    End Sub

    Private Sub LinkLabelVersion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelVersion.LinkClicked
        Shell($"cmd /c start https://github.com/bellingcat/reddit-post-scraping-tool/releases/tag/{My.Application.Info.Version}")
    End Sub
End Class
