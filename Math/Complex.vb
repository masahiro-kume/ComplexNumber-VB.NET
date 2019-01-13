Option Explicit On
Option Strict On

Imports System.Math
Imports System

Namespace PsiMath

    Public Class Complex
        Private dblReal As Double
        Private dblImaginary As Double

        Public Property Real() As Double
            Get
                Return dblReal
            End Get
            Set(ByVal value As Double)
                dblReal = value
            End Set
        End Property

        Public Property Imaginary() As Double
            Get
                Return dblImaginary
            End Get
            Set(ByVal value As Double)
                dblImaginary = value
            End Set
        End Property

        Public Sub New(ByVal Real As Double, ByVal Imaginary As Double)
            dblReal = Real
            dblImaginary = Imaginary
        End Sub

        Public Sub New()
            dblReal = 0
            dblImaginary = 0
        End Sub

        Public Sub New(ByVal Radius As Double, ByVal Radian As Double, ByVal Poler As Boolean)
            If Poler Then
                dblReal = Radius * Math.Cos(Radian)
                dblImaginary = Radius * Math.Sin(Radian)
            Else
                dblReal = 0
                dblImaginary = 0
            End If
        End Sub

        Public ReadOnly Property Radius() As Double
            Get
                Return Math.Sqrt(dblReal ^ 2 + dblImaginary ^ 2)
            End Get
        End Property

        Public ReadOnly Property Angle() As Double
            Get
                Return Math.Atan(dblImaginary / dblReal)
            End Get
        End Property

        Public Overrides Function ToString() As String
            ''''   Real [+-] Imag(i) Style (Original of This class in FW3.x)
            'Dim strSign As String = "+"
            'If dblImaginary < 0 Then strSign = "-"
            'Return String.Format("{0} {1} {2}(i)", dblReal.ToString, strSign, Math.Abs(dblImaginary).ToString)

            ''''  Miscosoft System.Numeric.Complex Style (FW4.x or later)
            Return String.Format("({0}, {1})", dblReal.ToString, dblImaginary.ToString)
        End Function


        Public Shared Operator =(ByVal x As Complex, ByVal y As Complex) As Boolean
            If x.Real = y.Real And x.Imaginary = y.Imaginary Then
                Return True
            Else
                Return False
            End If
        End Operator

        Public Shared Operator <>(ByVal x As Complex, ByVal y As Complex) As Boolean
            Return Not (x = y)
        End Operator

        Public Shared Operator -(ByVal x As Complex) As Complex
            Return New Complex(-x.Real, -x.Imaginary)
        End Operator

        Public Shared Operator +(ByVal x As Complex, ByVal y As Complex) As Complex
            Return New Complex(x.Real + y.Real, x.Imaginary + y.Imaginary)
        End Operator

        Public Shared Operator +(ByVal x As Double, ByVal y As Complex) As Complex
            Return New Complex(x + y.Real, y.Imaginary)
        End Operator

        Public Shared Operator +(ByVal x As Complex, ByVal y As Double) As Complex
            Return New Complex(x.Real + y, x.Imaginary)
        End Operator

        Public Shared Operator -(ByVal x As Complex, ByVal y As Complex) As Complex
            Return New Complex(x.Real - y.Real, x.Imaginary - y.Imaginary)
        End Operator

        Public Shared Operator -(ByVal x As Double, ByVal y As Complex) As Complex
            Return New Complex(x - y.Real, -y.Imaginary)
        End Operator

        Public Shared Operator -(ByVal x As Complex, ByVal y As Double) As Complex
            Return New Complex(x.Real - y, x.Imaginary)
        End Operator

        Public Shared Operator *(ByVal x As Complex, ByVal y As Complex) As Complex
            Return New Complex(x.Real * y.Real - x.Imaginary * y.Imaginary, x.Imaginary * y.Real + x.Real * y.Imaginary)
        End Operator

        Public Shared Operator *(ByVal x As Double, ByVal y As Complex) As Complex
            Return New Complex(x * y.Real, x * y.Imaginary)
        End Operator

        Public Shared Operator *(ByVal x As Complex, ByVal y As Double) As Complex
            Return New Complex(x.Real * y, x.Imaginary * y)
        End Operator

        Public Shared Operator /(ByVal x As Complex, ByVal y As Complex) As Complex
            If y.Imaginary = 0 Then
                Return x / y.Real
            Else
                Dim dblDenominator As Double = y.Real ^ 2 + y.Imaginary ^ 2
                Return New Complex((x.Real * y.Real + x.Imaginary * y.Imaginary) / dblDenominator, (x.Imaginary * y.Real - x.Real * y.Imaginary) / dblDenominator)
            End If
        End Operator

        Public Shared Operator /(ByVal x As Complex, ByVal y As Double) As Complex
            Return New Complex(x.Real / y, x.Imaginary / y)
        End Operator

        Public Shared Operator /(ByVal x As Double, ByVal y As Complex) As Complex
            If y.Imaginary = 0 Then
                Return New Complex(x / y.Real, 0)
            Else
                Dim dblDenominator As Double = y.Real ^ 2 + y.Imaginary ^ 2
                Return New Complex(x * y.Real / dblDenominator, -x * y.Imaginary / dblDenominator)
            End If
        End Operator

        Public Shared Operator ^(ByVal x As Complex, ByVal y As Double) As Complex
            If x.Imaginary = 0 Then
                Return New Complex(x.Real ^ y, 0)
            ElseIf Abs(x) > 0 And y = 0 Then
                Return New Complex(1, 0)
            Else
                Dim r As Double = x.Radius
                Dim t As Double = x.Angle
                Return New Complex(r ^ y * Math.Cos(y * t), r ^ y * Math.Sin(y * t))
            End If
        End Operator

        Public Shared Operator ^(ByVal x As Double, ByVal y As Complex) As Complex
            If y.Imaginary = 0 Then
                Return New Complex(x ^ y.Real, 0)
            Else
                Dim C As Double = x ^ y.Real
                Return New Complex(C * Cos(y.Imaginary * Log(x)), C * Sin(y.Imaginary * Log(x)))
            End If
        End Operator

        Public Shared Operator ^(ByVal x As Complex, ByVal y As Complex) As Complex
            If y.Imaginary = 0 Then
                Return x ^ y.Real
            Else
                Dim C As Double = x.Radius ^ y.Real * Math.Exp(-y.Imaginary * x.Angle)
                Return New Complex(C * Cos(y.Imaginary * Log(x.Radius) + y.Real * x.Angle), C * Sin(y.Imaginary * Log(x.Radius) + y.Real * x.Angle))
            End If
        End Operator


        Public Overloads Shared Function Exp(ByVal x As Complex) As Complex
            Dim C As Double = Math.Exp(x.Real)
            Return New Complex(C * Cos(x.Imaginary), C * Sin(x.Imaginary))
        End Function

        Public Overloads Shared Function Abs(ByVal x As Complex) As Double
            Return Math.Sqrt(x.Real ^ 2 + x.Imaginary ^ 2)
        End Function

        Public Overloads Shared Function Sqrt(ByVal x As Double) As Complex
            Dim rv As New Complex
            If x >= 0 Then
                rv.Real = Math.Sqrt(x)
            Else
                rv.Imaginary = Math.Sqrt(-x)
            End If
            Return rv
        End Function

        Public Shared Function nthRoot(ByVal x As Complex, ByVal n As Integer) As List(Of Complex)
            Dim lstReturn As New List(Of Complex)
            Dim i = Sqrt(-1)
            Dim C As Double = x.Radius ^ (1 / n)
            For k As Integer = 0 To n - 1
                lstReturn.Add(C * Exp((x.Angle + 2 * k * PI) * i / n))
            Next
            Return lstReturn
        End Function

    End Class



End Namespace


