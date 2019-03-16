<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldSrcBackground
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LeftColor = New System.Windows.Forms.Panel()
        Me.DownColor = New System.Windows.Forms.Panel()
        Me.RightColor = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LeftColor
        '
        Me.LeftColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LeftColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftColor.Location = New System.Drawing.Point(0, 0)
        Me.LeftColor.Name = "LeftColor"
        Me.LeftColor.Size = New System.Drawing.Size(1, 149)
        Me.LeftColor.TabIndex = 4
        '
        'DownColor
        '
        Me.DownColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.DownColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownColor.Location = New System.Drawing.Point(0, 149)
        Me.DownColor.Name = "DownColor"
        Me.DownColor.Size = New System.Drawing.Size(149, 1)
        Me.DownColor.TabIndex = 5
        '
        'RightColor
        '
        Me.RightColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightColor.Location = New System.Drawing.Point(149, 0)
        Me.RightColor.Name = "RightColor"
        Me.RightColor.Size = New System.Drawing.Size(1, 150)
        Me.RightColor.TabIndex = 6
        '
        'GoldSrcWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Controls.Add(Me.LeftColor)
        Me.Controls.Add(Me.DownColor)
        Me.Controls.Add(Me.RightColor)
        Me.Name = "GoldSrcWindow"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftColor As Panel
    Friend WithEvents DownColor As Panel
    Friend WithEvents RightColor As Panel
End Class
