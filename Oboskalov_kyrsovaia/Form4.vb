Public Class Form4
    Public LastSelectedItemForm4 As ListViewItem
    Dim LastSelectedItem2Form4 As ListViewItem
    Dim strFIOForm4 As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        medcard()
    End Sub

    Public Sub medcard()
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)

        ListViewMedCard.Items.Clear()
        Dim items(2) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
                Me.BaseDataSet.MEDICAL_CARD.Rows
            TempRow = Row.GetParentRow("STUDENTMEDICAL_CARD")
            items(2) = TempRow(1)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            ListViewMedCard.Items.Add(it)
        Next Row
    End Sub

    Private Sub ButtonAddMedCard_Click(sender As Object, e As EventArgs) Handles ButtonAddMedCard.Click
        With Dialog4
            .ComboBoxStudent.Items.Clear()
            For Each Row As DataRow In
                    Me.BaseDataSet.STUDENT.Rows
                .ComboBoxStudent.Items.Add(Row(1))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                medcard()
            End If
        End With
    End Sub

    Private Sub ButtonDeleteMedCard_Click(sender As Object, e As EventArgs) Handles ButtonDeleteMedCard.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewMedCard.CheckedItems
            Rows = BaseDataSet.MEDICAL_CARD.Select("ID_card ='" & item.Text & "'")
            MEDICAL_CARDTableAdapter.Delete(Rows(0)(0), Rows(0)(1))
            item.Remove()
        Next item
        Me.MEDICAL_CARDTableAdapter.Fill(BaseDataSet.MEDICAL_CARD)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListViewMedCard.Items.Clear()
        Dim items(2) As String
        Dim TempRow As DataRow
        If TextBox1.Text = vbNullChar Then
            TextBox1.Text = ""
        End If
        strFIOForm4 = TextBox1.Text

        Dim fPostsID As ULong

        For Each RowPost As DataRow In BaseDataSet.STUDENT.Select("FIO_student Like'" & TextBox1.Text & "*'")
            fPostsID = RowPost("ID_student")
            For Each Row As DataRow In Me.BaseDataSet.MEDICAL_CARD.Select("ID_student ='" & fPostsID & "'")
                TempRow = Row.GetParentRow("STUDENTMEDICAL_CARD")
                items(2) = TempRow(1)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListViewMedCard.Items.Add(it)
            Next Row
        Next RowPost
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
    End Sub
End Class