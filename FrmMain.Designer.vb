<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblLow = New System.Windows.Forms.Label()
        Me.lblMed = New System.Windows.Forms.Label()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblDispLow = New System.Windows.Forms.Label()
        Me.lblDispMed = New System.Windows.Forms.Label()
        Me.lblDispHigh = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 12)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(208, 57)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate 3 Random Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblLow
        '
        Me.lblLow.AutoSize = True
        Me.lblLow.Location = New System.Drawing.Point(13, 95)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(53, 13)
        Me.lblLow.TabIndex = 1
        Me.lblLow.Text = "Number 1"
        '
        'lblMed
        '
        Me.lblMed.AutoSize = True
        Me.lblMed.Location = New System.Drawing.Point(13, 158)
        Me.lblMed.Name = "lblMed"
        Me.lblMed.Size = New System.Drawing.Size(53, 13)
        Me.lblMed.TabIndex = 2
        Me.lblMed.Text = "Number 2"
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.Location = New System.Drawing.Point(13, 218)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(53, 13)
        Me.lblHigh.TabIndex = 3
        Me.lblHigh.Text = "Number 3"
        '
        'lblDispLow
        '
        Me.lblDispLow.AutoSize = True
        Me.lblDispLow.Location = New System.Drawing.Point(91, 95)
        Me.lblDispLow.Name = "lblDispLow"
        Me.lblDispLow.Size = New System.Drawing.Size(11, 13)
        Me.lblDispLow.TabIndex = 4
        Me.lblDispLow.Text = "*"
        '
        'lblDispMed
        '
        Me.lblDispMed.AutoSize = True
        Me.lblDispMed.Location = New System.Drawing.Point(91, 158)
        Me.lblDispMed.Name = "lblDispMed"
        Me.lblDispMed.Size = New System.Drawing.Size(11, 13)
        Me.lblDispMed.TabIndex = 5
        Me.lblDispMed.Text = "*"
        '
        'lblDispHigh
        '
        Me.lblDispHigh.AutoSize = True
        Me.lblDispHigh.Location = New System.Drawing.Point(91, 218)
        Me.lblDispHigh.Name = "lblDispHigh"
        Me.lblDispHigh.Size = New System.Drawing.Size(11, 13)
        Me.lblDispHigh.TabIndex = 6
        Me.lblDispHigh.Text = "*"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 262)
        Me.Controls.Add(Me.lblDispHigh)
        Me.Controls.Add(Me.lblDispMed)
        Me.Controls.Add(Me.lblDispLow)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.lblMed)
        Me.Controls.Add(Me.lblLow)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "FrmMain"
        Me.Text = "Number Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblLow As Label
    Friend WithEvents lblMed As Label
    Friend WithEvents lblHigh As Label
    Friend WithEvents lblDispLow As Label
    Friend WithEvents lblDispMed As Label
    Friend WithEvents lblDispHigh As Label
End Class
