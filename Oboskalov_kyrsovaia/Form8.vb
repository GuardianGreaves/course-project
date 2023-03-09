Public Class Form8


    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        documentprofilacticprivivki()
    End Sub

    Public Sub documentprofilacticprivivki()
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)
        Me.PREVENTIVE_VACCINATIONSTableAdapter.Fill(Me.BaseDataSet.PREVENTIVE_VACCINATIONS)
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)

        ListViewDocProfPrivivki.Items.Clear()
        Dim items(6) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
                Me.BaseDataSet.PREVENTIVE_VACCINATIONS.Rows
            TempRow = Row.GetParentRow("STUDENTPREVENTIVE_VACCINATIONS")
            items(1) = TempRow(1)
            TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONPREVENTIVE_VACCINATIONS")
            items(2) = TempRow(0)
            items(3) = Row(4)
            items(4) = Row(5)
            Dim it As New ListViewItem()
            it.Text = Row(1)
            it.SubItems.AddRange(items)
            ListViewDocProfPrivivki.Items.Add(it)
        Next Row
    End Sub

    Private Sub ButtonDeleteDocProfPrivivki_Click(sender As Object, e As EventArgs) Handles ButtonDeleteDocProfPrivivki.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewDocProfPrivivki.CheckedItems
            Rows = BaseDataSet.PREVENTIVE_VACCINATIONS.Select("ID_document ='" & item.Text & "'")
            PREVENTIVE_VACCINATIONSTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5), Rows(0)(6))
            item.Remove()
        Next item
        Me.PREVENTIVE_VACCINATIONSTableAdapter.Fill(BaseDataSet.PREVENTIVE_VACCINATIONS)
    End Sub

    Private Sub ButtonAddDocProfPrivivki_Click(sender As Object, e As EventArgs) Handles ButtonAddDocProfPrivivki.Click
        With Dialog8
            .Text = "Добавление документа. Профилактические прививки"
            .AddOrChangeDialog8 = False
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
                documentprofilacticprivivki()
            End If
        End With
    End Sub
End Class