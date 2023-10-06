Imports System.Security.Cryptography.X509Certificates

Module Module1

    Sub Main()

        'literala()
        Literalb()

    End Sub
    Sub literala()
        Dim precio = 75
        Dim cambio, pago, faltante, suma, comple As Double

        Console.WriteLine("COSTO DEL PRODUCTO= 75 dolares")

        Console.WriteLine("Ingrese el monto de dinero")
        pago = Console.ReadLine()

        If pago > precio Then
            cambio = pago - precio
            Console.WriteLine("Su cambio es " & cambio)
            Console.WriteLine("Gracias por su compra")

        ElseIf pago = precio Then

            Console.WriteLine("Gracias por su compra")

        ElseIf pago < precio Then

            faltante = precio - pago

            Console.WriteLine("Debe agregar la cantidad de " & faltante)
            Console.WriteLine("Introduzca el pago solicitado")
            comple = Console.ReadLine()

            suma = comple + pago


        ElseIf suma = precio Then
            Console.WriteLine("Gracias por su compra")

        Else
            Console.WriteLine("Regrese otro dia por su producto")

        End If
    End Sub
    Sub Literalb()

        Console.WriteLine("Escriba 1.- Si Desea Ingresar Una compra ")
        Console.WriteLine("Escriba 2.- Si Desea Salir de la compra ")
        Dim compra As Integer = Console.ReadLine()

        If compra = 1 Then
            Console.WriteLine("Ingrese el monto de compra: ")
            Dim monto As Integer = Console.ReadLine()
            If monto <= -1 Then
                Console.WriteLine("Debe ingresar valores positivos")
            End If
            If monto > 500 Then
                Dim Subtotal As Integer = monto * 0.05
                Dim totalaPagar As Integer = monto - Subtotal
                Console.WriteLine("El Total a pagar es: " & totalaPagar)
            End If
            If monto > 1000 Then
                Dim Subtotal As Integer = monto * 0.1
                Dim totalaPagar As Integer = monto - Subtotal
                Console.WriteLine("El Total a pagar es: " & totalaPagar)
            End If
            If monto <= 500 Then
                Console.WriteLine("El Total a pagar es: " & monto)
            End If
        End If

    End Sub

End Module
