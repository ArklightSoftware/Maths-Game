<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.lblBackgroundColour = New System.Windows.Forms.Label()
        Me.cmboBack = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTextColour = New System.Windows.Forms.Label()
        Me.cmboText = New System.Windows.Forms.ComboBox()
        Me.btnText = New System.Windows.Forms.Button()
        Me.btnBtn = New System.Windows.Forms.Button()
        Me.cmboBtn = New System.Windows.Forms.ComboBox()
        Me.lblButtonColour = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBackgroundColour
        '
        Me.lblBackgroundColour.AutoSize = True
        Me.lblBackgroundColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackgroundColour.Location = New System.Drawing.Point(28, 39)
        Me.lblBackgroundColour.Name = "lblBackgroundColour"
        Me.lblBackgroundColour.Size = New System.Drawing.Size(154, 18)
        Me.lblBackgroundColour.TabIndex = 0
        Me.lblBackgroundColour.Text = "Background Colour"
        '
        'cmboBack
        '
        Me.cmboBack.FormattingEnabled = True
        Me.cmboBack.Items.AddRange(New Object() {"Defualt", "Blue", "Green", "Red", "Purple", "Black", "Orange", "Yellow", "Pink", "White"})
        Me.cmboBack.Location = New System.Drawing.Point(31, 60)
        Me.cmboBack.Name = "cmboBack"
        Me.cmboBack.Size = New System.Drawing.Size(151, 21)
        Me.cmboBack.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(188, 60)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Change"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTextColour
        '
        Me.lblTextColour.AutoSize = True
        Me.lblTextColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextColour.Location = New System.Drawing.Point(28, 134)
        Me.lblTextColour.Name = "lblTextColour"
        Me.lblTextColour.Size = New System.Drawing.Size(96, 18)
        Me.lblTextColour.TabIndex = 3
        Me.lblTextColour.Text = "Text Colour"
        '
        'cmboText
        '
        Me.cmboText.FormattingEnabled = True
        Me.cmboText.Items.AddRange(New Object() {"Blue", "Green", "Red", "Purple", "Black", "Orange", "Yellow", "Pink", "White"})
        Me.cmboText.Location = New System.Drawing.Point(31, 156)
        Me.cmboText.Name = "cmboText"
        Me.cmboText.Size = New System.Drawing.Size(151, 21)
        Me.cmboText.TabIndex = 4
        '
        'btnText
        '
        Me.btnText.Location = New System.Drawing.Point(188, 154)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(75, 23)
        Me.btnText.TabIndex = 5
        Me.btnText.Text = "Change"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'btnBtn
        '
        Me.btnBtn.Location = New System.Drawing.Point(188, 250)
        Me.btnBtn.Name = "btnBtn"
        Me.btnBtn.Size = New System.Drawing.Size(75, 23)
        Me.btnBtn.TabIndex = 8
        Me.btnBtn.Text = "Change"
        Me.btnBtn.UseVisualStyleBackColor = True
        '
        'cmboBtn
        '
        Me.cmboBtn.FormattingEnabled = True
        Me.cmboBtn.Items.AddRange(New Object() {"Defualt", "Blue", "Green", "Red", "Purple", "Black", "Orange", "Yellow", "Pink", "White"})
        Me.cmboBtn.Location = New System.Drawing.Point(31, 252)
        Me.cmboBtn.Name = "cmboBtn"
        Me.cmboBtn.Size = New System.Drawing.Size(151, 21)
        Me.cmboBtn.TabIndex = 7
        '
        'lblButtonColour
        '
        Me.lblButtonColour.AutoSize = True
        Me.lblButtonColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButtonColour.Location = New System.Drawing.Point(28, 230)
        Me.lblButtonColour.Name = "lblButtonColour"
        Me.lblButtonColour.Size = New System.Drawing.Size(113, 18)
        Me.lblButtonColour.TabIndex = 6
        Me.lblButtonColour.Text = "Button Colour"
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(397, 427)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(75, 23)
        Me.btnGoBack.TabIndex = 9
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnBtn)
        Me.Controls.Add(Me.cmboBtn)
        Me.Controls.Add(Me.lblButtonColour)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.cmboText)
        Me.Controls.Add(Me.lblTextColour)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cmboBack)
        Me.Controls.Add(Me.lblBackgroundColour)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.Text = "Maths Game - Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackgroundColour As System.Windows.Forms.Label
    Friend WithEvents cmboBack As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTextColour As System.Windows.Forms.Label
    Friend WithEvents cmboText As System.Windows.Forms.ComboBox
    Friend WithEvents btnText As System.Windows.Forms.Button
    Friend WithEvents btnBtn As System.Windows.Forms.Button
    Friend WithEvents cmboBtn As System.Windows.Forms.ComboBox
    Friend WithEvents lblButtonColour As System.Windows.Forms.Label
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
End Class
