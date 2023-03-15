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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDeleteMedCard
        '
        Me.ButtonDeleteMedCard.Location = New System.Drawing.Point(234, 189)
        Me.ButtonDeleteMedCard.Name = "ButtonDeleteMedCard"
        Me.ButtonDeleteMedCard.Size = New System.Drawing.Size(129, 23)
        Me.ButtonDeleteMedCard.TabIndex = 5
        Me.ButtonDeleteMedCard.Text = "Удалить карту"
        Me.ButtonDeleteMedCard.UseVisualStyleBackColor = True
        '
        'ButtonAddMedCard
        '
        Me.ButtonAddMedCard.Location = New System.Drawing.Point(99, 189)
        Me.ButtonAddMedCard.Name = "ButtonAddMedCard"
        Me.ButtonAddMedCard.Size = New System.Drawing.Size(129, 23)
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
        Me.ListViewMedCard.Location = New System.Drawing.Point(9, 19)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 63)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск и фильтрация"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 20)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Очистить фильтр"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ФИО студента"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewMedCard)
        Me.GroupBox2.Controls.Add(Me.ButtonDeleteMedCard)
        Me.GroupBox2.Controls.Add(Me.ButtonAddMedCard)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 222)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Список медицинских карточек"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 309)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Медицинские карты"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
