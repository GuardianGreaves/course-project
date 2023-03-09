Imports System.Windows.Forms

Public Class Dialog2
    Public AddOrChange2 As Boolean
    Public OldRowID2 As ULong

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If AddOrChange2 = False Then
            Form1.GRUPPATableAdapter.Insert(DateTimePicker1.Value, TextBox2.Text, TextBox1.Text)
        End If
        If AddOrChange2 = True Then
            Dim OldWorkerRow As DataRow = Form1.BaseDataSet.STUDENT.Select("ID_student='" & OldRowID2.ToString & "'")(0)
            Form1.GRUPPATableAdapter.Update(DateTimePicker1.Value, TextBox2.Text, TextBox1.Text, OldWorkerRow(0), OldWorkerRow(1), OldWorkerRow(2), OldWorkerRow(3))
            Form1.student()
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
