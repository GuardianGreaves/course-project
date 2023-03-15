<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListViewPropuskiPoBolezni = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.ButtonDeleteStudent = New System.Windows.Forms.Button()
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter()
        Me.MEDICAL_CARDTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_CARDTableAdapter()
        Me.MEDICAL_ORGANIZATIONTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewPropuskiPoBolezni
        '
        Me.ListViewPropuskiPoBolezni.CheckBoxes = True
        Me.ListViewPropuskiPoBolezni.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListViewPropuskiPoBolezni.FullRowSelect = True
        Me.ListViewPropuskiPoBolezni.GridLines = True
        Me.ListViewPropuskiPoBolezni.HideSelection = False
        Me.ListViewPropuskiPoBolezni.Location = New System.Drawing.Point(9, 19)
        Me.ListViewPropuskiPoBolezni.MultiSelect = False
        Me.ListViewPropuskiPoBolezni.Name = "ListViewPropuskiPoBolezni"
        Me.ListViewPropuskiPoBolezni.Size = New System.Drawing.Size(555, 159)
        Me.ListViewPropuskiPoBolezni.TabIndex = 1
        Me.ListViewPropuskiPoBolezni.UseCompatibleStateImageBehavior = False
        Me.ListViewPropuskiPoBolezni.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 23
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Фамилия Имя Отчество"
        Me.ColumnHeader8.Width = 148
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Медицинская карта"
        Me.ColumnHeader9.Width = 119
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Дата"
        Me.ColumnHeader10.Width = 69
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Диагноз"
        Me.ColumnHeader11.Width = 172
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.Location = New System.Drawing.Point(296, 184)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(131, 27)
        Me.ButtonAddStudent.TabIndex = 11
        Me.ButtonAddStudent.Text = "Добавить студента"
        Me.ButtonAddStudent.UseVisualStyleBackColor = True
        '
        'ButtonDeleteStudent
        '
        Me.ButtonDeleteStudent.Location = New System.Drawing.Point(433, 184)
        Me.ButtonDeleteStudent.Name = "ButtonDeleteStudent"
        Me.ButtonDeleteStudent.Size = New System.Drawing.Size(131, 27)
        Me.ButtonDeleteStudent.TabIndex = 12
        Me.ButtonDeleteStudent.Text = "Удалить студента"
        Me.ButtonDeleteStudent.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter = Me.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter = Nothing
        Me.TableAdapterManager.GRUPPATableAdapter = Nothing
        Me.TableAdapterManager.MedCardTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ABSENTEEISM_DUE_TO_ILLNESSTableAdapter
        '
        Me.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter.ClearBeforeFill = True
        '
        'MEDICAL_CARDTableAdapter
        '
        Me.MEDICAL_CARDTableAdapter.ClearBeforeFill = True
        '
        'MEDICAL_ORGANIZATIONTableAdapter
        '
        Me.MEDICAL_ORGANIZATIONTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 91)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск и фильтрация"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(440, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(124, 20)
        Me.TextBox2.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(189, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(116, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ФИО"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Медицинская карта"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Дата"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Диагноз"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 20)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Очистить фильтр"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewPropuskiPoBolezni)
        Me.GroupBox2.Controls.Add(Me.ButtonDeleteStudent)
        Me.GroupBox2.Controls.Add(Me.ButtonAddStudent)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 223)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Список документов"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(311, 31)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox2.TabIndex = 22
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 337)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form6"
        Me.Text = "Документ. Пропуски занятий по болезни"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewPropuskiPoBolezni As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents ButtonDeleteStudent As Button
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ABSENTEEISM_DUE_TO_ILLNESSTableAdapter As baseDataSetTableAdapters.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter
    Friend WithEvents MEDICAL_CARDTableAdapter As baseDataSetTableAdapters.MEDICAL_CARDTableAdapter
    Friend WithEvents MEDICAL_ORGANIZATIONTableAdapter As baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
