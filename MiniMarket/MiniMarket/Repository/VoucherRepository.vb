Imports System.Data.OleDb

Public Class VoucherRepository
    Public Function GetVoucherByCode(ByVal voucherCode As String) As VoucherDto
        Dim result As New VoucherDto
        Try
            Call Koneksi()
            DMLSql = New OleDb.OleDbCommand
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = " SELECT VoucherId,VoucherCode,ValidFrom,ValidTo,Status,Nominal
                                    FROM Vouchers WHERE VoucherCode = ?"

            DMLSql.Parameters.AddWithValue("VoucherCode", voucherCode)
            Dim reader = DMLSql.ExecuteReader()
            While reader.Read()
                result.VoucherId = reader("VoucherId")
                result.VoucherCode = reader("VoucherCode")
                result.ValidFrom = reader("ValidFrom")
                result.ValidTo = IIf(IsDBNull(reader("ValidTo")), Nothing, reader("ValidTo"))
                result.Status = reader("Status")
                result.Nominal = reader("Nominal")
                Exit While
            End While
        Catch ex As Exception
            result = New VoucherDto
        Finally
            DMLSql.Dispose()
        End Try

        Return result
    End Function

    Public Sub UpdateVoucherStatus(ByVal listVoucher As List(Of VoucherDto), ByVal No_Faktur As String)

        For Each voucher In listVoucher
            Try
                Call Koneksi()
                DMLSql = New OleDb.OleDbCommand
                DMLSql.Connection = Database
                DMLSql.CommandType = CommandType.Text

                DMLSql.CommandText = " UPDATE Vouchers SET Status = 'TERPAKAI' , No_Faktur = ? , LastModified = GETDATE(), UsageDate = GETDATE()
                                       WHERE VoucherId = ?"
                DMLSql.Parameters.AddWithValue("No_Faktur", No_Faktur)
                DMLSql.Parameters.AddWithValue("VoucherId", voucher.VoucherId)
                DMLSql.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                DMLSql.Dispose()
            End Try
        Next
    End Sub
End Class
