Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text

        Dim result As String
        result = FirstName(name)

        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        'Find the first space

        Dim idx As Integer
        idx = name.IndexOf(" ")

        'Extract the first name
        Dim fName As String
        fName = name.Substring(0, idx)


        Return fName


    End Function

End Class
