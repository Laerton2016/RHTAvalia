using SchequesWin.Forms;

namespace WinAvalia.Forms
{
    partial class FormRespostas : FormModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRespostas));
            this.barraBusca = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cobAvaliados = new System.Windows.Forms.ToolStripComboBox();
            this.btResuladopp = new System.Windows.Forms.ToolStripButton();
            this.btResultadog = new System.Windows.Forms.ToolStripButton();
            this.barraInicial = new System.Windows.Forms.ToolStrip();
            this.labTermo = new System.Windows.Forms.ToolStripLabel();
            this.cobAvaliacoes = new System.Windows.Forms.ToolStripComboBox();
            this.btAvaliar = new System.Windows.Forms.ToolStripButton();
            this.btResultados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btFinalzadas = new System.Windows.Forms.ToolStripButton();
            this.btNaoFinalizadas = new System.Windows.Forms.ToolStripButton();
            this.panelInformacoes = new System.Windows.Forms.Panel();
            this.btIniciar = new System.Windows.Forms.Button();
            this.labInformacoes = new System.Windows.Forms.Label();
            this.panelPergunta = new System.Windows.Forms.Panel();
            this.labPergunta = new System.Windows.Forms.RichTextBox();
            this.labObs = new System.Windows.Forms.RichTextBox();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.labSelecao = new System.Windows.Forms.RichTextBox();
            this.combSelecao = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labAvaliado = new System.Windows.Forms.Label();
            this.btResponder = new System.Windows.Forms.Button();
            this.panelRespotaGrafica = new System.Windows.Forms.Panel();
            this.txtNumerico = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.barraBusca.SuspendLayout();
            this.barraInicial.SuspendLayout();
            this.panelInformacoes.SuspendLayout();
            this.panelPergunta.SuspendLayout();
            this.panelSelecao.SuspendLayout();
            this.panelRespotaGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumerico)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Size = new System.Drawing.Size(75, 604);
            // 
            // picIcone
            // 
            this.picIcone.Image = ((System.Drawing.Image)(resources.GetObject("picIcone.Image")));
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(1023, 95);
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.barraBusca);
            this.panelBarra.Controls.Add(this.barraInicial);
            this.panelBarra.Size = new System.Drawing.Size(1023, 62);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelPergunta);
            this.panelContainer.Controls.Add(this.panelInformacoes);
            this.panelContainer.Size = new System.Drawing.Size(1023, 509);
            // 
            // barraBusca
            // 
            this.barraBusca.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barraBusca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.cobAvaliados,
            this.btResuladopp,
            this.btResultadog});
            this.barraBusca.Location = new System.Drawing.Point(0, 31);
            this.barraBusca.Name = "barraBusca";
            this.barraBusca.Size = new System.Drawing.Size(725, 31);
            this.barraBusca.TabIndex = 10;
            this.barraBusca.Text = "toolStrip2";
            this.barraBusca.Visible = false;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 28);
            this.toolStripLabel2.Text = "Avaliado";
            // 
            // cobAvaliados
            // 
            this.cobAvaliados.Name = "cobAvaliados";
            this.cobAvaliados.Size = new System.Drawing.Size(400, 31);
            // 
            // btResuladopp
            // 
            this.btResuladopp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btResuladopp.Image = global::WinAvalia.Properties.Resources.Resultado;
            this.btResuladopp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btResuladopp.Name = "btResuladopp";
            this.btResuladopp.Size = new System.Drawing.Size(28, 28);
            this.btResuladopp.Text = "Edita o lote";
            this.btResuladopp.ToolTipText = "Resultado por pessoa";
            // 
            // btResultadog
            // 
            this.btResultadog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btResultadog.Image = global::WinAvalia.Properties.Resources.Resultado;
            this.btResultadog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btResultadog.Name = "btResultadog";
            this.btResultadog.Size = new System.Drawing.Size(28, 28);
            this.btResultadog.Text = "toolStripButton1";
            this.btResultadog.ToolTipText = "Resultado de modo global";
            // 
            // barraInicial
            // 
            this.barraInicial.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barraInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labTermo,
            this.cobAvaliacoes,
            this.btAvaliar,
            this.btResultados,
            this.toolStripSeparator1,
            this.btFinalzadas,
            this.btNaoFinalizadas});
            this.barraInicial.Location = new System.Drawing.Point(0, 0);
            this.barraInicial.Name = "barraInicial";
            this.barraInicial.Size = new System.Drawing.Size(1023, 31);
            this.barraInicial.TabIndex = 9;
            this.barraInicial.Text = "toolStrip1";
            // 
            // labTermo
            // 
            this.labTermo.Name = "labTermo";
            this.labTermo.Size = new System.Drawing.Size(125, 28);
            this.labTermo.Text = "Avaliações disponíveis";
            // 
            // cobAvaliacoes
            // 
            this.cobAvaliacoes.DropDownWidth = 400;
            this.cobAvaliacoes.Name = "cobAvaliacoes";
            this.cobAvaliacoes.Size = new System.Drawing.Size(400, 31);
            // 
            // btAvaliar
            // 
            this.btAvaliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAvaliar.Image = global::WinAvalia.Properties.Resources.Avalia;
            this.btAvaliar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAvaliar.Name = "btAvaliar";
            this.btAvaliar.Size = new System.Drawing.Size(28, 28);
            this.btAvaliar.Text = "Buscar";
            this.btAvaliar.Click += new System.EventHandler(this.btAvaliar_Click);
            // 
            // btResultados
            // 
            this.btResultados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btResultados.Image = global::WinAvalia.Properties.Resources.Resultado;
            this.btResultados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btResultados.Name = "btResultados";
            this.btResultados.Size = new System.Drawing.Size(28, 28);
            this.btResultados.Text = "toolStripButton1";
            this.btResultados.ToolTipText = "Resultados";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btFinalzadas
            // 
            this.btFinalzadas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFinalzadas.Image = global::WinAvalia.Properties.Resources.Avalia;
            this.btFinalzadas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFinalzadas.Name = "btFinalzadas";
            this.btFinalzadas.Size = new System.Drawing.Size(28, 28);
            this.btFinalzadas.Text = "Avaliações finalizadas";
            this.btFinalzadas.Click += new System.EventHandler(this.btFinalzadas_Click);
            // 
            // btNaoFinalizadas
            // 
            this.btNaoFinalizadas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNaoFinalizadas.Image = global::WinAvalia.Properties.Resources.Avalia;
            this.btNaoFinalizadas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNaoFinalizadas.Name = "btNaoFinalizadas";
            this.btNaoFinalizadas.Size = new System.Drawing.Size(28, 28);
            this.btNaoFinalizadas.Text = "Avaliçoes não finalizadas";
            this.btNaoFinalizadas.Click += new System.EventHandler(this.btNaoFinalizadas_Click);
            // 
            // panelInformacoes
            // 
            this.panelInformacoes.BackColor = System.Drawing.Color.White;
            this.panelInformacoes.Controls.Add(this.btIniciar);
            this.panelInformacoes.Controls.Add(this.labInformacoes);
            this.panelInformacoes.Location = new System.Drawing.Point(9, 6);
            this.panelInformacoes.Name = "panelInformacoes";
            this.panelInformacoes.Size = new System.Drawing.Size(980, 107);
            this.panelInformacoes.TabIndex = 0;
            this.panelInformacoes.Visible = false;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(769, 73);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(105, 31);
            this.btIniciar.TabIndex = 6;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // labInformacoes
            // 
            this.labInformacoes.AutoSize = true;
            this.labInformacoes.Location = new System.Drawing.Point(18, 10);
            this.labInformacoes.Name = "labInformacoes";
            this.labInformacoes.Size = new System.Drawing.Size(191, 21);
            this.labInformacoes.TabIndex = 0;
            this.labInformacoes.Text = "Informações da avaliação";
            // 
            // panelPergunta
            // 
            this.panelPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelPergunta.Controls.Add(this.labPergunta);
            this.panelPergunta.Controls.Add(this.labObs);
            this.panelPergunta.Controls.Add(this.panelSelecao);
            this.panelPergunta.Controls.Add(this.labAvaliado);
            this.panelPergunta.Controls.Add(this.btResponder);
            this.panelPergunta.Controls.Add(this.panelRespotaGrafica);
            this.panelPergunta.Location = new System.Drawing.Point(9, 119);
            this.panelPergunta.Name = "panelPergunta";
            this.panelPergunta.Size = new System.Drawing.Size(980, 378);
            this.panelPergunta.TabIndex = 1;
            this.panelPergunta.Visible = false;
            // 
            // labPergunta
            // 
            this.labPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labPergunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labPergunta.Location = new System.Drawing.Point(22, 28);
            this.labPergunta.Name = "labPergunta";
            this.labPergunta.Size = new System.Drawing.Size(941, 49);
            this.labPergunta.TabIndex = 10;
            this.labPergunta.TabStop = false;
            this.labPergunta.Text = "";
            // 
            // labObs
            // 
            this.labObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labObs.Location = new System.Drawing.Point(22, 273);
            this.labObs.Name = "labObs";
            this.labObs.Size = new System.Drawing.Size(741, 57);
            this.labObs.TabIndex = 9;
            this.labObs.TabStop = false;
            this.labObs.Text = "";
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelSelecao.Controls.Add(this.labSelecao);
            this.panelSelecao.Controls.Add(this.combSelecao);
            this.panelSelecao.Controls.Add(this.label2);
            this.panelSelecao.Location = new System.Drawing.Point(22, 83);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(944, 164);
            this.panelSelecao.TabIndex = 8;
            this.panelSelecao.Visible = false;
            // 
            // labSelecao
            // 
            this.labSelecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labSelecao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labSelecao.Location = new System.Drawing.Point(3, 98);
            this.labSelecao.Name = "labSelecao";
            this.labSelecao.Size = new System.Drawing.Size(917, 57);
            this.labSelecao.TabIndex = 11;
            this.labSelecao.TabStop = false;
            this.labSelecao.Text = "";
            // 
            // combSelecao
            // 
            this.combSelecao.FormattingEnabled = true;
            this.combSelecao.ItemHeight = 21;
            this.combSelecao.Location = new System.Drawing.Point(3, 25);
            this.combSelecao.Name = "combSelecao";
            this.combSelecao.ScrollAlwaysVisible = true;
            this.combSelecao.Size = new System.Drawing.Size(917, 67);
            this.combSelecao.TabIndex = 3;
            this.combSelecao.SelectedValueChanged += new System.EventHandler(this.combSelecao_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione uma das alternativas:";
            // 
            // labAvaliado
            // 
            this.labAvaliado.AutoSize = true;
            this.labAvaliado.Location = new System.Drawing.Point(18, 4);
            this.labAvaliado.Name = "labAvaliado";
            this.labAvaliado.Size = new System.Drawing.Size(191, 21);
            this.labAvaliado.TabIndex = 6;
            this.labAvaliado.Text = "Informações da avaliação";
            // 
            // btResponder
            // 
            this.btResponder.Location = new System.Drawing.Point(861, 299);
            this.btResponder.Name = "btResponder";
            this.btResponder.Size = new System.Drawing.Size(105, 31);
            this.btResponder.TabIndex = 5;
            this.btResponder.Text = "Responder";
            this.btResponder.UseVisualStyleBackColor = true;
            this.btResponder.Click += new System.EventHandler(this.btResponder_Click);
            // 
            // panelRespotaGrafica
            // 
            this.panelRespotaGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelRespotaGrafica.Controls.Add(this.txtNumerico);
            this.panelRespotaGrafica.Controls.Add(this.label1);
            this.panelRespotaGrafica.Location = new System.Drawing.Point(22, 173);
            this.panelRespotaGrafica.Name = "panelRespotaGrafica";
            this.panelRespotaGrafica.Size = new System.Drawing.Size(741, 74);
            this.panelRespotaGrafica.TabIndex = 3;
            this.panelRespotaGrafica.Visible = false;
            // 
            // txtNumerico
            // 
            this.txtNumerico.Location = new System.Drawing.Point(344, 22);
            this.txtNumerico.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNumerico.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumerico.Name = "txtNumerico";
            this.txtNumerico.Size = new System.Drawing.Size(120, 29);
            this.txtNumerico.TabIndex = 3;
            this.txtNumerico.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione um valor entre 1 e 10,\r\nsendo 1 para muito ruim e 10 para execelente:\r\n" +
    "";
            // 
            // FormRespostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 604);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRespostas";
            this.Text = "Resposta de avaliação";
            this.Load += new System.EventHandler(this.FormRespostas_Load);
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
            this.panelInformacoes.ResumeLayout(false);
            this.panelInformacoes.PerformLayout();
            this.panelPergunta.ResumeLayout(false);
            this.panelPergunta.PerformLayout();
            this.panelSelecao.ResumeLayout(false);
            this.panelSelecao.PerformLayout();
            this.panelRespotaGrafica.ResumeLayout(false);
            this.panelRespotaGrafica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumerico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraBusca;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cobAvaliados;
        private System.Windows.Forms.ToolStripButton btResuladopp;
        private System.Windows.Forms.ToolStripButton btResultadog;
        private System.Windows.Forms.ToolStrip barraInicial;
        private System.Windows.Forms.ToolStripLabel labTermo;
        private System.Windows.Forms.ToolStripComboBox cobAvaliacoes;
        private System.Windows.Forms.ToolStripButton btAvaliar;
        private System.Windows.Forms.ToolStripButton btResultados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btFinalzadas;
        private System.Windows.Forms.ToolStripButton btNaoFinalizadas;
        private System.Windows.Forms.Panel panelInformacoes;
        private System.Windows.Forms.Label labInformacoes;
        private System.Windows.Forms.Panel panelPergunta;
        private System.Windows.Forms.Panel panelRespotaGrafica;
        private System.Windows.Forms.NumericUpDown txtNumerico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Label labAvaliado;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox labObs;
        private System.Windows.Forms.RichTextBox labPergunta;
        private System.Windows.Forms.ListBox combSelecao;
        private System.Windows.Forms.RichTextBox labSelecao;
        private System.Windows.Forms.Button btResponder;
    }
}