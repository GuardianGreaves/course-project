Public Class Form6
    Public LastSelectedItemForm6 As ListViewItem
    Dim LastSelectedItem2Form6 As ListViewItem
    Dim strFIOForm6 As String

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.MEDICAL_ORGANIZATION". При необходимости она может быть перемещена или удалена.
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)
        propyskpobolezni()
    End Sub

    Public Sub propyskpobolezni()
        Me.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter.Fill(Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)

        ComboBox1.Items.Clear()
        For Each RowCB As DataRow In
                Me.BaseDataSet.MEDICAL_CARD.Rows
            ComboBox1.Items.Add(RowCB("ID_card"))
        Next RowCB

        ComboBox2.Items.Clear()
        For Each RowCB As DataRow In
                Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Rows
            ComboBox2.Items.Add(RowCB("Date"))
        Next RowCB

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListViewPropuskiPoBolezni.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In
                Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.MEDICAL_CARD.Select("ID_card='" & ComboBox1.SelectedItem & "'")(0)
            If Row("ID_card") = RowFilterDepart("ID_card") Then
                TempRow = Row.GetParentRow("STUDENTABSENTEEISM_DUE_TO_ILLNESS")
                items(1) = TempRow(1)
                items(2) = Row(4)
                items(3) = Row(5)
                items(4) = Row(6)
                Dim it As New ListViewItem()
                it.Text = Row(1)
                it.SubItems.AddRange(items)
                ListViewPropuskiPoBolezni.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListViewPropuskiPoBolezni.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow
        If TextBox1.Text = vbNullChar Then
            TextBox1.Text = ""
        End If
        strFIOForm6 = TextBox1.Text

        Dim fPostsID

        For Each RowPost As DataRow In BaseDataSet.STUDENT.Select("FIO_student Like'%" & TextBox1.Text & "*'")
            fPostsID = RowPost("ID_student")
            For Each Row As DataRow In Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Select("ID_student ='" & fPostsID & "'")
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
        Next RowPost
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListViewPropuskiPoBolezni.Items.Clear()
        Dim items(4) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In
                Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Select("Date='" & ComboBox2.Text & "'")(0)
            If Row("ID_group") = RowFilterDepart("ID_group") Then
                TempRow = Row.GetParentRow("STUDENTABSENTEEISM_DUE_TO_ILLNESS")
                items(1) = TempRow(1)
                items(2) = Row(4)
                items(3) = Row(5)
                items(4) = Row(6)
                Dim it As New ListViewItem()
                it.Text = Row(1)
                it.SubItems.AddRange(items)
                ListViewPropuskiPoBolezni.Items.Add(it)
            End If
        Next Row
    End Sub
End Class