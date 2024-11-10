Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "tepen" And TextBox2.Text = "admin" Then
            MessageBox.Show("Login berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Login gagal", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim frm2 As New Form2
        frm2.Show()
        Me.Close()
        Dim sound = CreateObject("SAPI.spvoice")
        sound.speak("login successful")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Handle the Click event as needed.
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        ' Change the PictureBox's border or background color to red when the mouse enters.
        PictureBox2.BackColor = Color.Red
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        ' Restore the original PictureBox's border or background color when the mouse leaves.
        PictureBox2.BackColor = SystemColors.Control ' You can use a different color if needed.
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


End Class
