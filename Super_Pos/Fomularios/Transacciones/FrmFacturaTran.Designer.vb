<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturaTran
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
        Me.dgvfact = New System.Windows.Forms.DataGridView()
        Me.txtcodproducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtrtn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblinterno = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtexento = New System.Windows.Forms.MaskedTextBox()
        Me.txtdescuento = New System.Windows.Forms.MaskedTextBox()
        Me.txtsubtot = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txttotal = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcambio = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtentregado = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbltipoisv = New System.Windows.Forms.Label()
        CType(Me.dgvfact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvfact
        '
        Me.dgvfact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfact.Location = New System.Drawing.Point(12, 141)
        Me.dgvfact.Name = "dgvfact"
        Me.dgvfact.Size = New System.Drawing.Size(919, 353)
        Me.dgvfact.TabIndex = 5
        '
        'txtcodproducto
        '
        Me.txtcodproducto.Location = New System.Drawing.Point(135, 24)
        Me.txtcodproducto.Name = "txtcodproducto"
        Me.txtcodproducto.Size = New System.Drawing.Size(137, 22)
        Me.txtcodproducto.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código de producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facturación"
        '
        'btnbuscar
        '
        Me.btnbuscar.Image = Global.Super_Pos.My.Resources.Resources.buscar24
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbuscar.Location = New System.Drawing.Point(278, 13)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(35, 34)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtrtn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcodcliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(463, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 110)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.Super_Pos.My.Resources.Resources.buscar24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(271, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtrtn
        '
        Me.txtrtn.Enabled = False
        Me.txtrtn.Location = New System.Drawing.Point(128, 80)
        Me.txtrtn.Name = "txtrtn"
        Me.txtrtn.Size = New System.Drawing.Size(137, 22)
        Me.txtrtn.TabIndex = 5
        Me.txtrtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RTN:"
        '
        'txtcliente
        '
        Me.txtcliente.Enabled = False
        Me.txtcliente.Location = New System.Drawing.Point(128, 52)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(334, 22)
        Me.txtcliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(128, 24)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(137, 22)
        Me.txtcodcliente.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Código de cliente:"
        '
        'lblinterno
        '
        Me.lblinterno.AutoSize = True
        Me.lblinterno.Location = New System.Drawing.Point(918, 9)
        Me.lblinterno.Name = "lblinterno"
        Me.lblinterno.Size = New System.Drawing.Size(13, 13)
        Me.lblinterno.TabIndex = 23
        Me.lblinterno.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(849, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Interno:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 550)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 115)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtexento)
        Me.GroupBox3.Controls.Add(Me.txtdescuento)
        Me.GroupBox3.Controls.Add(Me.txtsubtot)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(641, 500)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 113)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'txtexento
        '
        Me.txtexento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtexento.Enabled = False
        Me.txtexento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexento.Location = New System.Drawing.Point(113, 77)
        Me.txtexento.Mask = "000,000.00"
        Me.txtexento.Name = "txtexento"
        Me.txtexento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtexento.Size = New System.Drawing.Size(171, 26)
        Me.txtexento.TabIndex = 0
        Me.txtexento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdescuento
        '
        Me.txtdescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento.Location = New System.Drawing.Point(113, 45)
        Me.txtdescuento.Mask = "000,000.00"
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtdescuento.Size = New System.Drawing.Size(171, 26)
        Me.txtdescuento.TabIndex = 4
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsubtot
        '
        Me.txtsubtot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsubtot.Enabled = False
        Me.txtsubtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtot.Location = New System.Drawing.Point(113, 13)
        Me.txtsubtot.Mask = "000,000.00"
        Me.txtsubtot.Name = "txtsubtot"
        Me.txtsubtot.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsubtot.Size = New System.Drawing.Size(171, 26)
        Me.txtsubtot.TabIndex = 2
        Me.txtsubtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Exento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Descuento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Subtotal:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Silver
        Me.GroupBox4.Controls.Add(Me.txttotal)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(641, 619)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(290, 46)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.Silver
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(113, 11)
        Me.txttotal.Mask = "000,000.00"
        Me.txttotal.Name = "txttotal"
        Me.txttotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txttotal.Size = New System.Drawing.Size(171, 29)
        Me.txttotal.TabIndex = 1
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Silver
        Me.GroupBox5.Controls.Add(Me.txtcambio)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtentregado)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 500)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(623, 46)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'txtcambio
        '
        Me.txtcambio.BackColor = System.Drawing.Color.Silver
        Me.txtcambio.Enabled = False
        Me.txtcambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcambio.Location = New System.Drawing.Point(446, 10)
        Me.txtcambio.Mask = "000.00"
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcambio.Size = New System.Drawing.Size(171, 29)
        Me.txtcambio.TabIndex = 8
        Me.txtcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(353, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 24)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Cambio:"
        '
        'txtentregado
        '
        Me.txtentregado.BackColor = System.Drawing.Color.LightGray
        Me.txtentregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtentregado.Location = New System.Drawing.Point(125, 11)
        Me.txtentregado.Mask = "000,000.00"
        Me.txtentregado.Name = "txtentregado"
        Me.txtentregado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtentregado.Size = New System.Drawing.Size(171, 29)
        Me.txtentregado.TabIndex = 6
        Me.txtentregado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Entregado:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbltipoisv)
        Me.GroupBox6.Controls.Add(Me.btnagregar)
        Me.GroupBox6.Controls.Add(Me.txtprecio)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.txtcantidad)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txtproducto)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtcodproducto)
        Me.GroupBox6.Controls.Add(Me.btnbuscar)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(445, 110)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Producto"
        '
        'btnagregar
        '
        Me.btnagregar.Enabled = False
        Me.btnagregar.Image = Global.Super_Pos.My.Resources.Resources.agregar24
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnagregar.Location = New System.Drawing.Point(319, 13)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(35, 34)
        Me.btnagregar.TabIndex = 12
        Me.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(339, 81)
        Me.txtprecio.Mask = "000,000.00"
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtprecio.Size = New System.Drawing.Size(100, 23)
        Me.txtprecio.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(268, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 16)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Precio:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(135, 81)
        Me.txtcantidad.Mask = "000.00"
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcantidad.Size = New System.Drawing.Size(100, 23)
        Me.txtcantidad.TabIndex = 9
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Cantidad:"
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Location = New System.Drawing.Point(135, 53)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(304, 22)
        Me.txtproducto.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Producto:"
        '
        'lbltipoisv
        '
        Me.lbltipoisv.AutoSize = True
        Me.lbltipoisv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipoisv.Location = New System.Drawing.Point(423, 22)
        Me.lbltipoisv.Name = "lbltipoisv"
        Me.lbltipoisv.Size = New System.Drawing.Size(13, 17)
        Me.lbltipoisv.TabIndex = 24
        Me.lbltipoisv.Text = "*"
        '
        'FrmFacturaTran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(943, 671)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblinterno)
        Me.Controls.Add(Me.dgvfact)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFacturaTran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.dgvfact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents dgvfact As DataGridView
    Public WithEvents txtcodproducto As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Public WithEvents btnbuscar As Button
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents txtrtn As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtcliente As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtcodcliente As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents lblinterno As Label
    Public WithEvents Label16 As Label
    Public WithEvents Button1 As Button
    Public WithEvents GroupBox2 As GroupBox
    Public WithEvents GroupBox3 As GroupBox
    Public WithEvents GroupBox4 As GroupBox
    Public WithEvents Label7 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label10 As Label
    Friend WithEvents txtexento As MaskedTextBox
    Friend WithEvents txtdescuento As MaskedTextBox
    Friend WithEvents txtsubtot As MaskedTextBox
    Friend WithEvents txttotal As MaskedTextBox
    Public WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtcambio As MaskedTextBox
    Public WithEvents Label11 As Label
    Friend WithEvents txtentregado As MaskedTextBox
    Public WithEvents Label9 As Label
    Public WithEvents GroupBox6 As GroupBox
    Public WithEvents txtproducto As TextBox
    Public WithEvents Label12 As Label
    Public WithEvents btnagregar As Button
    Friend WithEvents txtprecio As MaskedTextBox
    Public WithEvents Label14 As Label
    Friend WithEvents txtcantidad As MaskedTextBox
    Public WithEvents Label13 As Label
    Public WithEvents lbltipoisv As Label
End Class
