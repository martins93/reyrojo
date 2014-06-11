<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_documentacion
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
        Me.txt_documentacion_ubicacion = New System.Windows.Forms.TextBox()
        Me.cmd_documentacion_cancelar = New System.Windows.Forms.Button()
        Me.cmd_documentacion_ok = New System.Windows.Forms.Button()
        Me.txt_documentacion_descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_documentacion_ubicacion = New System.Windows.Forms.Label()
        Me.lbl_documentacion_descripcion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_documentacion_ubicacion
        '
        Me.txt_documentacion_ubicacion.Location = New System.Drawing.Point(119, 67)
        Me.txt_documentacion_ubicacion.Name = "txt_documentacion_ubicacion"
        Me.txt_documentacion_ubicacion.Size = New System.Drawing.Size(214, 20)
        Me.txt_documentacion_ubicacion.TabIndex = 7
        '
        'cmd_documentacion_cancelar
        '
        Me.cmd_documentacion_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_documentacion_cancelar.Location = New System.Drawing.Point(210, 115)
        Me.cmd_documentacion_cancelar.Name = "cmd_documentacion_cancelar"
        Me.cmd_documentacion_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_documentacion_cancelar.TabIndex = 9
        Me.cmd_documentacion_cancelar.Text = "Cancelar"
        Me.cmd_documentacion_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_documentacion_ok
        '
        Me.cmd_documentacion_ok.Location = New System.Drawing.Point(63, 115)
        Me.cmd_documentacion_ok.Name = "cmd_documentacion_ok"
        Me.cmd_documentacion_ok.Size = New System.Drawing.Size(75, 23)
        Me.cmd_documentacion_ok.TabIndex = 8
        Me.cmd_documentacion_ok.Text = "OK"
        Me.cmd_documentacion_ok.UseVisualStyleBackColor = True
        '
        'txt_documentacion_descripcion
        '
        Me.txt_documentacion_descripcion.Location = New System.Drawing.Point(119, 28)
        Me.txt_documentacion_descripcion.Name = "txt_documentacion_descripcion"
        Me.txt_documentacion_descripcion.Size = New System.Drawing.Size(214, 20)
        Me.txt_documentacion_descripcion.TabIndex = 4
        '
        'lbl_documentacion_ubicacion
        '
        Me.lbl_documentacion_ubicacion.AutoSize = True
        Me.lbl_documentacion_ubicacion.Location = New System.Drawing.Point(2, 70)
        Me.lbl_documentacion_ubicacion.Name = "lbl_documentacion_ubicacion"
        Me.lbl_documentacion_ubicacion.Size = New System.Drawing.Size(111, 13)
        Me.lbl_documentacion_ubicacion.TabIndex = 6
        Me.lbl_documentacion_ubicacion.Text = "Ubicacion del Archivo"
        '
        'lbl_documentacion_descripcion
        '
        Me.lbl_documentacion_descripcion.AutoSize = True
        Me.lbl_documentacion_descripcion.Location = New System.Drawing.Point(40, 31)
        Me.lbl_documentacion_descripcion.Name = "lbl_documentacion_descripcion"
        Me.lbl_documentacion_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_documentacion_descripcion.TabIndex = 5
        Me.lbl_documentacion_descripcion.Text = "Descripcion"
        '
        'frm_documentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 153)
        Me.Controls.Add(Me.txt_documentacion_ubicacion)
        Me.Controls.Add(Me.cmd_documentacion_cancelar)
        Me.Controls.Add(Me.cmd_documentacion_ok)
        Me.Controls.Add(Me.txt_documentacion_descripcion)
        Me.Controls.Add(Me.lbl_documentacion_ubicacion)
        Me.Controls.Add(Me.lbl_documentacion_descripcion)
        Me.Name = "frm_documentacion"
        Me.Text = "Cargar Documentacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_documentacion_ubicacion As System.Windows.Forms.TextBox
    Friend WithEvents cmd_documentacion_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_documentacion_ok As System.Windows.Forms.Button
    Friend WithEvents txt_documentacion_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_documentacion_ubicacion As System.Windows.Forms.Label
    Friend WithEvents lbl_documentacion_descripcion As System.Windows.Forms.Label
End Class
