Public Class Conexion

    Enum tipo_conexion  'para transacciones o inserciones simples
        transaccion
        simple
    End Enum

    Enum motores
        sqlserver
        access
    End Enum

    Enum estado_transaccion 'para determinar resultado de transaccion
        _ok
        _error
    End Enum

    Dim conexion As New Object
    Dim cmd As New Object
    Dim str_conexion As String
    Dim motor As motores = motores.access
    Dim nom_tabla As String = ""

    'manejo de transacciones
    Dim configurar_conexion As tipo_conexion = tipo_conexion.simple
    Dim transaccion As New Object
    Dim control_transaccion As estado_transaccion = estado_transaccion._ok


    Public Property _cadenaConexion() As String
        Get
            Return Me.str_conexion
        End Get
        Set(ByVal valor As String)
            Me.str_conexion = valor
        End Set
    End Property

    Public Property _tabla() As String
        Get
            Return Me.nom_tabla
        End Get
        Set(ByVal value As String)
            Me.nom_tabla = value
        End Set
    End Property

    Private Sub _conectarMotor(ByVal _motor As motores)
        Select Case _motor
            Case motores.access
                conexion = New Data.OleDb.OleDbConnection
                cmd = New Data.OleDb.OleDbCommand
            Case motores.sqlserver
                conexion = New Data.SqlClient.SqlConnection
                cmd = New Data.SqlClient.SqlCommand
        End Select
    End Sub

    Public Sub New()
        _conectarMotor(Me.motor)
    End Sub

    Public Sub New(ByVal _CadenaConexion As String, ByVal _MotorBaseDatos As motores)
        Me.str_conexion = _CadenaConexion
        Me.motor = _MotorBaseDatos
        _conectarMotor(Me.motor)
    End Sub

    Public Sub New(ByVal _CadenaConexion As String, ByVal _NombreTabla As String, ByVal _MotorBaseDatos As motores)
        Me.str_conexion = _CadenaConexion
        Me.nom_tabla = _NombreTabla
        Me.motor = _MotorBaseDatos
        _conectarMotor(Me.motor)
    End Sub

    Public Sub New(ByVal _MotorBaseDatos As motores, ByVal _NombreTabla As String)
        Me.nom_tabla = _NombreTabla
        Me.motor = _MotorBaseDatos
        _conectarMotor(Me.motor)
    End Sub

    Public Sub New(ByVal _MotorBaseDatos As motores)
        Me.motor = _MotorBaseDatos
        _conectarMotor(Me.motor)
    End Sub

    'Public Sub New(ByVal _NombreTabla As String)
    '    Me.nom_tabla = _NombreTabla
    '    conexion = New Data.OleDb.OleDbConnection
    '    cmd = New Data.OleDb.OleDbCommand
    'End Sub

    Private Sub _conectar()

        If Me.conexion.State.ToString() <> "Open" Then
            Me.conexion.ConnectionString = Me.str_conexion
            Me.conexion.Open()
            Me.cmd.Connection = conexion
            Me.cmd.CommandType = CommandType.Text

            If Me.configurar_conexion = tipo_conexion.transaccion Then
                Me.transaccion = Me.conexion.BeginTransaction()
                Me.cmd.Transaction = Me.transaccion
            End If
        End If

    End Sub

    'Manejo de transacciones
    Public Sub _iniciar_conexion_con_transaccion()
        Me.configurar_conexion = tipo_conexion.transaccion
        Me.control_transaccion = estado_transaccion._ok
    End Sub

    Public Function _finalizar_conexio_con_transaccion() As estado_transaccion
        If Me.control_transaccion = estado_transaccion._ok Then
            Me.transaccion.Commit()
        Else
            Me.transaccion.Rollback()
        End If

        Me.conexion.Close()
        Me.configurar_conexion = tipo_conexion.simple

        Return Me.control_transaccion

    End Function

    Private Function _ejecutar(ByVal comando As String) As String
        Me._conectar()
        Me.cmd.CommandText = comando
        Try
            cmd.ExecuteNonQuery()
            Return "ok"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.control_transaccion = estado_transaccion._error
            Return ex.Message
        End Try
    End Function

    '--------------------------------------

    Public Function _consulta(ByVal comando As String) As Data.DataTable
        Dim _tabla As New Data.DataTable
        Me._conectar()
        Me.cmd.CommandText = comando
        Try
            _tabla.Load(Me.cmd.ExecuteReader())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en consulta")
        End Try

        If Me.configurar_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
        Return _tabla
    End Function

    Public Sub _consulta(ByVal comando As String, ByVal _tabla As Data.DataTable)
        Me._conectar()
        Me.cmd.CommandText = comando
        Try
            _tabla.Load(Me.cmd.ExecuteReader())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en consulta")
        End Try
        If Me.configurar_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
    End Sub

    Public Function leo_tabla() As Data.DataTable
        Return Me._consulta("select * from " & Me.nom_tabla)
    End Function

    Public Function leo_tabla(ByVal pk As String, ByVal descripcion As String) As Data.DataTable
        Return Me._consulta("select " & pk & ", " & descripcion & " from " & Me.nom_tabla)
    End Function

    Public Function leo_tabla(ByVal restriccion As String) As Data.DataTable
        Return Me._consulta("select * from " & Me.nom_tabla & " Where " & restriccion)
    End Function

    Public Sub cambiar_Tabla(ByVal tabla As String)
        Me.nom_tabla = tabla
    End Sub

    'Esta mal hecho, el case y el armado de string no va en la clase conexion.
    'Hacer otro borrar con parametro nombre tabla? el atributo ya esta en esta clase, no tendria sentido.
    Public Sub _borrar(ByVal id As Integer)
        Dim texto_borrar As String = "DELETE FROM " & nom_tabla & " WHERE "
        Me._conectar()
        Select Case nom_tabla
            Case "abogado"
                texto_borrar += "matricula= "
            Case "solicitante"
                texto_borrar += "idSolicitante= "
            Case "empleado"
                texto_borrar += "legajo= "
            Case "creditos"
                texto_borrar += "idCreditos= "
            Case "expediente"
                texto_borrar += "idExpediente= "
            Case Else
                Exit Sub
        End Select
        texto_borrar &= id
        ' MsgBox(texto_borrar)
        Me.cmd.CommandText = texto_borrar
        Try
            cmd.ExecuteNonQuery()
        Catch e As SqlClient.SqlException
            MsgBox("No se pudo eliminar el elemento seleccionado", vbOKOnly + vbCritical, "Importante")
        End Try

        Me.conexion.Close() ' FALTA VERIFICAR SI ES CONEXION SIMPLE O TRANSACCION
    End Sub

    Public Sub _borrar(ByVal documento As Integer, ByVal tipoDocumento As Integer)
        Dim texto_borrar As String = "DELETE FROM " & nom_tabla & " WHERE "
        Me._conectar()
        Select Case nom_tabla
            Case "solicitante"
                texto_borrar += "numeroDocumento= " & documento & " AND tipo_Documento_idTipo_Documento= " & tipoDocumento
            Case Else
                Exit Sub
        End Select
        '  MsgBox(texto_borrar)
        Me.cmd.CommandText = texto_borrar
        cmd.ExecuteNonQuery()
        Me.conexion.Close() ' FALTA VERIFICAR SI ES CONEXION SIMPLE O TRANSACCION
    End Sub

    Public Sub _modificar(ByVal comando As String)
        Me._conectar()
        Me.cmd.CommandText = comando
        ' MsgBox(comando)
        cmd.ExecuteNonQuery()
        Me.conexion.Close() ' FALTA VERIFICAR SI ES CONEXION SIMPLE O TRANSACCION
    End Sub

    Public Sub _modificar(ByVal valores As String, ByVal restriccion As String)
        Dim _update As String = "UPDATE " + Me.nom_tabla + " SET" + Chr(13)
        Dim _set As String
        Dim _restriccion As String

        _set = Me._arma_set_update(valores)

        If _set = "error" Then
            Exit Sub
        End If

        _restriccion = _armar_restriccion_update(restriccion)

        If _restriccion = "error" Then
            Exit Sub
        End If

        _update &= _set + _restriccion
        'MsgBox(_update)

        Me._conectar()
        Me.cmd.CommandText = _update
        cmd.ExecuteNonQuery()
        Me.conexion.Close() ' FALTA VERIFICAR SI ES CONEXION SIMPLE O TRANSACCION
    End Sub

    Private Function _armar_restriccion_update(ByVal restriccion As String) As String

        Dim objeto_tabla As Data.DataTable  'tabla que contiene la estructura en la base
        Dim contador As Integer = 0         'contador de bucle()
        Dim c As Integer = 0                'para  recorrer las columas buscando una
        Dim coma As Integer = 0             'ubicacion de la(",")
        Dim igual As Integer = 0            'ubicación del("=")
        Dim txt_origen As String = ""       'texto origen  
        Dim nombre_campo As String = ""     'campo a  buscar()
        Dim valor As String = ""            'valor del campo()
        Dim txt As String = ""              'texto que se va formando para el insert
        Dim tipo_dato As String = ""
        Dim estado As Boolean = True
        Dim encontro As Boolean = False
        Dim primera_vez As Boolean = True


        objeto_tabla = Me.leo_estructura()
        txt_origen = restriccion.ToUpper.Trim()
        While estado
            igual = txt_origen.IndexOf("=")
            coma = IIf(txt_origen.IndexOf(",") = -1, txt_origen.Length, txt_origen.IndexOf(","))

            If txt_origen.IndexOf(",") = -1 Then
                estado = False
            End If

            nombre_campo = txt_origen.Substring(0, igual).Trim()
            valor = txt_origen.Substring(igual + 1, coma - igual - 1).Trim()
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString

            For c = 0 To objeto_tabla.Columns.Count() - 1
                If nombre_campo.Trim() = objeto_tabla.Columns(c).Caption.ToUpper.Trim() Then
                    tipo_dato = objeto_tabla.Columns(c).DataType.ToString
                    encontro = True
                End If
            Next

            If encontro Then
                If primera_vez Then
                    txt &= "WHERE " + nombre_campo + " = " + acomodo_al_tipo_dato(valor, tipo_dato) + Chr(13)
                    primera_vez = False
                Else
                    txt &= " AND " + nombre_campo + " = " + acomodo_al_tipo_dato(valor, tipo_dato) + Chr(13)
                End If
            Else
                MsgBox("no existe el nombre de columna " + nombre_campo, MsgBoxStyle.Critical, "Importante")
                txt = "error"
                Exit While
            End If
            If estado = True Then
                txt_origen = txt_origen.Substring(coma + 1)
            End If
        End While
        Return txt
    End Function

    Private Function _arma_set_update(ByVal valores As String) As String
        Dim objeto_tabla As Data.DataTable 'tabla quecontiene la estructura en la base
        Dim contador As Integer = 0 'contador de bucle()
        Dim c As Integer = 0 'para recorrer las columas buscando una
        Dim coma As Integer = 0 'ubicacion de la(",")
        Dim igual As Integer = 0 'ubicación del("=")
        Dim txt_origen As String = "" 'texto origen
        Dim nombre_campo As String = "" 'campo a buscar()
        Dim valor As String = "" 'valor del campo()
        Dim txt As String = "" 'texto que se va formando para el insert
        Dim tipo_dato As String = ""
        Dim estado As Boolean = True
        Dim encontro As Boolean = False
        Dim primera_vez As Boolean = True

        objeto_tabla = Me.leo_estructura()
        txt_origen = valores.Trim()
        While estado

            igual = txt_origen.IndexOf("=")
            coma = IIf(txt_origen.IndexOf(",") = -1,
            txt_origen.Length, txt_origen.IndexOf(","))

            If txt_origen.IndexOf(",") = -1 Then
                estado = False
            End If

            nombre_campo = txt_origen.Substring(0, igual).Trim()
            valor = txt_origen.Substring(igual + 1, coma - igual - 1).Trim()
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString

            For c = 0 To objeto_tabla.Columns.Count() - 1
                If nombre_campo.Trim.ToUpper() = objeto_tabla.Columns(c).Caption.ToUpper.Trim() Then
                    tipo_dato = objeto_tabla.Columns(c).DataType.ToString
                    encontro = True
                End If
            Next
            If encontro Then
                If primera_vez Then
                    txt &= nombre_campo + " = " + acomodo_al_tipo_dato(valor, tipo_dato) + Chr(13)
                    primera_vez = False
                Else
                    txt &= ", " + nombre_campo + " = " + acomodo_al_tipo_dato(valor, tipo_dato) + Chr(13)
                End If
            Else
                MsgBox("no existe el nombre de columna " + nombre_campo, MsgBoxStyle.Critical, "Importante")
                txt = "error"
                Exit While
            End If
            If estado = True Then
                txt_origen = txt_origen.Substring(coma + 1)
            End If
        End While
        Return txt
    End Function


    'Insert que maneja transacciones y inserciones simples/conid (mepa que no sirve)
    Public Function _insertar_transaccion(ByVal valores As String, ByVal conid As Boolean) As String
        Dim txt_Insert As String = ""

        txt_Insert = Me.armo_insert(conid)
        txt_Insert += Me.asigno_valores_insert(valores, conid)

        '   MsgBox(txt_Insert)

        Dim estado As String = Me._ejecutar(txt_Insert)
        If Me.configurar_conexion = tipo_conexion.transaccion Then
            If estado = "ok" Then
                Return "ok"
            Else
                Return "error"
            End If
        Else
            Me.conexion.Close()
            Return ("ok")
        End If

    End Function
    'Insert con transaccion sin detalle
    Public Function _insertar_transaccion(ByVal valores As String) As String
        Dim txt_Insert As String = valores

        Dim estado As String = Me._ejecutar(txt_Insert)
        If Me.configurar_conexion = tipo_conexion.transaccion Then
            If estado = "ok" Then
                Return "ok"
            Else
                Return "error"
            End If
        Else
            Me.conexion.Close()
            Return ("ok")
        End If

    End Function
    'Insert con transaccion, con detalle
    Public Function _insertar_con_detalle(ByVal text As String, ByVal nomTabla As String) As Integer
        Dim id As Integer = -1

        Me._conectar()

        Dim txt_Insert As String = ""
        txt_Insert = text
        Dim tabla As New DataTable
        Me.cmd.CommandText = txt_Insert
        Try

            Me.cmd.executeNonQuery()
            Me.cmd.CommandText = "SELECT IDENT_CURRENT('" & nomTabla & "')"
            tabla.Load(Me.cmd.ExecuteReader())
            id = tabla.Rows(0)(0)
        Catch ex As Exception
            If Me.configurar_conexion = tipo_conexion.transaccion Then
                Me.control_transaccion = estado_transaccion._error
            End If
            MessageBox.Show("Error al insertar " & ex.Message & "Insertanto Records")

        End Try

        If Me.configurar_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
        Return id
    End Function

    Public Sub _insertar(ByVal valores As String, ByVal conid As Boolean) 'usar true si tabla no tiene id; usar false si la tabla tiene id
        Dim txt_Insert As String = ""
        txt_Insert = Me.armo_insert(conid)
        txt_Insert += Me.asigno_valores_insert(valores, conid)
        ' MsgBox(txt_Insert)

        Me._conectar()
        Me.cmd.CommandText = txt_Insert
        cmd.ExecuteNonQuery()
        Me.conexion.Close()
    End Sub

    Private Function armo_insert(ByVal conid As Boolean) As String
        Dim tabla As Data.DataTable
        Dim contador As Integer
        Dim txt As String = ""
        If conid = True Then
            contador = 0
        ElseIf conid = False Then
            contador = 1
        End If
        'tabla = Me.leo_tabla()
        tabla = Me.leo_estructura()
        txt = "insert into " & Me.nom_tabla & " ("
        While tabla.Columns.Count() > contador
            txt += tabla.Columns(contador).Caption
            contador += 1
            If contador < tabla.Columns.Count() Then
                txt += ", "
            End If
        End While
        txt += ") values ("
        Return txt
    End Function

    Private Function asigno_valores_insert(ByVal txt_insertar As String, ByVal conid As Boolean) As String
        Dim objeto_tabla As Data.DataTable 'tabla que contiene la estructura en la base
        Dim contador As Integer 'contador de bucle()
        Dim campo As Integer = 0 'ubicación  del(campo)
        Dim coma As Integer = 0 'ubicacion de la(",")
        Dim igual As Integer = 0 'ubicación del("=")
        Dim txt_origen As String = "" 'texto origen
        Dim nombre_campo As String = "" 'campo a  buscar()
        Dim valor As String = "" 'valor del  campo()
        Dim txt As String = "" 'texto que se va formando para el insert
        Dim tipo_dato As String = ""

        If conid = True Then
            contador = 0
        ElseIf conid = False Then
            contador = 1
        End If

        'objeto_tabla = Me.leo_tabla()

        objeto_tabla = Me.leo_estructura()
        txt_origen = txt_insertar.ToUpper.Trim()
        While objeto_tabla.Columns.Count() > contador
            nombre_campo = objeto_tabla.Columns(contador).Caption.ToUpper.Trim()
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString
            'MsgBox(nombre_campo & ": " & tipo_dato)
            campo = txt_origen.IndexOf(nombre_campo)

            If campo <> -1 Then
                igual = txt_origen.IndexOf("=", campo)
                coma = txt_origen.IndexOf(",", campo)
            Else
                igual = -1
                coma = -1
            End If
            If campo <> -1 Then
                igual = txt_origen.IndexOf("=", campo)
                coma = txt_origen.IndexOf(",", campo)
                If coma <> -1 Then
                    valor = Me.acomodo_al_tipo_dato(txt_origen.Substring(igual + 1, coma - igual - 1), tipo_dato)
                Else
                    valor = Me.acomodo_al_tipo_dato(txt_origen.Substring(igual + 1),
                    tipo_dato)
                End If
            Else
                valor = "null"
            End If
            txt += valor
            contador += 1
            If contador < objeto_tabla.Columns.Count() Then
                txt += ", "
            End If
        End While
        txt += ")"
        Return txt
    End Function

    Private Function acomodo_al_tipo_dato(ByVal texto As String, ByVal tipo_dato As String) As String
        Select Case tipo_dato
            Case "System.String"
                Return "'" & texto & "'"
            Case "System.Int16"
                Return texto
            Case "System.Int32"
                Return texto
            Case "System.Int64"
                Return texto
            Case "System.Byte"
                Return texto
            Case "System.Double"
                Return texto
            Case "System.Decimal"
                Return texto
            Case "System.DateTime"
                If motor = motores.access Then
                    Return "#" & texto & "#"
                Else
                    Return "convert(date, '" & texto & "', 103)"
                End If
            Case "System.DateTimeKind"
                If motor = motores.access Then
                    Return "#" & texto & "#"
                Else
                    Return "convert(date, '" & texto & "', 103)"
                End If
            Case Else
                Return texto
        End Select
    End Function

    Private Function leo_estructura() As Data.DataTable
        Dim sql As String
        Dim tabla As New DataTable
        Select Case motor
            Case motores.access
                sql = "select top 1 * from " & Me.nom_tabla
                tabla = Me._consulta(sql)
                Return tabla
            Case motores.sqlserver
                sql = "select top 1 * from " & Me.nom_tabla
                tabla = Me._consulta(sql)
                Return tabla
        End Select
        Return tabla
    End Function


End Class
