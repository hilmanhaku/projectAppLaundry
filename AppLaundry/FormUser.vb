Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe
Public Class FormUser
    Private selectedId As Integer
    Sub ResetForm()

        txtNamaUser.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbLevelUser.SelectedIndex = -1

        txtNamaUser.Focus()

    End Sub
    Sub TampilData()

        Call Konek()

        da = New MySqlDataAdapter(
        "SELECT * FROM users",
        Koneksi
    )

        dt = New DataTable

        da.Fill(dt)

        dgvUser.DataSource = dt

        Call Diskonek()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLevelUser.SelectedIndexChanged

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("username / password wajib diisi...")
        Else
            Try

                Call Konek()

                Dim query As String =
                "INSERT INTO users
            (
                nama_user,
                username,
                password,
                level_user
            )
            VALUES
            (
                @nama,
                @username,
                @password,
                @level
            )"

                cmd = New MySqlCommand(
                query,
                Koneksi
            )

                cmd.Parameters.AddWithValue(
                "@nama",
                txtNamaUser.Text
            )

                cmd.Parameters.AddWithValue(
                "@username",
                txtUsername.Text
            )

                cmd.Parameters.AddWithValue(
                "@password",
                txtPassword.Text
            )
                cmd.Parameters.AddWithValue(
                "@level",
                cmbLevelUser.SelectedItem.ToString()
            )


                cmd.ExecuteNonQuery()

                MsgBox(
                "Data Berhasil Disimpan"
            )

                TampilData()

                ResetForm()

                Call Diskonek()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        Dim baris As Integer =
        dgvUser.CurrentRow.Index

        ' Store the id of the selected row for use in update/delete operations
        selectedId = CInt(dgvUser.Rows(baris).Cells(0).Value)

        txtNamaUser.Text =
        dgvUser.Rows(baris).
        Cells(1).Value

        txtUsername.Text =
        dgvUser.Rows(baris).
        Cells(2).Value

        txtPassword.Text =
        dgvUser.Rows(baris).
        Cells(3).Value

        cmbLevelUser.SelectedItem =
            dgvUser.Rows(baris).
                        Cells(4).Value

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Try

            Call Konek()
            ' Use the selectedId set in dgvUser_CellClick for the WHERE clause
            Dim query As String =
                "update users set
                nama_user = @nama,
                username = @username,
                password = @password,
                level_user = @level
            WHERE id_user = @id"



            cmd = New MySqlCommand(
                query,
                Koneksi
            )

            cmd.Parameters.AddWithValue(
                "@nama",
                txtNamaUser.Text
            )

            cmd.Parameters.AddWithValue(
                "@username",
                txtUsername.Text
            )

            cmd.Parameters.AddWithValue(
                "@password",
                txtPassword.Text
            )
            cmd.Parameters.AddWithValue(
                "@level",
                cmbLevelUser.SelectedItem.ToString()
            )
            cmd.Parameters.AddWithValue(
                "@id",
                selectedId
            )


            cmd.ExecuteNonQuery()

            MsgBox(
                "Data Berhasil Disimpan"
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

                ' Use the previously stored selectedId from dgvUser_CellClick
                Dim id As Integer = selectedId
                Dim query As String =
                "DELETE FROM users
                 WHERE id_user=@id"

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

    Private Sub txtCariPelanggan_Click(sender As Object, e As EventArgs) Handles txtCariUser.Click

        Call Konek()

        da = New MySqlDataAdapter(
        "SELECT * FROM users
         WHERE nama_user
         LIKE '%" &
         txtCariUser.Text &
         "%'",
        Koneksi
    )

        dt = New DataTable

        da.Fill(dt)

        dgvUser.DataSource = dt

        Call Diskonek()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ResetForm()
    End Sub
End Class