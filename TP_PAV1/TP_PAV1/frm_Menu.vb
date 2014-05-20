Imports System.Text.RegularExpressions

Public Class frm_Menu

    Dim cadena_Conexion As String = "Data Source=SALVADOR-PC\PAV1;Initial Catalog=PAV1;Integrated Security=True"
    Dim conexion As New Conexion(cadena_Conexion, conexion.motores.sqlserver)

    'Ambos id no son txt asi que necesito variables globales.
    Dim idSolicitante As Integer = -1
    Dim idCredito As Integer = -1

    Dim buscador As buscar_doc_tipoDoc 'Para busqueda Doc/TipoDoc
    Dim _combo As New combo     'Para carga combo
    Dim frm_objeto As frm_objeto 'Para cargar objeto


    'Botones y eventos de formulario.


    'Saliendo del formulario principal
    Private Sub frm_Menu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Quiere Cerrar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False  'Si la salida seleccionada es SI, el formulario se cierra'
        Else
            e.Cancel = True  'Si la salida seleccionada es NO, se omite la accion de cerrado'
        End If
    End Sub

    'Cuando se carga el formulario principal
    Private Sub frm_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tab_menu.Width = 1260  'Esto despues se borra, es para no tener la pestaña gigante por debajo de los controles en el diseñador
    End Sub

    'Boton borrar de los ABM
    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        Dim pestaña As Integer = Me.tab_control.SelectedIndex
        Dim id_clave As Integer

        Select Case pestaña 'En que pestaña de ABM estoy parado
            Case 0, 2
                id_clave = pedir_clave_numerica()   'Pido matricula/legajo

            Case 1
                If Me.idSolicitante = -1 Then  'Si no tengo el id por doble click en grilla lo pido.
                    id_clave = pedir_clave_numerica()
                Else
                    id_clave = Me.idSolicitante
                End If

            Case 3
                If Me.idCredito = -1 Then   'Si no tengo el id por doble click en grilla lo pido.
                    id_clave = Me.pedir_clave_numerica
                Else
                    id_clave = Me.idCredito
                End If

            Case Else
                Exit Sub
        End Select
        'Limpio campos, borro y recargo grilla
        Me.limpiar_tab()
        conexion._borrar(id_clave)
        Me.cargar_Grilla()

    End Sub

    'Boton buscar de los ABM
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click    'BUSCA TODO EN GRILLA, CAMBIAR ESO, CAMBIAR buscar_clave POR buscar_en_tabla
        Dim pestaña As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña   'Segun pestaña de ABM sobre la que estoy
            Case 0
                Dim matricula As Integer = pedir_clave_numerica()       'Pido matricula de abogado
                Dim fila As Integer = Me.buscar_clave(matricula)
                If fila <> -1 Then
                    MsgBox("Matricula encontrada", vbOKOnly, "Resultado")
                    Me.llenar_tab_segunGrilla(fila)                     'Si la encuentro cargo los boxes con la info.

                    For f As Integer = 0 To grilla.Rows.Count - 1       'Resalto esa fila.
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

            Case 1                  'SOLICITANTE BUSCAMOS POR ID O DOC/TDOC?
                Dim doc As Integer
                Dim tdoc As Integer

                abrir_buscador(doc, tdoc)
                If Me.buscar_doc_tdoc(doc, tdoc) = 0 Then
                    MsgBox("Documento no encontrado", vbOKOnly, "Resultado")
                ElseIf Me.buscar_doc_tdoc(doc, tdoc) = 1 Then
                    MsgBox("Documento encontrado", vbOKOnly, "Resultado")
                End If

            Case 2                  'Idem abogado
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
            Case 3              'Busco idCredito 
                Dim idCredito As Integer = pedir_clave_numerica()
                Dim fila As Integer = Me.buscar_clave(idCredito)
                If fila <> -1 Then
                    MsgBox("Credito encontrado", vbOKOnly, "Resultado")
                    Me.llenar_tab_segunGrilla(fila)

                    For f As Integer = 0 To grilla.Rows.Count - 1
                        Dim num As Integer = Val(grilla.Rows(f).Cells(0).Value)
                        If num = idCredito Then
                            grilla.Rows(f).DefaultCellStyle.BackColor = Color.Cyan
                            grilla.Rows(f).Selected = True
                        Else
                            grilla.Rows(f).DefaultCellStyle.BackColor = Color.White
                        End If
                    Next
                ElseIf idCredito = -1 Then
                    Exit Sub
                Else
                    MsgBox("Credito no encontrado", vbOKOnly, "Resultado")
                End If
        End Select
    End Sub

    'Boton modificar de los ABM
    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Dim texto As String = ""                                'Consulta que voy a hacer
        Dim nom_Tabla As String = nombre_tabla_pestana()        'Nombre de la tabla segun la pestaña sobre la que estoy
        Dim pestaña As Integer = Me.tab_control.SelectedIndex
        Dim id_clave As Integer

        If validaciones_pestaña() Then          'Si los campos estan llenados correctamente
            texto = "UPDATE " & nom_Tabla & " SET "
            Select Case pestaña
                Case 0
                    texto += "nombre='" & Me.txt_abogado_nombre.Text & "', apellido='" & Me.txt_abogado_apellido.Text & "', telefono='" & Me.mtxt_abogado_telefono.Text & "', domicilio='" & Me.txt_abogado_domicilio.Text & "'"
                    texto += " WHERE matricula= " & Me.txt_abogado_matricula.Text
                Case 1
                    If Me.idSolicitante = -1 Then  'Si no busco o hizo doble click en un solicitante pido el id
                        id_clave = pedir_clave_numerica()
                    Else
                        id_clave = Me.idSolicitante
                    End If
                    texto += "numeroDocumento='" & Me.mtxt_solicitante_nrodoc.Text & "', apellido='" & Me.txt_solicitante_apellido.Text & "', nombre='" & Me.txt_solicitante_nombre.Text & "', telefono='" & Me.mtxt_solicitante_telefono.Text & "', domicilio='" & Me.txt_solicitante_domicilio.Text & "', tipo_Documento_idTipo_Documento='" & Me.cmb_solicitante_tipodoc.SelectedValue & "', fechaNacimiento='" & Me.mtxt_solicitante_fechaNacimiento.Text & "'"
                    texto += " WHERE idSolicitante= " & id_clave
                Case 2
                    texto += "Empleado_legajo=" & Me.txt_empleado_legSup.Text & ", Cargo_idCargo=" & Me.cmb_empleado_cargo.SelectedIndex + 1 & ", nombres='" & Me.txt_empleado_nombre.Text & "', apellido='" & Me.txt_empleado_ape.Text & "', fecha_Alta='" & Me.txt_empleado_fecha.Text & "'"
                    texto += " WHERE legajo= " & Me.txt_empleado_legajo.Text
                Case 3
                    If Me.idCredito = -1 Then   'Idem solicitante
                        id_clave = pedir_clave_numerica()
                    Else
                        id_clave = Me.idCredito
                    End If

                    'HACER VARIABLE CONTENER VALIDAR_ESTADO_CREDITO
                    'SE PUEDE CONOCER EL ESTADO DEL CREDITO DE OTRA FORMA?

                    If validar_estado_credito(id_clave) = 2 Then  'Si credito=deuda solo puedo volver a aprobado (pago deuda), ninguna otra operacion
                        If Me.cmb_creditos_estadoCredito.SelectedIndex = 1 Then
                            texto += "Estado_Credito_idEstado_Credito=" & Me.cmb_creditos_estadoCredito.SelectedIndex
                        Else
                            MsgBox("Creditos en deuda solo pueden volver a aprobados")
                            Exit Sub
                        End If
                    ElseIf validar_estado_credito(id_clave) = 3 Then    'Si credito=rechazado no puedo hacer nada
                        MsgBox("No se pueden modificar creditos rechazados")
                        Exit Sub
                    ElseIf validar_estado_credito(id_clave) = 1 Then    'Si credito=aprobado solo puedo pasar a deuda
                        If Me.cmb_creditos_estadoCredito.SelectedIndex = 2 Then
                            texto += "Estado_Credito_idEstado_Credito=" & Me.cmb_creditos_estadoCredito.SelectedIndex
                        Else
                            MsgBox("Creditos aprobados solo pueden pasar a estado de Deuda")
                            Exit Sub
                        End If
                    Else
                        If Me.cmb_creditos_estadoCredito.SelectedIndex = 1 Then 'Si credito=pendiente 
                            If Me.mtxt_creditos_fAprobacion.MaskCompleted = True Then   'Si hay fecha de aprobacion ya se que paso a aprobado
                                texto += "monto= " & Me.txt_creditos_monto.Text & ", fechaAprobacion=" & Me.mtxt_creditos_fAprobacion.Text & ", Estado_Credito_idEstado_Credito=" & Me.cmb_creditos_estadoCredito.SelectedIndex
                            Else
                                MsgBox("Se debe llenar la fecha de aprobacion")
                                Exit Sub
                            End If
                        ElseIf Me.cmb_creditos_estadoCredito.SelectedIndex = 3 Then  'Paso a rechazado
                            texto += "Estado_Credito_idEstado_Credito=" & Me.cmb_creditos_estadoCredito.SelectedIndex
                        Else 'No puedo pasar a deuda desde pendiente
                            MsgBox("Creditos pendientes solo se puede actualizar a Aprobados o Rechazados")
                            Exit Sub
                        End If

                    End If
                    texto += " WHERE idCreditos=" & id_clave



                    'If validar_estado_credito(id_clave) <> 1 And validar_estado_credito(id_clave) <> 3 Then

                    '    texto += "monto= " & Me.txt_creditos_monto.Text
                    '    If Me.mtxt_creditos_fAprobacion.Enabled = True Then
                    '        texto += ", fechaAprobacion=" & Me.mtxt_creditos_fAprobacion.Text
                    '    End If
                    '    texto += ", Estado_Credito_idEstado_Credito=" & Me.cmb_creditos_estadoCredito.SelectedIndex
                    '    texto += " WHERE idCreditos=" & id_clave
                    '    Me.txt_creditos_objeto.Enabled = True
                    'End If
                Case Else
                    Exit Sub
            End Select
            'Modifico, limpio campos y recargo grilla
            conexion._modificar(texto)
            Me.limpiar_tab()
            Me.cargar_Grilla()
        End If
    End Sub

    'Boton salir de los ABM
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    'Boton guardar de los ABM
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim texto As String = ""         'Consulta a hacer
        Dim conid As Boolean             'Si es con ID la consulta
        Dim pestaña As Integer = Me.tab_control.SelectedIndex

        conexion.cambiar_Tabla(Me.nombre_tabla_pestana) 'Defino a que tabla me voy a conectar segun la pestaña, ES NECESARIO?

        If validaciones_pestaña() Then      'Si los campos estan cargados correctamente
            Select Case pestaña
                Case 0
                    Dim matricula As Integer = Me.txt_abogado_matricula.Text
                    Dim fila As Integer = Me.buscar_clave(matricula)        'Busco al abogado en la grilla
                    If fila <> -1 Then
                        MsgBox("Ya existe un abogado con la misma matricula")
                        Exit Sub
                    Else
                        texto = "matricula=" & Me.txt_abogado_matricula.Text & ", nombre=" & Me.txt_abogado_nombre.Text & ", apellido=" & Me.txt_abogado_apellido.Text & ", telefono= " & Me.mtxt_abogado_telefono.Text & ", domicilio= " & Me.txt_abogado_domicilio.Text
                        conid = True
                    End If
                    conexion._insertar(texto, conid)    'Inserto sin ID autoincremental (true)
                Case 1
                    Dim mtextbox As Integer
                    Int32.TryParse(mtxt_solicitante_nrodoc.Text, mtextbox)
                    If Me.buscar_doc_tdoc(mtextbox, cmb_solicitante_tipodoc.SelectedIndex + 1) = 1 Then 'Busco al solicitante en la grilla
                        MsgBox("Ya existe un solicitante con el mismo Documento y tipo Documento")
                        Exit Sub
                    Else
                        texto = "numeroDocumento=" & Me.mtxt_solicitante_nrodoc.Text & ", apellido=" & Me.txt_solicitante_apellido.Text & ", nombre=" & Me.txt_solicitante_nombre.Text & ", telefono= " & Me.mtxt_solicitante_telefono.Text & ", domicilio= " & Me.txt_solicitante_domicilio.Text & ", tipo_Documento_idTipo_Documento= " & Me.cmb_solicitante_tipodoc.SelectedValue & ", fechaNacimiento=" & Me.mtxt_solicitante_fechaNacimiento.Text
                        conid = False
                    End If
                    conexion._insertar(texto, conid)
                Case 2
                    If Me.buscar_clave(Me.txt_empleado_legSup.Text) = -1 Then   'Busco en GRILLA al legajo del superior
                        MsgBox("No existe ningun superior con esa matricula")
                        Exit Sub
                    Else
                        texto = "legajo=" & Me.txt_empleado_legajo.Text & ", Empleado_legajo=" & Me.txt_empleado_legSup.Text & ", Cargo_idCargo=" & Me.cmb_empleado_cargo.SelectedIndex + 1 & ", nombres=" & Me.txt_empleado_nombre.Text & ", apellido=" & Me.txt_empleado_ape.Text & ", fecha_Alta=" & Me.txt_empleado_fecha.Text
                        conid = True
                    End If
                    conexion._insertar(texto, conid)
                Case 3

                    'SACCAR VALIDACIONES AFUERA?
                    If Me.buscar_en_tabla(Me.txt_creditos_idSolicitante.Text, 2) = -1 Then
                        MsgBox("No existe ningun solicitante con ese codigo")
                        Me.txt_creditos_idSolicitante.Focus()
                        Exit Sub
                    End If
                    If Me.buscar_en_tabla(Me.txt_creditos_legajo.Text, 1) = -1 Then
                        MsgBox("No existe ningun empleado con ese legajo")
                        Me.txt_creditos_legajo.Focus()
                        Exit Sub
                    End If
                    If Me.cmb_creditos_estadoCredito.SelectedIndex <> 0 Then
                        MsgBox("Creditos nuevos solo pueden ser pendientes")
                        Me.cmb_creditos_estadoCredito.Focus()
                        Exit Sub
                    End If

                    'texto = "monto= " & Me.txt_creditos_monto.Text & ", fechaSolicitud=" & Me.txt_creditos_fSolicitud.Text & ", Solicitante_idSolicitante=" & Me.txt_creditos_idSolicitante.Text & ", Estado_Credito_idEstado_Credito=" & Me.cmb_creditos_estadoCredito.SelectedIndex & ", Empleado_legajo=" & Me.txt_creditos_legajo.Text & ", Objeto_idObjeto=" & Me.txt_creditos_idObjeto.Text

                    'Uso INSERT propio porque varios valores no son cargados y el insert de conexion no permite eso
                    texto = "INSERT INTO creditos (monto, fechaSolicitud, Solicitante_idSolicitante, Estado_Credito_idEstado_Credito, Empleado_legajo, Objeto_idObjeto) VALUES ("
                    texto += Me.txt_creditos_monto.Text & ", '" & Me.txt_creditos_fSolicitud.Text & "', " & Me.txt_creditos_idSolicitante.Text & ", " & Me.cmb_creditos_estadoCredito.SelectedIndex & ", " & Me.txt_creditos_legajo.Text & ", " & Me.txt_creditos_idObjeto.Text & ")"
                    conexion._modificar(texto)          'conexion._modificar() ejecuta SQL por nonquery.
                    Me.txt_creditos_objeto.Enabled = True

                Case 4
                    Dim tabla As New DataTable
                    Dim consulta As String = "SELECT (Estado_Credito_idEstado_Credito) FROM Creditos WHERE "
                    consulta += "idCreditos=" & Me.txt_expediente_codCred.Text
                    Dim valor As Integer
                    tabla = conexion._consulta(consulta)
                    valor = tabla.Rows(0)(0)

                    'texto = "INSERT INTO expediente (idExpediente, Estado_Credito_idEstado_Credito, abogado_matricula, observacion, fechaInicio, abogado_matriculaSol) VALUES ("
                    texto += "idExpediente=" & Me.txt_expediente_numeroExp.Text & ", Estado_Credito_idEstado_Credito=" & valor & ", abogado_matricula=" & Me.txt_expediente_matAbCre.Text & ", observacion=" & Me.txt_expediente_observacion.Text & ", fechaInicio=" & Me.txt_expediente_fechaInicio.Text & ", abogado_matriculaSol=" & Me.txt_expediente_matAbSol.Text
                    '   MsgBox(texto)

                    Dim expediente As Integer = Me.txt_expediente_numeroExp.Text
                    Dim fila As Integer = Me.buscar_clave(expediente)
                    If fila <> -1 Then
                        MsgBox("Ya existe un expediente con el mismo valor")

                    Else
                        conid = True
                        conexion._insertar(texto, conid)
                    End If

                Case 5
                    If Me.buscar_en_tabla(Me.txt_garantia_idCredito.Text, 3) = -1 Then
                        MsgBox("No existe ningun credito con ese Codigo de Credito")
                        Me.txt_creditos_idSolicitante.Focus()
                        Exit Sub
                    End If

                    texto = "INSERT INTO garantia (descripcion, valorMonetario, Creditos_idCreditos) VALUES ('"
                    texto += Me.txt_garantia_descripcion.Text & "', " & Me.txt_garantia_monto.Text & ", " & Me.txt_garantia_idCredito.Text & ")"
                    conexion._modificar(texto)

                Case Else
                    Exit Sub
            End Select
            'Recargo grilla, limpio campos.
            cargar_Grilla()
            limpiar_tab()

        End If
    End Sub

    'Boton nuevo cargo de pestaña empleado
    Private Sub btn_empleado_nuevoCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_empleado_nuevoCargo.Click
        Dim texto As String = ""

        texto = InputBox("Inserte un nuevo cargo", "Nuevo Cargo")   'Recibo nuevo cargo
        If texto <> "" Then
            conexion._consulta("INSERT INTO Cargo (nombre) VALUES ('" & texto & "')") 'Inserto nuevo cargo en BD
            Me.CargoTableAdapter.Fill(Me.PAV1DataSet.Cargo) 'Recargo combo cargo.
        End If

    End Sub


    'Validaciones


    'Validaciones de campos no vacios, valores correctos, etc.
    Private Function validaciones_pestaña() As Boolean
        Dim pestaña As Integer = Me.tab_control.SelectedIndex
        Dim esteControl As System.Windows.Forms.Control

        For Each esteControl In tab_control.SelectedTab.Controls        'Reviso cada campo y valido no vacio.
            If esteControl.Enabled = True Then
                If esteControl.Text = "" Then
                    MsgBox("Se deben llenar todos los campos", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
            End If
        Next

        Select Case pestaña
            'Es Fecha?
            'CONFLICTO CON VALIDACION DE FECHAS DE SQLSERVER
            '12-31-2000 SQLSERVER
            '31-12-2000 VB.NET
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
                'If IsDate(mtxt_solicitante_fechaNacimiento.Text) = False Then
                '    MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Importante")
                '    mtxt_solicitante_fechaNacimiento.Focus()
                'Return false
                '    Exit Sub
                'End If
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
            Case 4
                Dim expediente As Integer = Me.txt_expediente_numeroExp.Text
                Dim fila As Integer = Me.buscar_clave(expediente)

                If fila <> -1 Then
                    MsgBox("Ya existe un expediente con el mismo valor")
                    Return False
                End If

                'HACER CON EL ESTADO DEL CREDITO, SI = APROBADO.
                'Fecha aprobacion mas vieja que solicitud
                ' If DateTime.Compare(Me.mtxt_creditos_fAprobacion.Text, Me.txt_creditos_fSolicitud.Text) Then
                'End If

            Case 5
                'Monto negativo
                If Me.txt_garantia_monto.Text < 1 Then
                    MsgBox("El Monto debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
        End Select
        Return True
    End Function

    'No permito ingresar letras en el textbox.
    Private Sub numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_abogado_matricula.KeyPress, txt_empleado_legajo.KeyPress, txt_empleado_legSup.KeyPress, txt_creditos_idSolicitante.KeyPress, txt_creditos_legajo.KeyPress, txt_creditos_monto.KeyPress
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

    'No permito ingresar numeros en el textbox.
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


    'Busquedas


    'Obtengo el estado del credito pasado por parametro.
    Private Function validar_estado_credito(ByVal clave As Integer) As Integer

        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        Dim valor As Integer
        Dim resultado As Integer = -1

        consulta = "SELECT * FROM creditos WHERE idCreditos=" & clave

        tabla = conexion._consulta(consulta)

        If tabla.Rows.Count = 1 Then
            valor = tabla.Rows(0)(5)
            resultado = valor

        End If
        Return resultado
    End Function

    'Busco por clave primaria en la grilla.
    Private Function buscar_clave(ByVal clave As Integer) As Integer   'NO VA MA
        Dim c As Integer
        Dim pestaña As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña
            Case 0
                For c = 0 To Me.grilla.RowCount - 1
                    If (Me.grilla.Rows(c).Cells("Matricula").Value = clave) Then
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
            Case 3
                For c = 0 To Me.grilla.RowCount - 1
                    If (Me.grilla.Rows(c).Cells("Codigo Credito").Value = clave) Then
                        Return c
                        Exit Function
                    End If
                Next
                Return -1
            Case 4
                For c = 0 To Me.grilla.RowCount - 1
                    If (Me.grilla.Rows(c).Cells("Número Expediente").Value = clave) Then
                        Return c
                        Exit Function
                    End If
                Next
                Return -1


        End Select
    End Function

    'Busco el documento y tipo de documento pasado por parametro, en grilla.
    Private Function buscar_doc_tdoc(ByVal dni As Integer, ByVal tdoc As Integer) As Integer
        Dim c As Integer
        If (dni = -1 Or tdoc = -1) Then
            Return 2
            Exit Function
        End If
        For c = 0 To Me.grilla.RowCount - 1
            If (Me.grilla.Rows(c).Cells("numeroDocumento").Value = dni) And (nombre_a_id(Me.grilla.Rows(c).Cells("tipodoc").Value) = tdoc) Then   'ARREGLAR ESTO.
                Return 1
                Exit Function
            End If
        Next
        Return 0
        'Return, 2=parametros invalidos, 0= no se encontro, 1=se encontro.
    End Function

    'Abro el formulario para pedir Doc y TipoDoc
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

    'Busco por consulta un valor, en una tabla elegida por parametro.
    Private Function buscar_en_tabla(ByVal clave As Integer, ByVal codigo As Integer) As Integer   'SE PUEDE HACER MAS GENERICO?

        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        Dim resultado As Integer = -1

        consulta = "SELECT * FROM "

        Select Case codigo
            'Case 0 'PARA ABOGADO
            Case 1 'Empleado    'DEBERIA SER EL 2
                consulta += "Empleado WHERE legajo=" & clave
            Case 2 'Busco el solicitante    'DEBERIA SE EL 1
                consulta += "Solicitante WHERE idSolicitante=" & clave
            Case 3 'Busco el Credito
                consulta += "Creditos WHERE idCreditos=" & clave
                '4=expediente, 5=garantias
        End Select
        tabla = conexion._consulta(consulta)

        If tabla.Rows.Count = 1 Then
            resultado = 1
        End If

        Return resultado
    End Function

    'Solicito clave primaria segun pestaña
    Private Function pedir_clave_numerica() As Integer
        Dim clave As Integer
        Dim resultado As String = ""
        Dim mensaje As String = ""
        Dim titulo As String = ""
        Dim valido As Boolean = False
        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña_abm 'Defino el mensaje a mostrar segun la pestaña
            Case 0
                mensaje = "Ingrese Matricula a buscar"
                titulo = "Matricula"
            Case 1
                mensaje = "Ingrese Codigo de Solicitante a buscar"
                titulo = "Codigo de Solicitante"
            Case 2
                mensaje = "Ingrese Legajo a buscar"
                titulo = "Legajo"
            Case 3
                mensaje = "Ingrese Codigo de Credito a buscar"
                titulo = "Codigo de Credito"
        End Select

        While valido = False 'Validar que ingrese un valor correcto
            resultado = InputBox(mensaje, titulo)
            If resultado = "" Then
                valido = True
            ElseIf IsNumeric(resultado) Then
                clave = Convert.ToInt32(resultado)
                valido = True
            End If
        End While

        If clave > 0 Then 'Si la clave es > 0 la devuelvo
            Return clave
        End If
        Return -1

    End Function


    'Visual & Interfaz


    'Limpio ComboBox, TextBox y MaskedTextBox
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

    'Cargar la grilla con los valores segun la pestaña
    Private Sub cargar_Grilla()

        'HACER 1 SOLO CONSULTA, DEFINIRLO EN EL CASE.

        Dim consulta_abogado As String = "SELECT matricula AS [Matricula], nombre AS [Nombres], apellido AS [Apellido], domicilio AS [Domicilio], telefono AS [Telefono] FROM Abogado"

        Dim consulta_solicitante As String = "SELECT Solicitante.idSolicitante AS [Codigo Solicitante], Solicitante.numeroDocumento AS [Documento], tipo_Documento.nombre AS [Tipo Documento], Solicitante.nombre AS [Nombres], Solicitante.apellido AS [Apellido], Solicitante.fechaNacimiento AS [Fecha Nacimiento], Solicitante.domicilio AS [Domicilio], Solicitante.telefono AS [Telefono] "
        consulta_solicitante += "FROM Solicitante INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento"

        Dim consulta_empleado As String = "SELECT Empleado.legajo AS [Legajo Empleado], Empleado.nombres AS [Nombres], Empleado.apellido AS [Apellido], Empleado.fecha_Alta AS [Fecha Alta], Empleado.Empleado_legajo AS [Legajo Superior], Cargo.nombre AS [Cargo] "
        consulta_empleado += "FROM Empleado INNER JOIN Cargo ON Empleado.Cargo_idCargo = Cargo.idCargo"

        Dim consulta_credito As String = "SELECT Creditos.idCreditos AS [Codigo Credito], Creditos.monto AS [Monto], Creditos.fechaSolicitud AS [Fecha Solicitud], Creditos.fechaAprobacion AS [Fecha Aprobacion], Solicitante.nombre AS [Nombre Solicitante], Solicitante.apellido AS [Apellido Solicitante], tipo_Documento.nombre AS [Tipo Documento], Solicitante.numeroDocumento AS [Documento], Estado_Credito.nombre AS [ESTADO], Objeto.descripcion AS [Objeto], Empleado.legajo AS [Legajo Empleado], Empleado.nombres AS [Nombre Empleado], Empleado.apellido AS [Apellido Empleado] "
        consulta_credito += "FROM Creditos INNER JOIN Solicitante ON Creditos.Solicitante_idSolicitante = Solicitante.idSolicitante "
        consulta_credito += "INNER JOIN Objeto ON Creditos.Objeto_idObjeto = Objeto.idObjeto "
        consulta_credito += "INNER JOIN Estado_Credito ON Creditos.Estado_Credito_idEstado_Credito = Estado_Credito.idEstado_Credito "
        consulta_credito += "INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento "
        consulta_credito += "INNER JOIN Empleado ON Creditos.Empleado_legajo = Empleado.legajo "

        Dim consulta_expediente = "SELECT Expediente.idExpediente AS [Número Expediente], Expediente.fechaInicio AS [Fecha Inicio], Expediente.fechaEntrega AS [Fecha Entrega], Expediente.fechaDevolucion AS [Fecha Devolucion], Estado_Credito.nombre AS [Estado Crédito], Abogado.matricula AS [Matricula Abogado], Abogado.nombre AS [Nombre Abogado], Abogado.apellido AS [Apellido Abogado], Ab2.matricula AS [Matricula Abogado Solicitante], Ab2.nombre AS [Nombre Abogado Solicitante], Ab2.apellido AS [Apellido Abogado Solicitante] "
        consulta_expediente += "FROM Expediente INNER JOIN"
        consulta_expediente += " Estado_Credito ON Expediente.Estado_Credito_idEstado_Credito = Estado_Credito.idEstado_Credito INNER JOIN"
        consulta_expediente += " Abogado ON Expediente.abogado_matricula = Abogado.matricula "
        consulta_expediente += "INNER JOIN Abogado Ab2 ON Expediente.abogado_matriculaSol = Ab2.matricula "

        Dim consulta_garantia = "SELECT Garantia.descripcion, Garantia.valorMonetario, Creditos.idCreditos, Creditos.monto, Solicitante.nombre, Solicitante.apellido, Solicitante.idSolicitante"
        consulta_garantia += " FROM Creditos INNER JOIN Garantia ON Creditos.idCreditos = Garantia.Creditos_idCreditos INNER JOIN Solicitante ON Creditos.Solicitante_idSolicitante = Solicitante.idSolicitante"


        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex
        Select Case pestaña_abm
            Case 0
                Me.grilla.DataSource = conexion._consulta(consulta_abogado)
            Case 1
                Me.grilla.DataSource = conexion._consulta(consulta_solicitante)
            Case 2
                Me.grilla.DataSource = conexion._consulta(consulta_empleado)
            Case 3
                Me.grilla.DataSource = conexion._consulta(consulta_credito)
            Case 4
                Me.grilla.DataSource = conexion._consulta(consulta_expediente)
            Case 5
                Me.grilla.DataSource = conexion._consulta(consulta_garantia)
        End Select

    End Sub

    'Lleno los campos segun valores de la grilla.
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
            Case 3
                Dim tabla As New Data.DataTable
                tabla = conexion._consulta("SELECT * FROM Creditos WHERE idCreditos=" & Me.idCredito)

                Me.idCredito = grilla.Rows(fila).Cells(0).Value
                Me.txt_creditos_fSolicitud.Text = grilla.Rows(fila).Cells(2).Value
                Me.txt_creditos_idObjeto.Text = tabla.Rows(0)("Objeto_idObjeto")
                Me.txt_creditos_idSolicitante.Text = tabla.Rows(0)("Solicitante_idSolicitante")                Me.txt_creditos_legajo.Text = tabla.Rows(0)("Empleado_legajo")
                Me.txt_creditos_monto.Text = grilla.Rows(fila).Cells(1).Value
                Me.txt_creditos_objeto.Text = grilla.Rows(fila).Cells(9).Value

                If IsDBNull(grilla.Rows(fila).Cells(3).Value) = False Then
                    Me.mtxt_creditos_fAprobacion.Text = grilla.Rows(fila).Cells(3).Value
                End If
                Me.cmb_creditos_estadoCredito.SelectedIndex = tabla.Rows(0)("Estado_Credito_idEstado_Credito")
        End Select
    End Sub

    'Muestro grilla y botones.
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


    'Logica


    'Segun en que pestaña estoy, que tabla accedo
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
            Case 4
                nom_Tabla = "expediente"
            Case 5
                nom_Tabla = "garantia"
            Case Else
                nom_Tabla = "ERROR"
        End Select
        Return nom_Tabla
    End Function

    'Acciones al cambiar de una pestaña a otra (Menu/ABM)
    Private Sub cambio_Pestaña(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_menu.Selected, tab_control.Selected
        Dim pestaña_menu As Integer = Me.tab_menu.SelectedIndex
        Dim pestaña_abm As Integer = Me.tab_control.SelectedIndex

        Select Case pestaña_menu
            Case 0
                Me.mostrar_Interfaz(False) 'Escondo grilla y botones.
            Case 1
                Me.mostrar_Interfaz(True) 'Muestro grilla y botones.
                Select Case pestaña_abm
                    Case 0
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.cargar_Grilla()
                    Case 1
                        Me.conexion._tabla = "tipo_documento"
                        Me._combo.cargar(Me.cmb_solicitante_tipodoc, Me.conexion.leo_tabla())
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.cargar_Grilla()
                    Case 2
                        Me.limpiar_tab()
                        Me.conexion._tabla = "cargo"
                        Me._combo.cargar(Me.cmb_empleado_cargo, Me.conexion.leo_tabla())
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.cargar_Grilla()
                        txt_empleado_fecha.Text = DateTime.Now().ToString("MM-dd-yyyy")   'ANTES ERA ("dd-MM-yyyy"), VER TIPO DATE SQLSERVER.
                    Case 3
                        Me.limpiar_tab()
                        Me.conexion._tabla = "Estado_Credito"
                        Me._combo.cargar(Me.cmb_creditos_estadoCredito, Me.conexion.leo_tabla())
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.cargar_Grilla()
                        txt_creditos_fSolicitud.Text = DateTime.Now().ToString("MM-dd-yyyy")    'ANTES ERA ("dd-MM-yyyy"), VER TIPO DATE SQLSERVER.

                        'Campos visibles/accesibles al cargar la pestaña
                        txt_creditos_fSolicitud.Enabled = False
                        txt_creditos_idObjeto.Visible = False
                        mtxt_creditos_fAprobacion.Enabled = False
                        txt_creditos_idObjeto.Enabled = False
                    Case 4
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.txt_expediente_codCred.Enabled = True            'PREGUNTAR QUE HACE
                        Me.cargar_Grilla()
                    Case 5
                        conexion.cambiar_Tabla(Me.nombre_tabla_pestana)
                        Me.limpiar_tab()
                        Me.cargar_Grilla()
                End Select
            Case Else
                Exit Sub
        End Select
    End Sub

    'Evento al hacer doble click en una celda en la grilla.
    Private Sub grilla_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla.CellDoubleClick
        Me.llenar_tab_segunGrilla(e.RowIndex)
    End Sub

    'Abro formulario de ingreso de objetos al llegar al TextBox objeto en creditos.
    Private Sub txt_creditos_objeto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_creditos_objeto.Enter

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

    'Recargo grilla correspondiente a la pestaña al salir de ciertos TextBox
    Private Sub txt_creditos_idSolicitante_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_creditos_idSolicitante.Validated, txt_creditos_legajo.Validated, txt_expediente_codCred.Validated, txt_expediente_matAbCre.Validated, txt_expediente_matAbSol.Validated, txt_garantia_idCredito.Validated
        Me.cargar_Grilla()
    End Sub

    'Cargo grilla correspondiente al llegar al TextBox idSolicitante en creditos.
    Private Sub txt_creditos_idSolicitante_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_creditos_idSolicitante.Enter
        Dim consulta_solicitante As String = "SELECT Solicitante.idSolicitante, Solicitante.numeroDocumento, Solicitante.nombre, Solicitante.apellido, Solicitante.fechaNacimiento, Solicitante.domicilio, Solicitante.telefono, tipo_Documento.nombre AS tipodoc "
        consulta_solicitante += "FROM Solicitante INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento"
        Me.grilla.DataSource = conexion._consulta(consulta_solicitante)
    End Sub

    'Cargo grilla correspondiente al llegar al TextBox legajo en creditos.
    Private Sub txt_creditos_legajo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_creditos_legajo.Enter
        Dim consulta_empleado As String = "SELECT Empleado.legajo AS 'Legajo Empleado', Empleado.nombres AS 'Nombres', Empleado.apellido AS 'Apellido', Empleado.fecha_Alta AS 'Fecha Alta', Empleado.Empleado_legajo AS 'Legajo Superior', Cargo.nombre AS 'Cargo' "
        consulta_empleado += "FROM Empleado INNER JOIN Cargo ON Empleado.Cargo_idCargo = Cargo.idCargo"
        Me.grilla.DataSource = conexion._consulta(consulta_empleado)
    End Sub

    'Cargo grilla correspondiente al llegar al TextBox codCred en Expediente.
    Private Sub txt_expediente_codCred_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_expediente_codCred.Enter

        Dim consulta_expediente As String = "SELECT Creditos.idCreditos AS [Codigo Credito], Creditos.monto AS [Monto], Creditos.fechaSolicitud AS [Fecha Solicitud], Creditos.fechaAprobacion AS [Fecha Aprobacion], Solicitante.nombre AS [Nombre Solicitante], Solicitante.apellido AS [Apellido Solicitante], tipo_Documento.nombre AS [Tipo Documento], Solicitante.numeroDocumento AS [Documento], Estado_Credito.nombre AS [ESTADO], Objeto.descripcion AS [Objeto] "
        consulta_expediente += "FROM Creditos INNER JOIN Solicitante ON Creditos.Solicitante_idSolicitante = Solicitante.idSolicitante "
        consulta_expediente += "INNER JOIN Objeto ON Creditos.Objeto_idObjeto = Objeto.idObjeto "
        consulta_expediente += "INNER JOIN Estado_Credito ON Creditos.Estado_Credito_idEstado_Credito = Estado_Credito.idEstado_Credito "
        consulta_expediente += "INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento "
        consulta_expediente += "WHERE Estado_Credito.nombre='DEUDA'"

        Me.grilla.DataSource = conexion._consulta(consulta_expediente)
    End Sub

    'Cargo grilla correspondiente al llegar a los TextBox matricula en Expediente.
    Private Sub txt_expediente_matAbCre_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_expediente_matAbCre.Enter, txt_expediente_matAbSol.Enter
        Dim consulta_abogado As String = "SELECT matricula AS [Matricula], nombre AS [Nombre], apellido AS [Apellido], domicilio AS [Domicilio], telefono AS [Telefono] FROM Abogado"
        Me.grilla.DataSource = conexion._consulta(consulta_abogado)
    End Sub

    'Habilito/Deshabilito campos segun seleccion del Combo Estado credito en creditos.
    Private Sub cmb_creditos_estadoCredito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_creditos_estadoCredito.SelectedIndexChanged

        If Me.cmb_creditos_estadoCredito.SelectedIndex = 1 Then
            Me.mtxt_creditos_fAprobacion.Enabled = True
            Me.txt_creditos_objeto.Enabled = False
            Me.txt_creditos_legajo.Enabled = False
            Me.txt_creditos_idSolicitante.Enabled = False
            '    Me.txt_creditos_monto.Enabled = False
            'Me.txt_creditos_objeto.Text = ""
            'Me.txt_creditos_legajo.Text = ""
            'Me.txt_creditos_idSolicitante.Text = ""
            '' Me.txt_creditos_monto.Text = ""
        End If
        If Me.cmb_creditos_estadoCredito.SelectedIndex = 0 Then
            Me.mtxt_creditos_fAprobacion.Enabled = False
            Me.mtxt_creditos_fAprobacion.Clear()
            Me.txt_creditos_objeto.Enabled = True
            Me.txt_creditos_legajo.Enabled = True
            Me.txt_creditos_idSolicitante.Enabled = True
            Me.txt_creditos_monto.Enabled = True
        End If
        If Me.cmb_creditos_estadoCredito.SelectedIndex = 2 Or Me.cmb_creditos_estadoCredito.SelectedIndex = 3 Then
            Me.mtxt_creditos_fAprobacion.Enabled = False
            Me.mtxt_creditos_fAprobacion.Clear()
            Me.txt_creditos_objeto.Enabled = False
            Me.txt_creditos_legajo.Enabled = False
            Me.txt_creditos_idSolicitante.Enabled = False
            Me.txt_creditos_monto.Enabled = False
            'Me.txt_creditos_objeto.Text = ""
            'Me.txt_creditos_legajo.Text = ""
            'Me.txt_creditos_idSolicitante.Text = ""
            'Me.txt_creditos_monto.Text = ""
        End If
    End Sub

    'Cargo grilla correspondiente al llegar al TextBox id Credito en Garantias.
    Private Sub txt_garantia_idCredito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_garantia_idCredito.Enter

        'Solo los creditos con estado Pendiente

        Dim consulta_garantia As String = "SELECT Creditos.idCreditos AS [Codigo Credito], Creditos.monto AS [Monto], Creditos.fechaSolicitud AS [Fecha Solicitud], Creditos.fechaAprobacion AS [Fecha Aprobacion], Solicitante.nombre AS [Nombre Solicitante], Solicitante.apellido AS [Apellido Solicitante], tipo_Documento.nombre AS [Tipo Documento], Solicitante.numeroDocumento AS [Documento], Estado_Credito.nombre AS [ESTADO], Objeto.descripcion AS [Objeto] "
        consulta_garantia += "FROM Creditos INNER JOIN Solicitante ON Creditos.Solicitante_idSolicitante = Solicitante.idSolicitante "
        consulta_garantia += "INNER JOIN Objeto ON Creditos.Objeto_idObjeto = Objeto.idObjeto "
        consulta_garantia += "INNER JOIN Estado_Credito ON Creditos.Estado_Credito_idEstado_Credito = Estado_Credito.idEstado_Credito "
        consulta_garantia += "INNER JOIN tipo_Documento ON Solicitante.tipo_Documento_idTipo_Documento = tipo_Documento.idTipo_Documento "
        consulta_garantia += "WHERE Estado_Credito.nombre='PENDIENTE'"

        Me.grilla.DataSource = conexion._consulta(consulta_garantia)
    End Sub


    'Otros


    'REVISAR.
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

    'No va esto:
    'Private Sub txt_expediente_observacion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_expediente_observacion.Enter
    '    Me.cargar_Grilla()
    'End Sub

End Class

'Private Sub fecha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtxt_solicitante_fechaNacimiento.Validated
'    If sender.text <> "  -  -" Then
'        If Convert.ToInt32(sender.text.Substring(sender.text.Length - 4)) > 2014 Or Convert.ToInt32(sender.text.Substring(sender.text.Length - 4)) < 1900 Then
'            ' MsgBox("Año invalido", vbOKOnly + vbCritical, "Importante")

'            Exit Sub
'        End If
'    End If
'                       -----Sirve para resaltar el campo de un color si el contenido no es valido-----
'End Sub
