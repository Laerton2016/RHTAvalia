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
using String = System.String;

namespace WinAvalia.Forms
{
    public partial class FormRespostas : FormModelo
    {

        private ServiceAvalicao _service;
        private Pessoa _avaliador;
        private Avaliacao _avaliacao;
        private int _numeroAvaliado = 0, _numeroQuestao = 0;
        private Int64 _idAvaliado = 0;
        private List<Pessoa> _avaliados;
        private List<Pergunta> _perguntas;
        public FormRespostas(RHTContext context)
        {
            InitializeComponent();
            _service = new ServiceAvalicao(context);
        }

        public Pessoa Avaliador
        {
            get => _avaliador;
            set => _avaliador = value;
        }

        private void FormRespostas_Load(object sender, EventArgs e)
        {
            cobAvaliacoes.ComboBox.DataSource = _service.AvaliacaoesByPessoaAbertas(_avaliador.Id);
            cobAvaliacoes.ComboBox.SelectedItem = null;
        }

        private void btNaoFinalizadas_Click(object sender, EventArgs e)
        {
            cobAvaliacoes.ComboBox.DataSource = _service.AvaliacaoesByPessoaAbertas(_avaliador.Id);
            cobAvaliacoes.ComboBox.Refresh();
            cobAvaliacoes.ComboBox.SelectedItem = null;
        }

        private void btFinalzadas_Click(object sender, EventArgs e)
        {
            cobAvaliacoes.ComboBox.DataSource = _service.AvaliacoesByPessoaFechada(_avaliador.Id);
            cobAvaliacoes.ComboBox.Refresh();
            cobAvaliacoes.ComboBox.SelectedItem = null;
        }

        private void btAvaliar_Click(object sender, EventArgs e)
        {
            if (cobAvaliacoes.ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Para iniciar uma avaliação deve ser selecionado uma avaliação.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cobAvaliacoes.Focus();
            }

            _avaliacao = (Avaliacao) cobAvaliacoes.ComboBox.SelectedItem;
            
            labInformacoes.Text = String.Format("{2}\r\nData da publicação da avaliação {0:dd/MM/yyyy} \r\nAvaliador: {1}" +
                                                "\r\nNº de avaliados: {3} Nº de questões: {4}",
                _avaliacao.Data, _avaliacao.Avaliador.Nome, _avaliacao.Descricao, _avaliacao.Avaliados.Count, _avaliacao.Perguntas.Count);
            panelInformacoes.Visible = true;

        }

        private void combSelecao_SelectedValueChanged(object sender, EventArgs e)
        {
            labSelecao.Text = ((Alternativa) combSelecao.SelectedItem).Descricao;
        }

        private void btResponder_Click(object sender, EventArgs e)
        {
            if (panelSelecao.Visible && combSelecao.SelectedItem == null)
            {
                MessageBox.Show("Precisa ser seleiconado uma das opções para a pergunta.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                combSelecao.Focus();
                return;
            }
            Resposta r = new Resposta()
            {
                Avaliado = _avaliados[_numeroAvaliado],
                Questao =  _perguntas[_numeroQuestao],
                Nota = (panelSelecao.Visible)?0: (int) txtNumerico.Value,
                Selecionada = (panelSelecao.Visible)?(Alternativa) combSelecao.SelectedItem:null
            };
            _perguntas[_numeroQuestao].AddResposta(r);
            ProximaPergunta();
        }

        private void ProximaPergunta()
        {
            if ((_perguntas.Count -1) > (_numeroQuestao))
            {
                _numeroQuestao++;
                labPergunta.Text = String.Format("{0} - {1}", _numeroQuestao + 1, _perguntas[_numeroQuestao].Questao);
                labObs.Text = String.Format("Descrição conceitual: {0}.", _perguntas[_numeroQuestao].DescricaoConceitual);
                labAvaliado.Text = String.Format("Avaliado: {0}", _avaliados[_numeroAvaliado].Nome);
                if (_perguntas[_numeroQuestao].Tipo == TipoPergunta.GRAFICO)
                {
                    panelRespotaGrafica.Visible = true;
                    panelSelecao.Visible = false;
                    txtNumerico.Value = 1;
                }
                else
                {
                    panelSelecao.Visible = true;
                    panelRespotaGrafica.Visible = false;

                    combSelecao.DataSource = _perguntas[_numeroQuestao].Alternativas;
                    combSelecao.Focus();
                    labSelecao.Text = (combSelecao.SelectedItem == null) ? "" : ((Alternativa)combSelecao.SelectedItem).Descricao;
                }
            }
            else
            {
                _numeroQuestao = -1;
                if (_avaliados.Count - 1 > _numeroAvaliado)
                {
                    _numeroAvaliado++;
                    ProximaPergunta();
                }
                else
                {
                    Encerra();
                }
            }
        }

        private void Encerra()
        {
            _avaliacao.Perguntas = _perguntas;
            _service.Save(_avaliacao);
            MessageBox.Show("Avaliação concluida com suscesso!", Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            panelPergunta.Visible = false;
            panelInformacoes.Visible = false;
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            panelPergunta.Visible = true;
            _avaliados = new List<Pessoa>();
            _avaliacao.Avaliados.ForEach(p=> _avaliados.Add(p.Pessoa));
            _perguntas = _avaliacao.Perguntas.ToList();
            labPergunta.Text = String.Format("{0} - {1}", _numeroQuestao +1, _perguntas[_numeroQuestao].Questao);
            labObs.Text = String.Format("Descrição conceitual: {0}.", _perguntas[_numeroQuestao].DescricaoConceitual);
            labAvaliado.Text = String.Format("Avaliado: {0}" , _avaliados[_numeroAvaliado].Nome);
            if (_perguntas[_numeroQuestao].Tipo == TipoPergunta.GRAFICO)
            {
                panelRespotaGrafica.Visible = true;
                panelSelecao.Visible = false;
            }
            else
            {
                panelSelecao.Visible = true;
                panelRespotaGrafica.Visible = false;
                
                combSelecao.DataSource = _perguntas[_numeroQuestao].Alternativas;
                combSelecao.Focus();
                labSelecao.Text = (combSelecao.SelectedItem== null)?"":((Alternativa)combSelecao.SelectedItem).Descricao;
            }
        }
    }
}
