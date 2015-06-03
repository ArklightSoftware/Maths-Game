<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.lblAddition = New System.Windows.Forms.Label()
        Me.lblSubtraction = New System.Windows.Forms.Label()
        Me.lblMultipication = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(36, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(145, 133)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(301, 26)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(145, 133)
        Me.btnSub.TabIndex = 1
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.Location = New System.Drawing.Point(36, 242)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(145, 133)
        Me.btnMulti.TabIndex = 2
        Me.btnMulti.Text = "x"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(301, 242)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(145, 133)
        Me.btnDiv.TabIndex = 3
        Me.btnDiv.Text = "÷ "
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'lblAddition
        '
        Me.lblAddition.AutoSize = True
        Me.lblAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddition.Location = New System.Drawing.Point(69, 162)
        Me.lblAddition.Name = "lblAddition"
        Me.lblAddition.Size = New System.Drawing.Size(75, 20)
        Me.lblAddition.TabIndex = 4
        Me.lblAddition.Text = "Addition"
        '
        'lblSubtraction
        '
        Me.lblSubtraction.AutoSize = True
        Me.lblSubtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtraction.Location = New System.Drawing.Point(318, 162)
        Me.lblSubtraction.Name = "lblSubtraction"
        Me.lblSubtraction.Size = New System.Drawing.Size(102, 20)
        Me.lblSubtraction.TabIndex = 5
        Me.lblSubtraction.Text = "Subtraction"
        '
        'lblMultipication
        '
        Me.lblMultipication.AutoSize = True
        Me.lblMultipication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultipication.Location = New System.Drawing.Point(48, 378)
        Me.lblMultipication.Name = "lblMultipication"
        Me.lblMultipication.Size = New System.Drawing.Size(114, 20)
        Me.lblMultipication.TabIndex = 6
        Me.lblMultipication.Text = "Multiplication"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(335, 378)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(71, 20)
        Me.lblDivision.TabIndex = 7
        Me.lblDivision.Text = "Division"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(371, 427)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(290, 427)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnOptions.TabIndex = 9
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(209, 427)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 24)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.lblMultipication)
        Me.Controls.Add(Me.lblSubtraction)
        Me.Controls.Add(Me.lblAddition)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.Text = "Maths Game - Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents lblAddition As System.Windows.Forms.Label
    Friend WithEvents lblSubtraction As System.Windows.Forms.Label
    Friend WithEvents lblMultipication As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button

End Class
