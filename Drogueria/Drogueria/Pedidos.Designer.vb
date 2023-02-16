<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Me.CB_Prods = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Cant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_Solicitar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CB_Prods
        '
        Me.CB_Prods.FormattingEnabled = True
        Me.CB_Prods.Location = New System.Drawing.Point(70, 104)
        Me.CB_Prods.Name = "CB_Prods"
        Me.CB_Prods.Size = New System.Drawing.Size(213, 23)
        Me.CB_Prods.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nuevos Pedidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(54, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione el producto a solicitar"
        '
        'TB_Cant
        '
        Me.TB_Cant.Location = New System.Drawing.Point(126, 190)
        Me.TB_Cant.Name = "TB_Cant"
        Me.TB_Cant.Size = New System.Drawing.Size(100, 23)
        Me.TB_Cant.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(57, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad de unidades a solicitar"
        '
        'BTN_Solicitar
        '
        Me.BTN_Solicitar.Location = New System.Drawing.Point(142, 258)
        Me.BTN_Solicitar.Name = "BTN_Solicitar"
        Me.BTN_Solicitar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Solicitar.TabIndex = 6
        Me.BTN_Solicitar.Text = "Solicitar"
        Me.BTN_Solicitar.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(356, 327)
        Me.Controls.Add(Me.BTN_Solicitar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Cant)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_Prods)
        Me.Name = "Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedidos"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_Prods As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Cant As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_Solicitar As Button
End Class
