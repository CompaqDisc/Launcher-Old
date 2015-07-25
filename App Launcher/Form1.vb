Public Class AppLauncher
    Dim AppName() As String
    Dim AppPath() As String
    Dim AppConfig As String = "C:\Users\Owner\Desktop\Programs\Programming\My Visual Studio Apps\LauncherConfig\AppLauncher.csv"
    Dim ConfigEditor As String = "notepad"
    Private Sub CommandRunBtn_Click(sender As Object, e As EventArgs) Handles CommandRunBtn.Click
        RunCommand()
    End Sub

    Private Overloads Sub CommandBox_KeyDown(ByVal sender As System.Object, ByVal KeyEvent As System.Windows.Forms.KeyEventArgs) Handles CommandBox.KeyDown
        If KeyEvent.KeyCode = Keys.Return Then
            RunCommand()
        End If
    End Sub

    Sub RunCommand()
        Process.Start("cmd", "/K " & CommandBox.Text)
        CommandBox.Text = ""
    End Sub

    Private Sub AppLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppList()
        EditConfigNotepad.Checked = True
        ConfigFileEditor.Text = System.IO.File.ReadAllText(AppConfig)
    End Sub

    Private Sub AppRunBtn_Click(sender As Object, e As EventArgs) Handles AppRunBtn.Click
        Process.Start(AppPath(AppSelect.SelectedIndex))
        AppSelect.Text = "--Select Application--"
    End Sub

    Private Sub EditConfigNotepad_CheckedChanged(sender As Object, e As EventArgs) Handles EditConfigNotepad.CheckedChanged
        If EditConfigNotepad.Checked Then
            ConfigEditor = "notepad"
        End If
    End Sub

    Private Sub EditConfigNPP_CheckedChanged(sender As Object, e As EventArgs) Handles EditConfigNPP.CheckedChanged
        If EditConfigNPP.Checked Then
            ConfigEditor = "C:\Program Files (x86)\Notepad++\notepad++.exe"
        End If
    End Sub

    Private Sub EditConfigBtn_Click(sender As Object, e As EventArgs) Handles EditConfigBtn.Click
        Process.Start(ConfigEditor, AppConfig)
    End Sub
    Private Sub LoadAppList()
        Using ioReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(AppConfig)
            
            ioReader.TextFieldType = FileIO.FieldType.Delimited
            ioReader.SetDelimiters(",")

            While Not ioReader.EndOfData

                Dim thisData As String() = ioReader.ReadFields()

                If AppName Is Nothing Then
                    ReDim Preserve AppName(0)
                    ReDim Preserve AppPath(0)
                    AppName(0) = thisData(0)
                    AppPath(0) = thisData(1)

                Else
                    ReDim Preserve AppName(AppName.Length)
                    ReDim Preserve AppPath(AppPath.Length)
                    AppName((AppName.Length - 1)) = thisData(0)
                    AppPath((AppPath.Length - 1)) = thisData(1)

                End If
            End While
        End Using
        AppSelect.Items.AddRange(AppName)
    End Sub

    Private Sub AppRefreshBtn_Click(sender As Object, e As EventArgs) Handles AppRefreshBtn.Click
        Erase AppName, AppPath
        AppSelect.Items.Clear()
        LoadAppList()
    End Sub

    Private Sub SaveConfigFileBtn_Click(sender As Object, e As EventArgs) Handles SaveConfigFileBtn.Click
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(SaveFileDialog.FileName, ConfigFileEditor.Text)
        End If
        Erase AppName, AppPath
        AppSelect.Items.Clear()
        LoadAppList()
    End Sub

    Private Sub ConfigFileEditor_KeyDown(sender As Object, e As KeyEventArgs) Handles ConfigFileEditor.KeyDown
        If (e.KeyCode And Not Keys.Modifiers) = Keys.S AndAlso e.Modifiers = Keys.Control Then
            If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                IO.File.WriteAllText(SaveFileDialog.FileName, ConfigFileEditor.Text)
            End If
            Erase AppName, AppPath
            AppSelect.Items.Clear()
            LoadAppList()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.R AndAlso e.Modifiers = Keys.Control Then
            ConfigFileEditor.Text = System.IO.File.ReadAllText(AppConfig)
        End If
    End Sub
End Class
