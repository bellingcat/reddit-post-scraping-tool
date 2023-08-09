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
            FormMain.ToolStripMenuItemDarkMode.Checked = settings.DarkMode
        Else
            ' Settings file does not exist
            ' Create a new file with default settings 'False'
            Dim defaultSettings = New SettingsManager With {.DarkMode = False}
            Dim jsonOutput = Text.Json.JsonSerializer.Serialize(defaultSettings)
            File.WriteAllText(settingsFilePath, jsonOutput)

            Me.DarkMode = False
            FormMain.ToolStripMenuItemDarkMode.Checked = False
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
            FormMain.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.TextBoxSubreddit.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            FormMain.TextBoxKeyword.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            FormMain.NumericUpDownLimit.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            FormMain.NumericUpDownLimit.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            FormMain.ComboBoxListing.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            FormMain.ComboBoxTimeframe.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            ' Foreground colours
            FormMain.TextBoxKeyword.ForeColor = SystemColors.Control
            FormMain.TextBoxSubreddit.ForeColor = SystemColors.Control
            FormMain.NumericUpDownLimit.ForeColor = SystemColors.Control
            FormMain.NumericUpDownLimit.ForeColor = SystemColors.Control
            FormMain.ComboBoxListing.ForeColor = SystemColors.Control
            FormMain.ComboBoxTimeframe.ForeColor = SystemColors.Control
            FormMain.LabelKeyword.ForeColor = SystemColors.Control
            FormMain.LabelSubreddit.ForeColor = SystemColors.Control
            FormMain.LabelLimit.ForeColor = SystemColors.Control
            FormMain.LabelListing.ForeColor = SystemColors.Control
            FormMain.LabelTimeframe.ForeColor = SystemColors.Control


            ' Enable dark mode on 'Right Click Menu' items
            ' Background colours
            FormMain.ToolStripMenuItemDarkMode.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToolStripMenuItemSavePosts.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToolStripMenuItemtoJSON.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToolStripMenuItemtoCSV.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToolStripMenuItemAbout.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToolStripMenuItemDeveloper.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToolStripMenuItemCheckUpdates.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToolStripMenuItemQuit.BackColor = ColorTranslator.FromHtml("#FF121212")
            ' Foreground colours
            FormMain.ToolStripMenuItemDarkMode.ForeColor = SystemColors.Control
            FormMain.ToolStripMenuItemSavePosts.ForeColor = SystemColors.Control
            FormMain.ToolStripMenuItemtoJSON.ForeColor = SystemColors.Control
            FormMain.ToolStripMenuItemtoCSV.ForeColor = SystemColors.Control
            FormMain.ToolStripMenuItemAbout.ForeColor = SystemColors.Control
            FormMain.ToolStripMenuItemDeveloper.ForeColor = SystemColors.Control
            FormMain.ToolStripMenuItemCheckUpdates.ForeColor = SystemColors.Control
            FormMain.ToolStripMenuItemQuit.ForeColor = SystemColors.Control


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
            FormMain.ToolStripMenuItemDarkMode.Text = "Light Mode"
        Else
            ' Disable dark mode for the Main Form
            ' Background colours
            FormMain.BackColor = Color.Gainsboro
            FormMain.TextBoxKeyword.BackColor = SystemColors.Control
            FormMain.TextBoxSubreddit.BackColor = SystemColors.Control
            FormMain.NumericUpDownLimit.BackColor = SystemColors.Control
            FormMain.NumericUpDownLimit.BackColor = SystemColors.Control
            FormMain.ComboBoxTimeframe.BackColor = SystemColors.Control
            FormMain.ComboBoxListing.BackColor = SystemColors.Control
            ' Foreground colours
            FormMain.TextBoxKeyword.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.TextBoxSubreddit.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.NumericUpDownLimit.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.NumericUpDownLimit.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ComboBoxListing.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ComboBoxTimeframe.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.LabelKeyword.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.LabelSubreddit.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.LabelLimit.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.LabelListing.ForeColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.LabelTimeframe.ForeColor = ColorTranslator.FromHtml("#FF121212")

            ' Disable dark mode on 'Right Click Menu' items
            ' Background colours
            FormMain.ToolStripMenuItemDarkMode.BackColor = Color.Gainsboro
            FormMain.ToolStripMenuItemSavePosts.BackColor = Color.Gainsboro
            FormMain.ToolStripMenuItemtoJSON.BackColor = Color.Gainsboro
            FormMain.ToolStripMenuItemtoCSV.BackColor = Color.Gainsboro
            FormMain.ToolStripMenuItemAbout.BackColor = Color.Gainsboro
            FormMain.ToolStripMenuItemDeveloper.BackColor = Color.Gainsboro
            FormMain.ToolStripMenuItemCheckUpdates.BackColor = Color.Gainsboro
            FormMain.ToolStripMenuItemQuit.BackColor = Color.Gainsboro
            ' Foreground colours
            FormMain.ToolStripMenuItemDarkMode.ForeColor = Color.Black
            FormMain.ToolStripMenuItemSavePosts.ForeColor = Color.Black
            FormMain.ToolStripMenuItemtoJSON.ForeColor = Color.Black
            FormMain.ToolStripMenuItemtoCSV.ForeColor = Color.Black
            FormMain.ToolStripMenuItemAbout.ForeColor = Color.Black
            FormMain.ToolStripMenuItemDeveloper.ForeColor = Color.Black
            FormMain.ToolStripMenuItemCheckUpdates.ForeColor = Color.Black
            FormMain.ToolStripMenuItemQuit.ForeColor = Color.Black

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
            FormMain.ToolStripMenuItemDarkMode.Text = "Dark Mode"
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