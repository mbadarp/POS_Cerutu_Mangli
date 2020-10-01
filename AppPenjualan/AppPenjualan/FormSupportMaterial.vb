Imports System.Data.Odbc
Public Class FormSupportMaterial
    Sub KondisiAwal()
        idsupport.Text = ""
        name.Text = ""
        received.Text = ""
        analysis.Text = ""
        items.Text = ""
        good.Text = ""
        notgood.Text = ""
        vendor.Text = ""
        pcsRej.Text = ""
        kgsRej.Text = ""
        pcsRec.Text = ""
        pcsRec.Text = ""
        remaks.Text = ""

        idsupport.Enabled = False
        name.Enabled = False
        received.Enabled = False
        analysis.Enabled = False
        items.Enabled = False
        good.Enabled = False
        notgood.Enabled = False
        vendor.Enabled = False
        pcsRej.Enabled = False
        kgsRec.Enabled = False
        pcsRec.Enabled = False
        kgsRec.Enabled = False
        remaks.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From tbl_support_material", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_support_material")
        DataGridView1.DataSource = Ds.Tables("tbl_support_material")
        DataGridView1.ReadOnly = True



    End Sub
    Sub SiapIsi()
        idsupport.Enabled = True
        name.Enabled = True
        received.Enabled = True
        analysis.Enabled = True
        items.Enabled = True
        good.Enabled = True
        notgood.Enabled = True
        vendor.Enabled = True
        pcsRej.Enabled = True
        kgsRec.Enabled = True
        pcsRec.Enabled = True
        kgsRec.Enabled = True
        remaks.Enabled = True

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            

        Else
            If idsupport.Text = "" Or name.Text = "" Or received.Text = "" Or analysis.Text = "" Or items.Text = "" Or good.Text = "" Or notgood.Text = "" Or vendor.Text = "" Or pcsRej.Text = "" Or kgsRej.Text = "" Or pcsRec.Text = "" Or kgsRec.Text = "" Or remaks.Text = "" Then
                MsgBox("Silahkan isi semua data")
            Else
                Call Koneksi()
                Dim InputData As String = "insert into tbl_admin values('" & idsupport.Text & "','" & name.Text & "','" & received.Text & "','" & analysis.Text & "','" & items.Text & "','" & good.Text & "','" & notgood.Text & "','" & vendor.Text & "','" & pcsRej.Text & "','" & kgsRej.Text & "','" & pcsRec.Text & "','" & kgsRec.Text & "','" & remaks.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub

    Private Sub FormSupportMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

End Class