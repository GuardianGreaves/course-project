<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Me.ListViewDocObsledovanie = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonAddDocObsledovanie = New System.Windows.Forms.Button()
        Me.ButtonDeleteDocObsledovanie = New System.Windows.Forms.Button()
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.MEDICAL_CARDTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_CARDTableAdapter()
        Me.MEDICAL_ORGANIZATIONTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter()
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewDocObsledovanie
        '
        Me.ListViewDocObsledovanie.CheckBoxes = True
        Me.ListViewDocObsledovanie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListViewDocObsledovanie.FullRowSelect = True
        Me.ListViewDocObsledovanie.GridLines = True
        Me.ListViewDocObsledovanie.HideSelection = False
        Me.ListViewDocObsledovanie.Location = New System.Drawing.Point(12, 12)
        Me.ListViewDocObsledovanie.MultiSelect = False
        Me.ListViewDocObsledovanie.Name = "ListViewDocObsledovanie"
        Me.ListViewDocObsledovanie.Size = New System.Drawing.Size(768, 159)
        Me.ListViewDocObsledovanie.TabIndex = 1
        Me.ListViewDocObsledovanie.UseCompatibleStateImageBehavior = False
        Me.ListViewDocObsledovanie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 23
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ФИО студента"
        Me.ColumnHeader8.Width = 141
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Организация"
        Me.ColumnHeader9.Width = 98
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Медицинская карта"
        Me.ColumnHeader10.Width = 113
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Обследование"
        Me.ColumnHeader11.Width = 104
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Дата"
        Me.ColumnHeader12.Width = 70
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Результат обследования"
        Me.ColumnHeader13.Width = 215
        '
        'ButtonAddDocObsledovanie
        '
        Me.ButtonAddDocObsledovanie.Location = New System.Drawing.Point(512, 177)
        Me.ButtonAddDocObsledovanie.Name = "ButtonAddDocObsledovanie"
        Me.ButtonAddDocObsledovanie.Size = New System.Drawing.Size(131, 27)
        Me.ButtonAddDocObsledovanie.TabIndex = 11
        Me.ButtonAddDocObsledovanie.Text = "Добавить документ"
        Me.ButtonAddDocObsledovanie.UseVisualStyleBackColor = True
        '
        'ButtonDeleteDocObsledovanie
        '
        Me.ButtonDeleteDocObsledovanie.Location = New System.Drawing.Point(649, 177)
        Me.ButtonDeleteDocObsledovanie.Name = "ButtonDeleteDocObsledovanie"
        Me.ButtonDeleteDocObsledovanie.Size = New System.Drawing.Size(131, 27)
        Me.ButtonDeleteDocObsledovanie.TabIndex = 12
        Me.ButtonDeleteDocObsledovanie.Text = "Удалить документ"
        Me.ButtonDeleteDocObsledovanie.UseVisualStyleBackColor = True
        '
        'BaseDataSet
        '
        Me.BaseDataSet.CaseSensitive = True
        Me.BaseDataSet.DataSetName = "baseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DATE_OF_MEDICAL_EXAMINATIONSTableAdapter
        '
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter
        Me.TableAdapterManager.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter = Nothing
        Me.TableAdapterManager.GRUPPATableAdapter = Nothing
        Me.TableAdapterManager.MedCardTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Me.MEDICAL_CARDTableAdapter
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Me.MEDICAL_ORGANIZATIONTableAdapter
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICAL_CARDTableAdapter
        '
        Me.MEDICAL_CARDTableAdapter.ClearBeforeFill = True
        '
        'MEDICAL_ORGANIZATIONTableAdapter
        '
        Me.MEDICAL_ORGANIZATIONTableAdapter.ClearBeforeFill = True
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 297)
        Me.Controls.Add(Me.ButtonAddDocObsledovanie)
        Me.Controls.Add(Me.ButtonDeleteDocObsledovanie)
        Me.Controls.Add(Me.ListViewDocObsledovanie)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewDocObsledovanie As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ButtonAddDocObsledovanie As Button
    Friend WithEvents ButtonDeleteDocObsledovanie As Button
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents DATE_OF_MEDICAL_EXAMINATIONSTableAdapter As baseDataSetTableAdapters.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents MEDICAL_ORGANIZATIONTableAdapter As baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter
    Friend WithEvents MEDICAL_CARDTableAdapter As baseDataSetTableAdapters.MEDICAL_CARDTableAdapter
End Class
