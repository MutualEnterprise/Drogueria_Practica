<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporteador
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.DGV_Reporte_de_ventas = New System.Windows.Forms.DataGridView()
        Me.Btn_Volver = New System.Windows.Forms.Button()
        CType(Me.DGV_Reporte_de_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(45, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reporte de Ventas"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_titulo.ForeColor = System.Drawing.Color.Black
        Me.lbl_titulo.Location = New System.Drawing.Point(67, 93)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(90, 18)
        Me.lbl_titulo.TabIndex = 8
        Me.lbl_titulo.Text = "Bienvenido"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_producto
        '
        Me.lbl_producto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_producto.Location = New System.Drawing.Point(93, 125)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(90, 18)
        Me.lbl_producto.TabIndex = 9
        Me.lbl_producto.Text = "Bienvenido"
        Me.lbl_producto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Reporte_de_ventas
        '
        Me.DGV_Reporte_de_ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Reporte_de_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Reporte_de_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Reporte_de_ventas.Location = New System.Drawing.Point(45, 83)
        Me.DGV_Reporte_de_ventas.Name = "DGV_Reporte_de_ventas"
        Me.DGV_Reporte_de_ventas.RowTemplate.Height = 25
        Me.DGV_Reporte_de_ventas.Size = New System.Drawing.Size(363, 333)
        Me.DGV_Reporte_de_ventas.TabIndex = 10
        '
        'Btn_Volver
        '
        Me.Btn_Volver.Location = New System.Drawing.Point(189, 425)
        Me.Btn_Volver.Name = "Btn_Volver"
        Me.Btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Volver.TabIndex = 11
        Me.Btn_Volver.Text = "Retornar"
        Me.Btn_Volver.UseVisualStyleBackColor = True
        '
        'Reporteador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 460)
        Me.Controls.Add(Me.Btn_Volver)
        Me.Controls.Add(Me.DGV_Reporte_de_ventas)
        Me.Controls.Add(Me.lbl_producto)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reporteador"
        Me.Text = "Reporteador"
        CType(Me.DGV_Reporte_de_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_producto As Label
    Friend WithEvents DGV_Reporte_de_ventas As DataGridView
    Friend WithEvents Btn_Volver As Button
End Class
