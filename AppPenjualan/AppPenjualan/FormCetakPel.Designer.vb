<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakPel
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
        Me.CRPel = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRPel
        '
        Me.CRPel.ActiveViewIndex = -1
        Me.CRPel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRPel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRPel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRPel.Location = New System.Drawing.Point(0, 0)
        Me.CRPel.Name = "CRPel"
        Me.CRPel.Size = New System.Drawing.Size(1099, 511)
        Me.CRPel.TabIndex = 0
        '
        'FormCetakPel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 511)
        Me.Controls.Add(Me.CRPel)
        Me.Name = "FormCetakPel"
        Me.Text = "FormCetakPel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRPel As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
