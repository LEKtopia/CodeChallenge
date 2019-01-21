Public Class FrmMain

    Dim genRandom As New Random()

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        'lblDispLow = genRandom.Next(1, 21)
        'lblDispMed = genRandom.Next(1, 21)
        'lblDispHigh = genRandom.Next(1, 21)

        Dim randomArray As Integer() = New Integer() {genRandom.Next(1, 21), genRandom.Next(1, 21), genRandom.Next(1, 21)}
        System.Array.Sort(randomArray)

        lblDispLow.Text = randomArray(0).ToString
        lblDispMed.Text = randomArray(1).ToString
        lblDispHigh.Text = randomArray(2).ToString

    End Sub

End Class
