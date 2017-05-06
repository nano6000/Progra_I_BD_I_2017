Imports System.Data.SqlClient
Imports CpnivelDatos

Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Public Function listaGeneralPedidos()
        Dim encontro As Boolean
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim query As String = "exec sp_Rests"


        Dim cmd As New SqlCommand(query, conex.MiConexion)
        cmd.CommandType = CommandType.Text

        ' Dim dat As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        Using conex.MiConexion

            Dim loDataAdapter As New SqlDataAdapter(query, conex.MiConexion)
            loDataAdapter.Fill(dt)
            Me.DataGridView1.DataSource = dt
        End Using

        Return encontro
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listaGeneralPedidos()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNombreRes.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblCiudadRes.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPaisRes_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoEstabRes.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Progra_1_I_Sem_2017DataSet3.Paises' table. You can move, or remove it, as needed.
        Me.PaisesTableAdapter.Fill(Me.Progra_1_I_Sem_2017DataSet3.Paises)
        'TODO: This line of code loads data into the 'Progra_1_I_Sem_2017DataSet2.Ciudades' table. You can move, or remove it, as needed.
        Me.CiudadesTableAdapter.Fill(Me.Progra_1_I_Sem_2017DataSet2.Ciudades)
        'TODO: This line of code loads data into the 'Progra_1_I_Sem_2017DataSet1.RangoPrecios' table. You can move, or remove it, as needed.
        Me.RangoPreciosTableAdapter.Fill(Me.Progra_1_I_Sem_2017DataSet1.RangoPrecios)
        'TODO: This line of code loads data into the 'Progra_1_I_Sem_2017DataSet.EstablecimientoTipos' table. You can move, or remove it, as needed.
        Me.EstablecimientoTiposTableAdapter.Fill(Me.Progra_1_I_Sem_2017DataSet.EstablecimientoTipos)

    End Sub

    Private Sub lblTipoEstabRes_Click(sender As Object, e As EventArgs) Handles lblTipoEstabRes.Click

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CiudadesTableAdapter.FillBy(Me.Progra_1_I_Sem_2017DataSet2.Ciudades)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.CiudadesTableAdapter.FillBy(Me.Progra_1_I_Sem_2017DataSet2.Ciudades)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
