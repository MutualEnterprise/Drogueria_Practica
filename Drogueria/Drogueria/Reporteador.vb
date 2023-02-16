Public Class Reporteador
    Public msg1, msg2 As String
    Public tipo As Integer

    Private Sub Btn_Volver_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click
        Me.Close()
    End Sub

    Private Sub Reporteador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_producto.Text = vbNullString
        lbl_titulo.Text = vbNullString
        DGV_Reporte_de_ventas.Visible = False
        If Not IsNothing(msg1) Then
            lbl_titulo.Text = "El producto con " + msg1 + " numero de ventas es :"
        End If
        If Not IsNothing(msg2) Then
            lbl_producto.Text = msg2
        End If
        If tipo <> 0 Then
            DGV_Reporte_de_ventas.DataSource = FrmPppal.listado_de_ventas
            DGV_Reporte_de_ventas.Visible = True
        End If
    End Sub
End Class