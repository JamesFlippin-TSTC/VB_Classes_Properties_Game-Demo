'*******************************************
'*******************************************
'Programmer: James Flippin
'Course: ITSE 1332.10x1 (VB)
'Program purpose: This is the class file that
'                 is the basis for the player
'                 or the monster in this game
'*******************************************
'*******************************************

#Region "Compiler_Directives"

'*******************************************
Option Explicit On
Option Strict On
Option Infer Off
#Disable Warning IDE1006
'*******************************************

#End Region

Public Class clsPlayer

    'Private Variables only viewable/accessible within the class
    'Typically private variables in classes are prefixes with an _ to denote private
    Private _strName As String = String.Empty

    Private _strTeam As String = String.Empty
    Private _intDamageCanCause As Integer = 0
    Private _intHealthPoints As Integer = 0
    Public _bolDead As Boolean = False

    'A sub for later use with a "Start new Game" option to reset the values
    Public Sub Reset()
        _bolDead = False
        _strName = String.Empty
        _strTeam = String.Empty
        _intDamageCanCause = 0
        _intHealthPoints = 0
    End Sub

    'Used to indicate the player/monster based on this class is alive or dead
    Public ReadOnly Property bolDead As Boolean
        Get
            Return _bolDead
        End Get
    End Property

    'Holds the name of the player or the type of the Monster
    'IE: Bob or Space Squid
    Public Property strName As String
        Set(strValue As String)
            _strName = strValue
        End Set
        Get
            Return _strName
        End Get
    End Property

    'Holds the name of the Team the player belongs to,
    'But for monsters, it is just left empty
    'IE: Gardians of the Galaxy
    Public Property strTeam As String
        Set(strValue As String)
            _strTeam = strValue
        End Set
        Get
            Return _strTeam
        End Get
    End Property

    'Sets or retrieves the amount of damage the player or monster can cause
    Public Property intDamageCanCause As Integer
        Set(intValue As Integer)
            _intDamageCanCause = intValue

        End Set
        Get
            Return _intDamageCanCause
        End Get
    End Property

    'Sets or retrieves the amount of Help points the player or monster currently has
    Public Property intHeathPoints As Integer
        Set(intValue As Integer)
            _intHealthPoints = intValue
        End Set
        Get
            Return _intHealthPoints
        End Get
    End Property

    'Sets the amount of damage done by a successful attack
    Public Sub Attacked(ByVal intDamageDone As Integer)
        _intHealthPoints -= intDamageDone
        If _intHealthPoints <= 0 Then
            _bolDead = True
        End If
    End Sub

End Class