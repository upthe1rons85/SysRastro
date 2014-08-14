<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatBasculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatBasculas))
        Me.LblBancos = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboParidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBitsParada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBistParidad = New System.Windows.Forms.TextBox()
        Me.cboPuertos = New System.Windows.Forms.ComboBox()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.spPuertos = New System.IO.Ports.SerialPort(Me.components)
        Me.txtBufferIn = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnValidaDato = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDatoFin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDatoIni = New System.Windows.Forms.TextBox()
        Me.txtDatoBasculaNumerico = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstBasculas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblBancos
        '
        Me.LblBancos.AutoSize = True
        Me.LblBancos.BackColor = System.Drawing.Color.Transparent
        Me.LblBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBancos.ForeColor = System.Drawing.Color.Navy
        Me.LblBancos.Location = New System.Drawing.Point(12, 21)
        Me.LblBancos.Name = "LblBancos"
        Me.LblBancos.Size = New System.Drawing.Size(247, 29)
        Me.LblBancos.TabIndex = 98
        Me.LblBancos.Text = "Catálogo de Basculas"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(481, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.BtnNuevo.TabIndex = 12
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(524, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(37, 38)
        Me.btnModificar.TabIndex = 13
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.Location = New System.Drawing.Point(567, 12)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGrabar.TabIndex = 11
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 16
        Me.LineShape2.X2 = 609
        Me.LineShape2.Y1 = 62
        Me.LineShape2.Y2 = 62
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(621, 404)
        Me.ShapeContainer1.TabIndex = 103
        Me.ShapeContainer1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboParidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBitsParada)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBistParidad)
        Me.GroupBox1.Controls.Add(Me.cboPuertos)
        Me.GroupBox1.Controls.Add(Me.txtVelocidad)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 152)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros Basculas"
        '
        'cboParidad
        '
        Me.cboParidad.FormattingEnabled = True
        Me.cboParidad.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.cboParidad.Location = New System.Drawing.Point(91, 98)
        Me.cboParidad.Name = "cboParidad"
        Me.cboParidad.Size = New System.Drawing.Size(121, 21)
        Me.cboParidad.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "Puerto :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bits de Parada :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Paridad :"
        '
        'txtBitsParada
        '
        Me.txtBitsParada.Location = New System.Drawing.Point(91, 125)
        Me.txtBitsParada.Name = "txtBitsParada"
        Me.txtBitsParada.Size = New System.Drawing.Size(32, 20)
        Me.txtBitsParada.TabIndex = 6
        Me.txtBitsParada.Text = "1"
        Me.txtBitsParada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bits Paridad :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Velocidad :"
        '
        'txtBistParidad
        '
        Me.txtBistParidad.Location = New System.Drawing.Point(91, 72)
        Me.txtBistParidad.Name = "txtBistParidad"
        Me.txtBistParidad.Size = New System.Drawing.Size(32, 20)
        Me.txtBistParidad.TabIndex = 4
        Me.txtBistParidad.Text = "8"
        Me.txtBistParidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboPuertos
        '
        Me.cboPuertos.FormattingEnabled = True
        Me.cboPuertos.Location = New System.Drawing.Point(91, 19)
        Me.cboPuertos.Name = "cboPuertos"
        Me.cboPuertos.Size = New System.Drawing.Size(121, 21)
        Me.cboPuertos.TabIndex = 2
        '
        'txtVelocidad
        '
        Me.txtVelocidad.Location = New System.Drawing.Point(91, 46)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(54, 20)
        Me.txtVelocidad.TabIndex = 3
        Me.txtVelocidad.Text = "9600"
        Me.txtVelocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(169, 57)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(131, 23)
        Me.btnConectar.TabIndex = 9
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 1000
        '
        'spPuertos
        '
        Me.spPuertos.Parity = System.IO.Ports.Parity.Odd
        '
        'txtBufferIn
        '
        Me.txtBufferIn.BackColor = System.Drawing.Color.Black
        Me.txtBufferIn.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.txtBufferIn.ForeColor = System.Drawing.Color.Lime
        Me.txtBufferIn.Location = New System.Drawing.Point(3, 25)
        Me.txtBufferIn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBufferIn.Multiline = True
        Me.txtBufferIn.Name = "txtBufferIn"
        Me.txtBufferIn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBufferIn.Size = New System.Drawing.Size(297, 29)
        Me.txtBufferIn.TabIndex = 192
        Me.txtBufferIn.Text = "ABD00251.52XYZ"
        Me.txtBufferIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnValidaDato)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDatoFin)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnConectar)
        Me.GroupBox2.Controls.Add(Me.txtDatoIni)
        Me.GroupBox2.Controls.Add(Me.txtDatoBasculaNumerico)
        Me.GroupBox2.Controls.Add(Me.txtBufferIn)
        Me.GroupBox2.Location = New System.Drawing.Point(305, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 156)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display Bascula"
        '
        'btnValidaDato
        '
        Me.btnValidaDato.Enabled = False
        Me.btnValidaDato.Location = New System.Drawing.Point(169, 83)
        Me.btnValidaDato.Name = "btnValidaDato"
        Me.btnValidaDato.Size = New System.Drawing.Size(131, 22)
        Me.btnValidaDato.TabIndex = 10
        Me.btnValidaDato.Text = "Validar Dato Peso"
        Me.btnValidaDato.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "Cadena Final :"
        '
        'txtDatoFin
        '
        Me.txtDatoFin.Location = New System.Drawing.Point(98, 83)
        Me.txtDatoFin.Name = "txtDatoFin"
        Me.txtDatoFin.Size = New System.Drawing.Size(59, 20)
        Me.txtDatoFin.TabIndex = 8
        Me.txtDatoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Cadena Inicial :"
        '
        'txtDatoIni
        '
        Me.txtDatoIni.Location = New System.Drawing.Point(98, 59)
        Me.txtDatoIni.Name = "txtDatoIni"
        Me.txtDatoIni.Size = New System.Drawing.Size(59, 20)
        Me.txtDatoIni.TabIndex = 7
        Me.txtDatoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDatoBasculaNumerico
        '
        Me.txtDatoBasculaNumerico.BackColor = System.Drawing.Color.Black
        Me.txtDatoBasculaNumerico.Font = New System.Drawing.Font("Consolas", 20.0!)
        Me.txtDatoBasculaNumerico.ForeColor = System.Drawing.Color.Lime
        Me.txtDatoBasculaNumerico.Location = New System.Drawing.Point(4, 110)
        Me.txtDatoBasculaNumerico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDatoBasculaNumerico.Multiline = True
        Me.txtDatoBasculaNumerico.Name = "txtDatoBasculaNumerico"
        Me.txtDatoBasculaNumerico.ReadOnly = True
        Me.txtDatoBasculaNumerico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDatoBasculaNumerico.Size = New System.Drawing.Size(296, 36)
        Me.txtDatoBasculaNumerico.TabIndex = 194
        Me.txtDatoBasculaNumerico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtDescripcion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtFolio)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(282, 62)
        Me.GroupBox3.TabIndex = 194
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Descripcion :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(90, 34)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(186, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Folio :"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(90, 10)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(45, 20)
        Me.txtFolio.TabIndex = 0
        Me.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstBasculas)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 153)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(282, 246)
        Me.GroupBox4.TabIndex = 195
        Me.GroupBox4.TabStop = False
        '
        'lstBasculas
        '
        Me.lstBasculas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstBasculas.FullRowSelect = True
        Me.lstBasculas.GridLines = True
        Me.lstBasculas.Location = New System.Drawing.Point(6, 21)
        Me.lstBasculas.Name = "lstBasculas"
        Me.lstBasculas.Size = New System.Drawing.Size(270, 218)
        Me.lstBasculas.TabIndex = 100
        Me.lstBasculas.UseCompatibleStateImageBehavior = False
        Me.lstBasculas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Folio"
        Me.ColumnHeader1.Width = 46
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Bascula"
        Me.ColumnHeader2.Width = 166
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Conce"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 50
        '
        'frmCatBasculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 404)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.LblBancos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCatBasculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCatBasculas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents LblBancos As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBistParidad As System.Windows.Forms.TextBox
    Friend WithEvents txtVelocidad As System.Windows.Forms.TextBox
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents cboPuertos As System.Windows.Forms.ComboBox
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents spPuertos As System.IO.Ports.SerialPort
    Friend WithEvents txtBufferIn As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDatoBasculaNumerico As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBitsParada As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboParidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDatoFin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDatoIni As System.Windows.Forms.TextBox
    Friend WithEvents btnValidaDato As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstBasculas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
