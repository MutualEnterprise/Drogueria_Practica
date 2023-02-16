Public Class Inventario
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BTN_Pedidos_Click(sender As Object, e As EventArgs) Handles BTN_Pedidos.Click
        Pedidos.Show()
        Me.Close()
    End Sub
End Class