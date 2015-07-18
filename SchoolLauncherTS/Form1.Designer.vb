<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppWindow
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
        Me.AppSelect = New System.Windows.Forms.ComboBox()
        Me.AppIconBox = New System.Windows.Forms.PictureBox()
        CType(Me.AppIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppSelect
        '
        Me.AppSelect.FormattingEnabled = True
        Me.AppSelect.Location = New System.Drawing.Point(12, 12)
        Me.AppSelect.Name = "AppSelect"
        Me.AppSelect.Size = New System.Drawing.Size(256, 21)
        Me.AppSelect.TabIndex = 0
        '
        'AppIconBox
        '
        Me.AppIconBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AppIconBox.Location = New System.Drawing.Point(12, 39)
        Me.AppIconBox.Name = "AppIconBox"
        Me.AppIconBox.Size = New System.Drawing.Size(256, 256)
        Me.AppIconBox.TabIndex = 1
        Me.AppIconBox.TabStop = False
        '
        'AppWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(280, 304)
        Me.Controls.Add(Me.AppIconBox)
        Me.Controls.Add(Me.AppSelect)
        Me.Name = "AppWindow"
        Me.Text = "App Launcher"
        CType(Me.AppIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AppSelect As System.Windows.Forms.ComboBox
    Friend WithEvents AppIconBox As System.Windows.Forms.PictureBox

End Class
