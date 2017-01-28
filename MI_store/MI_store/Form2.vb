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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.TbkeuanganBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TbkeuanganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("hapus data", "konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            TbkeuanganBindingSource.RemoveCurrent()

            Me.Validate()
            Me.TbkeuanganBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
        End If
    End Sub
End Class