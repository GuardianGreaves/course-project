<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.ButtonDeleteStudPropusc = New System.Windows.Forms.Button()
        Me.ButtonAddStudPropusc = New System.Windows.Forms.Button()
        Me.ListViewStudPropusci = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.STUDENTTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.STUDENTTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.GRUPPATableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.GRUPPATableAdapter()
        Me.RESPONIBLE_FOR_PASSESTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.RESPONIBLE_FOR_PASSESTableAdapter()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDeleteStudPropusc
        '
        Me.ButtonDeleteStudPropusc.Location = New System.Drawing.Point(170, 219)
        Me.ButtonDeleteStudPropusc.Name = "ButtonDeleteStudPropusc"
        Me.ButtonDeleteStudPropusc.Size = New System.Drawing.Size(151, 23)
        Me.ButtonDeleteStudPropusc.TabIndex = 5
        Me.ButtonDeleteStudPropusc.Text = "Удалить студента"
        Me.ButtonDeleteStudPropusc.UseVisualStyleBackColor = True
        '
        'ButtonAddStudPropusc
        '
        Me.ButtonAddStudPropusc.Location = New System.Drawing.Point(12, 219)
        Me.ButtonAddStudPropusc.Name = "ButtonAddStudPropusc"
        Me.ButtonAddStudPropusc.Size = New System.Drawing.Size(151, 23)
        Me.ButtonAddStudPropusc.TabIndex = 4
        Me.ButtonAddStudPropusc.Text = "Добавить студента"
        Me.ButtonAddStudPropusc.UseVisualStyleBackColor = True
        '
        'ListViewStudPropusci
        '
        Me.ListViewStudPropusci.CheckBoxes = True
        Me.ListViewStudPropusci.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewStudPropusci.GridLines = True
        Me.ListViewStudPropusci.HideSelection = False
        Me.ListViewStudPropusci.Location = New System.Drawing.Point(12, 12)
        Me.ListViewStudPropusci.Name = "ListViewStudPropusci"
        Me.ListViewStudPropusci.Size = New System.Drawing.Size(309, 201)
        Me.ListViewStudPropusci.TabIndex = 3
        Me.ListViewStudPropusci.UseCompatibleStateImageBehavior = False
        Me.ListViewStudPropusci.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ФИО студента"
        Me.ColumnHeader4.Width = 244
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Группа"
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
        Me.TableAdapterManager.MEDICAL_CARDTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_DOCUMENTTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAL_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.PREVENTIVE_VACCINATIONSTableAdapter = Nothing
        Me.TableAdapterManager.RESPONIBLE_FOR_PASSESTableAdapter = Me.RESPONIBLE_FOR_PASSESTableAdapter
        Me.TableAdapterManager.STUDENTTableAdapter = Me.STUDENTTableAdapter
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GRUPPATableAdapter
        '
        Me.GRUPPATableAdapter.ClearBeforeFill = True
        '
        'RESPONIBLE_FOR_PASSESTableAdapter
        '
        Me.RESPONIBLE_FOR_PASSESTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 536)
        Me.Controls.Add(Me.ButtonDeleteStudPropusc)
        Me.Controls.Add(Me.ButtonAddStudPropusc)
        Me.Controls.Add(Me.ListViewStudPropusci)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonDeleteStudPropusc As Button
    Friend WithEvents ButtonAddStudPropusc As Button
    Friend WithEvents ListViewStudPropusci As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents STUDENTTableAdapter As baseDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GRUPPATableAdapter As baseDataSetTableAdapters.GRUPPATableAdapter
    Friend WithEvents RESPONIBLE_FOR_PASSESTableAdapter As baseDataSetTableAdapters.RESPONIBLE_FOR_PASSESTableAdapter
End Class
