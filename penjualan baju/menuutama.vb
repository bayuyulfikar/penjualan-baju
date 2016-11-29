Public Class menuutama

    Private Sub TbbahanpakaianBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TbbahanpakaianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)

    End Sub

    Private Sub menuutama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PakaianonlineDataSet.tbpakaian' table. You can move, or remove it, as needed.
        Me.TbpakaianTableAdapter.Fill(Me.PakaianonlineDataSet.tbpakaian)
        'TODO: This line of code loads data into the 'PakaianonlineDataSet.tbbahanpakaian' table. You can move, or remove it, as needed.
        Me.TbbahanpakaianTableAdapter.Fill(Me.PakaianonlineDataSet.tbbahanpakaian)

    End Sub

    Private Sub TambahButton_Click(sender As System.Object, e As System.EventArgs) Handles TambahButton.Click
        TbpakaianBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.TbpakaianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
    End Sub
End Class