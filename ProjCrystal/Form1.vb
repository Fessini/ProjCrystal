Imports System.ComponentModel

Public Class Form1
#Region "Recursos"
    Public Structure estructParametros
        Dim NOME As String
        Dim VALOR As Object
    End Structure

    Public rptRelatorio As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private m_strTilulo As String
    ''' <summary>
    ''' Recebe o Título do Relatório e Sua Sigla (Ex: Contas à Pagar - REL_0001)
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    Public Property TITULO_RELATORIO() As String
        Get
            Return m_strTilulo
        End Get
        Set(ByVal value As String)
            m_strTilulo = "Relatório: " & value
        End Set
    End Property

    Private m_strCaminhoRelatorio As String
    ''' <summary>
    ''' Recebe o Caminho físico do Relatório a ser carregado (Ex: C:\Relatorios\REL_0001.rpt)
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    Public Property CAMINHO_RELATORIO() As String
        Get
            Return m_strCaminhoRelatorio
        End Get
        Set(ByVal value As String)
            m_strCaminhoRelatorio = value
        End Set
    End Property

    Private m_dtsDataSet As Data.DataSet
    ''' <summary>
    ''' Recebe os dados do relatório em um DataSet
    ''' </summary>
    ''' <value>DataSet</value>
    ''' <returns>DataSet</returns>
    Public Property DADOS_RELATORIO() As Data.DataSet
        Get
            Return m_dtsDataSet
        End Get
        Set(ByVal value As Data.DataSet)
            m_dtsDataSet = value
        End Set
    End Property

    Private m_parParametros As List(Of estructParametros)
    Public Property PARAMETROS() As List(Of estructParametros)
        Get
            Return m_parParametros
        End Get
        Set(ByVal value As List(Of estructParametros))
            m_parParametros = value
        End Set
    End Property

    Public Property Zoom As Integer = 100

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Coloca como titulo da janela o nome do relatório.
            Me.Text = m_strTilulo
            '
            If System.IO.File.Exists(m_strCaminhoRelatorio) Then

                rptRelatorio.Load(m_strCaminhoRelatorio)
                'rptRelatorio.Database.Tables(0).SetDataSource(m_dtsDataSet.Tables(0))
                rptRelatorio.SetDataSource(m_dtsDataSet)

                If m_parParametros IsNot Nothing Then
                    For Each a As estructParametros In m_parParametros
                        Dim paramValue As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()
                        paramValue.Value = a.VALOR.ToString
                        rptRelatorio.SetParameterValue(a.NOME.ToString, paramValue)
                        paramValue = Nothing
                    Next
                End If

                crvRel.ReportSource = rptRelatorio

                crvRel.Zoom(Zoom)

            Else
                MessageBox.Show("O Relatório não foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rptRelatorio.Dispose()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Limpar título da janela
        m_strTilulo = ""
        rptRelatorio.Dispose()
        rptRelatorio = Nothing
    End Sub
End Class
