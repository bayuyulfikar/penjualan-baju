<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim IdBahanPakaianLabel As System.Windows.Forms.Label
        Dim NamaBahanPakaianLabel As System.Windows.Forms.Label
        Dim HargaBahanPakaianLabel As System.Windows.Forms.Label
        Dim StokBahanPakaianLabel As System.Windows.Forms.Label
        Dim TbPakaian_idJenisPakaianLabel As System.Windows.Forms.Label
        Me.PakaianonlineDataSet = New MI_store.pakaianonlineDataSet()
        Me.TbbahanpakaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbbahanpakaianTableAdapter = New MI_store.pakaianonlineDataSetTableAdapters.tbbahanpakaianTableAdapter()
        Me.TableAdapterManager = New MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager()
        Me.TbbahanpakaianDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBahanPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.NamaBahanPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.HargaBahanPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.StokBahanPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.TbPakaian_idJenisPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        IdBahanPakaianLabel = New System.Windows.Forms.Label()
        NamaBahanPakaianLabel = New System.Windows.Forms.Label()
        HargaBahanPakaianLabel = New System.Windows.Forms.Label()
        StokBahanPakaianLabel = New System.Windows.Forms.Label()
        TbPakaian_idJenisPakaianLabel = New System.Windows.Forms.Label()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbbahanpakaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbbahanpakaianDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PakaianonlineDataSet
        '
        Me.PakaianonlineDataSet.DataSetName = "pakaianonlineDataSet"
        Me.PakaianonlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbbahanpakaianBindingSource
        '
        Me.TbbahanpakaianBindingSource.DataMember = "tbbahanpakaian"
        Me.TbbahanpakaianBindingSource.DataSource = Me.PakaianonlineDataSet
        '
        'TbbahanpakaianTableAdapter
        '
        Me.TbbahanpakaianTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbbahanpakaianTableAdapter = Me.TbbahanpakaianTableAdapter
        Me.TableAdapterManager.tbkeuanganTableAdapter = Nothing
        Me.TableAdapterManager.tbpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesanan_has_tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbbahanpakaianDataGridView
        '
        Me.TbbahanpakaianDataGridView.AutoGenerateColumns = False
        Me.TbbahanpakaianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbbahanpakaianDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TbbahanpakaianDataGridView.DataSource = Me.TbbahanpakaianBindingSource
        Me.TbbahanpakaianDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.TbbahanpakaianDataGridView.Name = "TbbahanpakaianDataGridView"
        Me.TbbahanpakaianDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.TbbahanpakaianDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idBahanPakaian"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idBahanPakaian"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "namaBahanPakaian"
        Me.DataGridViewTextBoxColumn2.HeaderText = "namaBahanPakaian"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HargaBahanPakaian"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HargaBahanPakaian"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "stokBahanPakaian"
        Me.DataGridViewTextBoxColumn4.HeaderText = "stokBahanPakaian"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tbPakaian_idJenisPakaian"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tbPakaian_idJenisPakaian"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IdBahanPakaianLabel
        '
        IdBahanPakaianLabel.AutoSize = True
        IdBahanPakaianLabel.Location = New System.Drawing.Point(12, 262)
        IdBahanPakaianLabel.Name = "IdBahanPakaianLabel"
        IdBahanPakaianLabel.Size = New System.Drawing.Size(94, 13)
        IdBahanPakaianLabel.TabIndex = 2
        IdBahanPakaianLabel.Text = "id Bahan Pakaian:"
        '
        'IdBahanPakaianTextBox
        '
        Me.IdBahanPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbbahanpakaianBindingSource, "idBahanPakaian", True))
        Me.IdBahanPakaianTextBox.Location = New System.Drawing.Point(159, 259)
        Me.IdBahanPakaianTextBox.Name = "IdBahanPakaianTextBox"
        Me.IdBahanPakaianTextBox.Size = New System.Drawing.Size(284, 20)
        Me.IdBahanPakaianTextBox.TabIndex = 3
        '
        'NamaBahanPakaianLabel
        '
        NamaBahanPakaianLabel.AutoSize = True
        NamaBahanPakaianLabel.Location = New System.Drawing.Point(12, 288)
        NamaBahanPakaianLabel.Name = "NamaBahanPakaianLabel"
        NamaBahanPakaianLabel.Size = New System.Drawing.Size(112, 13)
        NamaBahanPakaianLabel.TabIndex = 4
        NamaBahanPakaianLabel.Text = "nama Bahan Pakaian:"
        '
        'NamaBahanPakaianTextBox
        '
        Me.NamaBahanPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbbahanpakaianBindingSource, "namaBahanPakaian", True))
        Me.NamaBahanPakaianTextBox.Location = New System.Drawing.Point(159, 285)
        Me.NamaBahanPakaianTextBox.Name = "NamaBahanPakaianTextBox"
        Me.NamaBahanPakaianTextBox.Size = New System.Drawing.Size(284, 20)
        Me.NamaBahanPakaianTextBox.TabIndex = 5
        '
        'HargaBahanPakaianLabel
        '
        HargaBahanPakaianLabel.AutoSize = True
        HargaBahanPakaianLabel.Location = New System.Drawing.Point(12, 314)
        HargaBahanPakaianLabel.Name = "HargaBahanPakaianLabel"
        HargaBahanPakaianLabel.Size = New System.Drawing.Size(115, 13)
        HargaBahanPakaianLabel.TabIndex = 6
        HargaBahanPakaianLabel.Text = "Harga Bahan Pakaian:"
        '
        'HargaBahanPakaianTextBox
        '
        Me.HargaBahanPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbbahanpakaianBindingSource, "HargaBahanPakaian", True))
        Me.HargaBahanPakaianTextBox.Location = New System.Drawing.Point(159, 311)
        Me.HargaBahanPakaianTextBox.Name = "HargaBahanPakaianTextBox"
        Me.HargaBahanPakaianTextBox.Size = New System.Drawing.Size(284, 20)
        Me.HargaBahanPakaianTextBox.TabIndex = 7
        '
        'StokBahanPakaianLabel
        '
        StokBahanPakaianLabel.AutoSize = True
        StokBahanPakaianLabel.Location = New System.Drawing.Point(12, 340)
        StokBahanPakaianLabel.Name = "StokBahanPakaianLabel"
        StokBahanPakaianLabel.Size = New System.Drawing.Size(106, 13)
        StokBahanPakaianLabel.TabIndex = 8
        StokBahanPakaianLabel.Text = "stok Bahan Pakaian:"
        '
        'StokBahanPakaianTextBox
        '
        Me.StokBahanPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbbahanpakaianBindingSource, "stokBahanPakaian", True))
        Me.StokBahanPakaianTextBox.Location = New System.Drawing.Point(159, 337)
        Me.StokBahanPakaianTextBox.Name = "StokBahanPakaianTextBox"
        Me.StokBahanPakaianTextBox.Size = New System.Drawing.Size(284, 20)
        Me.StokBahanPakaianTextBox.TabIndex = 9
        '
        'TbPakaian_idJenisPakaianLabel
        '
        TbPakaian_idJenisPakaianLabel.AutoSize = True
        TbPakaian_idJenisPakaianLabel.Location = New System.Drawing.Point(12, 366)
        TbPakaian_idJenisPakaianLabel.Name = "TbPakaian_idJenisPakaianLabel"
        TbPakaian_idJenisPakaianLabel.Size = New System.Drawing.Size(141, 13)
        TbPakaian_idJenisPakaianLabel.TabIndex = 10
        TbPakaian_idJenisPakaianLabel.Text = "tb Pakaian id Jenis Pakaian:"
        '
        'TbPakaian_idJenisPakaianTextBox
        '
        Me.TbPakaian_idJenisPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbbahanpakaianBindingSource, "tbPakaian_idJenisPakaian", True))
        Me.TbPakaian_idJenisPakaianTextBox.Location = New System.Drawing.Point(159, 363)
        Me.TbPakaian_idJenisPakaianTextBox.Name = "TbPakaian_idJenisPakaianTextBox"
        Me.TbPakaian_idJenisPakaianTextBox.Size = New System.Drawing.Size(284, 20)
        Me.TbPakaian_idJenisPakaianTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(460, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(460, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(460, 337)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 449)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdBahanPakaianLabel)
        Me.Controls.Add(Me.IdBahanPakaianTextBox)
        Me.Controls.Add(NamaBahanPakaianLabel)
        Me.Controls.Add(Me.NamaBahanPakaianTextBox)
        Me.Controls.Add(HargaBahanPakaianLabel)
        Me.Controls.Add(Me.HargaBahanPakaianTextBox)
        Me.Controls.Add(StokBahanPakaianLabel)
        Me.Controls.Add(Me.StokBahanPakaianTextBox)
        Me.Controls.Add(TbPakaian_idJenisPakaianLabel)
        Me.Controls.Add(Me.TbPakaian_idJenisPakaianTextBox)
        Me.Controls.Add(Me.TbbahanpakaianDataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbbahanpakaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbbahanpakaianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PakaianonlineDataSet As MI_store.pakaianonlineDataSet
    Friend WithEvents TbbahanpakaianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbbahanpakaianTableAdapter As MI_store.pakaianonlineDataSetTableAdapters.tbbahanpakaianTableAdapter
    Friend WithEvents TableAdapterManager As MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbbahanpakaianDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdBahanPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaBahanPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HargaBahanPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StokBahanPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TbPakaian_idJenisPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
