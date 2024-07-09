Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DataGridView with columns
        DataGridView1.Columns.Add("Column4", "GENRE")
        DataGridView1.Columns.Add("Column3", "YEAR PUPLISHED")
        DataGridView1.Columns.Add("Column2", "AUTHOR")
        DataGridView1.Columns.Add("Column1", "TITLE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add new row to DataGridView
        If Not String.IsNullOrEmpty(TextBox1.Text) AndAlso Not String.IsNullOrEmpty(TextBox2.Text) AndAlso Not String.IsNullOrEmpty(TextBox3.Text) AndAlso Not String.IsNullOrEmpty(TextBox4.Text) Then
            DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
            ClearTextBoxes()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Update selected row in DataGridView
        If DataGridView1.SelectedRows.Count > 0 AndAlso Not String.IsNullOrEmpty(TextBox1.Text) AndAlso Not String.IsNullOrEmpty(TextBox2.Text) AndAlso Not String.IsNullOrEmpty(TextBox3.Text) AndAlso Not String.IsNullOrEmpty(TextBox4.Text) Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells("Column1").Value = TextBox1.Text
            selectedRow.Cells("Column2").Value = TextBox2.Text
            selectedRow.Cells("Column3").Value = TextBox3.Text
            selectedRow.Cells("Column4").Value = TextBox4.Text
            ClearTextBoxes()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Delete selected row from DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Clear all rows from DataGridView
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Display cell content in message box
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim clickedCellContent As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            MessageBox.Show(clickedCellContent)
        End If
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear text boxes
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
End Class
