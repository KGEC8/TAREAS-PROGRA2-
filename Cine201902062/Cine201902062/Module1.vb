Module Module1
    Public cantidad As Integer
    Public vfuncion(cantidad)
    Public vcine(cantidad)
    Public vsubtotal(cantidad)
    Public vdescuento1(cantidad)
    Public vdescuento2(cantidad)
    Public vtotal(cantidad)
    Public indice = 0

    Public calculosubtotal As Double = 0
    Public calculdescuento1 As Double = 0



    Function calcularsubtotal(ByVal funcion As String, ByVal cine As String) As Double

        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculosubtotal = 30
                    Case "2"
                        calculosubtotal = 35
                    Case Else
                        calculosubtotal = 40
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculosubtotal = 24
                    Case "2"
                        calculosubtotal = 34
                    Case Else
                        calculosubtotal = 44
                End Select
            Case "C"
                Select Case funcion
                    Case "1"
                        calculosubtotal = 35
                    Case "2"
                        calculosubtotal = 40
                    Case Else
                        calculosubtotal = 40
                End Select
        End Select
        Return calculosubtotal

    End Function

    Function calculodescuento1(ByVal funcion As String, ByVal cine As String) As Double
        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculdescuento1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculdescuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculdescuento1 = 0.015

        End If
        Return calculdescuento1
    End Function

End Module
