Module Module1

    Sub Main()
        Dim charge As Integer = 5
        For i = 1 To 10
            Console.WriteLine(RunningTotal(charge))
        Next

        Console.WriteLine(RunningTotal(0))
        Console.Read()
    End Sub

    Function RunningTotal(ByVal currentCharge As Integer) As Integer
        Static _runningTotal As Integer
        For i = 1 To 10
            _runningTotal = _runningTotal + currentCharge
        Next


        Return _runningTotal
    End Function

    'Function firstNumber() As Integer
    '    Return 5
    'End Function

    'Function sum(ByVal firstNumber As Integer, ByVal numTwo As Integer) As Integer
    '    Console.WriteLine($"in sum secondNumber is {numTwo}")
    '    Return firstNumber + numTwo
    'End Function

End Module
