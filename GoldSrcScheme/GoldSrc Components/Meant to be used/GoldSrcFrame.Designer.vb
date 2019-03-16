<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoldSrcFrame
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
        Me.RightColor = New System.Windows.Forms.Panel()
        Me.Icon = New System.Windows.Forms.PictureBox()
        Me.WindowName = New System.Windows.Forms.Label()
        Me.GoldSrcCloseBtn1 = New GoldSrcScheme.GoldSrcCloseBtn()
        CType(Me.Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopColor
        '
        Me.TopColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TopColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopColor.Location = New System.Drawing.Point(1, 0)
        Me.TopColor.Name = "TopColor"
        Me.TopColor.Size = New System.Drawing.Size(148, 1)
        Me.TopColor.TabIndex = 4
        '
        'LeftColor
        '
        Me.LeftColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LeftColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftColor.Location = New System.Drawing.Point(0, 0)
        Me.LeftColor.Name = "LeftColor"
        Me.LeftColor.Size = New System.Drawing.Size(1, 31)
        Me.LeftColor.TabIndex = 5
        '
        'RightColor
        '
        Me.RightColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightColor.Location = New System.Drawing.Point(149, 0)
        Me.RightColor.Name = "RightColor"
        Me.RightColor.Size = New System.Drawing.Size(1, 31)
        Me.RightColor.TabIndex = 7
        '
        'Icon
        '
        Me.Icon.BackColor = System.Drawing.Color.Transparent
        Me.Icon.Image = Global.GoldSrcScheme.My.Resources.Resources.icon
        Me.Icon.Location = New System.Drawing.Point(6, 8)
        Me.Icon.Name = "Icon"
        Me.Icon.Size = New System.Drawing.Size(16, 15)
        Me.Icon.TabIndex = 8
        Me.Icon.TabStop = False
        '
        'WindowName
        '
        Me.WindowName.AutoSize = True
        Me.WindowName.BackColor = System.Drawing.Color.Transparent
        Me.WindowName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowName.ForeColor = System.Drawing.Color.White
        Me.WindowName.Location = New System.Drawing.Point(27, 8)
        Me.WindowName.Name = "WindowName"
        Me.WindowName.Size = New System.Drawing.Size(95, 16)
        Me.WindowName.TabIndex = 9
        Me.WindowName.Text = "WindowName"
        Me.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GoldSrcCloseBtn1
        '
        Me.GoldSrcCloseBtn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoldSrcCloseBtn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GoldSrcCloseBtn1.Location = New System.Drawing.Point(125, 7)
        Me.GoldSrcCloseBtn1.Name = "GoldSrcCloseBtn1"
        Me.GoldSrcCloseBtn1.Size = New System.Drawing.Size(18, 18)
        Me.GoldSrcCloseBtn1.TabIndex = 10
        '
        'GoldSrcFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Controls.Add(Me.GoldSrcCloseBtn1)
        Me.Controls.Add(Me.WindowName)
        Me.Controls.Add(Me.Icon)
        Me.Controls.Add(Me.TopColor)
        Me.Controls.Add(Me.LeftColor)
        Me.Controls.Add(Me.RightColor)
        Me.Name = "GoldSrcFrame"
        Me.Size = New System.Drawing.Size(150, 31)
        CType(Me.Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TopColor As Panel
    Friend WithEvents LeftColor As Panel
    Friend WithEvents RightColor As Panel
    Friend WithEvents Icon As PictureBox
    Friend WithEvents WindowName As Label
    Friend WithEvents GoldSrcCloseBtn1 As GoldSrcCloseBtn
End Class
