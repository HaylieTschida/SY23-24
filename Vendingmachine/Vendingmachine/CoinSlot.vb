Public Class CoinSlot
    Public Event CoinReturnEvent(d As Integer, q As Integer, di As Integer, N As Integer)

    Public Property Dollars As Integer
    Public Property Quarters As Integer
    Public Property Dimes As Integer
    Public Property Nickels As Integer
    Public ReadOnly Property Total As Decimal
        Get
            Return Nickels * 0.05 + Dimes * 0.1 + Quarters * 0.25 + Dollars
        End Get
    End Property
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
End Class
