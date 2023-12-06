Public Class FormApps
    ' One-dimensional array to store app names
    Private appsArray As Integer = 7
    Private appsCount As Integer = 0
    Private apps(appsArray - 1) As String

    Private Sub clearList()
        ListApps.Items.Clear() 'clear the list of Apps
    End Sub

    Private Sub DisplayListApps()
        ListApps.Items.Clear()

        For i As Integer = 0 To appsCount - 1
            ListApps.Items.Add(apps(i))
        Next
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'for user to view the list of all installed apps
        DisplayListApps()
    End Sub

    Private Sub addApp(appName As String)
        'check if there is space in the array
        If appsCount < appsArray Then
            'add the app to the array
            apps(appsCount) = appName
            appsCount += 1
            MessageBox.Show($"{appName} has been added.", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Array is full! Cannot add more apps.", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim appName As String = InputBox("Enter name of the app: ")

        If Not String.IsNullOrEmpty(appName) Then
            'add the app into the array
            addApp(appName)

            'display the updated list of apps
            DisplayListApps()
            clearList()
        End If
    End Sub

    Private Sub updateApp(index As Integer, newName As String)
        'update the app with new name
        apps(index) = newName
        MessageBox.Show($"The app is successfully updated! New name: {newName}", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' allow user to select an apps to update 
        Dim selectedApp As Integer = ListApps.SelectedIndex

        If selectedApp <> -1 Then
            'get new name for apps
            Dim newAppName As String
            newAppName = InputBox("Enter the New name for this apps: ")
            MessageBox.Show($"The app is successfully update! New apps name: {newAppName}", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'check if user enter a new name
            If Not String.IsNullOrEmpty(newAppName) Then
                updateApp(selectedApp, newAppName)
                DisplayListApps()
            Else
                MessageBox.Show("Please select an app to update.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub DeleteApp(index As Integer)
        'remove the app
        Dim removeAppName As String = apps(index)
        Dim confirmessage = MessageBox.Show($"Are you sure to delete {removeAppName}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmessage = DialogResult.Yes Then
            For i As Integer = index To appsCount - 2
                apps(i) = apps(i + 1)
            Next

            'decrement the app count
            appsCount -= 1
            MessageBox.Show($"{removeAppName} app has been deleted.", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'allow the user to select an app to remove
        Dim selectedApp As Integer = ListApps.SelectedIndex

        If selectedApp <> -1 Then
            'remove the selected app
            DeleteApp(selectedApp)

            'display the updated list of apps
            DisplayListApps()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
