<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.БазаДанныхToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ГруппыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.МедицинскиеОрганизацииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.МедицинскиеКартыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчетыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СложныеЗапросыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ГруппаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбщежитиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВсеДокументыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПропускЗанятийПоБолезниToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПрофилактическиеПрививкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбследованияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПросмотрСправкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxAddressStudent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonClearFilter = New System.Windows.Forms.Button()
        Me.TextBoxFIO = New System.Windows.Forms.TextBox()
        Me.ComboBoxHostel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.ButtonDeleteStudent = New System.Windows.Forms.Button()
        Me.ListViewStudent = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonStudentData = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ИзменитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.GRUPPATableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.GRUPPATableAdapter()
        Me.MEDICAL_CARDTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_CARDTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(24, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.СправочникиToolStripMenuItem, Me.ОтчетыToolStripMenuItem, Me.ВсеДокументыToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.БазаДанныхToolStripMenuItem, Me.СохранитьToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'БазаДанныхToolStripMenuItem
        '
        Me.БазаДанныхToolStripMenuItem.Name = "БазаДанныхToolStripMenuItem"
        Me.БазаДанныхToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.БазаДанныхToolStripMenuItem.Text = "База данных"
        '
        'СохранитьToolStripMenuItem
        '
        Me.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.СохранитьToolStripMenuItem.Text = "Сохранить все"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'СправочникиToolStripMenuItem
        '
        Me.СправочникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ГруппыToolStripMenuItem, Me.МедицинскиеОрганизацииToolStripMenuItem, Me.МедицинскиеКартыToolStripMenuItem, Me.СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem})
        Me.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        Me.СправочникиToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.СправочникиToolStripMenuItem.Text = "Справочники"
        '
        'ГруппыToolStripMenuItem
        '
        Me.ГруппыToolStripMenuItem.Name = "ГруппыToolStripMenuItem"
        Me.ГруппыToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ГруппыToolStripMenuItem.Text = "Группы"
        '
        'МедицинскиеОрганизацииToolStripMenuItem
        '
        Me.МедицинскиеОрганизацииToolStripMenuItem.Name = "МедицинскиеОрганизацииToolStripMenuItem"
        Me.МедицинскиеОрганизацииToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.МедицинскиеОрганизацииToolStripMenuItem.Text = "Медицинские организации"
        '
        'МедицинскиеКартыToolStripMenuItem
        '
        Me.МедицинскиеКартыToolStripMenuItem.Name = "МедицинскиеКартыToolStripMenuItem"
        Me.МедицинскиеКартыToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.МедицинскиеКартыToolStripMenuItem.Text = "Медицинские карты"
        '
        'СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem
        '
        Me.СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem.Name = "СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem"
        Me.СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem.Text = "Ответсвенные за пропуски по болезни"
        '
        'ОтчетыToolStripMenuItem
        '
        Me.ОтчетыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СложныеЗапросыToolStripMenuItem, Me.ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem})
        Me.ОтчетыToolStripMenuItem.Name = "ОтчетыToolStripMenuItem"
        Me.ОтчетыToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ОтчетыToolStripMenuItem.Text = "Отчеты"
        '
        'СложныеЗапросыToolStripMenuItem
        '
        Me.СложныеЗапросыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ГруппаToolStripMenuItem, Me.ОбщежитиеToolStripMenuItem})
        Me.СложныеЗапросыToolStripMenuItem.Name = "СложныеЗапросыToolStripMenuItem"
        Me.СложныеЗапросыToolStripMenuItem.Size = New System.Drawing.Size(397, 22)
        Me.СложныеЗапросыToolStripMenuItem.Text = "Поиск по сложным запросам"
        '
        'ГруппаToolStripMenuItem
        '
        Me.ГруппаToolStripMenuItem.Name = "ГруппаToolStripMenuItem"
        Me.ГруппаToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ГруппаToolStripMenuItem.Text = "Группа: 3П"
        '
        'ОбщежитиеToolStripMenuItem
        '
        Me.ОбщежитиеToolStripMenuItem.Name = "ОбщежитиеToolStripMenuItem"
        Me.ОбщежитиеToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ОбщежитиеToolStripMenuItem.Text = "Общежитие: нет"
        '
        'ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem
        '
        Me.ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem.Name = "ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem"
        Me.ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem.Size = New System.Drawing.Size(397, 22)
        Me.ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem.Text = "Просмотр информации о студентах по выбранной группе"
        '
        'ВсеДокументыToolStripMenuItem
        '
        Me.ВсеДокументыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem, Me.ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem, Me.ПропускЗанятийПоБолезниToolStripMenuItem, Me.ПрофилактическиеПрививкиToolStripMenuItem, Me.ОбследованияToolStripMenuItem})
        Me.ВсеДокументыToolStripMenuItem.Name = "ВсеДокументыToolStripMenuItem"
        Me.ВсеДокументыToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.ВсеДокументыToolStripMenuItem.Text = "Документы"
        '
        'ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem
        '
        Me.ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem.Name = "ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem"
        Me.ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem.Text = "Осмотры перед прививками и после прививок"
        '
        'ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem
        '
        Me.ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem.Name = "ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem"
        Me.ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem.Text = "Данные медицинских профилактических осмотров"
        '
        'ПропускЗанятийПоБолезниToolStripMenuItem
        '
        Me.ПропускЗанятийПоБолезниToolStripMenuItem.Name = "ПропускЗанятийПоБолезниToolStripMenuItem"
        Me.ПропускЗанятийПоБолезниToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.ПропускЗанятийПоБолезниToolStripMenuItem.Text = "Пропуск занятий по болезни"
        '
        'ПрофилактическиеПрививкиToolStripMenuItem
        '
        Me.ПрофилактическиеПрививкиToolStripMenuItem.Name = "ПрофилактическиеПрививкиToolStripMenuItem"
        Me.ПрофилактическиеПрививкиToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.ПрофилактическиеПрививкиToolStripMenuItem.Text = "Профилактические прививки"
        '
        'ОбследованияToolStripMenuItem
        '
        Me.ОбследованияToolStripMenuItem.Name = "ОбследованияToolStripMenuItem"
        Me.ОбследованияToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.ОбследованияToolStripMenuItem.Text = "Обследования"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПросмотрСправкиToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'ПросмотрСправкиToolStripMenuItem
        '
        Me.ПросмотрСправкиToolStripMenuItem.Name = "ПросмотрСправкиToolStripMenuItem"
        Me.ПросмотрСправкиToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ПросмотрСправкиToolStripMenuItem.Text = "Просмотр справки"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxAddressStudent)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonClearFilter)
        Me.GroupBox1.Controls.Add(Me.TextBoxFIO)
        Me.GroupBox1.Controls.Add(Me.ComboBoxHostel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxGroup)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 72)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск и фильтрация студента"
        '
        'TextBoxAddressStudent
        '
        Me.TextBoxAddressStudent.Location = New System.Drawing.Point(174, 36)
        Me.TextBoxAddressStudent.Name = "TextBoxAddressStudent"
        Me.TextBoxAddressStudent.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxAddressStudent.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Адрес"
        '
        'ButtonClearFilter
        '
        Me.ButtonClearFilter.Location = New System.Drawing.Point(505, 36)
        Me.ButtonClearFilter.Name = "ButtonClearFilter"
        Me.ButtonClearFilter.Size = New System.Drawing.Size(105, 23)
        Me.ButtonClearFilter.TabIndex = 16
        Me.ButtonClearFilter.Text = "Очистить фильтр"
        Me.ButtonClearFilter.UseVisualStyleBackColor = True
        '
        'TextBoxFIO
        '
        Me.TextBoxFIO.Location = New System.Drawing.Point(9, 37)
        Me.TextBoxFIO.Name = "TextBoxFIO"
        Me.TextBoxFIO.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxFIO.TabIndex = 12
        '
        'ComboBoxHostel
        '
        Me.ComboBoxHostel.FormattingEnabled = True
        Me.ComboBoxHostel.Location = New System.Drawing.Point(420, 36)
        Me.ComboBoxHostel.Name = "ComboBoxHostel"
        Me.ComboBoxHostel.Size = New System.Drawing.Size(66, 21)
        Me.ComboBoxHostel.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Фамилия Имя Отчество"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Общежитие"
        '
        'ComboBoxGroup
        '
        Me.ComboBoxGroup.FormattingEnabled = True
        Me.ComboBoxGroup.Location = New System.Drawing.Point(342, 36)
        Me.ComboBoxGroup.Name = "ComboBoxGroup"
        Me.ComboBoxGroup.Size = New System.Drawing.Size(66, 21)
        Me.ComboBoxGroup.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Группа"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonAddStudent)
        Me.GroupBox2.Controls.Add(Me.ButtonDeleteStudent)
        Me.GroupBox2.Controls.Add(Me.ListViewStudent)
        Me.GroupBox2.Controls.Add(Me.ButtonStudentData)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(713, 218)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Список студентов"
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.Location = New System.Drawing.Point(433, 184)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(131, 27)
        Me.ButtonAddStudent.TabIndex = 9
        Me.ButtonAddStudent.Text = "Добавить студента"
        Me.ButtonAddStudent.UseVisualStyleBackColor = True
        '
        'ButtonDeleteStudent
        '
        Me.ButtonDeleteStudent.Location = New System.Drawing.Point(570, 184)
        Me.ButtonDeleteStudent.Name = "ButtonDeleteStudent"
        Me.ButtonDeleteStudent.Size = New System.Drawing.Size(131, 27)
        Me.ButtonDeleteStudent.TabIndex = 10
        Me.ButtonDeleteStudent.Text = "Удалить студента"
        Me.ButtonDeleteStudent.UseVisualStyleBackColor = True
        '
        'ListViewStudent
        '
        Me.ListViewStudent.CheckBoxes = True
        Me.ListViewStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListViewStudent.FullRowSelect = True
        Me.ListViewStudent.GridLines = True
        Me.ListViewStudent.HideSelection = False
        Me.ListViewStudent.Location = New System.Drawing.Point(9, 19)
        Me.ListViewStudent.MultiSelect = False
        Me.ListViewStudent.Name = "ListViewStudent"
        Me.ListViewStudent.Size = New System.Drawing.Size(692, 159)
        Me.ListViewStudent.TabIndex = 0
        Me.ListViewStudent.UseCompatibleStateImageBehavior = False
        Me.ListViewStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 23
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ФИО студента"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Группа"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Дата зачисления"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Дата рождения"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Адрес"
        Me.ColumnHeader6.Width = 160
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Общежитие"
        Me.ColumnHeader7.Width = 75
        '
        'ButtonStudentData
        '
        Me.ButtonStudentData.Location = New System.Drawing.Point(9, 184)
        Me.ButtonStudentData.Name = "ButtonStudentData"
        Me.ButtonStudentData.Size = New System.Drawing.Size(184, 27)
        Me.ButtonStudentData.TabIndex = 2
        Me.ButtonStudentData.Text = "Просмотр данных о студенте"
        Me.ButtonStudentData.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзменитьToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 26)
        '
        'ИзменитьToolStripMenuItem
        '
        Me.ИзменитьToolStripMenuItem.Name = "ИзменитьToolStripMenuItem"
        Me.ИзменитьToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ИзменитьToolStripMenuItem.Text = "Изменить"
        '
        'BaseDataSet
        '
        Me.BaseDataSet.CaseSensitive = True
        Me.BaseDataSet.DataSetName = "baseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter = Nothing
        Me.TableAdapterManager.GRUPPATableAdapter = Me.GRUPPATableAdapter
        Me.TableAdapterManager.MedCardTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Me.MEDICAL_CARDTableAdapter
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GRUPPATableAdapter
        '
        Me.GRUPPATableAdapter.ClearBeforeFill = True
        '
        'MEDICAL_CARDTableAdapter
        '
        Me.MEDICAL_CARDTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 329)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Контроль состояния здоровья студентов"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БазаДанныхToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправочникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ГруппыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents МедицинскиеОрганизацииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents МедицинскиеКартыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОтчетыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СложныеЗапросыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ГруппаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбщежитиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПпосмотрИнформацииОСтудентахПоВыбраннойГруппеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВсеДокументыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОсмотрыПередПрививкамиИПослеПрививокToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДанныеМедицинскизПрофилактическихОсмотровToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПропускЗанятийПоБолезниToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПрофилактическиеПрививкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбследованияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxAddressStudent As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonClearFilter As Button
    Friend WithEvents TextBoxFIO As TextBox
    Friend WithEvents ComboBoxHostel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxGroup As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonDeleteStudent As Button
    Friend WithEvents ListViewStudent As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ButtonStudentData As Button
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ИзменитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MEDICAL_CARDTableAdapter As baseDataSetTableAdapters.MEDICAL_CARDTableAdapter
    Friend WithEvents GRUPPATableAdapter As baseDataSetTableAdapters.GRUPPATableAdapter
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents СтудентыОтветсвенныеЗаПропускиПоБолезниToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПросмотрСправкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
End Class
