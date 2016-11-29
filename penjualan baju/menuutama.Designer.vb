<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuutama
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
        Dim IdJenisPakaianLabel As System.Windows.Forms.Label
        Dim JenisPakaianLabel As System.Windows.Forms.Label
        Dim StokJenisPakaianLabel As System.Windows.Forms.Label
        Dim StokBahanPakaianLabel As System.Windows.Forms.Label
        Me.PakaianonlineDataSet = New penjualan_baju.pakaianonlineDataSet()
        Me.TbbahanpakaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbbahanpakaianTableAdapter = New penjualan_baju.pakaianonlineDataSetTableAdapters.tbbahanpakaianTableAdapter()
        Me.TableAdapterManager = New penjualan_baju.pakaianonlineDataSetTableAdapters.TableAdapterManager()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TbpakaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbpakaianTableAdapter = New penjualan_baju.pakaianonlineDataSetTableAdapters.tbpakaianTableAdapter()
        Me.TbpakaianDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdJenisPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.JenisPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.StokJenisPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.StokBahanPakaianTextBox = New System.Windows.Forms.TextBox()
        IdJenisPakaianLabel = New System.Windows.Forms.Label()
        JenisPakaianLabel = New System.Windows.Forms.Label()
        StokJenisPakaianLabel = New System.Windows.Forms.Label()
        StokBahanPakaianLabel = New System.Windows.Forms.Label()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbbahanpakaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpakaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpakaianDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableAdapterManager.tbpakaianTableAdapter = Me.TbpakaianTableAdapter
        Me.TableAdapterManager.tbpemesanan_has_tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = penjualan_baju.pakaianonlineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(463, 170)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(275, 23)
        Me.TambahButton.TabIndex = 3
        Me.TambahButton.Text = "TAMBAH"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(463, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(275, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(463, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(275, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(463, 228)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(275, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TbpakaianBindingSource
        '
        Me.TbpakaianBindingSource.DataMember = "tbpakaian"
        Me.TbpakaianBindingSource.DataSource = Me.PakaianonlineDataSet
        '
        'TbpakaianTableAdapter
        '
        Me.TbpakaianTableAdapter.ClearBeforeFill = True
        '
        'TbpakaianDataGridView
        '
        Me.TbpakaianDataGridView.AutoGenerateColumns = False
        Me.TbpakaianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbpakaianDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TbpakaianDataGridView.DataSource = Me.TbpakaianBindingSource
        Me.TbpakaianDataGridView.Location = New System.Drawing.Point(8, 17)
        Me.TbpakaianDataGridView.Name = "TbpakaianDataGridView"
        Me.TbpakaianDataGridView.Size = New System.Drawing.Size(448, 363)
        Me.TbpakaianDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idJenisPakaian"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idJenisPakaian"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "JenisPakaian"
        Me.DataGridViewTextBoxColumn2.HeaderText = "JenisPakaian"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "stokJenisPakaian"
        Me.DataGridViewTextBoxColumn3.HeaderText = "stokJenisPakaian"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "stokBahanPakaian"
        Me.DataGridViewTextBoxColumn4.HeaderText = "stokBahanPakaian"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdJenisPakaianLabel)
        Me.GroupBox1.Controls.Add(Me.IdJenisPakaianTextBox)
        Me.GroupBox1.Controls.Add(JenisPakaianLabel)
        Me.GroupBox1.Controls.Add(Me.JenisPakaianTextBox)
        Me.GroupBox1.Controls.Add(StokJenisPakaianLabel)
        Me.GroupBox1.Controls.Add(Me.StokJenisPakaianTextBox)
        Me.GroupBox1.Controls.Add(StokBahanPakaianLabel)
        Me.GroupBox1.Controls.Add(Me.StokBahanPakaianTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(463, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 137)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'IdJenisPakaianLabel
        '
        IdJenisPakaianLabel.AutoSize = True
        IdJenisPakaianLabel.Location = New System.Drawing.Point(13, 26)
        IdJenisPakaianLabel.Name = "IdJenisPakaianLabel"
        IdJenisPakaianLabel.Size = New System.Drawing.Size(87, 13)
        IdJenisPakaianLabel.TabIndex = 0
        IdJenisPakaianLabel.Text = "id Jenis Pakaian:"
        '
        'IdJenisPakaianTextBox
        '
        Me.IdJenisPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "idJenisPakaian", True))
        Me.IdJenisPakaianTextBox.Location = New System.Drawing.Point(125, 23)
        Me.IdJenisPakaianTextBox.Name = "IdJenisPakaianTextBox"
        Me.IdJenisPakaianTextBox.Size = New System.Drawing.Size(144, 20)
        Me.IdJenisPakaianTextBox.TabIndex = 1
        '
        'JenisPakaianLabel
        '
        JenisPakaianLabel.AutoSize = True
        JenisPakaianLabel.Location = New System.Drawing.Point(13, 52)
        JenisPakaianLabel.Name = "JenisPakaianLabel"
        JenisPakaianLabel.Size = New System.Drawing.Size(76, 13)
        JenisPakaianLabel.TabIndex = 2
        JenisPakaianLabel.Text = "Jenis Pakaian:"
        '
        'JenisPakaianTextBox
        '
        Me.JenisPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "JenisPakaian", True))
        Me.JenisPakaianTextBox.Location = New System.Drawing.Point(125, 49)
        Me.JenisPakaianTextBox.Name = "JenisPakaianTextBox"
        Me.JenisPakaianTextBox.Size = New System.Drawing.Size(144, 20)
        Me.JenisPakaianTextBox.TabIndex = 3
        '
        'StokJenisPakaianLabel
        '
        StokJenisPakaianLabel.AutoSize = True
        StokJenisPakaianLabel.Location = New System.Drawing.Point(13, 78)
        StokJenisPakaianLabel.Name = "StokJenisPakaianLabel"
        StokJenisPakaianLabel.Size = New System.Drawing.Size(99, 13)
        StokJenisPakaianLabel.TabIndex = 4
        StokJenisPakaianLabel.Text = "stok Jenis Pakaian:"
        '
        'StokJenisPakaianTextBox
        '
        Me.StokJenisPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "stokJenisPakaian", True))
        Me.StokJenisPakaianTextBox.Location = New System.Drawing.Point(125, 75)
        Me.StokJenisPakaianTextBox.Name = "StokJenisPakaianTextBox"
        Me.StokJenisPakaianTextBox.Size = New System.Drawing.Size(144, 20)
        Me.StokJenisPakaianTextBox.TabIndex = 5
        '
        'StokBahanPakaianLabel
        '
        StokBahanPakaianLabel.AutoSize = True
        StokBahanPakaianLabel.Location = New System.Drawing.Point(13, 104)
        StokBahanPakaianLabel.Name = "StokBahanPakaianLabel"
        StokBahanPakaianLabel.Size = New System.Drawing.Size(106, 13)
        StokBahanPakaianLabel.TabIndex = 6
        StokBahanPakaianLabel.Text = "stok Bahan Pakaian:"
        '
        'StokBahanPakaianTextBox
        '
        Me.StokBahanPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "stokBahanPakaian", True))
        Me.StokBahanPakaianTextBox.Location = New System.Drawing.Point(125, 101)
        Me.StokBahanPakaianTextBox.Name = "StokBahanPakaianTextBox"
        Me.StokBahanPakaianTextBox.Size = New System.Drawing.Size(144, 20)
        Me.StokBahanPakaianTextBox.TabIndex = 7
        '
        'menuutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TbpakaianDataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TambahButton)
        Me.Name = "menuutama"
        Me.Text = "MENU UTAMA"
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbbahanpakaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpakaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpakaianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PakaianonlineDataSet As penjualan_baju.pakaianonlineDataSet
    Friend WithEvents TbbahanpakaianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbbahanpakaianTableAdapter As penjualan_baju.pakaianonlineDataSetTableAdapters.tbbahanpakaianTableAdapter
    Friend WithEvents TableAdapterManager As penjualan_baju.pakaianonlineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TbpakaianTableAdapter As penjualan_baju.pakaianonlineDataSetTableAdapters.tbpakaianTableAdapter
    Friend WithEvents TbpakaianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbpakaianDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IdJenisPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JenisPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StokJenisPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StokBahanPakaianTextBox As System.Windows.Forms.TextBox
End Class
