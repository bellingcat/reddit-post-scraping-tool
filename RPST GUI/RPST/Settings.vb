Imports System.IO
Imports System.Text.Json
Imports Newtonsoft.Json.Linq


Public Class SettingsManager

    ''' <summary>
    ''' Represents the Dark Mode property.
    ''' Indicates whether the dark mode is enabled or disabled.
    ''' </summary>
    Public Property DarkMode As Boolean

    Private ReadOnly settingsFilePath As String = Path.Combine(Environment.CurrentDirectory, "settings.json")

    ''' <summary>
    ''' Loads application settings from the 'settings.json' file.
    ''' If the settings file doesn't exist, it creates a new file with default settings.
    ''' </summary>
    Public Sub LoadSettings()
        ' Check if the settings.json file exists
        ' and load the configurations from it
        If File.Exists(settingsFilePath) Then
            Dim json As String = File.ReadAllText(settingsFilePath)
            Dim options As New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True}
            Dim settings = Text.Json.JsonSerializer.Deserialize(Of SettingsManager)(json, options)
            Me.DarkMode = settings.DarkMode
            StartForm.ToolStripMenuItemDarkMode.Checked = settings.DarkMode
        Else
            ' Settings file does not exist
            ' Create a new file with default settings 'False'
            Dim defaultSettings = New SettingsManager With {.DarkMode = False}
            Dim jsonOutput = Text.Json.JsonSerializer.Serialize(defaultSettings)
            File.WriteAllText(settingsFilePath, jsonOutput)

            Me.DarkMode = False
            StartForm.ToolStripMenuItemDarkMode.Checked = False
        End If
    End Sub


    ''' <summary>
    ''' Toggles the Dark Mode setting on or off based on the provided parameter.
    ''' </summary>
    ''' <param name="enabled">A Boolean indicating if Dark Mode should be enabled or not.</param>
    Public Sub ToggleDarkMode(enabled As Boolean)
        Dim json As String = File.ReadAllText(settingsFilePath)
        Dim options As New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True}
        Dim settings As SettingsManager = JsonSerializer.Deserialize(Of SettingsManager)(json, options)
        settings.DarkMode = enabled
        SaveSettings(settings)
        ApplyTheme()
    End Sub

    ''' <summary>
    ''' Saves the provided settings to the 'settings.json' file.
    ''' </summary>
    ''' <param name="settings">An instance of the SettingsManager containing the configurations to be saved.</param>
    Private Sub SaveSettings(settings)
        Dim jsonOutput = JsonSerializer.Serialize(settings)
        File.WriteAllText(settingsFilePath, jsonOutput)
    End Sub


    ''' <summary>
    ''' Applies the visual theme based on the Dark Mode setting.
    ''' If Dark Mode is enabled, a dark theme is applied. If it's disabled, a light theme is set.
    ''' </summary>
    Public Sub ApplyTheme()
        Dim DarkMode As Boolean = GetDarkMode()
        If DarkMode Then
            ' Enable dark mode for the Main form
            ' Background colours (I know 'Colours'/'Colors'😆)
            StartForm.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.SubredditTextBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.KeywordTextBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.ListingComboBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.TimeframeComboBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            ' Foreground colours
            StartForm.KeywordTextBox.ForeColor = SystemColors.Control
            StartForm.SubredditTextBox.ForeColor = SystemColors.Control
            StartForm.LimitNumericUpDown.ForeColor = SystemColors.Control
            StartForm.LimitNumericUpDown.ForeColor = SystemColors.Control
            StartForm.ListingComboBox.ForeColor = SystemColors.Control
            StartForm.TimeframeComboBox.ForeColor = SystemColors.Control
            StartForm.LabelRPST.ForeColor = SystemColors.Control
            StartForm.LabelKeyword.ForeColor = SystemColors.Control
            StartForm.LabelSubreddit.ForeColor = SystemColors.Control
            StartForm.LabelLimit.ForeColor = SystemColors.Control
            StartForm.LabelListing.ForeColor = SystemColors.Control
            StartForm.LabelTimeframe.ForeColor = SystemColors.Control

            ResultsForm.BackColor = ColorTranslator.FromHtml("#FF121212")

            ' Enable dark mode on 'Right Click Menu' items
            ' Background colours
            StartForm.ToolStripMenuItemDarkMode.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolStripMenuItemSavePosts.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolStripMenuItemtoJSON.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolStripMenuItemtoCSV.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolStripMenuItemAbout.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolStripMenuItemDeveloper.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolStripMenuItemCheckUpdates.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolStripMenuItemQuit.BackColor = ColorTranslator.FromHtml("#FF121212")
            ' Foreground colours
            StartForm.ToolStripMenuItemDarkMode.ForeColor = SystemColors.Control
            StartForm.ToolStripMenuItemSavePosts.ForeColor = SystemColors.Control
            StartForm.ToolStripMenuItemtoJSON.ForeColor = SystemColors.Control
            StartForm.ToolStripMenuItemtoCSV.ForeColor = SystemColors.Control
            StartForm.ToolStripMenuItemAbout.ForeColor = SystemColors.Control
            StartForm.ToolStripMenuItemDeveloper.ForeColor = SystemColors.Control
            StartForm.ToolStripMenuItemCheckUpdates.ForeColor = SystemColors.Control
            StartForm.ToolStripMenuItemQuit.ForeColor = SystemColors.Control


            ' Enable dark mode for the About box
            ' Background colours
            AboutBox.BackColor = ColorTranslator.FromHtml("#FF121212")
            AboutBox.LicenseRichTextBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            AboutBox.Panel1.BackColor = ColorTranslator.FromHtml("#FF121212")
            ' Foreground colours
            AboutBox.ForeColor = SystemColors.Control
            AboutBox.LicenseRichTextBox.ForeColor = SystemColors.Control
            AboutBox.LabelProgramName.ForeColor = SystemColors.Control
            AboutBox.LabelProgramDescription.ForeColor = SystemColors.Control
            AboutBox.LabelVersion.ForeColor = SystemColors.Control

            ' If dark mode is enabled, set the 'Dark Mode' text value to 'Light mode'
            StartForm.ToolStripMenuItemDarkMode.Text = "Light Mode"
        Else
            ' Disable dark mode for the Main Form
            ' Background colours
            StartForm.BackColor = Color.Gainsboro
            StartForm.KeywordTextBox.BackColor = SystemColors.Control
            StartForm.SubredditTextBox.BackColor = SystemColors.Control
            StartForm.LimitNumericUpDown.BackColor = SystemColors.Control
            StartForm.LimitNumericUpDown.BackColor = SystemColors.Control
            StartForm.TimeframeComboBox.BackColor = SystemColors.Control
            StartForm.ListingComboBox.BackColor = SystemColors.Control
            ' Foreground colours
            StartForm.KeywordTextBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.SubredditTextBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ListingComboBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.TimeframeComboBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LabelRPST.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LabelKeyword.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LabelSubreddit.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LabelLimit.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LabelListing.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LabelTimeframe.ForeColor = ColorTranslator.FromHtml("#FF121212")

            ' Disable dark mode on 'Right Click Menu' items
            ' Background colours
            StartForm.ToolStripMenuItemDarkMode.BackColor = Color.Gainsboro
            StartForm.ToolStripMenuItemSavePosts.BackColor = Color.Gainsboro
            StartForm.ToolStripMenuItemtoJSON.BackColor = Color.Gainsboro
            StartForm.ToolStripMenuItemtoCSV.BackColor = Color.Gainsboro
            StartForm.ToolStripMenuItemAbout.BackColor = Color.Gainsboro
            StartForm.ToolStripMenuItemDeveloper.BackColor = Color.Gainsboro
            StartForm.ToolStripMenuItemCheckUpdates.BackColor = Color.Gainsboro
            StartForm.ToolStripMenuItemQuit.BackColor = Color.Gainsboro
            ' Foreground colours
            StartForm.ToolStripMenuItemDarkMode.ForeColor = Color.Black
            StartForm.ToolStripMenuItemSavePosts.ForeColor = Color.Black
            StartForm.ToolStripMenuItemtoJSON.ForeColor = Color.Black
            StartForm.ToolStripMenuItemtoCSV.ForeColor = Color.Black
            StartForm.ToolStripMenuItemAbout.ForeColor = Color.Black
            StartForm.ToolStripMenuItemDeveloper.ForeColor = Color.Black
            StartForm.ToolStripMenuItemCheckUpdates.ForeColor = Color.Black
            StartForm.ToolStripMenuItemQuit.ForeColor = Color.Black

            ' Disable dark mode for the About box
            ' Background colours
            AboutBox.BackColor = Color.Gainsboro
            AboutBox.ForeColor = SystemColors.WindowText
            AboutBox.LicenseRichTextBox.BackColor = SystemColors.Control
            AboutBox.LicenseRichTextBox.ForeColor = SystemColors.WindowText
            AboutBox.Panel1.BackColor = Color.Gainsboro
            ' Foreground colours
            AboutBox.Panel1.ForeColor = SystemColors.WindowText
            AboutBox.LabelProgramName.ForeColor = SystemColors.WindowText
            AboutBox.LabelProgramDescription.ForeColor = SystemColors.WindowText
            AboutBox.LabelVersion.ForeColor = SystemColors.WindowText

            ' If dark mode is disabled, set the 'Light Mode' text value to 'Dark Mode'
            StartForm.ToolStripMenuItemDarkMode.Text = "Dark Mode"
        End If
    End Sub


    ''' <summary>
    ''' Retrieves the Dark Mode setting value from 'settings.json'. 
    ''' If the settings file doesn't exist, defaults to returning 'False' (Dark Mode off).
    ''' </summary>
    ''' <returns>A Boolean indicating if Dark Mode is enabled or not.</returns>
    Private Function GetDarkMode() As Boolean
        If File.Exists(settingsFilePath) Then
            Dim json As String = File.ReadAllText(settingsFilePath)
            Dim settings As JObject = JObject.Parse(json)
            Return settings(NameOf(DarkMode)).ToObject(Of Boolean)()
        Else
            Return False
        End If
    End Function
End Class