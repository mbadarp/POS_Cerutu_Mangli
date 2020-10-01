<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPackagingChecking
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_checkpack = New System.Windows.Forms.DataGridView()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_brand = New System.Windows.Forms.ComboBox()
        Me.txt_inspector = New System.Windows.Forms.TextBox()
        Me.cbo_cigarsize = New System.Windows.Forms.ComboBox()
        Me.cbo_cigarshape = New System.Windows.Forms.ComboBox()
        Me.dt_tglanalisis = New System.Windows.Forms.DateTimePicker()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_totalbefore = New System.Windows.Forms.Label()
        Me.txt_crack = New System.Windows.Forms.TextBox()
        Me.txt_texture = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_totalduring = New System.Windows.Forms.Label()
        Me.txt_ring = New System.Windows.Forms.TextBox()
        Me.txt_cellopduring = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_cukai = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LBL_totalafter = New System.Windows.Forms.Label()
        Me.txt_prodcode = New System.Windows.Forms.TextBox()
        Me.txt_cellopafter = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_kodecheck = New System.Windows.Forms.TextBox()
        Me.cbo_kodebarang = New System.Windows.Forms.ComboBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        CType(Me.dgv_checkpack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Packaging Checking Form"
        '
        'dgv_checkpack
        '
        Me.dgv_checkpack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_checkpack.Location = New System.Drawing.Point(12, 304)
        Me.dgv_checkpack.Name = "dgv_checkpack"
        Me.dgv_checkpack.Size = New System.Drawing.Size(872, 243)
        Me.dgv_checkpack.TabIndex = 1
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(250, 275)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(75, 23)
        Me.btn_input.TabIndex = 16
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(352, 275)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(454, 275)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 4
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_tutup
        '
        Me.btn_tutup.Location = New System.Drawing.Point(551, 275)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(75, 23)
        Me.btn_tutup.TabIndex = 17
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(13, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cigar Size"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(13, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cigar Shape"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(13, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 27)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Inspector"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(13, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Analysis"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(13, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Remarks"
        '
        'cbo_brand
        '
        Me.cbo_brand.FormattingEnabled = True
        Me.cbo_brand.Location = New System.Drawing.Point(104, 114)
        Me.cbo_brand.Name = "cbo_brand"
        Me.cbo_brand.Size = New System.Drawing.Size(121, 21)
        Me.cbo_brand.TabIndex = 2
        '
        'txt_inspector
        '
        Me.txt_inspector.Location = New System.Drawing.Point(104, 142)
        Me.txt_inspector.Name = "txt_inspector"
        Me.txt_inspector.Size = New System.Drawing.Size(121, 20)
        Me.txt_inspector.TabIndex = 3
        '
        'cbo_cigarsize
        '
        Me.cbo_cigarsize.FormattingEnabled = True
        Me.cbo_cigarsize.Location = New System.Drawing.Point(104, 169)
        Me.cbo_cigarsize.Name = "cbo_cigarsize"
        Me.cbo_cigarsize.Size = New System.Drawing.Size(121, 21)
        Me.cbo_cigarsize.TabIndex = 4
        '
        'cbo_cigarshape
        '
        Me.cbo_cigarshape.FormattingEnabled = True
        Me.cbo_cigarshape.Location = New System.Drawing.Point(104, 195)
        Me.cbo_cigarshape.Name = "cbo_cigarshape"
        Me.cbo_cigarshape.Size = New System.Drawing.Size(121, 21)
        Me.cbo_cigarshape.TabIndex = 5
        '
        'dt_tglanalisis
        '
        Me.dt_tglanalisis.CustomFormat = "yyyy-MM-dd"
        Me.dt_tglanalisis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_tglanalisis.Location = New System.Drawing.Point(104, 222)
        Me.dt_tglanalisis.Name = "dt_tglanalisis"
        Me.dt_tglanalisis.Size = New System.Drawing.Size(121, 20)
        Me.dt_tglanalisis.TabIndex = 6
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(104, 248)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(121, 20)
        Me.txt_remarks.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.LBL_totalbefore)
        Me.GroupBox1.Controls.Add(Me.txt_crack)
        Me.GroupBox1.Controls.Add(Me.txt_texture)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.txt_size)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(297, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 167)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Before Packaging"
        '
        'LBL_totalbefore
        '
        Me.LBL_totalbefore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_totalbefore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_totalbefore.Location = New System.Drawing.Point(80, 131)
        Me.LBL_totalbefore.Name = "LBL_totalbefore"
        Me.LBL_totalbefore.Size = New System.Drawing.Size(97, 28)
        Me.LBL_totalbefore.TabIndex = 28
        Me.LBL_totalbefore.Text = "LBLTotal Reject"
        '
        'txt_crack
        '
        Me.txt_crack.Location = New System.Drawing.Point(80, 103)
        Me.txt_crack.Name = "txt_crack"
        Me.txt_crack.Size = New System.Drawing.Size(97, 20)
        Me.txt_crack.TabIndex = 11
        '
        'txt_texture
        '
        Me.txt_texture.Location = New System.Drawing.Point(80, 73)
        Me.txt_texture.Name = "txt_texture"
        Me.txt_texture.Size = New System.Drawing.Size(97, 20)
        Me.txt_texture.TabIndex = 10
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(80, 45)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(97, 20)
        Me.txt_color.TabIndex = 9
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(80, 17)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(97, 20)
        Me.txt_size.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 28)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Total Reject"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 28)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Crack"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Texture"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 28)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Color"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 28)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Size"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBL_totalduring)
        Me.GroupBox2.Controls.Add(Me.txt_ring)
        Me.GroupBox2.Controls.Add(Me.txt_cellopduring)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(497, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 167)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "During Packaging"
        '
        'LBL_totalduring
        '
        Me.LBL_totalduring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_totalduring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_totalduring.Location = New System.Drawing.Point(80, 73)
        Me.LBL_totalduring.Name = "LBL_totalduring"
        Me.LBL_totalduring.Size = New System.Drawing.Size(97, 28)
        Me.LBL_totalduring.TabIndex = 29
        Me.LBL_totalduring.Text = "LBLTotal Reject"
        '
        'txt_ring
        '
        Me.txt_ring.Location = New System.Drawing.Point(80, 45)
        Me.txt_ring.Name = "txt_ring"
        Me.txt_ring.Size = New System.Drawing.Size(97, 20)
        Me.txt_ring.TabIndex = 13
        '
        'txt_cellopduring
        '
        Me.txt_cellopduring.Location = New System.Drawing.Point(80, 17)
        Me.txt_cellopduring.Name = "txt_cellopduring"
        Me.txt_cellopduring.Size = New System.Drawing.Size(97, 20)
        Me.txt_cellopduring.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 28)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Total Reject"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 28)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Ring"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 28)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Cellop"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_cukai)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.LBL_totalafter)
        Me.GroupBox3.Controls.Add(Me.txt_prodcode)
        Me.GroupBox3.Controls.Add(Me.txt_cellopafter)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(701, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 167)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "After Packaging"
        '
        'txt_cukai
        '
        Me.txt_cukai.Location = New System.Drawing.Point(80, 73)
        Me.txt_cukai.Name = "txt_cukai"
        Me.txt_cukai.Size = New System.Drawing.Size(97, 20)
        Me.txt_cukai.TabIndex = 32
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 28)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Cukai"
        '
        'LBL_totalafter
        '
        Me.LBL_totalafter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_totalafter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_totalafter.Location = New System.Drawing.Point(80, 101)
        Me.LBL_totalafter.Name = "LBL_totalafter"
        Me.LBL_totalafter.Size = New System.Drawing.Size(97, 28)
        Me.LBL_totalafter.TabIndex = 29
        Me.LBL_totalafter.Text = "LBLTotal Reject"
        '
        'txt_prodcode
        '
        Me.txt_prodcode.Location = New System.Drawing.Point(80, 45)
        Me.txt_prodcode.Name = "txt_prodcode"
        Me.txt_prodcode.Size = New System.Drawing.Size(97, 20)
        Me.txt_prodcode.TabIndex = 15
        '
        'txt_cellopafter
        '
        Me.txt_cellopafter.Location = New System.Drawing.Point(80, 17)
        Me.txt_cellopafter.Name = "txt_cellopafter"
        Me.txt_cellopafter.Size = New System.Drawing.Size(97, 20)
        Me.txt_cellopafter.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 28)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Total Reject"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 28)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Prod. Code"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 28)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Cellop"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Location = New System.Drawing.Point(13, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 28)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Kode Barang"
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Location = New System.Drawing.Point(13, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 28)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Checking Code"
        '
        'txt_kodecheck
        '
        Me.txt_kodecheck.Location = New System.Drawing.Point(104, 58)
        Me.txt_kodecheck.Name = "txt_kodecheck"
        Me.txt_kodecheck.Size = New System.Drawing.Size(121, 20)
        Me.txt_kodecheck.TabIndex = 22
        '
        'cbo_kodebarang
        '
        Me.cbo_kodebarang.FormattingEnabled = True
        Me.cbo_kodebarang.Location = New System.Drawing.Point(104, 87)
        Me.cbo_kodebarang.Name = "cbo_kodebarang"
        Me.cbo_kodebarang.Size = New System.Drawing.Size(121, 21)
        Me.cbo_kodebarang.TabIndex = 1
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(643, 275)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(75, 23)
        Me.btn_cetak.TabIndex = 23
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'FormPackagingChecking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(896, 559)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.cbo_kodebarang)
        Me.Controls.Add(Me.txt_kodecheck)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.dt_tglanalisis)
        Me.Controls.Add(Me.cbo_cigarshape)
        Me.Controls.Add(Me.cbo_cigarsize)
        Me.Controls.Add(Me.txt_inspector)
        Me.Controls.Add(Me.cbo_brand)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.dgv_checkpack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPackagingChecking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPackagingChecking"
        CType(Me.dgv_checkpack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_checkpack As System.Windows.Forms.DataGridView
    Friend WithEvents btn_input As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_tutup As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo_brand As System.Windows.Forms.ComboBox
    Friend WithEvents txt_inspector As System.Windows.Forms.TextBox
    Friend WithEvents cbo_cigarsize As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cigarshape As System.Windows.Forms.ComboBox
    Friend WithEvents dt_tglanalisis As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_crack As System.Windows.Forms.TextBox
    Friend WithEvents txt_texture As System.Windows.Forms.TextBox
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents txt_size As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ring As System.Windows.Forms.TextBox
    Friend WithEvents txt_cellopduring As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_prodcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_cellopafter As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_kodecheck As System.Windows.Forms.TextBox
    Friend WithEvents cbo_kodebarang As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_totalbefore As System.Windows.Forms.Label
    Friend WithEvents LBL_totalduring As System.Windows.Forms.Label
    Friend WithEvents LBL_totalafter As System.Windows.Forms.Label
    Friend WithEvents txt_cukai As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
End Class
