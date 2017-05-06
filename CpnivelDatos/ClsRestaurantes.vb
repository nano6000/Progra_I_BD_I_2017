Public Class ClsRestaurantes
    Public Sub New()
    End Sub

    Private id As Int16
    Public Property xid() As Int16
        Get
            Return id
        End Get
        Set(ByVal idres As Int16)
            id = idres
        End Set
    End Property


    Private nombre As String
    Public Property xnombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal nombreRes As String)
            nombre = nombreRes
        End Set
    End Property

    Private direccion As String
    Public Property xdireccion() As String
        Get
            Return direccion
        End Get
        Set(ByVal direccionRes As String)
            direccion = direccionRes
        End Set
    End Property

    Private ciudad As Int16
    Public Property xciudad() As Int16
        Get
            Return ciudad
        End Get
        Set(ByVal ciud As Int16)
            ciudad = ciud
        End Set
    End Property

    Private pais As String
    Public Property xpais() As String
        Get
            Return pais
        End Get
        Set(ByVal paisRes As String)
            pais = paisRes
        End Set
    End Property

    Private descripcion As String
    Public Property xdescripcion() As String
        Get
            Return descripcion
        End Get
        Set(ByVal descripcionRes As String)
            descripcion = descripcionRes
        End Set
    End Property


    Private instrucciones As String
    Public Property xinstrucciones() As String
        Get
            Return instrucciones
        End Get
        Set(ByVal instruc As String)
            instrucciones = instruc
        End Set
    End Property

    Private tipoEstablecimiento As String
    Public Property xtipoEstablecimiento() As String
        Get
            Return tipoEstablecimiento
        End Get
        Set(ByVal tipoEstab As String)
            tipoEstablecimiento = tipoEstab
        End Set
    End Property

    Private rangoPrecio As String
    Public Property xrangoPrecio() As String
        Get
            Return rangoPrecio
        End Get
        Set(ByVal rangoPrecioRes As String)
            rangoPrecio = rangoPrecioRes
        End Set
    End Property


End Class
