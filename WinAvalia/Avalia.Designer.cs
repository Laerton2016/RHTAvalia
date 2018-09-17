using AvaliaCore.Context;
using AvaliaCore.Entidade;
using WinAvalia.Forms;

namespace WinAvalia
{
    partial class Avalia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avalia));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respostasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.btUser = new Syncfusion.Windows.Forms.Tools.StatusStripButton();
            this.BtLogout = new Syncfusion.Windows.Forms.Tools.StatusStripButton();
            this.avaliacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.respostasToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaliacaoToolStripMenuItem,
            this.classificaçãoToolStripMenuItem,
            this.pessoaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // respostasToolStripMenuItem
            // 
            this.respostasToolStripMenuItem.Name = "respostasToolStripMenuItem";
            this.respostasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.respostasToolStripMenuItem.Text = "Respostas";
            this.respostasToolStripMenuItem.Click += new System.EventHandler(this.respostasToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.btUser,
            this.labUser,
            this.BtLogout});
            this.statusStrip.Location = new System.Drawing.Point(0, 427);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 21);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // labUser
            // 
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(87, 21);
            this.labUser.Text = "Usuário logado";
            // 
            // btUser
            // 
            this.btUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUser.Image = global::WinAvalia.Properties.Resources.Login_40;
            this.btUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUser.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(23, 20);
            // 
            // BtLogout
            // 
            this.BtLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtLogout.Image = global::WinAvalia.Properties.Resources.Logout;
            this.BtLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtLogout.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.BtLogout.Name = "BtLogout";
            this.BtLogout.Size = new System.Drawing.Size(23, 20);
            this.BtLogout.ToolTipText = "Deslogar";
            this.BtLogout.Click += new System.EventHandler(this.BtLogout_Click);
            // 
            // avaliacaoToolStripMenuItem
            // 
            this.avaliacaoToolStripMenuItem.Image = global::WinAvalia.Properties.Resources.Avalia;
            this.avaliacaoToolStripMenuItem.Name = "avaliacaoToolStripMenuItem";
            this.avaliacaoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.avaliacaoToolStripMenuItem.Text = "Avaliacao";
            this.avaliacaoToolStripMenuItem.Click += new System.EventHandler(this.avaliacaoToolStripMenuItem_Click);
            // 
            // classificaçãoToolStripMenuItem
            // 
            this.classificaçãoToolStripMenuItem.Image = global::WinAvalia.Properties.Resources.classificacao_24;
            this.classificaçãoToolStripMenuItem.Name = "classificaçãoToolStripMenuItem";
            this.classificaçãoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.classificaçãoToolStripMenuItem.Text = "Classificação";
            this.classificaçãoToolStripMenuItem.Click += new System.EventHandler(this.classificaçãoToolStripMenuItem_Click);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Image = global::WinAvalia.Properties.Resources.cliente_24;
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // Avalia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Avalia";
            this.Text = "Sistema avaliador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Avalia_FormClosing);
            this.Load += new System.EventHandler(this.Avalia_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respostasToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.StatusStripButton btUser;
        private System.Windows.Forms.ToolStripStatusLabel labUser;
        private Syncfusion.Windows.Forms.Tools.StatusStripButton BtLogout;
    }
}



