Imports MySql.Data.MySqlClient
Module ModuleKoneksi

    Public SessionIDUser As String
    Public UserLogin As String
    Public SessionLevel As String

    Dim MySQLKonek As String = "Server=localhost;Database=db_laundry1;User=root;Password=;SslMode="
    Public Koneksi As New MySqlConnection(MySQLKonek)

    Public da As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dt As New DataTable
    Public dr As MySqlDataReader

    Public Status As Boolean = False
    Public Sub Konek()
        Try
            ' Cek jika koneksi masih terbuka, tutup dulu baru buka lagi
            If Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
            Koneksi.Open()
            'MessageBox.Show("Koneksi Database Berhasil")
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub

    Function Diskonek()
        Koneksi.Close()
        Return Koneksi
    End Function
End Module
