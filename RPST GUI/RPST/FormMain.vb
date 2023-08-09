Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormMain
    ReadOnly settings As New SettingsManager()
    ReadOnly ApiHandler As New ApiHandler()

    ''' <summary>
    ''' Event handler for the form load event.
    ''' It loads settings, toggles dark mode if necessary, checks for directories, logs first time launch, and sets the form title.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        settings.LoadSettings()
        settings.ToggleDarkMode(settings.DarkMode)
        Utilities.PathFinder()
        Utilities.LogFirstTimeLaunch()
        Me.Text = My.Application.Info.AssemblyName
    End Sub


    ''' <summary>
    ''' Event handler for the 'Dark Mode' checkbox change event.
    ''' It toggles the dark mode of the application based on the checkbox status.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub DarkModeToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles ToolStripMenuItemDarkMode.CheckedChanged
        settings.ToggleDarkMode(ToolStripMenuItemDarkMode.Checked)
    End Sub


    ''' <summary>
    ''' Event handler for the 'About' menu item click.
    ''' It shows the 'About' box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub ToolStripMenuItemAbout_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemAbout.Click
        AboutBox.Show()
    End Sub


    ''' <summary>
    ''' Event handler for the 'Developer' menu item click.
    ''' It shows the 'Developer' dialog box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub ToolStripMenuItemDeveloper_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemDeveloper.Click
        DeveloperBox.ShowDialog()
    End Sub


    ''' <summary>
    ''' Event handler for the 'Check Updates' menu item click.
    ''' It checks for application updates and provides update information if a newer version is available.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub ToolStripMenuItemCheckUpdates_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemCheckUpdates.Click
        Dim data As JObject = ApiHandler.CheckUpdates()
        If data("tag_name").ToString = My.Application.Info.Version.ToString Then
            MessageBox.Show($"You're running the latest version v{My.Application.Info.Version} of {Me.Text}. Check again soon! :)", $"{Me.Text} v{My.Application.Info.Version}", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim confirm As DialogResult = MessageBox.Show($"A new version v{data("tag_name")} of {Me.Text} is available, would you like to get it?

{data("body")}
", $"{Me.Text} v{data("tag_name")}".ToString, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                Shell($"cmd /c start {data("html_url")}")
            End If
        End If
    End Sub


    ''' <summary>
    ''' Event handler for the 'Quit' menu item click.
    ''' It asks the user for confirmation and closes the program if the user agrees.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub ToolStripMenuItemQuit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemQuit.Click
        Dim result As DialogResult = MessageBox.Show("This will close the program, continue?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    ''' <summary>
    ''' Handles the click event of the ScrapeButton.
    ''' Collects inputs, fetches Reddit posts based on the inputs,
    ''' and processes Reddit posts.
    ''' </summary>
    ''' <param name="sender">The sender of the event.</param>
    ''' <param name="e">The EventArgs instance containing the event data.</param>
    Private Sub ButtonScrape_Click(sender As Object, e As EventArgs) Handles ButtonScrape.Click
        Utilities.ProcessRedditPosts(ToolStripMenuItemtoJSON)
    End Sub


    ''' <summary>
    ''' Handles the KeyDown event for the TextBoxKeyword. 
    ''' Processes Reddit posts when the Enter key is pressed.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    Private Sub TextBoxKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxKeyword.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Prevent the beep sound that usually comes with the Enter key in a single-line TextBox
            e.SuppressKeyPress = True
            Utilities.ProcessRedditPosts(ToolStripMenuItemtoJSON)
        End If
    End Sub


    ''' <summary>
    ''' Handles the KeyDown event for the TextBoxSubreddit. 
    ''' Processes Reddit posts when the Enter key is pressed.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    Private Sub TextBoxSubreddit_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSubreddit.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Prevent the beep sound that usually comes with the Enter key in a single-line TextBox
            e.SuppressKeyPress = True
            Utilities.ProcessRedditPosts(ToolStripMenuItemtoJSON)
        End If
    End Sub


    ''' <summary>
    ''' Handles the KeyDown event for the NumericUpDownLimit. 
    ''' Processes Reddit posts when the Enter key is pressed.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    Private Sub NumericUpDownLimit_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDownLimit.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Prevent the beep sound that usually comes with the Enter key in a single-line TextBox
            e.SuppressKeyPress = True
            Utilities.ProcessRedditPosts(ToolStripMenuItemtoJSON)
        End If
    End Sub


    ''' <summary>
    ''' Handles the KeyDown event for the ComboBoxListing. 
    ''' Processes Reddit posts when the Enter key is pressed.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    Private Sub ComboBoxListing_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxListing.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Prevent the beep sound that usually comes with the Enter key in a single-line TextBox
            e.SuppressKeyPress = True
            Utilities.ProcessRedditPosts(ToolStripMenuItemtoJSON)
        End If
    End Sub


    ''' <summary>
    ''' Handles the KeyDown event for the ComboBoxTimeframe. 
    ''' Processes Reddit posts when the Enter key is pressed.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    Private Sub ComboBoxTimeframe_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxTimeframe.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Prevent the beep sound that usually comes with the Enter key in a single-line TextBox
            e.SuppressKeyPress = True
            Utilities.ProcessRedditPosts(ToolStripMenuItemtoJSON)
        End If
    End Sub
End Class
