Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm1 As New Form1
        frm1.Show()
        Me.Close()
        Dim sound = CreateObject("SAPI.spvoice")
        sound.speak("logged out")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set DateTimePicker to display only the time
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker2.ShowUpDown = True
        DateTimePicker3.ShowUpDown = True
        ' Set custom time format
        DateTimePicker2.CustomFormat = "hh:mm tt"
        DateTimePicker3.CustomFormat = "hh:mm tt"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kendaraan = TextBox1.Text
        SelectedDate = DateTimePicker1.Value
        masuk = DateTimePicker2.Value
        keluar = DateTimePicker3.Value
        plat = TextBox3.Text
        Dim frm3 As New Form3
        frm3.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kendaraan = TextBox1.Text
        SelectedDate = DateTimePicker1.Value
        masuk = DateTimePicker2.Value
        keluar = DateTimePicker3.Value
        plat = TextBox3.Text
        Dim frm4 As New Form4
        frm4.Show()
        Me.Close()
    End Sub
End Class