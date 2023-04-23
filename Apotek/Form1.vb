Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Focus()
        Me.ActiveControl = username
        password.UseSystemPasswordChar = True
    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If e.KeyChar = Chr(13) Then
            password.Focus()
        End If
    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Chr(13) Then
            blogin.Focus()
        End If
    End Sub

    Sub insertlogin()
        koneksi()
        Dim userid As Integer
        CMD = New MySqlCommand("select id_user from tbl_user where username = '" & username.Text & "'", CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            userid = RD("id_user")
            RD.Close()
            Dim datenow As DateTime = DateTime.Now
            CMD = New MySqlCommand("insert into tbl_log (waktu, aktivitas, id_user) values ('" & datenow.ToString("yyyy/MM/dd HH:mm:ss") & "', 'Login', " & userid & ")", CONN)
            CMD.ExecuteNonQuery()
        End If
    End Sub

    Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click
        If username.Text = "" Or password.Text = "" Then
            MessageBox.Show("Harap isi username dan password!")
        Else
            koneksi()
            CMD = New MySqlCommand("Select * from tbl_user where Username ='" & username.Text & "' and Password = '" & password.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                If RD("Tipe_User").ToString = "Admin" Then
                    Call insertlogin()
                    username.Text = ""
                    password.Text = ""
                    Me.Hide()
                    Form2.Show()
                ElseIf RD("Tipe_User").ToString = "Apoteker" Then
                    Call insertlogin()
                    username.Text = ""
                    password.Text = ""
                    Me.Hide()
                    Form6.Show()
                ElseIf RD("Tipe_User").ToString = "Kasir" Then
                    Call insertlogin()
                    username.Text = ""
                    password.Text = ""
                    Me.Hide()
                    Form7.Show()
                End If
            Else
                RD.Close()
                MessageBox.Show("Periksa Kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                username.Focus()
                username.Text = ""
                password.Text = ""
            End If
            RD.Close()
        End If
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        username.Focus()
        username.Text = ""
        password.Text = ""
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs) Handles show.Click
        If password.UseSystemPasswordChar = True Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

End Class
