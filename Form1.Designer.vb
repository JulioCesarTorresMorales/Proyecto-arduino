<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtRojoEncender = New System.Windows.Forms.RadioButton()
        Me.rbtRojoApagar = New System.Windows.Forms.RadioButton()
        Me.rbtVerdeEncender = New System.Windows.Forms.RadioButton()
        Me.rbtVerdeApagar = New System.Windows.Forms.RadioButton()
        Me.rbtAzulEncender = New System.Windows.Forms.RadioButton()
        Me.rbtAzulApagar = New System.Windows.Forms.RadioButton()
        Me.spPuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LED 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LED 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LED 3"
        '
        'rbtRojoEncender
        '
        Me.rbtRojoEncender.AutoSize = True
        Me.rbtRojoEncender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtRojoEncender.Location = New System.Drawing.Point(60, 110)
        Me.rbtRojoEncender.Name = "rbtRojoEncender"
        Me.rbtRojoEncender.Size = New System.Drawing.Size(93, 17)
        Me.rbtRojoEncender.TabIndex = 3
        Me.rbtRojoEncender.TabStop = True
        Me.rbtRojoEncender.Text = "ENCENDER"
        Me.rbtRojoEncender.UseVisualStyleBackColor = True
        '
        'rbtRojoApagar
        '
        Me.rbtRojoApagar.AutoSize = True
        Me.rbtRojoApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtRojoApagar.Location = New System.Drawing.Point(60, 151)
        Me.rbtRojoApagar.Name = "rbtRojoApagar"
        Me.rbtRojoApagar.Size = New System.Drawing.Size(75, 17)
        Me.rbtRojoApagar.TabIndex = 4
        Me.rbtRojoApagar.TabStop = True
        Me.rbtRojoApagar.Text = "APAGAR"
        Me.rbtRojoApagar.UseVisualStyleBackColor = True
        '
        'rbtVerdeEncender
        '
        Me.rbtVerdeEncender.AutoSize = True
        Me.rbtVerdeEncender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtVerdeEncender.Location = New System.Drawing.Point(199, 110)
        Me.rbtVerdeEncender.Name = "rbtVerdeEncender"
        Me.rbtVerdeEncender.Size = New System.Drawing.Size(93, 17)
        Me.rbtVerdeEncender.TabIndex = 5
        Me.rbtVerdeEncender.TabStop = True
        Me.rbtVerdeEncender.Text = "ENCENDER"
        Me.rbtVerdeEncender.UseVisualStyleBackColor = True
        '
        'rbtVerdeApagar
        '
        Me.rbtVerdeApagar.AutoSize = True
        Me.rbtVerdeApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtVerdeApagar.Location = New System.Drawing.Point(199, 151)
        Me.rbtVerdeApagar.Name = "rbtVerdeApagar"
        Me.rbtVerdeApagar.Size = New System.Drawing.Size(75, 17)
        Me.rbtVerdeApagar.TabIndex = 6
        Me.rbtVerdeApagar.TabStop = True
        Me.rbtVerdeApagar.Text = "APAGAR"
        Me.rbtVerdeApagar.UseVisualStyleBackColor = True
        '
        'rbtAzulEncender
        '
        Me.rbtAzulEncender.AutoSize = True
        Me.rbtAzulEncender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAzulEncender.Location = New System.Drawing.Point(321, 110)
        Me.rbtAzulEncender.Name = "rbtAzulEncender"
        Me.rbtAzulEncender.Size = New System.Drawing.Size(93, 17)
        Me.rbtAzulEncender.TabIndex = 7
        Me.rbtAzulEncender.TabStop = True
        Me.rbtAzulEncender.Text = "ENCENDER"
        Me.rbtAzulEncender.UseVisualStyleBackColor = True
        '
        'rbtAzulApagar
        '
        Me.rbtAzulApagar.AutoSize = True
        Me.rbtAzulApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAzulApagar.Location = New System.Drawing.Point(321, 151)
        Me.rbtAzulApagar.Name = "rbtAzulApagar"
        Me.rbtAzulApagar.Size = New System.Drawing.Size(75, 17)
        Me.rbtAzulApagar.TabIndex = 8
        Me.rbtAzulApagar.TabStop = True
        Me.rbtAzulApagar.Text = "APAGAR"
        Me.rbtAzulApagar.UseVisualStyleBackColor = True
        '
        'spPuerto
        '
        Me.spPuerto.PortName = "COM3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(493, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbtAzulApagar)
        Me.Controls.Add(Me.rbtAzulEncender)
        Me.Controls.Add(Me.rbtVerdeApagar)
        Me.Controls.Add(Me.rbtVerdeEncender)
        Me.Controls.Add(Me.rbtRojoApagar)
        Me.Controls.Add(Me.rbtRojoEncender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PROYECTO ARDUINO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbtRojoEncender As RadioButton
    Friend WithEvents rbtRojoApagar As RadioButton
    Friend WithEvents rbtVerdeEncender As RadioButton
    Friend WithEvents rbtVerdeApagar As RadioButton
    Friend WithEvents rbtAzulEncender As RadioButton
    Friend WithEvents rbtAzulApagar As RadioButton
    Friend WithEvents spPuerto As IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As PictureBox
End Class
