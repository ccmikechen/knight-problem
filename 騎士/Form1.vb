Imports System.IO
Public Class Form1
    Dim n As Integer
    Dim ans As String
    Dim sw As New StreamWriter("out.txt")
    Sub start(ByVal x As Integer, ByVal y As Integer, ByVal p(,) As Integer, ByVal r As Integer)
        If p(x, y) = 0 Then
            p(x, y) = r

            r += 1
            If r > n * n Then
                For i = 1 To n
                    For j = 1 To n
                        ans &= p(i, j) & vbTab
                    Next
                    ans &= vbCrLf
                Next
                sw.WriteLine(ans) : sw.Flush() : End
            End If
            If x + 2 <= n And y + 1 <= n Then start(x + 2, y + 1, p, r)
            If x + 1 <= n And y + 2 <= n Then start(x + 1, y + 2, p, r)
            If x - 1 >= 1 And y + 2 <= n Then start(x - 1, y + 2, p, r)
            If x - 2 >= 1 And y + 1 <= n Then start(x - 2, y + 1, p, r)
            If x - 2 >= 1 And y - 1 >= 1 Then start(x - 2, y - 1, p, r)
            If x - 1 >= 1 And y - 2 >= 1 Then start(x - 1, y - 2, p, r)
            If x + 1 <= n And y - 2 >= 1 Then start(x + 1, y - 2, p, r)
            If x + 2 <= n And y - 1 >= 1 Then start(x + 2, y - 1, p, r)
            p(x, y) = 0
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New StreamReader("in.txt")
        n = sr.ReadLine
        Dim cb(n, n) As Integer
        start(1, 1, cb, 1)
    End Sub
End Class
