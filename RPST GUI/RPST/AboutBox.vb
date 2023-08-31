Imports System.Runtime

Public Class AboutBox
    ReadOnly settings As New SettingsManager()

    ''' <summary>
    ''' Handles the Load event for the AboutBox form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"About {My.Application.Info.AssemblyName}"

        settings.LoadSettings()
        settings.ToggleSettings(settings.DarkMode, "darkmode")

        LabelProgramName.Text = My.Application.Info.ProductName
        LabelDescription.Text = "Retrieve Reddit posts that contain the specified keyword 
from a specified subreddit. "
        LabelVersion.Text = $"Version {My.Application.Info.Version}"
        LabelCopyright.Text = My.Application.Info.Copyright
    End Sub

    ''' <summary>
    ''' Handles the LinkClicked event for the LinkLabelLicense control. 
    ''' Opens A MessageBox showing the License Notice.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub LinkLabelLicense_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLicense.LinkClicked
        Utilities.LicenseAgreement()
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

    ''' <summary>
    ''' Handles the LinkClicked event for the LinkLabelAboutMe control. 
    ''' Opens A MessageBox showing the License Notice.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub LinkLabelAboutMe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAboutMe.LinkClicked
        Shell("cmd /c start https://about.me/rly0nheart")
    End Sub

    ''' <summary>
    ''' Handles the LinkClicked event for the LinkLabelBMC control. 
    ''' Opens A MessageBox showing the License Notice.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub LinkLabelBMC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelBMC.LinkClicked
        Shell("cmd /c start https://buymeacoffee.com/_rly0nheart")
    End Sub

    ''' <summary>
    ''' Handles the LinkClicked event for the LinkLabelEmail control. 
    ''' Opens A MessageBox showing the License Notice.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub LinkLabelEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEmail.LinkClicked
        Shell("cmd /c start mailto:rly0nheart@duck.com")
    End Sub


    ''' <summary>
    ''' Handles the Click event for ButtonOK event. 
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The event data.</param>
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class
