Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient



Public Class Home
    Public s As String = "server= localhost; user id= root ; password= '' ; database= vpapd;"
    'Public s As String = "server=localhost; user id=192.168.254.102; password= '' ; database= vpapd;"

    Public ServerString As New MySqlConnection(s)
    Dim COMMAND As MySqlCommand






   
















    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Hide()
        BarGen.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Registrationvb.Show()

    End Sub

   

    Private Sub vehicle_reg_load()

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            ServerString.Open()
            Dim Query As String
            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type' from VPAPD.Vehicle_Logs  where date='" & DateTimePicker2.Text & "' order By time desc"
            COMMAND = New MySqlCommand(Query, ServerString)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            KryptonDataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)


            ServerString.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ServerString.Dispose()
        End Try
    End Sub






    Private Sub load_select_current_vehicle()




        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            ServerString.Open()
            Dim Query As String
            Query = "select * from VPAPD.Vehicle_current order by time desc"
            COMMAND = New MySqlCommand(Query, ServerString)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_Vehicle_List.DataSource = bSource

            SDA.Update(dbDataSet)


            ServerString.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)



        Finally
            ServerString.Dispose()



        End Try

    End Sub

  

 
    


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.BackColor = Color.FromArgb(150, 255, 255, 255)



        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)

        vehicle_reg_load()
        load_select_current_vehicle()
        ' KryptonDataGridView1.Sort(KryptonDataGridView1.Columns("Time"), ListSortDirection.Descending)
        ' DataGridView_Vehicle_List.Sort(DataGridView_Vehicle_List.Columns("Time"), ListSortDirection.Descending)

    End Sub


    Public warning As String

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        warning = MsgBox("Exit Application?", vbQuestion + vbYesNo, "EXIT")
        If warning = vbNo Then
            e.Cancel = True

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.Value = DateTime.Now


        V_Total.Text = DataGridView_Vehicle_List.RowCount

        Label2.Text = "MONITOR"
        
    End Sub

    Private Sub refresh1()
        vehicle_reg_load()
        load_select_current_vehicle()
        ' KryptonDataGridView1.Sort(KryptonDataGridView1.Columns("Time"), ListSortDirection.Descending)
        ' DataGridView_Vehicle_List.Sort(DataGridView_Vehicle_List.Columns("Time"), ListSortDirection.Descending)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = DateTime.Now
        If DateTime.Now >= "20:00" Then
            Dim command As New MySqlCommand("delete  from Profile where type = visitor  ", ServerString)
        End If

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
        Me.Show()

    End Sub

  

    
   
    


    
    

    Private Sub MonitorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Show()

    End Sub

    Private Sub GenerateBarcodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerateBarcodeToolStripMenuItem.Click
        Me.Hide()
        BarGen.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_Vehicle_List_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Vehicle_List.CellClick




        Try
            Dim command As New MySqlCommand("select * from Profile where Barcode = " & DataGridView_Vehicle_List.Rows(e.RowIndex).Cells("Barcode").Value.ToString & "  ", ServerString)




            Dim table As New DataTable()

            Dim adapter As New MySqlDataAdapter(command)

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then

                MessageBox.Show("No Image For This Id")
            Else



                Dim img() As Byte

                img = table.Rows(0)(6)

                Dim ms As New MemoryStream(img)

                PictureBox1.Image = Image.FromStream(ms)

            End If

            If e.RowIndex >= 0 Then
                Label_Gatepass.Text = DataGridView_Vehicle_List.Rows(e.RowIndex).Cells("Type").Value.ToString
                Label_Name.Text = DataGridView_Vehicle_List.Rows(e.RowIndex).Cells("FirstName").Value.ToString
                Label_Lname.Text = DataGridView_Vehicle_List.Rows(e.RowIndex).Cells("LastName").Value.ToString
                Label5.Visible = False
                Label6.Visible = False
                Label_Plate.Visible = False
                Label_Vehicle.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    
  

   

    
    
    
  
    

    

   
    
    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        refresh1()

    End Sub

    
    Private Sub KryptonDataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim command As New MySqlCommand("select * from Vehicle_Logs where time = " & KryptonDataGridView1.Rows(e.RowIndex).Cells("Time").Value.ToString & "  ", ServerString)



            Label_Name.Text = KryptonDataGridView1.Rows(e.RowIndex).Cells("FirstName").Value.ToString
            Label_Lname.Text = KryptonDataGridView1.Rows(e.RowIndex).Cells("LastName").Value.ToString
            Label_Gatepass.Text = KryptonDataGridView1.Rows(e.RowIndex).Cells("Type").Value.ToString
            Label_Plate.Text = KryptonDataGridView1.Rows(e.RowIndex).Cells("Plate number").Value.ToString
            Label_Vehicle.Text = KryptonDataGridView1.Rows(e.RowIndex).Cells("Vehicle Type").Value.ToString
        End If

        Try
            Dim command1 As New MySqlCommand("select * from profile where barcode = " & KryptonDataGridView1.Rows(e.RowIndex).Cells("barcode").Value.ToString & "  ", ServerString)
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

    Private Sub DataGridView_Vehicle_List_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Vehicle_List.CellContentClick

    End Sub

    Private Sub GatepassStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GatepassStatusToolStripMenuItem.Click
        Me.Hide()
        Profile.Show()

    End Sub


End Class
