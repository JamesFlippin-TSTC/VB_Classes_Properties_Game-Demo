Public Class clsPlayer

    'Private Variables only viewable/accessible within the class
    'Typically private variables in classes are prefixes with an _ to denote private
    Private _strName As String = String.Empty

    Private _strTeam As String = String.Empty
    Private _intDamageCanCause As Integer = 0
    Private _intHealthPoints As Integer = 0
    Public _bolDead As Boolean = False

    Public Sub Reset()
        _bolDead = False
    End Sub

    Public ReadOnly Property bolDead As Boolean
        Get
            Return _bolDead
        End Get
    End Property

    Public Property strName As String
        Set(strValue As String)
            _strName = strValue
        End Set
        Get
            Return _strName
        End Get
    End Property

    Public Property strTeam As String
        Set(strValue As String)
            _strTeam = strValue
        End Set
        Get
            Return _strTeam
        End Get
    End Property

    Public Property intDamageCanCause As Integer
        Set(intValue As Integer)
            _intDamageCanCause = intValue

        End Set
        Get
            Return _intDamageCanCause
        End Get
    End Property

    Public Property intHeathPoints As Integer
        Set(intValue As Integer)
            _intHealthPoints = intValue
        End Set
        Get
            Return _intHealthPoints
        End Get
    End Property

    Public Sub Attacked(ByVal intDamageDone As Integer)
        _intHealthPoints -= intDamageDone
        If _intHealthPoints <= 0 Then
            _bolDead = True
        End If
    End Sub

End Class