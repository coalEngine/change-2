Public Class Form1
    Dim tpp As Double = 0.0
    Dim tax As Double = 0.0
    Dim amount, temp As Integer




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tax = Val(TextBoxCostOfItem.Text) * 0.08125
        tpp = Val(TextBoxCostOfItem.Text) + Val(tax)

        TextBoxTax.Text = Math.Round(tax, 2)
        TextBoxTPP.Text = Math.Round(tpp, 2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        picture1.Visible = False
        picture2.Visible = False
        picture3.Visible = False
        picture4.Visible = False
        picture5.Visible = False
        picture6.Visible = False
        picture7.Visible = False
        picture8.Visible = False
        picture9.Visible = False
        picture10.Visible = False
        picture11.Visible = False
        picture12.Visible = False
        picture13.Visible = False
        picture14.Visible = False
        picture15.Visible = False
        picture16.Visible = False
        picture17.Visible = False
        picture18.Visible = False
        picture19.Visible = False
        picture20.Visible = False
        picture21.Visible = False
        picture22.Visible = False
        TextBoxChangeOg.Text = ""
        TextBoxCostOfItem.Text = ""
        TextBoxMoneyGiven.Text = ""
        TextBoxTPP.Text = ""
        TextBoxTax.Text = ""
        TextBox1dolan.Text = ""
        TextBox10.Text = ""
        TextBox100.Text = ""
        TextBox50.Text = ""
        TextBox20.Text = ""
        TextBoxP.Text = ""
        TextBoxQ.Text = ""
        TextBoxN.Text = ""
        TextBoxD.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxChangeOg.Text = Math.Round(Val(TextBoxMoneyGiven.Text) - Val(TextBoxTPP.Text), 2)
        Dim DataQ As Integer = 0
        Dim find100 As Integer
        Dim find50 As Integer
        Dim find20 As Integer
        Dim find10 As Integer
        Dim find5 As Integer
        Dim find1 As Integer
        Dim findQ As Integer
        Dim findD As Integer
        Dim findN As Integer
        Dim findP As Integer

        Do While Val(TextBoxChangeOg.Text) >= 100
            find100 += 1
            TextBox100.Text = find100
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 100
            If find100 = 1 Then
                picture1.Visible = True
            End If
            If find100 = 2 Then
                picture2.Visible = True
            End If
            If find100 = 3 Then
                picture3.Visible = True
            End If
        Loop


        Do While Val(TextBoxChangeOg.Text) >= 50
            find50 += 1
            TextBox50.Text = find50
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 50
            If find50 = 1 Then
                picture4.Visible = True
            End If
        Loop



        Do While Val(TextBoxChangeOg.Text) >= 20
            find20 += 1
            TextBox20.Text = find20
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 20
            If find20 = 1 Then
                picture5.Visible = True
            End If
            If find20 = 2 Then
                picture6.Visible = True
            End If
        Loop



        Do While Val(TextBoxChangeOg.Text) >= 10
            find10 += 1
            TextBox10.Text = find10
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 10
            If find10 = 1 Then
                picture7.Visible = True
            End If
        Loop

        Do While Val(TextBoxChangeOg.Text) >= 5
            find5 += 1
            TextBox5Buks.Text = find5
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 5
            If find5 = 1 Then
                picture8.Visible = True
            End If
        Loop

        Do While Val(TextBoxChangeOg.Text) >= 1
            find1 += 1
            TextBox1dolan.Text = find1
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 1
            If find1 = 1 Then
                picture9.Visible = True
            End If
            If find1 = 2 Then
                picture10.Visible = True
            End If
            If find1 = 3 Then
                picture11.Visible = True
            End If
            If find1 = 4 Then
                picture12.Visible = True
            End If
        Loop

        Do While Val(TextBoxChangeOg.Text) >= 0.25
            findQ += 1
            TextBoxQ.Text = findQ
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 0.25
            If findQ = 1 Then
                picture13.Visible = True
            End If
            If findQ = 2 Then
                picture14.Visible = True
            End If
            If findQ = 3 Then
                picture15.Visible = True
            End If
        Loop

        Do While Val(TextBoxChangeOg.Text) >= 0.1
            findD += 1
            TextBoxD.Text = findD
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 0.1
            If findD = 1 Then
                picture16.Visible = True
            End If
            If findD = 2 Then
                picture17.Visible = True
            End If
        Loop

        Do While Val(TextBoxChangeOg.Text) >= 0.05
            findN += 1
            TextBoxN.Text = findN
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 0.05
            If findN = 1 Then
                picture18.Visible = True
            End If
        Loop

        Do While Val(TextBoxChangeOg.Text) < 0.05 And Val(TextBoxChangeOg.Text) > 0.01
            Math.Round(Val(TextBoxChangeOg.Text), 2)
            findP += 1
            TextBoxP.Text = findP
            TextBoxChangeOg.Text = Val(TextBoxChangeOg.Text) - 0.01
            If findP = 1 Then
                picture19.Visible = True
            End If
            If findP = 2 Then
                picture20.Visible = True
            End If
            If findP = 3 Then
                picture21.Visible = True
            End If
            If findP = 4 Then
                picture22.Visible = True
            End If
        Loop

        TextBoxChangeOg.Text = 0
    End Sub
End Class
