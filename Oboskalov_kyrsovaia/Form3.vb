Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        organization()
    End Sub

    Public Sub organization()
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)

        ListViewOrganization.Items.Clear()
        Dim items(3) As String
        For Each Row As DataRow In
                Me.BaseDataSet.MEDICAL_ORGANIZATION.Rows
            items(1) = Row(0)
            items(2) = Row(2)
            Dim it As New ListViewItem()
            it.Text = Row(1)
            it.SubItems.AddRange(items)
            ListViewOrganization.Items.Add(it)
        Next Row
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAddOrganization.Click
        With Dialog3
            .Text = "Добавление документа. Осмотры перед прививками и после прививок"
            .AddOrChangeDialog3 = False
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                organization()
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonDeleteOrganization.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewOrganization.CheckedItems
            Rows = BaseDataSet.MEDICAL_ORGANIZATION.Select("ID_organization ='" & item.Text & "'")
            MEDICAL_ORGANIZATIONTableAdapter.Delete(Rows(0)(1), Rows(0)(2))
            item.Remove()
        Next item
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(BaseDataSet.MEDICAL_ORGANIZATION)
    End Sub
End Class