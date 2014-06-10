Public Class buscar_doc_tipoDoc

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        doc2 = -1
        tdoc2 = -1
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBFDataSet.tipo_documento' Puede moverla o quitarla según sea necesario.
        Me.Tipo_DocumentoTableAdapter.Fill(Me.PAV1DataSet.tipo_Documento)
        Me.CenterToParent()
        Me.cmb_tdoc.ResetText()
    End Sub

    Public Property doc2 As Integer
        Get
            If txt_dni.MaskCompleted = True Then
                Return txt_dni.Text
            Else
                Return -1
            End If
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property tdoc2 As Integer
        Get
            Return cmb_tdoc.SelectedIndex
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click
        If Me.txt_dni.Text = "" Then
            MsgBox("Numero Documento vacio", vbOKOnly + vbCritical, "Atencion")
            Me.txt_dni.Focus()
            Exit Sub
        End If

        If Me.cmb_tdoc.SelectedIndex = -1 Then
            MsgBox("Tipo de Documento vacio", vbOKOnly + vbCritical, "Atencion")
            Me.cmb_tdoc.Focus()
            Exit Sub
        End If

        If Me.txt_dni.MaskCompleted = True And Me.cmb_tdoc.SelectedIndex > -1 Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If

    End Sub

End Class