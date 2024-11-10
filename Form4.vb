Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New Form2
        frm2.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = kendaraan
        Label3.Text = SelectedDate.ToString("dd MMMM yyyy")
        Label9.Text = plat
        Label10.Text = masuk.ToString("hh:mm tt")
        Label11.Text = keluar.ToString("hh:mm tt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("berhasil masuk  ke database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("mencetak karcis", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("data tersimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class