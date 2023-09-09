Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Americano" Then
            TextBox1.Text = 20000
        ElseIf ComboBox1.Text = "Cafe Latte" Then
            TextBox1.Text = 27000
        ElseIf ComboBox1.Text = "Earl Grey Tea" Then
            TextBox1.Text = 25000
        ElseIf ComboBox1.Text = "Milk Tea" Then
            TextBox1.Text = 26000
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Roti Croissant" Then
            TextBox2.Text = 24000
        ElseIf ComboBox2.Text = "Roti Sandwich" Then
            TextBox2.Text = 23000
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim Nilai As Integer
        If Val(TextBox3.Text) <> 0 Then
            Nilai = Int(TextBox1.Text)
            TextBox1.Text = Nilai

        End If
    End Sub
End Class
