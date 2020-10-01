<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterCerutu
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_cigarbrand = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbo_cigarsize = New System.Windows.Forms.ComboBox()
        Me.dt_produksi = New System.Windows.Forms.DateTimePicker()
        Me.txt_kodeproduk = New System.Windows.Forms.TextBox()
        Me.txt_rollername = New System.Windows.Forms.TextBox()
        Me.txt_jumlahproduk = New System.Windows.Forms.TextBox()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btn_cetak = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Location = New System.Drawing.Point(12, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 28)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Kode Produk"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 28)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Cigar Brand"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Cigar Size"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 28)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Rolle's Name"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(12, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 28)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Jumlah Produk"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 28)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Production Date"
        '
        'cbo_cigarbrand
        '
        Me.cbo_cigarbrand.FormattingEnabled = True
        Me.cbo_cigarbrand.Location = New System.Drawing.Point(107, 66)
        Me.cbo_cigarbrand.Name = "cbo_cigarbrand"
        Me.cbo_cigarbrand.Size = New System.Drawing.Size(121, 21)
        Me.cbo_cigarbrand.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(732, 251)
        Me.DataGridView1.TabIndex = 29
        '
        'cbo_cigarsize
        '
        Me.cbo_cigarsize.FormattingEnabled = True
        Me.cbo_cigarsize.Location = New System.Drawing.Point(107, 94)
        Me.cbo_cigarsize.Name = "cbo_cigarsize"
        Me.cbo_cigarsize.Size = New System.Drawing.Size(121, 21)
        Me.cbo_cigarsize.TabIndex = 30
        '
        'dt_produksi
        '
        Me.dt_produksi.CustomFormat = "yyyy-MM-dd"
        Me.dt_produksi.Enabled = False
        Me.dt_produksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_produksi.Location = New System.Drawing.Point(107, 178)
        Me.dt_produksi.Name = "dt_produksi"
        Me.dt_produksi.Size = New System.Drawing.Size(121, 20)
        Me.dt_produksi.TabIndex = 31
        '
        'txt_kodeproduk
        '
        Me.txt_kodeproduk.Location = New System.Drawing.Point(107, 38)
        Me.txt_kodeproduk.Name = "txt_kodeproduk"
        Me.txt_kodeproduk.Size = New System.Drawing.Size(121, 20)
        Me.txt_kodeproduk.TabIndex = 32
        '
        'txt_rollername
        '
        Me.txt_rollername.Location = New System.Drawing.Point(107, 122)
        Me.txt_rollername.Name = "txt_rollername"
        Me.txt_rollername.Size = New System.Drawing.Size(121, 20)
        Me.txt_rollername.TabIndex = 33
        '
        'txt_jumlahproduk
        '
        Me.txt_jumlahproduk.Location = New System.Drawing.Point(107, 150)
        Me.txt_jumlahproduk.Name = "txt_jumlahproduk"
        Me.txt_jumlahproduk.Size = New System.Drawing.Size(121, 20)
        Me.txt_jumlahproduk.TabIndex = 34
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(173, 222)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(75, 38)
        Me.btn_input.TabIndex = 35
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(254, 222)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 38)
        Me.btn_edit.TabIndex = 36
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(335, 222)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 38)
        Me.btn_hapus.TabIndex = 37
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_tutup
        '
        Me.btn_tutup.Location = New System.Drawing.Point(497, 222)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(75, 38)
        Me.btn_tutup.TabIndex = 38
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.UseVisualStyleBackColor = True
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(416, 222)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(75, 38)
        Me.btn_cetak.TabIndex = 39
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'FormMasterCerutu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 529)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.txt_jumlahproduk)
        Me.Controls.Add(Me.txt_rollername)
        Me.Controls.Add(Me.txt_kodeproduk)
        Me.Controls.Add(Me.dt_produksi)
        Me.Controls.Add(Me.cbo_cigarsize)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbo_cigarbrand)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label20)
        Me.Name = "FormMasterCerutu"
        Me.Text = "FormMasterCerutu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_cigarbrand As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_cigarsize As System.Windows.Forms.ComboBox
    Friend WithEvents dt_produksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_kodeproduk As System.Windows.Forms.TextBox
    Friend WithEvents txt_rollername As System.Windows.Forms.TextBox
    Friend WithEvents txt_jumlahproduk As System.Windows.Forms.TextBox
    Friend WithEvents btn_input As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_tutup As System.Windows.Forms.Button
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
End Class
