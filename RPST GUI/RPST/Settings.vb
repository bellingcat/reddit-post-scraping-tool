Imports System.IO
Imports System.Text.Json
Imports Newtonsoft.Json.Linq


Public Class SettingsManager

    ''' <summary>
    ''' Represents the Dark Mode property.
    ''' Indicates whether the dark mode is enabled or disabled.
    ''' </summary>
    Public Property DarkMode As Boolean
    Public Property SaveToJson As Boolean
    Public Property SaveToCsv As Boolean

    Private ReadOnly settingsFilePath As String = Path.Combine(Environment.CurrentDirectory, "config.json")

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
            Dim settings = JsonSerializer.Deserialize(Of SettingsManager)(json, options)

            DarkMode = settings.DarkMode
            SaveToJson = settings.SaveToJson
            SaveToCsv = settings.SaveToCsv

            FormMain.DarkModeToolStripMenuItem.Checked = settings.DarkMode
            FormMain.ToJSONToolStripMenuItem.Checked = settings.SaveToJson
            FormMain.ToCSVToolStripMenuItem.Checked = settings.SaveToCsv
        Else
            ' Settings file does not exist
            ' Create a new file with default settings 'False'
            Dim defaultSettings = New SettingsManager With {.DarkMode = False, .SaveToCsv = False, .SaveToJson = False}
            Dim jsonOutput = JsonSerializer.Serialize(defaultSettings)
            File.WriteAllText(settingsFilePath, jsonOutput)

            DarkMode = False
            SaveToJson = False
            SaveToCsv = False

            FormMain.ToJSONToolStripMenuItem.Checked = False
            FormMain.ToCSVToolStripMenuItem.Checked = False
            FormMain.DarkModeToolStripMenuItem.Checked = False


        End If
    End Sub


    ''' <summary>
    ''' Retrieves application settings from a JSON file.
    ''' </summary>
    ''' <returns>A Dictionary containing the names and values of all settings. 
    ''' If the settings file doesn't exist, returns a Dictionary with default values.</returns>
    Private Function GetSettings() As Dictionary(Of String, Object)
        Dim settings As New Dictionary(Of String, Object)
        If File.Exists(settingsFilePath) Then
            ' Read and parse the JSON settings file.
            Dim json As String = File.ReadAllText(settingsFilePath)
            Dim jObject As JObject = JObject.Parse(json)

            ' Loop through each property in the JObject and add it to the settings Dictionary.
            For Each item As JProperty In jObject.Properties()
                settings.Add(item.Name, item.Value.ToObject(Of Object)())
            Next
        Else
        End If
        Return settings
    End Function

    ''' <summary>
    ''' Saves the provided settings to the 'settings.json' file.
    ''' </summary>
    ''' <param name="settings">An instance of the SettingsManager containing the configurations to be saved.</param>
    Private Sub SaveSettings(settings)
        Dim jsonOutput = JsonSerializer.Serialize(settings)
        File.WriteAllText(settingsFilePath, jsonOutput)
    End Sub


    ''' <summary>
    ''' Applies the current settings to the application's interface. This includes
    ''' toggling SaveToJson, SaveToCsv, and applying the visual theme based on the Dark Mode setting.
    ''' </summary>
    Public Sub ApplySettings()
        ' Retrieve the current settings
        Dim settings As Dictionary(Of String, Object) = GetSettings()

        ' Apply the SaveToJson setting to the menu item checkbox
        FormMain.ToJSONToolStripMenuItem.Checked = CBool(settings("SaveToJson"))

        ' Apply the SaveToCsv setting to the menu item checkbox
        FormMain.ToCSVToolStripMenuItem.Checked = CBool(settings("SaveToCsv"))

        If CBool(settings("DarkMode")) Then
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
            FormMain.SettingsToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.DarkModeToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.SavePostsToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToJSONToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.ToCSVToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.AboutToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.DeveloperToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.CheckForUpdatesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            FormMain.QuitToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FF121212")
            ' Foreground colours
            FormMain.SettingsToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.DarkModeToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.SavePostsToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.ToJSONToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.ToCSVToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.AboutToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.DeveloperToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.CheckForUpdatesToolStripMenuItem.ForeColor = SystemColors.Control
            FormMain.QuitToolStripMenuItem.ForeColor = SystemColors.Control


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
            AboutBox.LinkLabelVersion.ForeColor = SystemColors.Control

            ' If dark mode is enabled, set the 'Dark Mode' text value to 'Light mode'
            FormMain.DarkModeToolStripMenuItem.Text = "Dark Mode: Enabled"
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
            FormMain.SettingsToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.DarkModeToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.SavePostsToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.ToJSONToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.ToCSVToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.AboutToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.DeveloperToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.CheckForUpdatesToolStripMenuItem.BackColor = Color.Gainsboro
            FormMain.QuitToolStripMenuItem.BackColor = Color.Gainsboro
            ' Foreground colours
            FormMain.SettingsToolStripMenuItem.ForeColor = Color.Black
            FormMain.DarkModeToolStripMenuItem.ForeColor = Color.Black
            FormMain.SavePostsToolStripMenuItem.ForeColor = Color.Black
            FormMain.ToJSONToolStripMenuItem.ForeColor = Color.Black
            FormMain.ToCSVToolStripMenuItem.ForeColor = Color.Black
            FormMain.AboutToolStripMenuItem.ForeColor = Color.Black
            FormMain.DeveloperToolStripMenuItem.ForeColor = Color.Black
            FormMain.CheckForUpdatesToolStripMenuItem.ForeColor = Color.Black
            FormMain.QuitToolStripMenuItem.ForeColor = Color.Black

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
            AboutBox.LinkLabelVersion.ForeColor = SystemColors.WindowText

            ' If dark mode is disabled, set the 'Light Mode' text value to 'Dark Mode'
            FormMain.DarkModeToolStripMenuItem.Text = "Dark Mode: Disabled"
        End If
    End Sub


    ''' <summary>
    ''' Toggles specific settings on or off based on the provided parameters.
    ''' </summary>
    ''' <param name="enabled">A Boolean indicating if the setting option should be enabled or not.</param>
    ''' <param name="saveTo">A String specifying the type of setting to toggle ('json', 'csv', or 'darkmode').</param>
    Public Sub ToggleSettings(enabled As Boolean, saveTo As String)
        ' Read the existing settings from the settings file
        Dim json As String = File.ReadAllText(settingsFilePath)
        Dim options As New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True}
        Dim settings As SettingsManager = JsonSerializer.Deserialize(Of SettingsManager)(json, options)

        ' Update the settings based on the specified saveTo parameter
        If saveTo.ToLower(Globalization.CultureInfo.InvariantCulture) = "json" Then
            settings.SaveToJson = enabled
        ElseIf saveTo.ToLower(Globalization.CultureInfo.InvariantCulture) = "csv" Then
            settings.SaveToCsv = enabled
        ElseIf saveTo.ToLower(Globalization.CultureInfo.InvariantCulture) = "darkmode" Then
            settings.DarkMode = enabled
        Else
            ' Handle unexpected value of saveTo (if needed)
        End If

        ' Save the updated settings back to the settings file
        SaveSettings(settings)
        ' Apply the updated settings to the application
        ApplySettings()
    End Sub
End Class