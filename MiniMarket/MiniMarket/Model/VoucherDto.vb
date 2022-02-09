Public Class VoucherDto
    Private _voucherId As Integer
    Public Property VoucherId() As Integer
        Get
            Return _voucherId
        End Get
        Set(ByVal value As Integer)
            _voucherId = value
        End Set
    End Property

    Private _voucherCode As String
    Public Property VoucherCode() As String
        Get
            Return _voucherCode
        End Get
        Set(ByVal value As String)
            _voucherCode = value
        End Set
    End Property

    Private _nominal As Decimal
    Public Property Nominal() As Decimal
        Get
            Return _nominal
        End Get
        Set(ByVal value As Decimal)
            _nominal = value
        End Set
    End Property

    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Private _validFrom As DateTime
    Public Property ValidFrom() As DateTime
        Get
            Return _validFrom
        End Get
        Set(ByVal value As DateTime)
            _validFrom = value
        End Set
    End Property

    Private _validTo As DateTime?
    Public Property ValidTo() As DateTime?
        Get
            Return _validTo
        End Get
        Set(ByVal value As DateTime?)
            _validTo = value
        End Set
    End Property

    Private _memberId As Integer
    Public Property MemberId() As Integer
        Get
            Return _memberId
        End Get
        Set(ByVal value As Integer)
            _memberId = value
        End Set
    End Property

    Private _noFaktur As String
    Public Property No_Faktur() As String
        Get
            Return _noFaktur
        End Get
        Set(ByVal value As String)
            _noFaktur = value
        End Set
    End Property
End Class
