Imports MySql.Data.MySqlClient
Public Class Exit_Gate_Loginvb




    Dim ServerString As New MySqlConnection

    Private Sub Login_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim warning As String = MsgBox("Exit Application", vbQuestion + vbYesNo, "EXIT")
        If warning = vbNo Then
            e.Cancel = True







        End If
    End Sub



    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KryptonGroupBox1.Text = "Login"
    End Sub

    Private Sub KryptonButton_Login_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton_Login.Click
        If KryptonTextBox_Username.Text = Nothing Or KryptonTextBox_Password.Text = Nothing Then
            MsgBox("Please Fill all fields!", MsgBoxStyle.Information, "Note")
        Else
            ServerString = New MySqlConnection
            ServerString.ConnectionString = "Server=localhost; user id=root; password=CasQuiLet123; Database= VPAPD;"


            ServerString.Open()
            Dim verify As New MySqlCommand("SELECT * FROM Login WHERE Username= '" & KryptonTextBox_Username.Text & "' and Password= '" & KryptonTextBox_Password.Text & "' ", ServerString)
            Dim verify_Reader As MySqlDataReader



            verify_Reader = verify.ExecuteReader
            If verify_Reader.HasRows Then
                MsgBox("Login Successful", MsgBoxStyle.OkOnly, "Note")
                Me.Hide()
                Exitvb.Show()
            Else
                MsgBox("Login Failed", vbOK, "Note")
                KryptonTextBox_Password.Clear()
                KryptonTextBox_Username.Clear()

            End If
            ServerString.Close()
        End If



    End Sub
End Class
