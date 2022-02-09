Public Class FakturDto
    Public Sub New()
        ListDetail = New List(Of FakturDetailDto)
    End Sub

    Private _noFaktur As String
    Public Property NoFaktur() As String
        Get
            Return _noFaktur
        End Get
        Set(ByVal value As String)
            _noFaktur = value
        End Set
    End Property

    Private _tglTransaksi As DateTime
    Public Property TglTransaksi() As DateTime
        Get
            Return _tglTransaksi
        End Get
        Set(ByVal value As DateTime)
            _tglTransaksi = value
        End Set
    End Property

    Private _pelanggan As String
    Public Property Pelanggan() As String
        Get
            Return _pelanggan
        End Get
        Set(ByVal value As String)
            _pelanggan = value
        End Set
    End Property

    Private _pelangganId As Integer
    Public Property PelangganId() As Integer
        Get
            Return _pelangganId
        End Get
        Set(ByVal value As Integer)
            _pelangganId = value
        End Set
    End Property

    Private _kasir As String
    Public Property Kasir() As String
        Get
            Return _kasir
        End Get
        Set(ByVal value As String)
            _kasir = value
        End Set
    End Property

    Private _totalBayar As Decimal
    Public Property TotalBayar() As Decimal
        Get
            Return _totalBayar
        End Get
        Set(ByVal value As Decimal)
            _totalBayar = value
        End Set
    End Property

    Private _bayar As Decimal
    Public Property Bayar() As Decimal
        Get
            Return _bayar
        End Get
        Set(ByVal value As Decimal)
            _bayar = value
        End Set
    End Property

    Private _kembali As Decimal
    Public Property Kembali() As Decimal
        Get
            Return _kembali
        End Get
        Set(ByVal value As Decimal)
            _kembali = value
        End Set
    End Property

    Private _diskon As Decimal
    Public Property Diskon() As Decimal
        Get
            Return _diskon
        End Get
        Set(ByVal value As Decimal)
            _diskon = value
        End Set
    End Property

    Private _voucher As Decimal
    Public Property Voucher() As Decimal
        Get
            Return _voucher
        End Get
        Set(ByVal value As Decimal)
            _voucher = value
        End Set
    End Property

    Private _listDetail As List(Of FakturDetailDto)
    Public Property ListDetail() As List(Of FakturDetailDto)
        Get
            Return _listDetail
        End Get
        Set(ByVal value As List(Of FakturDetailDto))
            _listDetail = value
        End Set
    End Property

End Class

Public Class FakturDetailDto
    Private _namaBarang As String
    Public Property NamaBarang() As String
        Get
            Return _namaBarang
        End Get
        Set(ByVal value As String)
            _namaBarang = value
        End Set
    End Property

    Private _hargaJual As Decimal
    Public Property HargaJual() As Decimal
        Get
            Return _hargaJual
        End Get
        Set(ByVal value As Decimal)
            _hargaJual = value
        End Set
    End Property

    Private _jmlJual As Integer
    Public Property JmlJual() As Integer
        Get
            Return _jmlJual
        End Get
        Set(ByVal value As Integer)
            _jmlJual = value
        End Set
    End Property

    Private _subTotal As Decimal
    Public Property SubTotal() As Decimal
        Get
            Return _subTotal
        End Get
        Set(ByVal value As Decimal)
            _subTotal = value
        End Set
    End Property
End Class
