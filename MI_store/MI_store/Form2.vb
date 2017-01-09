Public Class Form2

    Private Sub TbkeuanganBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TbkeuanganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PakaianonlineDataSet.tbkeuangan' table. You can move, or remove it, as needed.
        Me.TbkeuanganTableAdapter.Fill(Me.PakaianonlineDataSet.tbkeuangan)

    End Sub
End Class