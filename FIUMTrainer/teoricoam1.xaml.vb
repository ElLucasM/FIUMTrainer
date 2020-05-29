Class teoricoam1
    Private Sub treeView_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles treeView.MouseDoubleClick
        Select Case treeView.SelectedItem.Header
            Case "Definidas"
                webBrowser1.Navigate(New Uri("C:\Users\Lucas J. Melogno\source\repos\FIUMTrainer\FIUMTrainer\Resources\definidas.xps"))
            Case "Impropias"
                webBrowser1.Navigate(New Uri("C:\Users\Lucas J. Melogno\source\repos\FIUMTrainer\FIUMTrainer\Resources\impropias.xps"))
        End Select
    End Sub
End Class
