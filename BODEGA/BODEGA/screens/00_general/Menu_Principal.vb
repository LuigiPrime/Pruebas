Public Class Menu_Principal
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        l_cabecera.Visible = False

        'Gestor visibilidad al modo editor
        If sin_permisos Then
            'No tenemos los permisos necesarios para hacer edicicion en la BD
            b_editor.Visible = False
            b_editor.Enabled = False
        Else

            b_editor.Visible = True
            b_editor.Enabled = True
        End If

        'cerrar conexion con la base de datos
        desconectar_BD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cerrar_Aplicacion.Click

        Dim registro As Byte

        registro = MsgBox("¿Desea apagar la aplicación?", vbYesNo, "Confirmar")
        If registro = vbYes Then
            desconectar_BD()
            Dispose()
            End
        Else
            Return
        End If

    End Sub

    Private Sub b_Debug_Click(sender As Object, e As EventArgs) Handles b_Debug.Click
        Debug_Aplicacion.Show()
    End Sub

    Private Sub Inicio_CLOSE(sender As Object, e As EventArgs) Handles MyBase.Closed
        desconectar_BD()
        Dispose()
        End

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b_showCatalog.Click
        Folleto_Vinos.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles b_showTotal.Click
        Totalizadores.Show()
    End Sub

    Private Sub b_Ayuda_Click(sender As Object, e As EventArgs) Handles b_Ayuda.Click
        Help.ShowHelp(Me, URL_help_document)
    End Sub

    Private Sub b_ShowFrontal_Click(sender As Object, e As EventArgs) Handles b_ShowFrontal.Click
        Bodega_Huecos_Principal.Show()
    End Sub

    Private Sub b_ShowAuxiliar_Click(sender As Object, e As EventArgs) Handles b_ShowAuxiliar.Click
        Bodega_Huecos_Principal_Aux.Show()
    End Sub

    Private Sub b_ShowDespensa_Click(sender As Object, e As EventArgs) Handles b_ShowDespensa.Click
        Bodega_Huecos_Despensa.Show()
    End Sub

    Private Sub b_ShowLenera_Click(sender As Object, e As EventArgs) Handles b_ShowLenera.Click
        Bodega_Huecos_Lenera.Show()
    End Sub

    Private Sub l_cabecera_Click(sender As Object, e As EventArgs) Handles l_cabecera.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub b_editor_Click(sender As Object, e As EventArgs) Handles b_editor.Click
        Menu_Edicion.Show()
    End Sub

    Private Sub p_ShowFrontal_Click(sender As Object, e As EventArgs) Handles p_ShowFrontal.Click
        Bodega_Huecos_Principal.Show()
    End Sub

    Private Sub p_ShowAuxiliar_Click(sender As Object, e As EventArgs) Handles p_ShowAuxiliar.Click
        Bodega_Huecos_Principal_Aux.Show()
    End Sub

    Private Sub p_ShowDespensa_Click(sender As Object, e As EventArgs) Handles p_ShowDespensa.Click
        Bodega_Huecos_Despensa.Show()
    End Sub

    Private Sub p_ShowLenera_Click(sender As Object, e As EventArgs) Handles p_ShowLenera.Click
        Bodega_Huecos_Lenera.Show()
    End Sub
End Class
