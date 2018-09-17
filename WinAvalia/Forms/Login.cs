using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADVCore.Service;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Service;
using SchequesWin.Forms;

namespace WinAvalia.Forms
{
    public partial class Login : FormModelo
    {
        private Avalia _formAvalida;
        private RHTContext _context;
        private PessoaService _service;
        private Pessoa _pessoa;

        public Login()
        {
            InitializeComponent();
            _context = new RHTContext();
            _service = new PessoaService(_context);
        }

        public void LimpaCampos()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtLogin.Focus();
        }
        private void btLogar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Equals(""))
            {
                MessageBox.Show("Não foi informado um login.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }

            if (ValidaDados.ExistCaracterEspeciais(txtLogin.Text))
            {
                MessageBox.Show("Login não pode conter carateres especiais.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }

            if (txtSenha.Text.Trim().Equals(""))
            {
                MessageBox.Show("Senha não informada!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }

            _pessoa = _service.FindByLoginAndSenha(txtLogin.Text, txtSenha.Text);
            if (_pessoa == null)
            {
                MessageBox.Show("Login ou senha inválidos", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLogin.Focus();
                return;
            }

            _formAvalida = new Avalia();
            _formAvalida.Context = _context;
            _formAvalida.Login = this;
            _formAvalida.Pessoa = _pessoa;
            _formAvalida.LabUser.Text = _pessoa.Login;
            this.Visible = false;
            _formAvalida.Show();


        }
    }
}
