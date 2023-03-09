Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.MEDICAL_ORGANIZATION". При необходимости она может быть перемещена или удалена.
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)
        propyskpobolezni()
    End Sub

    Public Sub propyskpobolezni()
        Me.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter.Fill(Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)

        ListViewPropuskiPoBolezni.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
                Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Rows
            TempRow = Row.GetParentRow("STUDENTABSENTEEISM_DUE_TO_ILLNESS")
            items(1) = TempRow(1)
            items(2) = Row(4)
            items(3) = Row(5)
            items(4) = Row(6)
            Dim it As New ListViewItem()
            it.Text = Row(1)
            it.SubItems.AddRange(items)
            ListViewPropuskiPoBolezni.Items.Add(it)
        Next Row
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
        With Dialog6
            .Text = "Добавление документа. Пропуски по болезни"
            .AddOrChangeDialog6 = False
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
                propyskpobolezni()
            End If
        End With
    End Sub



    Private Sub ButtonDeleteStudent_Click(sender As Object, e As EventArgs) Handles ButtonDeleteStudent.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewPropuskiPoBolezni.CheckedItems
            Rows = BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Select("ID_document ='" & item.Text & "'")
            ABSENTEEISM_DUE_TO_ILLNESSTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5))
            item.Remove()
        Next item
        Me.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter.Fill(BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS)
    End Sub
End Class