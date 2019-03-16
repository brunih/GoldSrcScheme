<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoldSrcCloseBtn
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
        Me.CloseBtn = New System.Windows.Forms.PictureBox()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopColor
        '
        Me.TopColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TopColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopColor.Location = New System.Drawing.Point(0, 0)
        Me.TopColor.Name = "TopColor"
        Me.TopColor.Size = New System.Drawing.Size(18, 1)
        Me.TopColor.TabIndex = 0
        '
        'LeftColor
        '
        Me.LeftColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LeftColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftColor.Location = New System.Drawing.Point(0, 1)
        Me.LeftColor.Name = "LeftColor"
        Me.LeftColor.Size = New System.Drawing.Size(1, 16)
        Me.LeftColor.TabIndex = 1
        '
        'DownColor
        '
        Me.DownColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.DownColor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownColor.Location = New System.Drawing.Point(0, 17)
        Me.DownColor.Name = "DownColor"
        Me.DownColor.Size = New System.Drawing.Size(17, 1)
        Me.DownColor.TabIndex = 2
        '
        'RightColor
        '
        Me.RightColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightColor.Location = New System.Drawing.Point(17, 1)
        Me.RightColor.Name = "RightColor"
        Me.RightColor.Size = New System.Drawing.Size(1, 17)
        Me.RightColor.TabIndex = 3
        '
        'CloseBtn
        '
        Me.CloseBtn.Image = Global.GoldSrcScheme.My.Resources.Resources.Close
        Me.CloseBtn.Location = New System.Drawing.Point(1, 1)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(16, 16)
        Me.CloseBtn.TabIndex = 4
        Me.CloseBtn.TabStop = False
        '
        'GoldSrcCloseBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Controls.Add(Me.LeftColor)
        Me.Controls.Add(Me.DownColor)
        Me.Controls.Add(Me.RightColor)
        Me.Controls.Add(Me.TopColor)
        Me.Controls.Add(Me.CloseBtn)
        Me.Name = "GoldSrcCloseBtn"
        Me.Size = New System.Drawing.Size(18, 18)
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopColor As Panel
    Friend WithEvents LeftColor As Panel
    Friend WithEvents DownColor As Panel
    Friend WithEvents RightColor As Panel
    Friend WithEvents CloseBtn As PictureBox
End Class
