Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmPppal
    Public productos As DataTable
    Public listado_de_ventas As DataTable
    Private Sub FrmPppal_Load(sender As Object, e As EventArgs) Handles Me.Load
        carga_productos()
        carga_ventas()
    End Sub
    Private Sub IngresarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarProductoToolStripMenuItem.Click
        Inventario.DGV_Productos.DataSource = productos
        Inventario.DGV_Productos.Columns.Item(3).DefaultCellStyle.Format = "C2"
        Inventario.MdiParent = Me
        Inventario.Show()
    End Sub
    Private Sub GenerarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarVentaToolStripMenuItem.Click
        Ventas.MdiParent = Me
        Ventas.Show()
    End Sub

    Private Sub TopDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopDeProductosToolStripMenuItem.Click
        Reporteador.msg1 = "MAYOR"
        Reporteador.msg2 = Ventas.calculadora_De_ventas(Reporteador.msg1)
        Reporteador.MdiParent = Me
        Reporteador.Show()
    End Sub

    Private Sub MenosVendidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenosVendidoToolStripMenuItem.Click
        Reporteador.msg1 = "MENOR"
        Reporteador.msg2 = Ventas.calculadora_De_ventas(Reporteador.msg1)
        Reporteador.MdiParent = Me
        Reporteador.Show()
    End Sub

    Private Sub ResumenDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeVentasToolStripMenuItem.Click
        Reporteador.tipo = 1
        Reporteador.MdiParent = Me
        Reporteador.Show()
    End Sub
    Private Sub carga_productos()
        Dim ds As New DataSet()
        Dim tabla As New DataTable()
        ds.Tables.Add(tabla)
        tabla.Columns.Add("Nombre")
        tabla.Columns.Add("Tipo")
        tabla.Columns.Add("Cantidad Minima Requerida")
        tabla.Columns.Add("Precio de Venta")
        tabla.Columns.Add("Cantidad Actual")
        tabla.Rows.Add("Alcanfor", "Frasco", "10", FormatCurrency("20000", 2), "80")
        tabla.Rows.Add("Mentol", "Frasco", "5", FormatCurrency("30000", 2), "30")
        tabla.Rows.Add("Shampoo H&S", "Sachet", "10", FormatCurrency("2000", 2), "80")
        tabla.Rows.Add("Crema para peinar", "Sachet", "10", FormatCurrency("3000", 2), "80")
        tabla.Rows.Add("Vitamina C", "Sobre", "50", FormatCurrency("5000", 2), "50")
        tabla.Rows.Add("Vitamina D", "Sobre", "50", FormatCurrency("20000", 2), "80")
        tabla.Rows.Add("Alcohol", "Frasco", "10", FormatCurrency("25000", 2), "20")
        tabla.Rows.Add("Dolex Gripa", "Capsulas", "100", FormatCurrency("1000", 2), "120")
        tabla.Rows.Add("Acetaminofen", "Capsulas", "30", FormatCurrency("2000", 2), "50")
        tabla.Rows.Add("Ibuflash", "Frasco", "10", FormatCurrency("60000", 2), "50")
        productos = tabla
    End Sub

    Private Sub carga_ventas()
        Dim ds As New DataSet()
        Dim tabla As New DataTable()
        ds.Tables.Add(tabla)
        tabla.Columns.Add("Nombre Producto")
        tabla.Columns.Add("Cantidad Vendida")
        tabla.Columns.Add("Valor Venta")
        listado_de_ventas = tabla
    End Sub


End Class
