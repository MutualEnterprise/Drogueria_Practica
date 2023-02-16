Public Class Pedidos
    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each registro As DataRow In FrmPppal.productos.Rows
            CB_Prods.Items.Add(registro.Item(0).ToString)
        Next

    End Sub

    Private Sub BTN_Solicitar_Click(sender As Object, e As EventArgs) Handles BTN_Solicitar.Click
        For Each registro As DataRow In FrmPppal.productos.Rows
            If registro.Item(0).ToString = CB_Prods.SelectedItem.ToString Then
                Dim indice = FrmPppal.productos.Rows.IndexOf(registro)
                Dim cant_ini = FrmPppal.productos.Rows.Item(indice).Item(4).ToString
                FrmPppal.productos.Rows.Item(indice).Item(4) = CInt(cant_ini) + CInt(TB_Cant.Text)
            End If
        Next
        Inventario.DGV_Productos.Rows.Clear()
        Inventario.DGV_Productos.DataSource = FrmPppal.productos
        Inventario.DGV_Productos.Columns.Item(3).DefaultCellStyle.Format = "C2"
        Inventario.MdiParent = FrmPppal
        MsgBox("Pedido realizado")
        Inventario.Show()
        Me.Close()
    End Sub
End Class