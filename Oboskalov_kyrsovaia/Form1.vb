Public Class Form1
    Public LastSelectedItem As ListViewItem
    Dim LastSelectedItem2 As ListViewItem
    Dim strFIO As String
    Public a

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox1.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & "\Picture\KPK_gerb.jpg")
        student()
    End Sub

    Public Sub student()
        Me.GRUPPATableAdapter.Fill(Me.BaseDataSet.GRUPPA)
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)


        'фильтр группа
        ComboBoxGroup.Items.Clear()
        For Each RowCB As DataRow In
                Me.BaseDataSet.GRUPPA.Rows
            ComboBoxGroup.Items.Add(RowCB("name_group"))
        Next RowCB

        'фильтр общежитие
        ComboBoxHostel.Items.Clear()
        ComboBoxHostel.Items.Add("Да")
        ComboBoxHostel.Items.Add("Нет")

        ListViewStudent.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
                Me.BaseDataSet.STUDENT.Rows
            items(1) = Row(1)
            TempRow = Row.GetParentRow("GRUPPASTUDENT")
            items(2) = TempRow(3)
            items(3) = Row(3)
            items(4) = Row(4)
            items(5) = Row(5)
            items(6) = Row(6)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            ListViewStudent.Items.Add(it)
        Next Row
    End Sub

    'сложный запрос группа 3П
    Private Sub ГруппаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ГруппаToolStripMenuItem.Click
        'Dim cn As New OleDb.OleDbConnection ' 
        'cn.ConnectionString = My.Settings.kporiginalConnectionString2
        'MsgBox(cn.ConnectionString)
        'cn.Open()
        'Dim sql As New OleDb.OleDbCommand("SELECT STUDENT.FIO_student As [Фамилия Имя Отчество], GRUPPA.name_group As Группа, STUDENT.date_of_application As [Дата зачисления], STUDENT.birthday As [Дата рождения], STUDENT.address_students As [Адрес], STUDENT.hostel As [Общежитие] 
        '                               FROM GRUPPA INNER JOIN STUDENT ON GRUPPA.ID_group = STUDENT.ID_group 
        '                               WHERE (((GRUPPA.name_group)='3П'))", cn)
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim DataSqlTable As New DataTable
        'da.SelectCommand = sql
        'da.Fill(DataSqlTable)
        'cn.Close()
        'Dim RowCB As DataRow
        'For Each RowCB In DataSqlTable.Rows
        '    MsgBox(RowCB("Фамилия Имя Отчество") & " " & RowCB("Группа") & " " & RowCB("Дата зачисления") & " " & RowCB("Дата рождения") & " " & RowCB("Адрес") & " " & RowCB("Общежитие"))
        'Next RowCB
        'Form3.DataGridView1.DataSource = DataSqlTable
        'Form3.Show()
    End Sub

    'сложный запрос общежитие: нет
    Private Sub ОбщежитиеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбщежитиеToolStripMenuItem.Click
        'Dim cn As New OleDb.OleDbConnection ' 
        'cn.ConnectionString = My.Settings.kporiginalConnectionString2
        'MsgBox(cn.ConnectionString)
        'cn.Open()
        'Dim sql As New OleDb.OleDbCommand("SELECT STUDENT.FIO_student As [Фамилия Имя Отчество], GRUPPA.name_group As Группа, STUDENT.date_of_application As [Дата зачисления], STUDENT.birthday As [Дата рождения], STUDENT.address_students As [Адрес], STUDENT.hostel As [Общежитие] FROM GRUPPA INNER JOIN STUDENT ON GRUPPA.ID_group = STUDENT.ID_group WHERE (((STUDENT.hostel)='Нет'))", cn)
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim DataSqlTable As New DataTable
        'da.SelectCommand = sql
        'da.Fill(DataSqlTable)
        'cn.Close()
        'Dim RowCB As DataRow
        'For Each RowCB In DataSqlTable.Rows
        '    MsgBox(RowCB("Фамилия Имя Отчество") & " " & RowCB("Группа") & " " & RowCB("Дата зачисления") & " " & RowCB("Дата рождения") & " " & RowCB("Адрес") & " " & RowCB("Общежитие"))
        'Next RowCB
        'Form3.DataGridView1.DataSource = DataSqlTable
        'Form3.Show()
    End Sub


    'фильтр фио
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFIO.TextChanged
        ListViewStudent.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow
        If TextBoxFIO.Text = vbNullChar Then
            TextBoxFIO.Text = ""
        End If
        strFIO = TextBoxFIO.Text

        For Each Row As DataRow In Me.BaseDataSet.
        STUDENT.Select("FIO_student Like'%" & strFIO & "*'")
            items(1) = Row(1)
            TempRow = Row.GetParentRow("GRUPPASTUDENT")
            items(2) = TempRow(3)
            items(3) = Row(3)
            items(4) = Row(4)
            items(5) = Row(5)
            items(6) = Row(6)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            ListViewStudent.Items.Add(it)
        Next Row
    End Sub

    'Фильтр группа
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxGroup.SelectionChangeCommitted
        ListViewStudent.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In
                Me.BaseDataSet.STUDENT.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.GRUPPA.Select("name_group='" & ComboBoxGroup.SelectedItem & "'")(0)
            If Row("ID_group") = RowFilterDepart("ID_group") Then
                items(1) = Row(1)
                TempRow = Row.GetParentRow("GRUPPASTUDENT")
                items(2) = TempRow(3)
                items(3) = Row(3)
                items(4) = Row(4)
                items(5) = Row(5)
                items(6) = Row(6)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListViewStudent.Items.Add(it)
            End If
        Next Row
    End Sub

    'фильтр общежитие
    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxHostel.SelectionChangeCommitted
        ListViewStudent.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In
                Me.BaseDataSet.STUDENT.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.STUDENT.Select("hostel='" & ComboBoxHostel.SelectedItem & "'")(0)
            If Row("hostel") = RowFilterDepart("hostel") Then
                items(1) = Row(1)
                TempRow = Row.GetParentRow("GRUPPASTUDENT")
                items(2) = TempRow(3)
                items(3) = Row(3)
                items(4) = Row(4)
                items(5) = Row(5)
                items(6) = Row(6)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListViewStudent.Items.Add(it)
            End If
        Next Row
    End Sub

    'очистка фильтра
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonClearFilter.Click
        TextBoxFIO.Text = " "
        ComboBoxGroup.Text = " "
        ComboBoxHostel.Text = " "
        student()
    End Sub

    'Фильтр адрес
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAddressStudent.TextChanged
        ListViewStudent.Items.Clear()
        Dim items(7) As String
        Dim TempRow As DataRow
        If TextBoxAddressStudent.Text = vbNullChar Then
            TextBoxAddressStudent.Text = ""
        End If
        strFIO = TextBoxAddressStudent.Text
        For Each Row As DataRow In Me.BaseDataSet.
        STUDENT.Select("address_students Like'%" & strFIO & "*'")
            items(1) = Row(1)
            TempRow = Row.GetParentRow("GRUPPASTUDENT")
            items(2) = TempRow(3)
            items(3) = Row(3)
            items(4) = Row(4)
            items(5) = Row(5)
            items(6) = Row(6)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            ListViewStudent.Items.Add(it)
        Next Row
    End Sub

    'добавление студента
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
        With Dialog1
            .Text = "Добавление студента"
            .AddOrChangeDialog1 = False
            .Label8.Text = "Не создана"
            .DateTimePickerZachisleniye.Value = DateTime.Now
            .DateTimePickerBirthday.Value = DateTime.Now
            .ComboBoxGroup.Items.Clear()
            For Each Row As DataRow In
                    Me.BaseDataSet.GRUPPA.Rows
                .ComboBoxGroup.Items.Add(Row(3))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                student()
            End If
        End With
    End Sub

    'изменение
    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListViewStudent.ItemSelectionChanged
        LastSelectedItem = e.Item
        LastSelectedItem2 = e.Item
    End Sub

    'изменение
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewStudent.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(sender, e.X, e.Y)
        End If
    End Sub

    'изменение
    Public Sub ИзменитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзменитьToolStripMenuItem.Click
        'a = ListView1.FocusedItem.Text
        With Dialog1
            .Text = "Редактирование студента"
            Dim CurrentWorkerRow As DataRow = BaseDataSet.STUDENT.Select("ID_student ='" & LastSelectedItem.Text & "'")(0)
            .OldRowIdDialog1 = CurrentWorkerRow("ID_student")
            .AddOrChangeDialog1 = True
            .TextBoxFIO.Text = CurrentWorkerRow("FIO_student")
            '.TextBox1.ReadOnly = True
            .DateTimePickerZachisleniye.Value = CurrentWorkerRow("date_of_application")
            '.DateTimePicker1.
            .ComboBoxGroup.Text = CurrentWorkerRow.GetParentRow("GRUPPASTUDENT")("name_group")
            '.ComboBox1.Enabled = False
            .DateTimePickerBirthday.Value = CurrentWorkerRow("birthday")
            '.DateTimePicker2.ShowUpDown = False
            '.DateTimePicker2.ShowCheckBox = False
            .TextBoxAddressStudent.Text = CurrentWorkerRow("address_students")
            '.TextBox3.ReadOnly = True
            .ComboBoxHostel.Text = CurrentWorkerRow("hostel")
            '.ComboBox2.Enabled = False
            .ComboBoxGroup.Items.Clear()
            For Each Row As DataRow In
                    Me.BaseDataSet.GRUPPA.Rows
                .ComboBoxGroup.Items.Add(Row(3))
            Next Row
            Dim CurrentWorkerRow2 As DataRow = BaseDataSet.MEDICAL_CARD.Select("ID_student ='" & LastSelectedItem.Text & "'")(0)
            .Label8.Text = CurrentWorkerRow2("ID_card")
            .ShowDialog()
            If DialogResult = DialogResult.OK Then
                student()
            End If
        End With
    End Sub

    'удаление студента
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonDeleteStudent.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewStudent.CheckedItems
            Rows = BaseDataSet.STUDENT.Select("ID_student ='" & item.Text & "'")
            STUDENTTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5), Rows(0)(6))
            item.Remove()
        Next item
        Me.STUDENTTableAdapter.Fill(BaseDataSet.STUDENT)
    End Sub


    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonStudentData.Click
        a = ListViewStudent.FocusedItem.Text
        Form11.Show()

        With Form11
            .Text = "Редактирование студента"
            Dim CurrentWorkerRow As DataRow = BaseDataSet.STUDENT.Select("ID_student ='" & LastSelectedItem.Text & "'")(0)
            '.OldRowIdForm11 = CurrentWorkerRow("ID_student")
            '.AddOrChangeForm11 = True
            .TextBoxFIO.Text = CurrentWorkerRow("FIO_student")
            '.TextBox1.ReadOnly = True
            .DateTimePickerZachisleniye.Value = CurrentWorkerRow("date_of_application")
            '.DateTimePicker1.
            .ComboBoxGroup.Text = CurrentWorkerRow.GetParentRow("GRUPPASTUDENT")("name_group")
            '.ComboBox1.Enabled = False
            .DateTimePickerBirthday.Value = CurrentWorkerRow("birthday")
            '.DateTimePicker2.ShowUpDown = False
            '.DateTimePicker2.ShowCheckBox = False
            .TextBoxAddressStudent.Text = CurrentWorkerRow("address_students")
            '.TextBox3.ReadOnly = True
            .ComboBoxHostel.Text = CurrentWorkerRow("hostel")
            '.ComboBox2.Enabled = False
            .ComboBoxGroup.Items.Clear()
            For Each Row As DataRow In
                    Me.BaseDataSet.GRUPPA.Rows
                .ComboBoxGroup.Items.Add(Row(3))
            Next Row
            Dim CurrentWorkerRow2 As DataRow = BaseDataSet.MEDICAL_CARD.Select("ID_student ='" & LastSelectedItem.Text & "'")(0)
            .Label8.Text = CurrentWorkerRow2("ID_card")

            '.ListViewDocs.Items.Clear()
            'Dim items2(2) As String
            'Dim TempRow2 As DataRow
            'For Each Row2 As DataRow In Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Select("ID_student ='" & LastSelectedItem.Text & "*'")
            '    MsgBox("d")
            '    TempRow2 = Row2.GetParentRow("MEDICAL_ORGANIZATIONABSENTEEISM_DUE_TO_ILLNESS")
            '    items2(1) = TempRow2(0)
            '    Dim it2 As New ListViewItem()
            '    it2.Text = Row2(0)
            '    it2.SubItems.AddRange(items2)
            '    .ListViewDocs.Items.Add(it2)
            'Next Row2



        End With
    End Sub

    Private Sub ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem.Click
        Form10.Show()
    End Sub

    Private Sub ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem.Click
        'Form2.Show()
    End Sub

    Private Sub ГруппыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ГруппыToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub МедицинскиеОрганизацииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МедицинскиеОрганизацииToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub МедицинскиеКартыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МедицинскиеКартыToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub ПропускЗанятийПоБолезниToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПропускЗанятийПоБолезниToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub ОбследованияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбследованияToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub ПрофилактическиеПрививкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПрофилактическиеПрививкиToolStripMenuItem.Click
        Form8.Show()
    End Sub


End Class
