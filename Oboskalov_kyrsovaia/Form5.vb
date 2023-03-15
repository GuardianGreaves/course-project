Public Class Form5
    Public LastSelectedItemForm5 As ListViewItem
    Dim LastSelectedItem2Form5 As ListViewItem
    Dim strFIOForm5 As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studpropysci()
    End Sub

    Public Sub studpropysci()
        Me.RESPONIBLE_FOR_PASSESTableAdapter.Fill(Me.BaseDataSet.RESPONIBLE_FOR_PASSES)
        Me.GRUPPATableAdapter.Fill(Me.BaseDataSet.GRUPPA)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)

        ComboBox1.Items.Clear()
        For Each RowCB As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            ComboBox1.Items.Add(RowCB("name_group"))
        Next RowCB

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListViewStudPropusci.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow
        If TextBox1.Text = vbNullChar Then
            TextBox1.Text = ""
        End If
        strFIOForm5 = TextBox1.Text

        Dim fPostsID

        For Each RowPost As DataRow In BaseDataSet.STUDENT.Select("FIO_student Like'%" & TextBox1.Text & "*'")
            fPostsID = RowPost("ID_student")
            For Each Row As DataRow In Me.BaseDataSet.RESPONIBLE_FOR_PASSES.Select("ID_student ='" & fPostsID & "'")
                TempRow = Row.GetParentRow("GRUPPARESPONIBLE_FOR_PASSES")
                items(1) = TempRow(3)
                Dim it As New ListViewItem()
                TempRow = Row.GetParentRow("STUDENTRESPONIBLE_FOR_PASSES")
                it.Text = TempRow(1)
                it.SubItems.AddRange(items)
                ListViewStudPropusci.Items.Add(it)
            Next Row
        Next RowPost
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListViewStudPropusci.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In
                Me.BaseDataSet.RESPONIBLE_FOR_PASSES.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.GRUPPA.Select("name_group='" & ComboBox1.SelectedItem & "'")(0)
            If Row("ID_group") = RowFilterDepart("ID_group") Then
                TempRow = Row.GetParentRow("GRUPPARESPONIBLE_FOR_PASSES")
                items(1) = TempRow(3)
                Dim it As New ListViewItem()
                TempRow = Row.GetParentRow("STUDENTRESPONIBLE_FOR_PASSES")
                it.Text = TempRow(1)
                it.SubItems.AddRange(items)
                ListViewStudPropusci.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Text = ""
        TextBox1.Clear()
        studpropysci()
    End Sub

    Private Sub ListViewStudPropusci_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListViewStudPropusci.ItemSelectionChanged
        LastSelectedItemForm5 = e.Item
        LastSelectedItem2Form5 = e.Item
    End Sub

    Private Sub ListViewStudPropusci_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewStudPropusci.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(sender, e.X, e.Y)
        End If
    End Sub

    Private Sub ИзменитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзменитьToolStripMenuItem.Click
        With Dialog5
            Dim CurrentWorkerRow3 As DataRow = BaseDataSet.STUDENT.Select("FIO_student ='" & LastSelectedItemForm5.Text & "'")(0)
            Dim a = CurrentWorkerRow3("ID_student")
            Dim CurrentWorkerRow4 As DataRow = BaseDataSet.RESPONIBLE_FOR_PASSES.Select("ID_student ='" & a & "'")(0)
            Dim b = CurrentWorkerRow4("ID_group")


            .Text = "Редактирование студента ответсвенного за пропуски"
            Dim CurrentWorkerRow As DataRow = BaseDataSet.RESPONIBLE_FOR_PASSES.Select("ID_student ='" & a & "'")(0)
            .OldRowIdDialog5 = CurrentWorkerRow("ID_student")
            .AddOrChangeDialog5 = True

            .ComboBoxStudentFIO.Items.Clear()
            For Each Row As DataRow In
        Me.BaseDataSet.STUDENT.Rows
                .ComboBoxStudentFIO.Items.Add(Row(1))
            Next Row

            .ComboBoxGruppa.Items.Clear()
            For Each Row As DataRow In
                    Me.BaseDataSet.GRUPPA.Rows
                .ComboBoxGruppa.Items.Add(Row(3))
            Next Row

            Dim CurrentWorkerRow0 As DataRow = BaseDataSet.GRUPPA.Select("ID_group ='" & b & "'")(0)
            .ComboBoxGruppa.Text = CurrentWorkerRow0("name_group")
            Dim CurrentWorkerRow2 As DataRow = BaseDataSet.STUDENT.Select("ID_student ='" & a & "'")(0)
            .ComboBoxStudentFIO.Text = CurrentWorkerRow2("FIO_student")


            .ShowDialog()
            If DialogResult = DialogResult.OK Then
                studpropysci()
            End If
        End With
    End Sub
End Class