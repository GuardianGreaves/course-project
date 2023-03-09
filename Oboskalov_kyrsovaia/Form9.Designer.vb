<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
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
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.MEDICAL_ORGANIZATIONTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter()
        Me.SURVEYSTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.SURVEYSTableAdapter()
        Me.SURVEYSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SURVEYSDataGridView = New System.Windows.Forms.DataGridView()
        Me.STUDENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICAL_ORGANIZATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICAL_CARDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICAL_CARDTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_CARDTableAdapter()
        Me.MEDICALCARDSURVEYSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICALCARDSURVEYSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENTSURVEYSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDataSet1 = New Oboskalov_kyrsovaia.baseDataSet()
        Me.BaseDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SURVEYSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SURVEYSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAL_ORGANIZATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAL_CARDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICALCARDSURVEYSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICALCARDSURVEYSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTSURVEYSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.GRUPPATableAdapter = Nothing
        Me.TableAdapterManager.MedCardTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Me.MEDICAL_ORGANIZATIONTableAdapter
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Me.SURVEYSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICAL_ORGANIZATIONTableAdapter
        '
        Me.MEDICAL_ORGANIZATIONTableAdapter.ClearBeforeFill = True
        '
        'SURVEYSTableAdapter
        '
        Me.SURVEYSTableAdapter.ClearBeforeFill = True
        '
        'SURVEYSBindingSource
        '
        Me.SURVEYSBindingSource.DataMember = "SURVEYS"
        Me.SURVEYSBindingSource.DataSource = Me.BaseDataSet
        '
        'SURVEYSDataGridView
        '
        Me.SURVEYSDataGridView.AutoGenerateColumns = False
        Me.SURVEYSDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SURVEYSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SURVEYSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2})
        Me.SURVEYSDataGridView.DataSource = Me.SURVEYSBindingSource
        Me.SURVEYSDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.SURVEYSDataGridView.Name = "SURVEYSDataGridView"
        Me.SURVEYSDataGridView.Size = New System.Drawing.Size(980, 220)
        Me.SURVEYSDataGridView.TabIndex = 1
        '
        'STUDENTBindingSource
        '
        Me.STUDENTBindingSource.DataMember = "STUDENT"
        Me.STUDENTBindingSource.DataSource = Me.BaseDataSet
        '
        'MEDICAL_ORGANIZATIONBindingSource
        '
        Me.MEDICAL_ORGANIZATIONBindingSource.DataMember = "MEDICAL_ORGANIZATION"
        Me.MEDICAL_ORGANIZATIONBindingSource.DataSource = Me.BaseDataSet
        '
        'MEDICAL_CARDBindingSource
        '
        Me.MEDICAL_CARDBindingSource.DataMember = "MEDICAL_CARD"
        Me.MEDICAL_CARDBindingSource.DataSource = Me.BaseDataSet
        '
        'MEDICAL_CARDTableAdapter
        '
        Me.MEDICAL_CARDTableAdapter.ClearBeforeFill = True
        '
        'MEDICALCARDSURVEYSBindingSource
        '
        Me.MEDICALCARDSURVEYSBindingSource.DataMember = "MEDICAL_CARDSURVEYS"
        Me.MEDICALCARDSURVEYSBindingSource.DataSource = Me.MEDICAL_CARDBindingSource
        '
        'MEDICALCARDSURVEYSBindingSource1
        '
        Me.MEDICALCARDSURVEYSBindingSource1.DataMember = "MEDICAL_CARDSURVEYS"
        Me.MEDICALCARDSURVEYSBindingSource1.DataSource = Me.MEDICAL_CARDBindingSource
        '
        'STUDENTSURVEYSBindingSource
        '
        Me.STUDENTSURVEYSBindingSource.DataMember = "STUDENTSURVEYS"
        Me.STUDENTSURVEYSBindingSource.DataSource = Me.STUDENTBindingSource
        '
        'BaseDataSet1
        '
        Me.BaseDataSet1.CaseSensitive = True
        Me.BaseDataSet1.DataSetName = "baseDataSet"
        Me.BaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BaseDataSet1BindingSource
        '
        Me.BaseDataSet1BindingSource.DataSource = Me.BaseDataSet1
        Me.BaseDataSet1BindingSource.Position = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name_document"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name_document"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_document"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_document"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID_student"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.STUDENTBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "FIO_student"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID_student"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "ID_student"
        Me.DataGridViewTextBoxColumn5.Width = 156
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_organization"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.MEDICAL_ORGANIZATIONBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "name_organization"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_organization"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "ID_organization"
        Me.DataGridViewTextBoxColumn6.Width = 155
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_card"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_card"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.Width = 156
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Examination"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Examination"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 156
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 155
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Result"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Result"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 156
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(861, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 27)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Сохранить и обновить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 488)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SURVEYSDataGridView)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SURVEYSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SURVEYSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAL_ORGANIZATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAL_CARDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICALCARDSURVEYSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICALCARDSURVEYSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTSURVEYSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SURVEYSTableAdapter As baseDataSetTableAdapters.SURVEYSTableAdapter
    Friend WithEvents MEDICAL_ORGANIZATIONTableAdapter As baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter
    Friend WithEvents SURVEYSBindingSource As BindingSource
    Friend WithEvents SURVEYSDataGridView As DataGridView
    Friend WithEvents STUDENTBindingSource As BindingSource
    Friend WithEvents MEDICAL_ORGANIZATIONBindingSource As BindingSource
    Friend WithEvents MEDICAL_CARDBindingSource As BindingSource
    Friend WithEvents MEDICAL_CARDTableAdapter As baseDataSetTableAdapters.MEDICAL_CARDTableAdapter
    Friend WithEvents MEDICALCARDSURVEYSBindingSource As BindingSource
    Friend WithEvents MEDICALCARDSURVEYSBindingSource1 As BindingSource
    Friend WithEvents STUDENTSURVEYSBindingSource As BindingSource
    Friend WithEvents BaseDataSet1 As baseDataSet
    Friend WithEvents BaseDataSet1BindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class
