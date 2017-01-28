<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim TanggalBulanTahunLabel As System.Windows.Forms.Label
        Dim PemasukanLabel As System.Windows.Forms.Label
        Dim PengeluaranLabel As System.Windows.Forms.Label
        Dim Laba___rugiLabel As System.Windows.Forms.Label
        Dim TbPemesanan_idPemesananLabel As System.Windows.Forms.Label
        Me.PakaianonlineDataSet = New MI_store.pakaianonlineDataSet()
        Me.TbkeuanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbkeuanganTableAdapter = New MI_store.pakaianonlineDataSetTableAdapters.tbkeuanganTableAdapter()
        Me.TableAdapterManager = New MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager()
        Me.TbkeuanganDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalBulanTahunTextBox = New System.Windows.Forms.TextBox()
        Me.PemasukanTextBox = New System.Windows.Forms.TextBox()
        Me.PengeluaranTextBox = New System.Windows.Forms.TextBox()
        Me.Laba___rugiTextBox = New System.Windows.Forms.TextBox()
        Me.TbPemesanan_idPemesananSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        TanggalBulanTahunLabel = New System.Windows.Forms.Label()
        PemasukanLabel = New System.Windows.Forms.Label()
        PengeluaranLabel = New System.Windows.Forms.Label()
        Laba___rugiLabel = New System.Windows.Forms.Label()
        TbPemesanan_idPemesananLabel = New System.Windows.Forms.Label()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbkeuanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbkeuanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPemesanan_idPemesananSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TanggalBulanTahunLabel
        '
        TanggalBulanTahunLabel.AutoSize = True
        TanggalBulanTahunLabel.Location = New System.Drawing.Point(13, 178)
        TanggalBulanTahunLabel.Name = "TanggalBulanTahunLabel"
        TanggalBulanTahunLabel.Size = New System.Drawing.Size(109, 13)
        TanggalBulanTahunLabel.TabIndex = 2
        TanggalBulanTahunLabel.Text = "tanggal Bulan Tahun:"
        '
        'PemasukanLabel
        '
        PemasukanLabel.AutoSize = True
        PemasukanLabel.Location = New System.Drawing.Point(13, 204)
        PemasukanLabel.Name = "PemasukanLabel"
        PemasukanLabel.Size = New System.Drawing.Size(65, 13)
        PemasukanLabel.TabIndex = 4
        PemasukanLabel.Text = "pemasukan:"
        '
        'PengeluaranLabel
        '
        PengeluaranLabel.AutoSize = True
        PengeluaranLabel.Location = New System.Drawing.Point(13, 230)
        PengeluaranLabel.Name = "PengeluaranLabel"
        PengeluaranLabel.Size = New System.Drawing.Size(69, 13)
        PengeluaranLabel.TabIndex = 6
        PengeluaranLabel.Text = "pengeluaran:"
        '
        'Laba___rugiLabel
        '
        Laba___rugiLabel.AutoSize = True
        Laba___rugiLabel.Location = New System.Drawing.Point(13, 256)
        Laba___rugiLabel.Name = "Laba___rugiLabel"
        Laba___rugiLabel.Size = New System.Drawing.Size(58, 13)
        Laba___rugiLabel.TabIndex = 8
        Laba___rugiLabel.Text = "laba / rugi:"
        '
        'TbPemesanan_idPemesananLabel
        '
        TbPemesanan_idPemesananLabel.AutoSize = True
        TbPemesanan_idPemesananLabel.Location = New System.Drawing.Point(13, 279)
        TbPemesanan_idPemesananLabel.Name = "TbPemesanan_idPemesananLabel"
        TbPemesanan_idPemesananLabel.Size = New System.Drawing.Size(148, 13)
        TbPemesanan_idPemesananLabel.TabIndex = 10
        TbPemesanan_idPemesananLabel.Text = "tb Pemesanan id Pemesanan:"
        '
        'PakaianonlineDataSet
        '
        Me.PakaianonlineDataSet.DataSetName = "pakaianonlineDataSet"
        Me.PakaianonlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbkeuanganBindingSource
        '
        Me.TbkeuanganBindingSource.DataMember = "tbkeuangan"
        Me.TbkeuanganBindingSource.DataSource = Me.PakaianonlineDataSet
        '
        'TbkeuanganTableAdapter
        '
        Me.TbkeuanganTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbkeuanganTableAdapter = Me.TbkeuanganTableAdapter
        Me.TableAdapterManager.tbpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesanan_has_tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbkeuanganDataGridView
        '
        Me.TbkeuanganDataGridView.AutoGenerateColumns = False
        Me.TbkeuanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbkeuanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TbkeuanganDataGridView.DataSource = Me.TbkeuanganBindingSource
        Me.TbkeuanganDataGridView.Location = New System.Drawing.Point(16, 20)
        Me.TbkeuanganDataGridView.Name = "TbkeuanganDataGridView"
        Me.TbkeuanganDataGridView.Size = New System.Drawing.Size(549, 145)
        Me.TbkeuanganDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tanggalBulanTahun"
        Me.DataGridViewTextBoxColumn1.HeaderText = "tanggalBulanTahun"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pemasukan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "pemasukan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "pengeluaran"
        Me.DataGridViewTextBoxColumn3.HeaderText = "pengeluaran"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "laba / rugi"
        Me.DataGridViewTextBoxColumn4.HeaderText = "laba / rugi"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tbPemesanan_idPemesanan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tbPemesanan_idPemesanan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TanggalBulanTahunTextBox
        '
        Me.TanggalBulanTahunTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbkeuanganBindingSource, "tanggalBulanTahun", True))
        Me.TanggalBulanTahunTextBox.Location = New System.Drawing.Point(167, 175)
        Me.TanggalBulanTahunTextBox.Name = "TanggalBulanTahunTextBox"
        Me.TanggalBulanTahunTextBox.Size = New System.Drawing.Size(268, 20)
        Me.TanggalBulanTahunTextBox.TabIndex = 3
        '
        'PemasukanTextBox
        '
        Me.PemasukanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbkeuanganBindingSource, "pemasukan", True))
        Me.PemasukanTextBox.Location = New System.Drawing.Point(167, 201)
        Me.PemasukanTextBox.Name = "PemasukanTextBox"
        Me.PemasukanTextBox.Size = New System.Drawing.Size(268, 20)
        Me.PemasukanTextBox.TabIndex = 5
        '
        'PengeluaranTextBox
        '
        Me.PengeluaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbkeuanganBindingSource, "pengeluaran", True))
        Me.PengeluaranTextBox.Location = New System.Drawing.Point(167, 227)
        Me.PengeluaranTextBox.Name = "PengeluaranTextBox"
        Me.PengeluaranTextBox.Size = New System.Drawing.Size(268, 20)
        Me.PengeluaranTextBox.TabIndex = 7
        '
        'Laba___rugiTextBox
        '
        Me.Laba___rugiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbkeuanganBindingSource, "laba / rugi", True))
        Me.Laba___rugiTextBox.Location = New System.Drawing.Point(167, 253)
        Me.Laba___rugiTextBox.Name = "Laba___rugiTextBox"
        Me.Laba___rugiTextBox.Size = New System.Drawing.Size(268, 20)
        Me.Laba___rugiTextBox.TabIndex = 9
        '
        'TbPemesanan_idPemesananSpinEdit
        '
        Me.TbPemesanan_idPemesananSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TbkeuanganBindingSource, "tbPemesanan_idPemesanan", True))
        Me.TbPemesanan_idPemesananSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TbPemesanan_idPemesananSpinEdit.Location = New System.Drawing.Point(167, 276)
        Me.TbPemesanan_idPemesananSpinEdit.Name = "TbPemesanan_idPemesananSpinEdit"
        Me.TbPemesanan_idPemesananSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TbPemesanan_idPemesananSpinEdit.Size = New System.Drawing.Size(268, 20)
        Me.TbPemesanan_idPemesananSpinEdit.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(462, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(462, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(462, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(462, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 361)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TanggalBulanTahunLabel)
        Me.Controls.Add(Me.TanggalBulanTahunTextBox)
        Me.Controls.Add(PemasukanLabel)
        Me.Controls.Add(Me.PemasukanTextBox)
        Me.Controls.Add(PengeluaranLabel)
        Me.Controls.Add(Me.PengeluaranTextBox)
        Me.Controls.Add(Laba___rugiLabel)
        Me.Controls.Add(Me.Laba___rugiTextBox)
        Me.Controls.Add(TbPemesanan_idPemesananLabel)
        Me.Controls.Add(Me.TbPemesanan_idPemesananSpinEdit)
        Me.Controls.Add(Me.TbkeuanganDataGridView)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbkeuanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbkeuanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPemesanan_idPemesananSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PakaianonlineDataSet As MI_store.pakaianonlineDataSet
    Friend WithEvents TbkeuanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbkeuanganTableAdapter As MI_store.pakaianonlineDataSetTableAdapters.tbkeuanganTableAdapter
    Friend WithEvents TableAdapterManager As MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbkeuanganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalBulanTahunTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PemasukanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PengeluaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Laba___rugiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TbPemesanan_idPemesananSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
