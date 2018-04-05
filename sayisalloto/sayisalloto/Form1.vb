Public Class Form1

    Private Sub OynaButon_Click(sender As Object, e As EventArgs) Handles OynaButon.Click

        Dim sayilar(5) As Object

        Dim rast As New Random

        sayilar(0) = rast.Next(1, 50) '1 ile 49 arası sayılar üretmek için kullanır  
        For i = 1 To sayilar.Count - 1
            Dim sayi As Object
            Do
                sayi = rast.Next(1, 50)

            Loop While sayilar.Contains(sayi) ' Loop Until sayilar.Contains(sayi)'
            sayilar(i) = sayi

        Next
        Array.Sort(sayilar)
        sayilarlistbox.Items.Clear()
        sayilarlistbox.Items.AddRange(sayilar)

        










    End Sub
End Class
