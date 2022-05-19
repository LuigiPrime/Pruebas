Public Class Info_Listado_Vinos
    Private Sub Info_Listado_Vinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '***************************************************
        'Configuracion de la lista de vinos
        '***************************************************

        ' Set the ListBox to display items in multiple columns.
        ListBox1.MultiColumn = False
        ' Set the selection mode to multiple and extended.
        ListBox1.SelectionMode = SelectionMode.One

        ' Shutdown the painting of the ListBox as items are added.
        ListBox1.BeginUpdate()
        ' Loop through and add X items to the ListBox.
        Dim x As Integer
        For x = 0 To num_vinos_registrados
            'ListBox1.Items.Add("Item " & x.ToString())
            ListBox1.Items.Add(N_Folleto_Marca(x))
        Next x
        ' Allow the ListBox to repaint and display the new items.
        ListBox1.EndUpdate()

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MsgBox("El vino seleccionado tiene el numero ID de busqueda " & ListBox1.SelectedIndex)
        index_vino = ListBox1.SelectedIndex
    End Sub
End Class