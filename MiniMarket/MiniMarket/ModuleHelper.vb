Imports System.Runtime.CompilerServices

Module ModuleHelper

    <Extension()>
    Public Function RemoveCommaAndDot(ByVal aString As String) As String
        Return aString.Replace(".", "").Replace(",", "")
    End Function

    <Extension()>
    Public Function ToDecWithoutCommaAndDot(ByVal aString As String) As String
        Try
            Return CDec(aString.Replace(".", "").Replace(",", ""))
        Catch ex As Exception
            Return 0
        End Try

    End Function

End Module
