Public Class CoinSlot
    Public Event CoinReturnEvent(d As Integer, q As Integer, di As Integer, N As Integer)
    Dim _total As Decimal
    Public Event dispence(p As Image)
    Public ReadOnly Property Total As Decimal
        Get
            _total = (Nickels * 0.05) + (Dimes * 0.1) + (Quarters * 0.25) + Dollars
            Return _total
        End Get
    End Property
    Public Property Dollars As Integer
    Public Property Quarters As Integer
    Public Property Dimes As Integer
    Public Property Nickels As Integer

    Public Sub insertQuarter()
        Quarters += 1
    End Sub
    Public Sub insertDime()
        Dimes += 1
    End Sub
    Public Sub insertNickel()
        Nickels += 1
    End Sub
    Public Sub insertDollar()
        Dollars += 1
    End Sub
    Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Dimes, Nickels)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickels = 0
    End Sub
    Public Sub Buy(p As ProductControl)
        If p.Productcount > 0 And p.ProductPrice <= _total Then
            _total = _total - p.ProductPrice
            p.buy()
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nickels = _total / 0.05
            RaiseEvent dispence(p.ProductImage)
        End If

    End Sub
End Class
