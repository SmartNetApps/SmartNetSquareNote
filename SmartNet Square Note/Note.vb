''' <summary>
''' Représente une note.
''' </summary>
Public Class Note
    ''' <summary>
    ''' L'identifiant numérique de la note.
    ''' </summary>
    Public noteID As Integer
    ''' <summary>
    ''' Le texte de la note.
    ''' </summary>
    Public noteText As String
    ''' <summary>
    ''' Booléen déterminant si la note est visible ou cachée.
    ''' </summary>
    Public isVisible As Boolean

    Public Sub New()
        noteID = 0
        noteText = ""
        isVisible = True
    End Sub

    Public Sub New(id As Integer)
        noteID = id
        noteText = ""
        isVisible = True
    End Sub

    Public Sub New(id As Integer, text As String)
        noteID = id
        noteText = text
        isVisible = True
    End Sub

    Public Sub New(id As Integer, text As String, visible As Boolean)
        noteID = id
        noteText = text
        isVisible = visible
    End Sub
End Class
