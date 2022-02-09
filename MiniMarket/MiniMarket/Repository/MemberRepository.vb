Public Class MemberRepository
    Public Function GetMemberById(ByVal memberId As Integer)
        Dim result As New MemberDto
        Try
            Call Koneksi()
            DMLSql = New OleDb.OleDbCommand
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = " SELECT FullName,MembershipNumber,Address,DiscountRate,DiscountFlat
                                    FROM Members WHERE MemberId = ?"

            DMLSql.Parameters.AddWithValue("MemberId", memberId)
            Dim reader = DMLSql.ExecuteReader()
            While reader.Read()
                result.MemberId = memberId
                result.MemberName = reader("FullName")
                result.MembershipNumber = reader("MembershipNumber")
                result.MemberAddress = reader("Address")
                result.DiscountFlat = reader("DiscountFlat")
                result.DiscountRate = reader("DiscountRate")
            End While

        Catch ex As Exception
            result = New MemberDto
        Finally
            DMLSql.Dispose()
        End Try
        Return result
    End Function
End Class
