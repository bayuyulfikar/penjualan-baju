Public Class Form1

    Private Sub TbbahanpakaianBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TbbahanpakaianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PakaianonlineDataSet.tbbahanpakaian' table. You can move, or remove it, as needed.
        Me.TbbahanpakaianTableAdapter.Fill(Me.PakaianonlineDataSet.tbbahanpakaian)

    End Sub
End Class
