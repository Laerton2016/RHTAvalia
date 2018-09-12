#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace WinAvalia
{
    partial class FormPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoa));
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.CobFuncao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barraBusca = new System.Windows.Forms.ToolStrip();
            this.btExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cobResultado = new System.Windows.Forms.ToolStripComboBox();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.barraInicial = new System.Windows.Forms.ToolStrip();
            this.btNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labTermo = new System.Windows.Forms.ToolStripLabel();
            this.txtTermo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cobBusca = new System.Windows.Forms.ToolStripComboBox();
            this.btBusca = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.barraBusca.SuspendLayout();
            this.barraInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btCancela);
            this.panelLeft.Size = new System.Drawing.Size(75, 368);
            this.panelLeft.Controls.SetChildIndex(this.btCancela, 0);
            this.panelLeft.Controls.SetChildIndex(this.picIcone, 0);
            // 
            // picIcone
            // 
            this.picIcone.Image = ((System.Drawing.Image)(resources.GetObject("picIcone.Image")));
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(654, 95);
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.barraBusca);
            this.panelBarra.Controls.Add(this.barraInicial);
            this.panelBarra.Size = new System.Drawing.Size(654, 62);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.txtSenha);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.txtLogin);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.labId);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.btSalvar);
            this.panelContainer.Controls.Add(this.txtNome);
            this.panelContainer.Controls.Add(this.CobFuncao);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Size = new System.Drawing.Size(654, 273);
            this.panelContainer.Visible = false;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::WinAvalia.Properties.Resources.salvar_24;
            this.btSalvar.Location = new System.Drawing.Point(519, 192);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 37);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancela
            // 
            this.btCancela.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btCancela.Image = global::WinAvalia.Properties.Resources.Excluir_24;
            this.btCancela.Location = new System.Drawing.Point(0, 331);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(75, 37);
            this.btCancela.TabIndex = 10;
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(458, 29);
            this.txtNome.TabIndex = 0;
            // 
            // CobFuncao
            // 
            this.CobFuncao.FormattingEnabled = true;
            this.CobFuncao.Location = new System.Drawing.Point(136, 89);
            this.CobFuncao.Name = "CobFuncao";
            this.CobFuncao.Size = new System.Drawing.Size(258, 29);
            this.CobFuncao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Função:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome :";
            // 
            // barraBusca
            // 
            this.barraBusca.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barraBusca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btExcluir,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.cobResultado,
            this.btEditar});
            this.barraBusca.Location = new System.Drawing.Point(0, 31);
            this.barraBusca.Name = "barraBusca";
            this.barraBusca.Size = new System.Drawing.Size(654, 31);
            this.barraBusca.TabIndex = 8;
            this.barraBusca.Text = "toolStrip2";
            this.barraBusca.Visible = false;
            // 
            // btExcluir
            // 
            this.btExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(28, 28);
            this.btExcluir.Text = "Exclui o lote";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 28);
            this.toolStripLabel2.Text = "Resultado";
            // 
            // cobResultado
            // 
            this.cobResultado.Name = "cobResultado";
            this.cobResultado.Size = new System.Drawing.Size(400, 31);
            // 
            // btEditar
            // 
            this.btEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(28, 28);
            this.btEditar.Text = "Edita o lote";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // barraInicial
            // 
            this.barraInicial.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barraInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovo,
            this.toolStripSeparator1,
            this.labTermo,
            this.txtTermo,
            this.toolStripLabel1,
            this.cobBusca,
            this.btBusca});
            this.barraInicial.Location = new System.Drawing.Point(0, 0);
            this.barraInicial.Name = "barraInicial";
            this.barraInicial.Size = new System.Drawing.Size(654, 31);
            this.barraInicial.TabIndex = 7;
            this.barraInicial.Text = "toolStrip1";
            // 
            // btNovo
            // 
            this.btNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(28, 28);
            this.btNovo.Text = "Novo lote";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // labTermo
            // 
            this.labTermo.Name = "labTermo";
            this.labTermo.Size = new System.Drawing.Size(91, 28);
            this.labTermo.Text = "Termo de busca";
            // 
            // txtTermo
            // 
            this.txtTermo.Name = "txtTermo";
            this.txtTermo.Size = new System.Drawing.Size(200, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 28);
            this.toolStripLabel1.Text = "Tipo de busca:";
            // 
            // cobBusca
            // 
            this.cobBusca.Name = "cobBusca";
            this.cobBusca.Size = new System.Drawing.Size(121, 31);
            // 
            // btBusca
            // 
            this.btBusca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btBusca.Image = ((System.Drawing.Image)(resources.GetObject("btBusca.Image")));
            this.btBusca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(28, 28);
            this.btBusca.Text = "Buscar";
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(132, 15);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 21);
            this.labId.TabIndex = 13;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(136, 122);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(258, 29);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(136, 157);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(258, 29);
            this.txtSenha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Senha:";
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 368);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPessoa";
            this.Text = "Cadastro de pessoas";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.barraBusca.ResumeLayout(false);
            this.barraBusca.PerformLayout();
            this.barraInicial.ResumeLayout(false);
            this.barraInicial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox CobFuncao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip barraBusca;
        private System.Windows.Forms.ToolStripButton btExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cobResultado;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStrip barraInicial;
        private System.Windows.Forms.ToolStripButton btNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labTermo;
        private System.Windows.Forms.ToolStripTextBox txtTermo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cobBusca;
        private System.Windows.Forms.ToolStripButton btBusca;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
    }
}

