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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBLARGE = New System.Windows.Forms.CheckBox()
        Me.CBMED = New System.Windows.Forms.CheckBox()
        Me.CBSMALL = New System.Windows.Forms.CheckBox()
        Me.MATERIAL = New System.Windows.Forms.GroupBox()
        Me.RBLONA = New System.Windows.Forms.RadioButton()
        Me.RBSEDA = New System.Windows.Forms.RadioButton()
        Me.ALDODONT = New System.Windows.Forms.RadioButton()
        Me.ACEPTAR = New System.Windows.Forms.Button()
        Me.BLimpio = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MATERIAL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox1.Controls.Add(Me.CBLARGE)
        Me.GroupBox1.Controls.Add(Me.CBMED)
        Me.GroupBox1.Controls.Add(Me.CBSMALL)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TALLAS"
        '
        'CBLARGE
        '
        Me.CBLARGE.AutoSize = True
        Me.CBLARGE.Location = New System.Drawing.Point(7, 68)
        Me.CBLARGE.Name = "CBLARGE"
        Me.CBLARGE.Size = New System.Drawing.Size(70, 23)
        Me.CBLARGE.TabIndex = 2
        Me.CBLARGE.Text = "LARGE"
        Me.CBLARGE.UseVisualStyleBackColor = True
        '
        'CBMED
        '
        Me.CBMED.AutoSize = True
        Me.CBMED.Location = New System.Drawing.Point(7, 44)
        Me.CBMED.Name = "CBMED"
        Me.CBMED.Size = New System.Drawing.Size(84, 23)
        Me.CBMED.TabIndex = 1
        Me.CBMED.Text = "MEDIUM"
        Me.CBMED.UseVisualStyleBackColor = True
        '
        'CBSMALL
        '
        Me.CBSMALL.AllowDrop = True
        Me.CBSMALL.AutoSize = True
        Me.CBSMALL.Location = New System.Drawing.Point(7, 25)
        Me.CBSMALL.Name = "CBSMALL"
        Me.CBSMALL.Size = New System.Drawing.Size(72, 23)
        Me.CBSMALL.TabIndex = 0
        Me.CBSMALL.Text = "SMALL"
        Me.CBSMALL.UseVisualStyleBackColor = True
        '
        'MATERIAL
        '
        Me.MATERIAL.BackColor = System.Drawing.Color.DarkCyan
        Me.MATERIAL.Controls.Add(Me.RBLONA)
        Me.MATERIAL.Controls.Add(Me.RBSEDA)
        Me.MATERIAL.Controls.Add(Me.ALDODONT)
        Me.MATERIAL.Enabled = False
        Me.MATERIAL.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MATERIAL.Location = New System.Drawing.Point(21, 119)
        Me.MATERIAL.Name = "MATERIAL"
        Me.MATERIAL.Size = New System.Drawing.Size(126, 100)
        Me.MATERIAL.TabIndex = 1
        Me.MATERIAL.TabStop = False
        Me.MATERIAL.Text = "MATERIAL"
        '
        'RBLONA
        '
        Me.RBLONA.AutoSize = True
        Me.RBLONA.Location = New System.Drawing.Point(7, 68)
        Me.RBLONA.Name = "RBLONA"
        Me.RBLONA.Size = New System.Drawing.Size(65, 23)
        Me.RBLONA.TabIndex = 2
        Me.RBLONA.TabStop = True
        Me.RBLONA.Text = "LONA"
        Me.RBLONA.UseVisualStyleBackColor = True
        '
        'RBSEDA
        '
        Me.RBSEDA.AutoSize = True
        Me.RBSEDA.Location = New System.Drawing.Point(7, 44)
        Me.RBSEDA.Name = "RBSEDA"
        Me.RBSEDA.Size = New System.Drawing.Size(63, 23)
        Me.RBSEDA.TabIndex = 1
        Me.RBSEDA.TabStop = True
        Me.RBSEDA.Text = "SEDA"
        Me.RBSEDA.UseVisualStyleBackColor = True
        '
        'ALDODONT
        '
        Me.ALDODONT.AutoSize = True
        Me.ALDODONT.Location = New System.Drawing.Point(7, 20)
        Me.ALDODONT.Name = "ALDODONT"
        Me.ALDODONT.Size = New System.Drawing.Size(93, 23)
        Me.ALDODONT.TabIndex = 0
        Me.ALDODONT.TabStop = True
        Me.ALDODONT.Text = "ALGODON"
        Me.ALDODONT.UseVisualStyleBackColor = True
        '
        'ACEPTAR
        '
        Me.ACEPTAR.Location = New System.Drawing.Point(188, 22)
        Me.ACEPTAR.Name = "ACEPTAR"
        Me.ACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.ACEPTAR.TabIndex = 2
        Me.ACEPTAR.Text = "ACEPTAR"
        Me.ACEPTAR.UseVisualStyleBackColor = True
        '
        'BLimpio
        '
        Me.BLimpio.Location = New System.Drawing.Point(188, 80)
        Me.BLimpio.Name = "BLimpio"
        Me.BLimpio.Size = New System.Drawing.Size(75, 23)
        Me.BLimpio.TabIndex = 3
        Me.BLimpio.Text = "LIMPIAR"
        Me.BLimpio.UseVisualStyleBackColor = True
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(188, 139)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(75, 23)
        Me.SALIR.TabIndex = 4
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(521, 450)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.BLimpio)
        Me.Controls.Add(Me.ACEPTAR)
        Me.Controls.Add(Me.MATERIAL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MATERIAL.ResumeLayout(False)
        Me.MATERIAL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBLARGE As CheckBox
    Friend WithEvents CBMED As CheckBox
    Friend WithEvents CBSMALL As CheckBox
    Friend WithEvents MATERIAL As GroupBox
    Friend WithEvents RBLONA As RadioButton
    Friend WithEvents RBSEDA As RadioButton
    Friend WithEvents ALDODONT As RadioButton
    Friend WithEvents ACEPTAR As Button
    Friend WithEvents BLimpio As Button
    Friend WithEvents SALIR As Button
End Class
