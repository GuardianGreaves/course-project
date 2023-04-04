Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.SURVEYS". При необходимости она может быть перемещена или удалена.
        Me.SURVEYSTableAdapter.Fill(Me.BaseDataSet.SURVEYS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.RESPONIBLE_FOR_PASSES". При необходимости она может быть перемещена или удалена.
        Me.RESPONIBLE_FOR_PASSESTableAdapter.Fill(Me.BaseDataSet.RESPONIBLE_FOR_PASSES)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.PREVENTIVE_VACCINATIONS". При необходимости она может быть перемещена или удалена.
        Me.PREVENTIVE_VACCINATIONSTableAdapter.Fill(Me.BaseDataSet.PREVENTIVE_VACCINATIONS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION". При необходимости она может быть перемещена или удалена.
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.Fill(Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS". При необходимости она может быть перемещена или удалена.
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter.Fill(Me.BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.GRUPPA". При необходимости она может быть перемещена или удалена.
        Me.GRUPPATableAdapter.Fill(Me.BaseDataSet.GRUPPA)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.MEDICAL_ORGANIZATION". При необходимости она может быть перемещена или удалена.
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.MEDICAL_CARD". При необходимости она может быть перемещена или удалена.
        Me.MEDICAL_CARDTableAdapter.Fill(Me.BaseDataSet.MEDICAL_CARD)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS". При необходимости она может быть перемещена или удалена.
        Me.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter.Fill(Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BaseDataSet.STUDENT". При необходимости она может быть перемещена или удалена.
        Me.STUDENTTableAdapter.Fill(Me.BaseDataSet.STUDENT)
        Text = "Редактирование студента"
        Dim CurrentWorkerRow As DataRow = BaseDataSet.STUDENT.Select("ID_student ='" & Form1.LastSelectedItem.Text & "'")(0)
        '.OldRowIdForm11 = CurrentWorkerRow("ID_student")
        Dim idstud = CurrentWorkerRow("ID_student")
        '.AddOrChangeForm11 = True
        TextBoxFIO.Text = CurrentWorkerRow("FIO_student")
        '.TextBox1.ReadOnly = True
        DateTimePickerZachisleniye.Value = CurrentWorkerRow("date_of_application")
        '.DateTimePicker1.
        ComboBoxGroup.Text = CurrentWorkerRow.GetParentRow("GRUPPASTUDENT")("name_group")
        '.ComboBox1.Enabled = False
        DateTimePickerBirthday.Value = CurrentWorkerRow("birthday")
        '.DateTimePicker2.ShowUpDown = False
        '.DateTimePicker2.ShowCheckBox = False
        TextBoxAddressStudent.Text = CurrentWorkerRow("address_students")
        '.TextBox3.ReadOnly = True
        ComboBoxHostel.Text = CurrentWorkerRow("hostel")
        '.ComboBox2.Enabled = False
        ComboBoxGroup.Items.Clear()
        For Each Row As DataRow In
                    BaseDataSet.GRUPPA.Rows
            ComboBoxGroup.Items.Add(Row(3))
        Next Row
        Dim CurrentWorkerRow2 As DataRow = BaseDataSet.MEDICAL_CARD.Select("ID_student ='" & Form1.LastSelectedItem.Text & "'")(0)
        Label8.Text = CurrentWorkerRow2("ID_card")

        ListView1.Items.Clear()
        Dim items(3) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In
                Me.BaseDataSet.ABSENTEEISM_DUE_TO_ILLNESS.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.STUDENT.Select("ID_student='" & idstud & "'")(0)
            If Row("ID_student") = RowFilterDepart("ID_student") Then
                TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONABSENTEEISM_DUE_TO_ILLNESS")
                items(1) = TempRow(0)
                items(2) = Row(5)
                'MsgBox(Row(0))
                'MsgBox(Row(1))
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListView1.Items.Add(it)
            End If
        Next Row

        For Each Row As DataRow In
                Me.BaseDataSet.DATE_OF_MEDICAL_EXAMINATIONS.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.STUDENT.Select("ID_student='" & idstud & "'")(0)
            If Row("ID_student") = RowFilterDepart("ID_student") Then
                TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONDATE_OF_MEDICAL_EXAMINATIONS")
                items(1) = TempRow(0)
                items(2) = Row(6)
                'MsgBox(Row(0))
                'MsgBox(Row(1))
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListView1.Items.Add(it)
            End If
        Next Row

        For Each Row As DataRow In
                Me.BaseDataSet.EXAMINATION_BEFORE_AFTER_VACCINATION.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.STUDENT.Select("ID_student='" & idstud & "'")(0)
            If Row("ID_student") = RowFilterDepart("ID_student") Then
                TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONEXAMINATION_BEFORE_AFTER_VACCINATION")
                items(1) = TempRow(0)
                items(2) = Row(5)
                'MsgBox(Row(0))
                'MsgBox(Row(1))
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListView1.Items.Add(it)
            End If
        Next Row

        For Each Row As DataRow In
                Me.BaseDataSet.PREVENTIVE_VACCINATIONS.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.STUDENT.Select("ID_student='" & idstud & "'")(0)
            If Row("ID_student") = RowFilterDepart("ID_student") Then
                TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONPREVENTIVE_VACCINATIONS")
                items(1) = TempRow(0)
                items(2) = Row(6)
                'MsgBox(Row(0))
                'MsgBox(Row(1))
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                ListView1.Items.Add(it)
            End If
        Next Row

        For Each Row As DataRow In
                Me.BaseDataSet.SURVEYS.Rows
            Dim RowFilterDepart As DataRow = BaseDataSet.STUDENT.Select("ID_student='" & idstud & "'")(0)
            If Row("ID_student") = RowFilterDepart("ID_student") Then
                TempRow = Row.GetParentRow("MEDICAL_ORGANIZATIONSURVEYS")
                items(1) = TempRow(0)
                items(2) = Row(7)
                'MsgBox(Row(0))
                'MsgBox(Row(1))
                Dim it As New ListViewItem()
                it.Text = Row(2)
                it.SubItems.AddRange(items)
                ListView1.Items.Add(it)
            End If
        Next Row

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class