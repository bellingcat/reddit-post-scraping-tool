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

        ' Apply the color scheme based on the Dark Mode setting
        ApplyColorScheme(isDarkMode:=CBool(settings("DarkMode")))
    End Sub

    ''' <summary>
    ''' Applies the color scheme based on the given Dark Mode setting. 
    ''' Colors are defined in a mapping for easier maintenance and flexibility.
    ''' </summary>
    ''' <param name="isDarkMode">Indicates whether Dark Mode is enabled.</param>
    Public Shared Sub ApplyColorScheme(ByVal isDarkMode As Boolean)
        ' Initialize color mapping
        Dim colorMap As New Dictionary(Of String, Color)

        If isDarkMode Then
            ' Dark Mode colors
            colorMap("MainBackground") = ColorTranslator.FromHtml("#FF121212")
            colorMap("TextBoxBackground") = ColorTranslator.FromHtml("#FF2E2E2E")
            colorMap("Foreground") = SystemColors.Control
            colorMap("MenuBackground") = ColorTranslator.FromHtml("#FF121212")
            colorMap("AboutBackground") = ColorTranslator.FromHtml("#FF121212")
            colorMap("AboutForeground") = SystemColors.Control
            colorMap("TabPageBackground") = ColorTranslator.FromHtml("#FF2E2E2E")
            colorMap("TabPageForeground") = SystemColors.Control
            colorMap("ButtonForeground") = Color.Black
        Else
            ' Light Mode colors
            colorMap("MainBackground") = Color.Gainsboro
            colorMap("TextBoxBackground") = SystemColors.Control
            colorMap("Foreground") = ColorTranslator.FromHtml("#FF121212")
            colorMap("MenuBackground") = Color.Gainsboro
            colorMap("AboutBackground") = Color.Gainsboro
            colorMap("AboutForeground") = SystemColors.WindowText
            colorMap("TabPageBackground") = SystemColors.Control
            colorMap("TabPageForeground") = SystemColors.WindowText
            colorMap("ButtonForeground") = Color.Black
        End If

        ' Applying Main Form colors
        FormMain.BackColor = colorMap("MainBackground")
        FormMain.TextBoxKeyword.BackColor = colorMap("TextBoxBackground")
        FormMain.TextBoxSubreddit.BackColor = colorMap("TextBoxBackground")
        FormMain.NumericUpDownLimit.BackColor = colorMap("TextBoxBackground")
        FormMain.ComboBoxListing.BackColor = colorMap("TextBoxBackground")
        FormMain.ComboBoxTimeframe.BackColor = colorMap("TextBoxBackground")
        FormMain.TextBoxKeyword.ForeColor = colorMap("Foreground")
        FormMain.TextBoxSubreddit.ForeColor = colorMap("Foreground")
        FormMain.NumericUpDownLimit.ForeColor = colorMap("Foreground")
        FormMain.ComboBoxListing.ForeColor = colorMap("Foreground")
        FormMain.ComboBoxTimeframe.ForeColor = colorMap("Foreground")
        FormMain.LabelKeyword.ForeColor = colorMap("Foreground")
        FormMain.LabelSubreddit.ForeColor = colorMap("Foreground")
        FormMain.LabelLimit.ForeColor = colorMap("Foreground")
        FormMain.LabelListing.ForeColor = colorMap("Foreground")
        FormMain.LabelTimeframe.ForeColor = colorMap("Foreground")

        ' Applying Right-Click Menu colors
        FormMain.SettingsToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.DarkModeToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.SavePostsToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.ToJSONToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.ToCSVToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.AboutToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.CheckForUpdatesToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.QuitToolStripMenuItem.BackColor = colorMap("MenuBackground")
        FormMain.SettingsToolStripMenuItem.ForeColor = colorMap("Foreground")
        FormMain.DarkModeToolStripMenuItem.ForeColor = colorMap("Foreground")
        FormMain.SavePostsToolStripMenuItem.ForeColor = colorMap("Foreground")
        FormMain.ToJSONToolStripMenuItem.ForeColor = colorMap("Foreground")
        FormMain.ToCSVToolStripMenuItem.ForeColor = colorMap("Foreground")
        FormMain.AboutToolStripMenuItem.ForeColor = colorMap("Foreground")
        FormMain.CheckForUpdatesToolStripMenuItem.ForeColor = colorMap("Foreground")
        FormMain.QuitToolStripMenuItem.ForeColor = colorMap("Foreground")

        ' Applying About Box colors
        AboutBox.BackColor = colorMap("AboutBackground")
        AboutBox.TabPageAbout.BackColor = colorMap("TabPageBackground")
        AboutBox.TabPageAuthor.BackColor = colorMap("TabPageBackground")
        AboutBox.ForeColor = colorMap("AboutForeground")
        AboutBox.LabelProgramName.ForeColor = colorMap("AboutForeground")
        AboutBox.LabelDescription.ForeColor = colorMap("AboutForeground")
        AboutBox.LabelCopyright.ForeColor = colorMap("AboutForeground")
        AboutBox.LabelVersion.ForeColor = colorMap("AboutForeground")
        AboutBox.LabelAuthor.ForeColor = colorMap("AboutForeground")
        AboutBox.ButtonClose.ForeColor = colorMap("ButtonForeground")

        ' Updating Dark Mode Text
        If isDarkMode Then
            FormMain.DarkModeToolStripMenuItem.Text = "Dark Mode: Enabled"
        Else
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