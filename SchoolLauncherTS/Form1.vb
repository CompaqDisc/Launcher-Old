Public Class AppWindow
    Dim AppConfig As String = ".\.lnk\lnk.csv"
    Dim AppName() As String
    Dim AppPath() As String
    Dim AppIcon() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppList()
        LoadDefaultProg()
    End Sub

    Private Sub LoadAppList()
        Try
            Using ioReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(AppConfig)

                ioReader.TextFieldType = FileIO.FieldType.Delimited
                ioReader.SetDelimiters(",")

                While Not ioReader.EndOfData

                    Dim thisData As String() = ioReader.ReadFields()

                    If AppName Is Nothing Then
                        ReDim Preserve AppName(0)
                        ReDim Preserve AppPath(0)
                        ReDim Preserve AppIcon(0)
                        AppName(0) = thisData(0)
                        AppPath(0) = thisData(1)
                        AppIcon(0) = thisData(2)

                    Else
                        ReDim Preserve AppName(AppName.Length)
                        ReDim Preserve AppPath(AppPath.Length)
                        ReDim Preserve AppIcon(AppIcon.Length)
                        AppName((AppName.Length - 1)) = thisData(0)
                        AppPath((AppPath.Length - 1)) = thisData(1)
                        AppIcon((AppIcon.Length - 1)) = thisData(2)

                    End If
                End While
            End Using
            AppSelect.Items.AddRange(AppName)
        Catch ex As Exception
            MsgBox("Configuration File Not Found")
            Me.Close()
        End Try
    End Sub

    Private Sub AppSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppSelect.SelectedIndexChanged
        Try
            AppIconBox.Image = Image.FromFile(AppIcon(AppSelect.SelectedIndex))
        Catch ex As Exception
            AppIconBox.Image = AppIconBox.ErrorImage
        End Try
    End Sub

    Private Sub LoadDefaultProg()
        AppSelect.SelectedIndex = 0
    End Sub

    Private Sub AppIconBox_Click(sender As Object, e As EventArgs) Handles AppIconBox.Click
        Try
            Process.Start(AppPath(AppSelect.SelectedIndex))
        Catch ex As Exception
            AppSelect.Text = "Could not load app..."
        End Try
    End Sub
End Class
