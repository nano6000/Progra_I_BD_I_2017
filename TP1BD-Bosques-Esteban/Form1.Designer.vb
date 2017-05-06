<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AdmRes = New System.Windows.Forms.TabPage()
        Me.cmbCiudadRes = New System.Windows.Forms.ComboBox()
        Me.CiudadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Progra_1_I_Sem_2017DataSet2 = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSet2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTaxRes = New System.Windows.Forms.TextBox()
        Me.cmbRangoRes = New System.Windows.Forms.ComboBox()
        Me.RangoPreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Progra_1_I_Sem_2017DataSet1 = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSet1()
        Me.cmbTipoEstabRes = New System.Windows.Forms.ComboBox()
        Me.EstablecimientoTiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Progra_1_I_Sem_2017DataSet = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSet()
        Me.lblRangoRes = New System.Windows.Forms.Label()
        Me.txtNombreRes = New System.Windows.Forms.TextBox()
        Me.lblTipoEstabRes = New System.Windows.Forms.Label()
        Me.lblNombreRes = New System.Windows.Forms.Label()
        Me.lblTrenRes = New System.Windows.Forms.Label()
        Me.txtDirRes = New System.Windows.Forms.TextBox()
        Me.txtTrenRes = New System.Windows.Forms.TextBox()
        Me.lblDirRes = New System.Windows.Forms.Label()
        Me.lblBusRes = New System.Windows.Forms.Label()
        Me.lblCiudadRes = New System.Windows.Forms.Label()
        Me.txtBusRes = New System.Windows.Forms.TextBox()
        Me.lblPaisRes = New System.Windows.Forms.Label()
        Me.lblTaxiRes = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDescripRes = New System.Windows.Forms.Label()
        Me.AdmPlat = New System.Windows.Forms.TabPage()
        Me.AdmColab = New System.Windows.Forms.TabPage()
        Me.AdmComent = New System.Windows.Forms.TabPage()
        Me.Consultas = New System.Windows.Forms.TabPage()
        Me.EstablecimientoTiposTableAdapter = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSetTableAdapters.EstablecimientoTiposTableAdapter()
        Me.RangoPreciosTableAdapter = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSet1TableAdapters.RangoPreciosTableAdapter()
        Me.CiudadesTableAdapter = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSet2TableAdapters.CiudadesTableAdapter()
        Me.cmbPaisRes = New System.Windows.Forms.ComboBox()
        Me.Progra_1_I_Sem_2017DataSet3 = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSet3()
        Me.PaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaisesTableAdapter = New TP1BD_Bosques_Esteban.Progra_1_I_Sem_2017DataSet3TableAdapters.PaisesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.AdmRes.SuspendLayout()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Progra_1_I_Sem_2017DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangoPreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Progra_1_I_Sem_2017DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstablecimientoTiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Progra_1_I_Sem_2017DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Progra_1_I_Sem_2017DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1008, 196)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(735, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AdmRes)
        Me.TabControl1.Controls.Add(Me.AdmPlat)
        Me.TabControl1.Controls.Add(Me.AdmColab)
        Me.TabControl1.Controls.Add(Me.AdmComent)
        Me.TabControl1.Controls.Add(Me.Consultas)
        Me.TabControl1.Location = New System.Drawing.Point(3, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1029, 543)
        Me.TabControl1.TabIndex = 2
        '
        'AdmRes
        '
        Me.AdmRes.Controls.Add(Me.cmbPaisRes)
        Me.AdmRes.Controls.Add(Me.cmbCiudadRes)
        Me.AdmRes.Controls.Add(Me.Label2)
        Me.AdmRes.Controls.Add(Me.Label1)
        Me.AdmRes.Controls.Add(Me.txtTaxRes)
        Me.AdmRes.Controls.Add(Me.cmbRangoRes)
        Me.AdmRes.Controls.Add(Me.DataGridView1)
        Me.AdmRes.Controls.Add(Me.cmbTipoEstabRes)
        Me.AdmRes.Controls.Add(Me.Button1)
        Me.AdmRes.Controls.Add(Me.lblRangoRes)
        Me.AdmRes.Controls.Add(Me.txtNombreRes)
        Me.AdmRes.Controls.Add(Me.lblTipoEstabRes)
        Me.AdmRes.Controls.Add(Me.lblNombreRes)
        Me.AdmRes.Controls.Add(Me.lblTrenRes)
        Me.AdmRes.Controls.Add(Me.txtDirRes)
        Me.AdmRes.Controls.Add(Me.txtTrenRes)
        Me.AdmRes.Controls.Add(Me.lblDirRes)
        Me.AdmRes.Controls.Add(Me.lblBusRes)
        Me.AdmRes.Controls.Add(Me.lblCiudadRes)
        Me.AdmRes.Controls.Add(Me.txtBusRes)
        Me.AdmRes.Controls.Add(Me.lblPaisRes)
        Me.AdmRes.Controls.Add(Me.lblTaxiRes)
        Me.AdmRes.Controls.Add(Me.TextBox1)
        Me.AdmRes.Controls.Add(Me.lblDescripRes)
        Me.AdmRes.Location = New System.Drawing.Point(4, 22)
        Me.AdmRes.Name = "AdmRes"
        Me.AdmRes.Padding = New System.Windows.Forms.Padding(3)
        Me.AdmRes.Size = New System.Drawing.Size(1021, 517)
        Me.AdmRes.TabIndex = 0
        Me.AdmRes.Text = "Adm Restaurante"
        Me.AdmRes.UseVisualStyleBackColor = True
        '
        'cmbCiudadRes
        '
        Me.cmbCiudadRes.DataSource = Me.CiudadesBindingSource
        Me.cmbCiudadRes.DisplayMember = "name"
        Me.cmbCiudadRes.FormattingEnabled = True
        Me.cmbCiudadRes.Location = New System.Drawing.Point(241, 17)
        Me.cmbCiudadRes.Name = "cmbCiudadRes"
        Me.cmbCiudadRes.Size = New System.Drawing.Size(100, 21)
        Me.cmbCiudadRes.TabIndex = 25
        Me.cmbCiudadRes.ValueMember = "name"
        '
        'CiudadesBindingSource
        '
        Me.CiudadesBindingSource.DataMember = "Ciudades"
        Me.CiudadesBindingSource.DataSource = Me.Progra_1_I_Sem_2017DataSet2
        '
        'Progra_1_I_Sem_2017DataSet2
        '
        Me.Progra_1_I_Sem_2017DataSet2.DataSetName = "Progra_1_I_Sem_2017DataSet2"
        Me.Progra_1_I_Sem_2017DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Restricciones dieteticas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(732, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tipo Cocina:"
        '
        'txtTaxRes
        '
        Me.txtTaxRes.Location = New System.Drawing.Point(406, 17)
        Me.txtTaxRes.Name = "txtTaxRes"
        Me.txtTaxRes.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxRes.TabIndex = 13
        '
        'cmbRangoRes
        '
        Me.cmbRangoRes.DataSource = Me.RangoPreciosBindingSource
        Me.cmbRangoRes.DisplayMember = "rango"
        Me.cmbRangoRes.FormattingEnabled = True
        Me.cmbRangoRes.Location = New System.Drawing.Point(833, 17)
        Me.cmbRangoRes.Name = "cmbRangoRes"
        Me.cmbRangoRes.Size = New System.Drawing.Size(100, 21)
        Me.cmbRangoRes.TabIndex = 22
        Me.cmbRangoRes.ValueMember = "rango"
        '
        'RangoPreciosBindingSource
        '
        Me.RangoPreciosBindingSource.DataMember = "RangoPrecios"
        Me.RangoPreciosBindingSource.DataSource = Me.Progra_1_I_Sem_2017DataSet1
        '
        'Progra_1_I_Sem_2017DataSet1
        '
        Me.Progra_1_I_Sem_2017DataSet1.DataSetName = "Progra_1_I_Sem_2017DataSet1"
        Me.Progra_1_I_Sem_2017DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbTipoEstabRes
        '
        Me.cmbTipoEstabRes.DataSource = Me.EstablecimientoTiposBindingSource
        Me.cmbTipoEstabRes.DisplayMember = "tipoEstab"
        Me.cmbTipoEstabRes.FormattingEnabled = True
        Me.cmbTipoEstabRes.Location = New System.Drawing.Point(626, 51)
        Me.cmbTipoEstabRes.Name = "cmbTipoEstabRes"
        Me.cmbTipoEstabRes.Size = New System.Drawing.Size(100, 21)
        Me.cmbTipoEstabRes.TabIndex = 21
        Me.cmbTipoEstabRes.ValueMember = "tipoEstab"
        '
        'EstablecimientoTiposBindingSource
        '
        Me.EstablecimientoTiposBindingSource.DataMember = "EstablecimientoTipos"
        Me.EstablecimientoTiposBindingSource.DataSource = Me.Progra_1_I_Sem_2017DataSet
        '
        'Progra_1_I_Sem_2017DataSet
        '
        Me.Progra_1_I_Sem_2017DataSet.DataSetName = "Progra_1_I_Sem_2017DataSet"
        Me.Progra_1_I_Sem_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblRangoRes
        '
        Me.lblRangoRes.AutoSize = True
        Me.lblRangoRes.Location = New System.Drawing.Point(732, 20)
        Me.lblRangoRes.Name = "lblRangoRes"
        Me.lblRangoRes.Size = New System.Drawing.Size(95, 13)
        Me.lblRangoRes.TabIndex = 20
        Me.lblRangoRes.Text = "Rango de Precios:"
        '
        'txtNombreRes
        '
        Me.txtNombreRes.Location = New System.Drawing.Point(82, 17)
        Me.txtNombreRes.Name = "txtNombreRes"
        Me.txtNombreRes.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreRes.TabIndex = 2
        '
        'lblTipoEstabRes
        '
        Me.lblTipoEstabRes.AutoSize = True
        Me.lblTipoEstabRes.Location = New System.Drawing.Point(512, 54)
        Me.lblTipoEstabRes.Name = "lblTipoEstabRes"
        Me.lblTipoEstabRes.Size = New System.Drawing.Size(108, 13)
        Me.lblTipoEstabRes.TabIndex = 18
        Me.lblTipoEstabRes.Text = "Tipo Establecimiento:"
        '
        'lblNombreRes
        '
        Me.lblNombreRes.AutoSize = True
        Me.lblNombreRes.Location = New System.Drawing.Point(21, 20)
        Me.lblNombreRes.Name = "lblNombreRes"
        Me.lblNombreRes.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreRes.TabIndex = 3
        Me.lblNombreRes.Text = "Nombre:"
        '
        'lblTrenRes
        '
        Me.lblTrenRes.AutoSize = True
        Me.lblTrenRes.Location = New System.Drawing.Point(512, 20)
        Me.lblTrenRes.Name = "lblTrenRes"
        Me.lblTrenRes.Size = New System.Drawing.Size(51, 13)
        Me.lblTrenRes.TabIndex = 17
        Me.lblTrenRes.Text = "Por Tren:"
        '
        'txtDirRes
        '
        Me.txtDirRes.Location = New System.Drawing.Point(82, 51)
        Me.txtDirRes.Name = "txtDirRes"
        Me.txtDirRes.Size = New System.Drawing.Size(100, 20)
        Me.txtDirRes.TabIndex = 4
        '
        'txtTrenRes
        '
        Me.txtTrenRes.Location = New System.Drawing.Point(626, 17)
        Me.txtTrenRes.Name = "txtTrenRes"
        Me.txtTrenRes.Size = New System.Drawing.Size(100, 20)
        Me.txtTrenRes.TabIndex = 16
        '
        'lblDirRes
        '
        Me.lblDirRes.AutoSize = True
        Me.lblDirRes.Location = New System.Drawing.Point(21, 54)
        Me.lblDirRes.Name = "lblDirRes"
        Me.lblDirRes.Size = New System.Drawing.Size(55, 13)
        Me.lblDirRes.TabIndex = 5
        Me.lblDirRes.Text = "Direccion:"
        '
        'lblBusRes
        '
        Me.lblBusRes.AutoSize = True
        Me.lblBusRes.Location = New System.Drawing.Point(347, 54)
        Me.lblBusRes.Name = "lblBusRes"
        Me.lblBusRes.Size = New System.Drawing.Size(47, 13)
        Me.lblBusRes.TabIndex = 15
        Me.lblBusRes.Text = "Por Bus:"
        '
        'lblCiudadRes
        '
        Me.lblCiudadRes.AutoSize = True
        Me.lblCiudadRes.Location = New System.Drawing.Point(188, 20)
        Me.lblCiudadRes.Name = "lblCiudadRes"
        Me.lblCiudadRes.Size = New System.Drawing.Size(43, 13)
        Me.lblCiudadRes.TabIndex = 6
        Me.lblCiudadRes.Text = "Ciudad:"
        '
        'txtBusRes
        '
        Me.txtBusRes.Location = New System.Drawing.Point(406, 51)
        Me.txtBusRes.Name = "txtBusRes"
        Me.txtBusRes.Size = New System.Drawing.Size(100, 20)
        Me.txtBusRes.TabIndex = 14
        '
        'lblPaisRes
        '
        Me.lblPaisRes.AutoSize = True
        Me.lblPaisRes.Location = New System.Drawing.Point(189, 54)
        Me.lblPaisRes.Name = "lblPaisRes"
        Me.lblPaisRes.Size = New System.Drawing.Size(30, 13)
        Me.lblPaisRes.TabIndex = 8
        Me.lblPaisRes.Text = "Pais:"
        '
        'lblTaxiRes
        '
        Me.lblTaxiRes.AutoSize = True
        Me.lblTaxiRes.Location = New System.Drawing.Point(347, 20)
        Me.lblTaxiRes.Name = "lblTaxiRes"
        Me.lblTaxiRes.Size = New System.Drawing.Size(49, 13)
        Me.lblTaxiRes.TabIndex = 12
        Me.lblTaxiRes.Text = "Por Taxi:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(413, 20)
        Me.TextBox1.TabIndex = 11
        '
        'lblDescripRes
        '
        Me.lblDescripRes.AutoSize = True
        Me.lblDescripRes.Location = New System.Drawing.Point(21, 123)
        Me.lblDescripRes.Name = "lblDescripRes"
        Me.lblDescripRes.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripRes.TabIndex = 10
        Me.lblDescripRes.Text = "Descripcion:"
        '
        'AdmPlat
        '
        Me.AdmPlat.Location = New System.Drawing.Point(4, 22)
        Me.AdmPlat.Name = "AdmPlat"
        Me.AdmPlat.Padding = New System.Windows.Forms.Padding(3)
        Me.AdmPlat.Size = New System.Drawing.Size(1021, 517)
        Me.AdmPlat.TabIndex = 1
        Me.AdmPlat.Text = "Adm Platillos"
        Me.AdmPlat.UseVisualStyleBackColor = True
        '
        'AdmColab
        '
        Me.AdmColab.Location = New System.Drawing.Point(4, 22)
        Me.AdmColab.Name = "AdmColab"
        Me.AdmColab.Size = New System.Drawing.Size(1021, 517)
        Me.AdmColab.TabIndex = 2
        Me.AdmColab.Text = "Adm Colaboradores"
        Me.AdmColab.UseVisualStyleBackColor = True
        '
        'AdmComent
        '
        Me.AdmComent.Location = New System.Drawing.Point(4, 22)
        Me.AdmComent.Name = "AdmComent"
        Me.AdmComent.Size = New System.Drawing.Size(1021, 517)
        Me.AdmComent.TabIndex = 3
        Me.AdmComent.Text = "Adm Comentarios"
        Me.AdmComent.UseVisualStyleBackColor = True
        '
        'Consultas
        '
        Me.Consultas.Location = New System.Drawing.Point(4, 22)
        Me.Consultas.Name = "Consultas"
        Me.Consultas.Size = New System.Drawing.Size(1021, 517)
        Me.Consultas.TabIndex = 4
        Me.Consultas.Text = "Consultas"
        Me.Consultas.UseVisualStyleBackColor = True
        '
        'EstablecimientoTiposTableAdapter
        '
        Me.EstablecimientoTiposTableAdapter.ClearBeforeFill = True
        '
        'RangoPreciosTableAdapter
        '
        Me.RangoPreciosTableAdapter.ClearBeforeFill = True
        '
        'CiudadesTableAdapter
        '
        Me.CiudadesTableAdapter.ClearBeforeFill = True
        '
        'cmbPaisRes
        '
        Me.cmbPaisRes.DataSource = Me.PaisesBindingSource
        Me.cmbPaisRes.DisplayMember = "iso2"
        Me.cmbPaisRes.FormattingEnabled = True
        Me.cmbPaisRes.Location = New System.Drawing.Point(241, 51)
        Me.cmbPaisRes.Name = "cmbPaisRes"
        Me.cmbPaisRes.Size = New System.Drawing.Size(100, 21)
        Me.cmbPaisRes.TabIndex = 26
        Me.cmbPaisRes.ValueMember = "iso2"
        '
        'Progra_1_I_Sem_2017DataSet3
        '
        Me.Progra_1_I_Sem_2017DataSet3.DataSetName = "Progra_1_I_Sem_2017DataSet3"
        Me.Progra_1_I_Sem_2017DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaisesBindingSource
        '
        Me.PaisesBindingSource.DataMember = "Paises"
        Me.PaisesBindingSource.DataSource = Me.Progra_1_I_Sem_2017DataSet3
        '
        'PaisesTableAdapter
        '
        Me.PaisesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 544)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.AdmRes.ResumeLayout(False)
        Me.AdmRes.PerformLayout()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Progra_1_I_Sem_2017DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangoPreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Progra_1_I_Sem_2017DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstablecimientoTiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Progra_1_I_Sem_2017DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Progra_1_I_Sem_2017DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AdmRes As TabPage
    Friend WithEvents AdmPlat As TabPage
    Friend WithEvents AdmColab As TabPage
    Friend WithEvents AdmComent As TabPage
    Friend WithEvents Consultas As TabPage
    Friend WithEvents lblNombreRes As Label
    Friend WithEvents txtNombreRes As TextBox
    Friend WithEvents lblCiudadRes As Label
    Friend WithEvents lblDirRes As Label
    Friend WithEvents txtDirRes As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDescripRes As Label
    Friend WithEvents lblPaisRes As Label
    Friend WithEvents cmbRangoRes As ComboBox
    Friend WithEvents cmbTipoEstabRes As ComboBox
    Friend WithEvents lblRangoRes As Label
    Friend WithEvents lblTipoEstabRes As Label
    Friend WithEvents lblTrenRes As Label
    Friend WithEvents txtTrenRes As TextBox
    Friend WithEvents lblBusRes As Label
    Friend WithEvents txtBusRes As TextBox
    Friend WithEvents txtTaxRes As TextBox
    Friend WithEvents lblTaxiRes As Label
    Friend WithEvents Progra_1_I_Sem_2017DataSet As Progra_1_I_Sem_2017DataSet
    Friend WithEvents EstablecimientoTiposBindingSource As BindingSource
    Friend WithEvents EstablecimientoTiposTableAdapter As Progra_1_I_Sem_2017DataSetTableAdapters.EstablecimientoTiposTableAdapter
    Friend WithEvents Progra_1_I_Sem_2017DataSet1 As Progra_1_I_Sem_2017DataSet1
    Friend WithEvents RangoPreciosBindingSource As BindingSource
    Friend WithEvents RangoPreciosTableAdapter As Progra_1_I_Sem_2017DataSet1TableAdapters.RangoPreciosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCiudadRes As ComboBox
    Friend WithEvents Progra_1_I_Sem_2017DataSet2 As Progra_1_I_Sem_2017DataSet2
    Friend WithEvents CiudadesBindingSource As BindingSource
    Friend WithEvents CiudadesTableAdapter As Progra_1_I_Sem_2017DataSet2TableAdapters.CiudadesTableAdapter
    Friend WithEvents cmbPaisRes As ComboBox
    Friend WithEvents Progra_1_I_Sem_2017DataSet3 As Progra_1_I_Sem_2017DataSet3
    Friend WithEvents PaisesBindingSource As BindingSource
    Friend WithEvents PaisesTableAdapter As Progra_1_I_Sem_2017DataSet3TableAdapters.PaisesTableAdapter
End Class
