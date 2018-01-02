Imports System

Module Program
    Sub Main(args As String())
        Console.ForegroundColor = ConsoleColor.Cyan

        Console.WriteLine("Hello World!" & vbCrLf)
        Console.WriteLine("Type some text and hit enter...")
        Dim inputStr As String = Console.ReadLine()
        If inputStr.Trim = "" Then
            Console.WriteLine("Too bad you didn't listen.....bye bye")
        Else
            Console.WriteLine(String.Format("You entered the following text: {0}{1}{2}", inputStr, vbCrLf, "Press a key to close this window."))
        End If
        Console.ReadKey()
    End Sub
End Module
