Imports System.Text.RegularExpressions

Public Class frm_Menu

    Dim cadena_Conexion As String = "Data Source=MARTIN-PC;Initial Catalog=PAV1;Integrated Security=True"
    Dim conexion As New Conexion(cadena_Conexion, conexion.motores.sqlserver)
    Dim buscador As buscar_doc_tipoDoc
    Dim idSolicitante As Integer = -1

    Dim _combo As New combo     'Para carga combo
    Dim frm_objeto As frm_objeto

    Private Sub frm_Menu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Quiere Cerrar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False  'Si la salida seleccionada es SI, el formulario se cierra'
        Else
            e.Cancel = True  'Si la salida seleccionada es NO, se omite la accion de cerrado'
        End If
    End Sub

    Private Sub nombre_columnas() 'Ver si se puede hacer desde SQL directamente
        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex
        Select Case pestaña_abm
            Case 0
                grilla.Columns(0).HeaderText = "Matricula"
                grilla.Columns(1).HeaderText = "Nombres"
                grilla.Columns(2).HeaderText = "Apellido"
                grilla.Columns(3).HeaderText = "Domicilio"
                grilla.Columns(4).HeaderText = "Telefono"
            Case 1
                grilla.Columns(0).HeaderText = "Codigo de Solicitante"
                grilla.Columns(1).HeaderText = "Numero de Documento"
                grilla.Columns(2).HeaderText = "Nombres"
                grilla.Columns(3).HeaderText = "Apellido"
                grilla.Columns(4).HeaderText = "Fecha de Nacimiento"
                grilla.Columns(5).HeaderText = "Domicilio"
                grilla.Columns(6).HeaderText = "Telefono"
                grilla.Columns(7).HeaderText = "Tipo de Documento"
                'Case 2
                'Agregar empleado.
        End Select

    End Sub

    Private Sub frm_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tab_menu.Width = 1260  'Esto despues se borra, es para no tener la pestaña gigante por debajo de los controles en el diseñador
    End Sub

    Private Function nombre_tabla_pestana() As String
        Dim nom_Tabla As String = ""
        Dim pestaña As Integer = Me.tab_control.SelectedIndex
        Select Case pestaña
            Case 0
                nom_Tabla = "abogado"
            Case 1
                nom_Tabla = "solicitante"
            Case 2
                nom_Tabla = "empleado"
            Case 3
                nom_Tabla = "creditos"
            Case Else
                nom_Tabla = "ERROR"
        End Select
        Return nom_Tabla
    End Function

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim texto As String = ""
        Dim conid As Boolean
        Dim pestaña As Integer = Me.tab_control.SelectedIndex

        If validaciones_pestaña() Then
            Select Case pestaña
                Case 0
                    Dim matricula As Integer = Me.txt_abogado_matricula.Text
                    Dim fila As Integer = Me.buscar_clave(matricula)
                    If fila <> -1 Then
                        MsgBox("Ya existe un abogado con la misma matricula")
                        Exit Sub
                    Else
                        texto = "matricula=" & Me.txt_abogado_matricula.Text & ", nombre=" & Me.txt_abogado_nombre.Text & ", apellido=" & Me.txt_abogado_apellido.Text & ", telefono= " & Me.mtxt_abogado_telefono.Text & ", domicilio= " & Me.txt_abogado_domicilio.Text
                        conid = True
                    End If

                Case 1
                    Dim mtextbox As Integer
                    Int32.TryParse(mtxt_solicitante_nrodoc.Text, mtextbox)
                    If Me.buscar_doc_tdoc(mtextbox, cmb_solicitante_tipodoc.SelectedIndex + 1) = 1 Then
                        MsgBox("Ya existe un solicitante con el mismo Documento y tipo Documento")
                        Exit Sub
                    Else
                        texto = "numeroDocumento=" & Me.mtxt_solicitante_nrodoc.Text & ", apellido=" & Me.txt_solicitante_apellido.Text & ", nombre=" & Me.txt_solicitante_nombre.Text & ", telefono= " & Me.mtxt_solicitante_telefono.Text & ", domicilio= " & Me.txt_solicitante_domicilio.Text & ", tipo_Documento_idTipo_Documento= " & Me.cmb_solicitante_tipodoc.SelectedValue & ", fechaNacimiento=" & Me.mtxt_solicitante_fechaNacimiento.Text
                        conid = False
                    End If

                Case 2
                    If Me.buscar_clave(Me.txt_empleado_legSup.Text) = -1 Then
                        MsgBox("No existe ningun superior con esa matricula")
                        Exit Sub
                    Else
                        texto = "legajo=" & Me.txt_empleado_legajo.Text & ", Empleado_legajo=" & Me.txt_empleado_legSup.Text & ", Cargo_idCargo=" & Me.cmb_empleado_cargo.SelectedIndex + 1 & ", nombres=" & Me.txt_empleado_nombre.Text & ", apellido=" & Me.txt_empleado_ape.Text & ", fecha_Alta=" & Me.txt_empleado_fecha.Text
                        conid = True
                    End If
                Case 3
                    If Me.buscar_clave(Me.txt_creditos_idSolicitante.Text) = -1 Then
                        MsgBox("No existe ningun solicitante con ese codigo")
                        Exit Sub
                    End If
                    If Me.buscar_clave(Me.txt_creditos_legajo.Text) = -1 Then
                        MsgBox("No existe ningun empleado con ese legajo")
                        Exit Sub
                    End If
                    ' texto = "monto= " & Me.txt_creditos_monto.Text & ", fechaSolicitud=" & Me.txt_creditos_fSolicitud.Text & ", Solicitante_idSolicitante=" & Me.txt_creditos_idSolicitante.Text & ", Estado_Credito_idEstado_Credito=" & Me.cmb_creditos_estadoCredito.SelectedIndex & ", Empleado_legajo=" & Me.txt_creditos_legajo.Text & ", Objeto_idObjeto=" & Me.txt_creditos_idObjeto.Text
                Case 4



                Case Else
                    Exit Sub
            End Select
            conexion._insertar(texto, conid)
            cargar_Grilla()
            limpiar_tab()
            txt_empleado_fecha.Text = DateTime.Now().ToString("dd-MM-yyyy")
        End If
    End Sub

    Private Sub mostrar_Interfaz(ByVal valor As Boolean)
        If valor = True Then
            Me.tab_control.Width = 421
            Me.tab_menu.Width = 430
            Me.grp_controles.Visible = True
        Else
            Me.grp_controles.Visible = False
            Me.tab_menu.Width = 1260
        End If
    End Sub

    Private Sub limpiar_tab()
        For Each EsteControl As System.Windows.Forms.Control In tab_control.SelectedTab.Controls
            Select Case EsteControl.GetType().ToString()
                Case "System.Windows.Forms.ComboBox"
                    EsteControl.ResetText()
                Case "System.Windows.Forms.TextBox"
                    EsteControl.Text = ""
                Case "System.Windows.Forms.MaskedTextBox"
                    EsteControl.Text = ""
            End Select
        Next
    End Sub

    Private Sub cambio_Pestaña(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_menu.Selected, tab_control.Selected
        Dim pestaña_menu As Integer = Me.tab_menu.SelectedIndex
        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña_menu
            Case 0
                Me.mostrar_Interfaz(False)
            Case 1
                Me.mostrar_Interfaz(True)

                Select Case pestaña_abm
                    Case 0
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.cargar_Grilla()
                        'Combo
                        Me.conexion._tabla = "tipo_documento"
                        Me._combo.cargar(Me.cmb_solicitante_tipodoc, Me.conexion.leo_tabla())
                    Case 1
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.cargar_Grilla()
                    Case 2
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.cargar_Grilla()
                        'Combo
                        Me.conexion._tabla = "cargo"
                        Me._combo.cargar(Me.cmb_empleado_cargo, Me.conexion.leo_tabla())
                        txt_empleado_fecha.Text = DateTime.Now().ToString("dd-MM-yyyy")
                    Case 3
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.cargar_Grilla()
                        'Combo
                        Me.conexion._tabla = "Estado_Credito"
                        Me._combo.cargar(Me.cmb_creditos_estadoCredito, Me.conexion.leo_tabla())
                        txt_creditos_fSolicitud.Text = DateTime.Now().ToString("dd-MM-yyyy")
                        txt_creditos_fSolicitud.Enabled = False
                    Case 4
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.txt_expediente_codCred.Enabled = True
                        Me.cargar_Grilla()
                    Case 2
                End Select
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        Dim pestaña As Integer = Me.tab_control.SelectedIndex
        Dim id_solicitante As Integer

        Select Case pestaña
            Case 0, 2
                conexion._borrar(pedir_clave_numerica())
            Case 1 'PEDIR ID CREDITO
                If Me.idSolicitante = -1 Then
                    id_solicitante = pedir_clave_numerica()
                Else
                    id_solicitante = Me.idSolicitante
                End If
                conexion._borrar(id_solicitante)
            Case Else
                Exit Sub
        End Select
        Me.cargar_Grilla()

    End Sub

    Private Sub cargar_Grilla()
        Dim consulta_solicitante As String = "SELECT Solicitante.idSolicitante, Solicitante.numeroDocumento, Solicitante.nombre, Solicitante.apellido, Solicitante.fechaNacimiento, Solicitante.domicilio, Solicitante.telefono, tipo_Documento.nombre AS tipodoc "
        consulta_solicitante += "FROM Solicitante INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento"
        Dim consulta_empleado As String = "SELECT Empleado.legajo AS 'Legajo Empleado', Empleado.nombres AS 'Nombres', Empleado.apellido AS 'Apellido', Empleado.fecha_Alta AS 'Fecha Alta', Empleado.Empleado_legajo AS 'Legajo Superior', Cargo.nombre AS 'Cargo' "
        consulta_empleado += "FROM Empleado INNER JOIN Cargo ON Empleado.Cargo_idCargo = Cargo.idCargo"
        Dim consulta_credito As String = "SELECT Creditos.idCreditos, Creditos.monto, Creditos.fechaSolicitud, Creditos.fechaAprobacion, Estado_Credito.nombre, Objeto.descripcion, Empleado.nombres, Empleado.apellido, Solicitante.nombre AS Expr1, Solicitante.apellido AS Expr2 FROM Creditos INNER JOIN Empleado ON Creditos.Empleado_legajo = Empleado.legajo INNER JOIN Estado_Credito ON Creditos.Estado_Credito_idEstado_Credito = Estado_Credito.idEstado_Credito INNER JOIN Objeto ON Creditos.Objeto_idObjeto = Objeto.idObjeto INNER JOIN Solicitante ON Creditos.Solicitante_idSolicitante = Solicitante.idSolicitante"

        Dim consulta_expediente = "SELECT Expediente.idExpediente AS [Número Expediente], Expediente.fechaInicio AS [Fecha Inicio], Expediente.fechaEntrega AS [Fecha Entrega], Expediente.fechaDevolucion AS [Fecha Devolucion], Estado_Credito.nombre AS [Estado Crédito], Abogado.matricula AS [Matricula Abogado], Abogado.nombre AS [Nombre Abogado], Abogado.apellido AS [Apellido Abogado] "
        consulta_expediente += "FROM Expediente INNER JOIN"
        consulta_expediente += " Estado_Credito ON Expediente.Estado_Credito_idEstado_Credito = Estado_Credito.idEstado_Credito INNER JOIN"
        consulta_expediente += " Abogado ON Expediente.abogado_matricula = Abogado.matricula"
        'Dim consulta_expediente = "SELECT * FROM Expediente"

        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex
        Select Case pestaña_abm
            Case 0
                Me.grilla.DataSource = conexion.leo_tabla()
            Case 1
                Me.grilla.DataSource = conexion._consulta(consulta_solicitante)
            Case 2
                Me.grilla.DataSource = conexion._consulta(consulta_empleado)
            Case 4
                Me.grilla.DataSource = conexion._consulta(consulta_expediente)
        End Select
        nombre_columnas()
    End Sub

    Private Function validaciones_pestaña() As Boolean
        Dim pestaña As Integer = Me.tab_control.SelectedIndex
        Dim esteControl As System.Windows.Forms.Control

        For Each esteControl In tab_control.SelectedTab.Controls
            If esteControl.Text = "" Then
                MsgBox("Se deben llenar todos los campos", vbOKOnly + vbCritical, "Importante")
                Return False 'TIENE QUE SER FALSE
                Exit Function
            End If
        Next

        Select Case pestaña
            Case 0
                'Matricula negativa
                If Me.txt_abogado_matricula.Text < 1 Then
                    MsgBox("La matricula debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
                'Telefono vacio
                If mtxt_abogado_telefono.Text = "(   )    -   -" Then
                    MsgBox("Ingrese el numero de telefono", vbOKOnly + vbCritical, "Importante")
                    mtxt_solicitante_telefono.Focus()
                    Return False
                    Exit Function
                End If
                'Telefono no lleno
                If mtxt_abogado_telefono.MaskCompleted = False Then 'mtxt_abogado_telefono.Text.Length < 17
                    MsgBox("Numero de telefono invalido", vbOKOnly + vbCritical, "Importante")
                    mtxt_solicitante_telefono.Focus()
                    Return False
                    Exit Function
                End If
            Case 1
                'Largo del numero de documento
                If mtxt_solicitante_nrodoc.MaskCompleted = False Then
                    MsgBox("Documento invalido (Debe tener 8 caracteres)", vbOKOnly + vbCritical, "Importante")
                    mtxt_solicitante_nrodoc.Focus()
                    Return False
                    Exit Function
                End If
                'Telefono vacio
                If mtxt_solicitante_telefono.Text = "(   )    -   -" Then
                    MsgBox("Ingrese el numero de telefono", vbOKOnly + vbCritical, "Importante")
                    mtxt_solicitante_telefono.Focus()
                    Return False
                    Exit Function
                End If
                'Telefono no lleno
                If mtxt_solicitante_telefono.Text.Length < 17 Then
                    MsgBox("Numero de telefono invalido", vbOKOnly + vbCritical, "Importante")
                    mtxt_solicitante_telefono.Focus()
                    Return False
                    Exit Function
                End If
                'Año entre 1900 y 2014?
                If Convert.ToInt32(mtxt_solicitante_fechaNacimiento.Text.Substring(mtxt_solicitante_fechaNacimiento.Text.Length - 4)) > 2014 Or Convert.ToInt32(mtxt_solicitante_fechaNacimiento.Text.Substring(mtxt_solicitante_fechaNacimiento.Text.Length - 4)) < 1900 Then
                    MsgBox("Año invalido", vbOKOnly + vbCritical, "Importante")
                    mtxt_solicitante_fechaNacimiento.Focus()
                    Return False
                    Exit Function
                End If
            Case 2
                'Legajo negativo
                If Me.txt_empleado_legajo.Text < 1 Then
                    MsgBox("El Legajo debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
                'Legajo sup negativa
                If Me.txt_empleado_legSup.Text < 1 Then
                    MsgBox("El Legajo del superior debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
            Case 3
                'Monto negativo
                If Me.txt_creditos_monto.Text < 1 Then
                    MsgBox("El Monto debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
                'Legajo negativo
                If Me.txt_creditos_legajo.Text < 1 Then
                    MsgBox("El Legajo debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
                'Solicitante negativo
                If Me.txt_creditos_idSolicitante.Text < 1 Then
                    MsgBox("El Codigo de Solicitante debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
                'Monto negativo
                If Me.txt_creditos_monto.Text < 1 Then
                    MsgBox("El Monto debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
                'Existe legajo
                Dim clave As Integer = Me.txt_creditos_legajo.Text
                For f As Integer = 0 To grilla.Rows.Count - 1
                    Dim num As Integer = Val(grilla.Rows(f).Cells(0).Value)
                    If num = clave Then
                        grilla.Rows(f).DefaultCellStyle.BackColor = Color.Cyan
                        grilla.Rows(f).Selected = True
                    Else
                        grilla.Rows(f).DefaultCellStyle.BackColor = Color.White
                    End If
                Next
                'Existe idSolicitante
                clave = Me.txt_creditos_idSolicitante.Text
                For f As Integer = 0 To grilla.Rows.Count - 1
                    Dim num As Integer = Val(grilla.Rows(f).Cells(0).Value)
                    If num = clave Then
                        grilla.Rows(f).DefaultCellStyle.BackColor = Color.Cyan
                        grilla.Rows(f).Selected = True
                    Else
                        grilla.Rows(f).DefaultCellStyle.BackColor = Color.White
                    End If
                Next

                'HACER CON EL ESTADO DEL CREDITO, SI = APROBADO.
                'Fecha aprobacion mas vieja que solicitud
                ' If DateTime.Compare(Me.mtxt_creditos_fAprobacion.Text, Me.txt_creditos_fSolicitud.Text) Then
                'End If

                'Es Fecha?
                'CONFLICTO CON VALIDACION DE FECHAS DE SQLSERVER
                '12-31-2000 SQLSERVER
                '31-12-2000 VB.NET

                'If IsDate(mtxt_solicitante_fechaNacimiento.Text) = False Then
                '    MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Importante")
                '    mtxt_solicitante_fechaNacimiento.Focus()
                'Return false
                '    Exit Sub
                'End If

        End Select
        Return True
    End Function

    Private Sub numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_abogado_matricula.KeyPress, txt_empleado_legajo.KeyPress, txt_empleado_legSup.KeyPress, txt_creditos_idSolicitante.KeyPress, txt_creditos_legajo.KeyPress, txt_creditos_monto.KeyPress, txt_expediente_codCred.KeyPress, txt_expediente_matAbCre.KeyPress, txt_expediente_numeroExp.KeyPress, txt_expediente_matAbSol.KeyPress
        'Permitimos teclas de desplazamiento en el textbox, entre otras'
        Select Case Asc(e.KeyChar)
            Case 4, 24, 19, 127, 13, 9, 15, 14, 8
                Exit Sub
        End Select
        'Validacion de caracteres'
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("No se pueden ingresar letras", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub texto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_solicitante_apellido.KeyPress, txt_solicitante_nombre.KeyPress, txt_solicitante_apellido.KeyPress, txt_solicitante_nombre.KeyPress, txt_empleado_ape.KeyPress, txt_empleado_nombre.KeyPress

        'Permitimos teclas de desplazamiento en el textbox, entre otras'
        Select Case Asc(e.KeyChar)
            Case 4, 24, 19, 127, 13, 9, 15, 14, 8
                Exit Sub
        End Select
        'Validacion de caracteres'
        If IsNumeric(e.KeyChar) = True Then
            MsgBox("No se pueden ingresar numeros", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Function pedir_clave_numerica() As Integer
        Dim clave As Integer
        Dim resultado As String = ""
        Dim mensaje As String = ""
        Dim titulo As String = ""
        Dim valido As Boolean = False
        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña_abm
            Case 0
                mensaje = "Ingrese Matricula a buscar"
                titulo = "Matricula"
            Case 1
                mensaje = "Ingrese Codigo de Solicitante a buscar"
                titulo = "Codigo de Solicitante"
            Case 2
                mensaje = "Ingrese Legajo a buscar"
                titulo = "Legajo"
        End Select

        While valido = False
            resultado = InputBox(mensaje, titulo)
            If resultado = "" Then
                valido = True
            ElseIf IsNumeric(resultado) Then
                clave = Convert.ToInt32(resultado)
                valido = True
            End If
        End While

        If clave > 0 Then
            Return clave
        End If
        Return -1

    End Function

    Private Sub llenar_tab_segunGrilla(ByVal fila As Integer)
        Dim pestaña As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña
            Case 0
                Me.txt_abogado_matricula.Text = grilla.Rows(fila).Cells(0).Value
                Me.txt_abogado_nombre.Text = grilla.Rows(fila).Cells(1).Value
                Me.txt_abogado_apellido.Text = grilla.Rows(fila).Cells(2).Value
                Me.mtxt_abogado_telefono.Text = grilla.Rows(fila).Cells(4).Value
                Me.txt_abogado_domicilio.Text = grilla.Rows(fila).Cells(3).Value
            Case 1
                Me.idSolicitante = grilla.Rows(fila).Cells(0).Value
                Me.txt_solicitante_nombre.Text = grilla.Rows(fila).Cells(2).Value
                Me.txt_solicitante_domicilio.Text = grilla.Rows(fila).Cells(5).Value
                Me.txt_solicitante_apellido.Text = grilla.Rows(fila).Cells(3).Value
                Me.mtxt_solicitante_telefono.Text = grilla.Rows(fila).Cells(6).Value
                Me.mtxt_solicitante_nrodoc.Text = grilla.Rows(fila).Cells(1).Value
                Me.mtxt_solicitante_fechaNacimiento.Text = grilla.Rows(fila).Cells(4).Value
            Case 2
                Me.txt_empleado_legajo.Text = grilla.Rows(fila).Cells(0).Value
                Me.txt_empleado_legSup.Text = grilla.Rows(fila).Cells(4).Value
                Me.txt_empleado_nombre.Text = grilla.Rows(fila).Cells(1).Value
                Me.txt_empleado_fecha.Text = grilla.Rows(fila).Cells(3).Value
                Me.txt_empleado_ape.Text = grilla.Rows(fila).Cells(2).Value



        End Select
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim pestaña As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña
            Case 0
                Dim matricula As Integer = pedir_clave_numerica()
                Dim fila As Integer = Me.buscar_clave(matricula)
                If fila <> -1 Then
                    MsgBox("Matricula encontrada", vbOKOnly, "Resultado")
                    Me.llenar_tab_segunGrilla(fila)

                    For f As Integer = 0 To grilla.Rows.Count - 1
                        Dim num As Integer = Val(grilla.Rows(f).Cells(0).Value)
                        If num = matricula Then
                            grilla.Rows(f).DefaultCellStyle.BackColor = Color.Cyan
                            grilla.Rows(f).Selected = True
                        Else
                            grilla.Rows(f).DefaultCellStyle.BackColor = Color.White
                        End If
                    Next
                ElseIf matricula = -1 Then
                    Exit Sub
                Else
                    MsgBox("Matricula no encontrada", vbOKOnly, "Resultado")
                End If

            Case 1
                Dim doc As Integer
                Dim tdoc As Integer

                abrir_buscador(doc, tdoc)
                If Me.buscar_doc_tdoc(doc, tdoc) = 0 Then
                    MsgBox("Documento no encontrado", vbOKOnly, "Resultado")
                ElseIf Me.buscar_doc_tdoc(doc, tdoc) = 1 Then
                    MsgBox("Documento encontrado", vbOKOnly, "Resultado")
                End If

            Case 2
                Dim legajo As Integer = pedir_clave_numerica()
                Dim fila As Integer = Me.buscar_clave(legajo)
                If fila <> -1 Then
                    MsgBox("Legajo encontrado", vbOKOnly, "Resultado")
                    Me.llenar_tab_segunGrilla(fila)

                    For f As Integer = 0 To grilla.Rows.Count - 1
                        Dim num As Integer = Val(grilla.Rows(f).Cells(0).Value)
                        If num = legajo Then
                            grilla.Rows(f).DefaultCellStyle.BackColor = Color.Cyan
                            grilla.Rows(f).Selected = True
                        Else
                            grilla.Rows(f).DefaultCellStyle.BackColor = Color.White
                        End If
                    Next
                ElseIf legajo = -1 Then
                    Exit Sub
                Else
                    MsgBox("Legajo no encontrado", vbOKOnly, "Resultado")
                End If
        End Select
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Dim texto As String = ""
        Dim nom_Tabla As String = nombre_tabla_pestana()
        Dim pestaña As Integer = Me.tab_control.SelectedIndex
        Dim id_solicitante As Integer

        If validaciones_pestaña() Then
            texto = "UPDATE " & nom_Tabla & " SET "
            Select Case pestaña
                Case 0
                    texto += "nombre='" & Me.txt_abogado_nombre.Text & "', apellido='" & Me.txt_abogado_apellido.Text & "', telefono='" & Me.mtxt_abogado_telefono.Text & "', domicilio='" & Me.txt_abogado_domicilio.Text & "'"
                    texto += " WHERE matricula= " & Me.txt_abogado_matricula.Text
                Case 1
                    If Me.idSolicitante = -1 Then
                        id_solicitante = pedir_clave_numerica()
                    Else
                        id_solicitante = Me.idSolicitante
                    End If
                    texto += "numeroDocumento='" & Me.mtxt_solicitante_nrodoc.Text & "', apellido='" & Me.txt_solicitante_apellido.Text & "', nombre='" & Me.txt_solicitante_nombre.Text & "', telefono='" & Me.mtxt_solicitante_telefono.Text & "', domicilio='" & Me.txt_solicitante_domicilio.Text & "', tipo_Documento_idTipo_Documento='" & Me.cmb_solicitante_tipodoc.SelectedValue & "', fechaNacimiento='" & Me.mtxt_solicitante_fechaNacimiento.Text & "'"
                    texto += " WHERE idSolicitante= " & id_solicitante
                Case 2
                    texto += "Empleado_legajo=" & Me.txt_empleado_legSup.Text & ", Cargo_idCargo=" & Me.cmb_empleado_cargo.SelectedIndex + 1 & ", nombres='" & Me.txt_empleado_nombre.Text & "', apellido='" & Me.txt_empleado_ape.Text & "', fecha_Alta='" & Me.txt_empleado_fecha.Text & "'"
                    texto += " WHERE legajo= " & Me.txt_empleado_legajo.Text
                Case Else
                    Exit Sub
            End Select
            conexion._modificar(texto)
            Me.limpiar_tab()
            Me.cargar_Grilla()
        End If
    End Sub

    Private Function buscar_clave(ByVal clave As Integer) As Integer
        Dim c As Integer
        Dim pestaña As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña
            Case 0
                For c = 0 To Me.grilla.RowCount - 1
                    If (Me.grilla.Rows(c).Cells("matricula").Value = clave) Then
                        Return c
                        Exit Function
                    End If
                Next
                Return -1
            Case 2
                For c = 0 To Me.grilla.RowCount - 1
                    If (Me.grilla.Rows(c).Cells("Legajo Empleado").Value = clave) Then
                        Return c
                        Exit Function
                    End If
                Next
                If c = 0 Then
                    Return -2
                Else
                    Return -1
                End If
        End Select
    End Function

    Private Function buscar_doc_tdoc(ByVal dni As Integer, ByVal tdoc As Integer) As Integer
        Dim c As Integer
        If (dni = -1 Or tdoc = -1) Then
            Return 2
            Exit Function
        End If
        For c = 0 To Me.grilla.RowCount - 1
            If (Me.grilla.Rows(c).Cells("numeroDocumento").Value = dni) And (nombre_a_id(Me.grilla.Rows(c).Cells("tipodoc").Value) = tdoc) Then
                Return 1
                Exit Function
            End If
        Next
        Return 0
    End Function

    Private Sub abrir_buscador(ByRef rdoc2 As Integer, ByRef rtdoc2 As Integer)

        Dim doc2 As Integer
        Dim tdoc2 As Integer
        buscador = New buscar_doc_tipoDoc

        Dim result As DialogResult = buscador.ShowDialog(Me)

        doc2 = buscador.doc2
        tdoc2 = buscador.tdoc2 + 1
        rdoc2 = doc2
        rtdoc2 = tdoc2

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub grilla_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla.CellDoubleClick
        Me.llenar_tab_segunGrilla(e.RowIndex)
    End Sub

    Private Sub btn_empleado_nuevoCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_empleado_nuevoCargo.Click
        Dim texto As String = ""

        texto = InputBox("Inserte un nuevo cargo", "Nuevo Cargo")
        If texto <> "" Then
            conexion._consulta("INSERT INTO Cargo (nombre) VALUES ('" & texto & "')")
            Me.CargoTableAdapter.Fill(Me.PAV1DataSet.Cargo)
        End If

    End Sub

    Private Function nombre_a_id(ByVal nombre As String) As Integer

        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña_abm
            Case 1
                Select Case nombre
                    Case "DNI"
                        Return 1
                        Exit Function
                End Select
        End Select
    End Function

    Private Sub cmd_credito_obj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_creditos_objeto.Enter

        Dim tabla As New Data.DataTable

        frm_objeto = New frm_objeto

        Dim result As DialogResult = frm_objeto.ShowDialog(Me)

        'Trae Descripcion_Objeto
        Me.txt_creditos_objeto.Text = frm_objeto.pasar_descripcion_obj()
        If txt_creditos_objeto.Text = "" Then
        Else
            txt_creditos_objeto.Enabled = False
        End If

        'Trae el ID_Objeto
        tabla = frm_objeto.traer_id_objeto()
        Me.txt_creditos_idObjeto.Text = tabla.Rows(0)(0)

    End Sub

    Private Sub txt_creditos_idSolicitante_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_creditos_idSolicitante.Enter
        Dim consulta_solicitante As String = "SELECT Solicitante.idSolicitante, Solicitante.numeroDocumento, Solicitante.nombre, Solicitante.apellido, Solicitante.fechaNacimiento, Solicitante.domicilio, Solicitante.telefono, tipo_Documento.nombre AS tipodoc "
        consulta_solicitante += "FROM Solicitante INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento"
        Me.grilla.DataSource = conexion._consulta(consulta_solicitante)
    End Sub

    Private Sub txt_creditos_legajo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_creditos_legajo.Enter
        Dim consulta_empleado As String = "SELECT Empleado.legajo AS 'Legajo Empleado', Empleado.nombres AS 'Nombres', Empleado.apellido AS 'Apellido', Empleado.fecha_Alta AS 'Fecha Alta', Empleado.Empleado_legajo AS 'Legajo Superior', Cargo.nombre AS 'Cargo' "
        consulta_empleado += "FROM Empleado INNER JOIN Cargo ON Empleado.Cargo_idCargo = Cargo.idCargo"
        Me.grilla.DataSource = conexion._consulta(consulta_empleado)
    End Sub

    Private Sub txt_expediente_codCred_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_expediente_codCred.Enter

        Dim consulta_expediente As String = "SELECT Creditos.idCreditos AS [Codigo Credito], Creditos.monto AS [Monto], Creditos.fechaSolicitud AS [Fecha Solicitud], Creditos.fechaAprobacion AS [Fecha Aprobacion], Solicitante.nombre AS [Nombre Solicitante], Solicitante.apellido AS [Apellido Solicitante], tipo_Documento.nombre AS [Tipo Documento], Solicitante.numeroDocumento AS [Documento], Estado_Credito.nombre AS [ESTADO], Objeto.descripcion AS [Objeto] "
        consulta_expediente += "FROM Creditos INNER JOIN Solicitante ON Creditos.Solicitante_idSolicitante = Solicitante.idSolicitante "
        consulta_expediente += "INNER JOIN Objeto ON Creditos.Objeto_idObjeto = Objeto.idObjeto "
        consulta_expediente += "INNER JOIN Estado_Credito ON Creditos.Estado_Credito_idEstado_Credito = Estado_Credito.idEstado_Credito "
        consulta_expediente += "INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento "
        consulta_expediente += "WHERE Estado_Credito.nombre='DEUDA'"

        Me.grilla.DataSource = conexion._consulta(consulta_expediente)
    End Sub
    Private Sub txt_expediente_matAbCre_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_expediente_matAbCre.Enter, txt_expediente_matAbSol.Enter
        Dim consulta_abogado As String = "SELECT matricula AS [Matricula], nombre AS [Nombre], apellido AS [Apellido], domicilio AS [Domicilio], telefono AS [Telefono] FROM Abogado"
        Me.grilla.DataSource = conexion._consulta(consulta_abogado)
    End Sub


End Class

'Private Sub fecha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtxt_solicitante_fechaNacimiento.Validated
'    If sender.text <> "  -  -" Then
'        If Convert.ToInt32(sender.text.Substring(sender.text.Length - 4)) > 2014 Or Convert.ToInt32(sender.text.Substring(sender.text.Length - 4)) < 1900 Then
'            ' MsgBox("Año invalido", vbOKOnly + vbCritical, "Importante")
'            mtxt_solicitante_fechaNacimiento.BackColor = Color.OrangeRed
'            Exit Sub
'        End If
'    End If
'                       -----Sirve para resaltar el campo de un color si el contenido no es valido-----
'End Sub
