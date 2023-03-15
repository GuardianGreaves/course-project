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
        Me.components = New System.ComponentModel.Container()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ИзменитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDeleteStudPropusc
        '
        Me.ButtonDeleteStudPropusc.Location = New System.Drawing.Point(164, 226)
        Me.ButtonDeleteStudPropusc.Name = "ButtonDeleteStudPropusc"
        Me.ButtonDeleteStudPropusc.Size = New System.Drawing.Size(151, 23)
        Me.ButtonDeleteStudPropusc.TabIndex = 5
        Me.ButtonDeleteStudPropusc.Text = "Удалить студента"
        Me.ButtonDeleteStudPropusc.UseVisualStyleBackColor = True
        '
        'ButtonAddStudPropusc
        '
        Me.ButtonAddStudPropusc.Location = New System.Drawing.Point(6, 226)
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
        Me.ListViewStudPropusci.FullRowSelect = True
        Me.ListViewStudPropusci.GridLines = True
        Me.ListViewStudPropusci.HideSelection = False
        Me.ListViewStudPropusci.Location = New System.Drawing.Point(6, 19)
        Me.ListViewStudPropusci.Name = "ListViewStudPropusci"
        Me.ListViewStudPropusci.RightToLeftLayout = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 91)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск и фильтрация"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewStudPropusci)
        Me.GroupBox2.Controls.Add(Me.ButtonAddStudPropusc)
        Me.GroupBox2.Controls.Add(Me.ButtonDeleteStudPropusc)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 258)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Список ответственных за пропуски"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Очистить фильтр"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ФИО"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Группа"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(164, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзменитьToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        'ИзменитьToolStripMenuItem
        '
        Me.ИзменитьToolStripMenuItem.Name = "ИзменитьToolStripMenuItem"
        Me.ИзменитьToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ИзменитьToolStripMenuItem.Text = "Изменить"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 372)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form5"
        Me.Text = "Ответственные за пропуски"
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ИзменитьToolStripMenuItem As ToolStripMenuItem
End Class
