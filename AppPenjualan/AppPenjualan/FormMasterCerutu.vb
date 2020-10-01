Imports System.Data.Odbc
Public Class FormMasterCerutu
    Sub KondisiAwal()
        txt_kodeproduk.Text = ""
        txt_rollername.Text = ""
        txt_jumlahproduk.Text = ""
        cbo_cigarbrand.Items.Clear()
        cbo_cigarsize.Items.Clear()
        cbo_cigarsize.Text = ""
        cbo_cigarbrand.Text = ""
        txt_kodeproduk.Enabled = False
        txt_rollername.Enabled = False
        txt_jumlahproduk.Enabled = False
        cbo_cigarbrand.Enabled = False
        cbo_cigarsize.Enabled = False

        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        Call Koneksi()
        Da = New OdbcDataAdapter("Select kodeproduk, cigar_brand, cigar_size, roller_name, jumlah_produk, date From tb_cerutu", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_cerutu")
        dgv_datacerutu.DataSource = Ds.Tables("tb_cerutu")
        dgv_datacerutu.ReadOnly = True
    End Sub
    Sub SiapIsi()
        txt_kodeproduk.Enabled = False
        txt_rollername.Enabled = True
        txt_jumlahproduk.Enabled = True
        cbo_cigarbrand.Enabled = True
        cbo_cigarsize.Enabled = True
        dt_produksi.Enabled = True
        cbo_cigarbrand.Items.Add("AL")
        cbo_cigarbrand.Items.Add("BR")
        cbo_cigarbrand.Items.Add("RB")
        cbo_cigarbrand.Items.Add("OEM")
        cbo_cigarbrand.Items.Add("Trial")
        cbo_cigarsize.Items.Add("GC")
        cbo_cigarsize.Items.Add("RO")
        cbo_cigarsize.Items.Add("TR")
        cbo_cigarsize.Items.Add("HC")
        cbo_cigarsize.Items.Add("PN")
        cbo_cigarsize.Items.Add("MC")
    End Sub
    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tb_cerutu where kodeproduk in (select max(kodeproduk) from tb_cerutu)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "CRT" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
            UrutanKode = "CRT" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        txt_kodeproduk.Text = UrutanKode
    End Sub

    Private Sub FormMasterCerutu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        If btn_input.Text = "Input" Then
            btn_input.Text = "Simpan"
            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "Batal"
            Call SiapIsi()
            Call NomorOtomatis()
            txt_kodeproduk.Enabled = False
            cbo_cigarbrand.Focus()

        Else
            If cbo_cigarbrand.Text = "" Or cbo_cigarsize.Text = "" Or txt_rollername.Text = "" Or txt_jumlahproduk.Text = "" Then
                MsgBox("Silahkan isi semua data")
            Else
                Call Koneksi()
                Dim InputData As String = "insert into tb_cerutu values('" & txt_kodeproduk.Text & "','" & cbo_cigarbrand.Text & "','" & cbo_cigarsize.Text & "','" & txt_rollername.Text & "','" & txt_jumlahproduk.Text & "','" & dt_produksi.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Simpan"
            btn_input.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "Batal"
            Call SiapIsi()
        Else
            If txt_kodeproduk.Text = "" Or cbo_cigarbrand.Text = "" Or cbo_cigarsize.Text = "" Or txt_rollername.Text = "" Or txt_jumlahproduk.Text = "" Then
                MsgBox("Silahkan isi semua data")
            Else
                Call Koneksi()
                Dim UpdateData As String = "Update tb_cerutu set cigar_brand='" & cbo_cigarbrand.Text & "',cigar_size='" & cbo_cigarsize.Text & "',roller_name='" & txt_rollername.Text & "',jumlah_produk='" & txt_jumlahproduk.Text & "',date='" & dt_produksi.Text & "' where kodeproduk='" & txt_kodeproduk.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        If btn_hapus.Text = "Hapus" Then
            btn_hapus.Text = "Delete"
            btn_input.Enabled = False
            btn_edit.Enabled = False
            btn_tutup.Text = "Batal"
            Call SiapIsi()
        Else
            If txt_kodeproduk.Text = "" Or cbo_cigarbrand.Text = "" Or cbo_cigarsize.Text = "" Or txt_rollername.Text = "" Then
                MsgBox("Silahkan isi semua data")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete from tb_cerutu where kodeproduk='" & txt_kodeproduk.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus data berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub

    Private Sub btn_tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tutup.Click
        If btn_tutup.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()

        End If
    End Sub

    Private Sub dgv_datacerutu_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datacerutu.CellClick
        Dim i As Integer
        i = dgv_datacerutu.CurrentRow.Index

        txt_kodeproduk.Text = dgv_datacerutu.Item(0, i).Value
        cbo_cigarbrand.Text = dgv_datacerutu.Item(1, i).Value
        cbo_cigarsize.Text = dgv_datacerutu.Item(2, i).Value
        txt_rollername.Text = dgv_datacerutu.Item(3, i).Value
        txt_jumlahproduk.Text = dgv_datacerutu.Item(4, i).Value
        dt_produksi.Text = dgv_datacerutu.Item(5, i).Value
    End Sub

    
End Class