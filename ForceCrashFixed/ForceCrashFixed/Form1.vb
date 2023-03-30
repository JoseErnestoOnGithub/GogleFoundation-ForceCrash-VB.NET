Public Class Form1
    Dim zero As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Console.WriteLine(1 \ zero)
        Catch ex As Exception
            Console.WriteLine("Unhandled exception: " + ex.Message)
            Console.WriteLine(ex.StackTrace)


            Dim ErrMsg = MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.StackTrace, "Uncaught exception was thrown", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If ErrMsg = DialogResult.OK Then
                Process.GetCurrentProcess.Kill()

            End If

        End Try
    End Sub
End Class
