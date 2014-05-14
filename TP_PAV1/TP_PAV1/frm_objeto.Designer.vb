<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_objeto
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
        Me.lbl_objeto_descripcion = New System.Windows.Forms.Label()
        Me.lbl_objeto_valor = New System.Windows.Forms.Label()
        Me.txt_objeto_descripcion = New System.Windows.Forms.TextBox()
        Me.cmd_objeto_ok = New System.Windows.Forms.Button()
        Me.cmd_objeto_cancelar = New System.Windows.Forms.Button()
        Me.txt_objeto_valorMonetario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_objeto_descripcion
        '
        Me.lbl_objeto_descripcion.AutoSize = True
        Me.lbl_objeto_descripcion.Location = New System.Drawing.Point(40, 28)
        Me.lbl_objeto_descripcion.Name = "lbl_objeto_descripcion"
        Me.lbl_objeto_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_objeto_descripcion.TabIndex = 0
        Me.lbl_objeto_descripcion.Text = "Descripcion"
        '
        'lbl_objeto_valor
        '
        Me.lbl_objeto_valor.AutoSize = True
        Me.lbl_objeto_valor.Location = New System.Drawing.Point(40, 67)
        Me.lbl_objeto_valor.Name = "lbl_objeto_valor"
        Me.lbl_objeto_valor.Size = New System.Drawing.Size(31, 13)
        Me.lbl_objeto_valor.TabIndex = 1
        Me.lbl_objeto_valor.Text = "Valor"
        '
        'txt_objeto_descripcion
        '
        Me.txt_objeto_descripcion.Location = New System.Drawing.Point(119, 25)
        Me.txt_objeto_descripcion.Name = "txt_objeto_descripcion"
        Me.txt_objeto_descripcion.Size = New System.Drawing.Size(214, 20)
        Me.txt_objeto_descripcion.TabIndex = 0
        '
        'cmd_objeto_ok
        '
        Me.cmd_objeto_ok.Location = New System.Drawing.Point(63, 112)
        Me.cmd_objeto_ok.Name = "cmd_objeto_ok"
        Me.cmd_objeto_ok.Size = New System.Drawing.Size(75, 23)
        Me.cmd_objeto_ok.TabIndex = 2
        Me.cmd_objeto_ok.Text = "OK"
        Me.cmd_objeto_ok.UseVisualStyleBackColor = True
        '
        'cmd_objeto_cancelar
        '
        Me.cmd_objeto_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_objeto_cancelar.Location = New System.Drawing.Point(210, 112)
        Me.cmd_objeto_cancelar.Name = "cmd_objeto_cancelar"
        Me.cmd_objeto_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_objeto_cancelar.TabIndex = 3
        Me.cmd_objeto_cancelar.Text = "Cancelar"
        Me.cmd_objeto_cancelar.UseVisualStyleBackColor = True
        '
        'txt_objeto_valorMonetario
        '
        Me.txt_objeto_valorMonetario.Location = New System.Drawing.Point(119, 64)
        Me.txt_objeto_valorMonetario.Name = "txt_objeto_valorMonetario"
        Me.txt_objeto_valorMonetario.Size = New System.Drawing.Size(100, 20)
        Me.txt_objeto_valorMonetario.TabIndex = 1
        '
        'frm_objeto
        '
        Me.AcceptButton = Me.cmd_objeto_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_objeto_cancelar
        Me.ClientSize = New System.Drawing.Size(345, 149)
        Me.Controls.Add(Me.txt_objeto_valorMonetario)
        Me.Controls.Add(Me.cmd_objeto_cancelar)
        Me.Controls.Add(Me.cmd_objeto_ok)
        Me.Controls.Add(Me.txt_objeto_descripcion)
        Me.Controls.Add(Me.lbl_objeto_valor)
        Me.Controls.Add(Me.lbl_objeto_descripcion)
        Me.Name = "frm_objeto"
        Me.Text = "Cargar Objeto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_objeto_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_objeto_valor As System.Windows.Forms.Label
    Friend WithEvents txt_objeto_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmd_objeto_ok As System.Windows.Forms.Button
    Friend WithEvents cmd_objeto_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_objeto_valorMonetario As System.Windows.Forms.TextBox
End Class
