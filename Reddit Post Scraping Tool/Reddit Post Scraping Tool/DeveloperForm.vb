Public Class DeveloperForm
    Private Sub DeveloperForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"Developer - {My.Application.Info.AssemblyName}"
        GreetingLabel.BackColor = Color.Transparent
        AboutMeLinkLabel.BackColor = Color.Transparent
        BuyMeACoffeeLinkLabel.BackColor = Color.Transparent
    End Sub

    Private Sub AboutMeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AboutMeLinkLabel.LinkClicked
        ' I couldn't find a proper way to open a url
        ' Process.Start() did not work
        Shell("cmd /c start https://about.me/rly0nheart")
    End Sub

    Private Sub BuyMeACoffeeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BuyMeACoffeeLinkLabel.LinkClicked
        Shell("cmd /c start https://buymeacoffee.com/189381184")
    End Sub
End Class