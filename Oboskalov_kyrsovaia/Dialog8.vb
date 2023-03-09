Imports System.Windows.Forms

Public Class Dialog8
	Public AddOrChangeDialog8 As Boolean
	Public OldRowIdDialog8 As ULong
	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Dim Rows() As DataRow
		Dim Rows2() As DataRow
		Dim OrganizationId As ULong
		Dim StudentId As ULong


		Rows = Form8.BaseDataSet.MEDICAL_ORGANIZATION.Select("name_organization='" & ComboBoxOrganization.Text & "'")
		If Rows.Length = 0 Then
			OrganizationId = Rows(0)("ID_organization")
		Else

			OrganizationId = Rows(0)("ID_organization")
		End If

		Rows2 = Form1.BaseDataSet.STUDENT.Select("FIO_student='" & ComboBoxStudentFIO.Text & "'")
		If Rows2.Length = 0 Then
			Form8.STUDENTTableAdapter.Insert(ComboBoxStudentFIO.Text, "", "", "", "", "")
			Form8.STUDENTTableAdapter.Fill(Form1.BaseDataSet.STUDENT)
			Rows2 = Form1.BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxStudentFIO.Text & "'")
			StudentId = Rows2(0)("ID_student")
		Else
			StudentId = Rows2(0)("ID_student")
		End If


		If AddOrChangeDialog8 = False Then
			Form8.PREVENTIVE_VACCINATIONSTableAdapter.Insert("Профилактические прививки", StudentId, OrganizationId, ComboBoxMedCards.Text, TextBoxPrivivka.Text, DateTimePicker1.Value)
		End If
		If AddOrChangeDialog8 = True Then
			Dim OldWorkerRow As DataRow = Form1.BaseDataSet.STUDENT.Select("ID_student='" & OldRowIdDialog8.ToString & "'")(0)
			Form8.PREVENTIVE_VACCINATIONSTableAdapter.Update("Профилактические прививки", StudentId, OrganizationId, ComboBoxMedCards.Text, TextBoxPrivivka.Text, DateTimePicker1.Value, OldWorkerRow(0), OldWorkerRow(1), OldWorkerRow(2), OldWorkerRow(3), OldWorkerRow(4), OldWorkerRow(5), OldWorkerRow(6))
			Form8.documentprofilacticprivivki()
		End If

		Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
