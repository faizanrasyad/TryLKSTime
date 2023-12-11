Public Class Home
    Dim home As Home
    Dim labtob As String
    Dim qty As Integer
    Dim total As Integer
    Dim itungan As Integer
    Dim index As Integer

    Public price() As Integer = {30000000, 16000000}
    Public laptopun As New ArrayList
    Public jumlahun As New ArrayList
    Public hargalun As New ArrayList
    Public totalun As New ArrayList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub comboLaptop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboLaptop.SelectedIndexChanged
        index = comboLaptop.SelectedIndex

        tbHarga.Text = "Rp" + CStr(price(index))

    End Sub

    Private Sub Home_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Show()

    End Sub

    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        labtob = comboLaptop.SelectedItem.ToString
        qty = numJumlah.Value
        total = price(index) * qty

        laptopun.Add(labtob)
        hargalun.Add(price(index))
        jumlahun.Add(qty)
        totalun.Add(total)

        For i = itungan To laptopun.Count - 1
            tabelLaporan.Rows.Add(New String() {i + 1, laptopun(i), hargalun(i), jumlahun(i), totalun(i)})
        Next

        MessageBox.Show("Nota Pembelian: " + vbNewLine + "Laptop: " + labtob + vbNewLine + "Harga Satuan: Rp" + price.ToString + vbNewLine + "Qty: " + qty.ToString + vbNewLine + "Total Harga: Rp" + total.ToString)

        comboLaptop.Text = ""
        tbHarga.Clear()
        numJumlah.Value = 1

        itungan += 1
    End Sub

End Class