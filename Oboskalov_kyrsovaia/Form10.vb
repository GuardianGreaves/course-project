Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter.Fill(Me.BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Fill(Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION)
        'docprivivkibeforeafter()

    End Sub

    Private Sub EXAMINATION_BEFORE_AFTER_VACCINATIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseDataSet)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Update(Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION)
        Me.Validate()
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource.EndEdit()
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Update(Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION)
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Fill(Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION)
    End Sub




    'Private Sub docprivivkibeforeafter()
    '    Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
    '    Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Fill(Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION)

    '    ListViewDocVaccination.Items.Clear()
    '    Dim items(10) As String
    '    Dim TempRow As DataRow
    '    For Each Row As DataRow In
    '            Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION.Rows
    '        TempRow = Row.GetParentRow("STUDENTEXAMINATION_BEFORE_AFTER_VACCINATION")
    '        items(1) = TempRow(1)
    '        TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONEXAMINATION_BEFORE_AFTER_VACCINATION")
    '        items(2) = TempRow(0)
    '        items(3) = Row(4)
    '        items(4) = Row(5)
    '        items(5) = Row(6)
    '        items(6) = Row(7)
    '        items(7) = Row(8)
    '        items(8) = Row(9)
    '        items(9) = Row(10)
    '        Dim it As New ListViewItem()
    '        it.Text = Row(1)
    '        it.SubItems.AddRange(items)
    '        ListViewDocVaccination.Items.Add(it)
    '    Next Row
    'End Sub

    'Private Sub ButtonDeleteDocVaccination_Click(sender As Object, e As EventArgs) Handles ButtonDeleteDocVaccination.Click
    '    Dim Rows() As DataRow
    '    For Each item As ListViewItem In ListViewDocVaccination.CheckedItems
    '        Rows = BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION.Select("ID_document ='" & item.Text & "'")
    '        EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5), Rows(0)(6), Rows(0)(7), Rows(0)(8), Rows(0)(9), Rows(0)(10))
    '        item.Remove()
    '    Next item
    '    Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Fill(BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION)
    'End Sub
End Class