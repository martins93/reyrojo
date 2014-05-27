Public Class frm_documentacion

    Dim cadena_Conexion As String = "Data Source=SALVADOR-PC\PAV1;Initial Catalog=PAV1;Integrated Security=True"
    Dim conexion As New Conexion(cadena_Conexion, "Documentacion", conexion.motores.sqlserver)

    Private Sub frm_documentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.txt_documentacion_descripcion.ResetText()
        Me.txt_documentacion_ubicacion.ResetText()
    End Sub

    Public Property descripcion As String
        Set(ByVal value As String)
            txt_documentacion_descripcion.Text = value
        End Set
        Get
            Return txt_documentacion_descripcion.Text
        End Get
    End Property

    Public Property ubicacion As String
        Set(ByVal value As String)
            txt_documentacion_ubicacion.Text = value
        End Set
        Get
            Return txt_documentacion_ubicacion.Text
        End Get
    End Property

    Private Sub texto_insert()
        Dim texto As String = "descripcion = " & Me.txt_documentacion_descripcion.Text & ", lugarAlmacenamiento = " & Me.txt_documentacion_ubicacion.Text

        conexion._insertar(texto, False)

    End Sub

    Public Function pasar_descripcion_docum() As String

        If txt_documentacion_descripcion.Text <> "" Then
            Return txt_documentacion_descripcion.Text
            Exit Function
        End If

        Return ""
    End Function

    Public Function pasar_ubicacion_docum() As String

        If txt_documentacion_ubicacion.Text <> "" Then
            Return txt_documentacion_ubicacion.Text
            Exit Function
        End If

        Return ""

    End Function

    Public Function traer_id_docum() As Data.DataTable

        Dim consulta_sql As String = "SELECT MAX(idDocumentacion) FROM Documentacion"
        Dim id_obj As Integer = 0
        Dim tabla As New Data.DataTable
        Dim cmd As New Data.OleDb.OleDbCommand

        tabla = conexion._consulta(consulta_sql)

        Return tabla

    End Function

    Private Sub cmd_documentacion_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_documentacion_ok.Click

        Me.texto_insert()
        MessageBox.Show("Documento Cargado con Exito", "Exito", MessageBoxButtons.OK)

        Me.Close()

    End Sub


    Private Sub cmd_documentacion_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_documentacion_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_documentacion_ubicacion_Enter(sender As Object, e As System.EventArgs) Handles txt_documentacion_ubicacion.Enter
        
        Dim openFileDialog = New OpenFileDialog()
        Dim ubicacion_txt As String = ""

        openFileDialog.Filter = "All Files (*.*)|*.*"
        openFileDialog.InitialDirectory = "c:\\"
        openFileDialog.Title = "Ubicacion Documentacion"
        openFileDialog.ShowDialog()

        If openFileDialog.FileName <> "" Then
            ubicacion_txt = openFileDialog.FileName
        End If

        Me.txt_documentacion_ubicacion.Text = ubicacion_txt

    End Sub



End Class