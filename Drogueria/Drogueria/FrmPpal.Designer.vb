<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPppal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenosVendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarProductoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'IngresarProductoToolStripMenuItem
        '
        Me.IngresarProductoToolStripMenuItem.Name = "IngresarProductoToolStripMenuItem"
        Me.IngresarProductoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IngresarProductoToolStripMenuItem.Text = "Ingresar Producto"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'GenerarVentaToolStripMenuItem
        '
        Me.GenerarVentaToolStripMenuItem.Name = "GenerarVentaToolStripMenuItem"
        Me.GenerarVentaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.GenerarVentaToolStripMenuItem.Text = "Generar Venta"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopDeProductosToolStripMenuItem, Me.MenosVendidoToolStripMenuItem, Me.ResumenDeVentasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'TopDeProductosToolStripMenuItem
        '
        Me.TopDeProductosToolStripMenuItem.Name = "TopDeProductosToolStripMenuItem"
        Me.TopDeProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TopDeProductosToolStripMenuItem.Text = "Mas Vendido"
        '
        'MenosVendidoToolStripMenuItem
        '
        Me.MenosVendidoToolStripMenuItem.Name = "MenosVendidoToolStripMenuItem"
        Me.MenosVendidoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MenosVendidoToolStripMenuItem.Text = "Menos Vendido"
        '
        'ResumenDeVentasToolStripMenuItem
        '
        Me.ResumenDeVentasToolStripMenuItem.Name = "ResumenDeVentasToolStripMenuItem"
        Me.ResumenDeVentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResumenDeVentasToolStripMenuItem.Text = "Resumen de Ventas"
        '
        'FrmPppal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPppal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de productos - Drogueria E1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenosVendidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumenDeVentasToolStripMenuItem As ToolStripMenuItem
End Class
