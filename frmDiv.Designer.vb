<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiv))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.picBar2 = New System.Windows.Forms.PictureBox()
        Me.picBar1 = New System.Windows.Forms.PictureBox()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(47, 426)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 25
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(193, 239)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 24
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(130, 215)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(204, 20)
        Me.txtAns.TabIndex = 23
        '
        'picBar2
        '
        Me.picBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picBar2.Location = New System.Drawing.Point(129, 268)
        Me.picBar2.Name = "picBar2"
        Me.picBar2.Size = New System.Drawing.Size(205, 10)
        Me.picBar2.TabIndex = 22
        Me.picBar2.TabStop = False
        '
        'picBar1
        '
        Me.picBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picBar1.Location = New System.Drawing.Point(128, 204)
        Me.picBar1.Name = "picBar1"
        Me.picBar1.Size = New System.Drawing.Size(205, 10)
        Me.picBar1.TabIndex = 21
        Me.picBar1.TabStop = False
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN2.Location = New System.Drawing.Point(165, 148)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(169, 55)
        Me.lblN2.TabIndex = 20
        Me.lblN2.Text = "Label4"
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSymbol.Location = New System.Drawing.Point(125, 148)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(67, 55)
        Me.lblSymbol.TabIndex = 19
        Me.lblSymbol.Text = "÷ "
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN1.Location = New System.Drawing.Point(165, 93)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(169, 55)
        Me.lblN1.TabIndex = 18
        Me.lblN1.Text = "Label2"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(28, 50)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(77, 20)
        Me.lblQuestion.TabIndex = 17
        Me.lblQuestion.Text = "Question:"
        '
        'frmDiv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.picBar2)
        Me.Controls.Add(Me.picBar1)
        Me.Controls.Add(Me.lblN2)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.lblN1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDiv"
        Me.Text = "Maths Game - Division"
        CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBar1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblN2 As System.Windows.Forms.Label
    Friend WithEvents lblSymbol As System.Windows.Forms.Label
    Friend WithEvents lblN1 As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
End Class
