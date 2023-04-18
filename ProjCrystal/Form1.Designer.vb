<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.crvRel = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvRel
        '
        Me.crvRel.ActiveViewIndex = -1
        Me.crvRel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvRel.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvRel.Location = New System.Drawing.Point(0, 0)
        Me.crvRel.Name = "crvRel"
        Me.crvRel.Size = New System.Drawing.Size(800, 450)
        Me.crvRel.TabIndex = 0
        Me.crvRel.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvRel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvRel As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
