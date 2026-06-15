Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub Button1_Click(Sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("username / password wajib diisi...")
        Else
            Dim username, password As String
            username = txtUsername.Text
            password = txtPassword.Text
            Try
                Konek()
                cmd = New MySqlCommand("SELECT * FROM users WHERE username = '" & username & "' AND password ='" & password & "' ", Koneksi)
                'Dim reader As MySqlDataReader
                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then
                    ' Username dan password ditemukan
                    MessageBox.Show("Login Sukses, Akses Telah Diberikan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Buka Form Tujuan

                    UserLogin = dr("nama_User")
                    SessionIDUser = dr("id_user")
                    SessionLevel = dr("level_user")

                    Dim MainMenu As New FormUtama
                    MainMenu.Show()
                    Me.Hide()
                Else

                    ' Username dan password tidak ditemukan
                    MessageBox.Show("Login gagal ! Username atau password salah.", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click

    End Sub
End Class
