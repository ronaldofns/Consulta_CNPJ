<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CnpjReceita
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CnpjReceita))
        Me.BoxReceita = New System.Windows.Forms.GroupBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.TxtCnpj = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabReceita = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PnlProcessamento = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtExtensoCapitalSocial = New System.Windows.Forms.TextBox()
        Me.TxtCapitalSocial = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtDtUltimaAtualizacao = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtDtSitEspecial = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtSituacaoEspecial = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtMotSitCadastral = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtDtSituacaoCadastral = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtSituacaoCadastral = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtEnteFederativo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtTelefone = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtUf = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtBairroDistrito = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCep = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtComplemento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNaturezaJuridica = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListAtividadeSecundaria = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAtividadePrincipal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPorte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNomeEmpresarial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMatrizFilial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDtAbertura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtInscricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListQsa = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BoxReceita.SuspendLayout()
        Me.TabReceita.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PnlProcessamento.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BoxReceita
        '
        Me.BoxReceita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxReceita.Controls.Add(Me.BtnImprimir)
        Me.BoxReceita.Controls.Add(Me.BtnLimpar)
        Me.BoxReceita.Controls.Add(Me.BtnConsulta)
        Me.BoxReceita.Controls.Add(Me.TxtCnpj)
        Me.BoxReceita.Controls.Add(Me.Label1)
        Me.BoxReceita.Location = New System.Drawing.Point(5, 0)
        Me.BoxReceita.Name = "BoxReceita"
        Me.BoxReceita.Size = New System.Drawing.Size(876, 82)
        Me.BoxReceita.TabIndex = 0
        Me.BoxReceita.TabStop = False
        Me.BoxReceita.Text = "Informe o CNPJ"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Enabled = False
        Me.BtnImprimir.Location = New System.Drawing.Point(419, 32)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(122, 29)
        Me.BtnImprimir.TabIndex = 4
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(291, 32)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(122, 29)
        Me.BtnLimpar.TabIndex = 3
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Location = New System.Drawing.Point(163, 32)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(122, 29)
        Me.BtnConsulta.TabIndex = 2
        Me.BtnConsulta.Text = "Consultar"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'TxtCnpj
        '
        Me.TxtCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TxtCnpj.Location = New System.Drawing.Point(6, 32)
        Me.TxtCnpj.Name = "TxtCnpj"
        Me.TxtCnpj.Size = New System.Drawing.Size(151, 29)
        Me.TxtCnpj.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CNPJ"
        '
        'TabReceita
        '
        Me.TabReceita.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabReceita.Controls.Add(Me.TabPage1)
        Me.TabReceita.Controls.Add(Me.TabPage2)
        Me.TabReceita.Location = New System.Drawing.Point(5, 90)
        Me.TabReceita.Name = "TabReceita"
        Me.TabReceita.SelectedIndex = 0
        Me.TabReceita.Size = New System.Drawing.Size(880, 673)
        Me.TabReceita.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.PnlProcessamento)
        Me.TabPage1.Controls.Add(Me.TxtExtensoCapitalSocial)
        Me.TabPage1.Controls.Add(Me.TxtCapitalSocial)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.TxtDtUltimaAtualizacao)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.TxtDtSitEspecial)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.TxtSituacaoEspecial)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.TxtMotSitCadastral)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.TxtDtSituacaoCadastral)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.TxtSituacaoCadastral)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.TxtEnteFederativo)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.TxtTelefone)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.TxtUf)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.TxtMunicipio)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TxtBairroDistrito)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TxtCep)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TxtComplemento)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TxtNumero)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.TxtLogradouro)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TxtNaturezaJuridica)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ListAtividadeSecundaria)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TxtAtividadePrincipal)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TxtPorte)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TxtRazaoSocial)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TxtNomeEmpresarial)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtMatrizFilial)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtDtAbertura)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtInscricao)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(872, 647)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contribuinte"
        '
        'PnlProcessamento
        '
        Me.PnlProcessamento.BackColor = System.Drawing.Color.Black
        Me.PnlProcessamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlProcessamento.Controls.Add(Me.Label30)
        Me.PnlProcessamento.Controls.Add(Me.Label29)
        Me.PnlProcessamento.Location = New System.Drawing.Point(301, 199)
        Me.PnlProcessamento.Name = "PnlProcessamento"
        Me.PnlProcessamento.Size = New System.Drawing.Size(289, 97)
        Me.PnlProcessamento.TabIndex = 53
        Me.PnlProcessamento.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(23, 45)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(244, 24)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Processando informações..."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(96, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 24)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Aguarde!!!"
        '
        'TxtExtensoCapitalSocial
        '
        Me.TxtExtensoCapitalSocial.BackColor = System.Drawing.Color.White
        Me.TxtExtensoCapitalSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtExtensoCapitalSocial.Location = New System.Drawing.Point(415, 578)
        Me.TxtExtensoCapitalSocial.Multiline = True
        Me.TxtExtensoCapitalSocial.Name = "TxtExtensoCapitalSocial"
        Me.TxtExtensoCapitalSocial.ReadOnly = True
        Me.TxtExtensoCapitalSocial.Size = New System.Drawing.Size(451, 62)
        Me.TxtExtensoCapitalSocial.TabIndex = 52
        Me.TxtExtensoCapitalSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCapitalSocial
        '
        Me.TxtCapitalSocial.BackColor = System.Drawing.Color.White
        Me.TxtCapitalSocial.Location = New System.Drawing.Point(246, 578)
        Me.TxtCapitalSocial.Name = "TxtCapitalSocial"
        Me.TxtCapitalSocial.ReadOnly = True
        Me.TxtCapitalSocial.Size = New System.Drawing.Size(163, 20)
        Me.TxtCapitalSocial.TabIndex = 51
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(243, 562)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 13)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Capital Social"
        '
        'TxtDtUltimaAtualizacao
        '
        Me.TxtDtUltimaAtualizacao.BackColor = System.Drawing.Color.White
        Me.TxtDtUltimaAtualizacao.Location = New System.Drawing.Point(9, 578)
        Me.TxtDtUltimaAtualizacao.Name = "TxtDtUltimaAtualizacao"
        Me.TxtDtUltimaAtualizacao.ReadOnly = True
        Me.TxtDtUltimaAtualizacao.Size = New System.Drawing.Size(231, 20)
        Me.TxtDtUltimaAtualizacao.TabIndex = 49
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 562)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(184, 13)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Data da ultima atualização dos dados"
        '
        'TxtDtSitEspecial
        '
        Me.TxtDtSitEspecial.BackColor = System.Drawing.Color.White
        Me.TxtDtSitEspecial.Location = New System.Drawing.Point(586, 539)
        Me.TxtDtSitEspecial.Name = "TxtDtSitEspecial"
        Me.TxtDtSitEspecial.ReadOnly = True
        Me.TxtDtSitEspecial.Size = New System.Drawing.Size(280, 20)
        Me.TxtDtSitEspecial.TabIndex = 47
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(583, 523)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(133, 13)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "Data da Situação Especial"
        '
        'TxtSituacaoEspecial
        '
        Me.TxtSituacaoEspecial.BackColor = System.Drawing.Color.White
        Me.TxtSituacaoEspecial.Location = New System.Drawing.Point(9, 539)
        Me.TxtSituacaoEspecial.Name = "TxtSituacaoEspecial"
        Me.TxtSituacaoEspecial.ReadOnly = True
        Me.TxtSituacaoEspecial.Size = New System.Drawing.Size(571, 20)
        Me.TxtSituacaoEspecial.TabIndex = 45
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 523)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 13)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Situação Especial"
        '
        'TxtMotSitCadastral
        '
        Me.TxtMotSitCadastral.BackColor = System.Drawing.Color.White
        Me.TxtMotSitCadastral.Location = New System.Drawing.Point(9, 499)
        Me.TxtMotSitCadastral.Name = "TxtMotSitCadastral"
        Me.TxtMotSitCadastral.ReadOnly = True
        Me.TxtMotSitCadastral.Size = New System.Drawing.Size(857, 20)
        Me.TxtMotSitCadastral.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 483)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(146, 13)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Motivo da Situação Cadastral"
        '
        'TxtDtSituacaoCadastral
        '
        Me.TxtDtSituacaoCadastral.BackColor = System.Drawing.Color.White
        Me.TxtDtSituacaoCadastral.Location = New System.Drawing.Point(586, 458)
        Me.TxtDtSituacaoCadastral.Name = "TxtDtSituacaoCadastral"
        Me.TxtDtSituacaoCadastral.ReadOnly = True
        Me.TxtDtSituacaoCadastral.Size = New System.Drawing.Size(280, 20)
        Me.TxtDtSituacaoCadastral.TabIndex = 41
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(583, 442)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(137, 13)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Data da Situação Cadastral"
        '
        'TxtSituacaoCadastral
        '
        Me.TxtSituacaoCadastral.BackColor = System.Drawing.Color.White
        Me.TxtSituacaoCadastral.Location = New System.Drawing.Point(9, 458)
        Me.TxtSituacaoCadastral.Name = "TxtSituacaoCadastral"
        Me.TxtSituacaoCadastral.ReadOnly = True
        Me.TxtSituacaoCadastral.Size = New System.Drawing.Size(571, 20)
        Me.TxtSituacaoCadastral.TabIndex = 39
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 442)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Situação Cadastral"
        '
        'TxtEnteFederativo
        '
        Me.TxtEnteFederativo.BackColor = System.Drawing.Color.White
        Me.TxtEnteFederativo.Location = New System.Drawing.Point(9, 418)
        Me.TxtEnteFederativo.Name = "TxtEnteFederativo"
        Me.TxtEnteFederativo.ReadOnly = True
        Me.TxtEnteFederativo.Size = New System.Drawing.Size(857, 20)
        Me.TxtEnteFederativo.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 402)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "EFR - Ente Federativo Responsável"
        '
        'TxtTelefone
        '
        Me.TxtTelefone.BackColor = System.Drawing.Color.White
        Me.TxtTelefone.Location = New System.Drawing.Point(753, 379)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.ReadOnly = True
        Me.TxtTelefone.Size = New System.Drawing.Size(113, 20)
        Me.TxtTelefone.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(750, 363)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Telefone"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.White
        Me.TxtEmail.Location = New System.Drawing.Point(519, 379)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(228, 20)
        Me.TxtEmail.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(516, 363)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Endereço Eletrônico"
        '
        'TxtUf
        '
        Me.TxtUf.BackColor = System.Drawing.Color.White
        Me.TxtUf.Location = New System.Drawing.Point(461, 379)
        Me.TxtUf.Name = "TxtUf"
        Me.TxtUf.ReadOnly = True
        Me.TxtUf.Size = New System.Drawing.Size(52, 20)
        Me.TxtUf.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(458, 363)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "UF"
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.BackColor = System.Drawing.Color.White
        Me.TxtMunicipio.Location = New System.Drawing.Point(287, 379)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.ReadOnly = True
        Me.TxtMunicipio.Size = New System.Drawing.Size(168, 20)
        Me.TxtMunicipio.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(284, 363)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Município"
        '
        'TxtBairroDistrito
        '
        Me.TxtBairroDistrito.BackColor = System.Drawing.Color.White
        Me.TxtBairroDistrito.Location = New System.Drawing.Point(92, 379)
        Me.TxtBairroDistrito.Name = "TxtBairroDistrito"
        Me.TxtBairroDistrito.ReadOnly = True
        Me.TxtBairroDistrito.Size = New System.Drawing.Size(189, 20)
        Me.TxtBairroDistrito.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(89, 363)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Bairro/Distrito"
        '
        'TxtCep
        '
        Me.TxtCep.BackColor = System.Drawing.Color.White
        Me.TxtCep.Location = New System.Drawing.Point(9, 379)
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.ReadOnly = True
        Me.TxtCep.Size = New System.Drawing.Size(77, 20)
        Me.TxtCep.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 363)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Cep"
        '
        'TxtComplemento
        '
        Me.TxtComplemento.BackColor = System.Drawing.Color.White
        Me.TxtComplemento.Location = New System.Drawing.Point(519, 340)
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.ReadOnly = True
        Me.TxtComplemento.Size = New System.Drawing.Size(347, 20)
        Me.TxtComplemento.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(519, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Complemento"
        '
        'TxtNumero
        '
        Me.TxtNumero.BackColor = System.Drawing.Color.White
        Me.TxtNumero.Location = New System.Drawing.Point(448, 340)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.ReadOnly = True
        Me.TxtNumero.Size = New System.Drawing.Size(65, 20)
        Me.TxtNumero.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(445, 325)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Número"
        '
        'TxtLogradouro
        '
        Me.TxtLogradouro.BackColor = System.Drawing.Color.White
        Me.TxtLogradouro.Location = New System.Drawing.Point(9, 340)
        Me.TxtLogradouro.Name = "TxtLogradouro"
        Me.TxtLogradouro.ReadOnly = True
        Me.TxtLogradouro.Size = New System.Drawing.Size(433, 20)
        Me.TxtLogradouro.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 324)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Logradouro"
        '
        'TxtNaturezaJuridica
        '
        Me.TxtNaturezaJuridica.BackColor = System.Drawing.Color.White
        Me.TxtNaturezaJuridica.Location = New System.Drawing.Point(9, 302)
        Me.TxtNaturezaJuridica.Name = "TxtNaturezaJuridica"
        Me.TxtNaturezaJuridica.ReadOnly = True
        Me.TxtNaturezaJuridica.Size = New System.Drawing.Size(857, 20)
        Me.TxtNaturezaJuridica.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(202, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Código e Descrição da Natureza Jurídica"
        '
        'ListAtividadeSecundaria
        '
        Me.ListAtividadeSecundaria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListAtividadeSecundaria.FullRowSelect = True
        Me.ListAtividadeSecundaria.HideSelection = False
        Me.ListAtividadeSecundaria.Location = New System.Drawing.Point(9, 176)
        Me.ListAtividadeSecundaria.Name = "ListAtividadeSecundaria"
        Me.ListAtividadeSecundaria.Size = New System.Drawing.Size(857, 106)
        Me.ListAtividadeSecundaria.TabIndex = 15
        Me.ListAtividadeSecundaria.UseCompatibleStateImageBehavior = False
        Me.ListAtividadeSecundaria.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição"
        Me.ColumnHeader2.Width = 759
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(295, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Código e Descrição das Atividades Econômicas Secundárias"
        '
        'TxtAtividadePrincipal
        '
        Me.TxtAtividadePrincipal.BackColor = System.Drawing.Color.White
        Me.TxtAtividadePrincipal.Location = New System.Drawing.Point(9, 137)
        Me.TxtAtividadePrincipal.Name = "TxtAtividadePrincipal"
        Me.TxtAtividadePrincipal.ReadOnly = True
        Me.TxtAtividadePrincipal.Size = New System.Drawing.Size(857, 20)
        Me.TxtAtividadePrincipal.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(261, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Código e Descrição da Atividade Econômica Principal"
        '
        'TxtPorte
        '
        Me.TxtPorte.BackColor = System.Drawing.Color.White
        Me.TxtPorte.Location = New System.Drawing.Point(753, 97)
        Me.TxtPorte.Name = "TxtPorte"
        Me.TxtPorte.ReadOnly = True
        Me.TxtPorte.Size = New System.Drawing.Size(113, 20)
        Me.TxtPorte.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(750, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Porte"
        '
        'TxtRazaoSocial
        '
        Me.TxtRazaoSocial.BackColor = System.Drawing.Color.White
        Me.TxtRazaoSocial.Location = New System.Drawing.Point(9, 97)
        Me.TxtRazaoSocial.Name = "TxtRazaoSocial"
        Me.TxtRazaoSocial.ReadOnly = True
        Me.TxtRazaoSocial.Size = New System.Drawing.Size(738, 20)
        Me.TxtRazaoSocial.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Título do estabelecimento (Razão Social)"
        '
        'TxtNomeEmpresarial
        '
        Me.TxtNomeEmpresarial.BackColor = System.Drawing.Color.White
        Me.TxtNomeEmpresarial.Location = New System.Drawing.Point(127, 58)
        Me.TxtNomeEmpresarial.Name = "TxtNomeEmpresarial"
        Me.TxtNomeEmpresarial.ReadOnly = True
        Me.TxtNomeEmpresarial.Size = New System.Drawing.Size(739, 20)
        Me.TxtNomeEmpresarial.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nome empresarial"
        '
        'TxtMatrizFilial
        '
        Me.TxtMatrizFilial.BackColor = System.Drawing.Color.White
        Me.TxtMatrizFilial.Location = New System.Drawing.Point(9, 58)
        Me.TxtMatrizFilial.Name = "TxtMatrizFilial"
        Me.TxtMatrizFilial.ReadOnly = True
        Me.TxtMatrizFilial.Size = New System.Drawing.Size(113, 20)
        Me.TxtMatrizFilial.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Matriz/Filial"
        '
        'TxtDtAbertura
        '
        Me.TxtDtAbertura.BackColor = System.Drawing.Color.White
        Me.TxtDtAbertura.Location = New System.Drawing.Point(127, 19)
        Me.TxtDtAbertura.Name = "TxtDtAbertura"
        Me.TxtDtAbertura.ReadOnly = True
        Me.TxtDtAbertura.Size = New System.Drawing.Size(154, 20)
        Me.TxtDtAbertura.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de Abertura"
        '
        'TxtInscricao
        '
        Me.TxtInscricao.BackColor = System.Drawing.Color.White
        Me.TxtInscricao.Location = New System.Drawing.Point(9, 19)
        Me.TxtInscricao.Name = "TxtInscricao"
        Me.TxtInscricao.ReadOnly = True
        Me.TxtInscricao.Size = New System.Drawing.Size(113, 20)
        Me.TxtInscricao.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número de inscrição"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.ListQsa)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(872, 647)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "QSA - Quadro de Sócio e Administradores"
        '
        'ListQsa
        '
        Me.ListQsa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListQsa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListQsa.FullRowSelect = True
        Me.ListQsa.HideSelection = False
        Me.ListQsa.Location = New System.Drawing.Point(6, 19)
        Me.ListQsa.Name = "ListQsa"
        Me.ListQsa.Size = New System.Drawing.Size(857, 621)
        Me.ListQsa.TabIndex = 17
        Me.ListQsa.UseCompatibleStateImageBehavior = False
        Me.ListQsa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Função"
        Me.ColumnHeader3.Width = 313
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nome do Sócio"
        Me.ColumnHeader4.Width = 540
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 3)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(204, 13)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "QSA - Quadro de Sócio e Administradores"
        '
        'Frm_CnpjReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 764)
        Me.Controls.Add(Me.TabReceita)
        Me.Controls.Add(Me.BoxReceita)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_CnpjReceita"
        Me.Text = "Consulta pública com base no WebService ""www.receitaws.com.br"""
        Me.BoxReceita.ResumeLayout(False)
        Me.BoxReceita.PerformLayout()
        Me.TabReceita.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PnlProcessamento.ResumeLayout(False)
        Me.PnlProcessamento.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BoxReceita As GroupBox
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnConsulta As Button
    Friend WithEvents TxtCnpj As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabReceita As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtExtensoCapitalSocial As TextBox
    Friend WithEvents TxtCapitalSocial As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtDtUltimaAtualizacao As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TxtDtSitEspecial As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtSituacaoEspecial As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtMotSitCadastral As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtDtSituacaoCadastral As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtSituacaoCadastral As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtEnteFederativo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtUf As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtBairroDistrito As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCep As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtComplemento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtLogradouro As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNaturezaJuridica As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ListAtividadeSecundaria As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtAtividadePrincipal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPorte As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRazaoSocial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNomeEmpresarial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMatrizFilial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDtAbertura As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtInscricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListQsa As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label28 As Label
    Friend WithEvents PnlProcessamento As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents BtnImprimir As Button
End Class
