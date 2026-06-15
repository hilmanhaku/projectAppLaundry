Imports MySql.Data.MySqlClient
Public Class Formpelanggan

    Sub TampilData()

        Call Konek()

        da = New MySqlDataAdapter(
        "SELECT * FROM pelanggan",
        Koneksi
    )

        dt = New DataTable

        da.Fill(dt)

        dgvPelanggan.DataSource = dt

        Call Diskonek()

    End Sub

    Sub ResetForm()

        txtNama.Clear()
        txtNoHP.Clear()
        txtAlamat.Clear()

        txtNama.Focus()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try

            Call Konek()

            Dim query As String =
                "INSERT INTO pelanggan
            (
                nama_pelanggan,
                no_hp,
                alamat
            )
            VALUES
            (
                @nama,
                @hp,
                @alamat
            )"

            cmd = New MySqlCommand(
                query,
                Koneksi
            )

            cmd.Parameters.AddWithValue(
                "@nama",
                txtNama.Text
            )

            cmd.Parameters.AddWithValue(
                "@hp",
                txtNoHP.Text
            )

            cmd.Parameters.AddWithValue(
                "@alamat",
                txtAlamat.Text
            )

            cmd.ExecuteNonQuery()

            MsgBox(
                "Data Berhasil Disimpan"
            )

            TampilData()

            ResetForm()
            FormTransaksi.TampilPelanggan()


            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dgvPelanggan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellContentClick

    End Sub

    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        Dim baris As Integer =
        dgvPelanggan.CurrentRow.Index

        txtNama.Text =
        dgvPelanggan.Rows(baris).
        Cells(1).Value

        txtNoHP.Text =
        dgvPelanggan.Rows(baris).
        Cells(2).Value

        txtAlamat.Text =
        dgvPelanggan.Rows(baris).
        Cells(3).Value

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Try

            Call Konek()

            Dim id As String =
                dgvPelanggan.CurrentRow.
                Cells(0).Value

            Dim query As String =
                "UPDATE pelanggan SET
            nama_pelanggan=@nama,
            no_hp=@hp,
            alamat=@alamat
            WHERE id_pelanggan=@id"

            cmd = New MySqlCommand(
                query,
                Koneksi
            )

            cmd.Parameters.AddWithValue(
                "@nama",
                txtNama.Text
            )

            cmd.Parameters.AddWithValue(
                "@hp",
                txtNoHP.Text
            )

            cmd.Parameters.AddWithValue(
                "@alamat",
                txtAlamat.Text
            )

            cmd.Parameters.AddWithValue(
                "@id",
                id
            )

            cmd.ExecuteNonQuery()

            MsgBox(
                "Data Berhasil Diubah"
            )

            TampilData()

            ResetForm()

            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try

            Dim jawab As DialogResult

            jawab = MessageBox.Show(
                "Yakin ingin menghapus data?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If jawab = DialogResult.Yes Then

                Call Konek()

                Dim id As String =
                    dgvPelanggan.CurrentRow.
                    Cells(0).Value

                Dim query As String =
                    "DELETE FROM pelanggan
                 WHERE id_pelanggan=@id"

                cmd = New MySqlCommand(
                    query,
                    Koneksi
                )

                cmd.Parameters.AddWithValue(
                    "@id",
                    id
                )

                cmd.ExecuteNonQuery()

                MsgBox(
                    "Data Berhasil Dihapus"
                )

                TampilData()

                ResetForm()

                Call Diskonek()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtCariPelanggan_Click(sender As Object, e As EventArgs) Handles txtCariPelanggan.Click
        Call Konek()

        da = New MySqlDataAdapter(
            "SELECT * FROM pelanggan
         WHERE nama_pelanggan
         LIKE '%" &
             txtCariPelanggan.Text &
             "%'",
            Koneksi
        )

        dt = New DataTable

        da.Fill(dt)

        dgvPelanggan.DataSource = dt

        Call Diskonek()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub Formpelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub txtNama_Click(sender As Object, e As EventArgs) Handles txtNama.Click

    End Sub
End Class