using SchequesWin.Forms;

namespace WinAvalia.Forms
{
    partial class FormGrafico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrafico));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btGeral = new System.Windows.Forms.Button();
            this.btCategoria = new System.Windows.Forms.Button();
            this.btAvaliado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cobCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cobAvaliado = new System.Windows.Forms.ComboBox();
            this.charGeral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labAvaliador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Size = new System.Drawing.Size(75, 458);
            // 
            // picIcone
            // 
            this.picIcone.Image = ((System.Drawing.Image)(resources.GetObject("picIcone.Image")));
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(834, 95);
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.labAvaliador);
            this.panelBarra.Controls.Add(this.panel1);
            this.panelBarra.Size = new System.Drawing.Size(834, 62);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.charGeral);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Size = new System.Drawing.Size(834, 363);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(454, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 355);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btGeral);
            this.panel2.Controls.Add(this.btCategoria);
            this.panel2.Controls.Add(this.btAvaliado);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cobCategoria);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cobAvaliado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(459, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 363);
            this.panel2.TabIndex = 0;
            // 
            // btGeral
            // 
            this.btGeral.Image = global::WinAvalia.Properties.Resources.sincroniza_24;
            this.btGeral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGeral.Location = new System.Drawing.Point(179, 278);
            this.btGeral.Name = "btGeral";
            this.btGeral.Size = new System.Drawing.Size(184, 37);
            this.btGeral.TabIndex = 8;
            this.btGeral.Text = "Gráfico geral";
            this.btGeral.UseVisualStyleBackColor = true;
            this.btGeral.Click += new System.EventHandler(this.btGeral_Click);
            // 
            // btCategoria
            // 
            this.btCategoria.Image = global::WinAvalia.Properties.Resources.sincroniza_24;
            this.btCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCategoria.Location = new System.Drawing.Point(179, 228);
            this.btCategoria.Name = "btCategoria";
            this.btCategoria.Size = new System.Drawing.Size(184, 37);
            this.btCategoria.TabIndex = 6;
            this.btCategoria.Text = "Por categoria";
            this.btCategoria.UseVisualStyleBackColor = true;
            this.btCategoria.Click += new System.EventHandler(this.btCategoria_Click);
            // 
            // btAvaliado
            // 
            this.btAvaliado.Image = global::WinAvalia.Properties.Resources.sincroniza_24;
            this.btAvaliado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAvaliado.Location = new System.Drawing.Point(179, 117);
            this.btAvaliado.Name = "btAvaliado";
            this.btAvaliado.Size = new System.Drawing.Size(184, 37);
            this.btAvaliado.TabIndex = 5;
            this.btAvaliado.Text = "Por avaliado";
            this.btAvaliado.UseVisualStyleBackColor = true;
            this.btAvaliado.Click += new System.EventHandler(this.btAvaliado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Visualizar grafico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Por categoria";
            // 
            // cobCategoria
            // 
            this.cobCategoria.FormattingEnabled = true;
            this.cobCategoria.Location = new System.Drawing.Point(18, 193);
            this.cobCategoria.Name = "cobCategoria";
            this.cobCategoria.Size = new System.Drawing.Size(345, 29);
            this.cobCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por avaliado";
            // 
            // cobAvaliado
            // 
            this.cobAvaliado.FormattingEnabled = true;
            this.cobAvaliado.Location = new System.Drawing.Point(18, 82);
            this.cobAvaliado.Name = "cobAvaliado";
            this.cobAvaliado.Size = new System.Drawing.Size(345, 29);
            this.cobAvaliado.TabIndex = 0;
            // 
            // charGeral
            // 
            this.charGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.charGeral.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.charGeral.Legends.Add(legend4);
            this.charGeral.Location = new System.Drawing.Point(0, 1);
            this.charGeral.Name = "charGeral";
            this.charGeral.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.charGeral.Series.Add(series4);
            this.charGeral.Size = new System.Drawing.Size(453, 362);
            this.charGeral.TabIndex = 2;
            this.charGeral.Text = "chart1";
            // 
            // labAvaliador
            // 
            this.labAvaliador.AutoSize = true;
            this.labAvaliador.ForeColor = System.Drawing.Color.White;
            this.labAvaliador.Location = new System.Drawing.Point(6, 8);
            this.labAvaliador.Name = "labAvaliador";
            this.labAvaliador.Size = new System.Drawing.Size(194, 24);
            this.labAvaliador.TabIndex = 5;
            this.labAvaliador.Text = "Visualizar grafico:";
            // 
            // button1
            // 
            this.button1.Image = global::WinAvalia.Properties.Resources.sincroniza_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(179, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pontuação geral";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 458);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGrafico";
            this.Text = "Resultado  Avaliação";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charGeral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart charGeral;
        private System.Windows.Forms.Button btAvaliado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobAvaliado;
        private System.Windows.Forms.Button btGeral;
        private System.Windows.Forms.Button btCategoria;
        private System.Windows.Forms.Label labAvaliador;
        private System.Windows.Forms.Button button1;
    }
}