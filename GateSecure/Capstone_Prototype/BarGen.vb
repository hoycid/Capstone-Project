Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Printing

Public Class BarGen

    Public Serverstring As New MySqlConnection(Home.s)
    Dim COMMAND As MySqlCommand


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)
        visitors_list()



    End Sub




    Dim WithEvents printDoc As New Printing.PrintDocument()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        PrintDialog1.Document = printDoc
        PrintDialog1.PrinterSettings = printDoc.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            DataGridView_Visitors_List.RowHeadersWidth = CInt(DataGridView_Visitors_List.RowHeadersWidth)
            printDoc.PrinterSettings = PrintDialog1.PrinterSettings
            printDoc.Print()
        End If

        ' printDoc.Print()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            Serverstring.Open()
            Dim Query As String
            Query = "update profile set PrintStatus = 'Not Printed' where barcode = '" & txtCode.Text & "'"
            COMMAND = New MySqlCommand(Query, Serverstring)


            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try
    End Sub
    Private Sub PrintImage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        Try



            e.Graphics.DrawImage(PictureBox1.Image, 500, 5, 295, 326)
            e.Graphics.DrawImage(pictBarcode.Image, 600, Margin.Top + 100, 100, 10)
            e.Graphics.DrawString(txtCode.Text, New Font("Times New Roman", 16), Brushes.Gray, 600, 130)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        '
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCode.TextChanged
        Dim str As String = txtCode.Text
        Dim length As Integer = str.Length

        If length = 3 Then

            Generator()


        End If


    End Sub

    Private Sub Generator()

        pictBarcode.Image = Code128Rendering.MakeBarcodeImage(txtCode.Text, 1, True)

        lbCode.Text = txtCode.Text


    End Sub


    Private Sub visitors_list()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        Try
            Serverstring.Open()
            Dim Query As String
            Query = "select Barcode,Type,Lastname,Firstname,Platenumber As 'Plate Number',Vehicletype as 'Vehicle Type',Status from profile where PrintStatus = 'Not Printed'"
            COMMAND = New MySqlCommand(Query, Serverstring)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_Visitors_List.DataSource = bSource

            SDA.Update(dbDataSet)


            Serverstring.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try
    End Sub

    Private Sub DataGridView_Visitors_List_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Visitors_List.CellClick













    End Sub

    Private Sub DataGridView_Visitors_List_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView_Visitors_List.CellContentClick



    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
        Home.Show()

    End Sub

    Private Sub btnGenerator_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub



    Private Sub BarGen_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Close()

        If Home.warning = vbNo Then
            e.Cancel = True

        End If



    End Sub



    Private Sub VehicleLogsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleLogsToolStripMenuItem1.Click
        Me.Hide()
        VehicleLogReport.Show()

    End Sub

    Private Sub EntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Home.Show()

    End Sub



    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Hide()
        Registrationvb.Show()

    End Sub

    Private Sub MonitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitorToolStripMenuItem.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Home.Close()

    End Sub

    Private Sub GenerateBarcodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateBarcodeToolStripMenuItem.Click
        Me.Show()


    End Sub



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView_Visitors_List_Click(sender As Object, e As EventArgs) Handles DataGridView_Visitors_List.Click

    End Sub

    Private Sub DataGridView_Visitors_List_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_Visitors_List.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView_Visitors_List.Rows(e.RowIndex)

            txtCode.Text = row.Cells("Barcode").Value.ToString
        Else
            Serverstring.Dispose()

        End If
        Try


            Dim adapter As New MySqlDataAdapter
            Dim Ds As New DataSet1
            Dim Query As String

            Query = "SELECT * FROM `gatepass_type` WHERE `Type` = '" & DataGridView_Visitors_List.Rows(e.RowIndex).Cells("Type").Value.ToString & "' "


            'data grid view

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable

            Dim bSource As New BindingSource

            If (Serverstring.State = ConnectionState.Open) Then

                Serverstring.Close()


            End If
            Serverstring.Open()

            Dim command As MySqlCommand

            command = New MySqlCommand(Query, Serverstring)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)









            If dbDataSet.Rows.Count() <= 0 Then

                MessageBox.Show("Image not found.")
            Else



                Dim img() As Byte

                img = dbDataSet.Rows(0)(2)

                Dim ms As New MemoryStream(img)

                PictureBox1.Image = Image.FromStream(ms)



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Serverstring.Dispose()
        End Try







    End Sub

    Private Sub DataGridView_Visitors_List_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView_Visitors_List.CellFormatting

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        PrintPreviewDialog1.Document = printDoc
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Hide()
        Profile.Show()

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
