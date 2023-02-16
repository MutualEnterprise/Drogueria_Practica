Imports System.CodeDom
Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class Ventas

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c1 As New DataGridViewComboBoxColumn()
        c1 = DGV_Ventas.Columns(0)
        For Each registro As DataRow In FrmPppal.productos.Rows
            c1.Items.Add(registro.Item(0).ToString)
        Next
    End Sub

    Private Sub BTN_Genera_venta_Click(sender As Object, e As EventArgs) Handles BTN_Genera_venta.Click
        Try
            registra_ventas()
            MsgBox("Venta generada exitosamente ...")
            Me.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        Me.Close()
    End Sub

    Private Sub DGV_Ventas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Ventas.CellEndEdit
        If IsNothing(DGV_Ventas.Rows(e.RowIndex).Cells(0).Value) Then Exit Sub
        For Each registro As DataRow In FrmPppal.productos.Rows
            If registro.Item(0).ToString = DGV_Ventas.Rows(e.RowIndex).Cells(0).Value.ToString Then
                DGV_Ventas.Rows(e.RowIndex).Cells(2).Value = Format(CDec(registro.Item(3).ToString), "C2")
            End If
        Next
        Dim v_suma = 0, v_val_unit = 0
        For Each registro As DataGridViewRow In DGV_Ventas.Rows
            v_suma = v_suma + CInt(registro.Cells(1).Value)
            v_val_unit = v_val_unit + (CInt(registro.Cells(1).Value) * CInt(registro.Cells(2).Value))
        Next
        TB_Tot_Cant.Text = v_suma
        TB_Tot_precio.Text = Format(CDec(v_val_unit), "C2")
    End Sub

    Private Sub registra_ventas()
        Dim registro As DataRow
        For Each reg_venta As DataGridViewRow In DGV_Ventas.Rows
            If Not IsNothing(reg_venta.Cells(0).Value) Then
                For Each r_producto As DataRow In FrmPppal.productos.Rows
                    If r_producto.Item(0).ToString = reg_venta.Cells(0).Value.ToString Then
                        Dim indice = FrmPppal.productos.Rows.IndexOf(r_producto)
                        Dim cant_act = CInt(FrmPppal.productos.Rows.Item(indice).Item(4))
                        If cant_act < CInt(reg_venta.Cells(1).Value) Then Throw New Exception("No cuenta con la cantidad suficiente del producto: " + r_producto.Item(0).ToString)
                        FrmPppal.productos.Rows.Item(indice).Item(4) = cant_act - CInt(reg_venta.Cells(1).Value)
                    End If

                Next
                registro = FrmPppal.listado_de_ventas.NewRow()
                registro.Item(0) = reg_venta.Cells(0).Value
                registro.Item(1) = reg_venta.Cells(1).Value
                registro.Item(2) = FormatCurrency(CInt(reg_venta.Cells(1).Value) * CInt(reg_venta.Cells(2).Value), 2)
                FrmPppal.listado_de_ventas.Rows.Add(registro)

            End If
        Next


    End Sub

    Public Function calculadora_De_ventas(objetivo As String) As String
        If FrmPppal.listado_de_ventas.Rows.Count = 0 Then Return "Imposible de calcular, no hay ventas registradas ..."
        Dim v_salida As String = vbNullString
        Dim valor, posicion As Integer
        Dim listado_1, listado_2 As New ArrayList()
        Dim resumen = FrmPppal.listado_de_ventas.AsEnumerable().GroupBy(Function(row) row.Field(Of String)("Nombre Producto"))
        For Each grupo In resumen
            listado_1.Add(grupo.Key)
            listado_2.Add(grupo.Sum(Function(row) row.Field(Of String)("Cantidad Vendida")))
        Next
        posicion = 0
        valor = CInt(listado_2.Item(posicion))
        If objetivo = "MAYOR" Then
            For i As Integer = 0 To listado_2.Count - 1 Step 1
                If listado_2.Item(i) > valor Then
                    valor = CInt(listado_2(i))
                    posicion = i
                End If
            Next
        End If
        If objetivo = "MENOR" Then
            For i As Integer = 0 To listado_2.Count - 1 Step 1
                If listado_2.Item(i) < valor Then
                    valor = CInt(listado_2(i))
                    posicion = i
                End If
            Next
        End If
        v_salida = listado_1.Item(posicion).ToString
        Return v_salida
    End Function
End Class