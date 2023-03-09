Partial Class baseDataSet
    Partial Public Class SURVEYSDataTable
        Private Sub SURVEYSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ID_documentColumn.ColumnName) Then
                'Добавьте здесь пользовательский код
            End If

        End Sub

    End Class
End Class

Namespace baseDataSetTableAdapters
    Partial Public Class SURVEYSTableAdapter
    End Class
End Namespace

Namespace baseDataSetTableAdapters
    Partial Public Class SURVEYSTableAdapter
    End Class
End Namespace
