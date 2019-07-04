﻿
Imports System.Net.Http
Imports System.Windows
Imports Newtonsoft.Json

Public Class Frm_CnpjReceita
    Private Async Sub BtnConsulta_ClickAsync(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        BtnConsulta.Enabled = False
        BtnConsulta.Text = "Aguarde..."
        Dim url As String
        url = "https://www.receitaws.com.br/v1/cnpj/" & TxtCnpj.Text
        PnlProcessamento.Visible = True
        Using client = New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim ProdutoJsonString = Await response.Content.ReadAsStringAsync()
                Dim Resposta = JsonConvert.DeserializeObject(Of ClsReceita)(ProdutoJsonString)
                If Resposta.Status <> "ERROR" Then
                    TxtInscricao.Text = Resposta.Cnpj
                    TxtDtAbertura.Text = Resposta.Abertura
                    TxtMatrizFilial.Text = Resposta.Tipo
                    TxtNomeEmpresarial.Text = Resposta.Fantasia
                    TxtRazaoSocial.Text = Resposta.Nome
                    TxtPorte.Text = Resposta.Porte
                    'Pega a Atividade principal
                    For AtivPrincipal As Integer = 0 To Resposta.Atividade_principal.Count - 1
                        TxtAtividadePrincipal.Text = Resposta.Atividade_principal(AtivPrincipal).Code & " - " & Resposta.Atividade_principal(AtivPrincipal).Text
                    Next

                    'Pega a Atividade Secundária
                    ListAtividadeSecundaria.Items.Clear()
                    For AtivSecundaria As Integer = 0 To Resposta.Atividades_secundarias.Count - 1
                        Dim LvAtivSecundaria As New ListViewItem With {
                        .Text = Resposta.Atividades_secundarias(AtivSecundaria).Code
                    }
                        LvAtivSecundaria.SubItems.Add(Resposta.Atividades_secundarias(AtivSecundaria).Text)
                        ListAtividadeSecundaria.Items.Add(LvAtivSecundaria)
                    Next

                    TxtNaturezaJuridica.Text = Resposta.Natureza_juridica
                    TxtLogradouro.Text = Resposta.Logradouro
                    TxtNumero.Text = Resposta.Numero
                    TxtComplemento.Text = Resposta.Complemento
                    TxtCep.Text = Resposta.Cep
                    TxtBairroDistrito.Text = Resposta.Bairro
                    TxtMunicipio.Text = Resposta.Municipio
                    TxtUf.Text = Resposta.Uf
                    TxtEmail.Text = Resposta.Email
                    TxtTelefone.Text = Resposta.Telefone
                    TxtEnteFederativo.Text = Resposta.Efr
                    TxtSituacaoCadastral.Text = Resposta.Situacao
                    TxtDtSituacaoCadastral.Text = Resposta.Data_situacao
                    TxtMotSitCadastral.Text = Resposta.Motivo_situacao
                    TxtSituacaoEspecial.Text = Resposta.Situacao_especial
                    TxtDtSitEspecial.Text = Resposta.Data_situacao_especial
                    TxtDtUltimaAtualizacao.Text = Resposta.Ultima_atualizacao

                    'Pega o Quadro de socios
                    ListQsa.Items.Clear()
                    For ItensQsa As Integer = 0 To Resposta.Qsa.Count - 1
                        Dim LvQsa As New ListViewItem With {
                        .Text = Resposta.Qsa(ItensQsa).Qual
                    }
                        LvQsa.SubItems.Add(Resposta.Qsa(ItensQsa).Nome)
                        ListQsa.Items.Add(LvQsa)
                    Next

                    TxtCapitalSocial.Text = Resposta.Capital_social

                Else
                    MsgBox(Resposta.Status & ": CNPJ inválido.")
                    LimparControles(Me)
                End If

            Else
                MessageBox.Show("Falha ao obter os dados : " + response.StatusCode.ToString)
            End If
            PnlProcessamento.Visible = False
            BtnConsulta.Text = "Consultar"
            BtnConsulta.Enabled = True
        End Using
    End Sub
    Protected Sub LimparControles(ByVal ctrl As Control)
        For Each c As Control In ctrl.Controls

            If TypeOf c Is TextBox Then
                c.Text = ""
            End If

            If c.HasChildren Then
                LimparControles(c)
            End If
        Next
        'Tentei de varias formas pegar o controle listview por não encontrei uma forma e optei em fazer a limpeza pelo nome do controle.
        ListAtividadeSecundaria.Items.Clear()
        ListQsa.Items.Clear()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparControles(Me)
    End Sub

    Private Sub Frm_CnpjReceita_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub TxtCapitalSocial_TextChanged(sender As Object, e As EventArgs) Handles TxtCapitalSocial.TextChanged
        TxtExtensoCapitalSocial.Text = NumeroToExtenso(TxtCapitalSocial.Text)
    End Sub
End Class
