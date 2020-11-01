<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(468, 316)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(186, 75)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(250, 316)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(186, 75)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(22, 316)
        Me.btnCompare.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(186, 75)
        Me.btnCompare.TabIndex = 24
        Me.btnCompare.Text = "&Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(28, 196)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(627, 85)
        Me.lblMessage.TabIndex = 23
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(448, 95)
        Me.txtB.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(202, 26)
        Me.txtB.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(370, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 68)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "B:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(98, 104)
        Me.txtA.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(202, 26)
        Me.txtA.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 68)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "A:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 68)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Enter Two Numbers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 470)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompare As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
