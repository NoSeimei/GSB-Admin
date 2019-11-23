﻿Public Class Vehicule

    Private m_immat As String
    Private m_puiss As Integer
    Private m_modeleEtMarque As String


    Sub New(immat As String, puiss As Integer, modeleEtMarque As String)
        m_immat = immat
        m_puiss = puiss
        m_modeleEtMarque = modeleEtMarque
    End Sub

    Property LireImmat
        Get
            Return m_immat
        End Get
        Set(value)
            m_immat = value
        End Set
    End Property

    Property LirePuiss
        Get
            Return m_puiss
        End Get
        Set(value)
            m_puiss = value
        End Set
    End Property

    Property LireModele
        Get
            Return m_modeleEtMarque
        End Get
        Set(value)
            m_modeleEtMarque = value
        End Set
    End Property


    Function verif_voitureUtilise(vehicule As Vehicule) As Boolean
        Dim verif As Boolean = False

        For Each utilise In CollectionVoitureUtiliser
            If utilise.vehiculeVoiture() = vehicule Then
                If utilise.dateFin Is Nothing Then
                    verif = True
                End If
            End If
        Next

            Return verif
    End Function

End Class
