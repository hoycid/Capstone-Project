Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Gatepass
    Public radio_b As Integer

    Dim ServerString As New MySqlConnection(Home.s)



    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        radio_b = 1
        TextBox_Type.Focus()
        Button1.Visible = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        radio_b = 2
        TextBox_Type.Focus()
        Button1.Visible = True

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        radio_b = 3
        TextBox_Type.Focus()
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (ServerString.State = ConnectionState.Open) Then
            ServerString.Close()
        End If

        If radio_b = 1 Then

            '
            Dim verify As New MySqlCommand("SELECT * FROM gatepass_type WHERE type= '" & TextBox_Type.Text & "' ", ServerString)
            Dim verify_Reader As MySqlDataReader
            Dim verified As New Boolean

            If (ServerString.State = ConnectionState.Open) Then
                ServerString.Close()


            End If
            ServerString.Open()
            verify_Reader = verify.ExecuteReader


            If verify_Reader.HasRows Then
                MsgBox("Gatepass Type Existing", vbInformation, "Note")

            Else
                Dim ms As New MemoryStream
                If TextBox_Type.Text = Nothing Then
                    MsgBox("Please Fill in all fields", vbExclamation, "Note")
                End If

                Try
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    If (ServerString.State = ConnectionState.Open) Then

                        ServerString.Close()


                    End If
                    ServerString.Open()
                    '

                    '
                    Dim Register As New MySqlCommand("Insert into Gatepass_type(Type,Gatepass) VALUES ('" & TextBox_Type.Text & "', @img)", ServerString)

                    Register.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()
                    Register.ExecuteNonQuery()
                    MsgBox("Registration Successful")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                ServerString.Close()
            End If
            '


        ElseIf radio_b = 2 Then

            Dim ms As New MemoryStream
            If TextBox_Type.Text = Nothing Then
                MsgBox("Please Fill in all fields", vbExclamation, "Note")
            End If

            Try
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                If (ServerString.State = ConnectionState.Open) Then

                    ServerString.Close()


                End If
                ServerString.Open()
                Dim Register As New MySqlCommand("update Gatepass_type set  Gatepass =  @img where Type = '" & TextBox_Type.Text & "'", ServerString)

                Register.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()
                Register.ExecuteNonQuery()
                MsgBox("Update Successful")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf radio_b = 3 Then

            Try
                If (ServerString.State = ConnectionState.Open) Then

                    ServerString.Close()


                End If
                ServerString.Open()
                Dim Register As New MySqlCommand("delete from Gatepass_type  where Type = '" & TextBox_Type.Text & "'", ServerString)


                Register.ExecuteNonQuery()
                MsgBox("Deleted")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
        load_dgv()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If


    End Sub

   

    

    Private Sub Gatepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)

        Panel1.BackColor = Color.FromArgb(100, 255, 255, 255)
        RadioButton1.Checked = True
        
       


        load_dgv()


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox_Type.Text = DataGridView1.Rows(e.RowIndex).Cells("Type").Value.ToString
    End Sub

  

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.RowIndex = 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                TextBox_Type.Text = DataGridView1.Rows(e.RowIndex).Cells("Type").Value.ToString
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub load_dgv()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            ServerString.Open()
            Dim Query As String
            Query = "select * from VPAPD.gatepass_type"
            Dim command1 = New MySqlCommand(Query, ServerString)
            SDA.SelectCommand = command1
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)


            ServerString.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)



        Finally
            ServerString.Dispose()



        End Try
        Dim command As New MySqlCommand("select Type,Gatepass from Gatepass_type  ", ServerString)


        Dim table As New DataTable()

        Dim adapter As New MySqlDataAdapter(command)

        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowTemplate.Height = 200


        Dim imgc As New DataGridViewImageColumn()

        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(1)

        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch




    End Sub



    Private Sub Gatepass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Close()

        If Home.warning = vbNo Then
            e.Cancel = True

        End If
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
        Registrationvb.Show()

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
        Me.Show()

    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Profile.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub GatepassStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GatepassStatusToolStripMenuItem.Click
        Me.Hide()
        Profile.Show()

    End Sub
End Class
