#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADVCore.Service;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Service;
using FormModql;
using SchequesWin.Forms;
using WinAvalia.Class;
using System.Resources;

namespace WinAvalia
{
    public partial class FormPessoa : FormModelo
    {

        private PessoaService _ps;
        private Pessoa _pessoa;
        public FormPessoa(RHTContext context)
        {
            InitializeComponent();
            CriaCombo();
            _ps = new PessoaService(context);
        }

        private void CriaCombo()
        {
            CobFuncao.Items.Clear();
            CobFuncao.Items.Add(TipoFuncao.GERENTE);
            CobFuncao.Items.Add(TipoFuncao.OPERARIO);
            CobFuncao.Items.Add(TipoFuncao.SUBGERENTE);
            CobFuncao.Items.Add(TipoFuncao.ADMINISTRADOR);
            cobBusca.Items.Clear();
            cobBusca.Items.Add(TipoBusca.ID);
            cobBusca.Items.Add(TipoBusca.NOME);

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;
            txtNome.Focus();
            LimpaCampos();
            _pessoa = new Pessoa();
            barraBusca.Visible = false;
            barraInicial.Enabled = false;
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            if (txtTermo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome para busca deve ser preenchido.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTermo.Focus();
                return;
            }

            cobResultado.ComboBox.DataSource = null;
            cobResultado.SelectedItem = null;
            switch ((TipoBusca) cobBusca.SelectedItem)
            {
                case TipoBusca.NOME:
                    cobResultado.ComboBox.DataSource = _ps.FindByNome(txtTermo.Text);
                   break;
                case TipoBusca.ID:
                    if (!ValidaDados.SoNumeros(txtTermo.Text))
                    {
                        MessageBox.Show(
                            "Para buscar pelo id deve ser informado somente números, positivos e maiores que zero.",
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTermo.Focus();
                        return;
                    }
                    Int64 id = Int64.Parse(txtTermo.Text);
                    if (id <= 0)
                    {
                        MessageBox.Show(
                            "Para buscar pelo id deve ser informado somente números, positivos e maiores que zero.",
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTermo.Focus();
                        return;
                    }

                    cobResultado.ComboBox.DataSource = new List<Pessoa>()
                    {
                        _ps.FindById(Int64.Parse(txtTermo.Text))
                    };
                    break;
            }

            cobResultado.ComboBox.SelectedItem = null;
            barraBusca.Visible = true;
            barraBusca.Enabled = true;
            cobResultado.Focus();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (cobResultado.SelectedItem == null)
            {
                MessageBox.Show("Deve ser selecionado uma pessoa para poder efetuar a edição", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cobResultado.Focus();
                return;
            }

            _pessoa = (Pessoa) cobResultado.SelectedItem;
            PreencheCampos();
            barraBusca.Enabled = false;
            barraInicial.Enabled = false;
            panelContainer.Visible = true;
            txtNome.Focus();
        }

        private void PreencheCampos()
        {
            txtNome.Text = _pessoa.Nome;
            CobFuncao.SelectedItem = _pessoa.TFuncao;
            txtLogin.Text = _pessoa.Login;
            txtSenha.Text = _pessoa.Senha;
            labId.Text = _pessoa.Id.ToString();
        }

        private void LimpaCampos()
        {
            txtNome.Text = "";
            CobFuncao.SelectedItem = null;
            labId.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CobFuncao.SelectedItem == null)
                {
                    MessageBox.Show("Função não selecionada.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CobFuncao.Focus();
                    return;
                    
                }

                if (txtLogin.Text.Trim().Equals("") || ValidaDados.ExistCaracterEspeciais(txtLogin.Text))
                {
                    MessageBox.Show("Login inválido", Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtLogin.Focus();
                    return;
                }

                if (txtSenha.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Senha inválida", Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtSenha.Focus();
                    return;
                }

                _pessoa.Nome = txtNome.Text;
                _pessoa.TFuncao = (TipoFuncao) CobFuncao.SelectedItem;
                _pessoa.Login = txtLogin.Text;
                _pessoa.Senha = txtSenha.Text;
                _ps.Save(_pessoa);
                MessageBox.Show("Dados salvos com suscesso!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reseta();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reseta()
        {
            cobResultado.SelectedItem = null;
            _pessoa = null;
            LimpaCampos();
            panelContainer.Visible = false;
            barraBusca.Enabled = true;
            barraInicial.Enabled = true;
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja cancelar este processo?", Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                return;
            }
            Reseta();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (cobResultado.SelectedItem == null)
            {
                MessageBox.Show("Deve ser selecionando uma pessoa a ser excluida.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cobResultado.Focus();
                return;
            }

            var resposta = MessageBox.Show("Deseja realmente excluir os dados desta pessoa?", Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resposta == DialogResult.No)
            {
                return;
            }

            try
            {
                _ps.Remove((Pessoa)cobResultado.SelectedItem);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Equals(""))
            {
                MessageBox.Show("Login deve ser preenchido.", Text
                    , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtLogin.Focus();
                return;
            }

            if (_pessoa.Id == 0 && !_ps.LoginValido(txtLogin.Text) )
            {
                MessageBox.Show("Login indisponível.", Text
                    , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtLogin.Focus();
            }
            
        }
    }
}
