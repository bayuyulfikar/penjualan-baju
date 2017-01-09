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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IdBahanPakaianLabel As System.Windows.Forms.Label
        Dim NamaBahanPakaianLabel As System.Windows.Forms.Label
        Dim HargaBahanPakaianLabel As System.Windows.Forms.Label
        Dim StokBahanPakaianLabel As System.Windows.Forms.Label
        Dim TbPakaian_idJenisPakaianLabel As System.Windows.Forms.Label
        Me.PakaianonlineDataSet = New MI_store.pakaianonlineDataSet()
        Me.TbbahanpakaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbbahanpakaianTableAdapter = New MI_store.pakaianonlineDataSetTableAdapters.tbbahanpakaianTableAdapter()
        Me.TableAdapterManager = New MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager()
        Me.TbbahanpakaianBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TbbahanpakaianBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        IdBahanPakaianLabel = New System.Windows.Forms.Label()
        NamaBahanPakaianLabel = New System.Windows.Forms.Label()
        HargaBahanPakaianLabel = New System.Windows.Forms.Label()
        StokBahanPakaianLabel = New System.Windows.Forms.Label()
        TbPakaian_idJenisPakaianLabel = New System.Windows.Forms.Label()
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbbahanpakaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbbahanpakaianBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbbahanpakaianBindingNavigator.SuspendLayout()
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
        'TbbahanpakaianBindingNavigator
        '
        Me.TbbahanpakaianBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TbbahanpakaianBindingNavigator.BindingSource = Me.TbbahanpakaianBindingSource
        Me.TbbahanpakaianBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TbbahanpakaianBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TbbahanpakaianBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbbahanpakaianBindingNavigatorSaveItem})
        Me.TbbahanpakaianBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TbbahanpakaianBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TbbahanpakaianBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TbbahanpakaianBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TbbahanpakaianBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TbbahanpakaianBindingNavigator.Name = "TbbahanpakaianBindingNavigator"
        Me.TbbahanpakaianBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TbbahanpakaianBindingNavigator.Size = New System.Drawing.Size(675, 25)
        Me.TbbahanpakaianBindingNavigator.TabIndex = 0
        Me.TbbahanpakaianBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TbbahanpakaianBindingNavigatorSaveItem
        '
        Me.TbbahanpakaianBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbbahanpakaianBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbbahanpakaianBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TbbahanpakaianBindingNavigatorSaveItem.Name = "TbbahanpakaianBindingNavigatorSaveItem"
        Me.TbbahanpakaianBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TbbahanpakaianBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TbbahanpakaianDataGridView
        '
        Me.TbbahanpakaianDataGridView.AutoGenerateColumns = False
        Me.TbbahanpakaianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbbahanpakaianDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TbbahanpakaianDataGridView.DataSource = Me.TbbahanpakaianBindingSource
        Me.TbbahanpakaianDataGridView.Location = New System.Drawing.Point(12, 28)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 449)
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
        Me.Controls.Add(Me.TbbahanpakaianBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PakaianonlineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbbahanpakaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbbahanpakaianBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbbahanpakaianBindingNavigator.ResumeLayout(False)
        Me.TbbahanpakaianBindingNavigator.PerformLayout()
        CType(Me.TbbahanpakaianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PakaianonlineDataSet As MI_store.pakaianonlineDataSet
    Friend WithEvents TbbahanpakaianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbbahanpakaianTableAdapter As MI_store.pakaianonlineDataSetTableAdapters.tbbahanpakaianTableAdapter
    Friend WithEvents TableAdapterManager As MI_store.pakaianonlineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbbahanpakaianBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TbbahanpakaianBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
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

End Class
