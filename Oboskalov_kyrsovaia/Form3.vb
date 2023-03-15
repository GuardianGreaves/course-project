Public Class Form3
    Public LastSelectedItemForm3 As ListViewItem
    Dim LastSelectedItem2Form3 As ListViewItem
    Dim strFIOForm3 As String
    Dim strAdressForm3 As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        organization()
    End Sub

    Public Sub organization()
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(Me.BaseDataSet.MEDICAL_ORGANIZATION)

        ListViewOrganization.Items.Clear()
        Dim items(3) As String
        For Each Row As DataRow In
                Me.BaseDataSet.MEDICAL_ORGANIZATION.Rows
            items(1) = Row(0)
            items(2) = Row(2)
            Dim it As New ListViewItem()
            it.Text = Row(1)
            it.SubItems.AddRange(items)
            ListViewOrganization.Items.Add(it)
        Next Row
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAddOrganization.Click
        With Dialog3
            .Text = "Добавление документа. Осмотры перед прививками и после прививок"
            .AddOrChangeDialog3 = False
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                organization()
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonDeleteOrganization.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In ListViewOrganization.CheckedItems
            Rows = BaseDataSet.MEDICAL_ORGANIZATION.Select("ID_organization ='" & item.Text & "'")
            MEDICAL_ORGANIZATIONTableAdapter.Delete(Rows(0)(1), Rows(0)(2))
            item.Remove()
        Next item
        Me.MEDICAL_ORGANIZATIONTableAdapter.Fill(BaseDataSet.MEDICAL_ORGANIZATION)
    End Sub

    Private Sub TextBoxFIO_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged
        ListViewOrganization.Items.Clear()
        Dim items(3) As String
        If TextBoxName.Text = vbNullChar Then
            TextBoxName.Text = ""
        End If
        strFIOForm3 = TextBoxName.Text

        For Each Row As DataRow In Me.BaseDataSet.
        MEDICAL_ORGANIZATION.Select("name_organization Like'%" & strFIOForm3 & "*'")
            items(1) = Row(0)
            items(2) = Row(2)
            Dim it As New ListViewItem()
            it.Text = Row(1)
            it.SubItems.AddRange(items)
            ListViewOrganization.Items.Add(it)
        Next Row
    End Sub

    Private Sub TextBoxAddressStudent_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAddressOrg.TextChanged
        ListViewOrganization.Items.Clear()
        Dim items(3) As String
        If TextBoxAddressOrg.Text = vbNullChar Then
            TextBoxAddressOrg.Text = ""
        End If
        strAdressForm3 = TextBoxAddressOrg.Text

        For Each Row As DataRow In Me.BaseDataSet.
        MEDICAL_ORGANIZATION.Select("adres Like'%" & strAdressForm3 & "*'")
            items(1) = Row(0)
            items(2) = Row(2)
            Dim it As New ListViewItem()
            it.Text = Row(1)
            it.SubItems.AddRange(items)
            ListViewOrganization.Items.Add(it)
        Next Row
    End Sub

    Private Sub ListViewOrganization_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListViewOrganization.ItemSelectionChanged
        LastSelectedItemForm3 = e.Item
        LastSelectedItem2Form3 = e.Item
    End Sub
    Private Sub ListViewOrganization_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewOrganization.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(sender, e.X, e.Y)
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxAddressOrg.Clear()
        TextBoxName.Clear()
    End Sub

    Private Sub ИзменитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзменитьToolStripMenuItem.Click
        With Dialog3
            .Text = "Редактирование организации"
            Dim CurrentWorkerRow As DataRow = BaseDataSet.MEDICAL_ORGANIZATION.Select("ID_organization ='" & LastSelectedItemForm3.Text & "'")(0)
            .OldRowIdDialog3 = CurrentWorkerRow("ID_organization")
            .AddOrChangeDialog3 = True
            .TextBoxNameOrganization.Text = CurrentWorkerRow("name_organization")
            .TextBoxAdresOrganization.Text = CurrentWorkerRow("adres")
            .ShowDialog()
            If DialogResult = DialogResult.OK Then
                organization()
            End If
        End With
    End Sub




End Class