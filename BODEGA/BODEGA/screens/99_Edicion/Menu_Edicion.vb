Imports System.IO
Public Class Menu_Edicion

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_Reinicio.Click

        Dim registro As Byte

        registro = MsgBox("¿Desea terminar la edicion de datos? La aplicacion se reiniciará", vbYesNo, "Confirmar")

        If registro = vbYes Then
            Me.Close()
            Application.Restart()
        Else
            MsgBox("No se actualizarán los cambios hasta completar el reinicio", vbInformation, "RECORDATORIO")
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Info_Listado_Vinos.Show()
    End Sub

    Private Sub b_EditorVinos_Click(sender As Object, e As EventArgs) Handles b_EditorVinos.Click
        Editor_Vinos_Principal.Show()
    End Sub

    Private Sub b_EditorHuecos_Click(sender As Object, e As EventArgs) Handles b_EditorHuecos.Click
        Editor_Huecos_Principal.Show()
    End Sub

    Private Sub b_EditorDO_Click(sender As Object, e As EventArgs) Handles b_EditorDO.Click
        Editor_DO_Principal.Show()
    End Sub

    Private Sub b_EditorZonas_Click(sender As Object, e As EventArgs) Handles b_EditorZonas.Click
        Editor_Zonas_Principal.Show()
    End Sub

    Private Sub Menu_Edicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_Ayuda.Click
        Help.ShowHelp(Me, URL_help_document)
    End Sub
End Class