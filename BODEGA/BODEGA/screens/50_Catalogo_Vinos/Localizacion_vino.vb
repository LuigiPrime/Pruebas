Public Class Localizacion_vino
    Private Sub Localizacion_vino_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TABLA DE VISUALIZACIÓN UBICACIÓN DE LAS BOTELLAS
        DataGridView1.DataSource = tabla_contabilizacion_vinos

        'ocultar las columnas no utiles

        DataGridView1.Columns("Fila").Visible = False
        DataGridView1.Columns("Columna").Visible = False

        Dim informe_botellas As String

        informe_botellas = tabla_contabilizacion_vinos.Rows.Count

        MsgBox("Contabilizadas " & informe_botellas & " botellas")

        'MsgBox("La botella esta en el hueco" & tabla_contabilizacion_vinos.Rows(1))

    End Sub

End Class