Public Class frm_objeto

    Dim cadena_Conexion As String = "Data Source=MARTIN-PC;Initial Catalog=PAV1;Integrated Security=True"
    Dim conexion As New Conexion(cadena_Conexion, "Objeto", conexion.motores.sqlserver)

    Private Sub frm_objeto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.txt_objeto_descripcion.ResetText()
        Me.txt_objeto_valorMonetario.ResetText()
    End Sub

    Public Property descripcion As String
        Set(value As String)
            txt_objeto_descripcion.Text = value
        End Set
        Get
            Return txt_objeto_descripcion.Text
        End Get
    End Property

    Public Property valor As Double
        Set(value As Double)
            txt_objeto_valorMonetario.Text = value
        End Set
        Get
            Return txt_objeto_valorMonetario.Text
        End Get
    End Property

    Private Sub texto_insert()

        Dim texto As String = "descripcion = " & Me.txt_objeto_descripcion.Text & ", valorMonetario = " & Me.txt_objeto_valorMonetario.Text

        conexion._insertar(texto, False)

    End Sub

    Public Function pasar_descripcion_obj() As String

        Return txt_objeto_descripcion.Text

    End Function

    Private Sub cmd_objeto_ok_Click(sender As System.Object, e As System.EventArgs) Handles cmd_objeto_ok.Click

        Me.texto_insert()
        MessageBox.Show("Objeto Cargado con Exito", "Exito", MessageBoxButtons.OK)
        Me.Close()

    End Sub


    Private Sub cmd_objeto_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmd_objeto_cancelar.Click
        Me.Close()
    End Sub
End Class