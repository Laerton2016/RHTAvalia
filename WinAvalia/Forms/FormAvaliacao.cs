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

namespace WinAvalia.Form
{
    public partial class FormAvaliacao : FormModelo
    {
        private ServiceAvalicao _service;
        private Avaliacao _avaliacao;
        
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
            
        }

        private void btPerguntas_Click(object sender, EventArgs e)
        {
            panelPerguntas.Visible = true;
            panelPerguntas.Top = panelPessoas.Top;
            panelPerguntas.Left = panelPessoas.Left;
            panelPessoas.Visible = false;
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
    }
}
