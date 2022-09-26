Public Class Form1

    Dim Potongan As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://iconscout.com/icon/cashier-26")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://github.com/BMegaGPea990/BP-School-Project-Repo")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = ("Buku Tulis") Then TextBox5.Text = ("2000")

        If ComboBox1.Text = ("Buku Gambar") Then TextBox5.Text = ("3000")

        If ComboBox1.Text = ("Pulpen Boxy") Then TextBox5.Text = ("2500")

        If ComboBox1.Text = ("Pensil Mekanik") Then TextBox5.Text = ("2000")

        If ComboBox1.Text = ("Penggaris Rotring") Then TextBox5.Text = ("3000")

        If ComboBox1.Text = ("Rautan Pensil") Then TextBox5.Text = ("15000")
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Function A() As Object
        Throw New NotImplementedException
    End Function

    Private Function B() As Object
        Throw New NotImplementedException
    End Function

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

        TextBox4.Focus()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged

        potongan = sender.text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim diskon As Single

        Dim total As Single

        If TextBox1.Text = Int(TextBox1.Text) Then

            diskon = (TextBox2.Text * TextBox2.Text * Potongan) / 100

            total = (TextBox2.Text * TextBox2.Text - diskon)

            TextBox2.Text = Format(total, "#,#")

        Else : TextBox2.Text = "Maaf, terjadi kesalahan. Silakan coba lagi."

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim kembalian As Integer

        If TextBox5.Text >= TextBox2.Text Then

            kembalian = (TextBox5.Text = TextBox2.Text)

            TextBox4.Text = kembalian

        ElseIf TextBox5.Text < TextBox2.Text Then

            TextBox4.Text = "Uang anda kurang"

        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

        TextBox4.Text = (TextBox5.Text = TextBox2.Text)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
