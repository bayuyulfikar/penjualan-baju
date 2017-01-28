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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        IdJenisPakaianTextBox.Enabled = True
        JenisPakaianTextBox.Enabled = True
        StokBahanPakaianTextBox.Enabled = True
        StokJenisPakaianTextBox.Enabled = True

        Me.TbpakaianBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TbpakaianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)

        MessageBox.Show("PENYIMPANAN BERHASIL")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("hapus data", "konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            TbpakaianBindingSource.RemoveCurrent()

            Me.Validate()
            Me.TbpakaianBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        IdJenisPakaianTextBox.Enabled = False
    End Sub

    Private Sub BATALButton_Click(sender As System.Object, e As System.EventArgs) Handles BATALButton.Click
        IdJenisPakaianTextBox.Enabled = True
        JenisPakaianTextBox.Enabled = True
        StokBahanPakaianTextBox.Enabled = True
        StokJenisPakaianTextBox.Enabled = True

    End Sub
End Class