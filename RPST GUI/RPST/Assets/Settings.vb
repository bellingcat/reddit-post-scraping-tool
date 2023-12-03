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

    Private ReadOnly settingsFilePath As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "RPST",
        "settings.json"
    )

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

            MainWindow.DarkModeToolStripMenuItem.Checked = settings.DarkMode
            MainWindow.ToJSONToolStripMenuItem.Checked = settings.SaveToJson
            MainWindow.ToCSVToolStripMenuItem.Checked = settings.SaveToCsv
        Else
            ' Settings file does not exist
            ' Create a new file with default settings 'False'
            Dim defaultSettings = New SettingsManager With {.DarkMode = False, .SaveToCsv = False, .SaveToJson = False}
            Dim jsonOutput = JsonSerializer.Serialize(defaultSettings)
            File.WriteAllText(settingsFilePath, jsonOutput)


            SaveToJson = False
            SaveToCsv = False
            MainWindow.ToJSONToolStripMenuItem.Checked = False
            MainWindow.ToCSVToolStripMenuItem.Checked = False

            If Utilities.IsSystemDarkTheme() Then
                DarkMode = True
                MainWindow.DarkModeToolStripMenuItem.Checked = True
            Else
                DarkMode = False
                MainWindow.DarkModeToolStripMenuItem.Checked = False
            End If
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
        MainWindow.ToJSONToolStripMenuItem.Checked = CBool(settings("SaveToJson"))

        ' Apply the SaveToCsv setting to the menu item checkbox
        MainWindow.ToCSVToolStripMenuItem.Checked = CBool(settings("SaveToCsv"))

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
        MainWindow.BackColor = colorMap("MainBackground")
        MainWindow.TextBoxKeyword.BackColor = colorMap("TextBoxBackground")
        MainWindow.TextBoxSubreddit.BackColor = colorMap("TextBoxBackground")
        MainWindow.NumericUpDownLimit.BackColor = colorMap("TextBoxBackground")
        MainWindow.ComboBoxListing.BackColor = colorMap("TextBoxBackground")
        MainWindow.ComboBoxTimeframe.BackColor = colorMap("TextBoxBackground")
        MainWindow.TextBoxKeyword.ForeColor = colorMap("Foreground")
        MainWindow.TextBoxSubreddit.ForeColor = colorMap("Foreground")
        MainWindow.NumericUpDownLimit.ForeColor = colorMap("Foreground")
        MainWindow.ComboBoxListing.ForeColor = colorMap("Foreground")
        MainWindow.ComboBoxTimeframe.ForeColor = colorMap("Foreground")
        MainWindow.LabelKeyword.ForeColor = colorMap("Foreground")
        MainWindow.LabelSubreddit.ForeColor = colorMap("Foreground")
        MainWindow.LabelLimit.ForeColor = colorMap("Foreground")
        MainWindow.LabelListing.ForeColor = colorMap("Foreground")
        MainWindow.LabelTimeframe.ForeColor = colorMap("Foreground")

        ' Applying Right-Click Menu colors
        MainWindow.SettingsToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.DarkModeToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.SavePostsToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.ToJSONToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.ToCSVToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.AboutToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.CheckForUpdatesToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.QuitToolStripMenuItem.BackColor = colorMap("MenuBackground")
        MainWindow.SettingsToolStripMenuItem.ForeColor = colorMap("Foreground")
        MainWindow.DarkModeToolStripMenuItem.ForeColor = colorMap("Foreground")
        MainWindow.SavePostsToolStripMenuItem.ForeColor = colorMap("Foreground")
        MainWindow.ToJSONToolStripMenuItem.ForeColor = colorMap("Foreground")
        MainWindow.ToCSVToolStripMenuItem.ForeColor = colorMap("Foreground")
        MainWindow.AboutToolStripMenuItem.ForeColor = colorMap("Foreground")
        MainWindow.CheckForUpdatesToolStripMenuItem.ForeColor = colorMap("Foreground")
        MainWindow.QuitToolStripMenuItem.ForeColor = colorMap("Foreground")

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
            MainWindow.DarkModeToolStripMenuItem.Text = "Dark Mode: Disable"
        Else
            MainWindow.DarkModeToolStripMenuItem.Text = "Dark Mode: Enable"
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