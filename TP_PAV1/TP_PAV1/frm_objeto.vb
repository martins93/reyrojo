Public Class frm_objeto

    Dim cadena_Conexion As String = frm_Menu.cadena_Conexion
    Dim conexion As New Conexion(cadena_Conexion, "Objeto", conexion.motores.sqlserver)

    Private Sub frm_objeto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.txt_objeto_descripcion.ResetText()
        Me.txt_objeto_valorMonetario.ResetText()
    End Sub

    Public Property descripcion As String
        Set(ByVal value As String)
            txt_objeto_descripcion.Text = value
        End Set
        Get
            Return txt_objeto_descripcion.Text
        End Get
    End Property

    Public Property valor As Double
        Set(ByVal value As Double)
            txt_objeto_valorMonetario.Text = value
        End Set
        Get
            Return txt_objeto_valorMonetario.Text
        End Get
    End Property

    Private Sub texto_insert()
        Dim texto As String = "descripcion=" & Me.txt_objeto_descripcion.Text & ", valorMonetario=" & Me.txt_objeto_valorMonetario.Text

        conexion._insertar(texto, False)

    End Sub

    Public Function pasar_descripcion_obj() As String
        If validar_objeto() Then
            Return txt_objeto_descripcion.Text
        End If
    End Function

    Public Function traer_id_objeto() As Data.DataTable
        If validar_objeto() Then
            Dim consulta_sql As String = "SELECT MAX(idObjeto) FROM Objeto"
            Dim id_obj As Integer = 0
            Dim tabla As New Data.DataTable
            Dim cmd As New Data.OleDb.OleDbCommand

            tabla = conexion._consulta(consulta_sql)

            Return tabla
        End If

    End Function

    Private Sub cmd_objeto_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_objeto_ok.Click
        If validar_objeto() Then
            Me.texto_insert()
            MessageBox.Show("Objeto Cargado con Exito", "Exito", MessageBoxButtons.OK)

            Me.Close()
        End If

    End Sub


    Private Sub cmd_objeto_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_objeto_cancelar.Click
        Me.Close()
    End Sub

    Private Function validar_objeto() As Boolean
        If Me.txt_objeto_descripcion.Text <> "" Then
            If IsNumeric(Me.txt_objeto_valorMonetario.Text) Then
                If Me.txt_objeto_valorMonetario.Text > 0 Then
                    Return True
                    Exit Function
                Else
                    MsgBox("El monto debe ser mayor a 0", vbOKOnly + vbCritical, "Importante")
                End If
            End If
        Else
            MsgBox("Se debe llenar la descripcion", vbOKOnly + vbCritical, "Importante")
        End If
        Return False
    End Function

End Class