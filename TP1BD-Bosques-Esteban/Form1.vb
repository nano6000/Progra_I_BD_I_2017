Imports System.Data.SqlClient
Imports CpnivelDatos

Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRestaurantes.CellContentClick

    End Sub
    Public Function refrescarRestaurantes()
        Dim encontro As Boolean
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim query As String = "exec sp_viewRestaurant"


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
        refrescarRestaurantes()
    End Sub

    Public Function cargarTiposCocina()
        Dim encontro As Boolean
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()

        Dim dt As New DataTable
        Using conex.MiConexion
            Dim query As String = "select * from TiposCocina"
            Dim cmd As New SqlCommand(query, conex.MiConexion)
            cmd.CommandType = CommandType.Text

            Dim dat As New SqlDataAdapter()
            dat.SelectCommand = cmd


            'Dim loDataAdapter As New SqlDataAdapter(query, conex.MiConexion)
            dat.Fill(dt)
        End Using

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                chkbxTipoCocinaRes.Items.Add(CStr(dt.Rows(i).Item(0)), False)
            Next
        End If
        Return encontro
    End Function

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

        cargarTiposCocina()

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

    Public Function agregarRest()
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim agregar As SqlCommand = New SqlCommand("exec sp_insertRestaurant @nombreRes, @direcRes, @ciudadRes, @paisRes, @naturRes, 
                                            @trenRes, @busRes, @taxiRes, @estabRes, @precioRes", conex.MiConexion)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try

            agregar.Parameters.Clear()
            agregar.Parameters.AddWithValue("@nombreRes", Convert.ToString(txtNombreRes.Text))
            agregar.Parameters.AddWithValue("@direcRes", Convert.ToString(txtDirRes.Text))
            agregar.Parameters.AddWithValue("@ciudadRes", cmbCiudadRes.Text)
            agregar.Parameters.AddWithValue("@paisRes", cmbPaisRes.Text)
            agregar.Parameters.AddWithValue("@naturRes", Convert.ToString(txtDescripRes.Text))
            agregar.Parameters.AddWithValue("@trenRes", Convert.ToString(txtTrenRes.Text))
            agregar.Parameters.AddWithValue("@busRes", Convert.ToString(txtBusRes.Text))
            agregar.Parameters.AddWithValue("@taxiRes", Convert.ToString(txtTaxRes.Text))
            agregar.Parameters.AddWithValue("@estabRes", cmbTipoEstabRes.Text)
            agregar.Parameters.AddWithValue("@precioRes", cmbRangoRes.Text)

            agregar.ExecuteNonQuery()

            MsgBox("Se registro correctamente un nuevo producto")
        Catch ex As Exception
            MsgBox("Error al tratar de ingresar los datos" & vbCrLf & ex.Message)

            conex.cerrar()

            '' cargaBoxProductosActivos()
        End Try
        Return True
    End Function

    Public Function agregarTipoCocina()
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim agregar As SqlCommand = New SqlCommand("exec sp_addtipoCocina @nombreRes, @tipoCocina", conex.MiConexion)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each li In chkbxTipoCocinaRes.CheckedItems
            Try
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@nombreRes", Convert.ToString(txtNombreRes.Text))
                agregar.Parameters.AddWithValue("@tipoCocina", li.ToString())
                agregar.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error al tratar de ingresar los datos" & vbCrLf & ex.Message)

                conex.cerrar()
            End Try
        Next
        Return True
    End Function

    Public Function agregarRestriccDiet()
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim agregar As SqlCommand = New SqlCommand("exec sp_addRestricRes @nombreRes, @restric", conex.MiConexion)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each li In chkbxRestricRes.CheckedItems
            Try
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@nombreRes", Convert.ToString(txtNombreRes.Text))
                agregar.Parameters.AddWithValue("@restric", li.ToString())
                agregar.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error al tratar de ingresar los datos" & vbCrLf & ex.Message)

                conex.cerrar()
            End Try
        Next
        Return True
    End Function

    Public Function agregarTipoComida()
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim agregar As SqlCommand = New SqlCommand("exec sp_addTipoComidaRes @nombreRes, @tipo", conex.MiConexion)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each li In chkbxTipoComidaRes.CheckedItems
            Try
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@nombreRes", Convert.ToString(txtNombreRes.Text))
                agregar.Parameters.AddWithValue("@tipo", li.ToString())
                agregar.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error al tratar de ingresar los datos" & vbCrLf & ex.Message)

                conex.cerrar()
            End Try
        Next
        Return True
    End Function

    Public Function agregarBuenoPara()
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim agregar As SqlCommand = New SqlCommand("exec sp_addBuenoPara @nombreRes, @bueno", conex.MiConexion)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each li In chkbxBuenoParaRes.CheckedItems
            Try
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@nombreRes", Convert.ToString(txtNombreRes.Text))
                agregar.Parameters.AddWithValue("@bueno", li.ToString())
                agregar.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error al tratar de ingresar los datos" & vbCrLf & ex.Message)

                conex.cerrar()
            End Try
        Next
        Return True
    End Function

    Private Sub btnAgregarRes_Click(sender As Object, e As EventArgs) Handles btnAgregarRes.Click
        agregarRest()
        agregarTipoCocina()
        agregarBuenoPara()
        agregarRestriccDiet()
        agregarTipoComida()
    End Sub

    Private Sub btnModRes_Click(sender As Object, e As EventArgs) Handles btnModRes.Click
        txtNombreRes.Text = dgvRestaurantes.SelectedRows.Item(0).Cells(0).Value
        txtDirRes.Text = dgvRestaurantes.SelectedRows.Item(0).Cells(1).Value
        txtDescripRes.Text = dgvRestaurantes.SelectedRows.Item(0).Cells(4).Value
        txtTrenRes.Text = dgvRestaurantes.SelectedRows.Item(0).Cells(5).Value
        txtBusRes.Text = dgvRestaurantes.SelectedRows.Item(0).Cells(6).Value
        txtTaxRes.Text = dgvRestaurantes.SelectedRows.Item(0).Cells(7).Value

    End Sub

    Public Function refrescarPlatillos()
        Dim encontro As Boolean
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim query As String = " exec sp_viewPlatillos"


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

    Private Sub btnRefrescarPlat_Click(sender As Object, e As EventArgs) Handles btnRefrescarPlat.Click
        refrescarPlatillos()
    End Sub

    Private Sub btnAgregarPlat_Click(sender As Object, e As EventArgs) Handles btnAgregarPlat.Click
        Dim conex As New CpnivelDatos.conexion
        conex.Conectar()
        Dim agregar As SqlCommand = New SqlCommand("exec sp_insertPlat @nombrePlat, @nombreRes, @descrip", conex.MiConexion)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try
            agregar.Parameters.Clear()
            agregar.Parameters.AddWithValue("@nombrePlat", Convert.ToString(txtNombrePlat.Text))
            agregar.Parameters.AddWithValue("@nombreRes", Convert.ToString(txtNombreRes.Text))
            agregar.Parameters.AddWithValue("@descrip", Convert.ToString(txtDescripPlat.Text))
            agregar.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error al tratar de ingresar los datos" & vbCrLf & ex.Message)

            conex.cerrar()
        End Try
    End Sub
End Class
