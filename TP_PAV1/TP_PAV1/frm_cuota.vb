Public Class frm_cuota

    
    'CUOTAS: 6-12-18-24-36-60-84

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




        'Me.conexion._iniciar_conexion_con_transaccion()

        Dim c As Integer = -1
        For c = 1 To Me.cmb_cuota_cantidad.Text

            insert_couta = "INSERT INTO Cuota (monto, interes, fechaVencimiento, fechaPago) VALUES ("
            insert_couta += Me.txt_cuota_montoCuota.Text & ", " & Me.txt_cuota_interes.Text & ", DATEADD(month, " & c & ", convert(date, '" & fecha_aprobacion & "', 103)), null)"
            MsgBox(insert_couta)

            Me.conexion._tabla = "Cuota"
            Me.conexion._modificar(insert_couta)
            tabla = conexion._consulta("SELECT MAX(idCuota) FROM Cuota")


            insert_txt = "INSERT INTO Creditos_x_Cuota (Creditos_idCreditos, Cuota_idCuota, Estado_Cuota_idEstado_Cuota) VALUES ("
            insert_txt += Me.id_credito & ", " & tabla.Rows(0)(0) & ", " & 0 & ")"

            Me.conexion._tabla = "Creditos_x_Cuota"

            Me.conexion._modificar(insert_txt)

        Next

        Me.Close()
        'Dim estado As Object
        'estado = Me.conexion._finalizar_conexio_con_transaccion()

        'If estado.ToString = "_ok" Then
        '    MsgBox("Se grabó exitosamente", MsgBoxStyle.Information, "Importante")
        'Else
        '    MsgBox("Se produjo error en la grabación", MsgBoxStyle.Information, "Importante")
        'End If

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
End Class