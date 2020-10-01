Public Class FormCetakPelanggan

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRP.Load
        CRP.ReportSource = "..\..\CRPelanggan.rpt"
    End Sub
End Class