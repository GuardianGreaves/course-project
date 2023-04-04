Public Class Form2
    Dim strFIO2
    Public LastSelectedItemForm2 As ListViewItem
    Dim LastSelectedItem2Form2 As ListViewItem

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gruppa()
    End Sub

    Public Sub gruppa()
        Me.GRUPPATableAdapter.Fill(Me.BaseDataSet.GRUPPA)
        ListViewGroup.Items.Clear()
        Dim items(3) As String

        ComboBoxGruppa.Items.Clear()
        For Each RowCB As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            ComboBoxGruppa.Items.Add(RowCB("name_group"))
        Next RowCB

        ComboBoxNumbStud.Items.Clear()
        For Each RowCB As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            ComboBoxNumbStud.Items.Add(RowCB("number_of_persons"))
        Next RowCB

        ComboBoxDate.Items.Clear()
        For Each RowCB As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            ComboBoxDate.Items.Add(RowCB("date_of_receipt"))
        Next RowCB

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGruppa.SelectedIndexChanged
        ListViewGroup.Items.Clear()
        Dim items(3) As String

        For Each Row As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxGruppa.SelectedItem & "'")(0)
            If Row("ID_group") = RowFilterDepart("ID_group") Then
                items(1) = Row(3)
                items(2) = Row(1)
                items(3) = Row(2)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListViewGroup.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub TextBoxNumbStud_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBoxNumbStud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNumbStud.SelectedIndexChanged
        ListViewGroup.Items.Clear()
        Dim items(3) As String

        For Each Row As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.GRUPPA.Select("number_of_persons='" & ComboBoxNumbStud.SelectedItem & "'")(0)
            If Row("ID_group") = RowFilterDepart("ID_group") Then
                items(1) = Row(3)
                items(2) = Row(1)
                items(3) = Row(2)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListViewGroup.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBoxDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDate.SelectedIndexChanged
        ListViewGroup.Items.Clear()
        Dim items(3) As String

        For Each Row As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.GRUPPA.Select("date_of_receipt='" & ComboBoxDate.Text & "'")(0)
            If Row("ID_group") = RowFilterDepart("ID_group") Then
                items(1) = Row(3)
                items(2) = Row(1)
                items(3) = Row(2)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListViewGroup.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub ListViewGroup_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListViewGroup.ItemSelectionChanged
        LastSelectedItemForm2 = e.Item
        LastSelectedItem2Form2 = e.Item
    End Sub

    Private Sub ListViewGroup_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewGroup.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(sender, e.X, e.Y)
        End If

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ИзменитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзменитьToolStripMenuItem.Click
        With Dialog2
            .Text = "Редактирование группы"
            Dim CurrentWorkerRow As DataRow = BaseDataSet.GRUPPA.Select("ID_group ='" & LastSelectedItemForm2.Text & "'")(0)
            .OldRowID2 = CurrentWorkerRow("ID_group")
            .AddOrChange2 = True
            .TextBox1.Text = CurrentWorkerRow("name_group")
            '.TextBox1.ReadOnly = True
            .DateTimePicker1.Value = CurrentWorkerRow("date_of_receipt")

            .TextBox2.Text = CurrentWorkerRow("number_of_persons")

            .ShowDialog()
            If DialogResult = DialogResult.OK Then
                gruppa()
            End If
        End With
    End Sub

    Private Sub ButtonGroupDate_Click(sender As Object, e As EventArgs) Handles ButtonGroupDate.Click

    End Sub
End Class