Public Class ISCalculator

    ' We declare some of the variables. Arrays are fixed in this case
    'but you can ask the user to enter a value for it if you want

    Public num1 As Integer() = New Integer(15) {}
    Public num2 As Integer() = New Integer(15) {}
    Public cont As Integer = 0
    Public result As Integer
    Public sum As Integer = 0
    Public a, b As String



    ' We start setting up our buttons

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        For cont As Integer = 0 To 14


            ' This show the row's number where we are inserting data

            labiterator.Text = (cont + 1)

            ' Here we do 2 types of input texts. One for Quantity and the other for Price. This will be repeating until user decides to cancel it.
            ' You can create a loop to validate the input as well but this is a simple practice

            a = InputBox("Insert Quantity", "Insert Data", "")

            If a = "" Then
                Exit For
            ElseIf a = " " Then
                Exit For
            End If

            b = InputBox("Insert Price", "Insert Data", "")


            If b = "" Then
                Exit For
            ElseIf b = " " Then
                Exit For
            End If


            ' After the inputs, we parse a and b into Integer because we are making an iterative sum

            num1(cont) = Integer.Parse(a)
            num2(cont) = Integer.Parse(b)

            result = num1(cont) * num2(cont)

            sum += result

            ' Then we turn the iterative sum into a string to display it on the textbox
            tbResult.Text = sum.ToString


        Next


    End Sub


    ' Here we just display both arrays on a DataGridView

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        For i As Integer = 0 To num1.GetUpperBound(0)
            DataGridView1.Rows.Add((i + 1), num1(i), num2(i))
        Next


    End Sub

    ' This button just takes care of a set of values. A clean up per say
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClean.Click

        tbResult.Clear()
        DataGridView1.Rows.Clear()
        Array.Clear(num1, 0, num1.Length)
        Array.Clear(num2, 0, num2.Length)
        DataGridView1.Refresh()
        sum = 0

    End Sub

End Class
