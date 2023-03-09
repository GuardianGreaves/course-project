Imports System.Windows.Forms

Public Class Dialog3
	Public AddOrChangeDialog3 As Boolean
	Public OldRowIdDialog3 As ULong

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		If AddOrChangeDialog3 = False Then
			Form3.MEDICAL_ORGANIZATIONTableAdapter.Insert(TextBoxNameOrganization.Text, TextBoxAdresOrganization.Text)
		End If
		If AddOrChangeDialog3 = True Then
			Dim OldWorkerRow2 As DataRow = Form1.BaseDataSet.MEDICAL_ORGANIZATION.Select("ID_organization='" & OldRowIdDialog3.ToString & "'")(0)
			Form3.MEDICAL_ORGANIZATIONTableAdapter.Update(TextBoxNameOrganization.Text, TextBoxAdresOrganization.Text, OldWorkerRow2(0), OldWorkerRow2(2))
			Form3.organization()
		End If

		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub TextBoxNameOrganization_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNameOrganization.TextChanged

	End Sub
End Class
