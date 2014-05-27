Imports System.Text.RegularExpressions

Public Class Validacion

    Private Const ERROR_FECHA As String = "Fecha invalida"
    Private Const ERROR_TELEFONO As String = "Ingrese un numero de telefono valido"
    Private Const ERROR_TIPODOC As String = "Seleccione un Tipo de Documento valido"
    Private Const ERROR_NUMDOC As String = "Documento debe tener 8 caracteres y no ser igual a 0"
    Private Const ERROR_LEGAJO As String = "Ingrese un legajo valido"
    Private Const ERROR_MATRICULA As String = "Ingrese una matricula valida"
    Private Const ERROR_CARGO As String = "Seleccione un Cargo valido"
    Private Const ERROR_ESTADO As String = "Seleccione un Estado de credito valido"
    Private Const ERROR_IDSOLICITANTE As String = "Ingrese un Codigo de Solicitante valido"
    Private Const ERROR_MONTO As String = "El monto debe ser mayor a 0"
    Private Const ERROR_CODCRED As String = "Ingrese un Codigo de Credito valido"
    Private Const ERROR_EXPEDIENTE As String = "Ingrese un numero de expediente valido"


    'Devolver mensajes de error y validar que no esten vacios en vez de usar booleaans?
    'O imprimimos por pantalla desde aca?


    Structure abogado
        Friend matricula As Integer
        Public nombres As String
        Public apellido As String
        Public telefono As String
        Public domicilio As String
    End Structure

    Structure solicitante
        Public numDoc As String
        Public tipoDoc As Integer
        Public nombres As String
        Public apellido As String
        Public telefono As String
        Public domicilio As String
        Public fecha_nacimiento As String
    End Structure

    Structure empleado
        Public legajo As Integer
        Public nombres As String
        Public apellido As String
        Public fecha_alta As String
        Public superior As Integer
        Public cargo As Integer
    End Structure

    Structure credito
        Public monto As Double
        Public fecha_solicitud As String
        Public fecha_aprobacion As String
        Public idSolicitante As Integer
        Public legajo As Integer
        Public estado As Integer
        Public idObjeto As Integer
        Public objeto_nombre As String
    End Structure

    Structure expediente
        Public numero As Integer
        Public codCred As Integer
        Public fecha_inicio As String
        Public matricula_crecor As Integer
        Public matricula_solicitante As Integer
        Public observacion As String
    End Structure

    Structure garantia
        Dim codCred As Integer
        Dim descripcion As String
        Dim monto As Double
        'Que hacemos con la documentacion?
    End Structure


    Friend Function _validar_campos_vacios() As Boolean
        Dim esteControl As System.Windows.Forms.Control

        For Each esteControl In frm_Menu.tab_control.SelectedTab.Controls        'Reviso cada campo y valido no vacio.
            If esteControl.Enabled = True Then
                If esteControl.Text = "" Then
                    MsgBox("Se deben llenar todos los campos", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
            End If
        Next

        Return True
    End Function

    Private Function _validar_fecha(ByVal fecha As String) As Boolean
        If IsDate(fecha) Then                                           'dd-mm-aaaa
            Dim año As Integer = Convert.ToInt32(fecha.Substring(6, 4)) '01 3 45 6 78910
            If año > 1900 And año <= 2014 Then
                Return True
                Exit Function
            End If
        End If
        Return False
    End Function

    Private Function _validar_numero_positivo(ByVal numero As Integer) As Boolean
        If numero > 0 Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Private Function _validar_existente(ByVal tabla_nombre As String, ByVal campo As String, ByVal clave As Integer) As Boolean 'True si existe, False si no
        Dim consulta As String = "SELECT * FROM " & tabla_nombre & " WHERE " & campo & "=" & clave
        Dim tabla_resultado As New Data.DataTable
        Dim conexion As New Conexion(frm_Menu.cadena_Conexion, conexion.motores.sqlserver)

        tabla_resultado = conexion._consulta(consulta)

        If tabla_resultado.Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function _validar_abogado(ByVal ab As abogado) As Boolean
        If _validar_numero_positivo(ab.matricula) Then
            Dim tel = Regex.Replace(ab.telefono, "[^0-9]", String.Empty)
            If tel.Length() = 12 Then
                Return True
            Else
                MsgBox(ERROR_TELEFONO, vbOKOnly + vbCritical, "Importante")
            End If
        Else
            MsgBox(ERROR_MATRICULA, vbOKOnly + vbCritical, "Importante")
        End If
        Return False
    End Function

    Public Function _validar_solicitante(ByVal sol As solicitante) As Boolean
        If _validar_campos_vacios() Then
            If sol.numDoc.ToString.Length = 8 And sol.numDoc <> 0 Then
                If _validar_numero_positivo(sol.tipoDoc) Then
                    Dim tel = Regex.Replace(sol.telefono, "[^0-9]", String.Empty)
                    If tel.Length() = 12 Then ' "(   )    -   -" Then
                        If _validar_fecha(sol.fecha_nacimiento) Then
                            Return True
                            Exit Function
                        Else
                            MsgBox(ERROR_FECHA, vbOKOnly + vbCritical, "Importante")
                        End If

                    Else
                        MsgBox(ERROR_TELEFONO, vbOKOnly + vbCritical, "Importante")
                    End If

                Else
                    MsgBox(ERROR_TIPODOC, vbOKOnly + vbCritical, "Importante")
                End If
            Else
                MsgBox(ERROR_NUMDOC, vbOKOnly + vbCritical, "Importante")
            End If
        End If
        Return False
    End Function

    Public Function _validar_empleado(ByVal emp As empleado) As Boolean
        If _validar_campos_vacios() Then
            If _validar_numero_positivo(emp.legajo) Then
                If _validar_fecha(emp.fecha_alta) Then
                    If _validar_numero_positivo(emp.superior) And _validar_existente("Empleado", "Legajo", emp.superior) Then
                        If _validar_numero_positivo(emp.cargo) Then
                            Return True
                            Exit Function
                        Else
                            MsgBox(ERROR_CARGO, vbOKOnly + vbCritical, "Importante")
                        End If
                    Else
                        MsgBox(ERROR_LEGAJO, vbOKOnly + vbCritical, "Importante")
                    End If
                Else
                    MsgBox(ERROR_FECHA, vbOKOnly + vbCritical, "Importante")
                End If
            Else
                MsgBox(ERROR_NUMDOC, vbOKOnly + vbCritical, "Importante")
            End If
        End If
        Return False
    End Function

    Public Function _validar_credito(ByVal cred As credito) As Boolean
        If _validar_campos_vacios() Then
            If _validar_numero_positivo(cred.monto) Then
                If _validar_fecha(cred.fecha_solicitud) Then                'Valido fecha aprobacion en el boton modificar.; NO, hacer nuevo metodo aca, validar modificacion credito.
                    If _validar_numero_positivo(cred.idSolicitante) And _validar_existente("Solicitante", "idSolicitante", cred.idSolicitante) Then    'VALIDAR QUE SELECCIONE UNO YA EXISTENTE
                        If _validar_numero_positivo(cred.legajo) And _validar_existente("Empleado", "legajo", cred.legajo) Then       'VALIDAR QUE SELECCIONE UNO YA EXISTENTE
                            If _validar_numero_positivo(cred.estado) Then
                                Return True                                 'No se valida el objeto.
                                Exit Function
                            Else
                                MsgBox(ERROR_ESTADO, vbOKOnly + vbCritical, "Importante")
                            End If
                        Else
                            MsgBox(ERROR_LEGAJO, vbOKOnly + vbCritical, "Importante")
                        End If
                    Else
                        MsgBox(ERROR_IDSOLICITANTE, vbOKOnly + vbCritical, "Importante")
                    End If
                Else
                    MsgBox(ERROR_FECHA, vbOKOnly + vbCritical, "Importante")
                End If
            Else
                MsgBox(ERROR_MONTO, vbOKOnly + vbCritical, "Importante")
            End If
        End If
        Return False
    End Function

    Public Function _validar_expediente(ByVal exp As expediente) As Boolean 'Validar que matriculas y codcred ya existan, metodo _validar_existente(nombre de campo a consultar)?
        If _validar_campos_vacios() Then
            If _validar_numero_positivo(exp.numero) Then    'No es autoincremental?
                If _validar_numero_positivo(exp.codCred) And _validar_existente("Creditos", "idCreditos", exp.codCred) Then
                    If _validar_fecha(exp.fecha_inicio) Then
                        If _validar_numero_positivo(exp.matricula_crecor) And _validar_existente("Abogado", "matricula", exp.matricula_crecor) Then
                            If _validar_numero_positivo(exp.matricula_solicitante) And _validar_existente("Abogado", "matricula", exp.matricula_solicitante) Then
                                Return True
                                Exit Function
                            Else
                                MsgBox(ERROR_MATRICULA, vbOKOnly + vbCritical, "Importante")
                            End If
                        Else
                            MsgBox(ERROR_MATRICULA, vbOKOnly + vbCritical, "Importante")
                        End If
                    Else
                        MsgBox(ERROR_FECHA, vbOKOnly + vbCritical, "Importante")
                    End If
                Else
                    MsgBox(ERROR_CODCRED, vbOKOnly + vbCritical, "Importante")
                End If
            Else
                MsgBox(ERROR_EXPEDIENTE, vbOKOnly + vbCritical, "Importante")   'No es autoincremental?
            End If
        End If
        Return False
    End Function

    Public Function _validar_garantia(ByVal gar As garantia) As Boolean
        If _validar_campos_vacios() Then
            If _validar_numero_positivo(gar.codCred) And _validar_existente("Creditos", "idCreditos", gar.codCred) Then
                If _validar_numero_positivo(gar.monto) Then
                    Return True
                    Exit Function
                Else
                    MsgBox(ERROR_MONTO, vbOKOnly + vbCritical, "Importante")
                End If
                MsgBox(ERROR_CODCRED, vbOKOnly + vbCritical, "Importante")
            End If
        End If
        Return False
    End Function

    'Private Function validaciones_pestaña() As Boolean
    '    Dim pestaña As Integer = Me.tab_control.SelectedIndex
    '    Dim esteControl As System.Windows.Forms.Control

    '    For Each esteControl In tab_control.SelectedTab.Controls        'Reviso cada campo y valido no vacio.
    '        If esteControl.Enabled = True Then
    '            If esteControl.Text = "" Then
    '                MsgBox("Se deben llenar todos los campos", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '        End If
    '    Next

    '    Select Case pestaña
    '        'Es Fecha?
    '        'CONFLICTO CON VALIDACION DE FECHAS DE SQLSERVER
    '        '12-31-2000 SQLSERVER
    '        '31-12-2000 VB.NET
    '        Case 0
    '            'Matricula negativa
    '            If Me.txt_abogado_matricula.Text < 1 Then
    '                MsgBox("La matricula debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '            'Telefono vacio
    '            If mtxt_abogado_telefono.Text = "(   )    -   -" Then
    '                MsgBox("Ingrese el numero de telefono", vbOKOnly + vbCritical, "Importante")
    '                mtxt_solicitante_telefono.Focus()
    '                Return False
    '                Exit Function
    '            End If
    '            'Telefono no lleno
    '            If mtxt_abogado_telefono.MaskCompleted = False Then 'mtxt_abogado_telefono.Text.Length < 17
    '                MsgBox("Numero de telefono invalido", vbOKOnly + vbCritical, "Importante")
    '                mtxt_solicitante_telefono.Focus()
    '                Return False
    '                Exit Function
    '            End If
    '        Case 1
    '            'Largo del numero de documento
    '            If mtxt_solicitante_nrodoc.MaskCompleted = False Then
    '                MsgBox("Documento invalido (Debe tener 8 caracteres)", vbOKOnly + vbCritical, "Importante")
    '                mtxt_solicitante_nrodoc.Focus()
    '                Return False
    '                Exit Function
    '            End If
    '            'Telefono vacio
    '            If mtxt_solicitante_telefono.Text = "(   )    -   -" Then
    '                MsgBox("Ingrese el numero de telefono", vbOKOnly + vbCritical, "Importante")
    '                mtxt_solicitante_telefono.Focus()
    '                Return False
    '                Exit Function
    '            End If
    '            'Telefono no lleno
    '            If mtxt_solicitante_telefono.Text.Length < 17 Then
    '                MsgBox("Numero de telefono invalido", vbOKOnly + vbCritical, "Importante")
    '                mtxt_solicitante_telefono.Focus()
    '                Return False
    '                Exit Function
    '            End If
    '            'Año entre 1900 y 2014?
    '            If Convert.ToInt32(mtxt_solicitante_fechaNacimiento.Text.Substring(mtxt_solicitante_fechaNacimiento.Text.Length - 4)) > 2014 Or Convert.ToInt32(mtxt_solicitante_fechaNacimiento.Text.Substring(mtxt_solicitante_fechaNacimiento.Text.Length - 4)) < 1900 Then
    '                MsgBox("Año invalido", vbOKOnly + vbCritical, "Importante")
    '                mtxt_solicitante_fechaNacimiento.Focus()
    '                Return False
    '                Exit Function
    '            End If
    '            'If IsDate(mtxt_solicitante_fechaNacimiento.Text) = False Then
    '            '    MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Importante")
    '            '    mtxt_solicitante_fechaNacimiento.Focus()
    '            'Return false
    '            '    Exit Sub
    '            'End If
    '        Case 2
    '            'Legajo negativo
    '            If Me.txt_empleado_legajo.Text < 1 Then
    '                MsgBox("El Legajo debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '            'Legajo sup negativa
    '            If Me.txt_empleado_legSup.Text < 1 Then
    '                MsgBox("El Legajo del superior debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '        Case 3
    '            'Monto negativo
    '            If Me.txt_creditos_monto.Text < 1 Then
    '                MsgBox("El Monto debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '            'Legajo negativo
    '            If Me.txt_creditos_legajo.Text < 1 Then
    '                MsgBox("El Legajo debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '            'Solicitante negativo
    '            If Me.txt_creditos_idSolicitante.Text < 1 Then
    '                MsgBox("El Codigo de Solicitante debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '            'Monto negativo
    '            If Me.txt_creditos_monto.Text < 1 Then
    '                MsgBox("El Monto debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '            'Existe legajo
    '            Dim clave As Integer = Me.txt_creditos_legajo.Text
    '            For f As Integer = 0 To grilla.Rows.Count - 1
    '                Dim num As Integer = Val(grilla.Rows(f).Cells(0).Value)
    '                If num = clave Then
    '                    grilla.Rows(f).DefaultCellStyle.BackColor = Color.Cyan
    '                    grilla.Rows(f).Selected = True
    '                Else
    '                    grilla.Rows(f).DefaultCellStyle.BackColor = Color.White
    '                End If
    '            Next
    '            'Existe idSolicitante
    '            clave = Me.txt_creditos_idSolicitante.Text
    '            For f As Integer = 0 To grilla.Rows.Count - 1
    '                Dim num As Integer = Val(grilla.Rows(f).Cells(0).Value)
    '                If num = clave Then
    '                    grilla.Rows(f).DefaultCellStyle.BackColor = Color.Cyan
    '                    grilla.Rows(f).Selected = True
    '                Else
    '                    grilla.Rows(f).DefaultCellStyle.BackColor = Color.White
    '                End If
    '            Next
    '        Case 4
    '            Dim expediente As Integer = Me.txt_expediente_numeroExp.Text
    '            Dim fila As Integer = Me.buscar_clave(expediente)

    '            If fila <> -1 Then
    '                MsgBox("Ya existe un expediente con el mismo valor")
    '                Return False
    '            End If

    '            'HACER CON EL ESTADO DEL CREDITO, SI = APROBADO.
    '            'Fecha aprobacion mas vieja que solicitud
    '            ' If DateTime.Compare(Me.mtxt_creditos_fAprobacion.Text, Me.txt_creditos_fSolicitud.Text) Then
    '            'End If

    '        Case 5
    '            'Monto negativo
    '            If Me.txt_garantia_monto.Text < 1 Then
    '                MsgBox("El Monto debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
    '                Return False
    '                Exit Function
    '            End If
    '    End Select
    '    Return True
    'End Function

End Class
