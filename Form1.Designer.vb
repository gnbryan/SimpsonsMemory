<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_memory
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_memory))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevaPartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MejorRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.lbl_numIntentos = New System.Windows.Forms.ToolStripLabel
        Me.lbl_intentos = New System.Windows.Forms.ToolStripLabel
        Me.pbx_1 = New System.Windows.Forms.PictureBox
        Me.pbx_2 = New System.Windows.Forms.PictureBox
        Me.pbx_3 = New System.Windows.Forms.PictureBox
        Me.pbx_4 = New System.Windows.Forms.PictureBox
        Me.pbx_5 = New System.Windows.Forms.PictureBox
        Me.pbx_6 = New System.Windows.Forms.PictureBox
        Me.pbx_7 = New System.Windows.Forms.PictureBox
        Me.pbx_8 = New System.Windows.Forms.PictureBox
        Me.pbx_9 = New System.Windows.Forms.PictureBox
        Me.pbx_10 = New System.Windows.Forms.PictureBox
        Me.pbx_11 = New System.Windows.Forms.PictureBox
        Me.pbx_12 = New System.Windows.Forms.PictureBox
        Me.btn_1 = New System.Windows.Forms.Button
        Me.btn_2 = New System.Windows.Forms.Button
        Me.btn_3 = New System.Windows.Forms.Button
        Me.btn_4 = New System.Windows.Forms.Button
        Me.btn_5 = New System.Windows.Forms.Button
        Me.btn_6 = New System.Windows.Forms.Button
        Me.btn_7 = New System.Windows.Forms.Button
        Me.btn_8 = New System.Windows.Forms.Button
        Me.btn_9 = New System.Windows.Forms.Button
        Me.btn_10 = New System.Windows.Forms.Button
        Me.btn_11 = New System.Windows.Forms.Button
        Me.btn_12 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pbx_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.RecordToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPartidaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevaPartidaToolStripMenuItem
        '
        Me.NuevaPartidaToolStripMenuItem.Name = "NuevaPartidaToolStripMenuItem"
        Me.NuevaPartidaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NuevaPartidaToolStripMenuItem.Text = "Nueva partida"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RecordToolStripMenuItem
        '
        Me.RecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MejorRecordToolStripMenuItem})
        Me.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem"
        Me.RecordToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.RecordToolStripMenuItem.Text = "&Record"
        '
        'MejorRecordToolStripMenuItem
        '
        Me.MejorRecordToolStripMenuItem.Name = "MejorRecordToolStripMenuItem"
        Me.MejorRecordToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.MejorRecordToolStripMenuItem.Text = "No hay ningún record actualmente."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_numIntentos, Me.lbl_intentos})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lbl_numIntentos
        '
        Me.lbl_numIntentos.Name = "lbl_numIntentos"
        Me.lbl_numIntentos.Size = New System.Drawing.Size(105, 22)
        Me.lbl_numIntentos.Text = "Número de intentos:"
        '
        'lbl_intentos
        '
        Me.lbl_intentos.Name = "lbl_intentos"
        Me.lbl_intentos.Size = New System.Drawing.Size(80, 22)
        Me.lbl_intentos.Text = "ToolStripLabel1"
        '
        'pbx_1
        '
        Me.pbx_1.Location = New System.Drawing.Point(12, 68)
        Me.pbx_1.Name = "pbx_1"
        Me.pbx_1.Size = New System.Drawing.Size(170, 99)
        Me.pbx_1.TabIndex = 2
        Me.pbx_1.TabStop = False
        '
        'pbx_2
        '
        Me.pbx_2.Location = New System.Drawing.Point(209, 68)
        Me.pbx_2.Name = "pbx_2"
        Me.pbx_2.Size = New System.Drawing.Size(170, 99)
        Me.pbx_2.TabIndex = 3
        Me.pbx_2.TabStop = False
        '
        'pbx_3
        '
        Me.pbx_3.Location = New System.Drawing.Point(404, 68)
        Me.pbx_3.Name = "pbx_3"
        Me.pbx_3.Size = New System.Drawing.Size(170, 99)
        Me.pbx_3.TabIndex = 4
        Me.pbx_3.TabStop = False
        '
        'pbx_4
        '
        Me.pbx_4.Location = New System.Drawing.Point(603, 68)
        Me.pbx_4.Name = "pbx_4"
        Me.pbx_4.Size = New System.Drawing.Size(170, 99)
        Me.pbx_4.TabIndex = 5
        Me.pbx_4.TabStop = False
        '
        'pbx_5
        '
        Me.pbx_5.Location = New System.Drawing.Point(13, 182)
        Me.pbx_5.Name = "pbx_5"
        Me.pbx_5.Size = New System.Drawing.Size(170, 99)
        Me.pbx_5.TabIndex = 6
        Me.pbx_5.TabStop = False
        '
        'pbx_6
        '
        Me.pbx_6.Location = New System.Drawing.Point(209, 182)
        Me.pbx_6.Name = "pbx_6"
        Me.pbx_6.Size = New System.Drawing.Size(170, 99)
        Me.pbx_6.TabIndex = 7
        Me.pbx_6.TabStop = False
        '
        'pbx_7
        '
        Me.pbx_7.Location = New System.Drawing.Point(404, 182)
        Me.pbx_7.Name = "pbx_7"
        Me.pbx_7.Size = New System.Drawing.Size(170, 99)
        Me.pbx_7.TabIndex = 8
        Me.pbx_7.TabStop = False
        '
        'pbx_8
        '
        Me.pbx_8.Location = New System.Drawing.Point(603, 182)
        Me.pbx_8.Name = "pbx_8"
        Me.pbx_8.Size = New System.Drawing.Size(170, 99)
        Me.pbx_8.TabIndex = 9
        Me.pbx_8.TabStop = False
        '
        'pbx_9
        '
        Me.pbx_9.Location = New System.Drawing.Point(12, 304)
        Me.pbx_9.Name = "pbx_9"
        Me.pbx_9.Size = New System.Drawing.Size(170, 99)
        Me.pbx_9.TabIndex = 10
        Me.pbx_9.TabStop = False
        '
        'pbx_10
        '
        Me.pbx_10.Location = New System.Drawing.Point(209, 304)
        Me.pbx_10.Name = "pbx_10"
        Me.pbx_10.Size = New System.Drawing.Size(170, 99)
        Me.pbx_10.TabIndex = 11
        Me.pbx_10.TabStop = False
        '
        'pbx_11
        '
        Me.pbx_11.Location = New System.Drawing.Point(404, 304)
        Me.pbx_11.Name = "pbx_11"
        Me.pbx_11.Size = New System.Drawing.Size(170, 99)
        Me.pbx_11.TabIndex = 12
        Me.pbx_11.TabStop = False
        '
        'pbx_12
        '
        Me.pbx_12.Location = New System.Drawing.Point(603, 304)
        Me.pbx_12.Name = "pbx_12"
        Me.pbx_12.Size = New System.Drawing.Size(170, 99)
        Me.pbx_12.TabIndex = 13
        Me.pbx_12.TabStop = False
        '
        'btn_1
        '
        Me.btn_1.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_1.Location = New System.Drawing.Point(13, 68)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(169, 99)
        Me.btn_1.TabIndex = 14
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_2.Location = New System.Drawing.Point(209, 68)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(170, 99)
        Me.btn_2.TabIndex = 15
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_3.Location = New System.Drawing.Point(404, 68)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(170, 99)
        Me.btn_3.TabIndex = 16
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_4.Location = New System.Drawing.Point(603, 68)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(170, 99)
        Me.btn_4.TabIndex = 17
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_5.Location = New System.Drawing.Point(12, 182)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(170, 99)
        Me.btn_5.TabIndex = 18
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_6.Location = New System.Drawing.Point(209, 182)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(170, 99)
        Me.btn_6.TabIndex = 19
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_7
        '
        Me.btn_7.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_7.Location = New System.Drawing.Point(404, 182)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(170, 99)
        Me.btn_7.TabIndex = 20
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_8.Location = New System.Drawing.Point(603, 182)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(170, 99)
        Me.btn_8.TabIndex = 21
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_9.Location = New System.Drawing.Point(13, 304)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(170, 99)
        Me.btn_9.TabIndex = 22
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_10
        '
        Me.btn_10.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_10.Location = New System.Drawing.Point(209, 304)
        Me.btn_10.Name = "btn_10"
        Me.btn_10.Size = New System.Drawing.Size(170, 99)
        Me.btn_10.TabIndex = 23
        Me.btn_10.UseVisualStyleBackColor = True
        '
        'btn_11
        '
        Me.btn_11.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_11.Location = New System.Drawing.Point(404, 304)
        Me.btn_11.Name = "btn_11"
        Me.btn_11.Size = New System.Drawing.Size(170, 99)
        Me.btn_11.TabIndex = 24
        Me.btn_11.UseVisualStyleBackColor = True
        '
        'btn_12
        '
        Me.btn_12.Image = Global.SimpsonMemory.My.Resources.Resources.logo
        Me.btn_12.Location = New System.Drawing.Point(603, 304)
        Me.btn_12.Name = "btn_12"
        Me.btn_12.Size = New System.Drawing.Size(170, 99)
        Me.btn_12.TabIndex = 25
        Me.btn_12.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'frm_memory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(787, 417)
        Me.Controls.Add(Me.btn_12)
        Me.Controls.Add(Me.btn_11)
        Me.Controls.Add(Me.btn_10)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.pbx_12)
        Me.Controls.Add(Me.pbx_11)
        Me.Controls.Add(Me.pbx_10)
        Me.Controls.Add(Me.pbx_9)
        Me.Controls.Add(Me.pbx_8)
        Me.Controls.Add(Me.pbx_7)
        Me.Controls.Add(Me.pbx_6)
        Me.Controls.Add(Me.pbx_5)
        Me.Controls.Add(Me.pbx_4)
        Me.Controls.Add(Me.pbx_3)
        Me.Controls.Add(Me.pbx_2)
        Me.Controls.Add(Me.pbx_1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_memory"
        Me.Text = "Juego del Memory -- The Simpsons"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pbx_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaPartidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MejorRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lbl_numIntentos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbl_intentos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents pbx_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_8 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_9 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_10 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_11 As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_12 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_10 As System.Windows.Forms.Button
    Friend WithEvents btn_11 As System.Windows.Forms.Button
    Friend WithEvents btn_12 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
