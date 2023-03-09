<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        Me.ListViewDocProfPrivivki = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonAddDocProfPrivivki = New System.Windows.Forms.Button()
        Me.ButtonDeleteDocProfPrivivki = New System.Windows.Forms.Button()
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.MEDICAL_CARDTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_CARDTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.PREVENTIVE_VACCINATIONSTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.PREVENTIVE_VACCINATIONSTableAdapter()
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        Me.MEDICAL_ORGANIZATIONTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewDocProfPrivivki
        '
        Me.ListViewDocProfPrivivki.CheckBoxes = True
        Me.ListViewDocProfPrivivki.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListViewDocProfPrivivki.FullRowSelect = True
        Me.ListViewDocProfPrivivki.GridLines = True
        Me.ListViewDocProfPrivivki.HideSelection = False
        Me.ListViewDocProfPrivivki.Location = New System.Drawing.Point(12, 12)
        Me.ListViewDocProfPrivivki.MultiSelect = False
        Me.ListViewDocProfPrivivki.Name = "ListViewDocProfPrivivki"
        Me.ListViewDocProfPrivivki.Size = New System.Drawing.Size(658, 159)
        Me.ListViewDocProfPrivivki.TabIndex = 1
        Me.ListViewDocProfPrivivki.UseCompatibleStateImageBehavior = False
        Me.ListViewDocProfPrivivki.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 23
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ФИО студента"
        Me.ColumnHeader2.Width = 186
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Организация"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Медицинская карта"
        Me.ColumnHeader9.Width = 136
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Прививка"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Дата "
        Me.ColumnHeader11.Width = 89
        '
        'ButtonAddDocProfPrivivki
        '
        Me.ButtonAddDocProfPrivivki.Location = New System.Drawing.Point(402, 177)
        Me.ButtonAddDocProfPrivivki.Name = "ButtonAddDocProfPrivivki"
        Me.ButtonAddDocProfPrivivki.Size = New System.Drawing.Size(131, 27)
        Me.ButtonAddDocProfPrivivki.TabIndex = 13
        Me.ButtonAddDocProfPrivivki.Text = "Добавить документ"
        Me.ButtonAddDocProfPrivivki.UseVisualStyleBackColor = True
        '
        'ButtonDeleteDocProfPrivivki
        '
        Me.ButtonDeleteDocProfPrivivki.Location = New System.Drawing.Point(539, 177)
        Me.ButtonDeleteDocProfPrivivki.Name = "ButtonDeleteDocProfPrivivki"
        Me.ButtonDeleteDocProfPrivivki.Size = New System.Drawing.Size(131, 27)
        Me.ButtonDeleteDocProfPrivivki.TabIndex = 14
        Me.ButtonDeleteDocProfPrivivki.Text = "Удалить документ"
        Me.ButtonDeleteDocProfPrivivki.UseVisualStyleBackColor = True
        '
        'BaseDataSet
        '
        Me.BaseDataSet.CaseSensitive = True
        Me.BaseDataSet.DataSetName = "baseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICAL_CARDTableAdapter
        '
        Me.MEDICAL_CARDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ABSENTEEISM_DUE_TO_ILLNESSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DATE_OF_MEDICAL_EXAMINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.EXAMINATION_BEFORE_AFTER_VACCINATIONTableAdapter = Nothing
        Me.TableAdapterManager.GRUPPATableAdapter = Nothing
        Me.TableAdapterManager.MedCardTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Me.MEDICAL_CARDTableAdapter
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Me.MEDICAL_ORGANIZATIONTableAdapter
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Me.PREVENTIVE_VACCINATIONSTableAdapter
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PREVENTIVE_VACCINATIONSTableAdapter
        '
        Me.PREVENTIVE_VACCINATIONSTableAdapter.ClearBeforeFill = True
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'MEDICAL_ORGANIZATIONTableAdapter
        '
        Me.MEDICAL_ORGANIZATIONTableAdapter.ClearBeforeFill = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 214)
        Me.Controls.Add(Me.ButtonAddDocProfPrivivki)
        Me.Controls.Add(Me.ButtonDeleteDocProfPrivivki)
        Me.Controls.Add(Me.ListViewDocProfPrivivki)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewDocProfPrivivki As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ButtonAddDocProfPrivivki As Button
    Friend WithEvents ButtonDeleteDocProfPrivivki As Button
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents MEDICAL_CARDTableAdapter As baseDataSetTableAdapters.MEDICAL_CARDTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PREVENTIVE_VACCINATIONSTableAdapter As baseDataSetTableAdapters.PREVENTIVE_VACCINATIONSTableAdapter
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents MEDICAL_ORGANIZATIONTableAdapter As baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter
End Class
