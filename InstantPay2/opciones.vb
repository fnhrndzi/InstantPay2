Public Class opciones
    Private Sub btn_registrohoras_Click(sender As Object, e As EventArgs) Handles btn_registrohoras.Click
        registrohoras.Show()
        Me.Hide()
    End Sub

    Private Sub btn_calcularpago_Click(sender As Object, e As EventArgs) Handles btn_calcularpago.Click
        calcular.Show()
        Me.Hide()
    End Sub

    Private Sub btn_agregarcolab_Click(sender As Object, e As EventArgs) Handles btn_agregarcolab.Click
        agregar.Show()
        Me.Hide()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea salir del programa?", vbYesNo, "Salir del Modulo")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub
End Class