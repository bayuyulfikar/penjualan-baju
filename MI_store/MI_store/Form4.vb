Public Class Form4

    Private Sub TbpemesananBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TbpemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)

    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PakaianonlineDataSet.tbpemesanan' table. You can move, or remove it, as needed.
        Me.TbpemesananTableAdapter.Fill(Me.PakaianonlineDataSet.tbpemesanan)

    End Sub
End Class