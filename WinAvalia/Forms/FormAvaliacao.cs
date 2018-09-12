using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Service;
using SchequesWin.Forms;
using Syncfusion.DataSource.Extensions;

namespace WinAvalia.Form
{
    public partial class FormAvaliacao : FormModelo
    {
        private ServiceAvalicao _service;
        private Avaliacao _avaliacao;
        private Pergunta _pergunta;
        public FormAvaliacao(RHTContext context)
        {
            InitializeComponent();
            _service = new ServiceAvalicao(context);
            MontaCobPessoas();
        }

        private void MontaCobPessoas()
        {
            cobPessoas.DataSource = null;
            cobPessoas.DataSource = _service.AllPessoas().OrderBy(p => p.Nome).ToList();
            cobPessoas.SelectedItem = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btPessoas_Click(object sender, EventArgs e)
        {
            panelPessoas.Visible = true;
            panelPerguntas.Visible = false;
            panelPesos.Visible = false;
            CriarListaPessoas();
            lbPessoas.Focus();

        }

        private void CriarListaPessoas()
        {
            lbPessoas.Items.Clear();
            _service.PessoasNaoAvaliadas(_avaliacao.Id, _avaliacao.IdAvaliador).ForEach(p=> lbPessoas.Items.Add(p));
            lbAvalia.Items.Clear();
            _avaliacao.Avaliados.ToList().ForEach(p=>lbAvalia.Items.Add(p.Pessoa));

        }

        private void btPerguntas_Click(object sender, EventArgs e)
        {
            panelPerguntas.Visible = true;
            panelPerguntas.Top = panelPessoas.Top;
            panelPerguntas.Left = panelPessoas.Left;
            panelPessoas.Visible = false;
            panelPesos.Visible = false;
            
            //Tipo de pergunta
            cobTipo.Items.Clear();
            cobTipo.Items.Add(TipoPergunta.GRAFICO);
            cobTipo.Items.Add(TipoPergunta.FORCADA);
            cobTipo.SelectedItem = null;

            //Classificação da pergunta
            cobClassificacao.Items.Clear();
            _service.AllClassificacaos().ForEach(c=> cobClassificacao.Items.Add(c));
            cobClassificacao.SelectedItem = null;

            MontaPerguntas();

        }

        private void MontaPerguntas()
        {
            lbPerguntas.Items.Clear();
            if (_avaliacao.Perguntas.Count != 0)
            {
                _avaliacao.Perguntas.ToList().ForEach(p => lbPerguntas.Items.Add(p));
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            panelDados.Visible = true;
            panelPerguntas.Visible = false;
            panelPessoas.Visible = false;
            panelPesos.Visible = false;
            _avaliacao = new Avaliacao();
        }

        private void LimpaCampos()
        {
            rtxtDescricao.Text = "";
            txtObs.Text = "";
            cobTipo.SelectedItem = null;
            lbAvalia.DataSource = null;
            lbPerguntas.DataSource = null;
            lbAlternativas.DataSource = null;
            panelBoteos.Enabled = false;
            panelPerguntas.Enabled =  true;
            panelPessoas.Enabled = true;
            panelPesos.Enabled = true;
        }

      

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (rtxtDescricao.Text.Trim().Equals(""))
            {
                MessageBox.Show("Precisa ser informado uma descrição sobre esta avaliação.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                rtxtDescricao.Focus();
                return;
            }

            if (cobPessoas.SelectedItem == null)
            {
                MessageBox.Show("Para a avaliação deseve ser definido um avaliador.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                cobPessoas.Focus();
                return;
            }

            if (_avaliacao != null && _avaliacao.Id != 0)
            {
                var resp = MessageBox.Show("Deseja revisar as informações da avaliação?", Text, MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (resp == DialogResult.No)
                {
                    _avaliacao.Avaliador = (Pessoa)cobPessoas.SelectedItem;
                    _avaliacao.Descricao = rtxtDescricao.Text;
                    try
                    {
                        _service.Save(_avaliacao);
                        MessageBox.Show("Dados salvos com suceso!", Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        panelDados.Visible = false;
                        return;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (resp == DialogResult.Cancel) {return; }
            }
            
            _avaliacao.Avaliador = (Pessoa) cobPessoas.SelectedItem;
            _avaliacao.Descricao = rtxtDescricao.Text;
            try
            {
                _service.Save(_avaliacao);
                MessageBox.Show("Selecione as pessoas a serem avaliadas.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                btPessoas_Click(sender, e);
                panelBoteos.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btPesos_Click(object sender, EventArgs e)
        {
            panelPesos.Left = panelPessoas.Left;
            panelPesos.Top = panelPessoas.Top;
            panelPesos.Visible = true;
            panelPessoas.Visible = false;
            panelPerguntas.Visible = false;
            MontaPesos();
        }

        private void MontaPesos()
        {
            List<Peso> pesos = new List<Peso>();
            foreach (Pergunta pergunta in _avaliacao.Perguntas.ToList())
            {
                if (pesos.Where(p => p.Classificacao.Id == pergunta.IdClassificacao).Count() == 0)
                {
                    pesos.Add(new Peso()
                    {
                        Classificacao = pergunta.Classificacao,
                    });
                }
            }

            if (_avaliacao.Id != 0)
            {
                var resp = MessageBox.Show(
                    "Ao acionar a alteraçõa de pesos, o sistema discosiderará os pesos já cadastrados para que seja informado novos valores. Deseja contiunar com alteração dos pesos?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    MessageBox.Show("Os valores dos pesos foram zerados!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
            dgvPesos.DataSource = pesos;
            // Diagramando o data grid
            dgvPesos.Columns[0].Visible = false;
            dgvPesos.Columns[1].Visible = false;
            dgvPesos.Columns[2].Visible = false;
            dgvPesos.Columns[3].Visible = true;
            dgvPesos.Columns[4].Visible = false;
            dgvPesos.Columns[5].Visible = false;
            dgvPesos.Columns[6].Visible = true;

            dgvPesos.Columns[3].Width = 90;
            dgvPesos.Columns[6].Width = 200;
            dgvPesos.Columns[6].ReadOnly = true;//Deixa somente como leitura o campo
            
        }

        

        private void btSalvaPesos_Click(object sender, EventArgs e)
        {
            _avaliacao.Pesos = new List<Peso>();
            foreach (DataGridViewRow row in dgvPesos.Rows)
            {
                double d = (Double) row.Cells[3].Value;
                Classificacao c = (Classificacao) row.Cells[5].Value;
                _avaliacao.AddPeso(c,d);
            }
            _service.Save(_avaliacao);
            panelPesos.Visible = false;
        }

        private void btAdPessoa_Click(object sender, EventArgs e)
        {
            if (lbPessoas.SelectedItem != null)
            {
                Pessoa p = (Pessoa) lbPessoas.SelectedItem;
                lbPessoas.Items.Remove(p);
                lbAvalia.Items.Add(p);
            }
        }

        private void btAddPessoas_Click(object sender, EventArgs e)
        {
            if (lbPessoas.Items.Count != 0)
            {
                lbPessoas.Items.ToList<Pessoa>().ForEach(p=> lbAvalia.Items.Add(p));
                lbPessoas.Items.Clear();
            }
        }

        private void btRemPessoa_Click(object sender, EventArgs e)
        {
            if (lbAvalia.SelectedItem != null)
            {
                Pessoa p = (Pessoa) lbAvalia.SelectedItem;
                lbAvalia.Items.Remove(p);
                lbPessoas.Items.Add(p);
            }
        }

        private void btRemPessoas_Click(object sender, EventArgs e)
        {
            if (lbAvalia.Items.Count != 0)
            {
                lbAvalia.Items.ToList<Pessoa>().ForEach(p => lbPessoas.Items.Add(p));
                lbAvalia.Items.Clear();
            }
        }

        private void btSalvarPessoas_Click(object sender, EventArgs e)
        {
            if (lbAvalia.Items.Count == 0)
            {
                MessageBox.Show("Para a avaliação precisa haver o minimo de uma pessoa na coluana avaliados.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cobPessoas.Focus();
                return;
            }
            _avaliacao.Avaliados = new List<PessoaAvaliacao>();
            lbAvalia.Items.ToList<Pessoa>().ForEach(p => _avaliacao.AddAvaliado(p));
            _service.Save(_avaliacao);
            MessageBox.Show(
                "Elabore agora as perguntas para esta avaliação, elas podem ser do tipo grafico ou de escolha forçada.",
                Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btPerguntas_Click(sender, e);
        }

        private void btAddPer_Click(object sender, EventArgs e)
        {
            if (txtPergunta.Text.Trim().Equals(""))
            {
                MessageBox.Show("Não foi fornecido nenhum dado para formulação da pergunta.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPergunta.Focus();
                return;
            }

            if (cobTipo.SelectedItem == null)
            {
                MessageBox.Show("Não foi definido o tipo de pergunta.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cobTipo.Focus();
                return;
            }

            if (cobClassificacao.SelectedItem == null)
            {
                MessageBox.Show("A pergunta deve ser classificada.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cobClassificacao.Focus();
                return;
            }
            _pergunta = new Pergunta()
            {
                Questao = txtPergunta.Text,
                Classificacao = (Classificacao) cobClassificacao.SelectedItem,
                DescricaoConceitual = txtObs.Text,
                Tipo = (TipoPergunta) cobTipo.SelectedItem,
                

            };

            if ((TipoPergunta) cobTipo.SelectedItem == TipoPergunta.FORCADA)
            {
                lbAlternativas.DataSource = null;
                lbAlternativas.Items.Clear();
                gbAlternativas.Visible = true;
                txtAlt.Text = "";
                chPositivo.Checked = false;
                if (_pergunta.Alternativas.Count != 0)
                {
                    lbAlternativas.Items.Clear();
                    _pergunta.Alternativas.ForEach(p => lbAlternativas.Items.Add(p));
                }

                txtAlt.Focus();
            }
            else
            {
                AddPergunta();
            }
            
        }

        private void AddPergunta()
        {
            lbPerguntas.Items.Add(_pergunta);
            txtPergunta.Text = "";
            txtObs.Text = "";
            cobTipo.SelectedItem = null;
            cobClassificacao.SelectedItem = null;
        }

        private void btAddAlt_Click(object sender, EventArgs e)
        {
            if (txtAlt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Deve ser informado dados para a alternativa.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtAlt.Focus();
                return;
            }
            
            Alternativa alternativa = new Alternativa()
            {
                Descricao = txtAlt.Text,
                Positiva = chPositivo.Checked,
                
            };
            lbAlternativas.Items.Add(alternativa);
            txtAlt.Text = "";
            chPositivo.Checked = false;
        }

        private void btSaveAlt_Click(object sender, EventArgs e)
        {
            if (!VerificaAlternativas())
            {
                MessageBox.Show(
                    "Para esse tipo de pergunta, precisa de no mínimo uma alternativa positiva e outra negativa.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAlt.Focus();
                return;
            }

            
            _pergunta.Alternativas = new List<Alternativa>();
            lbAlternativas.Items.ToList<Alternativa>().ForEach(a => _pergunta.AddAlternativa(a));
            gbAlternativas.Visible = false;
            AddPergunta();
        }

        private bool VerificaAlternativas()
        {
            bool positiva = lbAlternativas.Items.ToList<Alternativa>().Where(a => a.Positiva == true).Count() >= 1;
            bool negativa = lbAlternativas.Items.ToList<Alternativa>().Where(a => a.Positiva == false).Count() >=1;
            return (positiva & negativa);
        }

        private void btSalvarPerguntas_Click(object sender, EventArgs e)
        {
            if (lbPerguntas.Items.Count == 0)
            {
                MessageBox.Show(
                    "Para processegir no processo de avaliação, é nescessário o mínimo uma pergunta cadastrada.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPergunta.Focus();
                return;
            }
            _avaliacao.Perguntas = new List<Pergunta>();
            lbPerguntas.Items.ToList<Pergunta>().ForEach(p=> _avaliacao.AddPergunta(p));
            _service.Save(_avaliacao);
            panelPerguntas.Visible = false;
            btPesos_Click(sender, e);
        }

        private void btSalvaPesos_Click_1(object sender, EventArgs e)
        {
            if (!ValidandoPesos())
            {
                MessageBox.Show(
                    "Os pesos desta avaliação estão divergente, a soma dos mesmos não estão totalizando 100%, por favor confira os valores.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPesos.Focus();
            }

            _avaliacao.Pesos = new List<Peso>();
            foreach (DataGridViewRow row in dgvPesos.Rows)
            {
                _avaliacao.AddPeso((Classificacao)row.Cells[5].Value, (Double) row.Cells[3].Value);
            }
            _service.Save(_avaliacao);
            MessageBox.Show("Cadastro da avaliação concluido com sucesso!", Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            panelPesos.Visible = false;
            panelDados.Visible = false;

        }

        private bool ValidandoPesos()
        {
            double t = 0;
            foreach (DataGridViewRow peso in dgvPesos.Rows)
            {
                t += (Double) peso.Cells[3].Value;
            }
            return t == 100.0d;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair do cadastro da avaliação atual?", Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                this.panelDados.Visible = false;
                panelPesos.Visible = false;
                panelPessoas.Visible = false;
                panelPerguntas.Visible = false;
                rtxtDescricao.Text = "";
                cobPessoas.SelectedItem = null;
                panelBoteos.Enabled = false;
            
            }
        }

        private void FormAvaliacao_Load(object sender, EventArgs e)
        {
            cobBusca.Items.Clear();
            cobResultado.ComboBox.DataSource = null;
            cobBusca.Items.Add(TipoBuscaAvaliacao.ABERTAS);
            cobBusca.Items.Add(TipoBuscaAvaliacao.FECHADAS);
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            if (cobBusca.ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de busca.", Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cobBusca.Focus();
                return;
            }

            if ((TipoBuscaAvaliacao) cobBusca.SelectedItem == TipoBuscaAvaliacao.ABERTAS)
            {
                cobResultado.ComboBox.DataSource = _service.FindAllAvaliacaosAbertas();
                panelPerguntas.Enabled = true;
                panelPessoas.Enabled = true;
                panelPesos.Enabled = true;
            }
            else
            {
                cobResultado.ComboBox.DataSource = _service.FindAllAvaliacaoFechadas();
                panelPerguntas.Enabled = false;
                panelPessoas.Enabled = false;
                panelPesos.Enabled = false;
            }

            barraBusca.Visible = true;
        }

        private void BtEditPerg_Click(object sender, EventArgs e)
        {
            if (lbPerguntas.SelectedItem == null)
            {
                MessageBox.Show("Para editar precisa primeiro selecionar uma das perguntas cadastradas.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lbPerguntas.Focus();
                return;
            }

            _pergunta = (Pergunta) lbPerguntas.SelectedItem;
            PreencheCamposPergunta();
            lbPerguntas.Items.Remove(_pergunta);
        }

        private void PreencheCamposPergunta()
        {
            txtPergunta.Text = _pergunta.Questao;
            txtObs.Text = _pergunta.DescricaoConceitual;
            cobTipo.SelectedItem = _pergunta.Tipo;
            cobClassificacao.SelectedItem = _pergunta.Classificacao;
            txtPergunta.Focus();
        }

        private void btEditAlternativa_Click(object sender, EventArgs e)
        {
            if (lbAlternativas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma das alternativas para editar", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                lbAlternativas.Focus();
                return;
            }

            Alternativa alt = (Alternativa) lbAlternativas.SelectedItem;
            lbAlternativas.Items.Remove(alt);
            txtAlt.Text = alt.Descricao;
            chPositivo.Checked = alt.Positiva;
            txtAlt.Focus();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (cobResultado.SelectedItem == null)
            {
                MessageBox.Show("Selecione um dos resultados para poder abrir a edição.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                cobResultado.Focus();
                return;
            }

            _avaliacao = (Avaliacao) cobResultado.SelectedItem;
            PreecherCamposAvaliacao();
            panelDados.Visible = true;
            panelPerguntas.Visible = false;
            panelPessoas.Visible = false;
            panelPesos.Visible = false;
            rtxtDescricao.Focus();
        }

        private void PreecherCamposAvaliacao()
        {
            rtxtDescricao.Text = _avaliacao.Descricao;
            cobPessoas.SelectedItem = _avaliacao.Avaliador;
            panelBoteos.Enabled = true;
        }
    }

    public enum TipoBuscaAvaliacao
    {
        ABERTAS= 0,FECHADAS = 1
    }
}
