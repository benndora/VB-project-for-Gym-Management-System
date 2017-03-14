<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.Submit = New System.Windows.Forms.Button()
        Me.USERNAME = New System.Windows.Forms.Label()
        Me.PASSWORD = New System.Windows.Forms.Label()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.USERTYPE = New System.Windows.Forms.Label()
        Me.typetxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(110, 205)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(103, 36)
        Me.Submit.TabIndex = 0
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'USERNAME
        '
        Me.USERNAME.AutoSize = True
        Me.USERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERNAME.Location = New System.Drawing.Point(57, 51)
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.Size = New System.Drawing.Size(84, 15)
        Me.USERNAME.TabIndex = 1
        Me.USERNAME.Text = "USERNAME"
        '
        'PASSWORD
        '
        Me.PASSWORD.AutoSize = True
        Me.PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSWORD.Location = New System.Drawing.Point(54, 102)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.Size = New System.Drawing.Size(84, 15)
        Me.PASSWORD.TabIndex = 2
        Me.PASSWORD.Text = "PASSWORD"
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(179, 44)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(100, 20)
        Me.usertxt.TabIndex = 3
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(179, 102)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(100, 20)
        Me.passtxt.TabIndex = 4
        '
        'USERTYPE
        '
        Me.USERTYPE.AutoSize = True
        Me.USERTYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERTYPE.Location = New System.Drawing.Point(57, 158)
        Me.USERTYPE.Name = "USERTYPE"
        Me.USERTYPE.Size = New System.Drawing.Size(79, 15)
        Me.USERTYPE.TabIndex = 5
        Me.USERTYPE.Text = "USERTYPE"
        '
        'typetxt
        '
        Me.typetxt.Location = New System.Drawing.Point(179, 155)
        Me.typetxt.Name = "typetxt"
        Me.typetxt.Size = New System.Drawing.Size(100, 20)
        Me.typetxt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(87, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LOGIN MODULE"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gym_management.My.Resources.Resources.gym_hd_background_1_1680x1050
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.typetxt)
        Me.Controls.Add(Me.USERTYPE)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.PASSWORD)
        Me.Controls.Add(Me.USERNAME)
        Me.Controls.Add(Me.Submit)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents USERNAME As System.Windows.Forms.Label
    Friend WithEvents PASSWORD As System.Windows.Forms.Label
    Friend WithEvents usertxt As System.Windows.Forms.TextBox
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents USERTYPE As System.Windows.Forms.Label
    Friend WithEvents typetxt As System.Windows.Forms.TextBox

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passtxt.TextChanged

    End Sub

    Private Sub USERNAME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERNAME.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typetxt.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub PASSWORD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASSWORD.Click

    End Sub

    Private Sub USERTYPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERTYPE.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
