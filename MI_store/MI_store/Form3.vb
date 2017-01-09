Public Class Form3

    Private Sub TbpakaianBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TbpakaianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PakaianonlineDataSet.tbpakaian' table. You can move, or remove it, as needed.
        Me.TbpakaianTableAdapter.Fill(Me.PakaianonlineDataSet.tbpakaian)

    End Sub
End Class