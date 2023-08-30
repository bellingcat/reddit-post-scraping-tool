Public Class FormPosts
    Private Sub FormResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"{Me.Text} - {FormMain.TextBoxKeyword.Text}, r/{FormMain.TextBoxSubreddit.Text}, {FormMain.NumericUpDownLimit.Text}, {FormMain.ComboBoxListing.Text}, {FormMain.ComboBoxTimeframe.Text}"
    End Sub
End Class