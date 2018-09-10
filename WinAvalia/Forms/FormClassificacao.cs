using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliaCore.Entidade;
using AvaliaCore.Service;
using SchequesWin.Forms;
using Syncfusion.DataSource.Extensions;

namespace WinAvalia.Forms
{
    public partial class FormClassificacao : FormModelo
    {
        private ClassificacaoService _cs;
        private Classificacao _classificacao;
        public FormClassificacao(AvaliaCore.Context.RHTContext context)
        {
            InitializeComponent();
            _cs = new ClassificacaoService(context);
            dgvDados.DataSource = _cs.FindAll();
            dgvDados.Refresh();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            panelDados.Visible = true;
            txtClassificacao.Focus();
            _classificacao = null;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (_classificacao == null)
            {
                _classificacao = new Classificacao();


            }else
            {
                _classificacao = _cs.FindById(_classificacao.Id);
            }

            _classificacao.Descricao = txtClassificacao.Text;
            _cs.Save(_classificacao);
            dgvDados.DataSource = _cs.FindAll();
            dgvDados.Refresh();
            txtClassificacao.Text = "";
            panelDados.Visible = false;
            _classificacao = null;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection c = dgvDados.SelectedRows;
            if (c.Count == 0)
            {
                MessageBox.Show("Para edição deve ser selecionado uma classificação da lista.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvDados.Focus();
                return;
            }

            _classificacao = new Classificacao()
            {
                Id = (Int64) c[0].Cells[0].Value,
                Descricao = (String) c[0].Cells[1].Value,
            };

            txtClassificacao.Text = _classificacao.Descricao;
            panelDados.Visible = true;
            txtClassificacao.Focus();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection c = dgvDados.SelectedRows;
            if (c.Count == 0)
            {
                MessageBox.Show("Para exclusão deve ser selecionado uma classificação da lista.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvDados.Focus();
                return;
            }

            var r = MessageBox.Show("Deseja realmente excluir a classificação selecionada?", Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _classificacao = new Classificacao()
                {
                    Id = (Int64)c[0].Cells[0].Value,
                    Descricao = (String)c[0].Cells[1].Value,
                };

                _cs.Remove(_classificacao.Id);
                dgvDados.DataSource = _cs.FindAll();
                dgvDados.Refresh();

            }


        }
    }
}
