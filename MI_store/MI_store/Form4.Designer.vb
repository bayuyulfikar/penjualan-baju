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
        Me.TbpemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PakaianonlineDataSet = New MI_store.pakaianonlineDataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbpemesananTableAdapter = New MI_store.pakaianonlineDataSetTableAdapters.tbpemesananTableAdapter()
        Me.TableAdapterManager = New MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager()
        Me.IdPemesananTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPemesananTextBox = New System.Windows.Forms.TextBox()
        Me.NamaBarangYangDipesanTextBox = New System.Windows.Forms.TextBox()
        Me.TotalBarangYangDipesanTextBox = New System.Windows.Forms.TextBox()
        Me.TotalHargaBarangTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTujuanPengirimanTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalPesanBarangDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.TanggalBarangDikirimDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.TanggalBarangDiterimaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PotonganHargaTextBox = New System.Windows.Forms.TextBox()
        Me.BATALButton = New System.Windows.Forms.Button()
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
        CType(Me.TbpemesananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalPesanBarangDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalPesanBarangDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalBarangDikirimDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalBarangDikirimDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalBarangDiterimaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalBarangDiterimaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdPemesananLabel
        '
        IdPemesananLabel.AutoSize = True
        IdPemesananLabel.Location = New System.Drawing.Point(17, 271)
        IdPemesananLabel.Name = "IdPemesananLabel"
        IdPemesananLabel.Size = New System.Drawing.Size(77, 13)
        IdPemesananLabel.TabIndex = 25
        IdPemesananLabel.Text = "id Pemesanan:"
        '
        'NamaPemesananLabel
        '
        NamaPemesananLabel.AutoSize = True
        NamaPemesananLabel.Location = New System.Drawing.Point(17, 297)
        NamaPemesananLabel.Name = "NamaPemesananLabel"
        NamaPemesananLabel.Size = New System.Drawing.Size(95, 13)
        NamaPemesananLabel.TabIndex = 27
        NamaPemesananLabel.Text = "nama Pemesanan:"
        '
        'NamaBarangYangDipesanLabel
        '
        NamaBarangYangDipesanLabel.AutoSize = True
        NamaBarangYangDipesanLabel.Location = New System.Drawing.Point(17, 323)
        NamaBarangYangDipesanLabel.Name = "NamaBarangYangDipesanLabel"
        NamaBarangYangDipesanLabel.Size = New System.Drawing.Size(143, 13)
        NamaBarangYangDipesanLabel.TabIndex = 29
        NamaBarangYangDipesanLabel.Text = "nama Barang Yang Dipesan:"
        '
        'TotalBarangYangDipesanLabel
        '
        TotalBarangYangDipesanLabel.AutoSize = True
        TotalBarangYangDipesanLabel.Location = New System.Drawing.Point(17, 349)
        TotalBarangYangDipesanLabel.Name = "TotalBarangYangDipesanLabel"
        TotalBarangYangDipesanLabel.Size = New System.Drawing.Size(137, 13)
        TotalBarangYangDipesanLabel.TabIndex = 31
        TotalBarangYangDipesanLabel.Text = "total Barang Yang Dipesan:"
        '
        'TotalHargaBarangLabel
        '
        TotalHargaBarangLabel.AutoSize = True
        TotalHargaBarangLabel.Location = New System.Drawing.Point(17, 375)
        TotalHargaBarangLabel.Name = "TotalHargaBarangLabel"
        TotalHargaBarangLabel.Size = New System.Drawing.Size(99, 13)
        TotalHargaBarangLabel.TabIndex = 33
        TotalHargaBarangLabel.Text = "total Harga Barang:"
        '
        'AlamatTujuanPengirimanLabel
        '
        AlamatTujuanPengirimanLabel.AutoSize = True
        AlamatTujuanPengirimanLabel.Location = New System.Drawing.Point(17, 401)
        AlamatTujuanPengirimanLabel.Name = "AlamatTujuanPengirimanLabel"
        AlamatTujuanPengirimanLabel.Size = New System.Drawing.Size(132, 13)
        AlamatTujuanPengirimanLabel.TabIndex = 35
        AlamatTujuanPengirimanLabel.Text = "alamat Tujuan Pengiriman:"
        '
        'TanggalPesanBarangLabel
        '
        TanggalPesanBarangLabel.AutoSize = True
        TanggalPesanBarangLabel.Location = New System.Drawing.Point(17, 424)
        TanggalPesanBarangLabel.Name = "TanggalPesanBarangLabel"
        TanggalPesanBarangLabel.Size = New System.Drawing.Size(115, 13)
        TanggalPesanBarangLabel.TabIndex = 37
        TanggalPesanBarangLabel.Text = "tanggal Pesan Barang:"
        '
        'TanggalBarangDikirimLabel
        '
        TanggalBarangDikirimLabel.AutoSize = True
        TanggalBarangDikirimLabel.Location = New System.Drawing.Point(17, 450)
        TanggalBarangDikirimLabel.Name = "TanggalBarangDikirimLabel"
        TanggalBarangDikirimLabel.Size = New System.Drawing.Size(116, 13)
        TanggalBarangDikirimLabel.TabIndex = 39
        TanggalBarangDikirimLabel.Text = "tanggal Barang Dikirim:"
        '
        'TanggalBarangDiterimaLabel
        '
        TanggalBarangDiterimaLabel.AutoSize = True
        TanggalBarangDiterimaLabel.Location = New System.Drawing.Point(17, 476)
        TanggalBarangDiterimaLabel.Name = "TanggalBarangDiterimaLabel"
        TanggalBarangDiterimaLabel.Size = New System.Drawing.Size(123, 13)
        TanggalBarangDiterimaLabel.TabIndex = 41
        TanggalBarangDiterimaLabel.Text = "tanggal Barang Diterima:"
        '
        'PotonganHargaLabel
        '
        PotonganHargaLabel.AutoSize = True
        PotonganHargaLabel.Location = New System.Drawing.Point(17, 505)
        PotonganHargaLabel.Name = "PotonganHargaLabel"
        PotonganHargaLabel.Size = New System.Drawing.Size(87, 13)
        PotonganHargaLabel.TabIndex = 43
        PotonganHargaLabel.Text = "potongan Harga:"
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
        'TbpemesananBindingSource
        '
        Me.TbpemesananBindingSource.DataMember = "tbpemesanan"
        Me.TbpemesananBindingSource.DataSource = Me.PakaianonlineDataSet
        '
        'PakaianonlineDataSet
        '
        Me.PakaianonlineDataSet.DataSetName = "pakaianonlineDataSet"
        Me.PakaianonlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'IdPemesananTextBox
        '
        Me.IdPemesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "idPemesanan", True))
        Me.IdPemesananTextBox.Location = New System.Drawing.Point(166, 268)
        Me.IdPemesananTextBox.Name = "IdPemesananTextBox"
        Me.IdPemesananTextBox.Size = New System.Drawing.Size(361, 20)
        Me.IdPemesananTextBox.TabIndex = 26
        '
        'NamaPemesananTextBox
        '
        Me.NamaPemesananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "namaPemesanan", True))
        Me.NamaPemesananTextBox.Location = New System.Drawing.Point(166, 294)
        Me.NamaPemesananTextBox.Name = "NamaPemesananTextBox"
        Me.NamaPemesananTextBox.Size = New System.Drawing.Size(361, 20)
        Me.NamaPemesananTextBox.TabIndex = 28
        '
        'NamaBarangYangDipesanTextBox
        '
        Me.NamaBarangYangDipesanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "namaBarangYangDipesan", True))
        Me.NamaBarangYangDipesanTextBox.Location = New System.Drawing.Point(166, 320)
        Me.NamaBarangYangDipesanTextBox.Name = "NamaBarangYangDipesanTextBox"
        Me.NamaBarangYangDipesanTextBox.Size = New System.Drawing.Size(361, 20)
        Me.NamaBarangYangDipesanTextBox.TabIndex = 30
        '
        'TotalBarangYangDipesanTextBox
        '
        Me.TotalBarangYangDipesanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "totalBarangYangDipesan", True))
        Me.TotalBarangYangDipesanTextBox.Location = New System.Drawing.Point(166, 346)
        Me.TotalBarangYangDipesanTextBox.Name = "TotalBarangYangDipesanTextBox"
        Me.TotalBarangYangDipesanTextBox.Size = New System.Drawing.Size(361, 20)
        Me.TotalBarangYangDipesanTextBox.TabIndex = 32
        '
        'TotalHargaBarangTextBox
        '
        Me.TotalHargaBarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "totalHargaBarang", True))
        Me.TotalHargaBarangTextBox.Location = New System.Drawing.Point(166, 372)
        Me.TotalHargaBarangTextBox.Name = "TotalHargaBarangTextBox"
        Me.TotalHargaBarangTextBox.Size = New System.Drawing.Size(361, 20)
        Me.TotalHargaBarangTextBox.TabIndex = 34
        '
        'AlamatTujuanPengirimanTextBox
        '
        Me.AlamatTujuanPengirimanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "alamatTujuanPengiriman", True))
        Me.AlamatTujuanPengirimanTextBox.Location = New System.Drawing.Point(166, 398)
        Me.AlamatTujuanPengirimanTextBox.Name = "AlamatTujuanPengirimanTextBox"
        Me.AlamatTujuanPengirimanTextBox.Size = New System.Drawing.Size(361, 20)
        Me.AlamatTujuanPengirimanTextBox.TabIndex = 36
        '
        'TanggalPesanBarangDateEdit
        '
        Me.TanggalPesanBarangDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TbpemesananBindingSource, "tanggalPesanBarang", True))
        Me.TanggalPesanBarangDateEdit.EditValue = Nothing
        Me.TanggalPesanBarangDateEdit.Location = New System.Drawing.Point(166, 421)
        Me.TanggalPesanBarangDateEdit.Name = "TanggalPesanBarangDateEdit"
        Me.TanggalPesanBarangDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPesanBarangDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPesanBarangDateEdit.Size = New System.Drawing.Size(361, 20)
        Me.TanggalPesanBarangDateEdit.TabIndex = 38
        '
        'TanggalBarangDikirimDateEdit
        '
        Me.TanggalBarangDikirimDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TbpemesananBindingSource, "tanggalBarangDikirim", True))
        Me.TanggalBarangDikirimDateEdit.EditValue = Nothing
        Me.TanggalBarangDikirimDateEdit.Location = New System.Drawing.Point(166, 447)
        Me.TanggalBarangDikirimDateEdit.Name = "TanggalBarangDikirimDateEdit"
        Me.TanggalBarangDikirimDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalBarangDikirimDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalBarangDikirimDateEdit.Size = New System.Drawing.Size(361, 20)
        Me.TanggalBarangDikirimDateEdit.TabIndex = 40
        '
        'TanggalBarangDiterimaDateEdit
        '
        Me.TanggalBarangDiterimaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TbpemesananBindingSource, "tanggalBarangDiterima", True))
        Me.TanggalBarangDiterimaDateEdit.EditValue = Nothing
        Me.TanggalBarangDiterimaDateEdit.Location = New System.Drawing.Point(166, 473)
        Me.TanggalBarangDiterimaDateEdit.Name = "TanggalBarangDiterimaDateEdit"
        Me.TanggalBarangDiterimaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalBarangDiterimaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalBarangDiterimaDateEdit.Size = New System.Drawing.Size(361, 20)
        Me.TanggalBarangDiterimaDateEdit.TabIndex = 42
        '
        'PotonganHargaTextBox
        '
        Me.PotonganHargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpemesananBindingSource, "potonganHarga", True))
        Me.PotonganHargaTextBox.Location = New System.Drawing.Point(166, 502)
        Me.PotonganHargaTextBox.Name = "PotonganHargaTextBox"
        Me.PotonganHargaTextBox.Size = New System.Drawing.Size(361, 20)
        Me.PotonganHargaTextBox.TabIndex = 44
        '
        'BATALButton
        '
        Me.BATALButton.Location = New System.Drawing.Point(542, 365)
        Me.BATALButton.Name = "BATALButton"
        Me.BATALButton.Size = New System.Drawing.Size(96, 23)
        Me.BATALButton.TabIndex = 45
        Me.BATALButton.Text = "BATAL"
        Me.BATALButton.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 542)
        Me.Controls.Add(Me.BATALButton)
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
        Me.Controls.Add(Me.TanggalPesanBarangDateEdit)
        Me.Controls.Add(TanggalBarangDikirimLabel)
        Me.Controls.Add(Me.TanggalBarangDikirimDateEdit)
        Me.Controls.Add(TanggalBarangDiterimaLabel)
        Me.Controls.Add(Me.TanggalBarangDiterimaDateEdit)
        Me.Controls.Add(PotonganHargaLabel)
        Me.Controls.Add(Me.PotonganHargaTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbpemesananDataGridView)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.TbpemesananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalPesanBarangDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalPesanBarangDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalBarangDikirimDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalBarangDikirimDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalBarangDiterimaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalBarangDiterimaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IdPemesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaPemesananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaBarangYangDipesanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBarangYangDipesanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalHargaBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTujuanPengirimanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalPesanBarangDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TanggalBarangDikirimDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TanggalBarangDiterimaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PotonganHargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BATALButton As System.Windows.Forms.Button
End Class
