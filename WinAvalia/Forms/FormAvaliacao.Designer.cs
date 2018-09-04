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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cobPessoas = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btCancelar);
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
            this.panelContainer.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.cobPessoas);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.labId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 164);
            this.panel1.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::WinAvalia.Properties.Resources.salvar_24;
            this.btSalvar.Location = new System.Drawing.Point(766, 120);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(37, 38);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // cobPessoas
            // 
            this.cobPessoas.FormattingEnabled = true;
            this.cobPessoas.Location = new System.Drawing.Point(109, 119);
            this.cobPessoas.Name = "cobPessoas";
            this.cobPessoas.Size = new System.Drawing.Size(342, 29);
            this.cobPessoas.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(777, 58);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(56, 14);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(28, 21);
            this.labId.TabIndex = 3;
            this.labId.Text = "Id:";
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
            this.label2.Location = new System.Drawing.Point(22, 120);
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
            this.btCancelar.Location = new System.Drawing.Point(0, 413);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 38);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 451);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cobPessoas;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCancelar;
    }
}