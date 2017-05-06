Imports System.Data.SqlClient

Public Class conexion
    Public MiConexion As New SqlConnection
    Public enlace As String
    Public Sub Conectar()
        enlace = "Data Source=NANO\SQLMASTER;Initial Catalog=Progra_1_I_Sem_2017;Integrated Security=True"
        MiConexion = New SqlConnection(enlace)
        MiConexion.Open()
    End Sub

    Public Sub cerrar()
        MiConexion.Close()
    End Sub
End Class
