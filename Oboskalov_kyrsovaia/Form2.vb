Public Class Form2

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gruppa()
    End Sub

    Public Sub gruppa()
        Me.GRUPPATableAdapter.Fill(Me.BaseDataSet.GRUPPA)
        ListViewGroup.Items.Clear()
        Dim items(3) As String

        For Each Row As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            items(1) = Row(3)
            items(2) = Row(1)
            items(3) = Row(2)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            ListViewGroup.Items.Add(it)
        Next Row
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonDeleteGroup.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewGroup.CheckedItems
            Rows = BaseDataSet.GRUPPA.Select("ID_group ='" & item.Text & "'")
            GRUPPATableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3))
            item.Remove()
        Next item
        Me.GRUPPATableAdapter.Fill(BaseDataSet.GRUPPA)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAddGroup.Click
        With Dialog2
            .Text = "Добавление студента"
            .AddOrChange2 = False
            .DateTimePicker1.Value = DateTime.Now
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                gruppa()
            End If
        End With
    End Sub
End Class