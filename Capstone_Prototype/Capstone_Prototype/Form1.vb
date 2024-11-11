
Imports System.IO
Imports MySql.Data.MySqlClient



Public Class Home

    Public s As String = "server= localhost; user id= root ; password= '1234' ; database= vpapd"
    'Public s As String = "server= 192.168.254.102 ; user id= Entrance ; password= '' ; database= vpapd"

    Public ServerString As New MySqlConnection(s)
    Dim COMMAND As MySqlCommand



    Public Sub sapi()
        Dim objvoice
        objvoice = CreateObject("sapi.spvoice")
        objvoice.rate = 0
        objvoice.speak(Label2.Text)
    End Sub








    Dim status As String

    Private Sub Barcode_Scan()
        Dim str As String = Barcode.Text
        Dim length As Integer = str.Length
        Dim authenticator As Boolean = False


        If length = 4 Then





            'display info
            Dim select_table As New MySqlCommand("SELECT * FROM Profile WHERE Barcode = '" & Barcode.Text & "'  ", ServerString)
            Dim Barcode_Reader As MySqlDataReader

            If (ServerString.State = ConnectionState.Open) Then
                ServerString.Close()


            End If
            ServerString.Open()
            Barcode_Reader = select_table.ExecuteReader


            If Barcode_Reader.HasRows Then
                V_Total.Text = DataGridView_Vehicle_List.RowCount

                While Barcode_Reader.Read
                    Label_Name.Text = Barcode_Reader.GetString("FirstName")
                    Label_Lname.Text = Barcode_Reader.GetString("LastName")

                    If Barcode_Reader.GetString("Status") = "Stolen" Then
                        authenticator = True

                    End If
                    status = Barcode_Reader.GetString("Status")
                    Label_Plate.Text = Barcode_Reader.GetString("PlateNumber")
                    Label_Vehicle.Text = Barcode_Reader.GetString("VehicleType")
                    Label_Gatepass.Text = Barcode_Reader.GetString("Type")
                    If Label_Gatepass.Text = "Visitor" Then
                        PictureBox1 = Nothing
                    End If







                End While

                ServerString.Close()

                'verify if vehicle is already inside
                Dim verify As New MySqlCommand("SELECT * FROM vehicle_current WHERE Barcode= '" & Barcode.Text & "' ORDER BY time DESC", ServerString)
                Dim verify_Reader As MySqlDataReader

                If (ServerString.State = ConnectionState.Open) Then
                    ServerString.Close()


                End If
                ServerString.Open()
                verify_Reader = verify.ExecuteReader


                If verify_Reader.HasRows Then
                    ServerString.Close()
                    load_image()
                    Label2.Text = "Duplicate Entry!"
                    Label2.ForeColor = Color.Red
                    Label2.BackColor = Color.WhiteSmoke

                    My.Computer.Audio.PlaySystemSound(
             System.Media.SystemSounds.Asterisk)
                Else
                    ServerString.Close()
                    ' load_image()
                    If authenticator = True Then
                        Label2.Text = "Reported Stolen!"
                        Label2.ForeColor = Color.Red
                        Label2.BackColor = Color.WhiteSmoke
                        My.Computer.Audio.PlaySystemSound(
                     System.Media.SystemSounds.Asterisk)
                    Else
                        Label2.Text = "Authenticated"


                    End If


                    load_image()

                    load_insert_current_vehicle()
                    load_select_current_vehicle()
                    load_insert_vehiclelogs()
                    sapi()

                End If





                '









                Barcode.Clear()



            Else
                Barcode.Clear()

                Label2.Text = "INVALID BARCODE"



            End If


            vehicle_reg_load()

            ' Else
            '    Barcode.Clear()
        End If




    End Sub

















    Private Sub load_insert_vehiclelogs()
        If (ServerString.State = ConnectionState.Open) Then
            ServerString.Close()


        End If
        ServerString.Open()

        Dim ET As String
        ET = "Entry"
        Dim Register As New MySqlCommand("Insert into Vehicle_Logs(Barcode,EntryType, PlateNumber, FirstName, LastName, VehicleType, Time, Date, Type,Status) VALUES ('" & Barcode.Text & "','" & ET & "', '" & Label_Plate.Text & "', '" & Label_Name.Text & "', '" & Label_Lname.Text & "', '" & Label_Vehicle.Text & "','" & DateTimePicker1.Text & "',   '" & DateTimePicker2.Text & "', '" & Label_Gatepass.Text & "', '" & status & "')", ServerString)
        Register.ExecuteNonQuery()
        ServerString.Close()
    End Sub

    Private Sub vehicle_reg_load()


        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            If (ServerString.State = ConnectionState.Open) Then
                ServerString.Close()


            End If
            ServerString.Open()
            Dim Query As String
            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type',Status from VPAPD.Vehicle_Logs where date ='" & DateTimePicker2.Text & "' ORDER BY time DESC"
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





    Private Sub load_insert_current_vehicle()


        Try
            If (ServerString.State = ConnectionState.Open) Then
                ServerString.Close()


            End If
            ServerString.Open()

            Dim InTime As New MySqlCommand("Insert into vehicle_current(Barcode, Firstname, Lastname, Time, Type,Status) VALUES ( '" & Barcode.Text & "','" & Label_Name.Text & "', '" & Label_Lname.Text & "', '" & DateTimePicker1.Text & "', '" & Label_Gatepass.Text & "', '" & status & "')", ServerString)
            InTime.ExecuteNonQuery()
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
            If (ServerString.State = ConnectionState.Open) Then
                ServerString.Close()


            End If
            ServerString.Open()
            Dim Query As String
            Query = "select * from VPAPD.Vehicle_current ORDER BY time DESC"
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

    Private Sub Btn_Exit_Click(ByVal sender As Object, ByVal e As EventArgs)

        Me.Hide()
        Exitvb.Show()
    End Sub


    Private Sub load_image()




        Dim command As New MySqlCommand("select * from Profile where Barcode = " & Barcode.Text & "  ", ServerString)


        Dim table As New DataTable()

        Dim adapter As New MySqlDataAdapter(command)

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("No Image For This Id")
        Else



            Dim img() As Byte

            img = table.Rows(0)(6)

            Dim ms As New MemoryStream(img)
            Try
                PictureBox1.Image = Image.FromStream(ms)
            Catch
                ServerString.Dispose()

            End Try
        End If


    End Sub



    Private Sub Barcode_TextChanged(sender As Object, e As EventArgs) Handles Barcode.TextChanged
        V_Total.Text = DataGridView_Vehicle_List.RowCount


        Barcode_Scan()
    End Sub


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 255, 255, 255)
        Panel6.BackColor = Color.FromArgb(100, 255, 255, 255)

        Panel5.BackColor = Color.FromArgb(224, 126, 192, 238)
        Label1.BackColor = Color.FromArgb(224, 126, 192, 238)
        MenuStrip1.BackColor = Color.FromArgb(224, 126, 192, 238)

        Panel3.BackColor = Color.FromArgb(224, 255, 255, 255)
        Panel11.BackColor = Color.FromArgb(224, 255, 255, 255)
        Panel8.BackColor = Color.FromArgb(224, 255, 255, 255)
        Label10.BackColor = Color.FromArgb(224, 126, 192, 238)
        Panel2.BackColor = Color.FromArgb(224, 255, 255, 255)

        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)

        vehicle_reg_load()
        load_select_current_vehicle()


    End Sub


    Public warning As String
    Private Sub Home_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        warning = MsgBox("Exit Application", vbQuestion + vbYesNo, "EXIT")
        If warning = vbNo Then
            e.Cancel = True
        End If

    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.Value = DateTime.Now
        Barcode.Focus()
        vehicle_reg_load()
        V_Total.Text = DataGridView_Vehicle_List.RowCount

        load_select_current_vehicle()

    End Sub



    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        DateTimePicker1.Value = DateTime.Now


    End Sub

    Private Sub AddVisitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddVisitorToolStripMenuItem.Click
        AddVisitor.ShowDialog()

    End Sub

    Private Sub VehicleLogsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleLogsToolStripMenuItem1.Click
        Me.Hide()
        Me.Show()

    End Sub

    Private Sub ExitGateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitGateToolStripMenuItem.Click

        PictureBox1.Image = Nothing
        Label_Gatepass.Text = Nothing
        Label_Lname.Text = Nothing
        Label_Name.Text = Nothing
        Label_Plate.Text = Nothing
        Label_Vehicle.Text = Nothing
        Label2.Text = Nothing


        Me.Hide()
        Exitvb.Show()



    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()


    End Sub

   


End Class
