Imports System.Windows.Forms

Public Class Dialog5
	Public AddOrChangeDialog5 As Boolean
	Public OldRowIdDialog5 As ULong
	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Dim Rows() As DataRow
		Dim Rows2() As DataRow
		Dim GrupaId As ULong
		Dim StudentId As ULong


		Rows = Form1.BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxGruppa.Text & "'")
		If Rows.Length = 0 Then
			Form5.GRUPPATableAdapter.Insert("", "", ComboBoxGruppa.Text)
			Form5.GRUPPATableAdapter.Fill(Form1.BaseDataSet.GRUPPA)
			Rows = Form1.BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxGruppa.Text & "'")
			GrupaID = Rows(0)("ID_group")
		Else
			GrupaID = Rows(0)("ID_group")
		End If

		Rows2 = Form1.BaseDataSet.STUDENT.Select("FIO_student='" & ComboBoxStudentFIO.Text & "'")
		If Rows2.Length = 0 Then
			Form5.STUDENTTableAdapter.Insert(ComboBoxStudentFIO.Text, "", "", "", "", "")
			Form5.STUDENTTableAdapter.Fill(Form1.BaseDataSet.STUDENT)
			Rows2 = Form1.BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxStudentFIO.Text & "'")
			StudentId = Rows2(0)("ID_student")
		Else
			StudentId = Rows2(0)("ID_student")
		End If

		If AddOrChangeDialog5 = False Then
			Form5.RESPONIBLE_FOR_PASSESTableAdapter.Insert(StudentId, GrupaId)
		End If
		If AddOrChangeDialog5 = True Then
			Dim OldWorkerRow As DataRow = Form1.BaseDataSet.STUDENT.Select("ID_student='" & OldRowIdDialog5.ToString & "'")(0)
			Form5.RESPONIBLE_FOR_PASSESTableAdapter.Update(StudentId, GrupaId, OldWorkerRow(0), OldWorkerRow(1))
			Form5.studpropysci()
		End If

		Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStudentFIO.SelectedIndexChanged

    End Sub

	Private Sub Dialog5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
