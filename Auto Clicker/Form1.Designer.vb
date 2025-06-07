<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnnstart = New Button()
        btnstop = New Button()
        txttest = New TextBox()
        btntest = New Button()
        cbfast = New CheckBox()
        cbnormal = New CheckBox()
        Timer1 = New Timer(components)
        btnclose = New FontAwesome.Sharp.IconButton()
        SuspendLayout()
        ' 
        ' btnnstart
        ' 
        btnnstart.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnnstart.FlatAppearance.BorderSize = 0
        btnnstart.FlatStyle = FlatStyle.Flat
        btnnstart.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnnstart.Location = New Point(34, 59)
        btnnstart.Name = "btnnstart"
        btnnstart.Size = New Size(94, 29)
        btnnstart.TabIndex = 0
        btnnstart.Text = "Start"
        btnnstart.UseVisualStyleBackColor = False
        ' 
        ' btnstop
        ' 
        btnstop.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnstop.FlatAppearance.BorderSize = 0
        btnstop.FlatStyle = FlatStyle.Flat
        btnstop.ForeColor = Color.Red
        btnstop.Location = New Point(34, 109)
        btnstop.Name = "btnstop"
        btnstop.Size = New Size(94, 29)
        btnstop.TabIndex = 0
        btnstop.Text = "Stop"
        btnstop.UseVisualStyleBackColor = False
        ' 
        ' txttest
        ' 
        txttest.Location = New Point(168, 59)
        txttest.Multiline = True
        txttest.Name = "txttest"
        txttest.ReadOnly = True
        txttest.Size = New Size(167, 56)
        txttest.TabIndex = 1
        txttest.Text = "1"
        txttest.TextAlign = HorizontalAlignment.Center
        ' 
        ' btntest
        ' 
        btntest.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btntest.FlatAppearance.BorderSize = 0
        btntest.FlatStyle = FlatStyle.Flat
        btntest.ForeColor = Color.Cyan
        btntest.Location = New Point(370, 59)
        btntest.Name = "btntest"
        btntest.Size = New Size(94, 56)
        btntest.TabIndex = 0
        btntest.Text = "Test"
        btntest.UseVisualStyleBackColor = False
        ' 
        ' cbfast
        ' 
        cbfast.AutoSize = True
        cbfast.BackColor = Color.Gray
        cbfast.Location = New Point(170, 134)
        cbfast.Name = "cbfast"
        cbfast.Size = New Size(56, 24)
        cbfast.TabIndex = 2
        cbfast.Text = "Fast"
        cbfast.UseVisualStyleBackColor = False
        ' 
        ' cbnormal
        ' 
        cbnormal.AutoSize = True
        cbnormal.BackColor = Color.Gray
        cbnormal.Location = New Point(254, 134)
        cbnormal.Name = "cbnormal"
        cbnormal.Size = New Size(81, 24)
        cbnormal.TabIndex = 2
        cbnormal.Text = "Normal"
        cbnormal.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' btnclose
        ' 
        btnclose.FlatAppearance.BorderSize = 0
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.ForeColor = Color.White
        btnclose.IconChar = FontAwesome.Sharp.IconChar.Close
        btnclose.IconColor = Color.White
        btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnclose.IconSize = 25
        btnclose.Location = New Point(454, 12)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(26, 29)
        btnclose.TabIndex = 3
        btnclose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(503, 204)
        Controls.Add(btnclose)
        Controls.Add(cbnormal)
        Controls.Add(cbfast)
        Controls.Add(txttest)
        Controls.Add(btntest)
        Controls.Add(btnstop)
        Controls.Add(btnnstart)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnnstart As Button
    Friend WithEvents btnstop As Button
    Friend WithEvents txttest As TextBox
    Friend WithEvents btntest As Button
    Friend WithEvents cbfast As CheckBox
    Friend WithEvents cbnormal As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnclose As FontAwesome.Sharp.IconButton

End Class
