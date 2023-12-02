Imports System.Text

Public Class FormApps
    Private apps As New List(Of String)()
    Private MaxAppsCount As Integer = 10

    Private Sub clearList()
        ListApps.Items.Clear() 'clear the list of Apps
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the application
        Application.Exit()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        ' Get the app name from the TextBox
        Dim appName As String = TextBox.Text.Trim()

        ' Check if the app name is not empty
        If Not String.IsNullOrEmpty(appName) Then
            If apps.Count >= MaxAppsCount Then
                ' Handle the situation where the array is full
                MessageBox.Show("Cannot add the app. The maximum number of apps has been reached.", "Apps Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Add the app to the array or collection
                apps.Add(appName)

                ' Clear the TextBox
                TextBox.Text = ""

                ' Show a message box indicating that the app has been added
                MessageBox.Show($"{appName} has been added.", "Apps Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        ' Clear the ListBox
        ListApps.Items.Clear()

        ' Loop through the apps list and add each app to the ListBox
        For Each app As String In apps
            ListApps.Items.Add(app)
        Next
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ' Get the app name to be deleted from the TextBox
        Dim appNameToDelete As String = TextBox.Text.Trim()

        ' Check if the app name is not empty
        If Not String.IsNullOrEmpty(appNameToDelete) Then

            ' Check if the app exists in the array or collection
            If apps.Contains(appNameToDelete) Then
                ' Remove the app from the array or collection
                apps.Remove(appNameToDelete)

                ' Remove the app from the ListBox
                ListApps.Items.Remove(appNameToDelete)

                ' Clear the TextBox
                TextBox.Text = ""

                ' Show a message box indicating that the app has been deleted
                MessageBox.Show($"{appNameToDelete} has been deleted.", "Apps Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Show a message box indicating that the app does not exist
                MessageBox.Show("The app does not exist.", "Apps Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem1.Click
        ' Get the selected app's name from the ListBox
        If ListApps.SelectedIndex >= 0 Then
            Dim selectedAppName As String = ListApps.SelectedItem.ToString()

            ' Get the new app name from the TextBox
            Dim updatedAppName As String = TextBox.Text.Trim()

            ' Check if the new app name is not empty
            If Not String.IsNullOrEmpty(updatedAppName) Then
                ' Update the app's name in the array or collection
                Dim index As Integer = apps.IndexOf(selectedAppName)
                If index >= 0 Then
                    apps(index) = updatedAppName

                    ' Clear the TextBox
                    TextBox.Text = ""

                    ' Show a message box indicating that the app has been updated
                    MessageBox.Show($"{updatedAppName} has been updated.", "Apps Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ListApps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListApps.SelectedIndexChanged
        ' Get the selected app's name from the ListBox
        If ListApps.SelectedIndex >= 0 Then
            Dim selectedAppName As String = ListApps.SelectedItem.ToString()

            ' Display the app's name in a TextBox for editing
            TextBox.Text = selectedAppName
        End If
    End Sub
End Class
