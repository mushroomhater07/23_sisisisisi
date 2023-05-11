Module VBModule
    Sub Main()
        Dim rand As Integer
        Dim char1 As Integer() = new Integer(){72 ,65 ,80 ,80 ,89 ,32 ,66 ,73 ,82 ,84 ,72 ,68 ,65 ,89 ,32 ,83 ,73}
        Dim read As String = ""
        Dim counter As Integer
        For counter = 0 To char1.Length - 1
            rand = 0
            Do 
                rand += 1
                Console.WriteLine(read + Chr(rand))
                System.Threading.Thread.Sleep(10f)
            Loop Until rand = char1(counter)
            read += Chr(rand)
        Next
    End Sub
End Module
