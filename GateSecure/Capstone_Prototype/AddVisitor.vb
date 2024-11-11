Imports MySql.Data.MySqlClient

Public Class AddVisitor
    Dim ServerString As New MySqlConnection("server= localhost; user id= root ; password= '' ; database= VPAPD")






    Private Sub AddVisitorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Show()


    End Sub

    Private Sub VehicleLogsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles VehicleLogsToolStripMenuItem1.Click
        VehicleLogReport.Show()

    End Sub

    Private Sub EntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Home.Show()

    End Sub

 

    Private Sub RegisterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Hide()
        Registrationvb.Show()

    End Sub

    Private Sub KryptonTextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles KryptonTextBox_Barcode.TextChanged

       
        load_insert_profile()





    End Sub


    Private Sub load_insert_profile()
        If KryptonTextBox_Barcode.Text = Nothing Or KryptonTextBox_Firstname.Text = Nothing Or KryptonTextBox_Lastname.Text = Nothing Or KryptonTextBox_PlateNumber.Text = Nothing Then
            KryptonLabel_alert.Text = "Please fill all fields"

        End If
        Try


        
        Dim str As String = KryptonTextBox_Barcode.Text
        Dim length As Integer = str.Length

        If length = 3 Then
            ServerString.Open()


            Dim Register As New MySqlCommand("Insert into Profile(Barcode, PlateNumber, FirstName, LastName,Type) VALUES ('" & KryptonTextBox_Barcode.Text & "', '" & KryptonTextBox_PlateNumber.Text & "', '" & KryptonTextBox_Firstname.Text & "', '" & KryptonTextBox_Lastname.Text & "', '" & "Visitor" & "')", ServerString)
            Register.ExecuteNonQuery()
            ServerString.Close()
            KryptonLabel_alert.Text = "Registered"
            End If
        Catch ex As Exception
            KryptonLabel_alert.Text = ex.Message
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Home.Close()
    End Sub

    Private Sub MonitorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MonitorToolStripMenuItem.Click
        Me.Hide()
        Home.Show()

    End Sub
End Class