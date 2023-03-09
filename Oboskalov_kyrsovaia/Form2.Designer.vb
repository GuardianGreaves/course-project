<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonAddGroup = New System.Windows.Forms.Button()
        Me.ButtonDeleteGroup = New System.Windows.Forms.Button()
        Me.ListViewGroup = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonGroupDate = New System.Windows.Forms.Button()
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.GRUPPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GRUPPATableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.GRUPPATableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRUPPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 63)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Поиск и фильтрация"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Дата зачисления"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Кол-во студентов"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Группа"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonAddGroup)
        Me.GroupBox1.Controls.Add(Me.ButtonDeleteGroup)
        Me.GroupBox1.Controls.Add(Me.ListViewGroup)
        Me.GroupBox1.Controls.Add(Me.ButtonGroupDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 216)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Список групп"
        '
        'ButtonAddGroup
        '
        Me.ButtonAddGroup.Location = New System.Drawing.Point(157, 184)
        Me.ButtonAddGroup.Name = "ButtonAddGroup"
        Me.ButtonAddGroup.Size = New System.Drawing.Size(102, 23)
        Me.ButtonAddGroup.TabIndex = 3
        Me.ButtonAddGroup.Text = "Добавить группу"
        Me.ButtonAddGroup.UseVisualStyleBackColor = True
        '
        'ButtonDeleteGroup
        '
        Me.ButtonDeleteGroup.Location = New System.Drawing.Point(265, 184)
        Me.ButtonDeleteGroup.Name = "ButtonDeleteGroup"
        Me.ButtonDeleteGroup.Size = New System.Drawing.Size(98, 23)
        Me.ButtonDeleteGroup.TabIndex = 4
        Me.ButtonDeleteGroup.Text = "Удалить группу"
        Me.ButtonDeleteGroup.UseVisualStyleBackColor = True
        '
        'ListViewGroup
        '
        Me.ListViewGroup.CheckBoxes = True
        Me.ListViewGroup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader1, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListViewGroup.FullRowSelect = True
        Me.ListViewGroup.GridLines = True
        Me.ListViewGroup.HideSelection = False
        Me.ListViewGroup.Location = New System.Drawing.Point(6, 19)
        Me.ListViewGroup.MultiSelect = False
        Me.ListViewGroup.Name = "ListViewGroup"
        Me.ListViewGroup.Size = New System.Drawing.Size(357, 159)
        Me.ListViewGroup.TabIndex = 1
        Me.ListViewGroup.UseCompatibleStateImageBehavior = False
        Me.ListViewGroup.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = ""
        Me.ColumnHeader9.Width = 23
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Название группы"
        Me.ColumnHeader1.Width = 103
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Дата зачисления"
        Me.ColumnHeader10.Width = 101
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Количество студентов"
        Me.ColumnHeader11.Width = 125
        '
        'ButtonGroupDate
        '
        Me.ButtonGroupDate.Location = New System.Drawing.Point(6, 184)
        Me.ButtonGroupDate.Name = "ButtonGroupDate"
        Me.ButtonGroupDate.Size = New System.Drawing.Size(102, 23)
        Me.ButtonGroupDate.TabIndex = 2
        Me.ButtonGroupDate.Text = "Студенты группы"
        Me.ButtonGroupDate.UseVisualStyleBackColor = True
        '
        'BaseDataSet
        '
        Me.BaseDataSet.DataSetName = "baseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GRUPPABindingSource
        '
        Me.GRUPPABindingSource.DataMember = "GRUPPA"
        Me.GRUPPABindingSource.DataSource = Me.BaseDataSet
        '
        'GRUPPATableAdapter
        '
        Me.GRUPPATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter = Nothing
        Me.TableAdapterManager.GRUPPATableAdapter = Me.GRUPPATableAdapter
        Me.TableAdapterManager.MedCardTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Nothing
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 303)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Группы"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRUPPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonAddGroup As Button
    Friend WithEvents ButtonDeleteGroup As Button
    Friend WithEvents ListViewGroup As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ButtonGroupDate As Button
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents GRUPPABindingSource As BindingSource
    Friend WithEvents GRUPPATableAdapter As baseDataSetTableAdapters.GRUPPATableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
End Class
