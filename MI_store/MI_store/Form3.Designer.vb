<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.PakaianonlineDataSet = New MI_store.pakaianonlineDataSet()
        Me.TbpakaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbpakaianTableAdapter = New MI_store.pakaianonlineDataSetTableAdapters.tbpakaianTableAdapter()
        Me.TableAdapterManager = New MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager()
        Me.TbpakaianDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdJenisPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.JenisPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.StokJenisPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.StokBahanPakaianTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        IdJenisPakaianLabel = New System.Windows.Forms.Label()
        JenisPakaianLabel = New System.Windows.Forms.Label()
        StokJenisPakaianLabel = New System.Windows.Forms.Label()
        StokBahanPakaianLabel = New System.Windows.Forms.Label()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpakaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpakaianDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PakaianonlineDataSet
        '
        Me.PakaianonlineDataSet.DataSetName = "pakaianonlineDataSet"
        Me.PakaianonlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbkeuanganTableAdapter = Nothing
        Me.TableAdapterManager.tbpakaianTableAdapter = Me.TbpakaianTableAdapter
        Me.TableAdapterManager.tbpemesanan_has_tbbahanpakaianTableAdapter = Nothing
        Me.TableAdapterManager.tbpemesananTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbpakaianDataGridView
        '
        Me.TbpakaianDataGridView.AutoGenerateColumns = False
        Me.TbpakaianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbpakaianDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TbpakaianDataGridView.DataSource = Me.TbpakaianBindingSource
        Me.TbpakaianDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TbpakaianDataGridView.Name = "TbpakaianDataGridView"
        Me.TbpakaianDataGridView.Size = New System.Drawing.Size(445, 136)
        Me.TbpakaianDataGridView.TabIndex = 1
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
        'IdJenisPakaianLabel
        '
        IdJenisPakaianLabel.AutoSize = True
        IdJenisPakaianLabel.Location = New System.Drawing.Point(27, 187)
        IdJenisPakaianLabel.Name = "IdJenisPakaianLabel"
        IdJenisPakaianLabel.Size = New System.Drawing.Size(87, 13)
        IdJenisPakaianLabel.TabIndex = 2
        IdJenisPakaianLabel.Text = "id Jenis Pakaian:"
        '
        'IdJenisPakaianTextBox
        '
        Me.IdJenisPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "idJenisPakaian", True))
        Me.IdJenisPakaianTextBox.Location = New System.Drawing.Point(139, 184)
        Me.IdJenisPakaianTextBox.Name = "IdJenisPakaianTextBox"
        Me.IdJenisPakaianTextBox.Size = New System.Drawing.Size(222, 20)
        Me.IdJenisPakaianTextBox.TabIndex = 3
        '
        'JenisPakaianLabel
        '
        JenisPakaianLabel.AutoSize = True
        JenisPakaianLabel.Location = New System.Drawing.Point(27, 213)
        JenisPakaianLabel.Name = "JenisPakaianLabel"
        JenisPakaianLabel.Size = New System.Drawing.Size(76, 13)
        JenisPakaianLabel.TabIndex = 4
        JenisPakaianLabel.Text = "Jenis Pakaian:"
        '
        'JenisPakaianTextBox
        '
        Me.JenisPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "JenisPakaian", True))
        Me.JenisPakaianTextBox.Location = New System.Drawing.Point(139, 210)
        Me.JenisPakaianTextBox.Name = "JenisPakaianTextBox"
        Me.JenisPakaianTextBox.Size = New System.Drawing.Size(222, 20)
        Me.JenisPakaianTextBox.TabIndex = 5
        '
        'StokJenisPakaianLabel
        '
        StokJenisPakaianLabel.AutoSize = True
        StokJenisPakaianLabel.Location = New System.Drawing.Point(27, 239)
        StokJenisPakaianLabel.Name = "StokJenisPakaianLabel"
        StokJenisPakaianLabel.Size = New System.Drawing.Size(99, 13)
        StokJenisPakaianLabel.TabIndex = 6
        StokJenisPakaianLabel.Text = "stok Jenis Pakaian:"
        '
        'StokJenisPakaianTextBox
        '
        Me.StokJenisPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "stokJenisPakaian", True))
        Me.StokJenisPakaianTextBox.Location = New System.Drawing.Point(139, 236)
        Me.StokJenisPakaianTextBox.Name = "StokJenisPakaianTextBox"
        Me.StokJenisPakaianTextBox.Size = New System.Drawing.Size(222, 20)
        Me.StokJenisPakaianTextBox.TabIndex = 7
        '
        'StokBahanPakaianLabel
        '
        StokBahanPakaianLabel.AutoSize = True
        StokBahanPakaianLabel.Location = New System.Drawing.Point(27, 265)
        StokBahanPakaianLabel.Name = "StokBahanPakaianLabel"
        StokBahanPakaianLabel.Size = New System.Drawing.Size(106, 13)
        StokBahanPakaianLabel.TabIndex = 8
        StokBahanPakaianLabel.Text = "stok Bahan Pakaian:"
        '
        'StokBahanPakaianTextBox
        '
        Me.StokBahanPakaianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbpakaianBindingSource, "stokBahanPakaian", True))
        Me.StokBahanPakaianTextBox.Location = New System.Drawing.Point(139, 262)
        Me.StokBahanPakaianTextBox.Name = "StokBahanPakaianTextBox"
        Me.StokBahanPakaianTextBox.Size = New System.Drawing.Size(222, 20)
        Me.StokBahanPakaianTextBox.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(367, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(367, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(367, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 349)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdJenisPakaianLabel)
        Me.Controls.Add(Me.IdJenisPakaianTextBox)
        Me.Controls.Add(JenisPakaianLabel)
        Me.Controls.Add(Me.JenisPakaianTextBox)
        Me.Controls.Add(StokJenisPakaianLabel)
        Me.Controls.Add(Me.StokJenisPakaianTextBox)
        Me.Controls.Add(StokBahanPakaianLabel)
        Me.Controls.Add(Me.StokBahanPakaianTextBox)
        Me.Controls.Add(Me.TbpakaianDataGridView)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpakaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpakaianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PakaianonlineDataSet As MI_store.pakaianonlineDataSet
    Friend WithEvents TbpakaianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbpakaianTableAdapter As MI_store.pakaianonlineDataSetTableAdapters.tbpakaianTableAdapter
    Friend WithEvents TableAdapterManager As MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbpakaianDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdJenisPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JenisPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StokJenisPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StokBahanPakaianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
