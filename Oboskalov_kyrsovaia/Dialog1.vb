Imports System.Windows.Forms

Public Class Dialog1
	Public AddOrChangeDialog1 As Boolean
	Public OldRowIdDialog1 As ULong
	Public A

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Dim Rows() As DataRow
		Dim GrupaID As ULong

		Rows = Form1.BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxGroup.Text & "'")
		If Rows.Length = 0 Then
			Form1.GRUPPATableAdapter.Insert("", "", ComboBoxGroup.Text)
			Form1.GRUPPATableAdapter.Fill(Form1.BaseDataSet.GRUPPA)
			Rows = Form1.BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxGroup.Text & "'")
			GrupaID = Rows(0)("ID_group")
		Else
			GrupaID = Rows(0)("ID_group")
		End If

		If AddOrChangeDialog1 = False Then
			Me.Label8.Text = ""
			Form1.STUDENTTableAdapter.Insert(TextBoxFIO.Text, GrupaID, DateTimePickerZachisleniye.Value.Date, DateTimePickerZachisleniye.Value.Date, TextBoxAddressStudent.Text, ComboBoxHostel.Text)
		End If
		If AddOrChangeDialog1 = True Then
			Dim OldWorkerRow As DataRow = Form1.BaseDataSet.STUDENT.Select("ID_student='" & OldRowIdDialog1.ToString & "'")(0)
			Form1.STUDENTTableAdapter.Update(TextBoxFIO.Text, GrupaID, DateTimePickerZachisleniye.Value.Date, DateTimePickerZachisleniye.Value.Date, TextBoxAddressStudent.Text, ComboBoxHostel.Text, OldWorkerRow(0), OldWorkerRow(1), OldWorkerRow(2), OldWorkerRow(3), OldWorkerRow(4), OldWorkerRow(5), OldWorkerRow(6))
			Form1.student()
		End If

		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
