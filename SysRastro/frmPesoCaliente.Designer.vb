<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesoCaliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesoCaliente))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LblBancos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.RbtHembra = New System.Windows.Forms.RadioButton()
        Me.RbtMacho = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblLinea = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.LblTextConse = New System.Windows.Forms.Label()
        Me.LblKg = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblConsecutivo = New System.Windows.Forms.Label()
        Me.lstAnimales = New System.Windows.Forms.ListView()
        Me.xArete = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xPesoOrigen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xCorral = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xLote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xTipoAnimal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xSalida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(743, 416)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 21
        Me.LineShape3.X2 = 750
        Me.LineShape3.Y1 = 65
        Me.LineShape3.Y2 = 65
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightSlateGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 24
        Me.LineShape1.X2 = 753
        Me.LineShape1.Y1 = 66
        Me.LineShape1.Y2 = 66
        '
        'LblBancos
        '
        Me.LblBancos.AutoSize = True
        Me.LblBancos.BackColor = System.Drawing.Color.Transparent
        Me.LblBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBancos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblBancos.Location = New System.Drawing.Point(48, 18)
        Me.LblBancos.Name = "LblBancos"
        Me.LblBancos.Size = New System.Drawing.Size(282, 36)
        Me.LblBancos.TabIndex = 99
        Me.LblBancos.Text = "Registro de Llegada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Arete :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 190
        Me.Label3.Text = "Peso Origen :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "Corral :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Lote :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Tipo Animal :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(73, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Salida :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(187, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 27)
        Me.TextBox1.TabIndex = 196
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(187, 119)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 27)
        Me.TextBox2.TabIndex = 197
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(187, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(166, 27)
        Me.TextBox3.TabIndex = 198
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(187, 183)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 27)
        Me.TextBox4.TabIndex = 199
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(187, 246)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(166, 27)
        Me.TextBox6.TabIndex = 201
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RbtHembra
        '
        Me.RbtHembra.AutoSize = True
        Me.RbtHembra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtHembra.Location = New System.Drawing.Point(187, 219)
        Me.RbtHembra.Name = "RbtHembra"
        Me.RbtHembra.Size = New System.Drawing.Size(76, 21)
        Me.RbtHembra.TabIndex = 203
        Me.RbtHembra.TabStop = True
        Me.RbtHembra.Text = "Hembra"
        Me.RbtHembra.UseVisualStyleBackColor = True
        '
        'RbtMacho
        '
        Me.RbtMacho.AutoSize = True
        Me.RbtMacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtMacho.Location = New System.Drawing.Point(285, 219)
        Me.RbtMacho.Name = "RbtMacho"
        Me.RbtMacho.Size = New System.Drawing.Size(68, 21)
        Me.RbtMacho.TabIndex = 204
        Me.RbtMacho.TabStop = True
        Me.RbtMacho.Text = "Macho"
        Me.RbtMacho.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.STBlblUsuario, Me.ToolStripStatusLabel2, Me.STBlblLinea})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 394)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(743, 22)
        Me.StatusStrip1.TabIndex = 205
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(211, 17)
        Me.ToolStripStatusLabel1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V."
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel3.Text = "||  Usuario : "
        '
        'STBlblUsuario
        '
        Me.STBlblUsuario.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STBlblUsuario.Name = "STBlblUsuario"
        Me.STBlblUsuario.Size = New System.Drawing.Size(67, 17)
        Me.STBlblUsuario.Text = "STBlblUsuario"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel2.Text = "||  N° Linea"
        '
        'STBlblLinea
        '
        Me.STBlblLinea.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STBlblLinea.Name = "STBlblLinea"
        Me.STBlblLinea.Size = New System.Drawing.Size(56, 17)
        Me.STBlblLinea.Text = "STBlblLinea"
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.Black
        Me.txtPeso.Enabled = False
        Me.txtPeso.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.Lime
        Me.txtPeso.Location = New System.Drawing.Point(369, 88)
        Me.txtPeso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPeso.Multiline = True
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ReadOnly = True
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeso.Size = New System.Drawing.Size(362, 117)
        Me.txtPeso.TabIndex = 206
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label11.Location = New System.Drawing.Point(373, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(353, 9)
        Me.Label11.TabIndex = 210
        Me.Label11.Text = "_________________________________________________________________________________" & _
            "______"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.BackColor = System.Drawing.Color.Black
        Me.lblPeso.Font = New System.Drawing.Font("Consolas", 45.0!)
        Me.lblPeso.ForeColor = System.Drawing.Color.Lime
        Me.lblPeso.Location = New System.Drawing.Point(435, 106)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(228, 70)
        Me.lblPeso.TabIndex = 209
        Me.lblPeso.Text = "104.71"
        '
        'LblTextConse
        '
        Me.LblTextConse.AutoSize = True
        Me.LblTextConse.BackColor = System.Drawing.Color.Black
        Me.LblTextConse.Font = New System.Drawing.Font("Consolas", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTextConse.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTextConse.Location = New System.Drawing.Point(373, 174)
        Me.LblTextConse.Name = "LblTextConse"
        Me.LblTextConse.Size = New System.Drawing.Size(108, 20)
        Me.LblTextConse.TabIndex = 208
        Me.LblTextConse.Text = "CONSECUTIVO"
        '
        'LblKg
        '
        Me.LblKg.AutoSize = True
        Me.LblKg.BackColor = System.Drawing.Color.Black
        Me.LblKg.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKg.ForeColor = System.Drawing.Color.Lime
        Me.LblKg.Location = New System.Drawing.Point(658, 154)
        Me.LblKg.Name = "LblKg"
        Me.LblKg.Size = New System.Drawing.Size(60, 26)
        Me.LblKg.TabIndex = 207
        Me.LblKg.Text = "■ KG"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label8.Location = New System.Drawing.Point(374, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(353, 9)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "_________________________________________________________________________________" & _
            "______"
        '
        'lblConsecutivo
        '
        Me.lblConsecutivo.AutoSize = True
        Me.lblConsecutivo.BackColor = System.Drawing.Color.Black
        Me.lblConsecutivo.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutivo.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblConsecutivo.Location = New System.Drawing.Point(487, 173)
        Me.lblConsecutivo.Name = "lblConsecutivo"
        Me.lblConsecutivo.Size = New System.Drawing.Size(40, 22)
        Me.lblConsecutivo.TabIndex = 212
        Me.lblConsecutivo.Text = "000"
        '
        'lstAnimales
        '
        Me.lstAnimales.BackColor = System.Drawing.Color.Gainsboro
        Me.lstAnimales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xArete, Me.xPesoOrigen, Me.xCorral, Me.xLote, Me.xTipoAnimal, Me.xSalida})
        Me.lstAnimales.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAnimales.FullRowSelect = True
        Me.lstAnimales.GridLines = True
        Me.lstAnimales.Location = New System.Drawing.Point(76, 280)
        Me.lstAnimales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstAnimales.Name = "lstAnimales"
        Me.lstAnimales.Size = New System.Drawing.Size(599, 105)
        Me.lstAnimales.TabIndex = 213
        Me.lstAnimales.UseCompatibleStateImageBehavior = False
        Me.lstAnimales.View = System.Windows.Forms.View.Details
        '
        'xArete
        '
        Me.xArete.Tag = ""
        Me.xArete.Text = "                     ARETE"
        Me.xArete.Width = 138
        '
        'xPesoOrigen
        '
        Me.xPesoOrigen.Text = "        PESO ORIGEN"
        Me.xPesoOrigen.Width = 102
        '
        'xCorral
        '
        Me.xCorral.Text = "CORRAL    "
        Me.xCorral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.xCorral.Width = 72
        '
        'xLote
        '
        Me.xLote.Text = "         LOTE"
        Me.xLote.Width = 78
        '
        'xTipoAnimal
        '
        Me.xTipoAnimal.Text = "         TIPO ANIMAL"
        Me.xTipoAnimal.Width = 115
        '
        'xSalida
        '
        Me.xSalida.Text = "     SALIDA"
        Me.xSalida.Width = 68
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(530, 242)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 27)
        Me.DateTimePicker1.TabIndex = 214
        '
        'frmPesoCaliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(743, 416)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lstAnimales)
        Me.Controls.Add(Me.lblConsecutivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.LblTextConse)
        Me.Controls.Add(Me.LblKg)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RbtMacho)
        Me.Controls.Add(Me.RbtHembra)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblBancos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesoCaliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura Canal Caliente"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LblBancos As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents RbtHembra As System.Windows.Forms.RadioButton
    Friend WithEvents RbtMacho As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblLinea As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents LblTextConse As System.Windows.Forms.Label
    Friend WithEvents LblKg As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblConsecutivo As System.Windows.Forms.Label
    Friend WithEvents lstAnimales As System.Windows.Forms.ListView
    Friend WithEvents xArete As System.Windows.Forms.ColumnHeader
    Friend WithEvents xPesoOrigen As System.Windows.Forms.ColumnHeader
    Friend WithEvents xCorral As System.Windows.Forms.ColumnHeader
    Friend WithEvents xLote As System.Windows.Forms.ColumnHeader
    Friend WithEvents xTipoAnimal As System.Windows.Forms.ColumnHeader
    Friend WithEvents xSalida As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
