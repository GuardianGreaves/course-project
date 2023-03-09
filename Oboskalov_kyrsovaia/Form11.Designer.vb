<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBoxHostel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGroup = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxAddressStudent = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerBirthday = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerZachisleniye = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxFIO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ComboBoxHostel
        '
        Me.ComboBoxHostel.FormattingEnabled = True
        Me.ComboBoxHostel.Items.AddRange(New Object() {"Да", "Нет"})
        Me.ComboBoxHostel.Location = New System.Drawing.Point(15, 187)
        Me.ComboBoxHostel.Name = "ComboBoxHostel"
        Me.ComboBoxHostel.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxHostel.TabIndex = 60
        '
        'ComboBoxGroup
        '
        Me.ComboBoxGroup.FormattingEnabled = True
        Me.ComboBoxGroup.Location = New System.Drawing.Point(155, 187)
        Me.ComboBoxGroup.Name = "ComboBoxGroup"
        Me.ComboBoxGroup.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxGroup.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = ":Медицинская карта"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Общежитие"
        '
        'TextBoxAddressStudent
        '
        Me.TextBoxAddressStudent.AllowDrop = True
        Me.TextBoxAddressStudent.Location = New System.Drawing.Point(15, 93)
        Me.TextBoxAddressStudent.Name = "TextBoxAddressStudent"
        Me.TextBoxAddressStudent.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxAddressStudent.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Адрес проживания"
        '
        'DateTimePickerBirthday
        '
        Me.DateTimePickerBirthday.Location = New System.Drawing.Point(155, 139)
        Me.DateTimePickerBirthday.Name = "DateTimePickerBirthday"
        Me.DateTimePickerBirthday.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePickerBirthday.TabIndex = 53
        '
        'DateTimePickerZachisleniye
        '
        Me.DateTimePickerZachisleniye.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePickerZachisleniye.Location = New System.Drawing.Point(15, 139)
        Me.DateTimePickerZachisleniye.Name = "DateTimePickerZachisleniye"
        Me.DateTimePickerZachisleniye.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePickerZachisleniye.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Дата рождения"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Дата зачисления"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Группа"
        '
        'TextBoxFIO
        '
        Me.TextBoxFIO.Location = New System.Drawing.Point(15, 48)
        Me.TextBoxFIO.Name = "TextBoxFIO"
        Me.TextBoxFIO.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxFIO.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Фамилия, имя, отчество"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 214)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(292, 183)
        Me.ListView1.TabIndex = 61
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 443)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBoxHostel)
        Me.Controls.Add(Me.ComboBoxGroup)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxAddressStudent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePickerBirthday)
        Me.Controls.Add(Me.DateTimePickerZachisleniye)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFIO)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form11"
        Me.Text = "Form11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxHostel As ComboBox
    Friend WithEvents ComboBoxGroup As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAddressStudent As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerBirthday As DateTimePicker
    Friend WithEvents DateTimePickerZachisleniye As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxFIO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
End Class
