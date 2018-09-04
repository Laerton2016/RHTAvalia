namespace WinAvalia.Form
{
    partial class FormAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvaliacao));
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
            this.panelDados = new System.Windows.Forms.Panel();
            this.panelPerguntas = new System.Windows.Forms.Panel();
            this.gbAlternativas = new System.Windows.Forms.GroupBox();
            this.btMais = new System.Windows.Forms.Button();
            this.btAddAlt = new System.Windows.Forms.Button();
            this.lbAlternativas = new System.Windows.Forms.ListBox();
            this.chPositivo = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtAlternativa = new System.Windows.Forms.Label();
            this.lbPerguntas = new System.Windows.Forms.ListBox();
            this.btSalvarPerguntas = new System.Windows.Forms.Button();
            this.btAddPer = new System.Windows.Forms.Button();
            this.cobTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPessoas = new System.Windows.Forms.Panel();
            this.btSalvarPessoas = new System.Windows.Forms.Button();
            this.btRemPessoas = new System.Windows.Forms.Button();
            this.btRemPessoa = new System.Windows.Forms.Button();
            this.btAddPessoas = new System.Windows.Forms.Button();
            this.btAdPessoa = new System.Windows.Forms.Button();
            this.gAvaliar = new System.Windows.Forms.GroupBox();
            this.lbAvalia = new System.Windows.Forms.ListBox();
            this.grupPessoas = new System.Windows.Forms.GroupBox();
            this.lbPessoas = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPerguntas = new System.Windows.Forms.Button();
            this.btPessoas = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cobPessoas = new System.Windows.Forms.ComboBox();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.labId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.barraBusca.SuspendLayout();
            this.barraInicial.SuspendLayout();
            this.panelDados.SuspendLayout();
            this.panelPerguntas.SuspendLayout();
            this.gbAlternativas.SuspendLayout();
            this.panelPessoas.SuspendLayout();
            this.gAvaliar.SuspendLayout();
            this.grupPessoas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btCancelar);
            this.panelLeft.Size = new System.Drawing.Size(75, 639);
            this.panelLeft.Controls.SetChildIndex(this.picIcone, 0);
            this.panelLeft.Controls.SetChildIndex(this.btCancelar, 0);
            // 
            // picIcone
            // 
            this.picIcone.Image = ((System.Drawing.Image)(resources.GetObject("picIcone.Image")));
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.barraBusca);
            this.panelBarra.Controls.Add(this.barraInicial);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelDados);
            this.panelContainer.Size = new System.Drawing.Size(864, 544);
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
            this.barraBusca.Size = new System.Drawing.Size(864, 31);
            this.barraBusca.TabIndex = 10;
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
            this.barraInicial.Size = new System.Drawing.Size(864, 31);
            this.barraInicial.TabIndex = 9;
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
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.panelPerguntas);
            this.panelDados.Controls.Add(this.panelPessoas);
            this.panelDados.Controls.Add(this.panel2);
            this.panelDados.Controls.Add(this.btSalvar);
            this.panelDados.Controls.Add(this.cobPessoas);
            this.panelDados.Controls.Add(this.rtxtDescricao);
            this.panelDados.Controls.Add(this.labId);
            this.panelDados.Controls.Add(this.label3);
            this.panelDados.Controls.Add(this.label2);
            this.panelDados.Controls.Add(this.label1);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDados.Location = new System.Drawing.Point(0, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(864, 544);
            this.panelDados.TabIndex = 0;
            this.panelDados.Visible = false;
            // 
            // panelPerguntas
            // 
            this.panelPerguntas.Controls.Add(this.gbAlternativas);
            this.panelPerguntas.Controls.Add(this.lbPerguntas);
            this.panelPerguntas.Controls.Add(this.btSalvarPerguntas);
            this.panelPerguntas.Controls.Add(this.btAddPer);
            this.panelPerguntas.Controls.Add(this.cobTipo);
            this.panelPerguntas.Controls.Add(this.label6);
            this.panelPerguntas.Controls.Add(this.txtObs);
            this.panelPerguntas.Controls.Add(this.txtPergunta);
            this.panelPerguntas.Controls.Add(this.label5);
            this.panelPerguntas.Controls.Add(this.label4);
            this.panelPerguntas.Location = new System.Drawing.Point(561, 179);
            this.panelPerguntas.Name = "panelPerguntas";
            this.panelPerguntas.Size = new System.Drawing.Size(762, 301);
            this.panelPerguntas.TabIndex = 9;
            this.panelPerguntas.Visible = false;
            this.panelPerguntas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbAlternativas
            // 
            this.gbAlternativas.Controls.Add(this.btMais);
            this.gbAlternativas.Controls.Add(this.btAddAlt);
            this.gbAlternativas.Controls.Add(this.lbAlternativas);
            this.gbAlternativas.Controls.Add(this.chPositivo);
            this.gbAlternativas.Controls.Add(this.textBox3);
            this.gbAlternativas.Controls.Add(this.txtAlternativa);
            this.gbAlternativas.Location = new System.Drawing.Point(154, 115);
            this.gbAlternativas.Name = "gbAlternativas";
            this.gbAlternativas.Size = new System.Drawing.Size(479, 174);
            this.gbAlternativas.TabIndex = 22;
            this.gbAlternativas.TabStop = false;
            this.gbAlternativas.Text = "Alternativas";
            this.gbAlternativas.Visible = false;
            // 
            // btMais
            // 
            this.btMais.Image = global::WinAvalia.Properties.Resources.mais;
            this.btMais.Location = new System.Drawing.Point(393, 25);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(37, 38);
            this.btMais.TabIndex = 24;
            this.btMais.Tag = "Salva as perguntas na avaliação";
            this.btMais.UseVisualStyleBackColor = true;
            // 
            // btAddAlt
            // 
            this.btAddAlt.Image = global::WinAvalia.Properties.Resources.salvar_24;
            this.btAddAlt.Location = new System.Drawing.Point(436, 25);
            this.btAddAlt.Name = "btAddAlt";
            this.btAddAlt.Size = new System.Drawing.Size(37, 38);
            this.btAddAlt.TabIndex = 23;
            this.btAddAlt.Tag = "Salva as perguntas na avaliação";
            this.btAddAlt.UseVisualStyleBackColor = true;
            // 
            // lbAlternativas
            // 
            this.lbAlternativas.FormattingEnabled = true;
            this.lbAlternativas.ItemHeight = 21;
            this.lbAlternativas.Location = new System.Drawing.Point(11, 71);
            this.lbAlternativas.Name = "lbAlternativas";
            this.lbAlternativas.Size = new System.Drawing.Size(462, 67);
            this.lbAlternativas.TabIndex = 22;
            // 
            // chPositivo
            // 
            this.chPositivo.AutoSize = true;
            this.chPositivo.Location = new System.Drawing.Point(282, 32);
            this.chPositivo.Name = "chPositivo";
            this.chPositivo.Size = new System.Drawing.Size(84, 25);
            this.chPositivo.TabIndex = 2;
            this.chPositivo.Text = "Positivo";
            this.chPositivo.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 29);
            this.textBox3.TabIndex = 1;
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.AutoSize = true;
            this.txtAlternativa.Location = new System.Drawing.Point(7, 38);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(52, 21);
            this.txtAlternativa.TabIndex = 0;
            this.txtAlternativa.Text = "label7";
            // 
            // lbPerguntas
            // 
            this.lbPerguntas.FormattingEnabled = true;
            this.lbPerguntas.ItemHeight = 21;
            this.lbPerguntas.Location = new System.Drawing.Point(19, 132);
            this.lbPerguntas.Name = "lbPerguntas";
            this.lbPerguntas.Size = new System.Drawing.Size(703, 109);
            this.lbPerguntas.TabIndex = 21;
            // 
            // btSalvarPerguntas
            // 
            this.btSalvarPerguntas.Image = global::WinAvalia.Properties.Resources.salvar_24;
            this.btSalvarPerguntas.Location = new System.Drawing.Point(711, 260);
            this.btSalvarPerguntas.Name = "btSalvarPerguntas";
            this.btSalvarPerguntas.Size = new System.Drawing.Size(37, 38);
            this.btSalvarPerguntas.TabIndex = 20;
            this.btSalvarPerguntas.Tag = "Salva as perguntas na avaliação";
            this.btSalvarPerguntas.UseVisualStyleBackColor = true;
            // 
            // btAddPer
            // 
            this.btAddPer.Location = new System.Drawing.Point(348, 80);
            this.btAddPer.Name = "btAddPer";
            this.btAddPer.Size = new System.Drawing.Size(39, 29);
            this.btAddPer.TabIndex = 10;
            this.btAddPer.Text = "button8";
            this.btAddPer.UseVisualStyleBackColor = true;
            // 
            // cobTipo
            // 
            this.cobTipo.FormattingEnabled = true;
            this.cobTipo.Location = new System.Drawing.Point(154, 80);
            this.cobTipo.Name = "cobTipo";
            this.cobTipo.Size = new System.Drawing.Size(177, 29);
            this.cobTipo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de pergunta:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(112, 45);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(610, 29);
            this.txtObs.TabIndex = 3;
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(112, 11);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(610, 29);
            this.txtPergunta.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Observação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pergunta";
            // 
            // panelPessoas
            // 
            this.panelPessoas.Controls.Add(this.btSalvarPessoas);
            this.panelPessoas.Controls.Add(this.btRemPessoas);
            this.panelPessoas.Controls.Add(this.btRemPessoa);
            this.panelPessoas.Controls.Add(this.btAddPessoas);
            this.panelPessoas.Controls.Add(this.btAdPessoa);
            this.panelPessoas.Controls.Add(this.gAvaliar);
            this.panelPessoas.Controls.Add(this.grupPessoas);
            this.panelPessoas.Location = new System.Drawing.Point(26, 179);
            this.panelPessoas.Name = "panelPessoas";
            this.panelPessoas.Size = new System.Drawing.Size(529, 301);
            this.panelPessoas.TabIndex = 8;
            this.panelPessoas.Visible = false;
            // 
            // btSalvarPessoas
            // 
            this.btSalvarPessoas.Image = global::WinAvalia.Properties.Resources.salvar_24;
            this.btSalvarPessoas.Location = new System.Drawing.Point(468, 251);
            this.btSalvarPessoas.Name = "btSalvarPessoas";
            this.btSalvarPessoas.Size = new System.Drawing.Size(37, 38);
            this.btSalvarPessoas.TabIndex = 20;
            this.btSalvarPessoas.Tag = "Slavar as pessoas para avaliação";
            this.btSalvarPessoas.UseVisualStyleBackColor = true;
            // 
            // btRemPessoas
            // 
            this.btRemPessoas.Image = global::WinAvalia.Properties.Resources.SetaEsquerdaAll;
            this.btRemPessoas.Location = new System.Drawing.Point(249, 189);
            this.btRemPessoas.Name = "btRemPessoas";
            this.btRemPessoas.Size = new System.Drawing.Size(37, 38);
            this.btRemPessoas.TabIndex = 19;
            this.btRemPessoas.UseVisualStyleBackColor = true;
            // 
            // btRemPessoa
            // 
            this.btRemPessoa.Image = global::WinAvalia.Properties.Resources.SetaEsquerda;
            this.btRemPessoa.Location = new System.Drawing.Point(249, 145);
            this.btRemPessoa.Name = "btRemPessoa";
            this.btRemPessoa.Size = new System.Drawing.Size(37, 38);
            this.btRemPessoa.TabIndex = 18;
            this.btRemPessoa.UseVisualStyleBackColor = true;
            // 
            // btAddPessoas
            // 
            this.btAddPessoas.Image = global::WinAvalia.Properties.Resources.setaDireitaAll;
            this.btAddPessoas.Location = new System.Drawing.Point(249, 101);
            this.btAddPessoas.Name = "btAddPessoas";
            this.btAddPessoas.Size = new System.Drawing.Size(37, 38);
            this.btAddPessoas.TabIndex = 17;
            this.btAddPessoas.UseVisualStyleBackColor = true;
            // 
            // btAdPessoa
            // 
            this.btAdPessoa.Image = global::WinAvalia.Properties.Resources.setaDireita;
            this.btAdPessoa.Location = new System.Drawing.Point(249, 57);
            this.btAdPessoa.Name = "btAdPessoa";
            this.btAdPessoa.Size = new System.Drawing.Size(37, 38);
            this.btAdPessoa.TabIndex = 16;
            this.btAdPessoa.UseVisualStyleBackColor = true;
            // 
            // gAvaliar
            // 
            this.gAvaliar.Controls.Add(this.lbAvalia);
            this.gAvaliar.Location = new System.Drawing.Point(295, 14);
            this.gAvaliar.Name = "gAvaliar";
            this.gAvaliar.Size = new System.Drawing.Size(213, 231);
            this.gAvaliar.TabIndex = 15;
            this.gAvaliar.TabStop = false;
            this.gAvaliar.Text = "Avaliar";
            // 
            // lbAvalia
            // 
            this.lbAvalia.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAvalia.FormattingEnabled = true;
            this.lbAvalia.ItemHeight = 21;
            this.lbAvalia.Location = new System.Drawing.Point(3, 25);
            this.lbAvalia.Name = "lbAvalia";
            this.lbAvalia.Size = new System.Drawing.Size(204, 203);
            this.lbAvalia.TabIndex = 1;
            // 
            // grupPessoas
            // 
            this.grupPessoas.Controls.Add(this.lbPessoas);
            this.grupPessoas.Location = new System.Drawing.Point(29, 11);
            this.grupPessoas.Name = "grupPessoas";
            this.grupPessoas.Size = new System.Drawing.Size(210, 237);
            this.grupPessoas.TabIndex = 14;
            this.grupPessoas.TabStop = false;
            this.grupPessoas.Text = "Pessoas";
            // 
            // lbPessoas
            // 
            this.lbPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPessoas.FormattingEnabled = true;
            this.lbPessoas.ItemHeight = 21;
            this.lbPessoas.Location = new System.Drawing.Point(3, 25);
            this.lbPessoas.Name = "lbPessoas";
            this.lbPessoas.Size = new System.Drawing.Size(204, 209);
            this.lbPessoas.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btPerguntas);
            this.panel2.Controls.Add(this.btPessoas);
            this.panel2.Location = new System.Drawing.Point(465, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 47);
            this.panel2.TabIndex = 7;
            // 
            // btPerguntas
            // 
            this.btPerguntas.Image = global::WinAvalia.Properties.Resources.perguntas;
            this.btPerguntas.Location = new System.Drawing.Point(46, 3);
            this.btPerguntas.Name = "btPerguntas";
            this.btPerguntas.Size = new System.Drawing.Size(37, 38);
            this.btPerguntas.TabIndex = 8;
            this.btPerguntas.Tag = "Adiciona perguntas";
            this.btPerguntas.UseVisualStyleBackColor = true;
            this.btPerguntas.Click += new System.EventHandler(this.btPerguntas_Click);
            // 
            // btPessoas
            // 
            this.btPessoas.Image = global::WinAvalia.Properties.Resources.pessoas;
            this.btPessoas.Location = new System.Drawing.Point(3, 3);
            this.btPessoas.Name = "btPessoas";
            this.btPessoas.Size = new System.Drawing.Size(37, 38);
            this.btPessoas.TabIndex = 7;
            this.btPessoas.Tag = "Adiciona avaliados";
            this.btPessoas.UseVisualStyleBackColor = true;
            this.btPessoas.Click += new System.EventHandler(this.btPessoas_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::WinAvalia.Properties.Resources.salvar_24;
            this.btSalvar.Location = new System.Drawing.Point(766, 129);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(37, 38);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // cobPessoas
            // 
            this.cobPessoas.FormattingEnabled = true;
            this.cobPessoas.Location = new System.Drawing.Point(108, 123);
            this.cobPessoas.Name = "cobPessoas";
            this.cobPessoas.Size = new System.Drawing.Size(342, 29);
            this.cobPessoas.TabIndex = 5;
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Location = new System.Drawing.Point(26, 59);
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(777, 58);
            this.rtxtDescricao.TabIndex = 4;
            this.rtxtDescricao.Text = "";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(56, 14);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 21);
            this.labId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avaliador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição da avaliação:";
            // 
            // btCancelar
            // 
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btCancelar.Image = global::WinAvalia.Properties.Resources.Excluir_24;
            this.btCancelar.Location = new System.Drawing.Point(0, 601);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 38);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 639);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAvaliacao";
            this.Text = "Cadastro de avaliação";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.barraBusca.ResumeLayout(false);
            this.barraBusca.PerformLayout();
            this.barraInicial.ResumeLayout(false);
            this.barraInicial.PerformLayout();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.panelPerguntas.ResumeLayout(false);
            this.panelPerguntas.PerformLayout();
            this.gbAlternativas.ResumeLayout(false);
            this.gbAlternativas.PerformLayout();
            this.panelPessoas.ResumeLayout(false);
            this.gAvaliar.ResumeLayout(false);
            this.grupPessoas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cobPessoas;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btPessoas;
        private System.Windows.Forms.Button btPerguntas;
        private System.Windows.Forms.Panel panelPessoas;
        private System.Windows.Forms.Button btRemPessoas;
        private System.Windows.Forms.Button btRemPessoa;
        private System.Windows.Forms.Button btAddPessoas;
        private System.Windows.Forms.Button btAdPessoa;
        private System.Windows.Forms.GroupBox gAvaliar;
        private System.Windows.Forms.GroupBox grupPessoas;
        private System.Windows.Forms.Panel panelPerguntas;
        private System.Windows.Forms.ComboBox cobTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAddPer;
        private System.Windows.Forms.Button btSalvarPessoas;
        private System.Windows.Forms.Button btSalvarPerguntas;
        private System.Windows.Forms.GroupBox gbAlternativas;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btAddAlt;
        private System.Windows.Forms.ListBox lbAlternativas;
        private System.Windows.Forms.CheckBox chPositivo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtAlternativa;
        private System.Windows.Forms.ListBox lbPerguntas;
        private System.Windows.Forms.ListBox lbAvalia;
        private System.Windows.Forms.ListBox lbPessoas;
    }
}