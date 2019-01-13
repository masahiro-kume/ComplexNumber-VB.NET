Option Explicit On
Option Strict On

Imports SampleA.PsiMath
Imports SampleA.PsiMath.Complex


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ''2 ^ 0
        'MessageBox.Show((2 ^ 0).ToString)
        'MessageBox.Show((New Complex(2, 0) ^ 0).ToString)
        'MessageBox.Show((2 ^ New Complex(0, 0)).ToString)
        'MessageBox.Show(((New Complex(2, 0) ^ New Complex(0, 0))).ToString)
        ''0 ^ 2
        'MessageBox.Show((0 ^ 2).ToString)
        'MessageBox.Show((New Complex(0, 0) ^ 2).ToString)
        'MessageBox.Show((0 ^ New Complex(2, 0)).ToString)
        'MessageBox.Show(((New Complex(0, 0) ^ New Complex(2, 0))).ToString)
        ''0 ^ 0
        'MessageBox.Show((0 ^ 0).ToString)
        'MessageBox.Show((New Complex(0, 0) ^ 0).ToString)
        'MessageBox.Show((0 ^ New Complex(0, 0)).ToString)
        'MessageBox.Show(((New Complex(0, 0) ^ New Complex(0, 0))).ToString)

        '' Calc Results are different from System.Numerics.Complex
        '' https://docs.microsoft.com/ja-jp/dotnet/api/system.numerics.complex
        'Dim c1 As Complex = New Complex(Double.MaxValue / 2, Double.MaxValue / 2)
        'Dim c2 As Complex = c1 / New Complex(0, 0)
        'MessageBox.Show(c2.ToString)
        'c2 = c2 * New Complex(1.5, 1.5)
        'MessageBox.Show(c2.ToString)
        'Dim c3 As Complex = c1 * New Complex(2.5, 3.5)
        'MessageBox.Show(c3.ToString)
        'c3 = c3 + New Complex(Double.MinValue / 2, Double.MaxValue / 2)
        'MessageBox.Show(c3.ToString)



        '-1の平方根
        MessageBox.Show("SQRT(-1):  " & Sqrt(-1).ToString)
        'eのiπ乗
        MessageBox.Show("e^(i*pi):  " & Exp(Sqrt(-1) * Math.PI).ToString)

        ' n乗根をListでゲットする
        Dim myList As List(Of Complex)
        Dim myAns As String
        Dim ans As Complex
        Dim base As Double = 256
        For n As Integer = 1 To 8
            myList = Complex.nthRoot(New Complex(base, 0), n)
            myAns = String.Format("{0}の{1}乗根:  ", base, n) & vbNewLine
            For Each ans In myList
                myAns &= vbTab & ans.ToString & vbNewLine
            Next
            myList.Clear()
            MessageBox.Show(myAns)
        Next

        'overloadの実験
        Dim i As Complex = Sqrt(-4)
        Dim r As Complex = Sqrt(4)
        r += i               '2 + 2(i)
        MessageBox.Show("SQRT(4) + SQRT(-4) :  " & r.ToString)
        r = r * 2 - i * 15   '4 - 26(i)
        MessageBox.Show("(SQRT(4) + SQRT(-4)) * 2 - SQRT(-4) * 15 :  " & r.ToString)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim a As Double = CDbl(tbxA.Text)
            Dim b As Double = CDbl(tbxB.Text)
            Dim c As Double = CDbl(tbxC.Text)

            Dim Hanbetsu As Double = b ^ 2 - 4 * a * c
            tbxHanbetsu.Text = Hanbetsu.ToString

            Dim ans1 As Complex = (-b + Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            Dim ans2 As Complex = (-b - Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            tbxAns1.Text = ans1.ToString
            tbxAns2.Text = ans2.ToString
        Catch ex As Exception

        End Try

    End Sub
End Class
