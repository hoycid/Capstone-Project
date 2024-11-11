Imports MySql.Data.MySqlClient

Public Class AddVisitor
    Public Serverstring As New MySqlConnection(Home.s)






    Private Sub KryptonTextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonTextBox_Barcode.TextChanged


        load_insert_profile()





    End Sub


    Private Sub load_insert_profile()
        If KryptonTextBox_Barcode.Text = Nothing Or KryptonTextBox_Firstname.Text = Nothing Or KryptonTextBox_Lastname.Text = Nothing Or KryptonTextBox_PlateNumber.Text = Nothing Then
            KryptonLabel.Text = "Please fill all fields"

        End If
        Try



            Dim str As String = KryptonTextBox_Barcode.Text
            Dim length As Integer = str.Length

            If length = 4 Then
                If (Serverstring.State = ConnectionState.Open) Then
                    Serverstring.Close()


                End If
                Serverstring.Open()


                Dim Register As New MySqlCommand("Insert into Profile(Barcode, PlateNumber, FirstName, LastName,Type,Status) VALUES ('" & KryptonTextBox_Barcode.Text & "', '" & KryptonTextBox_PlateNumber.Text & "', '" & KryptonTextBox_Firstname.Text & "', '" & KryptonTextBox_Lastname.Text & "', '" & "Visitor" & "','Active')", Serverstring)
                Register.ExecuteNonQuery()
                Serverstring.Close()
                KryptonLabel.Text = "Registered"
            End If
        Catch ex As Exception
            KryptonLabel.Text = ex.Message
        End Try

    End Sub

    Private Sub AddVisitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()


    End Sub


    Private Sub ExitGateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitGateToolStripMenuItem.Click
        Me.Hide()
        Exitvb.Show()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Home.Close()



    End Sub

    Private Sub VehicleLogsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleLogsToolStripMenuItem1.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub AddVisitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(190, 255, 255, 255)
        MenuStrip1.BackColor = Color.FromArgb(222, 255, 255, 255)
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)
    End Sub
End Class