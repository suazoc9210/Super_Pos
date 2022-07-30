<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfiguracionMant
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.tbcconfig = New System.Windows.Forms.TabControl()
        Me.tbpempresa = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpiefact = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtpropietario = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtempresa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodempresa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrtn = New System.Windows.Forms.TextBox()
        Me.tbpcai = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtvencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtrangautfin = New System.Windows.Forms.MaskedTextBox()
        Me.txtrangautin = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtprefijo = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcai = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbpimpuestos = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvisv = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtdescripisv = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcodisv = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.dgvcai = New System.Windows.Forms.DataGridView()
        Me.tbcconfig.SuspendLayout()
        Me.tbpempresa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbpcai.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbpimpuestos.SuspendLayout()
        CType(Me.dgvisv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvcai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Configuración"
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.Super_Pos.My.Resources.Resources.salir24
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(860, 6)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 45)
        Me.btnsalir.TabIndex = 11
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.Super_Pos.My.Resources.Resources.descartar
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(787, 6)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(67, 45)
        Me.btncancelar.TabIndex = 10
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'tbcconfig
        '
        Me.tbcconfig.Controls.Add(Me.tbpempresa)
        Me.tbcconfig.Controls.Add(Me.tbpcai)
        Me.tbcconfig.Controls.Add(Me.tbpimpuestos)
        Me.tbcconfig.Location = New System.Drawing.Point(12, 57)
        Me.tbcconfig.Name = "tbcconfig"
        Me.tbcconfig.SelectedIndex = 0
        Me.tbcconfig.Size = New System.Drawing.Size(919, 468)
        Me.tbcconfig.TabIndex = 12
        '
        'tbpempresa
        '
        Me.tbpempresa.Controls.Add(Me.GroupBox1)
        Me.tbpempresa.Location = New System.Drawing.Point(4, 22)
        Me.tbpempresa.Name = "tbpempresa"
        Me.tbpempresa.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpempresa.Size = New System.Drawing.Size(911, 431)
        Me.tbpempresa.TabIndex = 0
        Me.tbpempresa.Text = "Empresa"
        Me.tbpempresa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtpiefact)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtpropietario)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtempresa)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcodempresa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtrtn)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(899, 198)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Empresa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Pie factura:"
        '
        'txtpiefact
        '
        Me.txtpiefact.Location = New System.Drawing.Point(115, 154)
        Me.txtpiefact.Name = "txtpiefact"
        Me.txtpiefact.Size = New System.Drawing.Size(705, 20)
        Me.txtpiefact.TabIndex = 26
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(423, 128)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(397, 20)
        Me.txtcorreo.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Teléfono:"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(115, 128)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(137, 20)
        Me.txttelefono.TabIndex = 22
        '
        'txtpropietario
        '
        Me.txtpropietario.Location = New System.Drawing.Point(423, 76)
        Me.txtpropietario.Name = "txtpropietario"
        Me.txtpropietario.Size = New System.Drawing.Size(397, 20)
        Me.txtpropietario.TabIndex = 16
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(115, 102)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(705, 20)
        Me.txtdireccion.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Dirección:"
        '
        'txtempresa
        '
        Me.txtempresa.Location = New System.Drawing.Point(115, 50)
        Me.txtempresa.Name = "txtempresa"
        Me.txtempresa.Size = New System.Drawing.Size(705, 20)
        Me.txtempresa.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(347, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Propietario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Empresa:"
        '
        'txtcodempresa
        '
        Me.txtcodempresa.Location = New System.Drawing.Point(115, 24)
        Me.txtcodempresa.Name = "txtcodempresa"
        Me.txtcodempresa.Size = New System.Drawing.Size(137, 20)
        Me.txtcodempresa.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "RTN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código de empresa:"
        '
        'txtrtn
        '
        Me.txtrtn.Location = New System.Drawing.Point(115, 76)
        Me.txtrtn.Name = "txtrtn"
        Me.txtrtn.Size = New System.Drawing.Size(137, 20)
        Me.txtrtn.TabIndex = 12
        '
        'tbpcai
        '
        Me.tbpcai.Controls.Add(Me.Label19)
        Me.tbpcai.Controls.Add(Me.Label20)
        Me.tbpcai.Controls.Add(Me.TextBox3)
        Me.tbpcai.Controls.Add(Me.dgvcai)
        Me.tbpcai.Controls.Add(Me.GroupBox2)
        Me.tbpcai.Location = New System.Drawing.Point(4, 22)
        Me.tbpcai.Name = "tbpcai"
        Me.tbpcai.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpcai.Size = New System.Drawing.Size(911, 442)
        Me.tbpcai.TabIndex = 1
        Me.tbpcai.Text = "Facturación / CAI"
        Me.tbpcai.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtvencimiento)
        Me.GroupBox2.Controls.Add(Me.txtrangautfin)
        Me.GroupBox2.Controls.Add(Me.txtrangautin)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtprefijo)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtcai)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 127)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Facturación / CAI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Vencimiento:"
        '
        'dtvencimiento
        '
        Me.dtvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtvencimiento.Location = New System.Drawing.Point(126, 97)
        Me.dtvencimiento.Name = "dtvencimiento"
        Me.dtvencimiento.Size = New System.Drawing.Size(87, 20)
        Me.dtvencimiento.TabIndex = 32
        '
        'txtrangautfin
        '
        Me.txtrangautfin.Location = New System.Drawing.Point(374, 71)
        Me.txtrangautfin.Mask = "00000000"
        Me.txtrangautfin.Name = "txtrangautfin"
        Me.txtrangautfin.Size = New System.Drawing.Size(66, 20)
        Me.txtrangautfin.TabIndex = 31
        '
        'txtrangautin
        '
        Me.txtrangautin.Location = New System.Drawing.Point(126, 71)
        Me.txtrangautin.Mask = "00000000"
        Me.txtrangautin.Name = "txtrangautin"
        Me.txtrangautin.Size = New System.Drawing.Size(63, 20)
        Me.txtrangautin.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(265, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Inicio Autorizado:"
        '
        'txtprefijo
        '
        Me.txtprefijo.Location = New System.Drawing.Point(126, 45)
        Me.txtprefijo.Mask = "000-000-00"
        Me.txtprefijo.Name = "txtprefijo"
        Me.txtprefijo.Size = New System.Drawing.Size(63, 20)
        Me.txtprefijo.TabIndex = 27
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(374, 45)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(137, 20)
        Me.TextBox5.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(265, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Correlativo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Prefijo:"
        '
        'txtcai
        '
        Me.txtcai.Location = New System.Drawing.Point(126, 19)
        Me.txtcai.Name = "txtcai"
        Me.txtcai.Size = New System.Drawing.Size(137, 20)
        Me.txtcai.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Inicio Autorizado:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "CAI:"
        '
        'tbpimpuestos
        '
        Me.tbpimpuestos.Controls.Add(Me.Label9)
        Me.tbpimpuestos.Controls.Add(Me.Label10)
        Me.tbpimpuestos.Controls.Add(Me.txtbuscar)
        Me.tbpimpuestos.Controls.Add(Me.dgvisv)
        Me.tbpimpuestos.Controls.Add(Me.GroupBox3)
        Me.tbpimpuestos.Location = New System.Drawing.Point(4, 22)
        Me.tbpimpuestos.Name = "tbpimpuestos"
        Me.tbpimpuestos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpimpuestos.Size = New System.Drawing.Size(911, 442)
        Me.tbpimpuestos.TabIndex = 2
        Me.tbpimpuestos.Text = "Impuestos"
        Me.tbpimpuestos.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(499, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Escriba para buscar:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(500, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Lista de Impuestos"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(628, 44)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtbuscar.TabIndex = 24
        '
        'dgvisv
        '
        Me.dgvisv.AllowUserToAddRows = False
        Me.dgvisv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvisv.Location = New System.Drawing.Point(500, 67)
        Me.dgvisv.Name = "dgvisv"
        Me.dgvisv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvisv.Size = New System.Drawing.Size(386, 241)
        Me.dgvisv.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtdescripisv)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtcodisv)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 107)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Impuestos"
        '
        'txtdescripisv
        '
        Me.txtdescripisv.Location = New System.Drawing.Point(237, 45)
        Me.txtdescripisv.Name = "txtdescripisv"
        Me.txtdescripisv.Size = New System.Drawing.Size(183, 20)
        Me.txtdescripisv.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(165, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Descripción:"
        '
        'txtcodisv
        '
        Me.txtcodisv.Location = New System.Drawing.Point(84, 45)
        Me.txtcodisv.Name = "txtcodisv"
        Me.txtcodisv.Size = New System.Drawing.Size(56, 20)
        Me.txtcodisv.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Código ISV:"
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.Super_Pos.My.Resources.Resources.guardar24
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(714, 6)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(67, 45)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(112, 185)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Escriba para buscar:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(113, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 20)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Lista de CAI's"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(241, 182)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 20)
        Me.TextBox3.TabIndex = 28
        '
        'dgvcai
        '
        Me.dgvcai.AllowUserToAddRows = False
        Me.dgvcai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcai.Location = New System.Drawing.Point(113, 208)
        Me.dgvcai.Name = "dgvcai"
        Me.dgvcai.Size = New System.Drawing.Size(643, 228)
        Me.dgvcai.TabIndex = 25
        '
        'FrmConfiguracionMant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(943, 561)
        Me.Controls.Add(Me.tbcconfig)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfiguracionMant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.tbcconfig.ResumeLayout(False)
        Me.tbpempresa.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbpcai.ResumeLayout(False)
        Me.tbpcai.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbpimpuestos.ResumeLayout(False)
        Me.tbpimpuestos.PerformLayout()
        CType(Me.dgvisv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvcai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents btnsalir As Button
    Public WithEvents btncancelar As Button
    Public WithEvents Label1 As Label
    Friend WithEvents tbcconfig As TabControl
    Friend WithEvents tbpempresa As TabPage
    Friend WithEvents tbpcai As TabPage
    Friend WithEvents tbpimpuestos As TabPage
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents txtpropietario As TextBox
    Public WithEvents Label14 As Label
    Public WithEvents txtdireccion As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents txtrtn As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents txtempresa As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtcodempresa As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label7 As Label
    Public WithEvents txtpiefact As TextBox
    Public WithEvents txtcorreo As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents Label6 As Label
    Public WithEvents txttelefono As TextBox
    Public WithEvents btnguardar As Button
    Public WithEvents GroupBox2 As GroupBox
    Public WithEvents TextBox5 As TextBox
    Public WithEvents Label12 As Label
    Public WithEvents Label15 As Label
    Public WithEvents txtcai As TextBox
    Public WithEvents Label16 As Label
    Public WithEvents Label17 As Label
    Friend WithEvents txtprefijo As MaskedTextBox
    Friend WithEvents txtrangautfin As MaskedTextBox
    Friend WithEvents txtrangautin As MaskedTextBox
    Public WithEvents Label18 As Label
    Public WithEvents Label8 As Label
    Friend WithEvents dtvencimiento As DateTimePicker
    Public WithEvents GroupBox3 As GroupBox
    Public WithEvents txtdescripisv As TextBox
    Public WithEvents Label13 As Label
    Public WithEvents txtcodisv As TextBox
    Public WithEvents Label21 As Label
    Public WithEvents dgvisv As DataGridView
    Public WithEvents Label9 As Label
    Public WithEvents Label10 As Label
    Public WithEvents txtbuscar As TextBox
    Public WithEvents Label19 As Label
    Public WithEvents Label20 As Label
    Public WithEvents TextBox3 As TextBox
    Public WithEvents dgvcai As DataGridView
End Class
