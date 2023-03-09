Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        documentmedobsledovanie()
    End Sub

    Public Sub documentmedobsledovanie()
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter.Fill(Me.BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS)

        ListViewDocObsledovanie.Items.Clear()
        Dim items(6) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
                Me.BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS.Rows
            TempRow = Row.GetParentRow("STUDENTDATE_OF_MEDICAL_EXAMINATIONS")
            items(1) = TempRow(1)
            TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONDATE_OF_MEDICAL_EXAMINATIONS")
            items(2) = TempRow(0)
            items(3) = Row(4)
            items(4) = Row(5)
            items(5) = Row(6)
            items(6) = Row(7)
            Dim it As New ListViewItem()
            it.Text = Row(1)
            it.SubItems.AddRange(items)
            ListViewDocObsledovanie.Items.Add(it)
        Next Row
    End Sub

    Private Sub ButtonAddDocObsledovanie_Click(sender As Object, e As EventArgs) Handles ButtonAddDocObsledovanie.Click
        With Dialog7
            .Text = "Добавление документа. Профилактические медицинские обследования"
            .AddOrChangeDialog7 = False
            .DateTimePicker1.Value = DateTime.Now
            .ComboBoxStudentFIO.Items.Clear()
            For Each Row As DataRow In
                    Me.BaseDataSet.STUDENT.Rows
                .ComboBoxStudentFIO.Items.Add(Row(1))
            Next Row

            .ComboBoxMedCards.Items.Clear()
            For Each Rows As DataRow In
                    Me.BaseDataSet.MEDICAL_CARD.Rows
                .ComboBoxMedCards.Items.Add(Rows(0))
            Next Rows

            .ComboBoxOrganization.Items.Clear()
            For Each Rows As DataRow In
                    Me.BaseDataSet.MEDICAL_ORGANIZATION.Rows
                .ComboBoxOrganization.Items.Add(Rows(0))
            Next Rows

            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                documentmedobsledovanie()
            End If
        End With
    End Sub

    Private Sub ButtonDeleteDocObsledovanie_Click(sender As Object, e As EventArgs) Handles ButtonDeleteDocObsledovanie.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewDocObsledovanie.CheckedItems
            Rows = BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS.Select("ID_document ='" & item.Text & "'")
            DATE_OF_MEDICAL_EXAMINATIONSTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5), Rows(0)(6))
            item.Remove()
        Next item
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter.Fill(BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS)
    End Sub
End Class