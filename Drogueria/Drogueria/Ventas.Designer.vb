<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Cant = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.BTN_Genera_venta = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Ventas = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_Tot_precio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Tot_Cant = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(64, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(636, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de VEntas de Productos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombres"
        '
        'TB_Cant
        '
        Me.TB_Cant.Location = New System.Drawing.Point(48, 117)
        Me.TB_Cant.Name = "TB_Cant"
        Me.TB_Cant.Size = New System.Drawing.Size(218, 23)
        Me.TB_Cant.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(272, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellidos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(272, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(238, 23)
        Me.TextBox1.TabIndex = 8
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(713, 470)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 12
        Me.BTN_Salir.Text = "Cerrar"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'BTN_Genera_venta
        '
        Me.BTN_Genera_venta.Location = New System.Drawing.Point(606, 470)
        Me.BTN_Genera_venta.Name = "BTN_Genera_venta"
        Me.BTN_Genera_venta.Size = New System.Drawing.Size(94, 23)
        Me.BTN_Genera_venta.TabIndex = 13
        Me.BTN_Genera_venta.Text = "Generar Venta"
        Me.BTN_Genera_venta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 139)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Del Cliente"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(272, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(238, 23)
        Me.TextBox2.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(272, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Direccion"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(19, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(218, 23)
        Me.TextBox3.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Ventas)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 274)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de los Productos"
        '
        'DGV_Ventas
        '
        Me.DGV_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.Valunit})
        Me.DGV_Ventas.Location = New System.Drawing.Point(19, 32)
        Me.DGV_Ventas.Name = "DGV_Ventas"
        Me.DGV_Ventas.RowTemplate.Height = 25
        Me.DGV_Ventas.Size = New System.Drawing.Size(438, 219)
        Me.DGV_Ventas.TabIndex = 0
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Valunit
        '
        Me.Valunit.HeaderText = "Valor Unitario"
        Me.Valunit.Name = "Valunit"
        Me.Valunit.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TB_Tot_precio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TB_Tot_Cant)
        Me.GroupBox3.Location = New System.Drawing.Point(527, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 141)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumen de la venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Valor Total de la venta"
        '
        'TB_Tot_precio
        '
        Me.TB_Tot_precio.Location = New System.Drawing.Point(94, 103)
        Me.TB_Tot_precio.Name = "TB_Tot_precio"
        Me.TB_Tot_precio.Size = New System.Drawing.Size(137, 23)
        Me.TB_Tot_precio.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cantidad Total de Productos:"
        '
        'TB_Tot_Cant
        '
        Me.TB_Tot_Cant.Location = New System.Drawing.Point(146, 42)
        Me.TB_Tot_Cant.Name = "TB_Tot_Cant"
        Me.TB_Tot_Cant.Size = New System.Drawing.Size(85, 23)
        Me.TB_Tot_Cant.TabIndex = 8
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BTN_Genera_venta)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Cant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Cant As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTN_Salir As Button
    Friend WithEvents BTN_Genera_venta As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_Ventas As DataGridView
    Friend WithEvents Producto As DataGridViewComboBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Valunit As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_Tot_precio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Tot_Cant As TextBox
End Class
