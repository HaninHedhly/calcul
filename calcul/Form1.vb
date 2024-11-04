Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        txt_affiche.Text = A + " " + op + " " + B

    End Sub

    Private Sub un_Click(sender As Object, e As EventArgs) Handles un.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub deux_Click(sender As Object, e As EventArgs) Handles deux.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub trois_Click(sender As Object, e As EventArgs) Handles trois.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub quatre_Click(sender As Object, e As EventArgs) Handles quatre.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub cinq_Click(sender As Object, e As EventArgs) Handles cinq.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub sept_Click(sender As Object, e As EventArgs) Handles sept.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub night_Click(sender As Object, e As EventArgs) Handles night.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        If Not A = "" Then
            op = "+"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub moin_Click(sender As Object, e As EventArgs) Handles moin.Click
        If Not A = "" Then
            op = "-"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub fois_Click(sender As Object, e As EventArgs) Handles fois.Click
        If Not A = "" Then
            op = "*"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        If Not A = "" Then
            op = "/"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        txt_affiche.Text = ""

    End Sub

    Private Sub resultat_Click(sender As Object, e As EventArgs) Handles resultat.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not vb = "" Then
                res = va / vb
            Else
                MessageBox.Show("div par 0")
                test = False

            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers")
            test = False

        End If
        If test Then
            txt_affiche.Text = txt_affiche.Text + "=" + res.ToString

        End If
    End Sub
End Class
