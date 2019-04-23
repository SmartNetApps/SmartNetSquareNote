Imports Newtonsoft.Json

''' <summary>
''' Représente une collection de Notes.
''' </summary>
Public Class NoteCollection
    Inherits List(Of Note)

    Public Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Crée et retourne une nouvelle instance de NoteCollection à partir d'une collection de notes au format JSON.
    ''' </summary>
    ''' <param name="jsonCollection">La collection de notes au format JSON.</param>
    Public Shared Function FromJsonCollection(jsonCollection As Specialized.StringCollection) As NoteCollection
        Dim theCollection As New NoteCollection()
        For Each note In jsonCollection
            theCollection.Add(JsonConvert.DeserializeObject(Of Note)(note))
        Next
        Return theCollection
    End Function

    ''' <summary>
    ''' Retourne la liste de notes au format JSON.
    ''' </summary>
    ''' <returns></returns>
    Public Function ToJsonCollection() As Specialized.StringCollection
        Dim theCollection As New Specialized.StringCollection()

        For Each note In Me
            theCollection.Add(JsonConvert.SerializeObject(note))
        Next

        Return theCollection
    End Function

    ''' <summary>
    ''' Retourne l'ID le plus grand de la collection de notes.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetHigherId() As Integer
        Dim higher As Integer = 0
        For Each note In Me
            If note.noteID > higher Then
                higher = note.noteID
            End If
        Next
        Return higher
    End Function

    ''' <summary>
    ''' Ajoute ou met à jour la note passée en paramètre.
    ''' </summary>
    ''' <param name="_note"></param>
    Public Sub AddOrUpdate(_note As Note)
        For Each note In Me
            If note.noteID = _note.noteID Then
                note.isVisible = _note.isVisible
                note.noteText = _note.noteText
                Exit Sub
            End If
        Next

        Me.Add(_note)
    End Sub

    Public Sub RemoveNote(_note As Note)
        For Each note In Me
            If note.noteID = _note.noteID Then
                Remove(note)
                Exit Sub
            End If
        Next
    End Sub
End Class
