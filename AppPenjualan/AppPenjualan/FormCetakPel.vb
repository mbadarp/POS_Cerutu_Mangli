Public Class FormCetakPel


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRPel.Load
        CRPel.ReportSource = "..\..\CR_Pel"
    End Sub
End Class