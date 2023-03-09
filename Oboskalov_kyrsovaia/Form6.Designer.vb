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
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewPropuskiPoBolezni
        '
        Me.ListViewPropuskiPoBolezni.CheckBoxes = True
        Me.ListViewPropuskiPoBolezni.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListViewPropuskiPoBolezni.FullRowSelect = True
        Me.ListViewPropuskiPoBolezni.GridLines = True
        Me.ListViewPropuskiPoBolezni.HideSelection = False
        Me.ListViewPropuskiPoBolezni.Location = New System.Drawing.Point(12, 12)
        Me.ListViewPropuskiPoBolezni.MultiSelect = False
        Me.ListViewPropuskiPoBolezni.Name = "ListViewPropuskiPoBolezni"
        Me.ListViewPropuskiPoBolezni.Size = New System.Drawing.Size(535, 159)
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
        Me.ButtonAddStudent.Location = New System.Drawing.Point(277, 177)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(131, 27)
        Me.ButtonAddStudent.TabIndex = 11
        Me.ButtonAddStudent.Text = "Добавить студента"
        Me.ButtonAddStudent.UseVisualStyleBackColor = True
        '
        'ButtonDeleteStudent
        '
        Me.ButtonDeleteStudent.Location = New System.Drawing.Point(414, 177)
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
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 209)
        Me.Controls.Add(Me.ButtonAddStudent)
        Me.Controls.Add(Me.ButtonDeleteStudent)
        Me.Controls.Add(Me.ListViewPropuskiPoBolezni)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
