Module Mdl_Relatorio
    Public ObjPrintTemp As New Printing.PrintDocument()

    'objeto para desenhar 
    'Variaveis das linhas
    Public LinhasPorPagina As Single = 0
    Public PosicaoDaLinha As Single = 0
    Public LinhaAtual As Integer = 0

    Public paginaAtual As Integer = 1

    Public Sub Imprimir()
        'define o titulo do relatorio   
        Dim ObjPrint As New Printing.PrintDocument()
        Dim RelatorioTitulo As String = "Cartão de CNPJ"

        'define os objetos printdocument e os eventos associados
        'IMPORTANTE - definimos 3 eventos para tratar a impressão : PringPage, BeginPrint e EndPrint.
        AddHandler ObjPrint.PrintPage, New Printing.PrintPageEventHandler(AddressOf Mdl_Relatorio.PdRelatorios_PrintPage)
        AddHandler ObjPrint.BeginPrint, New Printing.PrintEventHandler(AddressOf Mdl_Relatorio.Begin_Print)
        AddHandler ObjPrint.EndPrint, New Printing.PrintEventHandler(AddressOf Mdl_Relatorio.End_Print)

        'define o objeto para visualizar a impressao
        Dim objPrintPreview As New PrintPreviewDialog
        Dim impressora = New System.Windows.Forms.ToolStripButton With {
            .Image = CType(objPrintPreview.Controls(1), System.Windows.Forms.ToolStrip).ImageList.Images(0),
            .DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        }
        AddHandler impressora.Click, AddressOf SelecionaImpressora
        CType(objPrintPreview.Controls(1), System.Windows.Forms.ToolStrip).Items.RemoveAt(0)
        CType(objPrintPreview.Controls(1), System.Windows.Forms.ToolStrip).Items.Insert(0, impressora)

        Try
            'define o formulário como maximizado e com Zoom
            With objPrintPreview
                .Document = ObjPrint
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 0.85
                .Text = "Cartão de CNPJ"
                '.MdiParent = MDIVendas
                ObjPrintTemp = ObjPrint
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Public Sub SelecionaImpressora()
        Dim dialog As PrintDialog = New PrintDialog With {
            .Document = ObjPrintTemp
        }
        If (dialog.ShowDialog = DialogResult.OK) Then
            ObjPrintTemp.Print()
        End If
    End Sub

    'A conexÆo e o DataReader ‚ aberto aqui

    Private Sub Begin_Print(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        paginaAtual = 1
    End Sub

    'Layout da(s) pagina(s) a imprimir
    Private Sub PdRelatorios_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        'configura as margens para impressão
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)
        Dim MargemEsquerda As Single = e.MarginBounds.Left - 50
        Dim MargemSuperior As Single = e.MarginBounds.Top - 50
        Dim MargemDireita As Single = e.MarginBounds.Right
        Dim MargemInferior As Single = e.MarginBounds.Bottom

        'tamanho e atributos de estilo. 
        Dim FonteNegrito = New Font("Arial", 15, FontStyle.Bold)
        Dim FonteNormal = New Font("Arial", 9, FontStyle.Regular)
        Dim FonteNegrito9 = New Font("Arial", 9, FontStyle.Bold)
        Dim FonteNegrito10 = New Font("Arial", 10, FontStyle.Bold)
        Dim pFont2Un = New Font("Arial", 9, FontStyle.Underline)
        Dim FonteRodape = New Font("Arial", 8, FontStyle.Regular)


        'define valores para linha atual e para linha da impressao
        LinhaAtual = 0
        'define o número de linhas por pagina
        LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 7)
        'Borda da Página
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda, MargemSuperior, MargemDireita, MargemInferior)

        'Imagem
        e.Graphics.DrawImage(My.Resources.brasao_do_brasil_republica, MargemEsquerda + 30, MargemSuperior + 30, 100, 100)

        e.Graphics.DrawString("REPÚBLICA FEDERATIVA DO BRASIL", FonteNegrito, Brushes.Black, MargemEsquerda + 190, MargemSuperior + 30)
        e.Graphics.DrawString("CADASTRO NACIONAL DA PESSOA JURÍDICA", FonteNegrito, Brushes.Black, MargemEsquerda + 150, MargemSuperior + 80)

        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 160, MargemDireita - 10, 50)
        e.Graphics.DrawString("NÚMERO DE INSCRIÇÃO", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 165)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtInscricao.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 180)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtMatrizFilial.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 195)
        e.Graphics.DrawLine(Pens.Black, MargemEsquerda + 180, 260, MargemEsquerda + 180, 210) 'Linha Vertical
        e.Graphics.DrawString("COMPROVANTE DE INSCRIÇÃO E DE SITUAÇÃO", FonteNegrito10, Brushes.Black, MargemEsquerda + 185, MargemSuperior + 175)
        e.Graphics.DrawString("CADASTRAL", FonteNegrito10, Brushes.Black, MargemEsquerda + 300, MargemSuperior + 190)
        e.Graphics.DrawLine(Pens.Black, MargemEsquerda + 520, 260, MargemEsquerda + 520, 210) 'Linha Vertical
        e.Graphics.DrawString("DATA DE ABERTURA", FonteNormal, Brushes.Black, MargemEsquerda + 525, MargemSuperior + 165)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtDtAbertura.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 525, MargemSuperior + 180)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 215, MargemDireita - 10, 36)
        e.Graphics.DrawString("NOME EMPRESARIAL", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 220)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtRazaoSocial.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 235)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 256, MargemDireita - 180, 36)
        e.Graphics.DrawString("TÍTULO DO ESTABELECIMENTO (NOME FANTASIA)", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 261)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtNomeEmpresarial.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 276)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 560, MargemSuperior + 256, MargemDireita - 565, 36)
        e.Graphics.DrawString("PORTE", FonteNormal, Brushes.Black, MargemEsquerda + 565, MargemSuperior + 261)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtPorte.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 565, MargemSuperior + 276)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 297, MargemDireita - 10, 36)
        e.Graphics.DrawString("CÓDIGO E DESCRIÇÃO DA ATIVIDADE ECONÔMICA PRINCIPAL", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 302)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtAtividadePrincipal.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 317)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 338, MargemDireita - 10, 350)
        e.Graphics.DrawString("CÓDIGO E DESCRIÇÃO DAS ATIVIDADES ECONÔMICAS SECUNDÁRIAS", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 343)
        Dim Linha As Integer = 358
        For AtivSecundaria As Integer = 0 To Frm_CnpjReceita.ListAtividadeSecundaria.Items.Count - 1
            Dim Cod As String = Frm_CnpjReceita.ListAtividadeSecundaria.Items(AtivSecundaria).Text
            Dim Ativ As String = Frm_CnpjReceita.ListAtividadeSecundaria.Items(AtivSecundaria).SubItems(1).Text
            e.Graphics.DrawString(Cod & " - " & Ativ, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + Linha)
            Linha += 15
        Next
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 693, MargemDireita - 10, 36)
        e.Graphics.DrawString("CÓDIGO E DESCRIÇÃO DA NATUREZA JURÍDICA", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 699)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtNaturezaJuridica.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 714)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 734, MargemDireita - 380, 36)
        e.Graphics.DrawString("LOGRADOURO", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 739)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtLogradouro.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 754)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 360, MargemSuperior + 734, MargemDireita - 655, 36)
        e.Graphics.DrawString("NÚMERO", FonteNormal, Brushes.Black, MargemEsquerda + 365, MargemSuperior + 739)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtNumero.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 365, MargemSuperior + 754)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 440, MargemSuperior + 734, MargemDireita - 445, 36)
        e.Graphics.DrawString("COMPLEMENTO", FonteNormal, Brushes.Black, MargemEsquerda + 445, MargemSuperior + 739)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtComplemento.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 445, MargemSuperior + 754)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 775, MargemDireita - 600, 36)
        e.Graphics.DrawString("CEP", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 780)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtCep.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 795)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 140, MargemSuperior + 775, MargemDireita - 515, 36)
        e.Graphics.DrawString("BAIRRO/DISTRITO", FonteNormal, Brushes.Black, MargemEsquerda + 147, MargemSuperior + 780)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtBairroDistrito.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 147, MargemSuperior + 795)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 360, MargemSuperior + 775, MargemDireita - 465, 36)
        e.Graphics.DrawString("MUNICÍPIO", FonteNormal, Brushes.Black, MargemEsquerda + 365, MargemSuperior + 780)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtMunicipio.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 365, MargemSuperior + 795)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 630, MargemSuperior + 775, MargemDireita - 635, 36)
        e.Graphics.DrawString("UF", FonteNormal, Brushes.Black, MargemEsquerda + 635, MargemSuperior + 780)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtUf.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 635, MargemSuperior + 795)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 816, MargemDireita - 380, 36)
        e.Graphics.DrawString("ENDEREÇO ELETRÔNICO", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 821)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtEmail.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 836)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 360, MargemSuperior + 816, MargemDireita - 365, 36)
        e.Graphics.DrawString("TELEFONE", FonteNormal, Brushes.Black, MargemEsquerda + 365, MargemSuperior + 821)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtTelefone.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 365, MargemSuperior + 836)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 857, MargemDireita - 10, 36)
        e.Graphics.DrawString("ENTE FEDERATIVO RESPONSÁVEL (EFR)", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 862)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtEnteFederativo.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 877)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 898, MargemDireita - 250, 36)
        e.Graphics.DrawString("SITUAÇÃO CADASTRAL", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 903)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtSituacaoCadastral.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 918)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 490, MargemSuperior + 898, MargemDireita - 495, 36)
        e.Graphics.DrawString("DATA DA SITUAÇÃO CADASTRAL", FonteNormal, Brushes.Black, MargemEsquerda + 495, MargemSuperior + 903)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtDtSituacaoCadastral.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 495, MargemSuperior + 918)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 939, MargemDireita - 10, 36)
        e.Graphics.DrawString("MOTIVO DE SITUAÇÃO CADASTRAL", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 944)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtMotSitCadastral.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 959)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 980, MargemDireita - 250, 36)
        e.Graphics.DrawString("SITUAÇÃO ESPECIAL", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 985)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtSituacaoEspecial.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 1000)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 490, MargemSuperior + 980, MargemDireita - 495, 36)
        e.Graphics.DrawString("DATA DA SITUAÇÃO ESPECIAL", FonteNormal, Brushes.Black, MargemEsquerda + 495, MargemSuperior + 985)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtDtSitEspecial.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 495, MargemSuperior + 1000)
        'Borda da Legenda
        e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda + 5, MargemSuperior + 1021, MargemDireita - 10, 46)
        e.Graphics.DrawString("CAPITAL SOCIAL - ", FonteNormal, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 1026)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtCapitalSocial.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 125, MargemSuperior + 1026)
        e.Graphics.DrawString(Frm_CnpjReceita.TxtExtensoCapitalSocial.Text, FonteNegrito9, Brushes.Black, MargemEsquerda + 7, MargemSuperior + 1041)


        'verifica se continua imprimindo
        If (LinhaAtual >= LinhasPorPagina) Then
            'inicia a impressao - define a posição da linha e a posição de impressoa
            e.HasMorePages = True
        Else
            'inicia a impressao - define a posição da linha e a posição de impressoa
            e.HasMorePages = False
        End If

        'Incrementa o n£mero da pagina
        paginaAtual += 1



    End Sub

    'Encerra a conexÆo e o DataReader
    Private Sub End_Print(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        paginaAtual = 1
        ObjPrintTemp.Dispose()
    End Sub
End Module
