﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CreditosXEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAV1DataSet2 = New TP_PAV1.PAV1DataSet2()
        Me.CreditosXSolicitanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditosXRangoFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditosXRangoMontoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpedientesXAbogadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditosXEmpleadoAgrupadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GananciaXRangoMesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditosXRangoEstadisticaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoXCuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoXCreditoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.btn_credito_cuotas = New System.Windows.Forms.Button()
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
        Me.tab_control_garantia = New System.Windows.Forms.TabPage()
        Me.txt_garantias_ubicacion = New System.Windows.Forms.TextBox()
        Me.lbl_documentacion = New System.Windows.Forms.Label()
        Me.txt_garantias_descripDocum = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion_documentacion = New System.Windows.Forms.Label()
        Me.txt_garantia_monto = New System.Windows.Forms.TextBox()
        Me.lbl_direccion_documentacion = New System.Windows.Forms.Label()
        Me.txt_garantias_idDocumentacion = New System.Windows.Forms.TextBox()
        Me.txt_garantia_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_garantia_idCredito = New System.Windows.Forms.TextBox()
        Me.lbl_garantia_monto = New System.Windows.Forms.Label()
        Me.lbl_garantia_descripcion = New System.Windows.Forms.Label()
        Me.lbl_garantia_codCredito = New System.Windows.Forms.Label()
        Me.tab_control_pago = New System.Windows.Forms.TabPage()
        Me.cmb_pago_estado = New System.Windows.Forms.ComboBox()
        Me.txt_pago_fecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pago_codCred = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.tab_menu_abm = New System.Windows.Forms.TabPage()
        Me.tab_menu_report = New System.Windows.Forms.TabPage()
        Me.tab_report = New System.Windows.Forms.TabControl()
        Me.tab_report_credxemp = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cantxemp_leg = New System.Windows.Forms.TextBox()
        Me.report_credxemp = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btn_cantxemp = New System.Windows.Forms.Button()
        Me.tab_report_credxsol = New System.Windows.Forms.TabPage()
        Me.cmb_credxsol = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cantxsol_doc = New System.Windows.Forms.TextBox()
        Me.btn_cantxsol = New System.Windows.Forms.Button()
        Me.report_credxsol = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tab_report_credxrango = New System.Windows.Forms.TabPage()
        Me.datetime_credxrango_hasta = New System.Windows.Forms.DateTimePicker()
        Me.datetime_credxrango_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_credxrango = New System.Windows.Forms.Button()
        Me.report_credxfecha = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tab_report_credxmonto = New System.Windows.Forms.TabPage()
        Me.txt_credxmonto_hasta = New System.Windows.Forms.TextBox()
        Me.txt_credxmonto_desde = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_credxmonto = New System.Windows.Forms.Button()
        Me.report_credxmonto = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tab_report_expxabg = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_expxabg_leg = New System.Windows.Forms.TextBox()
        Me.btn_expxabg = New System.Windows.Forms.Button()
        Me.report_expxabg = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tab_menu_est = New System.Windows.Forms.TabPage()
        Me.tab_est = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CreditosXEmpleadoAgrupado = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_gxm = New System.Windows.Forms.Button()
        Me.txt_gxmhasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_gxm_desde = New System.Windows.Forms.MaskedTextBox()
        Me.report_gxm = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmb_cantXRango_est = New System.Windows.Forms.ComboBox()
        Me.lbl_año_estadistica1 = New System.Windows.Forms.Label()
        Me.txt_cantXRango_año = New System.Windows.Forms.TextBox()
        Me.btn_cantCredXRang = New System.Windows.Forms.Button()
        Me.CreditosXRangoEstadistica = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.report_estadoC = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.report_estadoCred = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TipoDocumentoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoTableAdapter = New TP_PAV1.PAV1DataSetTableAdapters.CargoTableAdapter()
        CType(Me.CreditosXEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAV1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosXSolicitanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosXRangoFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosXRangoMontoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedientesXAbogadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosXEmpleadoAgrupadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GananciaXRangoMesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosXRangoEstadisticaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoXCuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoXCreditoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control.SuspendLayout()
        Me.tab_control_abogado.SuspendLayout()
        Me.tab_control_solicitante.SuspendLayout()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAV1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control_empleado.SuspendLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control_credito.SuspendLayout()
        Me.tab_control_expediente.SuspendLayout()
        Me.tab_control_garantia.SuspendLayout()
        Me.tab_control_pago.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_controles.SuspendLayout()
        Me.tab_menu.SuspendLayout()
        Me.tab_menu_abm.SuspendLayout()
        Me.tab_menu_report.SuspendLayout()
        Me.tab_report.SuspendLayout()
        Me.tab_report_credxemp.SuspendLayout()
        Me.tab_report_credxsol.SuspendLayout()
        Me.tab_report_credxrango.SuspendLayout()
        Me.tab_report_credxmonto.SuspendLayout()
        Me.tab_report_expxabg.SuspendLayout()
        Me.tab_menu_est.SuspendLayout()
        Me.tab_est.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.TipoDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreditosXEmpleadoBindingSource
        '
        Me.CreditosXEmpleadoBindingSource.DataMember = "CreditosXEmpleado"
        Me.CreditosXEmpleadoBindingSource.DataSource = Me.PAV1DataSet2
        '
        'PAV1DataSet2
        '
        Me.PAV1DataSet2.DataSetName = "PAV1DataSet2"
        Me.PAV1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreditosXSolicitanteBindingSource
        '
        Me.CreditosXSolicitanteBindingSource.DataMember = "CreditosXSolicitante"
        Me.CreditosXSolicitanteBindingSource.DataSource = Me.PAV1DataSet2
        '
        'CreditosXRangoFechasBindingSource
        '
        Me.CreditosXRangoFechasBindingSource.DataMember = "CreditosXRangoFechas"
        Me.CreditosXRangoFechasBindingSource.DataSource = Me.PAV1DataSet2
        '
        'CreditosXRangoMontoBindingSource
        '
        Me.CreditosXRangoMontoBindingSource.DataMember = "CreditosXRangoMonto"
        Me.CreditosXRangoMontoBindingSource.DataSource = Me.PAV1DataSet2
        '
        'ExpedientesXAbogadoBindingSource
        '
        Me.ExpedientesXAbogadoBindingSource.DataMember = "ExpedientesXAbogado"
        Me.ExpedientesXAbogadoBindingSource.DataSource = Me.PAV1DataSet2
        '
        'CreditosXEmpleadoAgrupadoBindingSource
        '
        Me.CreditosXEmpleadoAgrupadoBindingSource.DataMember = "CreditosXEmpleadoAgrupado"
        Me.CreditosXEmpleadoAgrupadoBindingSource.DataSource = Me.PAV1DataSet2
        '
        'GananciaXRangoMesBindingSource
        '
        Me.GananciaXRangoMesBindingSource.DataMember = "GananciaXRangoMes"
        Me.GananciaXRangoMesBindingSource.DataSource = Me.PAV1DataSet2
        '
        'CreditosXRangoEstadisticaBindingSource
        '
        Me.CreditosXRangoEstadisticaBindingSource.DataMember = "CreditosXRangoEstadistica"
        Me.CreditosXRangoEstadisticaBindingSource.DataSource = Me.PAV1DataSet2
        '
        'EstadoXCuotaBindingSource
        '
        Me.EstadoXCuotaBindingSource.DataMember = "EstadoXCuota"
        Me.EstadoXCuotaBindingSource.DataSource = Me.PAV1DataSet2
        '
        'EstadoXCreditoBindingSource
        '
        Me.EstadoXCreditoBindingSource.DataMember = "EstadoXCredito"
        Me.EstadoXCreditoBindingSource.DataSource = Me.PAV1DataSet2
        '
        'tab_control
        '
        Me.tab_control.Controls.Add(Me.tab_control_abogado)
        Me.tab_control.Controls.Add(Me.tab_control_solicitante)
        Me.tab_control.Controls.Add(Me.tab_control_empleado)
        Me.tab_control.Controls.Add(Me.tab_control_credito)
        Me.tab_control.Controls.Add(Me.tab_control_expediente)
        Me.tab_control.Controls.Add(Me.tab_control_garantia)
        Me.tab_control.Controls.Add(Me.tab_control_pago)
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
        Me.tab_control_credito.Controls.Add(Me.btn_credito_cuotas)
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
        'btn_credito_cuotas
        '
        Me.btn_credito_cuotas.BackColor = System.Drawing.Color.Transparent
        Me.btn_credito_cuotas.Enabled = False
        Me.btn_credito_cuotas.ForeColor = System.Drawing.Color.Black
        Me.btn_credito_cuotas.Location = New System.Drawing.Point(61, 331)
        Me.btn_credito_cuotas.Name = "btn_credito_cuotas"
        Me.btn_credito_cuotas.Size = New System.Drawing.Size(299, 53)
        Me.btn_credito_cuotas.TabIndex = 10
        Me.btn_credito_cuotas.Text = "Cargar Cuotas"
        Me.btn_credito_cuotas.UseVisualStyleBackColor = False
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
        Me.txt_creditos_idObjeto.Enabled = False
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
        Me.mtxt_creditos_fAprobacion.Enabled = False
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
        Me.txt_expediente_matAbSol.TabIndex = 4
        '
        'txt_expediente_observacion
        '
        Me.txt_expediente_observacion.Location = New System.Drawing.Point(221, 218)
        Me.txt_expediente_observacion.Name = "txt_expediente_observacion"
        Me.txt_expediente_observacion.Size = New System.Drawing.Size(186, 20)
        Me.txt_expediente_observacion.TabIndex = 5
        '
        'txt_expediente_matAbCre
        '
        Me.txt_expediente_matAbCre.Location = New System.Drawing.Point(221, 149)
        Me.txt_expediente_matAbCre.Name = "txt_expediente_matAbCre"
        Me.txt_expediente_matAbCre.Size = New System.Drawing.Size(100, 20)
        Me.txt_expediente_matAbCre.TabIndex = 3
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
        Me.txt_expediente_codCred.TabIndex = 1
        '
        'txt_expediente_numeroExp
        '
        Me.txt_expediente_numeroExp.Location = New System.Drawing.Point(221, 35)
        Me.txt_expediente_numeroExp.Name = "txt_expediente_numeroExp"
        Me.txt_expediente_numeroExp.Size = New System.Drawing.Size(100, 20)
        Me.txt_expediente_numeroExp.TabIndex = 0
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
        'tab_control_garantia
        '
        Me.tab_control_garantia.Controls.Add(Me.txt_garantias_ubicacion)
        Me.tab_control_garantia.Controls.Add(Me.lbl_documentacion)
        Me.tab_control_garantia.Controls.Add(Me.txt_garantias_descripDocum)
        Me.tab_control_garantia.Controls.Add(Me.lbl_descripcion_documentacion)
        Me.tab_control_garantia.Controls.Add(Me.txt_garantia_monto)
        Me.tab_control_garantia.Controls.Add(Me.lbl_direccion_documentacion)
        Me.tab_control_garantia.Controls.Add(Me.txt_garantias_idDocumentacion)
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
        'txt_garantias_ubicacion
        '
        Me.txt_garantias_ubicacion.Location = New System.Drawing.Point(147, 269)
        Me.txt_garantias_ubicacion.Name = "txt_garantias_ubicacion"
        Me.txt_garantias_ubicacion.Size = New System.Drawing.Size(236, 20)
        Me.txt_garantias_ubicacion.TabIndex = 4
        '
        'lbl_documentacion
        '
        Me.lbl_documentacion.Location = New System.Drawing.Point(31, 183)
        Me.lbl_documentacion.Name = "lbl_documentacion"
        Me.lbl_documentacion.Size = New System.Drawing.Size(155, 14)
        Me.lbl_documentacion.TabIndex = 5
        Me.lbl_documentacion.Text = "Documentacion de Garantía"
        '
        'txt_garantias_descripDocum
        '
        Me.txt_garantias_descripDocum.Location = New System.Drawing.Point(147, 213)
        Me.txt_garantias_descripDocum.Name = "txt_garantias_descripDocum"
        Me.txt_garantias_descripDocum.Size = New System.Drawing.Size(236, 20)
        Me.txt_garantias_descripDocum.TabIndex = 3
        '
        'lbl_descripcion_documentacion
        '
        Me.lbl_descripcion_documentacion.Location = New System.Drawing.Point(33, 216)
        Me.lbl_descripcion_documentacion.Name = "lbl_descripcion_documentacion"
        Me.lbl_descripcion_documentacion.Size = New System.Drawing.Size(63, 23)
        Me.lbl_descripcion_documentacion.TabIndex = 0
        Me.lbl_descripcion_documentacion.Text = "Descripcion"
        '
        'txt_garantia_monto
        '
        Me.txt_garantia_monto.AllowDrop = True
        Me.txt_garantia_monto.Location = New System.Drawing.Point(196, 105)
        Me.txt_garantia_monto.Name = "txt_garantia_monto"
        Me.txt_garantia_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_garantia_monto.TabIndex = 2
        '
        'lbl_direccion_documentacion
        '
        Me.lbl_direccion_documentacion.Location = New System.Drawing.Point(33, 272)
        Me.lbl_direccion_documentacion.Name = "lbl_direccion_documentacion"
        Me.lbl_direccion_documentacion.Size = New System.Drawing.Size(118, 13)
        Me.lbl_direccion_documentacion.TabIndex = 1
        Me.lbl_direccion_documentacion.Text = "Ubicación del Archivo"
        '
        'txt_garantias_idDocumentacion
        '
        Me.txt_garantias_idDocumentacion.Enabled = False
        Me.txt_garantias_idDocumentacion.Location = New System.Drawing.Point(102, 213)
        Me.txt_garantias_idDocumentacion.Name = "txt_garantias_idDocumentacion"
        Me.txt_garantias_idDocumentacion.Size = New System.Drawing.Size(31, 20)
        Me.txt_garantias_idDocumentacion.TabIndex = 3
        Me.txt_garantias_idDocumentacion.Visible = False
        '
        'txt_garantia_descripcion
        '
        Me.txt_garantia_descripcion.Location = New System.Drawing.Point(196, 71)
        Me.txt_garantia_descripcion.Name = "txt_garantia_descripcion"
        Me.txt_garantia_descripcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_garantia_descripcion.TabIndex = 1
        '
        'txt_garantia_idCredito
        '
        Me.txt_garantia_idCredito.Location = New System.Drawing.Point(196, 35)
        Me.txt_garantia_idCredito.Name = "txt_garantia_idCredito"
        Me.txt_garantia_idCredito.Size = New System.Drawing.Size(100, 20)
        Me.txt_garantia_idCredito.TabIndex = 0
        '
        'lbl_garantia_monto
        '
        Me.lbl_garantia_monto.Location = New System.Drawing.Point(31, 108)
        Me.lbl_garantia_monto.Name = "lbl_garantia_monto"
        Me.lbl_garantia_monto.Size = New System.Drawing.Size(81, 13)
        Me.lbl_garantia_monto.TabIndex = 0
        Me.lbl_garantia_monto.Text = "Valor Monetario"
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
        'lbl_garantia_codCredito
        '
        Me.lbl_garantia_codCredito.AutoSize = True
        Me.lbl_garantia_codCredito.Location = New System.Drawing.Point(31, 38)
        Me.lbl_garantia_codCredito.Name = "lbl_garantia_codCredito"
        Me.lbl_garantia_codCredito.Size = New System.Drawing.Size(91, 13)
        Me.lbl_garantia_codCredito.TabIndex = 0
        Me.lbl_garantia_codCredito.Text = "Codigo de Credito"
        '
        'tab_control_pago
        '
        Me.tab_control_pago.Controls.Add(Me.cmb_pago_estado)
        Me.tab_control_pago.Controls.Add(Me.txt_pago_fecha)
        Me.tab_control_pago.Controls.Add(Me.Label7)
        Me.tab_control_pago.Controls.Add(Me.Label6)
        Me.tab_control_pago.Controls.Add(Me.txt_pago_codCred)
        Me.tab_control_pago.Controls.Add(Me.Label5)
        Me.tab_control_pago.Location = New System.Drawing.Point(4, 22)
        Me.tab_control_pago.Name = "tab_control_pago"
        Me.tab_control_pago.Size = New System.Drawing.Size(420, 618)
        Me.tab_control_pago.TabIndex = 7
        Me.tab_control_pago.Text = "Manejo Pago"
        Me.tab_control_pago.UseVisualStyleBackColor = True
        '
        'cmb_pago_estado
        '
        Me.cmb_pago_estado.FormattingEnabled = True
        Me.cmb_pago_estado.Location = New System.Drawing.Point(132, 101)
        Me.cmb_pago_estado.Name = "cmb_pago_estado"
        Me.cmb_pago_estado.Size = New System.Drawing.Size(121, 21)
        Me.cmb_pago_estado.TabIndex = 2
        '
        'txt_pago_fecha
        '
        Me.txt_pago_fecha.Location = New System.Drawing.Point(132, 65)
        Me.txt_pago_fecha.Name = "txt_pago_fecha"
        Me.txt_pago_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_pago_fecha.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Estado de Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fecha de Pago"
        '
        'txt_pago_codCred
        '
        Me.txt_pago_codCred.Location = New System.Drawing.Point(132, 27)
        Me.txt_pago_codCred.Name = "txt_pago_codCred"
        Me.txt_pago_codCred.Size = New System.Drawing.Size(100, 20)
        Me.txt_pago_codCred.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Codigo de Credito"
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
        Me.tab_menu.Controls.Add(Me.tab_menu_report)
        Me.tab_menu.Controls.Add(Me.tab_menu_est)
        Me.tab_menu.Location = New System.Drawing.Point(8, 2)
        Me.tab_menu.Name = "tab_menu"
        Me.tab_menu.SelectedIndex = 0
        Me.tab_menu.Size = New System.Drawing.Size(1238, 679)
        Me.tab_menu.TabIndex = 9
        '
        'tab_menu_inicio
        '
        Me.tab_menu_inicio.BackgroundImage = CType(resources.GetObject("tab_menu_inicio.BackgroundImage"), System.Drawing.Image)
        Me.tab_menu_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tab_menu_inicio.Location = New System.Drawing.Point(4, 22)
        Me.tab_menu_inicio.Name = "tab_menu_inicio"
        Me.tab_menu_inicio.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_menu_inicio.Size = New System.Drawing.Size(1230, 653)
        Me.tab_menu_inicio.TabIndex = 0
        Me.tab_menu_inicio.Text = "Inicio"
        Me.tab_menu_inicio.UseVisualStyleBackColor = True
        '
        'tab_menu_abm
        '
        Me.tab_menu_abm.Controls.Add(Me.tab_control)
        Me.tab_menu_abm.Location = New System.Drawing.Point(4, 22)
        Me.tab_menu_abm.Name = "tab_menu_abm"
        Me.tab_menu_abm.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_menu_abm.Size = New System.Drawing.Size(1230, 653)
        Me.tab_menu_abm.TabIndex = 1
        Me.tab_menu_abm.Text = "Carga de Datos"
        Me.tab_menu_abm.UseVisualStyleBackColor = True
        '
        'tab_menu_report
        '
        Me.tab_menu_report.Controls.Add(Me.tab_report)
        Me.tab_menu_report.Location = New System.Drawing.Point(4, 22)
        Me.tab_menu_report.Name = "tab_menu_report"
        Me.tab_menu_report.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_menu_report.Size = New System.Drawing.Size(1230, 653)
        Me.tab_menu_report.TabIndex = 2
        Me.tab_menu_report.Text = "Reportes"
        Me.tab_menu_report.UseVisualStyleBackColor = True
        '
        'tab_report
        '
        Me.tab_report.Controls.Add(Me.tab_report_credxemp)
        Me.tab_report.Controls.Add(Me.tab_report_credxsol)
        Me.tab_report.Controls.Add(Me.tab_report_credxrango)
        Me.tab_report.Controls.Add(Me.tab_report_credxmonto)
        Me.tab_report.Controls.Add(Me.tab_report_expxabg)
        Me.tab_report.Location = New System.Drawing.Point(0, 8)
        Me.tab_report.Name = "tab_report"
        Me.tab_report.SelectedIndex = 0
        Me.tab_report.Size = New System.Drawing.Size(1241, 614)
        Me.tab_report.TabIndex = 0
        '
        'tab_report_credxemp
        '
        Me.tab_report_credxemp.Controls.Add(Me.Label8)
        Me.tab_report_credxemp.Controls.Add(Me.txt_cantxemp_leg)
        Me.tab_report_credxemp.Controls.Add(Me.report_credxemp)
        Me.tab_report_credxemp.Controls.Add(Me.btn_cantxemp)
        Me.tab_report_credxemp.Location = New System.Drawing.Point(4, 22)
        Me.tab_report_credxemp.Name = "tab_report_credxemp"
        Me.tab_report_credxemp.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_report_credxemp.Size = New System.Drawing.Size(1233, 588)
        Me.tab_report_credxemp.TabIndex = 0
        Me.tab_report_credxemp.Text = "Creditos Por Empleado"
        Me.tab_report_credxemp.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 552)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Legajo Empleado"
        '
        'txt_cantxemp_leg
        '
        Me.txt_cantxemp_leg.Location = New System.Drawing.Point(104, 549)
        Me.txt_cantxemp_leg.Name = "txt_cantxemp_leg"
        Me.txt_cantxemp_leg.Size = New System.Drawing.Size(117, 20)
        Me.txt_cantxemp_leg.TabIndex = 1
        '
        'report_credxemp
        '
        ReportDataSource1.Name = "tabla_credxemp"
        ReportDataSource1.Value = Me.CreditosXEmpleadoBindingSource
        Me.report_credxemp.LocalReport.DataSources.Add(ReportDataSource1)
        Me.report_credxemp.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report1.rdlc"
        Me.report_credxemp.Location = New System.Drawing.Point(0, 3)
        Me.report_credxemp.Name = "report_credxemp"
        Me.report_credxemp.Size = New System.Drawing.Size(1161, 522)
        Me.report_credxemp.TabIndex = 3
        '
        'btn_cantxemp
        '
        Me.btn_cantxemp.Location = New System.Drawing.Point(319, 544)
        Me.btn_cantxemp.Name = "btn_cantxemp"
        Me.btn_cantxemp.Size = New System.Drawing.Size(82, 28)
        Me.btn_cantxemp.TabIndex = 2
        Me.btn_cantxemp.Text = "Mostrar"
        Me.btn_cantxemp.UseVisualStyleBackColor = True
        '
        'tab_report_credxsol
        '
        Me.tab_report_credxsol.Controls.Add(Me.cmb_credxsol)
        Me.tab_report_credxsol.Controls.Add(Me.Label9)
        Me.tab_report_credxsol.Controls.Add(Me.txt_cantxsol_doc)
        Me.tab_report_credxsol.Controls.Add(Me.btn_cantxsol)
        Me.tab_report_credxsol.Controls.Add(Me.report_credxsol)
        Me.tab_report_credxsol.Location = New System.Drawing.Point(4, 22)
        Me.tab_report_credxsol.Name = "tab_report_credxsol"
        Me.tab_report_credxsol.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_report_credxsol.Size = New System.Drawing.Size(1233, 588)
        Me.tab_report_credxsol.TabIndex = 1
        Me.tab_report_credxsol.Text = "Creditos Por Solicitante"
        Me.tab_report_credxsol.UseVisualStyleBackColor = True
        '
        'cmb_credxsol
        '
        Me.cmb_credxsol.FormattingEnabled = True
        Me.cmb_credxsol.Location = New System.Drawing.Point(199, 549)
        Me.cmb_credxsol.Name = "cmb_credxsol"
        Me.cmb_credxsol.Size = New System.Drawing.Size(99, 21)
        Me.cmb_credxsol.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 552)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Doc Solicitante"
        '
        'txt_cantxsol_doc
        '
        Me.txt_cantxsol_doc.Location = New System.Drawing.Point(104, 549)
        Me.txt_cantxsol_doc.Name = "txt_cantxsol_doc"
        Me.txt_cantxsol_doc.Size = New System.Drawing.Size(77, 20)
        Me.txt_cantxsol_doc.TabIndex = 1
        '
        'btn_cantxsol
        '
        Me.btn_cantxsol.Location = New System.Drawing.Point(319, 544)
        Me.btn_cantxsol.Name = "btn_cantxsol"
        Me.btn_cantxsol.Size = New System.Drawing.Size(82, 28)
        Me.btn_cantxsol.TabIndex = 3
        Me.btn_cantxsol.Text = "Mostrar"
        Me.btn_cantxsol.UseVisualStyleBackColor = True
        '
        'report_credxsol
        '
        ReportDataSource2.Name = "tabla2"
        ReportDataSource2.Value = Me.CreditosXSolicitanteBindingSource
        Me.report_credxsol.LocalReport.DataSources.Add(ReportDataSource2)
        Me.report_credxsol.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report2.rdlc"
        Me.report_credxsol.Location = New System.Drawing.Point(0, 3)
        Me.report_credxsol.Name = "report_credxsol"
        Me.report_credxsol.Size = New System.Drawing.Size(1161, 522)
        Me.report_credxsol.TabIndex = 4
        '
        'tab_report_credxrango
        '
        Me.tab_report_credxrango.Controls.Add(Me.datetime_credxrango_hasta)
        Me.tab_report_credxrango.Controls.Add(Me.datetime_credxrango_desde)
        Me.tab_report_credxrango.Controls.Add(Me.Label11)
        Me.tab_report_credxrango.Controls.Add(Me.Label10)
        Me.tab_report_credxrango.Controls.Add(Me.btn_credxrango)
        Me.tab_report_credxrango.Controls.Add(Me.report_credxfecha)
        Me.tab_report_credxrango.Location = New System.Drawing.Point(4, 22)
        Me.tab_report_credxrango.Name = "tab_report_credxrango"
        Me.tab_report_credxrango.Size = New System.Drawing.Size(1233, 588)
        Me.tab_report_credxrango.TabIndex = 2
        Me.tab_report_credxrango.Text = "Creditos por Rango Fechas"
        Me.tab_report_credxrango.UseVisualStyleBackColor = True
        '
        'datetime_credxrango_hasta
        '
        Me.datetime_credxrango_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetime_credxrango_hasta.Location = New System.Drawing.Point(216, 549)
        Me.datetime_credxrango_hasta.Name = "datetime_credxrango_hasta"
        Me.datetime_credxrango_hasta.Size = New System.Drawing.Size(97, 20)
        Me.datetime_credxrango_hasta.TabIndex = 3
        '
        'datetime_credxrango_desde
        '
        Me.datetime_credxrango_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetime_credxrango_desde.Location = New System.Drawing.Point(77, 549)
        Me.datetime_credxrango_desde.Name = "datetime_credxrango_desde"
        Me.datetime_credxrango_desde.Size = New System.Drawing.Size(97, 20)
        Me.datetime_credxrango_desde.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(177, 552)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Hasta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Desde"
        '
        'btn_credxrango
        '
        Me.btn_credxrango.Location = New System.Drawing.Point(319, 544)
        Me.btn_credxrango.Name = "btn_credxrango"
        Me.btn_credxrango.Size = New System.Drawing.Size(82, 28)
        Me.btn_credxrango.TabIndex = 4
        Me.btn_credxrango.Text = "Mostrar"
        Me.btn_credxrango.UseVisualStyleBackColor = True
        '
        'report_credxfecha
        '
        ReportDataSource3.Name = "tabla3"
        ReportDataSource3.Value = Me.CreditosXRangoFechasBindingSource
        Me.report_credxfecha.LocalReport.DataSources.Add(ReportDataSource3)
        Me.report_credxfecha.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report3.rdlc"
        Me.report_credxfecha.Location = New System.Drawing.Point(0, 3)
        Me.report_credxfecha.Name = "report_credxfecha"
        Me.report_credxfecha.Size = New System.Drawing.Size(1161, 522)
        Me.report_credxfecha.TabIndex = 5
        '
        'tab_report_credxmonto
        '
        Me.tab_report_credxmonto.Controls.Add(Me.txt_credxmonto_hasta)
        Me.tab_report_credxmonto.Controls.Add(Me.txt_credxmonto_desde)
        Me.tab_report_credxmonto.Controls.Add(Me.Label12)
        Me.tab_report_credxmonto.Controls.Add(Me.Label13)
        Me.tab_report_credxmonto.Controls.Add(Me.btn_credxmonto)
        Me.tab_report_credxmonto.Controls.Add(Me.report_credxmonto)
        Me.tab_report_credxmonto.Location = New System.Drawing.Point(4, 22)
        Me.tab_report_credxmonto.Name = "tab_report_credxmonto"
        Me.tab_report_credxmonto.Size = New System.Drawing.Size(1233, 588)
        Me.tab_report_credxmonto.TabIndex = 3
        Me.tab_report_credxmonto.Text = "Creditos por Rango Monto"
        Me.tab_report_credxmonto.UseVisualStyleBackColor = True
        '
        'txt_credxmonto_hasta
        '
        Me.txt_credxmonto_hasta.Location = New System.Drawing.Point(221, 549)
        Me.txt_credxmonto_hasta.Name = "txt_credxmonto_hasta"
        Me.txt_credxmonto_hasta.Size = New System.Drawing.Size(74, 20)
        Me.txt_credxmonto_hasta.TabIndex = 3
        '
        'txt_credxmonto_desde
        '
        Me.txt_credxmonto_desde.Location = New System.Drawing.Point(86, 549)
        Me.txt_credxmonto_desde.Name = "txt_credxmonto_desde"
        Me.txt_credxmonto_desde.Size = New System.Drawing.Size(74, 20)
        Me.txt_credxmonto_desde.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(177, 552)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Hasta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 552)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Desde"
        '
        'btn_credxmonto
        '
        Me.btn_credxmonto.Location = New System.Drawing.Point(319, 544)
        Me.btn_credxmonto.Name = "btn_credxmonto"
        Me.btn_credxmonto.Size = New System.Drawing.Size(82, 28)
        Me.btn_credxmonto.TabIndex = 4
        Me.btn_credxmonto.Text = "Mostrar"
        Me.btn_credxmonto.UseVisualStyleBackColor = True
        '
        'report_credxmonto
        '
        ReportDataSource4.Name = "tabla4"
        ReportDataSource4.Value = Me.CreditosXRangoMontoBindingSource
        Me.report_credxmonto.LocalReport.DataSources.Add(ReportDataSource4)
        Me.report_credxmonto.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report4.rdlc"
        Me.report_credxmonto.Location = New System.Drawing.Point(0, 3)
        Me.report_credxmonto.Name = "report_credxmonto"
        Me.report_credxmonto.Size = New System.Drawing.Size(1161, 522)
        Me.report_credxmonto.TabIndex = 5
        '
        'tab_report_expxabg
        '
        Me.tab_report_expxabg.Controls.Add(Me.Label3)
        Me.tab_report_expxabg.Controls.Add(Me.txt_expxabg_leg)
        Me.tab_report_expxabg.Controls.Add(Me.btn_expxabg)
        Me.tab_report_expxabg.Controls.Add(Me.report_expxabg)
        Me.tab_report_expxabg.Location = New System.Drawing.Point(4, 22)
        Me.tab_report_expxabg.Name = "tab_report_expxabg"
        Me.tab_report_expxabg.Size = New System.Drawing.Size(1233, 588)
        Me.tab_report_expxabg.TabIndex = 4
        Me.tab_report_expxabg.Text = "Expediente por Abogado"
        Me.tab_report_expxabg.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Legajo Abogado"
        '
        'txt_expxabg_leg
        '
        Me.txt_expxabg_leg.Location = New System.Drawing.Point(104, 549)
        Me.txt_expxabg_leg.Name = "txt_expxabg_leg"
        Me.txt_expxabg_leg.Size = New System.Drawing.Size(117, 20)
        Me.txt_expxabg_leg.TabIndex = 1
        '
        'btn_expxabg
        '
        Me.btn_expxabg.Location = New System.Drawing.Point(319, 544)
        Me.btn_expxabg.Name = "btn_expxabg"
        Me.btn_expxabg.Size = New System.Drawing.Size(82, 28)
        Me.btn_expxabg.TabIndex = 2
        Me.btn_expxabg.Text = "Mostrar"
        Me.btn_expxabg.UseVisualStyleBackColor = True
        '
        'report_expxabg
        '
        ReportDataSource5.Name = "tabla_expediente"
        ReportDataSource5.Value = Me.ExpedientesXAbogadoBindingSource
        Me.report_expxabg.LocalReport.DataSources.Add(ReportDataSource5)
        Me.report_expxabg.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report8.rdlc"
        Me.report_expxabg.Location = New System.Drawing.Point(0, 3)
        Me.report_expxabg.Name = "report_expxabg"
        Me.report_expxabg.Size = New System.Drawing.Size(1161, 522)
        Me.report_expxabg.TabIndex = 2
        '
        'tab_menu_est
        '
        Me.tab_menu_est.Controls.Add(Me.tab_est)
        Me.tab_menu_est.Location = New System.Drawing.Point(4, 22)
        Me.tab_menu_est.Name = "tab_menu_est"
        Me.tab_menu_est.Size = New System.Drawing.Size(1230, 653)
        Me.tab_menu_est.TabIndex = 3
        Me.tab_menu_est.Text = "Estadisticas"
        Me.tab_menu_est.UseVisualStyleBackColor = True
        '
        'tab_est
        '
        Me.tab_est.Controls.Add(Me.TabPage1)
        Me.tab_est.Controls.Add(Me.TabPage2)
        Me.tab_est.Controls.Add(Me.TabPage3)
        Me.tab_est.Controls.Add(Me.TabPage4)
        Me.tab_est.Controls.Add(Me.TabPage5)
        Me.tab_est.Location = New System.Drawing.Point(0, 8)
        Me.tab_est.Name = "tab_est"
        Me.tab_est.SelectedIndex = 0
        Me.tab_est.Size = New System.Drawing.Size(1241, 614)
        Me.tab_est.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CreditosXEmpleadoAgrupado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1233, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Creditos Por Empleado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CreditosXEmpleadoAgrupado
        '
        ReportDataSource6.Name = "CantidadCreditosXEmpleadoAgrupado"
        ReportDataSource6.Value = Me.CreditosXEmpleadoAgrupadoBindingSource
        Me.CreditosXEmpleadoAgrupado.LocalReport.DataSources.Add(ReportDataSource6)
        Me.CreditosXEmpleadoAgrupado.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report5.rdlc"
        Me.CreditosXEmpleadoAgrupado.Location = New System.Drawing.Point(0, 3)
        Me.CreditosXEmpleadoAgrupado.Name = "CreditosXEmpleadoAgrupado"
        Me.CreditosXEmpleadoAgrupado.Size = New System.Drawing.Size(1161, 522)
        Me.CreditosXEmpleadoAgrupado.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btn_gxm)
        Me.TabPage2.Controls.Add(Me.txt_gxmhasta)
        Me.TabPage2.Controls.Add(Me.txt_gxm_desde)
        Me.TabPage2.Controls.Add(Me.report_gxm)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1233, 588)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ganancias Por Periodo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 552)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 552)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Desde"
        '
        'btn_gxm
        '
        Me.btn_gxm.Location = New System.Drawing.Point(319, 544)
        Me.btn_gxm.Name = "btn_gxm"
        Me.btn_gxm.Size = New System.Drawing.Size(82, 28)
        Me.btn_gxm.TabIndex = 11
        Me.btn_gxm.Text = "Mostrar"
        Me.btn_gxm.UseVisualStyleBackColor = True
        '
        'txt_gxmhasta
        '
        Me.txt_gxmhasta.Location = New System.Drawing.Point(204, 549)
        Me.txt_gxmhasta.Mask = "00"
        Me.txt_gxmhasta.Name = "txt_gxmhasta"
        Me.txt_gxmhasta.Size = New System.Drawing.Size(20, 20)
        Me.txt_gxmhasta.TabIndex = 10
        '
        'txt_gxm_desde
        '
        Me.txt_gxm_desde.Location = New System.Drawing.Point(104, 549)
        Me.txt_gxm_desde.Mask = "00"
        Me.txt_gxm_desde.Name = "txt_gxm_desde"
        Me.txt_gxm_desde.Size = New System.Drawing.Size(20, 20)
        Me.txt_gxm_desde.TabIndex = 9
        '
        'report_gxm
        '
        ReportDataSource7.Name = "tabla_ganancia"
        ReportDataSource7.Value = Me.GananciaXRangoMesBindingSource
        Me.report_gxm.LocalReport.DataSources.Add(ReportDataSource7)
        Me.report_gxm.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report6.rdlc"
        Me.report_gxm.Location = New System.Drawing.Point(0, 3)
        Me.report_gxm.Name = "report_gxm"
        Me.report_gxm.Size = New System.Drawing.Size(1161, 522)
        Me.report_gxm.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmb_cantXRango_est)
        Me.TabPage3.Controls.Add(Me.lbl_año_estadistica1)
        Me.TabPage3.Controls.Add(Me.txt_cantXRango_año)
        Me.TabPage3.Controls.Add(Me.btn_cantCredXRang)
        Me.TabPage3.Controls.Add(Me.CreditosXRangoEstadistica)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1233, 588)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Creditos Por Rango"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmb_cantXRango_est
        '
        Me.cmb_cantXRango_est.FormattingEnabled = True
        Me.cmb_cantXRango_est.Items.AddRange(New Object() {"MENSUAL", "BIMESTRAL", "TRIMESTRAL", "CUATRIMESTRAL", "SEMESTRAL"})
        Me.cmb_cantXRango_est.Location = New System.Drawing.Point(199, 549)
        Me.cmb_cantXRango_est.Name = "cmb_cantXRango_est"
        Me.cmb_cantXRango_est.Size = New System.Drawing.Size(99, 21)
        Me.cmb_cantXRango_est.TabIndex = 10
        '
        'lbl_año_estadistica1
        '
        Me.lbl_año_estadistica1.AutoSize = True
        Me.lbl_año_estadistica1.Location = New System.Drawing.Point(50, 552)
        Me.lbl_año_estadistica1.Name = "lbl_año_estadistica1"
        Me.lbl_año_estadistica1.Size = New System.Drawing.Size(26, 13)
        Me.lbl_año_estadistica1.TabIndex = 9
        Me.lbl_año_estadistica1.Text = "Año"
        '
        'txt_cantXRango_año
        '
        Me.txt_cantXRango_año.Location = New System.Drawing.Point(104, 549)
        Me.txt_cantXRango_año.Name = "txt_cantXRango_año"
        Me.txt_cantXRango_año.Size = New System.Drawing.Size(77, 20)
        Me.txt_cantXRango_año.TabIndex = 8
        '
        'btn_cantCredXRang
        '
        Me.btn_cantCredXRang.Location = New System.Drawing.Point(319, 544)
        Me.btn_cantCredXRang.Name = "btn_cantCredXRang"
        Me.btn_cantCredXRang.Size = New System.Drawing.Size(82, 28)
        Me.btn_cantCredXRang.TabIndex = 6
        Me.btn_cantCredXRang.Text = "Mostrar"
        Me.btn_cantCredXRang.UseVisualStyleBackColor = True
        '
        'CreditosXRangoEstadistica
        '
        ReportDataSource8.Name = "CreditosXRangoEstadistica"
        ReportDataSource8.Value = Me.CreditosXRangoEstadisticaBindingSource
        Me.CreditosXRangoEstadistica.LocalReport.DataSources.Add(ReportDataSource8)
        Me.CreditosXRangoEstadistica.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report7.rdlc"
        Me.CreditosXRangoEstadistica.Location = New System.Drawing.Point(0, 3)
        Me.CreditosXRangoEstadistica.Name = "CreditosXRangoEstadistica"
        Me.CreditosXRangoEstadistica.Size = New System.Drawing.Size(1161, 522)
        Me.CreditosXRangoEstadistica.TabIndex = 5
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.report_estadoC)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1233, 588)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Estado Cuotas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'report_estadoC
        '
        ReportDataSource9.Name = "graficoEstadoXCuota"
        ReportDataSource9.Value = Me.EstadoXCuotaBindingSource
        Me.report_estadoC.LocalReport.DataSources.Add(ReportDataSource9)
        Me.report_estadoC.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report9.rdlc"
        Me.report_estadoC.Location = New System.Drawing.Point(0, 3)
        Me.report_estadoC.Name = "report_estadoC"
        Me.report_estadoC.Size = New System.Drawing.Size(1161, 522)
        Me.report_estadoC.TabIndex = 6
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.report_estadoCred)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1233, 588)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Estado Creditos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'report_estadoCred
        '
        ReportDataSource10.Name = "grafico_estadoCredito"
        ReportDataSource10.Value = Me.EstadoXCreditoBindingSource
        Me.report_estadoCred.LocalReport.DataSources.Add(ReportDataSource10)
        Me.report_estadoCred.LocalReport.ReportEmbeddedResource = "TP_PAV1.Report10.rdlc"
        Me.report_estadoCred.Location = New System.Drawing.Point(0, 3)
        Me.report_estadoCred.Name = "report_estadoCred"
        Me.report_estadoCred.Size = New System.Drawing.Size(1161, 522)
        Me.report_estadoCred.TabIndex = 5
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
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(1172, 682)
        Me.Controls.Add(Me.grp_controles)
        Me.Controls.Add(Me.tab_menu)
        Me.Name = "frm_Menu"
        Me.Text = "Creditos CreCOR"
        CType(Me.CreditosXEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAV1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosXSolicitanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosXRangoFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosXRangoMontoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedientesXAbogadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosXEmpleadoAgrupadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GananciaXRangoMesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosXRangoEstadisticaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoXCuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoXCreditoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.tab_control_garantia.ResumeLayout(False)
        Me.tab_control_garantia.PerformLayout()
        Me.tab_control_pago.ResumeLayout(False)
        Me.tab_control_pago.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_controles.ResumeLayout(False)
        Me.tab_menu.ResumeLayout(False)
        Me.tab_menu_abm.ResumeLayout(False)
        Me.tab_menu_report.ResumeLayout(False)
        Me.tab_report.ResumeLayout(False)
        Me.tab_report_credxemp.ResumeLayout(False)
        Me.tab_report_credxemp.PerformLayout()
        Me.tab_report_credxsol.ResumeLayout(False)
        Me.tab_report_credxsol.PerformLayout()
        Me.tab_report_credxrango.ResumeLayout(False)
        Me.tab_report_credxrango.PerformLayout()
        Me.tab_report_credxmonto.ResumeLayout(False)
        Me.tab_report_credxmonto.PerformLayout()
        Me.tab_report_expxabg.ResumeLayout(False)
        Me.tab_report_expxabg.PerformLayout()
        Me.tab_menu_est.ResumeLayout(False)
        Me.tab_est.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        CType(Me.TipoDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_garantia_monto As System.Windows.Forms.TextBox
    Friend WithEvents txt_garantia_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_garantia_idCredito As System.Windows.Forms.TextBox
    Friend WithEvents lbl_garantia_monto As System.Windows.Forms.Label
    Friend WithEvents lbl_garantia_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_garantia_codCredito As System.Windows.Forms.Label
    Friend WithEvents lbl_documentacion As System.Windows.Forms.Label
    Friend WithEvents txt_garantias_ubicacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_garantias_descripDocum As System.Windows.Forms.TextBox
    Friend WithEvents txt_garantias_idDocumentacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_direccion_documentacion As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion_documentacion As System.Windows.Forms.Label
    Friend WithEvents btn_credito_cuotas As System.Windows.Forms.Button
    Friend WithEvents tab_control_pago As System.Windows.Forms.TabPage
    Friend WithEvents cmb_pago_estado As System.Windows.Forms.ComboBox
    Friend WithEvents txt_pago_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pago_codCred As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tab_menu_report As System.Windows.Forms.TabPage
    Friend WithEvents tab_report As System.Windows.Forms.TabControl
    Friend WithEvents tab_report_credxemp As System.Windows.Forms.TabPage
    Friend WithEvents tab_report_credxsol As System.Windows.Forms.TabPage
    Friend WithEvents btn_cantxemp As System.Windows.Forms.Button
    Friend WithEvents report_credxemp As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents report_credxsol As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt_cantxemp_leg As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CreditosXEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAV1DataSet2 As TP_PAV1.PAV1DataSet2
    Friend WithEvents tab_menu_est As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cantxsol_doc As System.Windows.Forms.TextBox
    Friend WithEvents btn_cantxsol As System.Windows.Forms.Button
    Friend WithEvents CreditosXSolicitanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmb_credxsol As System.Windows.Forms.ComboBox
    Friend WithEvents tab_report_credxrango As System.Windows.Forms.TabPage
    Friend WithEvents report_credxfecha As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tab_report_credxmonto As System.Windows.Forms.TabPage
    Friend WithEvents report_credxmonto As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_credxrango As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_credxmonto As System.Windows.Forms.Button
    Friend WithEvents CreditosXRangoFechasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CreditosXRangoMontoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tab_est As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CreditosXEmpleadoAgrupado As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents report_gxm As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CreditosXRangoEstadistica As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CreditosXEmpleadoAgrupadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btn_cantCredXRang As System.Windows.Forms.Button
    Friend WithEvents cmb_cantXRango_est As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_año_estadistica1 As System.Windows.Forms.Label
    Friend WithEvents txt_cantXRango_año As System.Windows.Forms.TextBox
    Friend WithEvents CreditosXRangoEstadisticaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_gxm As System.Windows.Forms.Button
    Friend WithEvents txt_gxmhasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_gxm_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GananciaXRangoMesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents datetime_credxrango_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetime_credxrango_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_credxmonto_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txt_credxmonto_desde As System.Windows.Forms.TextBox
    Friend WithEvents tab_report_expxabg As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_expxabg_leg As System.Windows.Forms.TextBox
    Friend WithEvents btn_expxabg As System.Windows.Forms.Button
    Friend WithEvents report_expxabg As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ExpedientesXAbogadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents report_estadoC As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstadoXCuotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents report_estadoCred As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstadoXCreditoBindingSource As System.Windows.Forms.BindingSource
End Class
