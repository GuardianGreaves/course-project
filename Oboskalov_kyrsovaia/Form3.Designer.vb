<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.ListViewOrganization = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonAddOrganization = New System.Windows.Forms.Button()
        Me.ButtonDeleteOrganization = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxAddressOrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BaseDataSet = New Oboskalov_kyrsovaia.baseDataSet()
        Me.MEDICAL_ORGANIZATIONTableAdapter = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter()
        Me.TableAdapterManager = New Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ИзменитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewOrganization
        '
        Me.ListViewOrganization.CheckBoxes = True
        Me.ListViewOrganization.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewOrganization.FullRowSelect = True
        Me.ListViewOrganization.GridLines = True
        Me.ListViewOrganization.HideSelection = False
        Me.ListViewOrganization.Location = New System.Drawing.Point(9, 14)
        Me.ListViewOrganization.Name = "ListViewOrganization"
        Me.ListViewOrganization.Size = New System.Drawing.Size(309, 138)
        Me.ListViewOrganization.TabIndex = 0
        Me.ListViewOrganization.UseCompatibleStateImageBehavior = False
        Me.ListViewOrganization.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 20
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Название организации"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Адрес"
        Me.ColumnHeader3.Width = 130
        '
        'ButtonAddOrganization
        '
        Me.ButtonAddOrganization.Location = New System.Drawing.Point(9, 158)
        Me.ButtonAddOrganization.Name = "ButtonAddOrganization"
        Me.ButtonAddOrganization.Size = New System.Drawing.Size(151, 23)
        Me.ButtonAddOrganization.TabIndex = 1
        Me.ButtonAddOrganization.Text = "Добавить организацию"
        Me.ButtonAddOrganization.UseVisualStyleBackColor = True
        '
        'ButtonDeleteOrganization
        '
        Me.ButtonDeleteOrganization.Location = New System.Drawing.Point(167, 158)
        Me.ButtonDeleteOrganization.Name = "ButtonDeleteOrganization"
        Me.ButtonDeleteOrganization.Size = New System.Drawing.Size(151, 23)
        Me.ButtonDeleteOrganization.TabIndex = 2
        Me.ButtonDeleteOrganization.Text = "Удалить организацию"
        Me.ButtonDeleteOrganization.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBoxAddressOrg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 86)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск и фильтрация"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 20)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Очитить фильтр"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxAddressOrg
        '
        Me.TextBoxAddressOrg.Location = New System.Drawing.Point(167, 32)
        Me.TextBoxAddressOrg.Name = "TextBoxAddressOrg"
        Me.TextBoxAddressOrg.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxAddressOrg.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Адрес"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(9, 32)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxName.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Название организации"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewOrganization)
        Me.GroupBox2.Controls.Add(Me.ButtonDeleteOrganization)
        Me.GroupBox2.Controls.Add(Me.ButtonAddOrganization)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 188)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Список организаций"
        '
        'BaseDataSet
        '
        Me.BaseDataSet.CaseSensitive = True
        Me.BaseDataSet.DataSetName = "baseDataSet"
        Me.BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICAL_ORGANIZATIONTableAdapter
        '
        Me.MEDICAL_ORGANIZATIONTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.STUDENTTableAdapter = Nothing
        Me.TableAdapterManager.SURVEYSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oboskalov_kyrsovaia.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзменитьToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 26)
        '
        'ИзменитьToolStripMenuItem
        '
        Me.ИзменитьToolStripMenuItem.Name = "ИзменитьToolStripMenuItem"
        Me.ИзменитьToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ИзменитьToolStripMenuItem.Text = "Изменить"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 298)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form3"
        Me.Text = "Медицинские организации"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.BaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewOrganization As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BaseDataSet As baseDataSet
    Friend WithEvents MEDICAL_ORGANIZATIONTableAdapter As baseDataSetTableAdapters.MEDICAL_ORGANIZATIONTableAdapter
    Friend WithEvents TableAdapterManager As baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ButtonAddOrganization As Button
    Friend WithEvents ButtonDeleteOrganization As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxAddressOrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ИзменитьToolStripMenuItem As ToolStripMenuItem
End Class
