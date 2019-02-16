<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowError
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMessageDesc = New System.Windows.Forms.Label()
        Me.btnErrorOK = New System.Windows.Forms.Button()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = Global.MaskLoad.My.Resources.Resources.robot_network_icon
    Me.PictureBox1.Location = New System.Drawing.Point(14, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblMessageDesc
        '
        Me.lblMessageDesc.AutoSize = True
        Me.lblMessageDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageDesc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMessageDesc.Location = New System.Drawing.Point(363, 55)
        Me.lblMessageDesc.Name = "lblMessageDesc"
        Me.lblMessageDesc.Size = New System.Drawing.Size(314, 25)
        Me.lblMessageDesc.TabIndex = 1
        Me.lblMessageDesc.Text = "Unable to communicate with:"
        '
        'btnErrorOK
        '
        Me.btnErrorOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnErrorOK.Location = New System.Drawing.Point(479, 155)
        Me.btnErrorOK.Name = "btnErrorOK"
        Me.btnErrorOK.Size = New System.Drawing.Size(101, 41)
        Me.btnErrorOK.TabIndex = 2
        Me.btnErrorOK.Text = "&Ackowledge"
        Me.btnErrorOK.UseVisualStyleBackColor = True
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblErrorMessage.Location = New System.Drawing.Point(363, 113)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(187, 25)
        Me.lblErrorMessage.TabIndex = 3
        Me.lblErrorMessage.Text = "The Left Camera"
        '
        'frmShowError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(719, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.btnErrorOK)
        Me.Controls.Add(Me.lblMessageDesc)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShowError"
        Me.Opacity = 0.7R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMessageDesc As Label
    Friend WithEvents btnErrorOK As Button
    Friend WithEvents lblErrorMessage As Label
End Class
