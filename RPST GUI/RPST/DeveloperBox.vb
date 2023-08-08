Public Class DeveloperBox
    Private Sub DeveloperForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GreetingLabel.BackColor = Color.Transparent
        AboutMeLinkLabel.BackColor = Color.Transparent
        LinkLabelBuyMeACoffee.BackColor = Color.Transparent
    End Sub

    Private Sub AboutMeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AboutMeLinkLabel.LinkClicked
        ' I couldn't find a proper way to open a url
        ' Process.Start() did not work
        Shell("cmd /c start https://about.me/rly0nheart")
    End Sub

    Private Sub BuyMeACoffeeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelBuyMeACoffee.LinkClicked
        Shell("cmd /c start https://buymeacoffee.com/_rly0nheart")
    End Sub
End Class