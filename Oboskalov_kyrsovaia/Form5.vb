Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studpropysci()
    End Sub

    Public Sub studpropysci()
        Me.RESPONIBLE_FOR_PASSESTableAdapter.Fill(Me.BaseDataSet.RESPONIBLE_FOR_PASSES)
        Me.GRUPPATableAdapter.Fill(Me.BaseDataSet.GRUPPA)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)

        ListViewStudPropusci.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
                Me.BaseDataSet.RESPONIBLE_FOR_PASSES.Rows
            TempRow = Row.GetParentRow("GRUPPARESPONIBLE_FOR_PASSES")
            items(1) = TempRow(3)
            Dim it As New ListViewItem()
            TempRow = Row.GetParentRow("STUDENTRESPONIBLE_FOR_PASSES")
            it.Text = TempRow(1)
            it.SubItems.AddRange(items)
            ListViewStudPropusci.Items.Add(it)
        Next Row
    End Sub

    Private Sub ButtonAddStudPropusc_Click(sender As Object, e As EventArgs) Handles ButtonAddStudPropusc.Click
        With Dialog5
            .Text = "Добавление студента ответственного за пропуски"
            .AddOrChangeDialog5 = False
            .ComboBoxGruppa.Items.Clear()
            For Each Row As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
                .ComboBoxGruppa.Items.Add(Row(3))
            Next Row
            .ComboBoxStudentFIO.Items.Clear()
            For Each Row As DataRow In
                Me.BaseDataSet.STUDENT.Rows
                .ComboBoxStudentFIO.Items.Add(Row(1))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                studpropysci()
            End If
        End With
    End Sub
End Class