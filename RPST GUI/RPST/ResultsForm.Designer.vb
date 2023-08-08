<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridViewResults = New DataGridView()
        CType(DataGridViewResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewResults
        ' 
        DataGridViewResults.BackgroundColor = Color.Gainsboro
        DataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewResults.Dock = DockStyle.Fill
        DataGridViewResults.Location = New Point(0, 0)
        DataGridViewResults.Name = "DataGridViewResults"
        DataGridViewResults.ReadOnly = True
        DataGridViewResults.RowHeadersVisible = False
        DataGridViewResults.RowTemplate.Height = 25
        DataGridViewResults.Size = New Size(800, 450)
        DataGridViewResults.TabIndex = 3
        ' 
        ' ResultsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridViewResults)
        Name = "ResultsForm"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "ResultsForm"
        CType(DataGridViewResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewResults As DataGridView
End Class
