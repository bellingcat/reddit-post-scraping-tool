Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Runtime
Imports System.Text.Json

Public Class SettingsManager

    Public Property DarkMode As Boolean
    Private ReadOnly settingsFilePath As String = Path.Combine(Environment.CurrentDirectory, "settings.json")


    ' Load settings from the 'settings.json' file
    Public Sub LoadSettings()
        ' Check if the settings.json file exists
        ' and load the configurations from it
        If File.Exists(settingsFilePath) Then
            Dim json As String = File.ReadAllText(settingsFilePath)
            Dim options As New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True}
            Dim settings = Text.Json.JsonSerializer.Deserialize(Of SettingsManager)(json, options)
            Me.DarkMode = settings.DarkMode
            StartForm.DarkModeToolStripMenuItem.Checked = settings.DarkMode
        Else
            ' Settings file does not exist
            ' Create a new file with default settings 'False'
            Dim defaultSettings = New SettingsManager With {.DarkMode = False}
            Dim jsonOutput = Text.Json.JsonSerializer.Serialize(defaultSettings)
            File.WriteAllText(settingsFilePath, jsonOutput)

            Me.DarkMode = False
            StartForm.DarkModeToolStripMenuItem.Checked = False
        End If
    End Sub


    ' Toggle Dark mode
    Public Sub ToggleDarkMode(enabled As Boolean)
        Dim json As String = File.ReadAllText(settingsFilePath)
        Dim options As New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True}
        Dim settings As SettingsManager = Text.Json.JsonSerializer.Deserialize(Of SettingsManager)(json, options)
        settings.DarkMode = enabled
        SaveSettings(settings)
        ApplyTheme()
    End Sub


    ' Save current settings to settings.json
    Private Sub SaveSettings(settings)
        Dim jsonOutput = Text.Json.JsonSerializer.Serialize(settings)
        File.WriteAllText(settingsFilePath, jsonOutput)
    End Sub


    ' Apply theme
    Public Sub ApplyTheme()
        Dim DarkMode As Boolean = GetDarkMode()
        If DarkMode Then
            StartForm.BackColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ToolsToolStripMenuTools.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.KeywordTextBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.KeywordTextBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.SubredditTextBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.SubredditTextBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.ListingComboBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.ListingComboBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.TimeframeComboBox.BackColor = ColorTranslator.FromHtml("#FF2E2E2E")
            StartForm.TimeframeComboBox.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.Label1.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.Label2.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.Label3.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.Label4.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.Label5.ForeColor = ColorTranslator.FromHtml("#FFFFFFFF")
        Else
            StartForm.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.ToolsToolStripMenuTools.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.KeywordTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.KeywordTextBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.SubredditTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.SubredditTextBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.LimitNumericUpDown.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.LimitNumericUpDown.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.ListingComboBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.ListingComboBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.TimeframeComboBox.BackColor = ColorTranslator.FromHtml("#FFFFFFFF")
            StartForm.TimeframeComboBox.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.Label1.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.Label2.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.Label3.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.Label4.ForeColor = ColorTranslator.FromHtml("#FF121212")
            StartForm.Label5.ForeColor = ColorTranslator.FromHtml("#FF121212")
        End If
    End Sub

    ' Get dark mode state from settings.json's key 'DarkMode'
    Private Function GetDarkMode() As Boolean
        If File.Exists(settingsFilePath) Then
            Dim json As String = File.ReadAllText(settingsFilePath)
            Dim settings As JObject = JObject.Parse(json)
            Return settings("DarkMode").ToObject(Of Boolean)()
        Else
            Return False
        End If
    End Function

End Class