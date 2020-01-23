Imports System.Linq
Imports System.Text
Public Class Form1
    Private Sub cmdCheckSingleAddress_Click(sender As Object, e As EventArgs) Handles cmdCheckSingleAddress.Click
        Dim st = New SmartyStreets.SmartyStreets()
        'Dim res = st.CheckAddress("11155 Roseland Road", "Sebastian", "FL", "32950")
        Dim res As Boolean
        Dim msg As String
        Dim result_msg As StringBuilder = New StringBuilder()


        res = st.CheckAddress(txtStreet.Text, txtCity.Text, txtState.Text, txtZip.Text)
        If res = True Then
            result_msg.Clear()
            result_msg.Append("Address = " + st.Delivery_Address1 + vbCrLf)
            result_msg.Append("Address 2 = " + st.Delivery_Address2 + vbCrLf)
            result_msg.Append("City = " + st.City + vbCrLf)
            result_msg.Append("State = " + st.State + vbCrLf)
            result_msg.Append("Zip Code: " + st.ZipPlus4 + vbCrLf)
            RichTextBox1.Text = result_msg.ToString

            msg = st.ReturnMessage
            msg.Replace("\", vbCrLf)
            MessageBox.Show(msg, "Success!")
        Else
            msg = st.ReturnMessage
            msg.Replace("\", vbCrLf)
            MessageBox.Show(msg, "ERROR!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        RichTextBox1.Paste()

    End Sub

    Private Sub CopyToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem2.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub ContextMenuStrip3_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr() As String
        Dim i, kd_length As Integer
        arr = Split(RichTextBox1.Text, vbLf)
        kd_length = arr.Length
        For i = 0 To UBound(arr)
            MsgBox(arr(i))
        Next
    End Sub
End Class
