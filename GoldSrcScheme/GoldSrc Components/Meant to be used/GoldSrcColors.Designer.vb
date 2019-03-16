<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldSrcColors
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
        Me.RightColor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TopColor
        '
        Me.TopColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TopColor.Location = New System.Drawing.Point(7, 6)
        Me.TopColor.Name = "TopColor"
        Me.TopColor.Size = New System.Drawing.Size(35, 98)
        Me.TopColor.TabIndex = 4
        '
        'RightColor
        '
        Me.RightColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightColor.Location = New System.Drawing.Point(48, 6)
        Me.RightColor.Name = "RightColor"
        Me.RightColor.Size = New System.Drawing.Size(35, 98)
        Me.RightColor.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(89, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(35, 98)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 57)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Top And Left Color"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 57)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Bottom Right Color"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(86, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Background Color"
        '
        'GoldSrcColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopColor)
        Me.Controls.Add(Me.RightColor)
        Me.Name = "GoldSrcColors"
        Me.Size = New System.Drawing.Size(157, 167)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopColor As Panel
    Friend WithEvents RightColor As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
