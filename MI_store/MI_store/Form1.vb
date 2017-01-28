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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.TbbahanpakaianBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TbbahanpakaianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("hapus data", "konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            TbbahanpakaianBindingSource.RemoveCurrent()

            Me.Validate()
            Me.TbbahanpakaianBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
        End If
    End Sub
End Class
