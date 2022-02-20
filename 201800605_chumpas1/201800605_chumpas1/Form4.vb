Public Class Form
    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.CBSMALL.Checked And Form1.ALDODONT.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraSmall(msmall, talgodon))
        End If

        If Form1.CBSMALL.Checked And Form1.RBSEDA.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraSmall(msmall, tseda))
        End If

        If Form1.CBSMALL.Checked And Form1.RBLONA.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraSmall(msmall, tlona))
        End If

        If Form1.CBMED.Checked And Form1.ALDODONT.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraMed(mmed, talgodon))
        End If

        If Form1.CBMED.Checked And Form1.RBSEDA.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraMed(mmed, tseda))
        End If

        If Form1.CBMED.Checked And Form1.RBLONA.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraMed(mmed, tlona))
        End If

        If Form1.CBLARGE.Checked And Form1.ALDODONT.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraGrande(mlarge, talgodon))
        End If

        If Form1.CBLARGE.Checked And Form1.RBSEDA.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraGrande(mlarge, tseda))
        End If

        If Form1.CBLARGE.Checked And Form1.RBLONA.Checked Then
            Label1.Text = " El precio total de la chumpa es: " + Str(calcularCompraGrande(mlarge, tlona))
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class