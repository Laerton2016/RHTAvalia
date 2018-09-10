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

            dgvPesos.DataSource = pesos;
            // Diagramando o data grid
        }

        private void btSalvaPesos_Click(object sender, EventArgs e)
        {
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

            _pergunta.Alternativas = (List<Alternativa>) lbAlternativas.Items.ToList<Alternativa>();
            gbAlternativas.Visible = false;
            AddPergunta();
        }

        private bool VerificaAlternativas()
        {
            bool resp = lbAlternativas.Items.ToList<Alternativa>().Where(a => a.Positiva == true).Count() >=1 &
                    lbAlternativas.Items.ToList<Alternativa>().Where(a => a.Positiva == false).Count() >=1;
            return resp;
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
            _avaliacao.Perguntas = (ICollection<Pergunta>) lbPerguntas.Items.ToList<Pergunta>();
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

            _avaliacao.Pesos = (ICollection<Peso>) dgvPesos.Rows.ToList<Peso>();
            MessageBox.Show("Cadastro da avaliação concluido com sucesso!", Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            panelPesos.Visible = false;
            panelDados.Visible = false;

        }

        private bool ValidandoPesos()
        {
            double t = 0;
            foreach (Peso peso in dgvPesos.Rows.ToList<Peso>())
            {
                t += peso.PesoAvaliativo;
            }

            return t == 100.0d;
        }
    }
}
