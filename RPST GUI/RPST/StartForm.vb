Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class StartForm
    ReadOnly settings As New SettingsManager()
    ReadOnly ApiHandler As New ApiHandler()

    ''' <summary>
    ''' Handles the click event of the ScrapeButton.
    ''' Collects inputs, fetches Reddit posts based on the inputs,
    ''' and updates the DataGridView with the fetched posts.
    ''' </summary>
    ''' <param name="sender">The sender of the event.</param>
    ''' <param name="e">The EventArgs instance containing the event data.</param>
    Private Sub ScrapeButton_Click(sender As Object, e As EventArgs) Handles ScrapeButton.Click
        Utilities.ProcessRedditPosts(JSONToolStripMenuItem)
    End Sub


    ''' <summary>
    ''' Event handler for the form load event.
    ''' It loads settings, toggles dark mode if necessary, checks for directories, logs first time launch, and sets the form title.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        settings.LoadSettings()
        settings.ToggleDarkMode(settings.DarkMode)
        Utilities.PathFinder()
        Utilities.LogFirstTimeLaunch()
        Me.Text = My.Application.Info.AssemblyName
    End Sub


    ''' <summary>
    ''' Event handler for the 'About' menu item click.
    ''' It shows the 'About' dialog box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    ''' <summary>
    ''' Event handler for the 'Quit' menu item click.
    ''' It asks the user for confirmation and closes the program if the user agrees.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("This will close the program, continue?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    ''' <summary>
    ''' Event handler for the 'Developer' menu item click.
    ''' It shows the 'Developer' dialog box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub DeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperToolStripMenuItem.Click
        DeveloperForm.ShowDialog()
    End Sub


    ''' <summary>
    ''' Event handler for the 'Check Updates' menu item click.
    ''' It checks for application updates and provides update information if a newer version is available.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub CheckUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckUpdatesToolStripMenuItem.Click

        Dim data As JObject = ApiHandler.CheckUpdates()
        If data("tag_name").ToString = $"{My.Application.Info.Version}" Then
            MessageBox.Show($"You're running the current version v{My.Application.Info.Version} of {My.Application.Info.ProductName}. Check again soon! :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim confirm As DialogResult = MessageBox.Show($"A new version v{data("tag_name")} of {My.Application.Info.ProductName} is available, would you like to get it?

What's new in v{data("tag_name")}?
{data("body")}
", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                Shell($"cmd /c start https://github.com/bellingcat/reddit-post-scraping-tool/releases/tag/{data("tag_name")}")
            End If
        End If

    End Sub


    ''' <summary>
    ''' Event handler for the 'Dark Mode' checkbox change event.
    ''' It toggles the dark mode of the application based on the checkbox status.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub DarkModeToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem.CheckedChanged
        settings.ToggleDarkMode(DarkModeToolStripMenuItem.Checked)
    End Sub
End Class
