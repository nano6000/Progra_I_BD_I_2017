Imports System.Data.SqlClient
Imports CpnivelDatos

Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRestaurantes.CellContentClick

    End Sub
    Public Function listaGeneralPedidos()
        Dim encontro As Boolean
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim query As String = "select * from Restaurantes"


        Dim cmd As New SqlCommand(query, conex.MiConexion)
        cmd.CommandType = CommandType.Text

        ' Dim dat As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        Using conex.MiConexion

            Dim loDataAdapter As New SqlDataAdapter(query, conex.MiConexion)
            loDataAdapter.Fill(dt)
            Me.dgvRestaurantes.DataSource = dt
        End Using

        Return encontro
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefreshRes.Click
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
        'TODO: This line of code loads data into the 'Progra_1_I_Sem_2017DataSet4.TiposCocina' table. You can move, or remove it, as needed.
        Me.TiposCocinaTableAdapter.Fill(Me.Progra_1_I_Sem_2017DataSet4.TiposCocina)
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

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkbxRestricRes.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblTipoComidaRes.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles lblBuenoParaRes.Click

    End Sub

    Private Sub chkbxTipoCocinaRes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkbxTipoCocinaRes.SelectedIndexChanged

    End Sub

    Private Sub btnAgregarRes_Click(sender As Object, e As EventArgs) Handles btnAgregarRes.Click
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim agregar As SqlCommand = New SqlCommand("exec sp_insertRestaurant @nombreRes, @direcRes, @ciudadRes, @paisRes, @naturRes, 
                                            @trenRes, @busRes, @taxiRes, @estabRes, @precioRes", conex.MiConexion)


        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try

            agregar.Parameters.Clear()
            agregar.Parameters.AddWithValue("@nombreRes", Convert.ToString(txtNombreRes.Text)) ' Convert.ToString(fila.Cells("idproducto").Value))
            agregar.Parameters.AddWithValue("@direcRes", Convert.ToString(txtDirRes.Text)) 'Convert.ToString(fila.Cells("prove").Value))
            agregar.Parameters.AddWithValue("@ciudadRes", Convert.ToInt32(3936456)) 'Convert.ToString(fila.Cells("descripProd").Value))
            agregar.Parameters.AddWithValue("@paisRes", cmbPaisRes.Text) 'Convert.ToString(cmbPaisRes.SelectedItem.ToString)) 'Convert.ToString(fila.Cells("catego").Value))
            agregar.Parameters.AddWithValue("@naturRes", Convert.ToString(txtDescripRes.Text)) 'Convert.ToString(fila.Cells("preciouni").Value))
            agregar.Parameters.AddWithValue("@trenRes", Convert.ToString(txtTrenRes.Text)) 'Convert.ToString(fila.Cells("cantiE").Value))
            agregar.Parameters.AddWithValue("@busRes", Convert.ToString(txtBusRes.Text)) 'Convert.ToString(fila.Cells("esta").Value))
            agregar.Parameters.AddWithValue("@taxiRes", Convert.ToString(txtTaxRes.Text)) 'Convert.ToString(fila.Cells("esta").Value))
            agregar.Parameters.AddWithValue("@estabRes", cmbTipoEstabRes.Text) 'Convert.ToString(fila.Cells("esta").Value))
            agregar.Parameters.AddWithValue("@precioRes", cmbRangoRes.Text) 'Convert.ToString(fila.Cells("esta").Value))

            agregar.ExecuteNonQuery()

            MsgBox("Se registro correctamente un nuevo producto")
        Catch ex As Exception
            MsgBox("Error al tratar de ingresar los datos" & vbCrLf & ex.Message)

            conex.cerrar()

            '' cargaBoxProductosActivos()
        End Try
    End Sub
End Class
