<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdPemesananLabel As System.Windows.Forms.Label
        Dim NamaPemesananLabel As System.Windows.Forms.Label
        Dim NamaBarangYangDipesanLabel As System.Windows.Forms.Label
        Dim TotalBarangYangDipesanLabel As System.Windows.Forms.Label
        Dim TotalHargaBarangLabel As System.Windows.Forms.Label
        Dim AlamatTujuanPengirimanLabel As System.Windows.Forms.Label
        Dim TanggalPesanBarangLabel As System.Windows.Forms.Label
        Dim TanggalBarangDikirimLabel As System.Windows.Forms.Label
        Dim TanggalBarangDiterimaLabel As System.Windows.Forms.Label
        Dim PotonganHargaLabel As System.Windows.Forms.Label
        Me.PakaianonlineDataSet = New MI_store.pakaianonlineDataSet()
        Me.TbpemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbpemesananTableAdapter = New MI_store.pakaianonlineDataSetTableAdapters.tbpemesananTableAdapter()
        Me.TableAdapterManager = New MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager()
        Me.TbpemesananDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPemesananTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPemesananTextBox = New System.Windows.Forms.TextBox()
        Me.NamaBarangYangDipesanTextBox = New System.Windows.Forms.TextBox()
        Me.TotalBarangYangDipesanTextBox = New System.Windows.Forms.TextBox()
        Me.TotalHargaBarangTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTujuanPengirimanTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalPesanBarangTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalBarangDikirimTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalBarangDiterimaTextBox = New System.Windows.Forms.TextBox()
        Me.PotonganHargaTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        IdPemesananLabel = New System.Windows.Forms.Label()
        NamaPemesananLabel = New System.Windows.Forms.Label()
        NamaBarangYangDipesanLabel = New System.Windows.Forms.Label()
        TotalBarangYangDipesanLabel = New System.Windows.Forms.Label()
        TotalHargaBarangLabel = New System.Windows.Forms.Label()
        AlamatTujuanPengirimanLabel = New System.Windows.Forms.Label()
        TanggalPesanBarangLabel = New System.Windows.Forms.Label()
        TanggalBarangDikirimLabel = New System.Windows.Forms.Label()
        TanggalBarangDiterimaLabel = New System.Windows.Forms.Label()
        PotonganHargaLabel = New System.Windows.Forms.Label()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpemesananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PakaianonlineDataSet
        '
        Me.PakaianonlineDataSet.DataSetName = "pakaianonlineDataSet"
        Me.PakaianonlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbpemesananBindingSource
        '
        Me.TbpemesananBindingSource.DataMember = "tbpemesanan"
        Me.TbpemesananBindingSource.DataSource = Me.PakaianonlineDataSet
        '
        'TbpemesananTableAdapter
        '
        Me.TbpemesananTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbkeuanganTableAdapter = Nothing
        Me.TableAdapterManager.tbpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesanan_has_tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesananTableAdapter = Me.TbpemesananTableAdapter
        Me.TableAdapterManager.UpdateOrder = MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbpemesananDataGridView
        '
        Me.TbpemesananDataGridView.AutoGenerateColumns = False
        Me.TbpemesananDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbpemesananDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TbpemesananDataGridView.DataSource = Me.TbpemesananBindingSource
        Me.TbpemesananDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TbpemesananDataGridView.Name = "TbpemesananDataGridView"
        Me.TbpemesananDataGridView.Size = New System.Drawing.Size(1042, 220)
        Me.TbpemesananDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idPemesanan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idPemesanan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "namaPemesanan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "namaPemesanan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "namaBarangYangDipesan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "namaBarangYangDipesan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "totalBarangYangDipesan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "totalBarangYangDipesan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "totalHargaBarang"
        Me.DataGridViewTextBoxColumn5.HeaderText = "totalHargaBarang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "alamatTujuanPengiriman"
        Me.DataGridViewTextBoxColumn6.HeaderText = "alamatTujuanPengiriman"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tanggalPesanBarang"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tanggalPesanBarang"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tanggalBarangDikirim"
        Me.DataGridViewTextBoxColumn8.HeaderText = "tanggalBarangDikirim"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "tanggalBarangDiterima"
        Me.DataGridViewTextBoxColumn9.HeaderText = "tanggalBarangDiterima"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "potonganHarga"
        Me.DataGridViewTextBoxColumn10.HeaderText = "potonganHarga"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'IdPemesananLabel
        '
        IdPemesananLabel.AutoSize = True
        IdPemesananLabel.Location = New System.Drawing.Point(17, 261)
        IdPemesananLabel.Name = "IdPemesananLabel"
        IdPemesananLabel.Size = New System.Drawing.Size(77, 13)
        IdPemesananLabel.TabIndex = 2
        IdPemesananLabel.Text = "id Pemesanan:"
        '
        'IdPemesananTextBox
        '
        Me.IdPemesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "idPemesanan", True))
        Me.IdPemesananTextBox.Location = New System.Drawing.Point(166, 258)
        Me.IdPemesananTextBox.Name = "IdPemesananTextBox"
        Me.IdPemesananTextBox.Size = New System.Drawing.Size(370, 20)
        Me.IdPemesananTextBox.TabIndex = 3
        '
        'NamaPemesananLabel
        '
        NamaPemesananLabel.AutoSize = True
        NamaPemesananLabel.Location = New System.Drawing.Point(17, 287)
        NamaPemesananLabel.Name = "NamaPemesananLabel"
        NamaPemesananLabel.Size = New System.Drawing.Size(95, 13)
        NamaPemesananLabel.TabIndex = 4
        NamaPemesananLabel.Text = "nama Pemesanan:"
        '
        'NamaPemesananTextBox
        '
        Me.NamaPemesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "namaPemesanan", True))
        Me.NamaPemesananTextBox.Location = New System.Drawing.Point(166, 284)
        Me.NamaPemesananTextBox.Name = "NamaPemesananTextBox"
        Me.NamaPemesananTextBox.Size = New System.Drawing.Size(370, 20)
        Me.NamaPemesananTextBox.TabIndex = 5
        '
        'NamaBarangYangDipesanLabel
        '
        NamaBarangYangDipesanLabel.AutoSize = True
        NamaBarangYangDipesanLabel.Location = New System.Drawing.Point(17, 313)
        NamaBarangYangDipesanLabel.Name = "NamaBarangYangDipesanLabel"
        NamaBarangYangDipesanLabel.Size = New System.Drawing.Size(143, 13)
        NamaBarangYangDipesanLabel.TabIndex = 6
        NamaBarangYangDipesanLabel.Text = "nama Barang Yang Dipesan:"
        '
        'NamaBarangYangDipesanTextBox
        '
        Me.NamaBarangYangDipesanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "namaBarangYangDipesan", True))
        Me.NamaBarangYangDipesanTextBox.Location = New System.Drawing.Point(166, 310)
        Me.NamaBarangYangDipesanTextBox.Name = "NamaBarangYangDipesanTextBox"
        Me.NamaBarangYangDipesanTextBox.Size = New System.Drawing.Size(370, 20)
        Me.NamaBarangYangDipesanTextBox.TabIndex = 7
        '
        'TotalBarangYangDipesanLabel
        '
        TotalBarangYangDipesanLabel.AutoSize = True
        TotalBarangYangDipesanLabel.Location = New System.Drawing.Point(17, 339)
        TotalBarangYangDipesanLabel.Name = "TotalBarangYangDipesanLabel"
        TotalBarangYangDipesanLabel.Size = New System.Drawing.Size(137, 13)
        TotalBarangYangDipesanLabel.TabIndex = 8
        TotalBarangYangDipesanLabel.Text = "total Barang Yang Dipesan:"
        '
        'TotalBarangYangDipesanTextBox
        '
        Me.TotalBarangYangDipesanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "totalBarangYangDipesan", True))
        Me.TotalBarangYangDipesanTextBox.Location = New System.Drawing.Point(166, 336)
        Me.TotalBarangYangDipesanTextBox.Name = "TotalBarangYangDipesanTextBox"
        Me.TotalBarangYangDipesanTextBox.Size = New System.Drawing.Size(370, 20)
        Me.TotalBarangYangDipesanTextBox.TabIndex = 9
        '
        'TotalHargaBarangLabel
        '
        TotalHargaBarangLabel.AutoSize = True
        TotalHargaBarangLabel.Location = New System.Drawing.Point(17, 365)
        TotalHargaBarangLabel.Name = "TotalHargaBarangLabel"
        TotalHargaBarangLabel.Size = New System.Drawing.Size(99, 13)
        TotalHargaBarangLabel.TabIndex = 10
        TotalHargaBarangLabel.Text = "total Harga Barang:"
        '
        'TotalHargaBarangTextBox
        '
        Me.TotalHargaBarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "totalHargaBarang", True))
        Me.TotalHargaBarangTextBox.Location = New System.Drawing.Point(166, 362)
        Me.TotalHargaBarangTextBox.Name = "TotalHargaBarangTextBox"
        Me.TotalHargaBarangTextBox.Size = New System.Drawing.Size(370, 20)
        Me.TotalHargaBarangTextBox.TabIndex = 11
        '
        'AlamatTujuanPengirimanLabel
        '
        AlamatTujuanPengirimanLabel.AutoSize = True
        AlamatTujuanPengirimanLabel.Location = New System.Drawing.Point(17, 391)
        AlamatTujuanPengirimanLabel.Name = "AlamatTujuanPengirimanLabel"
        AlamatTujuanPengirimanLabel.Size = New System.Drawing.Size(132, 13)
        AlamatTujuanPengirimanLabel.TabIndex = 12
        AlamatTujuanPengirimanLabel.Text = "alamat Tujuan Pengiriman:"
        '
        'AlamatTujuanPengirimanTextBox
        '
        Me.AlamatTujuanPengirimanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "alamatTujuanPengiriman", True))
        Me.AlamatTujuanPengirimanTextBox.Location = New System.Drawing.Point(166, 388)
        Me.AlamatTujuanPengirimanTextBox.Name = "AlamatTujuanPengirimanTextBox"
        Me.AlamatTujuanPengirimanTextBox.Size = New System.Drawing.Size(370, 20)
        Me.AlamatTujuanPengirimanTextBox.TabIndex = 13
        '
        'TanggalPesanBarangLabel
        '
        TanggalPesanBarangLabel.AutoSize = True
        TanggalPesanBarangLabel.Location = New System.Drawing.Point(17, 417)
        TanggalPesanBarangLabel.Name = "TanggalPesanBarangLabel"
        TanggalPesanBarangLabel.Size = New System.Drawing.Size(115, 13)
        TanggalPesanBarangLabel.TabIndex = 14
        TanggalPesanBarangLabel.Text = "tanggal Pesan Barang:"
        '
        'TanggalPesanBarangTextBox
        '
        Me.TanggalPesanBarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "tanggalPesanBarang", True))
        Me.TanggalPesanBarangTextBox.Location = New System.Drawing.Point(166, 414)
        Me.TanggalPesanBarangTextBox.Name = "TanggalPesanBarangTextBox"
        Me.TanggalPesanBarangTextBox.Size = New System.Drawing.Size(370, 20)
        Me.TanggalPesanBarangTextBox.TabIndex = 15
        '
        'TanggalBarangDikirimLabel
        '
        TanggalBarangDikirimLabel.AutoSize = True
        TanggalBarangDikirimLabel.Location = New System.Drawing.Point(17, 443)
        TanggalBarangDikirimLabel.Name = "TanggalBarangDikirimLabel"
        TanggalBarangDikirimLabel.Size = New System.Drawing.Size(116, 13)
        TanggalBarangDikirimLabel.TabIndex = 16
        TanggalBarangDikirimLabel.Text = "tanggal Barang Dikirim:"
        '
        'TanggalBarangDikirimTextBox
        '
        Me.TanggalBarangDikirimTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "tanggalBarangDikirim", True))
        Me.TanggalBarangDikirimTextBox.Location = New System.Drawing.Point(166, 440)
        Me.TanggalBarangDikirimTextBox.Name = "TanggalBarangDikirimTextBox"
        Me.TanggalBarangDikirimTextBox.Size = New System.Drawing.Size(370, 20)
        Me.TanggalBarangDikirimTextBox.TabIndex = 17
        '
        'TanggalBarangDiterimaLabel
        '
        TanggalBarangDiterimaLabel.AutoSize = True
        TanggalBarangDiterimaLabel.Location = New System.Drawing.Point(17, 469)
        TanggalBarangDiterimaLabel.Name = "TanggalBarangDiterimaLabel"
        TanggalBarangDiterimaLabel.Size = New System.Drawing.Size(123, 13)
        TanggalBarangDiterimaLabel.TabIndex = 18
        TanggalBarangDiterimaLabel.Text = "tanggal Barang Diterima:"
        '
        'TanggalBarangDiterimaTextBox
        '
        Me.TanggalBarangDiterimaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "tanggalBarangDiterima", True))
        Me.TanggalBarangDiterimaTextBox.Location = New System.Drawing.Point(166, 466)
        Me.TanggalBarangDiterimaTextBox.Name = "TanggalBarangDiterimaTextBox"
        Me.TanggalBarangDiterimaTextBox.Size = New System.Drawing.Size(370, 20)
        Me.TanggalBarangDiterimaTextBox.TabIndex = 19
        '
        'PotonganHargaLabel
        '
        PotonganHargaLabel.AutoSize = True
        PotonganHargaLabel.Location = New System.Drawing.Point(17, 495)
        PotonganHargaLabel.Name = "PotonganHargaLabel"
        PotonganHargaLabel.Size = New System.Drawing.Size(87, 13)
        PotonganHargaLabel.TabIndex = 20
        PotonganHargaLabel.Text = "potongan Harga:"
        '
        'PotonganHargaTextBox
        '
        Me.PotonganHargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "potonganHarga", True))
        Me.PotonganHargaTextBox.Location = New System.Drawing.Point(166, 492)
        Me.PotonganHargaTextBox.Name = "PotonganHargaTextBox"
        Me.PotonganHargaTextBox.Size = New System.Drawing.Size(370, 20)
        Me.PotonganHargaTextBox.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(542, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(542, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(542, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(542, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 529)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdPemesananLabel)
        Me.Controls.Add(Me.IdPemesananTextBox)
        Me.Controls.Add(NamaPemesananLabel)
        Me.Controls.Add(Me.NamaPemesananTextBox)
        Me.Controls.Add(NamaBarangYangDipesanLabel)
        Me.Controls.Add(Me.NamaBarangYangDipesanTextBox)
        Me.Controls.Add(TotalBarangYangDipesanLabel)
        Me.Controls.Add(Me.TotalBarangYangDipesanTextBox)
        Me.Controls.Add(TotalHargaBarangLabel)
        Me.Controls.Add(Me.TotalHargaBarangTextBox)
        Me.Controls.Add(AlamatTujuanPengirimanLabel)
        Me.Controls.Add(Me.AlamatTujuanPengirimanTextBox)
        Me.Controls.Add(TanggalPesanBarangLabel)
        Me.Controls.Add(Me.TanggalPesanBarangTextBox)
        Me.Controls.Add(TanggalBarangDikirimLabel)
        Me.Controls.Add(Me.TanggalBarangDikirimTextBox)
        Me.Controls.Add(TanggalBarangDiterimaLabel)
        Me.Controls.Add(Me.TanggalBarangDiterimaTextBox)
        Me.Controls.Add(PotonganHargaLabel)
        Me.Controls.Add(Me.PotonganHargaTextBox)
        Me.Controls.Add(Me.TbpemesananDataGridView)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpemesananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PakaianonlineDataSet As MI_store.pakaianonlineDataSet
    Friend WithEvents TbpemesananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbpemesananTableAdapter As MI_store.pakaianonlineDataSetTableAdapters.tbpemesananTableAdapter
    Friend WithEvents TableAdapterManager As MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbpemesananDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPemesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaPemesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaBarangYangDipesanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBarangYangDipesanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalHargaBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTujuanPengirimanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalPesanBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalBarangDikirimTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalBarangDiterimaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PotonganHargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
