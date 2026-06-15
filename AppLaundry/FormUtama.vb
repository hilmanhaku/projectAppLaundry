Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserLogin.Text = UserLogin

        LoadForm(FormDashboard)

    End Sub

    Public Sub LoadForm(ByVal form As Form)

        PanelContainer.Controls.Clear()

        form.TopLevel = False

        form.FormBorderStyle =
            FormBorderStyle.None

        form.Dock = DockStyle.Fill

        PanelContainer.Controls.Add(form)

        form.Show()

    End Sub

    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnDasboard.Click
        LoadForm(FormDashboard)
    End Sub
    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        LoadForm(Formpelanggan)
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        LoadForm(FormTransaksi)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadForm(FormUser)
    End Sub
End Class