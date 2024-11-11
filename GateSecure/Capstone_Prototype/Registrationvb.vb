Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Registrationvb




    Public Serverstring As New MySqlConnection(Home.s)















    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox_FirstName.Text = Nothing Or TextBox_LastName.Text = Nothing Or TextBox_PlateNumber.Text = Nothing Or TextBox_VehicleType.Text = Nothing Or ComboBox_Gatepass.Text = Nothing Or PictureBox1.Image Is Nothing Then
            MsgBox("Please Fill in all fields")


        Else


            Dim ms As New MemoryStream










            Try
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                ServerString.Open()
                Dim Register As New MySqlCommand("Insert into Profile(Type, PlateNumber, FirstName, LastName, VehicleType,Picture,Status,PrintStatus) VALUES ('" & ComboBox_Gatepass.Text & "', '" & TextBox_PlateNumber.Text & "', '" & TextBox_FirstName.Text & "', '" & TextBox_LastName.Text & "', '" & TextBox_VehicleType.Text & "', @img,'Active','Not Printed')", ServerString)

                Register.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()
                Register.ExecuteNonQuery()
                MsgBox("Registration Successful")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            ServerString.Close()
            TextBox_FirstName.Clear()
            TextBox_LastName.Clear()

            TextBox_PlateNumber.Clear()
            TextBox_VehicleType.Clear()


        End If
    End Sub

    Private Sub Button_Others_SelectImage_Click(sender As Object, e As EventArgs) Handles Button_Others_SelectImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub Registrationvb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Home.Close()

        If Home.warning = vbNo Then
            e.Cancel = True

        End If


    End Sub

    Private Sub EntranceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Home.Close()

    End Sub

    Private Sub OthersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Show()

    End Sub

    Private Sub VehicleLogsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()

        VehicleLogReport.Show()

    End Sub


    
    Private Sub VehicleLogsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles VehicleLogsToolStripMenuItem1.Click
        Me.Hide()
        VehicleLogReport.Show()

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()

    End Sub

    Private Sub EntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Home.Show()

    End Sub

 
    Private Sub MonitorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MonitorToolStripMenuItem.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub GenerateBarcodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerateBarcodeToolStripMenuItem.Click
        Me.Hide()
        BarGen.Show()

    End Sub

    
    Private Sub ConfigureGatepassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigureGatepassToolStripMenuItem.Click
        Me.Hide()

        Gatepass.Show()

    End Sub



  

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
    Private Sub Registrationvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)
    End Sub

    Private Sub GatepassStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GatepassStatusToolStripMenuItem.Click
        Me.Hide()
        Profile.Show()

    End Sub
End Class