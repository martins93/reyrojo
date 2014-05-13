Public Class combo
    Dim _cadena_conexion As String

    Public Property cadena_conexion() As String
        Get
            Return _cadena_conexion
        End Get
        Set(ByVal value As String)
            _cadena_conexion = value
        End Set
    End Property
    Public Sub cargar(ByRef _combo As ComboBox, ByRef _tabla As Data.DataTable)

        _combo.DataSource = _tabla

        'La tabla puede tener el número de columnas que desee, pero el método solo utilizará las dos primeras
        'para llenar el combo
        'Analiza las dos primeras columnas para determinar cual de ellas es numérica, la que se tomará como pk o id, 
        'esta se asignará al ValueMember, la otra que debe ser de tipo strin se tomará como valor descriptivo y será 
        'asignada al DisplayMember

        'MsgBox(_tabla.Columns(0).DataType().ToString)

        Select Case _tabla.Rows(0)(0).GetType.Name
            Case "String"
                _combo.DisplayMember = _tabla.Columns(0).ColumnName
                _combo.ValueMember = _tabla.Columns(1).ColumnName
            Case Else
                _combo.DisplayMember = _tabla.Columns(1).ColumnName
                _combo.ValueMember = _tabla.Columns(0).ColumnName
        End Select
    End Sub
    Public Sub cargar(ByRef _combo As ComboBox, ByVal _tabla As Data.DataTable, ByVal _DisplayMember As String, ByVal _ValueMember As String)
        'Subrutina generica para cargar combos con información de una tabla de la BD
        'en donde el parámetro PK se corresponde con el id del DataTabla y el parámetro
        'DESCRIPCION se corresponde con el descriptro asciado a cada id en el DataTabla.
        'Los valores viene a través de DATOS parámetro de entrada del tipo DataTable
        'Se asignan de la siguiente forma:
        '         _ValueMember => ValueMember -> valor devuelto a través de SelectedValue, luego que se hizo una selección
        '         _DisplayMember => DisplayMember
        '         _tabla => DataSource 
        _combo.DataSource = _tabla
        _combo.DisplayMember = _DisplayMember
        _combo.ValueMember = _ValueMember
    End Sub
    Public Sub cargar(ByRef _combo As ComboBox, ByVal _nombre_tabla As String, ByVal _DisplayMember As String, ByVal _ValueMember As String)

        Dim _conexion As New Conexion

        _conexion._tabla = _nombre_tabla
        _combo.DataSource = _conexion.leo_tabla(_nombre_tabla)
        _combo.DisplayMember = _DisplayMember
        _combo.ValueMember = _ValueMember
    End Sub
    Public Sub cargar(ByRef _combo As ComboBox, ByVal _nombre_tabla As String)

        Dim _conexion As New Conexion(Me.cadena_conexion, Conexion.motores.access)
        Dim _tabla As New Data.DataTable

        _conexion._tabla = _nombre_tabla
        _tabla = _conexion.leo_tabla()

        'La tabla puede tener el número de columnas que desee, pero el método solo utilizará las dos primeras
        'para llenar el combo
        'Analiza las dos primeras columnas para determinar cual de ellas es numérica, la que se tomará como pk o id, 
        'esta se asignará al ValueMember, la otra que debe ser de tipo strin se tomará como valor descriptivo y será 
        'asignada al DisplayMember

        _combo.DataSource = _tabla

        Select Case _tabla.Rows(0)(0).GetType.Name
            Case "String"
                _combo.DisplayMember = _tabla.Columns(0).ColumnName
                _combo.ValueMember = _tabla.Columns(1).ColumnName
            Case Else
                _combo.DisplayMember = _tabla.Columns(1).ColumnName
                _combo.ValueMember = _tabla.Columns(0).ColumnName
        End Select
    End Sub
End Class
