Public Class Form1
    Dim Random1 As Integer
    Dim Change As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartTimer.Start()
        SwapTimer.Start()
        StopTimer.Start()
        TimeLabel.Text = "0"
        Change = False
        CountLabel.Text = "0"
    End Sub
    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        Dim random As Random
        random = New Random
        Random1 = random.Next(1, 61)
        TextBox1.Text = Random1.ToString
        If Random1 = 1 Then
            PictureBox1.Image = My.Resources.imagesM12VYAS6
            Change = True
        Else : PictureBox1.Image = My.Resources.images
        End If
        If Random1 = 2 Then
            PictureBox2.Image = My.Resources.imagesM12VYAS6
            Change = True
        Else : PictureBox2.Image = My.Resources.images
        End If
        If Random1 = 3 Then
            PictureBox3.Image = My.Resources.imagesM12VYAS6
            Change = True
        Else : PictureBox3.Image = My.Resources.images
        End If
        If Random1 = 4 Then
            PictureBox4.Image = My.Resources.imagesM12VYAS6
            Change = True
        Else : PictureBox4.Image = My.Resources.images
        End If
        If Random1 = 5 Then
            Change = True
            PictureBox5.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox5.Image = My.Resources.images
        End If
        If Random1 = 6 Then
            Change = True
            PictureBox6.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox6.Image = My.Resources.images
        End If
        If Random1 = 9 Then
            Change = True
            PictureBox9.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox9.Image = My.Resources.images
        End If
        If Random1 = 8 Then
            Change = True
            PictureBox8.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox8.Image = My.Resources.images
        End If
        If Random1 = 7 Then
            Change = True
            PictureBox7.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox7.Image = My.Resources.images
        End If
        If Random1 = 10 Then
            Change = True
            PictureBox10.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox10.Image = My.Resources.images
        End If
        If Random1 = 11 Then
            Change = True
            PictureBox11.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox11.Image = My.Resources.images
        End If
        If Random1 = 12 Then
            Change = True
            PictureBox12.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox12.Image = My.Resources.images
        End If
        If Random1 = 13 Then
            Change = True
            PictureBox13.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox13.Image = My.Resources.images
        End If
        If Random1 = 14 Then
            Change = True
            PictureBox14.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox14.Image = My.Resources.images
        End If
        If Random1 = 15 Then
            Change = True
            PictureBox15.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox15.Image = My.Resources.images
        End If
        If Random1 = 16 Then
            Change = True
            PictureBox16.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox16.Image = My.Resources.images
        End If
        If Random1 = 17 Then
            Change = True
            PictureBox17.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox17.Image = My.Resources.images
        End If
        If Random1 = 18 Then
            Change = True
            PictureBox18.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox18.Image = My.Resources.images
        End If
        If Random1 = 19 Then
            Change = True
            PictureBox19.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox19.Image = My.Resources.images
        End If
        If Random1 = 20 Then
            Change = True
            PictureBox20.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox20.Image = My.Resources.images
        End If
        If Random1 = 21 Then
            Change = True
            PictureBox21.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox21.Image = My.Resources.images
        End If
        If Random1 = 22 Then
            Change = True
            PictureBox22.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox22.Image = My.Resources.images
        End If
        If Random1 = 23 Then
            Change = True
            PictureBox23.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox23.Image = My.Resources.images
        End If
        If Random1 = 24 Then
            Change = True
            PictureBox24.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox24.Image = My.Resources.images
        End If
        If Random1 = 25 Then
            Change = True
            PictureBox25.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox25.Image = My.Resources.images
        End If
        If Random1 = 26 Then
            Change = True
            PictureBox26.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox26.Image = My.Resources.images
        End If
        If Random1 = 27 Then
            Change = True
            PictureBox27.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox27.Image = My.Resources.images
        End If
        If Random1 = 28 Then
            Change = True
            PictureBox28.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox28.Image = My.Resources.images
        End If
        If Random1 = 29 Then
            Change = True
            PictureBox29.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox29.Image = My.Resources.images
        End If
        If Random1 = 30 Then
            Change = True
            PictureBox30.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox30.Image = My.Resources.images
        End If
        If Random1 = 31 Then
            Change = True
            PictureBox31.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox31.Image = My.Resources.images
        End If
        If Random1 = 32 Then
            Change = True
            PictureBox32.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox32.Image = My.Resources.images
        End If
        If Random1 = 33 Then
            Change = True
            PictureBox33.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox33.Image = My.Resources.images
        End If
        If Random1 = 34 Then
            Change = True
            PictureBox34.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox34.Image = My.Resources.images
        End If
        If Random1 = 35 Then
            Change = True
            PictureBox35.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox35.Image = My.Resources.images
        End If
        If Random1 = 36 Then
            Change = True
            PictureBox36.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox36.Image = My.Resources.images
        End If
        If Random1 = 37 Then
            Change = True
            PictureBox37.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox37.Image = My.Resources.images
        End If
        If Random1 = 38 Then
            Change = True
            PictureBox38.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox38.Image = My.Resources.images
        End If
        If Random1 = 39 Then
            Change = True
            PictureBox39.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox39.Image = My.Resources.images
        End If
        If Random1 = 40 Then
            Change = True
            PictureBox40.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox40.Image = My.Resources.images
        End If
        If Random1 = 41 Then
            Change = True
            PictureBox41.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox41.Image = My.Resources.images
        End If
        If Random1 = 42 Then
            Change = True
            PictureBox42.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox42.Image = My.Resources.images
        End If
        If Random1 = 43 Then
            Change = True
            PictureBox43.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox43.Image = My.Resources.images
        End If
        If Random1 = 44 Then
            Change = True
            PictureBox44.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox44.Image = My.Resources.images
        End If
        If Random1 = 45 Then
            Change = True
            PictureBox45.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox45.Image = My.Resources.images
        End If
        If Random1 = 46 Then
            Change = True
            PictureBox46.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox46.Image = My.Resources.images
        End If
        If Random1 = 47 Then
            Change = True
            PictureBox47.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox47.Image = My.Resources.images
        End If
        If Random1 = 48 Then
            Change = True
            PictureBox48.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox48.Image = My.Resources.images
        End If
        If Random1 = 49 Then
            Change = True
            PictureBox49.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox49.Image = My.Resources.images
        End If
        If Random1 = 50 Then
            Change = True
            PictureBox50.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox50.Image = My.Resources.images
        End If
        If Random1 = 51 Then
            Change = True
            PictureBox51.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox51.Image = My.Resources.images
        End If
        If Random1 = 52 Then
            Change = True
            PictureBox52.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox52.Image = My.Resources.images
        End If
        If Random1 = 53 Then
            Change = True
            PictureBox53.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox53.Image = My.Resources.images
        End If
        If Random1 = 54 Then
            Change = True
            PictureBox54.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox54.Image = My.Resources.images
        End If
        If Random1 = 55 Then
            Change = True
            PictureBox55.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox55.Image = My.Resources.images
        End If
        If Random1 = 56 Then
            Change = True
            PictureBox56.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox56.Image = My.Resources.images
        End If
        If Random1 = 57 Then
            Change = True
            PictureBox57.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox57.Image = My.Resources.images
        End If
        If Random1 = 58 Then
            Change = True
            PictureBox58.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox58.Image = My.Resources.images
        End If
        If Random1 = 59 Then
            Change = True
            PictureBox59.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox59.Image = My.Resources.images
        End If
        If Random1 = 60 Then
            Change = True
            PictureBox60.Image = My.Resources.imagesM12VYAS6
        Else : PictureBox60.Image = My.Resources.images
        End If
    End Sub
    Private Sub StopTimer_Tick(sender As Object, e As EventArgs) Handles StopTimer.Tick
        TimeLabel.Text += 1
        If TimeLabel.Text = 30 Then
            SwapTimer.Stop()
            StartTimer.Stop()
            StopTimer.Stop()
            PictureBox60.Image = My.Resources.images
            PictureBox59.Image = My.Resources.images
            PictureBox58.Image = My.Resources.images
            PictureBox57.Image = My.Resources.images
            PictureBox56.Image = My.Resources.images
            PictureBox55.Image = My.Resources.images
            PictureBox54.Image = My.Resources.images
            PictureBox53.Image = My.Resources.images
            PictureBox52.Image = My.Resources.images
            PictureBox51.Image = My.Resources.images
            PictureBox50.Image = My.Resources.images
            PictureBox49.Image = My.Resources.images
            PictureBox48.Image = My.Resources.images
            PictureBox47.Image = My.Resources.images
            PictureBox46.Image = My.Resources.images
            PictureBox45.Image = My.Resources.images
            PictureBox44.Image = My.Resources.images
            PictureBox43.Image = My.Resources.images
            PictureBox42.Image = My.Resources.images
            PictureBox41.Image = My.Resources.images
            PictureBox40.Image = My.Resources.images
            PictureBox39.Image = My.Resources.images
            PictureBox38.Image = My.Resources.images
            PictureBox37.Image = My.Resources.images
            PictureBox36.Image = My.Resources.images
            PictureBox35.Image = My.Resources.images
            PictureBox34.Image = My.Resources.images
            PictureBox33.Image = My.Resources.images
            PictureBox32.Image = My.Resources.images
            PictureBox31.Image = My.Resources.images
            PictureBox30.Image = My.Resources.images
            PictureBox29.Image = My.Resources.images
            PictureBox28.Image = My.Resources.images
            PictureBox27.Image = My.Resources.images
            PictureBox26.Image = My.Resources.images
            PictureBox25.Image = My.Resources.images
            PictureBox24.Image = My.Resources.images
            PictureBox23.Image = My.Resources.images
            PictureBox22.Image = My.Resources.images
            PictureBox21.Image = My.Resources.images
            PictureBox20.Image = My.Resources.images
            PictureBox19.Image = My.Resources.images
            PictureBox18.Image = My.Resources.images
            PictureBox17.Image = My.Resources.images
            PictureBox16.Image = My.Resources.images
            PictureBox15.Image = My.Resources.images
            PictureBox14.Image = My.Resources.images
            PictureBox13.Image = My.Resources.images
            PictureBox12.Image = My.Resources.images
            PictureBox11.Image = My.Resources.images
            PictureBox10.Image = My.Resources.images
            PictureBox9.Image = My.Resources.images
            PictureBox8.Image = My.Resources.images
            PictureBox7.Image = My.Resources.images
            PictureBox6.Image = My.Resources.images
            PictureBox5.Image = My.Resources.images
            PictureBox4.Image = My.Resources.images
            PictureBox3.Image = My.Resources.images
            PictureBox2.Image = My.Resources.images
            PictureBox1.Image = My.Resources.images
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Random1 = 1 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If Random1 = 9 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub
    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Random1 = 3 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If Random1 = 8 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Random1 = 7 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Random1 = 6 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Random1 = 5 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Random1 = 4 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Random1 = 2 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If Random1 = 10 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If Random1 = 20 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If Random1 = 12 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If Random1 = 13 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If Random1 = 14 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If Random1 = 15 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If Random1 = 16 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If Random1 = 17 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If Random1 = 18 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If Random1 = 19 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If Random1 = 11 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        If Random1 = 30 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If Random1 = 22 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        If Random1 = 23 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        If Random1 = 24 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If Random1 = 25 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        If Random1 = 26 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        If Random1 = 27 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        If Random1 = 28 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        If Random1 = 29 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If Random1 = 21 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        If Random1 = 40 Then
            CountLabel.Text += 1
            Change = False
        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        If Random1 = 32 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        If Random1 = 33 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        If Random1 = 34 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        If Random1 = 35 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        If Random1 = 36 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        If Random1 = 37 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        If Random1 = 38 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        If Random1 = 39 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        If Random1 = 31 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        If Random1 = 50 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        If Random1 = 42 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        If Random1 = 43 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        If Random1 = 44 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        If Random1 = 45 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        If Random1 = 46 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        If Random1 = 47 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        If Random1 = 48 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        If Random1 = 49 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        If Random1 = 41 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        If Random1 = 60 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        If Random1 = 52 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        If Random1 = 53 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        If Random1 = 54 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        If Random1 = 55 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        If Random1 = 56 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click
        If Random1 = 57 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click
        If Random1 = 58 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        If Random1 = 59 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        If Random1 = 51 Then
            Change = False
            CountLabel.Text += 1
        End If
    End Sub
    Private Sub SwapTimer_Tick(sender As Object, e As EventArgs) Handles SwapTimer.Tick
        If Change = True Then
            StartTimer.Stop()
        Else : StartTimer.Start()
        End If
    End Sub
End Class
