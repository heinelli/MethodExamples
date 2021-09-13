Module Module1

    Sub Main()
        Dim secondNumber As Integer = 6
        Console.WriteLine($"in main secondNumber is {secondNumber}")
        'Console.WriteLine(firstNumber() + secondNumber)
        Console.WriteLine(sum(3, 8))
        Console.WriteLine($"in after sum and back in main secondNumber is {secondNumber}")


        Console.Read()
    End Sub

    Function firstNumber() As Integer
        Return 5
    End Function

    Function sum(ByVal firstNumber As Integer, ByVal secondNumber As Integer) As Integer
        Console.WriteLine($"in sum secondNumber is {secondNumber}")
        Return firstNumber + secondNumber
    End Function

End Module
