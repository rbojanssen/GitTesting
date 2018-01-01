Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!" & vbCrLf)
        Console.WriteLine("Type some text and hit enter...")
        Dim inputStr As String = Console.ReadLine()
        Console.WriteLine(String.Format("You entered the following text: {0}{1}{2}", inputStr, vbCrLf, "Press a key to close this window."))
        Console.ReadKey()
    End Sub
End Module
