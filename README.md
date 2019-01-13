# VB.NET で複素数を扱うクラス

[comment]: # ()

## このサンプルについて
### 言語
- VB.NET 最終確認は2017
- 対応Framework: 3.x以降
### コンテンツ
- 複素数の計算用クラス
- MethodやOperaterのオーバーライド、オーバーロードのサンプル
- 詳しくは「いきさつ」参照
### いきさつ
古いソースを整理していて出てきました  
.NET Framework 3.xの頃使っていたクラスです。当時はVSで複素数を扱うのが面倒だったのでつくりました。  
現状（4.0以降）では、[System.Numerics.Complex](https://docs.microsoft.com/ja-jp/dotnet/api/system.numerics.complex)があるので、実用的にはそちらを使うほうがお勧めですが、3.xで必要な場合や
以下のサンプルコードのように単純な式で複素数を使いたい場合、オペレータやメソッドをオーバーロード、オーバーライドするときの参考などにお使いください。  
n乗根の関数(nthRoot)もあります：（意外と便利）  
有効数字は検定してません。多少誤差ありでお使いください。
### Code Sample
```
    Imports SampleA.PsiMath
    Imports SampleA.PsiMath.Complex

    Sub Main()
        Dim a As Double = 1.0
        Dim b As Double = 2.0
        Dim c As Double = 3.0
        Dim ans1 As Complex = (-b + Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
        Dim ans2 As Complex = (-b - Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
        ' ans1 = (-1, 1.4142135623731)
        ' ans2 = (-1, -1.4142135623731)
        
        ' 256の8乗根： Listに8個の答えが返ってきます
        Dim myList As List(Of Complex) = Complex.nthRoot(New Complex(256, 0), 8)
        Dim ans As Complex
        For Each ans In myList
            Console.Writeline(ans.ToString)
        Next
    End Sub
```

