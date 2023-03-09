<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.ButtonDeleteMedCard = New System.Windows.Forms.Button()
        Me.ButtonAddMedCard = New System.Windows.Forms.Button()
        Me.ListViewMedCard = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.MEDICAL_CARDTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_CARDTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDeleteMedCard
        '
        Me.ButtonDeleteMedCard.Location = New System.Drawing.Point(215, 182)
        Me.ButtonDeleteMedCard.Name = "ButtonDeleteMedCard"
        Me.ButtonDeleteMedCard.Size = New System.Drawing.Size(151, 23)
        Me.ButtonDeleteMedCard.TabIndex = 5
        Me.ButtonDeleteMedCard.Text = "Удалить карту"
        Me.ButtonDeleteMedCard.UseVisualStyleBackColor = True
        '
        'ButtonAddMedCard
        '
        Me.ButtonAddMedCard.Location = New System.Drawing.Point(58, 182)
        Me.ButtonAddMedCard.Name = "ButtonAddMedCard"
        Me.ButtonAddMedCard.Size = New System.Drawing.Size(151, 23)
        Me.ButtonAddMedCard.TabIndex = 4
        Me.ButtonAddMedCard.Text = "Добавить карту"
        Me.ButtonAddMedCard.UseVisualStyleBackColor = True
        '
        'ListViewMedCard
        '
        Me.ListViewMedCard.CheckBoxes = True
        Me.ListViewMedCard.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListViewMedCard.GridLines = True
        Me.ListViewMedCard.HideSelection = False
        Me.ListViewMedCard.Location = New System.Drawing.Point(12, 12)
        Me.ListViewMedCard.Name = "ListViewMedCard"
        Me.ListViewMedCard.Size = New System.Drawing.Size(354, 164)
        Me.ListViewMedCard.TabIndex = 3
        Me.ListViewMedCard.UseCompatibleStateImageBehavior = False
        Me.ListViewMedCard.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Медицинскя карточка"
        Me.ColumnHeader1.Width = 127
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Студент"
        Me.ColumnHeader2.Width = 222
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
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 218)
        Me.Controls.Add(Me.ButtonDeleteMedCard)
        Me.Controls.Add(Me.ButtonAddMedCard)
        Me.Controls.Add(Me.ListViewMedCard)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonDeleteMedCard As Button
    Friend WithEvents ButtonAddMedCard As Button
    Friend WithEvents ListViewMedCard As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents MEDICAL_CARDTableAdapter As baseDataSetTableAdapters.MEDICAL_CARDTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
End Class
