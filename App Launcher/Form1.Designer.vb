<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppLauncher
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
        Me.TabWindow = New System.Windows.Forms.TabControl()
        Me.OpenTab = New System.Windows.Forms.TabPage()
        Me.OpenCommand = New System.Windows.Forms.GroupBox()
        Me.CommandRunBtn = New System.Windows.Forms.Button()
        Me.CommandBox = New System.Windows.Forms.TextBox()
        Me.OpenApp = New System.Windows.Forms.GroupBox()
        Me.AppRefreshBtn = New System.Windows.Forms.Button()
        Me.AppRunBtn = New System.Windows.Forms.Button()
        Me.AppSelect = New System.Windows.Forms.ComboBox()
        Me.AddTab = New System.Windows.Forms.TabPage()
        Me.SaveConfigFileBtn = New System.Windows.Forms.Button()
        Me.AppConfigEditBox = New System.Windows.Forms.GroupBox()
        Me.ConfigFileEditor = New System.Windows.Forms.TextBox()
        Me.EditConfigWith = New System.Windows.Forms.GroupBox()
        Me.EditConfigNotepad = New System.Windows.Forms.RadioButton()
        Me.EditConfigBtn = New System.Windows.Forms.Button()
        Me.EditConfigNPP = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TabWindow.SuspendLayout()
        Me.OpenTab.SuspendLayout()
        Me.OpenCommand.SuspendLayout()
        Me.OpenApp.SuspendLayout()
        Me.AddTab.SuspendLayout()
        Me.AppConfigEditBox.SuspendLayout()
        Me.EditConfigWith.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabWindow
        '
        Me.TabWindow.Controls.Add(Me.OpenTab)
        Me.TabWindow.Controls.Add(Me.AddTab)
        Me.TabWindow.Location = New System.Drawing.Point(0, -1)
        Me.TabWindow.Name = "TabWindow"
        Me.TabWindow.SelectedIndex = 0
        Me.TabWindow.Size = New System.Drawing.Size(692, 408)
        Me.TabWindow.TabIndex = 1
        '
        'OpenTab
        '
        Me.OpenTab.Controls.Add(Me.OpenCommand)
        Me.OpenTab.Controls.Add(Me.OpenApp)
        Me.OpenTab.Location = New System.Drawing.Point(4, 22)
        Me.OpenTab.Name = "OpenTab"
        Me.OpenTab.Padding = New System.Windows.Forms.Padding(3)
        Me.OpenTab.Size = New System.Drawing.Size(684, 382)
        Me.OpenTab.TabIndex = 0
        Me.OpenTab.Text = "Open"
        Me.OpenTab.UseVisualStyleBackColor = True
        '
        'OpenCommand
        '
        Me.OpenCommand.Controls.Add(Me.CommandRunBtn)
        Me.OpenCommand.Controls.Add(Me.CommandBox)
        Me.OpenCommand.Location = New System.Drawing.Point(6, 330)
        Me.OpenCommand.Name = "OpenCommand"
        Me.OpenCommand.Size = New System.Drawing.Size(668, 46)
        Me.OpenCommand.TabIndex = 2
        Me.OpenCommand.TabStop = False
        Me.OpenCommand.Text = "Run Command"
        '
        'CommandRunBtn
        '
        Me.CommandRunBtn.Location = New System.Drawing.Point(587, 15)
        Me.CommandRunBtn.Name = "CommandRunBtn"
        Me.CommandRunBtn.Size = New System.Drawing.Size(75, 23)
        Me.CommandRunBtn.TabIndex = 1
        Me.CommandRunBtn.Text = "Run"
        Me.CommandRunBtn.UseVisualStyleBackColor = True
        '
        'CommandBox
        '
        Me.CommandBox.Location = New System.Drawing.Point(6, 17)
        Me.CommandBox.Name = "CommandBox"
        Me.CommandBox.Size = New System.Drawing.Size(575, 20)
        Me.CommandBox.TabIndex = 0
        '
        'OpenApp
        '
        Me.OpenApp.Controls.Add(Me.AppRefreshBtn)
        Me.OpenApp.Controls.Add(Me.AppRunBtn)
        Me.OpenApp.Controls.Add(Me.AppSelect)
        Me.OpenApp.Location = New System.Drawing.Point(6, 6)
        Me.OpenApp.Name = "OpenApp"
        Me.OpenApp.Size = New System.Drawing.Size(668, 318)
        Me.OpenApp.TabIndex = 1
        Me.OpenApp.TabStop = False
        Me.OpenApp.Text = "Regular App"
        '
        'AppRefreshBtn
        '
        Me.AppRefreshBtn.Location = New System.Drawing.Point(518, 49)
        Me.AppRefreshBtn.Name = "AppRefreshBtn"
        Me.AppRefreshBtn.Size = New System.Drawing.Size(142, 23)
        Me.AppRefreshBtn.TabIndex = 2
        Me.AppRefreshBtn.Text = "Refresh List"
        Me.AppRefreshBtn.UseVisualStyleBackColor = True
        '
        'AppRunBtn
        '
        Me.AppRunBtn.Location = New System.Drawing.Point(518, 19)
        Me.AppRunBtn.Name = "AppRunBtn"
        Me.AppRunBtn.Size = New System.Drawing.Size(142, 23)
        Me.AppRunBtn.TabIndex = 1
        Me.AppRunBtn.Text = "Start App"
        Me.AppRunBtn.UseVisualStyleBackColor = True
        '
        'AppSelect
        '
        Me.AppSelect.FormattingEnabled = True
        Me.AppSelect.Location = New System.Drawing.Point(6, 19)
        Me.AppSelect.Name = "AppSelect"
        Me.AppSelect.Size = New System.Drawing.Size(506, 21)
        Me.AppSelect.TabIndex = 0
        Me.AppSelect.Text = "--Select Application--"
        '
        'AddTab
        '
        Me.AddTab.Controls.Add(Me.SaveConfigFileBtn)
        Me.AddTab.Controls.Add(Me.AppConfigEditBox)
        Me.AddTab.Controls.Add(Me.EditConfigWith)
        Me.AddTab.Location = New System.Drawing.Point(4, 22)
        Me.AddTab.Name = "AddTab"
        Me.AddTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddTab.Size = New System.Drawing.Size(684, 382)
        Me.AddTab.TabIndex = 1
        Me.AddTab.Text = "Add"
        Me.AddTab.UseVisualStyleBackColor = True
        '
        'SaveConfigFileBtn
        '
        Me.SaveConfigFileBtn.Location = New System.Drawing.Point(14, 354)
        Me.SaveConfigFileBtn.Name = "SaveConfigFileBtn"
        Me.SaveConfigFileBtn.Size = New System.Drawing.Size(656, 22)
        Me.SaveConfigFileBtn.TabIndex = 6
        Me.SaveConfigFileBtn.Text = "Save Config"
        Me.SaveConfigFileBtn.UseVisualStyleBackColor = True
        '
        'AppConfigEditBox
        '
        Me.AppConfigEditBox.Controls.Add(Me.ConfigFileEditor)
        Me.AppConfigEditBox.Location = New System.Drawing.Point(8, 61)
        Me.AppConfigEditBox.Name = "AppConfigEditBox"
        Me.AppConfigEditBox.Size = New System.Drawing.Size(668, 287)
        Me.AppConfigEditBox.TabIndex = 5
        Me.AppConfigEditBox.TabStop = False
        Me.AppConfigEditBox.Text = "Edit Here..."
        '
        'ConfigFileEditor
        '
        Me.ConfigFileEditor.AcceptsReturn = True
        Me.ConfigFileEditor.Location = New System.Drawing.Point(13, 19)
        Me.ConfigFileEditor.Multiline = True
        Me.ConfigFileEditor.Name = "ConfigFileEditor"
        Me.ConfigFileEditor.Size = New System.Drawing.Size(649, 262)
        Me.ConfigFileEditor.TabIndex = 0
        '
        'EditConfigWith
        '
        Me.EditConfigWith.Controls.Add(Me.EditConfigNotepad)
        Me.EditConfigWith.Controls.Add(Me.EditConfigBtn)
        Me.EditConfigWith.Controls.Add(Me.EditConfigNPP)
        Me.EditConfigWith.Location = New System.Drawing.Point(8, 6)
        Me.EditConfigWith.Name = "EditConfigWith"
        Me.EditConfigWith.Size = New System.Drawing.Size(668, 49)
        Me.EditConfigWith.TabIndex = 4
        Me.EditConfigWith.TabStop = False
        Me.EditConfigWith.Text = "Edit With..."
        '
        'EditConfigNotepad
        '
        Me.EditConfigNotepad.AutoSize = True
        Me.EditConfigNotepad.Location = New System.Drawing.Point(6, 19)
        Me.EditConfigNotepad.Name = "EditConfigNotepad"
        Me.EditConfigNotepad.Size = New System.Drawing.Size(107, 17)
        Me.EditConfigNotepad.TabIndex = 2
        Me.EditConfigNotepad.TabStop = True
        Me.EditConfigNotepad.Text = "Notepad (Built-In)"
        Me.EditConfigNotepad.UseVisualStyleBackColor = True
        '
        'EditConfigBtn
        '
        Me.EditConfigBtn.Location = New System.Drawing.Point(583, 19)
        Me.EditConfigBtn.Name = "EditConfigBtn"
        Me.EditConfigBtn.Size = New System.Drawing.Size(79, 23)
        Me.EditConfigBtn.TabIndex = 1
        Me.EditConfigBtn.Text = "Edit"
        Me.EditConfigBtn.UseVisualStyleBackColor = True
        '
        'EditConfigNPP
        '
        Me.EditConfigNPP.AutoSize = True
        Me.EditConfigNPP.Location = New System.Drawing.Point(119, 19)
        Me.EditConfigNPP.Name = "EditConfigNPP"
        Me.EditConfigNPP.Size = New System.Drawing.Size(78, 17)
        Me.EditConfigNPP.TabIndex = 3
        Me.EditConfigNPP.TabStop = True
        Me.EditConfigNPP.Text = "Notepad++"
        Me.EditConfigNPP.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "csv"
        Me.SaveFileDialog.FileName = "AppLauncher.csv"
        Me.SaveFileDialog.Filter = "Comma Separated Values|*.csv"
        Me.SaveFileDialog.InitialDirectory = "C:\Users\Owner\Desktop\Programs\Programming\My Visual Studio Apps\LauncherConfig"
        Me.SaveFileDialog.OverwritePrompt = False
        Me.SaveFileDialog.SupportMultiDottedExtensions = True
        Me.SaveFileDialog.Title = "Save Config As..."
        '
        'AppLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(692, 405)
        Me.Controls.Add(Me.TabWindow)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Name = "AppLauncher"
        Me.Text = "Launcher"
        Me.TabWindow.ResumeLayout(False)
        Me.OpenTab.ResumeLayout(False)
        Me.OpenCommand.ResumeLayout(False)
        Me.OpenCommand.PerformLayout()
        Me.OpenApp.ResumeLayout(False)
        Me.AddTab.ResumeLayout(False)
        Me.AppConfigEditBox.ResumeLayout(False)
        Me.AppConfigEditBox.PerformLayout()
        Me.EditConfigWith.ResumeLayout(False)
        Me.EditConfigWith.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabWindow As System.Windows.Forms.TabControl
    Friend WithEvents OpenTab As System.Windows.Forms.TabPage
    Friend WithEvents AddTab As System.Windows.Forms.TabPage
    Friend WithEvents OpenCommand As System.Windows.Forms.GroupBox
    Friend WithEvents OpenApp As System.Windows.Forms.GroupBox
    Friend WithEvents CommandRunBtn As System.Windows.Forms.Button
    Friend WithEvents CommandBox As System.Windows.Forms.TextBox
    Friend WithEvents AppSelect As System.Windows.Forms.ComboBox
    Friend WithEvents AppRunBtn As System.Windows.Forms.Button
    Friend WithEvents EditConfigBtn As System.Windows.Forms.Button
    Friend WithEvents EditConfigNPP As System.Windows.Forms.RadioButton
    Friend WithEvents EditConfigNotepad As System.Windows.Forms.RadioButton
    Friend WithEvents EditConfigWith As System.Windows.Forms.GroupBox
    Friend WithEvents AppConfigEditBox As System.Windows.Forms.GroupBox
    Friend WithEvents AppRefreshBtn As System.Windows.Forms.Button
    Friend WithEvents SaveConfigFileBtn As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ConfigFileEditor As System.Windows.Forms.TextBox

End Class
