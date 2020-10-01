Imports System.Data.Odbc
Public Class FormPackagingChecking
    Sub KondisiAwal()
        'TextBox1.Text = ""
        txt_cellopafter.Text = ""
        txt_cellopduring.Text = ""
        txt_color.Text = ""
        txt_crack.Text = ""
        txt_inspector.Text = ""
        txt_prodcode.Text = ""
        txt_remarks.Text = ""
        txt_ring.Text = ""
        txt_size.Text = ""
        txt_texture.Text = ""
        txt_cukai.Text = ""
        cbo_brand.Text = ""
        cbo_cigarshape.Text = ""
        cbo_cigarsize.Text = ""
        cbo_kodebarang.Text = ""
        cbo_brand.Items.Clear()
        cbo_cigarshape.Items.Clear()
        cbo_cigarsize.Items.Clear()

        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True

        txt_cellopafter.Enabled = False
        txt_cellopduring.Enabled = False
        txt_color.Enabled = False
        txt_crack.Enabled = False
        txt_inspector.Enabled = False
        txt_prodcode.Enabled = False
        txt_remarks.Enabled = False
        txt_ring.Enabled = False
        txt_size.Enabled = False
        txt_texture.Enabled = False
        txt_cukai.Enabled = False
        cbo_brand.Enabled = False
        cbo_cigarshape.Enabled = False
        cbo_cigarsize.Enabled = False
        cbo_kodebarang.Enabled = False

        Call MunculKodeBarang()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select id_pack, inspector, date, brand, cigarsize, cigarshape, size, color, texture, crack, total_before, cellop_during, ring, total_during, cellop_after, prod_code, cukai, total_after,remarks, kodebarang From tb_checkpack", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_checkpack")
        dgv_checkpack.DataSource = Ds.Tables("tb_checkpack")
        dgv_checkpack.ReadOnly = True

    End Sub
    Sub SiapIsi()
        txt_cellopafter.Enabled = True
        txt_cellopduring.Enabled = True
        txt_color.Enabled = True
        txt_crack.Enabled = True
        txt_inspector.Enabled = True
        txt_prodcode.Enabled = True
        txt_remarks.Enabled = True
        txt_ring.Enabled = True
        txt_size.Enabled = True
        txt_cukai.Enabled = True
        txt_texture.Enabled = True
        cbo_brand.Enabled = True
        cbo_cigarshape.Enabled = True
        cbo_cigarsize.Enabled = True
        cbo_kodebarang.Enabled = True
        'ComboBox1.Items.Add("Admin")
        cbo_brand.Items.Add("AL")
        cbo_brand.Items.Add("BR")
        cbo_brand.Items.Add("RB")
        cbo_brand.Items.Add("OEM")
        cbo_brand.Items.Add("Trial")
        cbo_cigarsize.Items.Add("GC")
        cbo_cigarsize.Items.Add("RO")
        cbo_cigarsize.Items.Add("TR")
        cbo_cigarsize.Items.Add("HC")
        cbo_cigarsize.Items.Add("PN")
        cbo_cigarsize.Items.Add("MC")
        cbo_cigarshape.Items.Add("Parejo")
        cbo_cigarshape.Items.Add("Torpedo")
        cbo_cigarshape.Items.Add("Box-press")

    End Sub
    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tb_checkpack where id_pack in (select max(id_pack) from tb_checkpack)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PCK" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "PCK" + Microsoft.VisualBasic.Right("0000" & Hitung, 3)
        End If
        txt_kodecheck.Text = UrutanKode
    End Sub
    Sub MunculKodeBarang()
        Call Koneksi()
        cbo_kodebarang.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_barang", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cbo_kodebarang.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub FormPackagingChecking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            txt_kodecheck.Enabled = False
            cbo_kodebarang.Focus()

        Else
            If txt_kodecheck.Text = "" Or txt_inspector.Text = "" Or txt_remarks.Text = "" Or cbo_brand.Text = "" Then
                MsgBox("Silahkan isi semua data")
            Else
                Call Koneksi()
                Dim InputData As String = "insert into tb_checkpack values('" & txt_kodecheck.Text & "','" & txt_inspector.Text & "','" & dt_tglanalisis.Text & "','" & cbo_brand.Text & "','" & cbo_cigarsize.Text & "','" & cbo_cigarshape.Text & "','" & txt_size.Text & "','" & txt_color.Text & "','" & txt_texture.Text & "','" & txt_crack.Text & "','" & LBL_totalbefore.Text & "','" & txt_cellopduring.Text & "','" & txt_ring.Text & "','" & LBL_totalduring.Text & "','" & txt_cellopafter.Text & "','" & txt_prodcode.Text & "','" & txt_cukai.Text & "','" & LBL_totalafter.Text & "','" & txt_remarks.Text & "','" & cbo_kodebarang.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
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
            If txt_kodecheck.Text = "" Or txt_inspector.Text = "" Or txt_remarks.Text = "" Or cbo_brand.Text = "" Then
                MsgBox("Silahkan isi semua data")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete from tb_checkpack where id_pack='" & txt_kodecheck.Text & "'"
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

    Private Sub txt_crack_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_crack.KeyPress
        If e.KeyChar = Chr(13) Then
            LBL_totalbefore.Text = Val(txt_size.Text) + Val(txt_color.Text) + Val(txt_texture.Text) + Val(txt_crack.Text)
        End If
    End Sub

    Private Sub txt_ring_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ring.KeyPress
        If e.KeyChar = Chr(13) Then
            LBL_totalduring.Text = Val(txt_cellopduring.Text) + Val(txt_ring.Text)
        End If
    End Sub

    Private Sub txt_cukai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cukai.KeyPress
        If e.KeyChar = Chr(13) Then
            LBL_totalafter.Text = Val(txt_cellopafter.Text) + Val(txt_prodcode.Text) + Val(txt_cukai.Text)
        End If
    End Sub

    Private Sub dgv_checkpack_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_checkpack.CellClick
        Dim i As Integer
        i = dgv_checkpack.CurrentRow.Index

        txt_kodecheck.Text = dgv_checkpack.Item(0, i).Value
        txt_inspector.Text = dgv_checkpack.Item(1, i).Value
        dt_tglanalisis.Text = dgv_checkpack.Item(2, i).Value
        cbo_brand.Text = dgv_checkpack.Item(3, i).Value
        cbo_cigarsize.Text = dgv_checkpack.Item(4, i).Value
        cbo_cigarshape.Text = dgv_checkpack.Item(5, i).Value
        txt_size.Text = dgv_checkpack.Item(6, i).Value
        txt_color.Text = dgv_checkpack.Item(7, i).Value
        txt_texture.Text = dgv_checkpack.Item(8, i).Value
        txt_crack.Text = dgv_checkpack.Item(9, i).Value
        LBL_totalbefore.Text = dgv_checkpack.Item(10, i).Value
        txt_cellopduring.Text = dgv_checkpack.Item(11, i).Value
        txt_ring.Text = dgv_checkpack.Item(12, i).Value
        LBL_totalduring.Text = dgv_checkpack.Item(13, i).Value
        txt_cellopafter.Text = dgv_checkpack.Item(14, i).Value
        txt_prodcode.Text = dgv_checkpack.Item(15, i).Value
        txt_cukai.Text = dgv_checkpack.Item(16, i).Value
        LBL_totalafter.Text = dgv_checkpack.Item(17, i).Value
        txt_remarks.Text = dgv_checkpack.Item(18, i).Value
        cbo_kodebarang.Text = dgv_checkpack.Item(19, i).Value



    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Simpan"
            btn_input.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "Batal"
            Call SiapIsi()
        Else
            If txt_kodecheck.Text = "" Or txt_inspector.Text = "" Or dt_tglanalisis.Text = "" Or cbo_brand.Text = "" Then
                MsgBox("Silahkan isi semua data")
            Else
                Call Koneksi()
                Dim UpdateData As String = "Update tb_checkpack set inspector='" & txt_inspector.Text & "',date='" & dt_tglanalisis.Text & "',brand='" & cbo_brand.Text & "' where id_pack='" & txt_kodecheck.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub
End Class