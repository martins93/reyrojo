<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu
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
        Me.tab_control = New System.Windows.Forms.TabControl()
        Me.tab_control_abogado = New System.Windows.Forms.TabPage()
        Me.mtxt_abogado_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.txt_abogado_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_abogado_apellido = New System.Windows.Forms.TextBox()
        Me.txt_abogado_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_abogado_domicilio = New System.Windows.Forms.Label()
        Me.txt_abogado_matricula = New System.Windows.Forms.TextBox()
        Me.lbl_abogado_apellido = New System.Windows.Forms.Label()
        Me.lbl_abogado_telefono = New System.Windows.Forms.Label()
        Me.lbl_abogado_nombre = New System.Windows.Forms.Label()
        Me.lbl_abogado_matricula = New System.Windows.Forms.Label()
        Me.tab_control_solicitante = New System.Windows.Forms.TabPage()
        Me.cmb_solicitante_tipodoc = New System.Windows.Forms.ComboBox()
        Me.TipoDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAV1DataSet = New TP_PAV1.PAV1DataSet()
        Me.mtxt_solicitante_nrodoc = New System.Windows.Forms.MaskedTextBox()
        Me.mtxt_solicitante_fechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.mtxt_solicitante_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.txt_solicitante_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_solicitante_apellido = New System.Windows.Forms.TextBox()
        Me.txt_solicitante_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_solicitante_fechanac = New System.Windows.Forms.Label()
        Me.lbl_solicitante_domicilio = New System.Windows.Forms.Label()
        Me.lbl_solicitante_apellido = New System.Windows.Forms.Label()
        Me.lbl_solicitante_telefono = New System.Windows.Forms.Label()
        Me.lbl_solicitante_nombre = New System.Windows.Forms.Label()
        Me.lbl_solicitante_tipodoc = New System.Windows.Forms.Label()
        Me.lbl_solicitante_nrodoc = New System.Windows.Forms.Label()
        Me.tab_control_empleado = New System.Windows.Forms.TabPage()
        Me.btn_empleado_nuevoCargo = New System.Windows.Forms.Button()
        Me.txt_empleado_fecha = New System.Windows.Forms.TextBox()
        Me.lbl_empleado_cargo = New System.Windows.Forms.Label()
        Me.cmb_empleado_cargo = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_empleado_legSup = New System.Windows.Forms.Label()
        Me.txt_empleado_legSup = New System.Windows.Forms.TextBox()
        Me.lbl_empleado_fecha = New System.Windows.Forms.Label()
        Me.lbl_empleado_legajo = New System.Windows.Forms.Label()
        Me.lbl_empleado_ape = New System.Windows.Forms.Label()
        Me.lbl_empleado_nombre = New System.Windows.Forms.Label()
        Me.txt_empleado_ape = New System.Windows.Forms.TextBox()
        Me.txt_empleado_legajo = New System.Windows.Forms.TextBox()
        Me.txt_empleado_nombre = New System.Windows.Forms.TextBox()
        Me.tab_control_credito = New System.Windows.Forms.TabPage()
        Me.cmb_creditos_estadoCredito = New System.Windows.Forms.ComboBox()
        Me.lbl_creditos_estadoCredito = New System.Windows.Forms.Label()
        Me.txt_creditos_idObjeto = New System.Windows.Forms.TextBox()
        Me.txt_creditos_objeto = New System.Windows.Forms.TextBox()
        Me.lbl_creditos_objeto = New System.Windows.Forms.Label()
        Me.mtxt_creditos_fAprobacion = New System.Windows.Forms.MaskedTextBox()
        Me.txt_creditos_legajo = New System.Windows.Forms.TextBox()
        Me.lbl_creditos_legajo = New System.Windows.Forms.Label()
        Me.txt_creditos_idSolicitante = New System.Windows.Forms.TextBox()
        Me.lbl_creditos_idSolicitante = New System.Windows.Forms.Label()
        Me.lbl_creditos_fAprobacion = New System.Windows.Forms.Label()
        Me.txt_creditos_fSolicitud = New System.Windows.Forms.TextBox()
        Me.lbl_creditos_fSolicitud = New System.Windows.Forms.Label()
        Me.txt_creditos_monto = New System.Windows.Forms.TextBox()
        Me.lbl_creditos_monto = New System.Windows.Forms.Label()
        Me.tab_control_expediente = New System.Windows.Forms.TabPage()
        Me.txt_expediente_matAbSol = New System.Windows.Forms.TextBox()
        Me.txt_expediente_observacion = New System.Windows.Forms.TextBox()
        Me.txt_expediente_matAbCre = New System.Windows.Forms.TextBox()
        Me.txt_expediente_fechaInicio = New System.Windows.Forms.TextBox()
        Me.txt_expediente_codCred = New System.Windows.Forms.TextBox()
        Me.txt_expediente_numeroExp = New System.Windows.Forms.TextBox()
        Me.lbl_expediente_matAbSol = New System.Windows.Forms.Label()
        Me.lbl_expediente_matAbCre = New System.Windows.Forms.Label()
        Me.lbl_expediente_observacion = New System.Windows.Forms.Label()
        Me.lbl_expediente_fechaInicio = New System.Windows.Forms.Label()
        Me.lbl_expediente_codCred = New System.Windows.Forms.Label()
        Me.lbl_expediente_numeroExp = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Tipo_DocumentoTableAdapter = New TP_PAV1.PAV1DataSetTableAdapters.tipo_DocumentoTableAdapter()
        Me.grp_controles = New System.Windows.Forms.GroupBox()
        Me.tab_menu = New System.Windows.Forms.TabControl()
        Me.tab_menu_inicio = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_menu_abm = New System.Windows.Forms.TabPage()
        Me.TipoDocumentoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoTableAdapter = New TP_PAV1.PAV1DataSetTableAdapters.CargoTableAdapter()
        Me.tab_control_garantia = New System.Windows.Forms.TabPage()
        Me.lbl_garantia_codCredito = New System.Windows.Forms.Label()
        Me.txt_garantia_idCredito = New System.Windows.Forms.TextBox()
        Me.lbl_garantia_descripcion = New System.Windows.Forms.Label()
        Me.txt_garantia_descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_garantia_monto = New System.Windows.Forms.Label()
        Me.txt_garantia_monto = New System.Windows.Forms.TextBox()
        Me.btn_garantia_documentacion = New System.Windows.Forms.Button()
        Me.tab_control.SuspendLayout()
        Me.tab_control_abogado.SuspendLayout()
        Me.tab_control_solicitante.SuspendLayout()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAV1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control_empleado.SuspendLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control_credito.SuspendLayout()
        Me.tab_control_expediente.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_controles.SuspendLayout()
        Me.tab_menu.SuspendLayout()
        Me.tab_menu_inicio.SuspendLayout()
        Me.tab_menu_abm.SuspendLayout()
        CType(Me.TipoDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control_garantia.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_control
        '
        Me.tab_control.Controls.Add(Me.tab_control_abogado)
        Me.tab_control.Controls.Add(Me.tab_control_solicitante)
        Me.tab_control.Controls.Add(Me.tab_control_empleado)
        Me.tab_control.Controls.Add(Me.tab_control_credito)
        Me.tab_control.Controls.Add(Me.tab_control_expediente)
        Me.tab_control.Controls.Add(Me.tab_control_garantia)
        Me.tab_control.Location = New System.Drawing.Point(0, 8)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.SelectedIndex = 0
        Me.tab_control.Size = New System.Drawing.Size(428, 644)
        Me.tab_control.TabIndex = 0
        '
        'tab_control_abogado
        '
        Me.tab_control_abogado.Controls.Add(Me.mtxt_abogado_telefono)
        Me.tab_control_abogado.Controls.Add(Me.txt_abogado_domicilio)
        Me.tab_control_abogado.Controls.Add(Me.txt_abogado_apellido)
        Me.tab_control_abogado.Controls.Add(Me.txt_abogado_nombre)
        Me.tab_control_abogado.Controls.Add(Me.lbl_abogado_domicilio)
        Me.tab_control_abogado.Controls.Add(Me.txt_abogado_matricula)
        Me.tab_control_abogado.Controls.Add(Me.lbl_abogado_apellido)
        Me.tab_control_abogado.Controls.Add(Me.lbl_abogado_telefono)
        Me.tab_control_abogado.Controls.Add(Me.lbl_abogado_nombre)
        Me.tab_control_abogado.Controls.Add(Me.lbl_abogado_matricula)
        Me.tab_control_abogado.Location = New System.Drawing.Point(4, 22)
        Me.tab_control_abogado.Name = "tab_control_abogado"
        Me.tab_control_abogado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_control_abogado.Size = New System.Drawing.Size(420, 618)
        Me.tab_control_abogado.TabIndex = 1
        Me.tab_control_abogado.Text = "Abogado"
        Me.tab_control_abogado.UseVisualStyleBackColor = True
        '
        'mtxt_abogado_telefono
        '
        Me.mtxt_abogado_telefono.Location = New System.Drawing.Point(123, 131)
        Me.mtxt_abogado_telefono.Mask = "(000) 000-000-000"
        Me.mtxt_abogado_telefono.Name = "mtxt_abogado_telefono"
        Me.mtxt_abogado_telefono.Size = New System.Drawing.Size(106, 20)
        Me.mtxt_abogado_telefono.TabIndex = 3
        '
        'txt_abogado_domicilio
        '
        Me.txt_abogado_domicilio.Location = New System.Drawing.Point(123, 166)
        Me.txt_abogado_domicilio.Name = "txt_abogado_domicilio"
        Me.txt_abogado_domicilio.Size = New System.Drawing.Size(181, 20)
        Me.txt_abogado_domicilio.TabIndex = 4
        '
        'txt_abogado_apellido
        '
        Me.txt_abogado_apellido.Location = New System.Drawing.Point(123, 95)
        Me.txt_abogado_apellido.Name = "txt_abogado_apellido"
        Me.txt_abogado_apellido.Size = New System.Drawing.Size(181, 20)
        Me.txt_abogado_apellido.TabIndex = 2
        '
        'txt_abogado_nombre
        '
        Me.txt_abogado_nombre.Location = New System.Drawing.Point(123, 66)
        Me.txt_abogado_nombre.Name = "txt_abogado_nombre"
        Me.txt_abogado_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_abogado_nombre.TabIndex = 1
        '
        'lbl_abogado_domicilio
        '
        Me.lbl_abogado_domicilio.AutoSize = True
        Me.lbl_abogado_domicilio.Location = New System.Drawing.Point(17, 166)
        Me.lbl_abogado_domicilio.Name = "lbl_abogado_domicilio"
        Me.lbl_abogado_domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_abogado_domicilio.TabIndex = 0
        Me.lbl_abogado_domicilio.Text = "Domicilio"
        '
        'txt_abogado_matricula
        '
        Me.txt_abogado_matricula.Location = New System.Drawing.Point(123, 31)
        Me.txt_abogado_matricula.Name = "txt_abogado_matricula"
        Me.txt_abogado_matricula.Size = New System.Drawing.Size(106, 20)
        Me.txt_abogado_matricula.TabIndex = 0
        '
        'lbl_abogado_apellido
        '
        Me.lbl_abogado_apellido.AutoSize = True
        Me.lbl_abogado_apellido.Location = New System.Drawing.Point(17, 98)
        Me.lbl_abogado_apellido.Name = "lbl_abogado_apellido"
        Me.lbl_abogado_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_abogado_apellido.TabIndex = 0
        Me.lbl_abogado_apellido.Text = "Apellido"
        '
        'lbl_abogado_telefono
        '
        Me.lbl_abogado_telefono.AutoSize = True
        Me.lbl_abogado_telefono.Location = New System.Drawing.Point(17, 131)
        Me.lbl_abogado_telefono.Name = "lbl_abogado_telefono"
        Me.lbl_abogado_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_abogado_telefono.TabIndex = 0
        Me.lbl_abogado_telefono.Text = "Telefono"
        '
        'lbl_abogado_nombre
        '
        Me.lbl_abogado_nombre.AutoSize = True
        Me.lbl_abogado_nombre.Location = New System.Drawing.Point(17, 66)
        Me.lbl_abogado_nombre.Name = "lbl_abogado_nombre"
        Me.lbl_abogado_nombre.Size = New System.Drawing.Size(49, 13)
        Me.lbl_abogado_nombre.TabIndex = 0
        Me.lbl_abogado_nombre.Text = "Nombres"
        '
        'lbl_abogado_matricula
        '
        Me.lbl_abogado_matricula.AutoSize = True
        Me.lbl_abogado_matricula.Location = New System.Drawing.Point(17, 31)
        Me.lbl_abogado_matricula.Name = "lbl_abogado_matricula"
        Me.lbl_abogado_matricula.Size = New System.Drawing.Size(50, 13)
        Me.lbl_abogado_matricula.TabIndex = 0
        Me.lbl_abogado_matricula.Text = "Matricula"
        '
        'tab_control_solicitante
        '
        Me.tab_control_solicitante.Controls.Add(Me.cmb_solicitante_tipodoc)
        Me.tab_control_solicitante.Controls.Add(Me.mtxt_solicitante_nrodoc)
        Me.tab_control_solicitante.Controls.Add(Me.mtxt_solicitante_fechaNacimiento)
        Me.tab_control_solicitante.Controls.Add(Me.mtxt_solicitante_telefono)
        Me.tab_control_solicitante.Controls.Add(Me.txt_solicitante_domicilio)
        Me.tab_control_solicitante.Controls.Add(Me.txt_solicitante_apellido)
        Me.tab_control_solicitante.Controls.Add(Me.txt_solicitante_nombre)
        Me.tab_control_solicitante.Controls.Add(Me.lbl_solicitante_fechanac)
        Me.tab_control_solicitante.Controls.Add(Me.lbl_solicitante_domicilio)
        Me.tab_control_solicitante.Controls.Add(Me.lbl_solicitante_apellido)
        Me.tab_control_solicitante.Controls.Add(Me.lbl_solicitante_telefono)
        Me.tab_control_solicitante.Controls.Add(Me.lbl_solicitante_nombre)
        Me.tab_control_solicitante.Controls.Add(Me.lbl_solicitante_tipodoc)
        Me.tab_control_solicitante.Controls.Add(Me.lbl_solicitante_nrodoc)
        Me.tab_control_solicitante.Location = New System.Drawing.Point(4, 22)
        Me.tab_control_solicitante.Name = "tab_control_solicitante"
        Me.tab_control_solicitante.Size = New System.Drawing.Size(420, 618)
        Me.tab_control_solicitante.TabIndex = 2
        Me.tab_control_solicitante.Text = "Solicitante"
        Me.tab_control_solicitante.UseVisualStyleBackColor = True
        '
        'cmb_solicitante_tipodoc
        '
        Me.cmb_solicitante_tipodoc.DataSource = Me.TipoDocumentoBindingSource
        Me.cmb_solicitante_tipodoc.DisplayMember = "nombre"
        Me.cmb_solicitante_tipodoc.FormattingEnabled = True
        Me.cmb_solicitante_tipodoc.Location = New System.Drawing.Point(156, 65)
        Me.cmb_solicitante_tipodoc.Name = "cmb_solicitante_tipodoc"
        Me.cmb_solicitante_tipodoc.Size = New System.Drawing.Size(181, 21)
        Me.cmb_solicitante_tipodoc.TabIndex = 1
        Me.cmb_solicitante_tipodoc.ValueMember = "nombre"
        '
        'TipoDocumentoBindingSource
        '
        Me.TipoDocumentoBindingSource.DataMember = "tipo_Documento"
        Me.TipoDocumentoBindingSource.DataSource = Me.PAV1DataSet
        '
        'PAV1DataSet
        '
        Me.PAV1DataSet.DataSetName = "PAV1DataSet"
        Me.PAV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mtxt_solicitante_nrodoc
        '
        Me.mtxt_solicitante_nrodoc.Location = New System.Drawing.Point(156, 36)
        Me.mtxt_solicitante_nrodoc.Mask = "00000000"
        Me.mtxt_solicitante_nrodoc.Name = "mtxt_solicitante_nrodoc"
        Me.mtxt_solicitante_nrodoc.Size = New System.Drawing.Size(100, 20)
        Me.mtxt_solicitante_nrodoc.TabIndex = 0
        '
        'mtxt_solicitante_fechaNacimiento
        '
        Me.mtxt_solicitante_fechaNacimiento.Location = New System.Drawing.Point(156, 233)
        Me.mtxt_solicitante_fechaNacimiento.Mask = "00-00-0000"
        Me.mtxt_solicitante_fechaNacimiento.Name = "mtxt_solicitante_fechaNacimiento"
        Me.mtxt_solicitante_fechaNacimiento.Size = New System.Drawing.Size(106, 20)
        Me.mtxt_solicitante_fechaNacimiento.TabIndex = 6
        '
        'mtxt_solicitante_telefono
        '
        Me.mtxt_solicitante_telefono.Location = New System.Drawing.Point(156, 166)
        Me.mtxt_solicitante_telefono.Mask = "(000) 000-000-000"
        Me.mtxt_solicitante_telefono.Name = "mtxt_solicitante_telefono"
        Me.mtxt_solicitante_telefono.Size = New System.Drawing.Size(106, 20)
        Me.mtxt_solicitante_telefono.TabIndex = 4
        '
        'txt_solicitante_domicilio
        '
        Me.txt_solicitante_domicilio.Location = New System.Drawing.Point(156, 201)
        Me.txt_solicitante_domicilio.Name = "txt_solicitante_domicilio"
        Me.txt_solicitante_domicilio.Size = New System.Drawing.Size(181, 20)
        Me.txt_solicitante_domicilio.TabIndex = 5
        '
        'txt_solicitante_apellido
        '
        Me.txt_solicitante_apellido.Location = New System.Drawing.Point(156, 130)
        Me.txt_solicitante_apellido.Name = "txt_solicitante_apellido"
        Me.txt_solicitante_apellido.Size = New System.Drawing.Size(181, 20)
        Me.txt_solicitante_apellido.TabIndex = 3
        '
        'txt_solicitante_nombre
        '
        Me.txt_solicitante_nombre.Location = New System.Drawing.Point(156, 101)
        Me.txt_solicitante_nombre.Name = "txt_solicitante_nombre"
        Me.txt_solicitante_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_solicitante_nombre.TabIndex = 2
        '
        'lbl_solicitante_fechanac
        '
        Me.lbl_solicitante_fechanac.AutoSize = True
        Me.lbl_solicitante_fechanac.Location = New System.Drawing.Point(18, 236)
        Me.lbl_solicitante_fechanac.Name = "lbl_solicitante_fechanac"
        Me.lbl_solicitante_fechanac.Size = New System.Drawing.Size(108, 13)
        Me.lbl_solicitante_fechanac.TabIndex = 8
        Me.lbl_solicitante_fechanac.Text = "Fecha de Nacimiento"
        '
        'lbl_solicitante_domicilio
        '
        Me.lbl_solicitante_domicilio.AutoSize = True
        Me.lbl_solicitante_domicilio.Location = New System.Drawing.Point(18, 201)
        Me.lbl_solicitante_domicilio.Name = "lbl_solicitante_domicilio"
        Me.lbl_solicitante_domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_solicitante_domicilio.TabIndex = 8
        Me.lbl_solicitante_domicilio.Text = "Domicilio"
        '
        'lbl_solicitante_apellido
        '
        Me.lbl_solicitante_apellido.AutoSize = True
        Me.lbl_solicitante_apellido.Location = New System.Drawing.Point(18, 133)
        Me.lbl_solicitante_apellido.Name = "lbl_solicitante_apellido"
        Me.lbl_solicitante_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_solicitante_apellido.TabIndex = 4
        Me.lbl_solicitante_apellido.Text = "Apellido"
        '
        'lbl_solicitante_telefono
        '
        Me.lbl_solicitante_telefono.AutoSize = True
        Me.lbl_solicitante_telefono.Location = New System.Drawing.Point(18, 166)
        Me.lbl_solicitante_telefono.Name = "lbl_solicitante_telefono"
        Me.lbl_solicitante_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_solicitante_telefono.TabIndex = 7
        Me.lbl_solicitante_telefono.Text = "Telefono"
        '
        'lbl_solicitante_nombre
        '
        Me.lbl_solicitante_nombre.AutoSize = True
        Me.lbl_solicitante_nombre.Location = New System.Drawing.Point(18, 101)
        Me.lbl_solicitante_nombre.Name = "lbl_solicitante_nombre"
        Me.lbl_solicitante_nombre.Size = New System.Drawing.Size(49, 13)
        Me.lbl_solicitante_nombre.TabIndex = 6
        Me.lbl_solicitante_nombre.Text = "Nombres"
        '
        'lbl_solicitante_tipodoc
        '
        Me.lbl_solicitante_tipodoc.AutoSize = True
        Me.lbl_solicitante_tipodoc.Location = New System.Drawing.Point(18, 68)
        Me.lbl_solicitante_tipodoc.Name = "lbl_solicitante_tipodoc"
        Me.lbl_solicitante_tipodoc.Size = New System.Drawing.Size(86, 13)
        Me.lbl_solicitante_tipodoc.TabIndex = 5
        Me.lbl_solicitante_tipodoc.Text = "Tipo Documento"
        '
        'lbl_solicitante_nrodoc
        '
        Me.lbl_solicitante_nrodoc.AutoSize = True
        Me.lbl_solicitante_nrodoc.Location = New System.Drawing.Point(18, 36)
        Me.lbl_solicitante_nrodoc.Name = "lbl_solicitante_nrodoc"
        Me.lbl_solicitante_nrodoc.Size = New System.Drawing.Size(117, 13)
        Me.lbl_solicitante_nrodoc.TabIndex = 5
        Me.lbl_solicitante_nrodoc.Text = "Numero de Documento"
        '
        'tab_control_empleado
        '
        Me.tab_control_empleado.Controls.Add(Me.btn_empleado_nuevoCargo)
        Me.tab_control_empleado.Controls.Add(Me.txt_empleado_fecha)
        Me.tab_control_empleado.Controls.Add(Me.lbl_empleado_cargo)
        Me.tab_control_empleado.Controls.Add(Me.cmb_empleado_cargo)
        Me.tab_control_empleado.Controls.Add(Me.lbl_empleado_legSup)
        Me.tab_control_empleado.Controls.Add(Me.txt_empleado_legSup)
        Me.tab_control_empleado.Controls.Add(Me.lbl_empleado_fecha)
        Me.tab_control_empleado.Controls.Add(Me.lbl_empleado_legajo)
        Me.tab_control_empleado.Controls.Add(Me.lbl_empleado_ape)
        Me.tab_control_empleado.Controls.Add(Me.lbl_empleado_nombre)
        Me.tab_control_empleado.Controls.Add(Me.txt_empleado_ape)
        Me.tab_control_empleado.Controls.Add(Me.txt_empleado_legajo)
        Me.tab_control_empleado.Controls.Add(Me.txt_empleado_nombre)
        Me.tab_control_empleado.Location = New System.Drawing.Point(4, 22)
        Me.tab_control_empleado.Name = "tab_control_empleado"
        Me.tab_control_empleado.Size = New System.Drawing.Size(420, 618)
        Me.tab_control_empleado.TabIndex = 3
        Me.tab_control_empleado.Text = "Empleado"
        Me.tab_control_empleado.UseVisualStyleBackColor = True
        '
        'btn_empleado_nuevoCargo
        '
        Me.btn_empleado_nuevoCargo.Location = New System.Drawing.Point(128, 391)
        Me.btn_empleado_nuevoCargo.Name = "btn_empleado_nuevoCargo"
        Me.btn_empleado_nuevoCargo.Size = New System.Drawing.Size(143, 63)
        Me.btn_empleado_nuevoCargo.TabIndex = 6
        Me.btn_empleado_nuevoCargo.Text = "Agregar nuevo cargo"
        Me.btn_empleado_nuevoCargo.UseVisualStyleBackColor = True
        '
        'txt_empleado_fecha
        '
        Me.txt_empleado_fecha.Enabled = False
        Me.txt_empleado_fecha.Location = New System.Drawing.Point(90, 153)
        Me.txt_empleado_fecha.Name = "txt_empleado_fecha"
        Me.txt_empleado_fecha.Size = New System.Drawing.Size(65, 20)
        Me.txt_empleado_fecha.TabIndex = 3
        '
        'lbl_empleado_cargo
        '
        Me.lbl_empleado_cargo.AutoSize = True
        Me.lbl_empleado_cargo.Location = New System.Drawing.Point(17, 229)
        Me.lbl_empleado_cargo.Name = "lbl_empleado_cargo"
        Me.lbl_empleado_cargo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_empleado_cargo.TabIndex = 12
        Me.lbl_empleado_cargo.Text = "Cargo"
        '
        'cmb_empleado_cargo
        '
        Me.cmb_empleado_cargo.DataSource = Me.CargoBindingSource
        Me.cmb_empleado_cargo.DisplayMember = "nombre"
        Me.cmb_empleado_cargo.FormattingEnabled = True
        Me.cmb_empleado_cargo.Location = New System.Drawing.Point(90, 221)
        Me.cmb_empleado_cargo.Name = "cmb_empleado_cargo"
        Me.cmb_empleado_cargo.Size = New System.Drawing.Size(181, 21)
        Me.cmb_empleado_cargo.TabIndex = 5
        Me.cmb_empleado_cargo.ValueMember = "idCargo"
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.PAV1DataSet
        '
        'lbl_empleado_legSup
        '
        Me.lbl_empleado_legSup.AutoSize = True
        Me.lbl_empleado_legSup.Location = New System.Drawing.Point(17, 193)
        Me.lbl_empleado_legSup.Name = "lbl_empleado_legSup"
        Me.lbl_empleado_legSup.Size = New System.Drawing.Size(46, 13)
        Me.lbl_empleado_legSup.TabIndex = 10
        Me.lbl_empleado_legSup.Text = "Superior"
        '
        'txt_empleado_legSup
        '
        Me.txt_empleado_legSup.Location = New System.Drawing.Point(90, 186)
        Me.txt_empleado_legSup.Name = "txt_empleado_legSup"
        Me.txt_empleado_legSup.Size = New System.Drawing.Size(65, 20)
        Me.txt_empleado_legSup.TabIndex = 4
        '
        'lbl_empleado_fecha
        '
        Me.lbl_empleado_fecha.AutoSize = True
        Me.lbl_empleado_fecha.Location = New System.Drawing.Point(17, 156)
        Me.lbl_empleado_fecha.Name = "lbl_empleado_fecha"
        Me.lbl_empleado_fecha.Size = New System.Drawing.Size(58, 13)
        Me.lbl_empleado_fecha.TabIndex = 8
        Me.lbl_empleado_fecha.Text = "Fecha Alta"
        '
        'lbl_empleado_legajo
        '
        Me.lbl_empleado_legajo.AutoSize = True
        Me.lbl_empleado_legajo.Location = New System.Drawing.Point(17, 40)
        Me.lbl_empleado_legajo.Name = "lbl_empleado_legajo"
        Me.lbl_empleado_legajo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_empleado_legajo.TabIndex = 5
        Me.lbl_empleado_legajo.Text = "Legajo"
        '
        'lbl_empleado_ape
        '
        Me.lbl_empleado_ape.AutoSize = True
        Me.lbl_empleado_ape.Location = New System.Drawing.Point(17, 113)
        Me.lbl_empleado_ape.Name = "lbl_empleado_ape"
        Me.lbl_empleado_ape.Size = New System.Drawing.Size(44, 13)
        Me.lbl_empleado_ape.TabIndex = 4
        Me.lbl_empleado_ape.Text = "Apellido"
        '
        'lbl_empleado_nombre
        '
        Me.lbl_empleado_nombre.AutoSize = True
        Me.lbl_empleado_nombre.Location = New System.Drawing.Point(17, 77)
        Me.lbl_empleado_nombre.Name = "lbl_empleado_nombre"
        Me.lbl_empleado_nombre.Size = New System.Drawing.Size(49, 13)
        Me.lbl_empleado_nombre.TabIndex = 3
        Me.lbl_empleado_nombre.Text = "Nombres"
        '
        'txt_empleado_ape
        '
        Me.txt_empleado_ape.Location = New System.Drawing.Point(90, 110)
        Me.txt_empleado_ape.Name = "txt_empleado_ape"
        Me.txt_empleado_ape.Size = New System.Drawing.Size(144, 20)
        Me.txt_empleado_ape.TabIndex = 2
        '
        'txt_empleado_legajo
        '
        Me.txt_empleado_legajo.Location = New System.Drawing.Point(90, 33)
        Me.txt_empleado_legajo.Name = "txt_empleado_legajo"
        Me.txt_empleado_legajo.Size = New System.Drawing.Size(65, 20)
        Me.txt_empleado_legajo.TabIndex = 0
        '
        'txt_empleado_nombre
        '
        Me.txt_empleado_nombre.Location = New System.Drawing.Point(90, 70)
        Me.txt_empleado_nombre.Name = "txt_empleado_nombre"
        Me.txt_empleado_nombre.Size = New System.Drawing.Size(144, 20)
        Me.txt_empleado_nombre.TabIndex = 1
        '
        'tab_control_credito
        '
        Me.tab_control_credito.Controls.Add(Me.cmb_creditos_estadoCredito)
        Me.tab_control_credito.Controls.Add(Me.lbl_creditos_estadoCredito)
        Me.tab_control_credito.Controls.Add(Me.txt_creditos_idObjeto)
        Me.tab_control_credito.Controls.Add(Me.txt_creditos_objeto)
        Me.tab_control_credito.Controls.Add(Me.lbl_creditos_objeto)
        Me.tab_control_credito.Controls.Add(Me.mtxt_creditos_fAprobacion)
        Me.tab_control_credito.Controls.Add(Me.txt_creditos_legajo)
        Me.tab_control_credito.Controls.Add(Me.lbl_creditos_legajo)
        Me.tab_control_credito.Controls.Add(Me.txt_creditos_idSolicitante)
        Me.tab_control_credito.Controls.Add(Me.lbl_creditos_idSolicitante)
        Me.tab_control_credito.Controls.Add(Me.lbl_creditos_fAprobacion)
        Me.tab_control_credito.Controls.Add(Me.txt_creditos_fSolicitud)
        Me.tab_control_credito.Controls.Add(Me.lbl_creditos_fSolicitud)
        Me.tab_control_credito.Controls.Add(Me.txt_creditos_monto)
        Me.tab_control_credito.Controls.Add(Me.lbl_creditos_monto)
        Me.tab_control_credito.Location = New System.Drawing.Point(4, 22)
        Me.tab_control_credito.Name = "tab_control_credito"
        Me.tab_control_credito.Size = New System.Drawing.Size(420, 618)
        Me.tab_control_credito.TabIndex = 4
        Me.tab_control_credito.Text = "Creditos"
        Me.tab_control_credito.UseVisualStyleBackColor = True
        '
        'cmb_creditos_estadoCredito
        '
        Me.cmb_creditos_estadoCredito.FormattingEnabled = True
        Me.cmb_creditos_estadoCredito.Location = New System.Drawing.Point(194, 210)
        Me.cmb_creditos_estadoCredito.Name = "cmb_creditos_estadoCredito"
        Me.cmb_creditos_estadoCredito.Size = New System.Drawing.Size(121, 21)
        Me.cmb_creditos_estadoCredito.TabIndex = 5
        '
        'lbl_creditos_estadoCredito
        '
        Me.lbl_creditos_estadoCredito.AutoSize = True
        Me.lbl_creditos_estadoCredito.Location = New System.Drawing.Point(36, 213)
        Me.lbl_creditos_estadoCredito.Name = "lbl_creditos_estadoCredito"
        Me.lbl_creditos_estadoCredito.Size = New System.Drawing.Size(93, 13)
        Me.lbl_creditos_estadoCredito.TabIndex = 9
        Me.lbl_creditos_estadoCredito.Text = "Estado del Credito"
        '
        'txt_creditos_idObjeto
        '
        Me.txt_creditos_idObjeto.Location = New System.Drawing.Point(129, 242)
        Me.txt_creditos_idObjeto.Name = "txt_creditos_idObjeto"
        Me.txt_creditos_idObjeto.Size = New System.Drawing.Size(45, 20)
        Me.txt_creditos_idObjeto.TabIndex = 6
        Me.txt_creditos_idObjeto.Visible = False
        '
        'txt_creditos_objeto
        '
        Me.txt_creditos_objeto.Location = New System.Drawing.Point(194, 242)
        Me.txt_creditos_objeto.Name = "txt_creditos_objeto"
        Me.txt_creditos_objeto.Size = New System.Drawing.Size(181, 20)
        Me.txt_creditos_objeto.TabIndex = 6
        '
        'lbl_creditos_objeto
        '
        Me.lbl_creditos_objeto.AutoSize = True
        Me.lbl_creditos_objeto.Location = New System.Drawing.Point(36, 245)
        Me.lbl_creditos_objeto.Name = "lbl_creditos_objeto"
        Me.lbl_creditos_objeto.Size = New System.Drawing.Size(38, 13)
        Me.lbl_creditos_objeto.TabIndex = 7
        Me.lbl_creditos_objeto.Text = "Objeto"
        '
        'mtxt_creditos_fAprobacion
        '
        Me.mtxt_creditos_fAprobacion.Location = New System.Drawing.Point(194, 108)
        Me.mtxt_creditos_fAprobacion.Mask = "00-00-0000"
        Me.mtxt_creditos_fAprobacion.Name = "mtxt_creditos_fAprobacion"
        Me.mtxt_creditos_fAprobacion.Size = New System.Drawing.Size(100, 20)
        Me.mtxt_creditos_fAprobacion.TabIndex = 2
        '
        'txt_creditos_legajo
        '
        Me.txt_creditos_legajo.Location = New System.Drawing.Point(194, 176)
        Me.txt_creditos_legajo.Name = "txt_creditos_legajo"
        Me.txt_creditos_legajo.Size = New System.Drawing.Size(100, 20)
        Me.txt_creditos_legajo.TabIndex = 4
        '
        'lbl_creditos_legajo
        '
        Me.lbl_creditos_legajo.AutoSize = True
        Me.lbl_creditos_legajo.Location = New System.Drawing.Point(33, 183)
        Me.lbl_creditos_legajo.Name = "lbl_creditos_legajo"
        Me.lbl_creditos_legajo.Size = New System.Drawing.Size(104, 13)
        Me.lbl_creditos_legajo.TabIndex = 0
        Me.lbl_creditos_legajo.Text = "Legajo de Empleado"
        '
        'txt_creditos_idSolicitante
        '
        Me.txt_creditos_idSolicitante.Location = New System.Drawing.Point(194, 140)
        Me.txt_creditos_idSolicitante.Name = "txt_creditos_idSolicitante"
        Me.txt_creditos_idSolicitante.Size = New System.Drawing.Size(100, 20)
        Me.txt_creditos_idSolicitante.TabIndex = 3
        '
        'lbl_creditos_idSolicitante
        '
        Me.lbl_creditos_idSolicitante.AutoSize = True
        Me.lbl_creditos_idSolicitante.Location = New System.Drawing.Point(33, 147)
        Me.lbl_creditos_idSolicitante.Name = "lbl_creditos_idSolicitante"
        Me.lbl_creditos_idSolicitante.Size = New System.Drawing.Size(107, 13)
        Me.lbl_creditos_idSolicitante.TabIndex = 0
        Me.lbl_creditos_idSolicitante.Text = "Codigo de Solicitante"
        '
        'lbl_creditos_fAprobacion
        '
        Me.lbl_creditos_fAprobacion.AutoSize = True
        Me.lbl_creditos_fAprobacion.Location = New System.Drawing.Point(33, 111)
        Me.lbl_creditos_fAprobacion.Name = "lbl_creditos_fAprobacion"
        Me.lbl_creditos_fAprobacion.Size = New System.Drawing.Size(109, 13)
        Me.lbl_creditos_fAprobacion.TabIndex = 0
        Me.lbl_creditos_fAprobacion.Text = "Fecha de Aprobacion"
        '
        'txt_creditos_fSolicitud
        '
        Me.txt_creditos_fSolicitud.Location = New System.Drawing.Point(194, 73)
        Me.txt_creditos_fSolicitud.Name = "txt_creditos_fSolicitud"
        Me.txt_creditos_fSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.txt_creditos_fSolicitud.TabIndex = 1
        '
        'lbl_creditos_fSolicitud
        '
        Me.lbl_creditos_fSolicitud.AutoSize = True
        Me.lbl_creditos_fSolicitud.Location = New System.Drawing.Point(33, 76)
        Me.lbl_creditos_fSolicitud.Name = "lbl_creditos_fSolicitud"
        Me.lbl_creditos_fSolicitud.Size = New System.Drawing.Size(95, 13)
        Me.lbl_creditos_fSolicitud.TabIndex = 0
        Me.lbl_creditos_fSolicitud.Text = "Fecha de Solicitud"
        '
        'txt_creditos_monto
        '
        Me.txt_creditos_monto.Location = New System.Drawing.Point(194, 33)
        Me.txt_creditos_monto.Name = "txt_creditos_monto"
        Me.txt_creditos_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_creditos_monto.TabIndex = 0
        '
        'lbl_creditos_monto
        '
        Me.lbl_creditos_monto.AutoSize = True
        Me.lbl_creditos_monto.Location = New System.Drawing.Point(33, 40)
        Me.lbl_creditos_monto.Name = "lbl_creditos_monto"
        Me.lbl_creditos_monto.Size = New System.Drawing.Size(37, 13)
        Me.lbl_creditos_monto.TabIndex = 0
        Me.lbl_creditos_monto.Text = "Monto"
        '
        'tab_control_expediente
        '
        Me.tab_control_expediente.Controls.Add(Me.txt_expediente_matAbSol)
        Me.tab_control_expediente.Controls.Add(Me.txt_expediente_observacion)
        Me.tab_control_expediente.Controls.Add(Me.txt_expediente_matAbCre)
        Me.tab_control_expediente.Controls.Add(Me.txt_expediente_fechaInicio)
        Me.tab_control_expediente.Controls.Add(Me.txt_expediente_codCred)
        Me.tab_control_expediente.Controls.Add(Me.txt_expediente_numeroExp)
        Me.tab_control_expediente.Controls.Add(Me.lbl_expediente_matAbSol)
        Me.tab_control_expediente.Controls.Add(Me.lbl_expediente_matAbCre)
        Me.tab_control_expediente.Controls.Add(Me.lbl_expediente_observacion)
        Me.tab_control_expediente.Controls.Add(Me.lbl_expediente_fechaInicio)
        Me.tab_control_expediente.Controls.Add(Me.lbl_expediente_codCred)
        Me.tab_control_expediente.Controls.Add(Me.lbl_expediente_numeroExp)
        Me.tab_control_expediente.Location = New System.Drawing.Point(4, 22)
        Me.tab_control_expediente.Name = "tab_control_expediente"
        Me.tab_control_expediente.Size = New System.Drawing.Size(420, 618)
        Me.tab_control_expediente.TabIndex = 5
        Me.tab_control_expediente.Text = "Expediente"
        Me.tab_control_expediente.UseVisualStyleBackColor = True
        '
        'txt_expediente_matAbSol
        '
        Me.txt_expediente_matAbSol.Location = New System.Drawing.Point(221, 184)
        Me.txt_expediente_matAbSol.Name = "txt_expediente_matAbSol"
        Me.txt_expediente_matAbSol.Size = New System.Drawing.Size(100, 20)
        Me.txt_expediente_matAbSol.TabIndex = 2
        '
        'txt_expediente_observacion
        '
        Me.txt_expediente_observacion.Location = New System.Drawing.Point(221, 218)
        Me.txt_expediente_observacion.Name = "txt_expediente_observacion"
        Me.txt_expediente_observacion.Size = New System.Drawing.Size(186, 20)
        Me.txt_expediente_observacion.TabIndex = 2
        '
        'txt_expediente_matAbCre
        '
        Me.txt_expediente_matAbCre.Location = New System.Drawing.Point(221, 149)
        Me.txt_expediente_matAbCre.Name = "txt_expediente_matAbCre"
        Me.txt_expediente_matAbCre.Size = New System.Drawing.Size(100, 20)
        Me.txt_expediente_matAbCre.TabIndex = 2
        '
        'txt_expediente_fechaInicio
        '
        Me.txt_expediente_fechaInicio.Location = New System.Drawing.Point(221, 110)
        Me.txt_expediente_fechaInicio.Name = "txt_expediente_fechaInicio"
        Me.txt_expediente_fechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_expediente_fechaInicio.TabIndex = 2
        '
        'txt_expediente_codCred
        '
        Me.txt_expediente_codCred.Location = New System.Drawing.Point(221, 70)
        Me.txt_expediente_codCred.Name = "txt_expediente_codCred"
        Me.txt_expediente_codCred.Size = New System.Drawing.Size(100, 20)
        Me.txt_expediente_codCred.TabIndex = 2
        '
        'txt_expediente_numeroExp
        '
        Me.txt_expediente_numeroExp.Location = New System.Drawing.Point(221, 35)
        Me.txt_expediente_numeroExp.Name = "txt_expediente_numeroExp"
        Me.txt_expediente_numeroExp.Size = New System.Drawing.Size(100, 20)
        Me.txt_expediente_numeroExp.TabIndex = 2
        '
        'lbl_expediente_matAbSol
        '
        Me.lbl_expediente_matAbSol.AutoSize = True
        Me.lbl_expediente_matAbSol.Location = New System.Drawing.Point(31, 187)
        Me.lbl_expediente_matAbSol.Name = "lbl_expediente_matAbSol"
        Me.lbl_expediente_matAbSol.Size = New System.Drawing.Size(162, 13)
        Me.lbl_expediente_matAbSol.TabIndex = 1
        Me.lbl_expediente_matAbSol.Text = "Matricula abogado de Solicitante"
        '
        'lbl_expediente_matAbCre
        '
        Me.lbl_expediente_matAbCre.AutoSize = True
        Me.lbl_expediente_matAbCre.Location = New System.Drawing.Point(31, 152)
        Me.lbl_expediente_matAbCre.Name = "lbl_expediente_matAbCre"
        Me.lbl_expediente_matAbCre.Size = New System.Drawing.Size(137, 13)
        Me.lbl_expediente_matAbCre.TabIndex = 1
        Me.lbl_expediente_matAbCre.Text = "Matricula abogado CreCOR"
        '
        'lbl_expediente_observacion
        '
        Me.lbl_expediente_observacion.AutoSize = True
        Me.lbl_expediente_observacion.Location = New System.Drawing.Point(31, 221)
        Me.lbl_expediente_observacion.Name = "lbl_expediente_observacion"
        Me.lbl_expediente_observacion.Size = New System.Drawing.Size(67, 13)
        Me.lbl_expediente_observacion.TabIndex = 1
        Me.lbl_expediente_observacion.Text = "Observacion"
        '
        'lbl_expediente_fechaInicio
        '
        Me.lbl_expediente_fechaInicio.AutoSize = True
        Me.lbl_expediente_fechaInicio.Location = New System.Drawing.Point(31, 113)
        Me.lbl_expediente_fechaInicio.Name = "lbl_expediente_fechaInicio"
        Me.lbl_expediente_fechaInicio.Size = New System.Drawing.Size(79, 13)
        Me.lbl_expediente_fechaInicio.TabIndex = 1
        Me.lbl_expediente_fechaInicio.Text = "Fecha de inicio"
        '
        'lbl_expediente_codCred
        '
        Me.lbl_expediente_codCred.AutoSize = True
        Me.lbl_expediente_codCred.Location = New System.Drawing.Point(31, 73)
        Me.lbl_expediente_codCred.Name = "lbl_expediente_codCred"
        Me.lbl_expediente_codCred.Size = New System.Drawing.Size(91, 13)
        Me.lbl_expediente_codCred.TabIndex = 1
        Me.lbl_expediente_codCred.Text = "Codigo de Credito"
        '
        'lbl_expediente_numeroExp
        '
        Me.lbl_expediente_numeroExp.AutoSize = True
        Me.lbl_expediente_numeroExp.Location = New System.Drawing.Point(31, 38)
        Me.lbl_expediente_numeroExp.Name = "lbl_expediente_numeroExp"
        Me.lbl_expediente_numeroExp.Size = New System.Drawing.Size(115, 13)
        Me.lbl_expediente_numeroExp.TabIndex = 1
        Me.lbl_expediente_numeroExp.Text = "Numero de Expediente"
        '
        'btn_salir
        '
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.Location = New System.Drawing.Point(537, 562)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(58, 57)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(356, 562)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(58, 57)
        Me.btn_modificar.TabIndex = 2
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(270, 562)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(58, 57)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(181, 562)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(58, 57)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(446, 562)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(58, 57)
        Me.btn_borrar.TabIndex = 3
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(6, 11)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(794, 531)
        Me.grilla.TabIndex = 5
        '
        'Tipo_DocumentoTableAdapter
        '
        Me.Tipo_DocumentoTableAdapter.ClearBeforeFill = True
        '
        'grp_controles
        '
        Me.grp_controles.Controls.Add(Me.grilla)
        Me.grp_controles.Controls.Add(Me.btn_salir)
        Me.grp_controles.Controls.Add(Me.btn_borrar)
        Me.grp_controles.Controls.Add(Me.btn_modificar)
        Me.grp_controles.Controls.Add(Me.btn_guardar)
        Me.grp_controles.Controls.Add(Me.btn_buscar)
        Me.grp_controles.Location = New System.Drawing.Point(447, 13)
        Me.grp_controles.Name = "grp_controles"
        Me.grp_controles.Size = New System.Drawing.Size(805, 625)
        Me.grp_controles.TabIndex = 8
        Me.grp_controles.TabStop = False
        Me.grp_controles.Visible = False
        '
        'tab_menu
        '
        Me.tab_menu.Controls.Add(Me.tab_menu_inicio)
        Me.tab_menu.Controls.Add(Me.tab_menu_abm)
        Me.tab_menu.Location = New System.Drawing.Point(2, 2)
        Me.tab_menu.Name = "tab_menu"
        Me.tab_menu.SelectedIndex = 0
        Me.tab_menu.Size = New System.Drawing.Size(439, 679)
        Me.tab_menu.TabIndex = 9
        '
        'tab_menu_inicio
        '
        Me.tab_menu_inicio.Controls.Add(Me.Label4)
        Me.tab_menu_inicio.Controls.Add(Me.Label3)
        Me.tab_menu_inicio.Controls.Add(Me.Label2)
        Me.tab_menu_inicio.Controls.Add(Me.Label1)
        Me.tab_menu_inicio.Location = New System.Drawing.Point(4, 22)
        Me.tab_menu_inicio.Name = "tab_menu_inicio"
        Me.tab_menu_inicio.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_menu_inicio.Size = New System.Drawing.Size(431, 653)
        Me.tab_menu_inicio.TabIndex = 0
        Me.tab_menu_inicio.Text = "Inicio"
        Me.tab_menu_inicio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label4.Location = New System.Drawing.Point(171, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "IMAGENES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(50, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 39)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Futuros procesos y estadisticas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proyecto PAV1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(125, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 125)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Creditos CreCOR"
        '
        'tab_menu_abm
        '
        Me.tab_menu_abm.Controls.Add(Me.tab_control)
        Me.tab_menu_abm.Location = New System.Drawing.Point(4, 22)
        Me.tab_menu_abm.Name = "tab_menu_abm"
        Me.tab_menu_abm.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_menu_abm.Size = New System.Drawing.Size(431, 653)
        Me.tab_menu_abm.TabIndex = 1
        Me.tab_menu_abm.Text = "Carga de Datos"
        Me.tab_menu_abm.UseVisualStyleBackColor = True
        '
        'TipoDocumentoBindingSource1
        '
        Me.TipoDocumentoBindingSource1.DataMember = "tipo_Documento"
        Me.TipoDocumentoBindingSource1.DataSource = Me.PAV1DataSet
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'tab_control_garantia
        '
        Me.tab_control_garantia.Controls.Add(Me.btn_garantia_documentacion)
        Me.tab_control_garantia.Controls.Add(Me.txt_garantia_monto)
        Me.tab_control_garantia.Controls.Add(Me.txt_garantia_descripcion)
        Me.tab_control_garantia.Controls.Add(Me.txt_garantia_idCredito)
        Me.tab_control_garantia.Controls.Add(Me.lbl_garantia_monto)
        Me.tab_control_garantia.Controls.Add(Me.lbl_garantia_descripcion)
        Me.tab_control_garantia.Controls.Add(Me.lbl_garantia_codCredito)
        Me.tab_control_garantia.Location = New System.Drawing.Point(4, 22)
        Me.tab_control_garantia.Name = "tab_control_garantia"
        Me.tab_control_garantia.Size = New System.Drawing.Size(420, 618)
        Me.tab_control_garantia.TabIndex = 6
        Me.tab_control_garantia.Text = "Garantias"
        Me.tab_control_garantia.UseVisualStyleBackColor = True
        '
        'lbl_garantia_codCredito
        '
        Me.lbl_garantia_codCredito.AutoSize = True
        Me.lbl_garantia_codCredito.Location = New System.Drawing.Point(31, 38)
        Me.lbl_garantia_codCredito.Name = "lbl_garantia_codCredito"
        Me.lbl_garantia_codCredito.Size = New System.Drawing.Size(91, 13)
        Me.lbl_garantia_codCredito.TabIndex = 0
        Me.lbl_garantia_codCredito.Text = "Codigo de Credito"
        '
        'txt_garantia_idCredito
        '
        Me.txt_garantia_idCredito.Location = New System.Drawing.Point(196, 38)
        Me.txt_garantia_idCredito.Name = "txt_garantia_idCredito"
        Me.txt_garantia_idCredito.Size = New System.Drawing.Size(100, 20)
        Me.txt_garantia_idCredito.TabIndex = 1
        '
        'lbl_garantia_descripcion
        '
        Me.lbl_garantia_descripcion.AutoSize = True
        Me.lbl_garantia_descripcion.Location = New System.Drawing.Point(31, 74)
        Me.lbl_garantia_descripcion.Name = "lbl_garantia_descripcion"
        Me.lbl_garantia_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_garantia_descripcion.TabIndex = 0
        Me.lbl_garantia_descripcion.Text = "Descripcion"
        '
        'txt_garantia_descripcion
        '
        Me.txt_garantia_descripcion.Location = New System.Drawing.Point(196, 74)
        Me.txt_garantia_descripcion.Name = "txt_garantia_descripcion"
        Me.txt_garantia_descripcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_garantia_descripcion.TabIndex = 1
        '
        'lbl_garantia_monto
        '
        Me.lbl_garantia_monto.AutoSize = True
        Me.lbl_garantia_monto.Location = New System.Drawing.Point(31, 108)
        Me.lbl_garantia_monto.Name = "lbl_garantia_monto"
        Me.lbl_garantia_monto.Size = New System.Drawing.Size(81, 13)
        Me.lbl_garantia_monto.TabIndex = 0
        Me.lbl_garantia_monto.Text = "Valor Monetario"
        '
        'txt_garantia_monto
        '
        Me.txt_garantia_monto.Location = New System.Drawing.Point(196, 108)
        Me.txt_garantia_monto.Name = "txt_garantia_monto"
        Me.txt_garantia_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_garantia_monto.TabIndex = 1
        '
        'btn_garantia_documentacion
        '
        Me.btn_garantia_documentacion.Location = New System.Drawing.Point(142, 233)
        Me.btn_garantia_documentacion.Name = "btn_garantia_documentacion"
        Me.btn_garantia_documentacion.Size = New System.Drawing.Size(124, 59)
        Me.btn_garantia_documentacion.TabIndex = 2
        Me.btn_garantia_documentacion.Text = "Cargar Documentacion"
        Me.btn_garantia_documentacion.UseVisualStyleBackColor = True
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.grp_controles)
        Me.Controls.Add(Me.tab_menu)
        Me.Name = "frm_Menu"
        Me.Text = "Creditos CreCOR"
        Me.tab_control.ResumeLayout(False)
        Me.tab_control_abogado.ResumeLayout(False)
        Me.tab_control_abogado.PerformLayout()
        Me.tab_control_solicitante.ResumeLayout(False)
        Me.tab_control_solicitante.PerformLayout()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAV1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control_empleado.ResumeLayout(False)
        Me.tab_control_empleado.PerformLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control_credito.ResumeLayout(False)
        Me.tab_control_credito.PerformLayout()
        Me.tab_control_expediente.ResumeLayout(False)
        Me.tab_control_expediente.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_controles.ResumeLayout(False)
        Me.tab_menu.ResumeLayout(False)
        Me.tab_menu_inicio.ResumeLayout(False)
        Me.tab_menu_inicio.PerformLayout()
        Me.tab_menu_abm.ResumeLayout(False)
        CType(Me.TipoDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control_garantia.ResumeLayout(False)
        Me.tab_control_garantia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_control As System.Windows.Forms.TabControl
    Friend WithEvents tab_control_abogado As System.Windows.Forms.TabPage
    Friend WithEvents tab_control_solicitante As System.Windows.Forms.TabPage
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents mtxt_abogado_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_abogado_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_abogado_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_abogado_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_abogado_domicilio As System.Windows.Forms.Label
    Friend WithEvents txt_abogado_matricula As System.Windows.Forms.TextBox
    Friend WithEvents lbl_abogado_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_abogado_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_abogado_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_abogado_matricula As System.Windows.Forms.Label
    Friend WithEvents mtxt_solicitante_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_solicitante_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_solicitante_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_solicitante_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_solicitante_domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_solicitante_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_solicitante_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_solicitante_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_solicitante_nrodoc As System.Windows.Forms.Label
    Friend WithEvents cmb_solicitante_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents mtxt_solicitante_nrodoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_solicitante_tipodoc As System.Windows.Forms.Label
    Friend WithEvents PAV1DataSet As TP_PAV1.PAV1DataSet
    Friend WithEvents TipoDocumentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipo_DocumentoTableAdapter As TP_PAV1.PAV1DataSetTableAdapters.tipo_DocumentoTableAdapter
    Friend WithEvents mtxt_solicitante_fechaNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_solicitante_fechanac As System.Windows.Forms.Label
    Friend WithEvents grp_controles As System.Windows.Forms.GroupBox
    Friend WithEvents tab_menu As System.Windows.Forms.TabControl
    Friend WithEvents tab_menu_inicio As System.Windows.Forms.TabPage
    Friend WithEvents tab_menu_abm As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TipoDocumentoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tab_control_empleado As System.Windows.Forms.TabPage
    Friend WithEvents lbl_empleado_legajo As System.Windows.Forms.Label
    Friend WithEvents lbl_empleado_ape As System.Windows.Forms.Label
    Friend WithEvents lbl_empleado_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_empleado_ape As System.Windows.Forms.TextBox
    Friend WithEvents txt_empleado_legajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_empleado_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_empleado_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_empleado_cargo As System.Windows.Forms.Label
    Friend WithEvents cmb_empleado_cargo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_empleado_legSup As System.Windows.Forms.Label
    Friend WithEvents txt_empleado_legSup As System.Windows.Forms.TextBox
    Friend WithEvents txt_empleado_fecha As System.Windows.Forms.TextBox
    Friend WithEvents CargoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargoTableAdapter As TP_PAV1.PAV1DataSetTableAdapters.CargoTableAdapter
    Friend WithEvents btn_empleado_nuevoCargo As System.Windows.Forms.Button
    Friend WithEvents tab_control_credito As System.Windows.Forms.TabPage
    Friend WithEvents mtxt_creditos_fAprobacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_creditos_legajo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_creditos_legajo As System.Windows.Forms.Label
    Friend WithEvents txt_creditos_idSolicitante As System.Windows.Forms.TextBox
    Friend WithEvents lbl_creditos_idSolicitante As System.Windows.Forms.Label
    Friend WithEvents lbl_creditos_fAprobacion As System.Windows.Forms.Label
    Friend WithEvents txt_creditos_fSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents lbl_creditos_fSolicitud As System.Windows.Forms.Label
    Friend WithEvents txt_creditos_monto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_creditos_monto As System.Windows.Forms.Label
    Friend WithEvents txt_creditos_objeto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_creditos_objeto As System.Windows.Forms.Label
    Friend WithEvents tab_control_expediente As System.Windows.Forms.TabPage
    Friend WithEvents txt_expediente_matAbSol As System.Windows.Forms.TextBox
    Friend WithEvents txt_expediente_observacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_expediente_matAbCre As System.Windows.Forms.TextBox
    Friend WithEvents txt_expediente_fechaInicio As System.Windows.Forms.TextBox
    Friend WithEvents txt_expediente_codCred As System.Windows.Forms.TextBox
    Friend WithEvents txt_expediente_numeroExp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_expediente_matAbSol As System.Windows.Forms.Label
    Friend WithEvents lbl_expediente_matAbCre As System.Windows.Forms.Label
    Friend WithEvents lbl_expediente_observacion As System.Windows.Forms.Label
    Friend WithEvents lbl_expediente_fechaInicio As System.Windows.Forms.Label
    Friend WithEvents lbl_expediente_codCred As System.Windows.Forms.Label
    Friend WithEvents lbl_expediente_numeroExp As System.Windows.Forms.Label
    Friend WithEvents cmb_creditos_estadoCredito As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_creditos_estadoCredito As System.Windows.Forms.Label
    Friend WithEvents txt_creditos_idObjeto As System.Windows.Forms.TextBox
    Friend WithEvents tab_control_garantia As System.Windows.Forms.TabPage
    Friend WithEvents btn_garantia_documentacion As System.Windows.Forms.Button
    Friend WithEvents txt_garantia_monto As System.Windows.Forms.TextBox
    Friend WithEvents txt_garantia_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_garantia_idCredito As System.Windows.Forms.TextBox
    Friend WithEvents lbl_garantia_monto As System.Windows.Forms.Label
    Friend WithEvents lbl_garantia_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_garantia_codCredito As System.Windows.Forms.Label
End Class
