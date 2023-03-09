<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.MEDICAL_ORGANIZATIONTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter()
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView = New System.Windows.Forms.DataGridView()
        Me.DATE_OF_MEDICAL_EXAMINATIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter()
        Me.STUDENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MEDICAL_ORGANIZATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICALORGANIZATIONEXAMINATIONBEFOREAFTERVACCINATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATE_OF_MEDICAL_EXAMINATIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAL_ORGANIZATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICALORGANIZATIONEXAMINATIONBEFOREAFTERVACCINATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseDataSet
        '
        Me.BaseDataSet.CaseSensitive = True
        Me.BaseDataSet.DataSetName = "baseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter
        '
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter = Me.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter
        Me.TableAdapterManager.GRUPPATableAdapter = Nothing
        Me.TableAdapterManager.MedCardTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Me.MEDICAL_ORGANIZATIONTableAdapter
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICAL_ORGANIZATIONTableAdapter
        '
        Me.MEDICAL_ORGANIZATIONTableAdapter.ClearBeforeFill = True
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource
        '
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource.DataMember = "EXAMINATION_BEFORE_AFTER_VACCINATION"
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource.DataSource = Me.BaseDataSet
        '
        'EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView
        '
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.AutoGenerateColumns = False
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.DataSource = Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.Name = "EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView"
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.Size = New System.Drawing.Size(1093, 214)
        Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView.TabIndex = 1
        '
        'DATE_OF_MEDICAL_EXAMINATIONSBindingSource
        '
        Me.DATE_OF_MEDICAL_EXAMINATIONSBindingSource.DataMember = "DATE_OF_MEDICAL_EXAMINATIONS"
        Me.DATE_OF_MEDICAL_EXAMINATIONSBindingSource.DataSource = Me.BaseDataSet
        '
        'DATE_OF_MEDICAL_EXAMINATIONSTableAdapter
        '
        Me.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter.ClearBeforeFill = True
        '
        'STUDENTBindingSource
        '
        Me.STUDENTBindingSource.DataMember = "STUDENT"
        Me.STUDENTBindingSource.DataSource = Me.BaseDataSet
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(974, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 27)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Сохранить и обновить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MEDICAL_ORGANIZATIONBindingSource
        '
        Me.MEDICAL_ORGANIZATIONBindingSource.DataMember = "MEDICAL_ORGANIZATION"
        Me.MEDICAL_ORGANIZATIONBindingSource.DataSource = Me.BaseDataSet
        '
        'MEDICALORGANIZATIONEXAMINATIONBEFOREAFTERVACCINATIONBindingSource
        '
        Me.MEDICALORGANIZATIONEXAMINATIONBEFOREAFTERVACCINATIONBindingSource.DataMember = "MEDICAL_ORGANIZATIONEXAMINATION_BEFORE_AFTER_VACCINATION"
        Me.MEDICALORGANIZATIONEXAMINATIONBEFOREAFTERVACCINATIONBindingSource.DataSource = Me.MEDICAL_ORGANIZATIONBindingSource
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name_document"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name_document"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 113
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_document"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_document"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 96
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_student"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.STUDENTBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "FIO_student"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn3.HeaderText = "ФИО студента"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ID_student"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_organization"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.MEDICAL_ORGANIZATIONBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "name_organization"
        Me.DataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn4.HeaderText = "Организация"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "ID_organization"
        Me.DataGridViewTextBoxColumn4.Width = 95
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID_card"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Медицинская карта"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 128
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Дата"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Body_temperature"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Температура тела"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 114
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Inspection_result"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Результат осмотра"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 119
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "State_after_30_min"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Состояние через 30 мин"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 111
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Vaccine"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Прививка"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 82
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Allowed_or_not_allowed"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Разрешена\не разрешена"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 265)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATE_OF_MEDICAL_EXAMINATIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAL_ORGANIZATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICALORGANIZATIONEXAMINATIONBEFOREAFTERVACCINATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter As baseDataSetTableAdapters.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents MEDICAL_ORGANIZATIONTableAdapter As baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter
    Friend WithEvents EXAMINATION_BEFORE_AFTER_VACCINATIONBindingSource As BindingSource
    Friend WithEvents EXAMINATION_BEFORE_AFTER_VACCINATIONDataGridView As DataGridView
    Friend WithEvents DATE_OF_MEDICAL_EXAMINATIONSBindingSource As BindingSource
    Friend WithEvents DATE_OF_MEDICAL_EXAMINATIONSTableAdapter As baseDataSetTableAdapters.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter
    Friend WithEvents STUDENTBindingSource As BindingSource
    Friend WithEvents Button3 As Button
    Friend WithEvents MEDICAL_ORGANIZATIONBindingSource As BindingSource
    Friend WithEvents MEDICALORGANIZATIONEXAMINATIONBEFOREAFTERVACCINATIONBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
