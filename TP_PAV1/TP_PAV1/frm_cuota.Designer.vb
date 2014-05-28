<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cuota
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cuota_montoTotal = New System.Windows.Forms.TextBox()
        Me.cmb_cuota_cantidad = New System.Windows.Forms.ComboBox()
        Me.btn_cuota_aceptar = New System.Windows.Forms.Button()
        Me.txt_cuota_montoCuota = New System.Windows.Forms.TextBox()
        Me.txt_cuota_interes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cuota_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de Cuotas"
        '
        'txt_cuota_montoTotal
        '
        Me.txt_cuota_montoTotal.Location = New System.Drawing.Point(144, 30)
        Me.txt_cuota_montoTotal.Name = "txt_cuota_montoTotal"
        Me.txt_cuota_montoTotal.Size = New System.Drawing.Size(146, 20)
        Me.txt_cuota_montoTotal.TabIndex = 1
        '
        'cmb_cuota_cantidad
        '
        Me.cmb_cuota_cantidad.FormattingEnabled = True
        Me.cmb_cuota_cantidad.Items.AddRange(New Object() {"6", "12", "18", "24", "36", "60", "84"})
        Me.cmb_cuota_cantidad.Location = New System.Drawing.Point(144, 87)
        Me.cmb_cuota_cantidad.Name = "cmb_cuota_cantidad"
        Me.cmb_cuota_cantidad.Size = New System.Drawing.Size(78, 21)
        Me.cmb_cuota_cantidad.TabIndex = 2
        '
        'btn_cuota_aceptar
        '
        Me.btn_cuota_aceptar.Location = New System.Drawing.Point(43, 167)
        Me.btn_cuota_aceptar.Name = "btn_cuota_aceptar"
        Me.btn_cuota_aceptar.Size = New System.Drawing.Size(100, 43)
        Me.btn_cuota_aceptar.TabIndex = 3
        Me.btn_cuota_aceptar.Text = "Aceptar"
        Me.btn_cuota_aceptar.UseVisualStyleBackColor = True
        '
        'txt_cuota_montoCuota
        '
        Me.txt_cuota_montoCuota.Location = New System.Drawing.Point(144, 127)
        Me.txt_cuota_montoCuota.Name = "txt_cuota_montoCuota"
        Me.txt_cuota_montoCuota.Size = New System.Drawing.Size(146, 20)
        Me.txt_cuota_montoCuota.TabIndex = 1
        '
        'txt_cuota_interes
        '
        Me.txt_cuota_interes.Location = New System.Drawing.Point(144, 59)
        Me.txt_cuota_interes.Name = "txt_cuota_interes"
        Me.txt_cuota_interes.Size = New System.Drawing.Size(146, 20)
        Me.txt_cuota_interes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monto total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Monto por Cuota" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   (Con interes)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tasa de interes"
        '
        'btn_cuota_cancelar
        '
        Me.btn_cuota_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cuota_cancelar.Location = New System.Drawing.Point(174, 167)
        Me.btn_cuota_cancelar.Name = "btn_cuota_cancelar"
        Me.btn_cuota_cancelar.Size = New System.Drawing.Size(100, 43)
        Me.btn_cuota_cancelar.TabIndex = 3
        Me.btn_cuota_cancelar.Text = "Cancelar"
        Me.btn_cuota_cancelar.UseVisualStyleBackColor = True
        '
        'frm_cuota
        '
        Me.AcceptButton = Me.btn_cuota_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cuota_cancelar
        Me.ClientSize = New System.Drawing.Size(318, 244)
        Me.Controls.Add(Me.btn_cuota_cancelar)
        Me.Controls.Add(Me.btn_cuota_aceptar)
        Me.Controls.Add(Me.cmb_cuota_cantidad)
        Me.Controls.Add(Me.txt_cuota_interes)
        Me.Controls.Add(Me.txt_cuota_montoCuota)
        Me.Controls.Add(Me.txt_cuota_montoTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_cuota"
        Me.Text = "Cuota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cuota_montoTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmb_cuota_cantidad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cuota_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_cuota_montoCuota As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuota_interes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_cuota_cancelar As System.Windows.Forms.Button
End Class
