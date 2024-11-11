Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Profile
    Public Serverstring As New MySqlConnection(Home.s)


    Private Sub load_profile()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim Command As New MySqlCommand
        Dim bSource As New BindingSource
        Try
            Serverstring.Open()
            Dim Query As String
            Query = "select Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type',Status from profile"
            Command = New MySqlCommand(Query, Serverstring)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)


            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)



        Finally
            Serverstring.Dispose()



        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load_search()
    End Sub

    Private Sub load_search()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim Command As New MySqlCommand
        Dim bSource As New BindingSource
        Try
            Serverstring.Open()
            Dim Query As String
            Query = "select Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type',Status from profile where Lastname = '" & TextBox1.Text & "'"
            Command = New MySqlCommand(Query, Serverstring)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)


            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.RowIndex >= 0 Then
                Dim command As New MySqlCommand("select Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type',Status * from Profile where Lastname = " & DataGridView1.Rows(e.RowIndex).Cells("Lastname").Value.ToString & "  ", Serverstring)



                Label_Name.Text = DataGridView1.Rows(e.RowIndex).Cells("FirstName").Value.ToString
                Label_Lname.Text = DataGridView1.Rows(e.RowIndex).Cells("LastName").Value.ToString
                Label_Gatepass.Text = DataGridView1.Rows(e.RowIndex).Cells("Type").Value.ToString
                Label_Plate.Text = DataGridView1.Rows(e.RowIndex).Cells("Plate number").Value.ToString
                Label_Vehicle.Text = DataGridView1.Rows(e.RowIndex).Cells("Vehicle Type").Value.ToString
                TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells("Barcode").Value.ToString
            End If


            Dim command1 As New MySqlCommand("select * from profile where barcode = " & DataGridView1.Rows(e.RowIndex).Cells("barcode").Value.ToString & "  ", Serverstring)
            Dim table As New DataTable()

            Dim adapter As New MySqlDataAdapter(command1)

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then

                MessageBox.Show("No Image For This Id")
            Else



                Dim img() As Byte

                img = table.Rows(0)(6)

                Dim ms As New MemoryStream(img)

                PictureBox1.Image = Image.FromStream(ms)

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub Profile_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Home.Close()
        If Home.warning = vbNo Then
            e.Cancel = True

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_update.Click


        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim Command As New MySqlCommand
        Dim bSource As New BindingSource
        Try
            Serverstring.Open()
            Dim Query As String
            Query = "update profile set Status = '" & status & "' where Barcode = '" & TextBox2.Text & "'"
            Command = New MySqlCommand(Query, Serverstring)

            MsgBox("Update Successful", vbInformation, "Note")

            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try
    End Sub
    Dim status As String
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        status = "Active"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        status = "Stolen"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        load_profile()

    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)


        RadioButton1.Checked = True

        load_profile()

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

    Private Sub RegisterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Hide()
        Registrationvb.Show()


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
        Gatepass.Show()

    End Sub



    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

   
End Class