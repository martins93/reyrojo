Public Class frm_cuota

    
    'CUOTAS: 6-12-18-24-36-60-84

    Enum estado_transaccion 'para determinar resultado de transaccion
        _ok
        _error
    End Enum

    Dim cadena_Conexion As String = frm_Menu.cadena_Conexion
    Dim conexion As New Conexion(cadena_Conexion, "Documentacion", conexion.motores.sqlserver)

    Dim id_credito As Integer
    Dim monto_credito As Double
    Dim fecha_aprobacion As String


    Private Sub frm_cuota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.cmb_cuota_cantidad.SelectedValue = 1
        Me.txt_cuota_montoTotal.ResetText()
        Me.txt_cuota_interes.ResetText()
        Me.txt_cuota_montoCuota.ResetText()

        Me.txt_cuota_montoTotal.Text = monto_credito
        Me.txt_cuota_montoTotal.Enabled = False

    End Sub

    Public Sub New(ByVal id_cred As Integer, ByVal monto_cred As Double, ByVal fecha_aprobacion As String)
        Me.InitializeComponent()
        Me.id_credito = id_cred
        Me.monto_credito = monto_cred
        Me.fecha_aprobacion = fecha_aprobacion
    End Sub

    Public Property cuota As Integer
        Set(value As Integer)

        End Set
        Get
            Return cmb_cuota_cantidad.Text
        End Get
    End Property

    Public Property interes As Double
        Set(ByVal value As Double)
            txt_cuota_interes.Text = value
        End Set
        Get
            Return txt_cuota_interes.Text
        End Get
    End Property

    Public Property monto_cuota As Double
        Set(value As Double)
            txt_cuota_montoCuota.Text = value
        End Set
        Get
            Return txt_cuota_montoCuota.Text
        End Get
    End Property

    Private Function calcular_valor_cuota() As Integer

        Dim couta As New Integer
        Dim cant_cout As New Integer
        Dim int As New Double

        cant_cout = Me.cmb_cuota_cantidad.Text
        int = 1 + (Me.txt_cuota_interes.Text / 100)

        couta = (monto_credito * int) / cant_cout

        Return couta
    End Function



    Private Sub btn_cuota_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cuota_aceptar.Click


        Dim tabla As New Data.DataTable
        Dim insert_couta As String = ""
        Dim insert_txt As String = ""
        Dim update_txt As String = ""
        Dim id_cuota As New Integer


        Me.conexion._iniciar_conexion_con_transaccion()

        Dim c As Integer = -1
        For c = 1 To Me.cmb_cuota_cantidad.Text

            insert_couta = "INSERT INTO Cuota (monto, interes, fechaVencimiento, fechaPago) VALUES ("
            insert_couta += Me.txt_cuota_montoCuota.Text & ", " & Me.txt_cuota_interes.Text & ", DATEADD(month, " & c & ", convert(date, '" & fecha_aprobacion & "', 103)), null)"


            Me.conexion._tabla = "Cuota"
            id_cuota = Me.conexion._insertar_con_detalle(insert_couta, "Cuota")


            insert_txt = "INSERT INTO Creditos_x_Cuota (Creditos_idCreditos, Cuota_idCuota, Estado_Cuota_idEstado_Cuota) VALUES ("
            insert_txt += Me.id_credito & ", " & id_cuota & ", " & 0 & ")"

            Me.conexion._tabla = "Creditos_x_Cuota"

            Me.conexion._insertar_transaccion(insert_txt)
        Next

        Dim estado As estado_transaccion = Me.conexion._finalizar_conexio_con_transaccion()

        If estado = estado_transaccion._ok Then
            update_txt = "UPDATE Creditos SET Estado_Credito_idEstado_Credito =" & 1 & ", fechaAprobacion=convert(date, '" & fecha_aprobacion & "', 103)   WHERE idCreditos =" & id_credito

            Me.conexion._modificar(update_txt)
        End If

        Me.Close()

    End Sub

    Private Sub cmb_cuota_cantidad_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmb_cuota_cantidad.SelectedIndexChanged
        'Dim valid As New Validacion

        'If valid._validar_vacios_generico Then
        If Me.txt_cuota_interes.Text >= 0 Then
            Me.txt_cuota_montoCuota.Text = Me.calcular_valor_cuota
        End If
        'End If
    End Sub

    Private Sub btn_cuota_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cuota_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_cuota_interes_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cuota_interes.KeyPress
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
End Class