<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldSrcBtn
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
        Me.TopColor = New System.Windows.Forms.Panel()
        Me.LeftColor = New System.Windows.Forms.Panel()
        Me.DownColor = New System.Windows.Forms.Panel()
        Me.RightColor = New System.Windows.Forms.Panel()
        Me.text1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TopColor
        '
        Me.TopColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TopColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopColor.Location = New System.Drawing.Point(1, 0)
        Me.TopColor.Name = "TopColor"
        Me.TopColor.Size = New System.Drawing.Size(70, 1)
        Me.TopColor.TabIndex = 0
        '
        'LeftColor
        '
        Me.LeftColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LeftColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftColor.Location = New System.Drawing.Point(0, 0)
        Me.LeftColor.Name = "LeftColor"
        Me.LeftColor.Size = New System.Drawing.Size(1, 23)
        Me.LeftColor.TabIndex = 1
        '
        'DownColor
        '
        Me.DownColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.DownColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownColor.Location = New System.Drawing.Point(0, 23)
        Me.DownColor.Name = "DownColor"
        Me.DownColor.Size = New System.Drawing.Size(71, 1)
        Me.DownColor.TabIndex = 2
        '
        'RightColor
        '
        Me.RightColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightColor.Location = New System.Drawing.Point(71, 0)
        Me.RightColor.Name = "RightColor"
        Me.RightColor.Size = New System.Drawing.Size(1, 24)
        Me.RightColor.TabIndex = 3
        '
        'text1
        '
        Me.text1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.text1.AutoSize = True
        Me.text1.BackColor = System.Drawing.Color.Transparent
        Me.text1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text1.ForeColor = System.Drawing.Color.White
        Me.text1.Location = New System.Drawing.Point(3, 4)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(43, 16)
        Me.text1.TabIndex = 4
        Me.text1.Text = "text1"
        Me.text1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GoldSrcBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.TopColor)
        Me.Controls.Add(Me.LeftColor)
        Me.Controls.Add(Me.DownColor)
        Me.Controls.Add(Me.RightColor)
        Me.Name = "GoldSrcBtn"
        Me.Size = New System.Drawing.Size(72, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopColor As Panel
    Friend WithEvents LeftColor As Panel
    Friend WithEvents DownColor As Panel
    Friend WithEvents RightColor As Panel
    Friend WithEvents text1 As Label
End Class
