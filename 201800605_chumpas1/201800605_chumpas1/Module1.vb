Module Module1
    Public Const msmall = 65.5
    Public Const mmed = 85.99
    Public Const mlarge = 99.99

    Public Const talgodon = 15.0
    Public Const tseda = 23.99
    Public Const tlona = 30.99

    Dim totalparcial = 0
    Dim manodeobra = 0
    Dim total = 0

    Sub Limpiar()
        Form1.CBSMALL.Checked = False
        Form1.CBMED.Checked = False
        Form1.CBLARGE.Checked = False
        Form1.ALDODONT.Checked = False
        Form1.RBLONA.Checked = False
        Form1.RBSEDA.Checked = False
        Form1.CBSMALL.Enabled = True
        Form1.CBMED.Enabled = True
        Form1.CBLARGE.Enabled = True
        Form1.ALDODONT.Enabled = True
        Form1.RBLONA.Enabled = True
        Form1.RBSEDA.Enabled = True
    End Sub


    Function calcularCompraSmall(mano As Double, tipo As Double) As Double

        total = mano + (2 * tipo)

        Return Math.Round(total, 2)
    End Function

    Function calcularCompraMed(mano As Double, tipo As Double) As Double

        total = mano + (2.5 * tipo)

        Return Math.Round(total, 2)
    End Function

    Function calcularCompraGrande(mano As Double, tipo As Double) As Double

        total = mano + (3 * tipo)

        Return Math.Round(total, 2)
    End Function


End Module
