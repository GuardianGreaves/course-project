Imports System.Windows.Forms

Public Class Dialog4
    Public AddOrChangeDialog3 As Boolean
    Public OldRowIdDialog3 As ULong

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Rows() As DataRow
        Dim StudentId As ULong
        Rows = Form1.BaseDataSet.STUDENT.Select("FIO_student='" & ComboBoxStudent.Text & "'")
        If Rows.Length = 0 Then
            Form1.STUDENTTableAdapter.Insert(ComboBoxStudent.Text, "", "", "", "", "")
            Form1.STUDENTTableAdapter.Fill(Form1.BaseDataSet.STUDENT)
            Rows = Form1.BaseDataSet.STUDENT.Select("FIO_student='" & ComboBoxStudent.Text & "'")
            StudentId = Rows(0)("ID_student")
        Else
            StudentId = Rows(0)("ID_student")
        End If

        If AddOrChangeDialog3 = False Then
            Form4.MEDICAL_CARDTableAdapter.Insert(StudentId)
        End If
        If AddOrChangeDialog3 = True Then
            Dim OldWorkerRow2 As DataRow = Form1.BaseDataSet.MEDICAL_ORGANIZATION.Select("ID_organization='" & OldRowIdDialog3.ToString & "'")(0)
            Form4.MEDICAL_CARDTableAdapter.Update(StudentId, OldWorkerRow2(0), OldWorkerRow2(1))
            Form4.medcard()
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
