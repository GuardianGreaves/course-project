Public Class Form9

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
        Me.SURVEYSTableAdapter.Fill(Me.BaseDataSet.SURVEYS)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)

        'docobsledovanie()
    End Sub

    Private Sub SURVEYSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SURVEYSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseDataSet)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.SURVEYSTableAdapter.Update(Me.BaseDataSet.SURVEYS)
        Me.Validate()
        Me.SURVEYSBindingSource.EndEdit()
        Me.SURVEYSTableAdapter.Update(Me.BaseDataSet.SURVEYS)
        Me.SURVEYSTableAdapter.Fill(Me.BaseDataSet.SURVEYS)
    End Sub




    'Private Sub docobsledovanie()
    '    Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
    '    Me.SURVEYSTableAdapter.Fill(Me.BaseDataSet.SURVEYS)
    '    Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)

    '    ListViewDocObsledovania.Items.Clear()
    '    Dim items(7) As String
    '    Dim TempRow As DataRow
    '    For Each Row As DataRow In
    '            Me.BaseDataSet.SURVEYS.Rows
    '        TempRow = Row.GetParentRow("STUDENTSURVEYS")
    '        items(1) = TempRow(1)
    '        TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONSURVEYS")
    '        items(2) = TempRow(0)
    '        items(3) = Row(4)
    '        items(4) = Row(5)
    '        items(5) = Row(6)
    '        items(6) = Row(7)
    '        Dim it As New ListViewItem()
    '        it.Text = Row(1)
    '        it.SubItems.AddRange(items)
    '        ListViewDocObsledovania.Items.Add(it)
    '    Next Row
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim Rows() As DataRow
    '    For Each item As ListViewItem In ListViewDocObsledovania.CheckedItems
    '        Rows = BaseDataSet.SURVEYS.Select("ID_document ='" & item.Text & "'")
    '        SURVEYSTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5), Rows(0)(6), Rows(0)(7))
    '        item.Remove()
    '    Next item
    '    Me.SURVEYSTableAdapter.Fill(BaseDataSet.SURVEYS)
    'End Sub
End Class