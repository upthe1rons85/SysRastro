<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesoPie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesoPie))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LblBancos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtArete = New System.Windows.Forms.TextBox()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.TxtLote = New System.Windows.Forms.TextBox()
        Me.TxtSalida = New System.Windows.Forms.TextBox()
        Me.RbtHembra = New System.Windows.Forms.RadioButton()
        Me.RbtMacho = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblLinea = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.LblTextConse = New System.Windows.Forms.Label()
        Me.LblKg = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblConsecutivo = New System.Windows.Forms.Label()
        Me.lstAnimales = New System.Windows.Forms.ListView()
        Me.xFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xArete = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xAreteSagarpa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xPesoOrigen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xCorral = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xLote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xTipoAnimal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xSalida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAreteSagarpa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.lblconsecutivoArete = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(723, 442)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 26
        Me.LineShape3.X2 = 743
        Me.LineShape3.Y1 = 49
        Me.LineShape3.Y2 = 49
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightSlateGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 29
        Me.LineShape1.X2 = 746
        Me.LineShape1.Y1 = 50
        Me.LineShape1.Y2 = 50
        '
        'LblBancos
        '
        Me.LblBancos.AutoSize = True
        Me.LblBancos.BackColor = System.Drawing.Color.Transparent
        Me.LblBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBancos.ForeColor = System.Drawing.Color.Black
        Me.LblBancos.Location = New System.Drawing.Point(18, 9)
        Me.LblBancos.Name = "LblBancos"
        Me.LblBancos.Size = New System.Drawing.Size(282, 36)
        Me.LblBancos.TabIndex = 0
        Me.LblBancos.Text = "Registro de Llegada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Arete :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Peso :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Lote :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Tipo Animal :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Salida :"
        '
        'TxtArete
        '
        Me.TxtArete.BackColor = System.Drawing.SystemColors.Info
        Me.TxtArete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArete.Location = New System.Drawing.Point(157, 141)
        Me.TxtArete.Name = "TxtArete"
        Me.TxtArete.Size = New System.Drawing.Size(166, 27)
        Me.TxtArete.TabIndex = 9
        Me.TxtArete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPeso
        '
        Me.TxtPeso.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPeso.Location = New System.Drawing.Point(157, 231)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(166, 27)
        Me.TxtPeso.TabIndex = 11
        Me.TxtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtLote
        '
        Me.TxtLote.BackColor = System.Drawing.SystemColors.Info
        Me.TxtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLote.Location = New System.Drawing.Point(157, 111)
        Me.TxtLote.Name = "TxtLote"
        Me.TxtLote.Size = New System.Drawing.Size(166, 27)
        Me.TxtLote.TabIndex = 8
        Me.TxtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSalida
        '
        Me.TxtSalida.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSalida.Location = New System.Drawing.Point(157, 201)
        Me.TxtSalida.Name = "TxtSalida"
        Me.TxtSalida.Size = New System.Drawing.Size(166, 27)
        Me.TxtSalida.TabIndex = 12
        Me.TxtSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RbtHembra
        '
        Me.RbtHembra.AutoSize = True
        Me.RbtHembra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtHembra.Location = New System.Drawing.Point(157, 265)
        Me.RbtHembra.Name = "RbtHembra"
        Me.RbtHembra.Size = New System.Drawing.Size(76, 21)
        Me.RbtHembra.TabIndex = 13
        Me.RbtHembra.TabStop = True
        Me.RbtHembra.Text = "Hembra"
        Me.RbtHembra.UseVisualStyleBackColor = True
        '
        'RbtMacho
        '
        Me.RbtMacho.AutoSize = True
        Me.RbtMacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtMacho.Location = New System.Drawing.Point(255, 265)
        Me.RbtMacho.Name = "RbtMacho"
        Me.RbtMacho.Size = New System.Drawing.Size(68, 21)
        Me.RbtMacho.TabIndex = 14
        Me.RbtMacho.TabStop = True
        Me.RbtMacho.Text = "Macho"
        Me.RbtMacho.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.STBlblUsuario, Me.ToolStripStatusLabel2, Me.STBlblLinea})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(723, 22)
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
        'txtDisplay
        '
        Me.txtDisplay.BackColor = System.Drawing.Color.Black
        Me.txtDisplay.Enabled = False
        Me.txtDisplay.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.ForeColor = System.Drawing.Color.Lime
        Me.txtDisplay.Location = New System.Drawing.Point(339, 79)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDisplay.Size = New System.Drawing.Size(358, 117)
        Me.txtDisplay.TabIndex = 206
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label11.Location = New System.Drawing.Point(343, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(345, 9)
        Me.Label11.TabIndex = 210
        Me.Label11.Text = "_________________________________________________________________________________" & _
            "____"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.BackColor = System.Drawing.Color.Black
        Me.lblPeso.Font = New System.Drawing.Font("Consolas", 45.0!)
        Me.lblPeso.ForeColor = System.Drawing.Color.Lime
        Me.lblPeso.Location = New System.Drawing.Point(397, 97)
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
        Me.LblTextConse.Location = New System.Drawing.Point(343, 165)
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
        Me.LblKg.Location = New System.Drawing.Point(620, 145)
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
        Me.Label8.Location = New System.Drawing.Point(344, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(345, 9)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "_________________________________________________________________________________" & _
            "____"
        '
        'lblConsecutivo
        '
        Me.lblConsecutivo.AutoSize = True
        Me.lblConsecutivo.BackColor = System.Drawing.Color.Black
        Me.lblConsecutivo.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsecutivo.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblConsecutivo.Location = New System.Drawing.Point(457, 164)
        Me.lblConsecutivo.Name = "lblConsecutivo"
        Me.lblConsecutivo.Size = New System.Drawing.Size(40, 22)
        Me.lblConsecutivo.TabIndex = 212
        Me.lblConsecutivo.Text = "000"
        '
        'lstAnimales
        '
        Me.lstAnimales.BackColor = System.Drawing.Color.Gainsboro
        Me.lstAnimales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xFecha, Me.xArete, Me.xAreteSagarpa, Me.xPesoOrigen, Me.xCorral, Me.xLote, Me.xTipoAnimal, Me.xSalida})
        Me.lstAnimales.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAnimales.FullRowSelect = True
        Me.lstAnimales.GridLines = True
        Me.lstAnimales.Location = New System.Drawing.Point(46, 302)
        Me.lstAnimales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstAnimales.Name = "lstAnimales"
        Me.lstAnimales.Size = New System.Drawing.Size(651, 105)
        Me.lstAnimales.TabIndex = 213
        Me.lstAnimales.UseCompatibleStateImageBehavior = False
        Me.lstAnimales.View = System.Windows.Forms.View.Details
        '
        'xFecha
        '
        Me.xFecha.Text = "   FECHA"
        '
        'xArete
        '
        Me.xArete.Tag = ""
        Me.xArete.Text = "                        ARETE"
        Me.xArete.Width = 149
        '
        'xAreteSagarpa
        '
        Me.xAreteSagarpa.Text = "ARETE SAGARPA"
        Me.xAreteSagarpa.Width = 97
        '
        'xPesoOrigen
        '
        Me.xPesoOrigen.Text = "  PESO ORIGEN"
        Me.xPesoOrigen.Width = 85
        '
        'xCorral
        '
        Me.xCorral.DisplayIndex = 7
        Me.xCorral.Text = "CORRAL    "
        Me.xCorral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.xCorral.Width = 61
        '
        'xLote
        '
        Me.xLote.DisplayIndex = 4
        Me.xLote.Text = "      LOTE"
        Me.xLote.Width = 63
        '
        'xTipoAnimal
        '
        Me.xTipoAnimal.DisplayIndex = 5
        Me.xTipoAnimal.Text = "TIPO ANIMAL"
        Me.xTipoAnimal.Width = 73
        '
        'xSalida
        '
        Me.xSalida.DisplayIndex = 6
        Me.xSalida.Text = "     SALIDA"
        Me.xSalida.Width = 59
        '
        'DtpFecha
        '
        Me.DtpFecha.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(157, 81)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(166, 27)
        Me.DtpFecha.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha :"
        '
        'TxtAreteSagarpa
        '
        Me.TxtAreteSagarpa.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAreteSagarpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAreteSagarpa.Location = New System.Drawing.Point(157, 171)
        Me.TxtAreteSagarpa.Name = "TxtAreteSagarpa"
        Me.TxtAreteSagarpa.Size = New System.Drawing.Size(166, 27)
        Me.TxtAreteSagarpa.TabIndex = 10
        Me.TxtAreteSagarpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Arete Sagarpa :"
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGrabar.Location = New System.Drawing.Point(461, 222)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(89, 47)
        Me.BtnGrabar.TabIndex = 214
        Me.BtnGrabar.Text = "GRABAR"
        Me.BtnGrabar.UseVisualStyleBackColor = False
        '
        'lblconsecutivoArete
        '
        Me.lblconsecutivoArete.AutoSize = True
        Me.lblconsecutivoArete.Location = New System.Drawing.Point(606, 285)
        Me.lblconsecutivoArete.Name = "lblconsecutivoArete"
        Me.lblconsecutivoArete.Size = New System.Drawing.Size(91, 13)
        Me.lblconsecutivoArete.TabIndex = 216
        Me.lblconsecutivoArete.Text = "ConsecutivoArete"
        '
        'frmPesoPie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(723, 442)
        Me.Controls.Add(Me.lblconsecutivoArete)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.TxtAreteSagarpa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.lstAnimales)
        Me.Controls.Add(Me.lblConsecutivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.LblTextConse)
        Me.Controls.Add(Me.LblKg)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RbtMacho)
        Me.Controls.Add(Me.RbtHembra)
        Me.Controls.Add(Me.TxtSalida)
        Me.Controls.Add(Me.TxtLote)
        Me.Controls.Add(Me.TxtPeso)
        Me.Controls.Add(Me.TxtArete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblBancos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesoPie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura Peso Pie"
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtArete As System.Windows.Forms.TextBox
    Friend WithEvents TxtPeso As System.Windows.Forms.TextBox
    Friend WithEvents TxtLote As System.Windows.Forms.TextBox
    Friend WithEvents TxtSalida As System.Windows.Forms.TextBox
    Friend WithEvents RbtHembra As System.Windows.Forms.RadioButton
    Friend WithEvents RbtMacho As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblLinea As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
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
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAreteSagarpa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents xAreteSagarpa As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents lblconsecutivoArete As System.Windows.Forms.Label
End Class
