Imports MySql.Data.MySqlClient

Public Class VehicleLogReport
    Public Serverstring As New MySqlConnection(Home.s)
    Dim status As String

    Public c_entry As Int16
    Public count_exit As Int16







    Private Sub VehicleLogsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleLogsToolStripMenuItem1.Click
        Me.Show()

    End Sub

    Private Sub EntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Home.Show()

    End Sub


    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Hide()
        Registrationvb.Show()

    End Sub




    Private Sub KryptonPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Me.CenterToParent()

    End Sub

    Private Sub VehicleLogReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel2.Location = New Point((Me.Width - Panel2.Width) \ 2, (Me.Height - Panel2.Height) \ 2)
    End Sub

    Private Sub ComboBox_Gatepass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Gatepass.SelectedIndexChanged

        Dim filter As String

        filter = ComboBox_Gatepass.Text
        Dim adapter As New MySqlDataAdapter
        Dim Ds As New DataSet1
        Dim Query As String
        If ComboBox1.Text = Nothing Then

            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type' from vehicle_logs where Type = '" & filter & "' and date = '" & DateTimePicker2.Text & "'  and Status = '" & status & "' ORDER BY Time DESC"

        Else

            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type' from vehicle_logs where Type = '" & filter & "' and entrytype  = '" & ComboBox1.Text & "' and date = '" & DateTimePicker2.Text & "'  and Status = '" & status & "' ORDER BY Time DESC"
        End If

        'data grid view

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            If (Serverstring.State = ConnectionState.Open) Then

                Serverstring.Close()


            End If
            Serverstring.Open()

            Dim command As MySqlCommand

            command = New MySqlCommand(Query, Serverstring)
            '



            Dim r_Reader As MySqlDataReader



            r_Reader = command.ExecuteReader

            c_entry = 0
            count_exit = 0

            If r_Reader.HasRows Then

                While r_Reader.Read

                    If r_Reader.GetString("Entry Type") = "Entry" Then
                        c_entry = c_entry + 1
                    Else
                        count_exit = count_exit + 1
                    End If




                End While
            End If









            If (Serverstring.State = ConnectionState.Open) Then

                Serverstring.Close()


            End If

            '
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            KryptonDataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)



            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try




    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        load_table_vehiclelogs()





        Dim filter As String
        filter = DateTimePicker2.Text
        Dim adapter As New MySqlDataAdapter
        Dim Ds As New DataSet1



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim filter As String
        filter = ComboBox1.Text
        Dim adapter As New MySqlDataAdapter
        Dim Ds As New DataSet1
        Dim Query As String

        If ComboBox_Gatepass.Text = Nothing Then

            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type' from vehicle_logs where entrytype  = '" & filter & "'  and date = '" & DateTimePicker2.Text & "'and Status = '" & status & "' ORDER BY Time DESC"
        Else

            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type' from vehicle_logs where entrytype = '" & filter & "' and Type = '" & ComboBox_Gatepass.Text & "' and date = '" & DateTimePicker2.Text & "'and Status = '" & status & "' ORDER BY Time DESC"


        End If


        'data grid view

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        If (Serverstring.State = ConnectionState.Open) Then

            Serverstring.Close()


        End If
        Serverstring.Open()

        Dim bSource As New BindingSource
        Try



            Dim command As MySqlCommand

            command = New MySqlCommand(Query, Serverstring)


            '



            Dim r_Reader As MySqlDataReader



            r_Reader = command.ExecuteReader

            c_entry = 0
            count_exit = 0

            If r_Reader.HasRows Then

                While r_Reader.Read

                    If r_Reader.GetString("Entry Type") = "Entry" Then
                        c_entry += 1
                    Else
                        count_exit = count_exit + 1
                    End If




                End While
            End If











            '
            If (Serverstring.State = ConnectionState.Open) Then

                Serverstring.Close()


            End If
            Serverstring.Open()
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            KryptonDataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)



            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try




    End Sub

    Private Sub MonitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitorToolStripMenuItem.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub GenerateBarcodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateBarcodeToolStripMenuItem.Click
        Me.Hide()
        BarGen.Show()

    End Sub



    Private Sub VehicleLogReport_Load1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RadioButton1.Checked = True
        Panel2.Location = New Point((Me.Width - Panel2.Width) \ 2, (Me.Height - Panel2.Height) \ 2)
        Panel2.BackColor = Color.FromArgb(100, 255, 255, 255)
        'OPPAcity ,R,G,B                       
        'MenuStrip1.BackColor = Color.FromArgb(100, 0, 0, 100)
        KryptonDataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("SansSerif", 20, FontStyle.Bold)














        load_table_vehiclelogs()

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim select_table As New MySqlCommand("select * FROM gatepass_type ", Serverstring)
        Dim Reader As MySqlDataReader


        Serverstring.Open()
        Reader = select_table.ExecuteReader


        While Reader.Read
            Dim type = Reader.GetString("Type")
            ComboBox_Gatepass.Items.Add(type)
        End While
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click


        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            KryptonDataGridView1.RowHeadersWidth = CInt(KryptonDataGridView1.RowHeadersWidth)
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If




    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure

    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer




    Dim mRow As Integer = 0
    Dim pagenum As Integer = 1
    Dim reportfor As String

    Dim brush As New SolidBrush(Color.Black)
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If ComboBox1.Text = Nothing Then

            reportfor = "All"
        Else
            reportfor = ComboBox1.Text
        End If
        If pagenum = 1 Then


            e.Graphics.DrawString("Entry Logs Total: " + c_entry.ToString + "              Exit Logs Total: " + count_exit.ToString, New Font("Times New Roman", 16), Brushes.Gray, 180, 230)
        End If


        Dim newpage As Boolean = True


        e.Graphics.DrawImage(PictureBox1.Image, 100, 50, PictureBox1.Width, PictureBox1.Height)
        e.Graphics.DrawString("Vehicle Log Report As Of : " + DateTimePicker2.Text, New Font("Times New Roman", 22), brush, 200, 170)
        With KryptonDataGridView1



            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top + 190

            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left - 30
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, 90, 21)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)


                    If (newpage = True) Then
                        e.Graphics.DrawString(KryptonDataGridView1.Columns(cell.ColumnIndex).HeaderText, New Font("Arial", 9, FontStyle.Bold), Brushes.Black, rc, fmt)




                    Else
                        e.Graphics.DrawString(KryptonDataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                Dim drawFont As New Font("Arial", 8.75)

                e.Graphics.DrawString("Status", drawFont, Brushes.Gray, 100, e.PageBounds.Bottom - 90)
                e.Graphics.DrawString("Date Created", drawFont, Brushes.Gray, 100, e.PageBounds.Bottom - 76)
                e.Graphics.DrawString("Page Number", drawFont, Brushes.Gray, 100, e.PageBounds.Bottom - 62)

                ' Draw some grid lines to add structure to the footer information
                e.Graphics.DrawLine(Pens.Gray, 200, e.PageBounds.Bottom - 90, 200, e.PageBounds.Bottom - 48)
                e.Graphics.DrawLine(Pens.Gray, 100, e.PageBounds.Bottom - 75, 550, e.PageBounds.Bottom - 75)
                e.Graphics.DrawLine(Pens.Gray, 100, e.PageBounds.Bottom - 61, 550, e.PageBounds.Bottom - 61)

                e.Graphics.DrawString(status, drawFont, Brushes.Black, 250, e.PageBounds.Bottom - 90)
                e.Graphics.DrawString(Date.Now.ToShortDateString & " " & Date.Now.ToShortTimeString, drawFont, Brushes.Black, 250, e.PageBounds.Bottom - 76)
                e.Graphics.DrawString(pagenum, drawFont, Brushes.Black, 250, e.PageBounds.Bottom - 62)
                y += h
                mRow += 1
                If (newpage = True And mRow = 1) Then
                    mRow = mRow - 1
                    newpage = False
                End If
                newpage = False
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    pagenum += 1
                    Exit Sub


                End If
            Loop

            mRow = 0


        End With


    End Sub
    Private Sub load_table_vehiclelogs()
        Dim compdate As String
        compdate = DateTimePicker2.Text


        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            If (Serverstring.State = ConnectionState.Open) Then
                Serverstring.Close()


            End If
            Serverstring.Open()
            Dim Query As String
            Dim command As MySqlCommand
            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type' from vehicle_logs where date= '" & compdate & "' and Status = '" & status & "' ORDER BY Time DESC"
            command = New MySqlCommand(Query, Serverstring)
            '



            Dim r_Reader As MySqlDataReader



            r_Reader = command.ExecuteReader

            c_entry = 0
            count_exit = 0

            If r_Reader.HasRows Then

                While r_Reader.Read

                    If r_Reader.GetString("Entry Type") = "Entry" Then
                        c_entry = c_entry + 1
                    Else
                        count_exit = count_exit + 1
                    End If




                End While
            End If





            If (Serverstring.State = ConnectionState.Open) Then

                Serverstring.Close()


            End If





            '
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            KryptonDataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)



            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try
    End Sub


    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Me.CenterToParent()
    End Sub


    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        ComboBox_Gatepass.Text = Nothing
        ComboBox1.Text = Nothing

        Dim compdate As String
        compdate = DateTimePicker2.Text

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            If (Serverstring.State = ConnectionState.Open) Then
                Serverstring.Close()


            End If
            Serverstring.Open()
            Dim Query As String
            Dim command As MySqlCommand

            Query = "select entrytype as 'Entry Type',Time,Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type' from vehicle_logs where date= '" & compdate & "' and Status = '" & status & "' ORDER BY Time DESC"

            command = New MySqlCommand(Query, Serverstring)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            KryptonDataGridView1.DataSource = bSource

            SDA.Update(dbDataSet)



            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try
    End Sub

    Private Sub PrintPreviewDialog1_Closed(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Closed
        pagenum = 1
    End Sub

    Private Sub PrintPreviewDialog1_Shown(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Shown
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
    End Sub

   


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        status = "Stolen"
        load_table_vehiclelogs()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        status = "Active"
        load_table_vehiclelogs()

    End Sub

    Private Sub VehicleLogReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Close()
        If Home.warning = vbNo Then
            e.Cancel = True

        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ConfigureGatepassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureGatepassToolStripMenuItem.Click
        Me.Hide()
        Gatepass.Show()

    End Sub

    Private Sub GatepassStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GatepassStatusToolStripMenuItem.Click
        Me.Hide()
        Profile.Show()

    End Sub
End Class