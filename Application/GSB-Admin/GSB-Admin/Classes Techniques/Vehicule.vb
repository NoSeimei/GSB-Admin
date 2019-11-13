Public Class Vehicule
    Private m_immat As Integer
    Private m_puiss As Integer
    Private m_modeleEtMarque As String


    Sub New(immat As Integer, puiss As Integer, modeleEtMarque As String)
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

End Class
