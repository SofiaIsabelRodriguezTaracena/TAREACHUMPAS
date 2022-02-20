Public Class Form1
    Private Sub CBSMALL_CheckedChanged(sender As Object, e As EventArgs) Handles CBSMALL.CheckedChanged
        If CBSMALL.Checked = True Then
            MATERIAL.Enabled = True
            CBMED.Enabled = False
            CBLARGE.Enabled = False
        End If
    End Sub

    Private Sub CBMED_CheckedChanged(sender As Object, e As EventArgs) Handles CBMED.CheckedChanged
        If CBMED.Checked = True Then
            MATERIAL.Enabled = True
            CBSMALL.Enabled = False
            CBLARGE.Enabled = False
        End If
    End Sub

    Private Sub CBLARGE_CheckedChanged(sender As Object, e As EventArgs) Handles CBLARGE.CheckedChanged
        If CBLARGE.Checked = True Then
            MATERIAL.Enabled = True
            CBSMALL.Enabled = False
            CBMED.Enabled = False
        End If
    End Sub

    Private Sub ALDODONT_CheckedChanged(sender As Object, e As EventArgs) Handles ALDODONT.CheckedChanged
        If ALDODONT.Checked = True Then
            RBLONA.Enabled = False
            RBSEDA.Enabled = False
        End If
    End Sub

    Private Sub RBSEDA_CheckedChanged(sender As Object, e As EventArgs) Handles RBSEDA.CheckedChanged
        If RBSEDA.Checked = True Then
            RBLONA.Enabled = False
            ALDODONT.Enabled = False
        End If
    End Sub

    Private Sub RBLONA_CheckedChanged(sender As Object, e As EventArgs) Handles RBLONA.CheckedChanged
        If RBLONA.Checked = True Then
            ALDODONT.Enabled = False
            RBSEDA.Enabled = False
        End If
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles BLimpio.Click
        Limpiar()
    End Sub

    Private Sub ACEPTAR_Click(sender As Object, e As EventArgs) Handles ACEPTAR.Click
        Form.Show()
        Me.Hide()
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
