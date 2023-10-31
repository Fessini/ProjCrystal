Imports System.Data.SqlClient

Public Class frmPrincipal
    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim conn As New SqlConnection("Server=CODE-DESENV;Database=Backup Mult;User Id=sa;Password=@mar147;")
        Dim command As New SqlCommand("select nome from tb_cad_cliente", conn)
        Dim da As New SqlDataAdapter(command)
        Dim ds As New DataSet
        da.Fill(ds)
        ds.Tables(0).TableName = "Cliente"
        '
        Dim frm As New Form1
        frm.TITULO_RELATORIO = "Primeiro Relatório"
        frm.CAMINHO_RELATORIO = Application.StartupPath & "\Relatorios\rtpRelatorio1.rpt"
        frm.DADOS_RELATORIO = ds
        frm.Show()
    End Sub
End Class