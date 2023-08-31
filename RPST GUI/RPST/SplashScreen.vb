Public NotInheritable Class SplashScreen
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Version info
        Version.Text = $"Version {My.Application.Info.Version}"

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub
End Class
