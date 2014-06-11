<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscar_doc_tipoDoc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmb_tdoc = New System.Windows.Forms.ComboBox()
        Me.TipoDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAV1DataSet = New TP_PAV1.PAV1DataSet()
        Me.txt_dni = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.lbl_tdoc = New System.Windows.Forms.Label()
        Me.lbl_dni = New System.Windows.Forms.Label()
        Me.Tipo_DocumentoTableAdapter = New TP_PAV1.PAV1DataSetTableAdapters.tipo_DocumentoTableAdapter()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAV1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_tdoc
        '
        Me.cmb_tdoc.DataSource = Me.TipoDocumentoBindingSource
        Me.cmb_tdoc.DisplayMember = "nombre"
        Me.cmb_tdoc.FormattingEnabled = True
        Me.cmb_tdoc.Location = New System.Drawing.Point(123, 62)
        Me.cmb_tdoc.Name = "cmb_tdoc"
        Me.cmb_tdoc.Size = New System.Drawing.Size(146, 21)
        Me.cmb_tdoc.TabIndex = 12
        Me.cmb_tdoc.ValueMember = "id_tipo_documento"
        '
        'TipoDocumentoBindingSource
        '
        Me.TipoDocumentoBindingSource.DataMember = "tipo_Documento"
        Me.TipoDocumentoBindingSource.DataSource = Me.PAV1DataSet
        '
        'PAV1DataSet
        '
        Me.PAV1DataSet.DataSetName = "PAV1DataSet"
        Me.PAV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(123, 26)
        Me.txt_dni.Mask = "90909090"
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_dni.TabIndex = 11
        Me.txt_dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancelar.Location = New System.Drawing.Point(173, 102)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(60, 33)
        Me.cmd_cancelar.TabIndex = 10
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(36, 102)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(61, 33)
        Me.cmd_ok.TabIndex = 9
        Me.cmd_ok.Text = "OK"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'lbl_tdoc
        '
        Me.lbl_tdoc.AutoSize = True
        Me.lbl_tdoc.Location = New System.Drawing.Point(11, 62)
        Me.lbl_tdoc.Name = "lbl_tdoc"
        Me.lbl_tdoc.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tdoc.TabIndex = 7
        Me.lbl_tdoc.Text = "Tipo Documento"
        '
        'lbl_dni
        '
        Me.lbl_dni.AutoSize = True
        Me.lbl_dni.Location = New System.Drawing.Point(11, 26)
        Me.lbl_dni.Name = "lbl_dni"
        Me.lbl_dni.Size = New System.Drawing.Size(62, 13)
        Me.lbl_dni.TabIndex = 8
        Me.lbl_dni.Text = "Documento"
        '
        'Tipo_DocumentoTableAdapter
        '
        Me.Tipo_DocumentoTableAdapter.ClearBeforeFill = True
        '
        'buscar_doc_tipoDoc
        '
        Me.AcceptButton = Me.cmd_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancelar
        Me.ClientSize = New System.Drawing.Size(284, 153)
        Me.Controls.Add(Me.cmb_tdoc)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.lbl_tdoc)
        Me.Controls.Add(Me.lbl_dni)
        Me.Name = "buscar_doc_tipoDoc"
        Me.Text = "Buscar Documento y Tipo"
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAV1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_tdoc As System.Windows.Forms.ComboBox
    Friend WithEvents TipoDocumentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAV1DataSet As TP_PAV1.PAV1DataSet
    Friend WithEvents txt_dni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents lbl_tdoc As System.Windows.Forms.Label
    Friend WithEvents lbl_dni As System.Windows.Forms.Label
    Friend WithEvents Tipo_DocumentoTableAdapter As TP_PAV1.PAV1DataSetTableAdapters.tipo_DocumentoTableAdapter
End Class
