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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.TbpemesananBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TbpemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("hapus data", "konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            TbpemesananBindingSource.RemoveCurrent()

            Me.Validate()
            Me.TbpemesananBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PakaianonlineDataSet)
        End If
    End Sub

    Private Sub BATALButton_Click(sender As System.Object, e As System.EventArgs) Handles BATALButton.Click
        IdPemesananTextBox.Enabled = True
        NamaPemesananTextBox.Enabled = True
        NamaBarangYangDipesanTextBox.Enabled = True
        TotalBarangYangDipesanTextBox.Enabled = True
        TotalHargaBarangTextBox.Enabled = True
        AlamatTujuanPengirimanTextBox.Enabled = True
        TanggalPesanBarangDateEdit.Enabled = True
        TanggalBarangDikirimDateEdit.Enabled = True
        TanggalBarangDiterimaDateEdit.Enabled = True
        PotonganHargaTextBox.Enabled = True

    End Sub
End Class