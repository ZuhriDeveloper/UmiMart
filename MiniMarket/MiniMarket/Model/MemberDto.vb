Public Class MemberDto

    Public Sub New()
        DiscountFlat = 0
        DiscountRate = 0
    End Sub

    Private _memberId As Integer
    Public Property MemberId() As Integer
        Get
            Return _memberId
        End Get
        Set(ByVal value As Integer)
            _memberId = value
        End Set
    End Property
    Private _memberName As String
    Public Property MemberName() As String
        Get
            Return _memberName
        End Get
        Set(ByVal value As String)
            _memberName = value
        End Set
    End Property

    Private _membershipNumber As String
    Public Property MembershipNumber() As String
        Get
            Return _membershipNumber
        End Get
        Set(ByVal value As String)
            _membershipNumber = value
        End Set
    End Property

    Private _memberAddress As String
    Public Property MemberAddress() As String
        Get
            Return _memberAddress
        End Get
        Set(ByVal value As String)
            _memberAddress = value
        End Set
    End Property

    Private _discountRate As Double
    Public Property DiscountRate() As Double
        Get
            Return _discountRate
        End Get
        Set(ByVal value As Double)
            _discountRate = value
        End Set
    End Property

    Private _discountFlat As Decimal
    Public Property DiscountFlat() As Decimal
        Get
            Return _discountFlat
        End Get
        Set(ByVal value As Decimal)
            _discountFlat = value
        End Set
    End Property
End Class
