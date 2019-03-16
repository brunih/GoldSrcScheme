<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoldSrcTextBox
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TopColor = New System.Windows.Forms.Panel()
        Me.LeftColor = New System.Windows.Forms.Panel()
        Me.DownColor = New System.Windows.Forms.Panel()
        Me.RightColor = New System.Windows.Forms.Panel()
        Me.GoldSrcTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TopColor
        '
        Me.TopColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TopColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopColor.Location = New System.Drawing.Point(0, 0)
        Me.TopColor.Name = "TopColor"
        Me.TopColor.Size = New System.Drawing.Size(131, 1)
        Me.TopColor.TabIndex = 0
        '
        'LeftColor
        '
        Me.LeftColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LeftColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftColor.Location = New System.Drawing.Point(0, 1)
        Me.LeftColor.Name = "LeftColor"
        Me.LeftColor.Size = New System.Drawing.Size(1, 22)
        Me.LeftColor.TabIndex = 1
        '
        'DownColor
        '
        Me.DownColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DownColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownColor.Location = New System.Drawing.Point(0, 23)
        Me.DownColor.Name = "DownColor"
        Me.DownColor.Size = New System.Drawing.Size(130, 1)
        Me.DownColor.TabIndex = 2
        '
        'RightColor
        '
        Me.RightColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RightColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightColor.Location = New System.Drawing.Point(130, 1)
        Me.RightColor.Name = "RightColor"
        Me.RightColor.Size = New System.Drawing.Size(1, 23)
        Me.RightColor.TabIndex = 3
        '
        'GoldSrcTB
        '
        Me.GoldSrcTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GoldSrcTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GoldSrcTB.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.GoldSrcTB.ForeColor = System.Drawing.Color.White
        Me.GoldSrcTB.Location = New System.Drawing.Point(1, 5)
        Me.GoldSrcTB.Multiline = True
        Me.GoldSrcTB.Name = "GoldSrcTB"
        Me.GoldSrcTB.Size = New System.Drawing.Size(129, 18)
        Me.GoldSrcTB.TabIndex = 4
        '
        'GoldSrcTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.GoldSrcTB)
        Me.Controls.Add(Me.LeftColor)
        Me.Controls.Add(Me.DownColor)
        Me.Controls.Add(Me.RightColor)
        Me.Controls.Add(Me.TopColor)
        Me.Name = "GoldSrcTextBox"
        Me.Size = New System.Drawing.Size(131, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopColor As Panel
    Friend WithEvents LeftColor As Panel
    Friend WithEvents DownColor As Panel
    Friend WithEvents RightColor As Panel
    Friend WithEvents GoldSrcTB As TextBox
End Class
