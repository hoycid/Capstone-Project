<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_Vehicle_List = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.DateTimePicker2 = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_Total = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.V_Total = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label_Gatepass = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_Lname = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Barcode = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label_Vehicle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_VehicleType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_PlateNumber = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label_Plate = New System.Windows.Forms.Label()
        Me.Label_Muffler = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddVisitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehicleLogsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Vehicle_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.label_Total.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.KryptonDataGridView1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView_Vehicle_List)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.label_Total)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label_Muffler)
        Me.Panel1.Location = New System.Drawing.Point(39, 45)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1694, 851)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Gate_Secure.My.Resources.Resources.BUKSULOGO
        Me.PictureBox2.Location = New System.Drawing.Point(1549, 623)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 145)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 173
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1292, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 401)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 158
        Me.PictureBox1.TabStop = False
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AllowUserToResizeColumns = False
        Me.KryptonDataGridView1.AllowUserToResizeRows = False
        Me.KryptonDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.KryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.KryptonDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.KryptonDataGridView1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.KryptonDataGridView1.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.KryptonDataGridView1.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.KryptonDataGridView1.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.KryptonDataGridView1.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(635, 592)
        Me.KryptonDataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        Me.KryptonDataGridView1.RowHeadersVisible = False
        Me.KryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.KryptonDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.KryptonDataGridView1.RowTemplate.Height = 24
        Me.KryptonDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.KryptonDataGridView1.ShowEditingIcon = False
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(889, 251)
        Me.KryptonDataGridView1.StateNormal.Background.Color1 = System.Drawing.Color.Transparent
        Me.KryptonDataGridView1.TabIndex = 172
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(635, 549)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(889, 41)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Vehicle Log"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView_Vehicle_List
        '
        Me.DataGridView_Vehicle_List.AllowUserToAddRows = False
        Me.DataGridView_Vehicle_List.AllowUserToDeleteRows = False
        Me.DataGridView_Vehicle_List.AllowUserToResizeColumns = False
        Me.DataGridView_Vehicle_List.AllowUserToResizeRows = False
        Me.DataGridView_Vehicle_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Vehicle_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_Vehicle_List.Location = New System.Drawing.Point(15, 261)
        Me.DataGridView_Vehicle_List.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView_Vehicle_List.Name = "DataGridView_Vehicle_List"
        Me.DataGridView_Vehicle_List.ReadOnly = True
        Me.DataGridView_Vehicle_List.RowHeadersVisible = False
        Me.DataGridView_Vehicle_List.RowTemplate.Height = 24
        Me.DataGridView_Vehicle_List.Size = New System.Drawing.Size(576, 582)
        Me.DataGridView_Vehicle_List.StateNormal.Background.Color1 = System.Drawing.Color.Transparent
        Me.DataGridView_Vehicle_List.TabIndex = 101
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Controls.Add(Me.DateTimePicker2)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(3, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1688, 128)
        Me.Panel5.TabIndex = 167
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "HH:mm:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1369, 11)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(301, 78)
        Me.DateTimePicker1.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.TabIndex = 118
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(1369, 97)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(152, 29)
        Me.DateTimePicker2.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.StateCommon.Content.Padding = New System.Windows.Forms.Padding(1, -1, -1, 1)
        Me.DateTimePicker2.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(572, 108)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "ENTRANCE"
        '
        'label_Total
        '
        Me.label_Total.BackColor = System.Drawing.Color.Gray
        Me.label_Total.Controls.Add(Me.Panel4)
        Me.label_Total.Controls.Add(Me.Label11)
        Me.label_Total.Location = New System.Drawing.Point(119, 135)
        Me.label_Total.Name = "label_Total"
        Me.label_Total.Size = New System.Drawing.Size(259, 47)
        Me.label_Total.TabIndex = 155
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.V_Total)
        Me.Panel4.Location = New System.Drawing.Point(174, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(82, 41)
        Me.Panel4.TabIndex = 98
        '
        'V_Total
        '
        Me.V_Total.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V_Total.AutoSize = True
        Me.V_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_Total.ForeColor = System.Drawing.Color.White
        Me.V_Total.Location = New System.Drawing.Point(14, 8)
        Me.V_Total.Name = "V_Total"
        Me.V_Total.Size = New System.Drawing.Size(60, 25)
        Me.V_Total.TabIndex = 97
        Me.V_Total.Text = "9999"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(20, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 25)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Vehicle Count:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SkyBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(576, 41)
        Me.Label10.TabIndex = 168
        Me.Label10.Text = "Vehicle Monitor"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Barcode)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label_VehicleType)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label_PlateNumber)
        Me.Panel6.Controls.Add(Me.Panel11)
        Me.Panel6.Location = New System.Drawing.Point(635, 135)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(651, 401)
        Me.Panel6.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 33)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Lastname:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.Label_Gatepass)
        Me.Panel9.Location = New System.Drawing.Point(210, 180)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(413, 36)
        Me.Panel9.TabIndex = 101
        '
        'Label_Gatepass
        '
        Me.Label_Gatepass.AutoSize = True
        Me.Label_Gatepass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Gatepass.Location = New System.Drawing.Point(3, 1)
        Me.Label_Gatepass.Name = "Label_Gatepass"
        Me.Label_Gatepass.Size = New System.Drawing.Size(37, 29)
        Me.Label_Gatepass.TabIndex = 105
        Me.Label_Gatepass.Text = "---"
        Me.Label_Gatepass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 29)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Barcode:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label_Name)
        Me.Panel3.Location = New System.Drawing.Point(194, 110)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(429, 50)
        Me.Panel3.TabIndex = 100
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(-2, -5)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(72, 55)
        Me.Label_Name.TabIndex = 81
        Me.Label_Name.Text = "---"
        Me.Label_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label_Lname)
        Me.Panel2.Location = New System.Drawing.Point(194, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 67)
        Me.Panel2.TabIndex = 99
        '
        'Label_Lname
        '
        Me.Label_Lname.AutoSize = True
        Me.Label_Lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Lname.Location = New System.Drawing.Point(-5, 0)
        Me.Label_Lname.Name = "Label_Lname"
        Me.Label_Lname.Size = New System.Drawing.Size(95, 73)
        Me.Label_Lname.TabIndex = 82
        Me.Label_Lname.Text = "---"
        Me.Label_Lname.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 31)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Firstname:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Barcode
        '
        Me.Barcode.Location = New System.Drawing.Point(39, 297)
        Me.Barcode.Margin = New System.Windows.Forms.Padding(2)
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Size = New System.Drawing.Size(146, 43)
        Me.Barcode.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barcode.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 29)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Gatepass Type:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.Label_Vehicle)
        Me.Panel8.Location = New System.Drawing.Point(421, 262)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(202, 36)
        Me.Panel8.TabIndex = 169
        '
        'Label_Vehicle
        '
        Me.Label_Vehicle.AutoSize = True
        Me.Label_Vehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Vehicle.Location = New System.Drawing.Point(5, 5)
        Me.Label_Vehicle.Name = "Label_Vehicle"
        Me.Label_Vehicle.Size = New System.Drawing.Size(37, 29)
        Me.Label_Vehicle.TabIndex = 100
        Me.Label_Vehicle.Text = "---"
        Me.Label_Vehicle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(265, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 29)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "Plate Number:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_VehicleType
        '
        Me.Label_VehicleType.AutoSize = True
        Me.Label_VehicleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_VehicleType.Location = New System.Drawing.Point(151, 262)
        Me.Label_VehicleType.Name = "Label_VehicleType"
        Me.Label_VehicleType.Size = New System.Drawing.Size(0, 29)
        Me.Label_VehicleType.TabIndex = 162
        Me.Label_VehicleType.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(265, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 29)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Vehicle Type:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_PlateNumber
        '
        Me.Label_PlateNumber.AutoSize = True
        Me.Label_PlateNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PlateNumber.Location = New System.Drawing.Point(150, 266)
        Me.Label_PlateNumber.Name = "Label_PlateNumber"
        Me.Label_PlateNumber.Size = New System.Drawing.Size(0, 29)
        Me.Label_PlateNumber.TabIndex = 163
        Me.Label_PlateNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.Label_Plate)
        Me.Panel11.Location = New System.Drawing.Point(421, 314)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(202, 36)
        Me.Panel11.TabIndex = 171
        '
        'Label_Plate
        '
        Me.Label_Plate.AutoSize = True
        Me.Label_Plate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Plate.Location = New System.Drawing.Point(5, 4)
        Me.Label_Plate.Name = "Label_Plate"
        Me.Label_Plate.Size = New System.Drawing.Size(37, 29)
        Me.Label_Plate.TabIndex = 101
        Me.Label_Plate.Text = "---"
        Me.Label_Plate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_Muffler
        '
        Me.Label_Muffler.AutoSize = True
        Me.Label_Muffler.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Muffler.Location = New System.Drawing.Point(1302, 398)
        Me.Label_Muffler.Name = "Label_Muffler"
        Me.Label_Muffler.Size = New System.Drawing.Size(0, 29)
        Me.Label_Muffler.TabIndex = 164
        Me.Label_Muffler.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1811, 24)
        Me.MenuStrip1.TabIndex = 175
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddVisitorToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddVisitorToolStripMenuItem
        '
        Me.AddVisitorToolStripMenuItem.Name = "AddVisitorToolStripMenuItem"
        Me.AddVisitorToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AddVisitorToolStripMenuItem.Text = "Add Visitor"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VehicleLogsToolStripMenuItem1, Me.ExitGateToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ReportsToolStripMenuItem.Text = "Gate Type"
        '
        'VehicleLogsToolStripMenuItem1
        '
        Me.VehicleLogsToolStripMenuItem1.Name = "VehicleLogsToolStripMenuItem1"
        Me.VehicleLogsToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.VehicleLogsToolStripMenuItem1.Text = "Entrance Gate"
        '
        'ExitGateToolStripMenuItem
        '
        Me.ExitGateToolStripMenuItem.Name = "ExitGateToolStripMenuItem"
        Me.ExitGateToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ExitGateToolStripMenuItem.Text = "Exit Gate"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 896)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1811, 34)
        Me.StatusStrip1.TabIndex = 176
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1765, 29)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "GateSecure By: Cidrex A. Quilang - Mary Catherine  G. Letimas - Jerson R. Castro"
        Me.ToolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Gate_Secure.My.Resources.Resources._19577456_1876207412633979_5519870710012282142_o
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1811, 930)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Home"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "GateSecure - Entrance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Vehicle_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.label_Total.ResumeLayout(False)
        Me.label_Total.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label_Total As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents V_Total As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label_Plate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label_PlateNumber As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label_Vehicle As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label_Gatepass As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label_Name As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label_Lname As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_VehicleType As System.Windows.Forms.Label
    Friend WithEvents Label_Muffler As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents DataGridView_Vehicle_List As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DateTimePicker1 As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents DateTimePicker2 As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents Barcode As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddVisitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehicleLogsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitGateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
