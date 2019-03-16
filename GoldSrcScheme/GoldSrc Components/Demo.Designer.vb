<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Demo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Me.GoldSrcTextBox1 = New GoldSrcScheme.GoldSrcTextBox()
        Me.GoldSrcBtn1 = New GoldSrcScheme.GoldSrcBtn()
        Me.GoldSrcFrame1 = New GoldSrcScheme.GoldSrcFrame()
        Me.GoldSrcBackground = New GoldSrcScheme.GoldSrcBackground()
        Me.SuspendLayout()
        '
        'GoldSrcTextBox1
        '
        Me.GoldSrcTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GoldSrcTextBox1.Location = New System.Drawing.Point(12, 66)
        Me.GoldSrcTextBox1.Name = "GoldSrcTextBox1"
        Me.GoldSrcTextBox1.Size = New System.Drawing.Size(234, 24)
        Me.GoldSrcTextBox1.TabIndex = 5
        '
        'GoldSrcBtn1
        '
        Me.GoldSrcBtn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GoldSrcBtn1.Location = New System.Drawing.Point(174, 124)
        Me.GoldSrcBtn1.Name = "GoldSrcBtn1"
        Me.GoldSrcBtn1.Size = New System.Drawing.Size(72, 24)
        Me.GoldSrcBtn1.TabIndex = 4
        '
        'GoldSrcFrame1
        '
        Me.GoldSrcFrame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GoldSrcFrame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GoldSrcFrame1.Location = New System.Drawing.Point(0, 0)
        Me.GoldSrcFrame1.Name = "GoldSrcFrame1"
        Me.GoldSrcFrame1.Size = New System.Drawing.Size(258, 31)
        Me.GoldSrcFrame1.TabIndex = 3
        '
        'GoldSrcBackground
        '
        Me.GoldSrcBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GoldSrcBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoldSrcBackground.Location = New System.Drawing.Point(0, 0)
        Me.GoldSrcBackground.Name = "GoldSrcBackground"
        Me.GoldSrcBackground.Size = New System.Drawing.Size(258, 160)
        Me.GoldSrcBackground.TabIndex = 1
        '
        'Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 160)
        Me.Controls.Add(Me.GoldSrcTextBox1)
        Me.Controls.Add(Me.GoldSrcBtn1)
        Me.Controls.Add(Me.GoldSrcFrame1)
        Me.Controls.Add(Me.GoldSrcBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Demo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GoldSrcBackground As GoldSrcBackground
    Friend WithEvents GoldSrcFrame1 As GoldSrcFrame
    Friend WithEvents GoldSrcBtn1 As GoldSrcBtn
    Friend WithEvents GoldSrcTextBox1 As GoldSrcTextBox
End Class
