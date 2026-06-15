Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class FormTransaksi

    Dim kode As String
    Dim tanggal As String
    Dim pelanggan As String
    Dim userLogin As String
    Dim berat As String
    Dim harga As String
    Dim total As String
    Dim status_loundry As String

    'TAMPILKAN DATA TRANSAKSI
    Sub TampilData()

        Call Konek()

        Dim query As String =
        "SELECT
            transaksi.id_transaksi,
            transaksi.kode_transaksi,
            transaksi.tanggal,
            pelanggan.nama_pelanggan,
            users.nama_user,
            transaksi.berat,
            transaksi.harga_perkg,
            transaksi.total_bayar,
            transaksi.status_laundry
         FROM transaksi
         JOIN pelanggan
         ON transaksi.id_pelanggan =
            pelanggan.id_pelanggan
         JOIN users
         ON transaksi.id_user =
            users.id_user"

        da = New MySqlDataAdapter(
        query,
        Koneksi
    )

        dt = New DataTable

        da.Fill(dt)

        dgvTransaksi.DataSource = dt

        dgvTransaksi.Columns(0).Visible =
        False

        dgvTransaksi.Columns(1).HeaderText =
        "Kode"

        dgvTransaksi.Columns(2).HeaderText =
        "Tanggal"

        dgvTransaksi.Columns(3).HeaderText =
        "Pelanggan"

        dgvTransaksi.Columns(4).HeaderText =
        "User"

        dgvTransaksi.Columns(5).HeaderText =
        "Berat"

        dgvTransaksi.Columns(6).HeaderText =
        "Harga/Kg"

        dgvTransaksi.Columns(7).HeaderText =
        "Total Bayar"

        dgvTransaksi.Columns(8).HeaderText =
        "Status"

        dgvTransaksi.Columns(7).
    DefaultCellStyle.Format = "N0"

        Call Diskonek()

    End Sub

    'RESET DATA
    Sub ResetForm()

        txtBeratCucian.Clear()
        txtHargaPer.Clear()
        txtTotalBayar.Clear()

        cbPelanggan.SelectedIndex = -1
        cbStatus.SelectedIndex = -1

        txtBeratCucian.Focus()

    End Sub

    'GET DATA PELANGGAN
    Sub TampilPelanggan()

        Call Konek()

        Dim query As String =
            "SELECT * FROM pelanggan"

        cmd = New MySqlCommand(
            query,
            Koneksi
        )

        dr = cmd.ExecuteReader()

        cbPelanggan.Items.Clear()

        While dr.Read()

            cbPelanggan.Items.Add(
                dr("nama_pelanggan")
            )

        End While

        dr.Close()

        Call Diskonek()

    End Sub

    'STATUS LAUNDRY

    Sub StatusLaundry()

        cbStatus.Items.Add("Proses")
        cbStatus.Items.Add("Selesai")
        cbStatus.Items.Add("Diambil")

    End Sub

    'KODE TRANSAKSI
    Sub GenerateKode()

        Call Konek()

        cmd = New MySqlCommand(
            "SELECT * FROM transaksi 
         ORDER BY id_transaksi DESC",
            Koneksi
        )

        dr = cmd.ExecuteReader()

        If dr.Read() Then

            Dim nomor As Integer

            nomor =
                Val(Microsoft.VisualBasic.Right(
                dr.Item("kode_transaksi").ToString,
                3
            )) + 1

            txtKode.Text =
                "TRX" &
                Format(nomor, "000")

        Else

            txtKode.Text = "TRX001"

        End If

        dr.Close()

        Call Diskonek()

    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()

        TotalPendapatan()


        TampilPelanggan()

        StatusLaundry()

        GenerateKode()

    End Sub


    Private Sub txtBeratCucian_TextChanged(sender As Object, e As EventArgs) Handles txtBeratCucian.TextChanged

        'HITUNG OTOMATIS

        If txtBeratCucian.Text <> "" And
      txtHargaPer.Text <> "" Then

            Dim berat As Double
            Dim harga As Double

            berat = Val(txtBeratCucian.Text)
            harga = Val(txtHargaPer.Text)

            txtTotalBayar.Text =
                berat * harga

        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try

            Call Konek()

            Dim idPelanggan As String = ""

            cmd = New MySqlCommand(
                "SELECT id_pelanggan 
             FROM pelanggan
             WHERE nama_pelanggan=@nama",
                Koneksi
            )

            cmd.Parameters.AddWithValue(
                "@nama",
                cbPelanggan.Text
            )

            dr = cmd.ExecuteReader()

            If dr.Read() Then

                idPelanggan =
                    dr("id_pelanggan")

            End If

            dr.Close()

            Dim query As String =
                "INSERT INTO transaksi
            (
                kode_transaksi,
                tanggal,
                id_pelanggan,
                id_user,
                berat,
                harga_perkg,
                total_bayar,
                status_laundry
            )
            VALUES
            (
                @kode,
                @tanggal,
                @pelanggan,
                @user,
                @berat,
                @harga,
                @total,
                @status
            )"

            cmd = New MySqlCommand(
                query,
                Koneksi
            )

            cmd.Parameters.AddWithValue(
                "@kode",
                txtKode.Text
            )

            cmd.Parameters.AddWithValue(
                "@tanggal",
                dtTanggal.Value
            )

            cmd.Parameters.AddWithValue(
                "@pelanggan",
                idPelanggan
            )

            cmd.Parameters.AddWithValue(
                "@user",
                SessionIDUser
            )

            cmd.Parameters.AddWithValue(
                "@berat",
                txtBeratCucian.Text
            )

            cmd.Parameters.AddWithValue(
                "@harga",
                txtHargaPer.Text
            )

            cmd.Parameters.AddWithValue(
                "@total",
                txtTotalBayar.Text
            )

            cmd.Parameters.AddWithValue(
                "@status",
                cbStatus.Text
            )

            cmd.ExecuteNonQuery()

            MsgBox(
                "Transaksi Berhasil Disimpan"
            )

            TampilData()

            ResetForm()

            GenerateKode()
            TotalPendapatan()


            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Call Konek()

        Dim query As String =
            "SELECT
                transaksi.id_transaksi,
                transaksi.kode_transaksi,
                transaksi.tanggal,
                pelanggan.nama_pelanggan,
                users.nama_user,
                transaksi.berat,
                transaksi.harga_perkg,
                transaksi.total_bayar,
                transaksi.status_laundry
             FROM transaksi
             JOIN pelanggan
             ON transaksi.id_pelanggan =
                pelanggan.id_pelanggan
             JOIN users
             ON transaksi.id_user =
                users.id_user
             WHERE pelanggan.nama_pelanggan
             LIKE @cari
             ORDER BY transaksi.id_transaksi DESC"

        cmd = New MySqlCommand(
            query,
            Koneksi
        )

        cmd.Parameters.AddWithValue(
            "@cari",
            "%" & txtCari.Text & "%"
        )

        da = New MySqlDataAdapter(cmd)

        dt = New DataTable

        da.Fill(dt)

        dgvTransaksi.DataSource = dt

        If dgvTransaksi.Columns.Count > 0 Then

            dgvTransaksi.Columns(0).Visible =
                False

            dgvTransaksi.Columns(1).HeaderText =
                "Kode"

            dgvTransaksi.Columns(2).HeaderText =
                "Tanggal"

            dgvTransaksi.Columns(3).HeaderText =
                "Pelanggan"

            dgvTransaksi.Columns(4).HeaderText =
                "User"

            dgvTransaksi.Columns(5).HeaderText =
                "Berat"

            dgvTransaksi.Columns(6).HeaderText =
                "Harga/Kg"

            dgvTransaksi.Columns(7).HeaderText =
                "Total Bayar"

            dgvTransaksi.Columns(8).HeaderText =
                "Status"

            dgvTransaksi.Columns(7).
            DefaultCellStyle.Format = "N0"

            dgvTransaksi.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

        End If

        Call Diskonek()
    End Sub

    'TOTAL PENDAPATAN
    Sub TotalPendapatan()

        Call Konek()

        cmd = New MySqlCommand(
            "SELECT SUM(total_bayar)
         FROM transaksi",
            Koneksi
        )

        Dim total As Object

        total = cmd.ExecuteScalar()

        If IsDBNull(total) Then

            lblTotalPendapatan.Text =
                "0"

        Else

            lblTotalPendapatan.Text =
                Format(total, "N0")

        End If

        Call Diskonek()

    End Sub


    Private Sub dgvTransaksi_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvTransaksi.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow =
            dgvTransaksi.Rows(e.RowIndex)

            kode =
            row.Cells(1).Value.ToString()

            tanggal =
            row.Cells(2).Value.ToString()

            pelanggan =
            row.Cells(3).Value.ToString()

            userLogin =
            row.Cells(4).Value.ToString()

            berat =
            row.Cells(5).Value.ToString()

            harga =
            row.Cells(6).Value.ToString()

            total =
            row.Cells(7).Value.ToString()

            status_loundry =
            row.Cells(8).Value.ToString()

        End If

    End Sub



    Private Sub PrintDocument1_PrintPage(
    sender As Object,
    e As Printing.PrintPageEventArgs
) Handles PrintDocument1.PrintPage
        Dim fontJudul As New Font(
        "Poppins",
        16,
        FontStyle.Bold
    )

        Dim fontIsi As New Font(
        "Consolas",
        11
    )

        Dim y As Integer = 40

        ' =========================
        ' LOAD LOGO RESOURCE
        ' =========================

        Dim logo As Image =
        My.Resources.logo_kucing_2


        ' =========================
        ' TAMPILKAN LOGO
        ' =========================

        e.Graphics.DrawImage(
        logo,
        20,
        20,
        60,
        60
    )

        ' =========================
        ' JUDUL
        ' =========================

        e.Graphics.DrawString(
        "LAINDORI LAUNDRY",
        fontJudul,
        Brushes.Black,
        95,
        y
    )

        y += 35

        e.Graphics.DrawString(
        "Laundry Cepat & Bersih",
        fontIsi,
        Brushes.Black,
        95,
        y
    )

        y += 40

        e.Graphics.DrawString(
        "================================",
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 30

        e.Graphics.DrawString(
        "Kode       : " & kode,
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 25

        e.Graphics.DrawString(
        "Tanggal    : " & tanggal,
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 25

        e.Graphics.DrawString(
        "Pelanggan  : " & pelanggan,
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 25

        e.Graphics.DrawString(
        "Kasir      : " & userLogin,
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 35

        e.Graphics.DrawString(
        "--------------------------------",
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 30

        e.Graphics.DrawString(
        "Berat          : " &
        berat & " Kg",
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 25

        e.Graphics.DrawString(
        "Harga / Kg     : " &
        harga,
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 25

        e.Graphics.DrawString(
        "Total Bayar    : " &
        Format(
            Val(total),
            "N0"
        ),
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 25

        e.Graphics.DrawString(
        "Status         : " &
        status_loundry,
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 35

        e.Graphics.DrawString(
        "--------------------------------",
        fontIsi,
        Brushes.Black,
        20,
        y
    )

        y += 35

        e.Graphics.DrawString(
        "Terima Kasih",
        fontIsi,
        Brushes.Black,
        80,
        y
    )

    End Sub


    Private Sub btnCetak_Click(
    sender As Object,
    e As EventArgs
) Handles btnCetak.Click

        PrintPreviewDialog1.Document =
        PrintDocument1

        PrintPreviewDialog1.ShowDialog()

    End Sub

End Class