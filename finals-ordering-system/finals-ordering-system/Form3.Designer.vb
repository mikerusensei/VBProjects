<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmd_home = New Button()
        SuspendLayout()
        ' 
        ' cmd_home
        ' 
        cmd_home.Location = New Point(713, 415)
        cmd_home.Name = "cmd_home"
        cmd_home.Size = New Size(75, 23)
        cmd_home.TabIndex = 1
        cmd_home.Text = "Home"
        cmd_home.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmd_home)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form3"
        Text = "About Me"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmd_home As Button
End Class
