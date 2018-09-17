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
using SchequesWin.Forms;
using WinAvalia.Form;
using WinAvalia.Forms;

namespace WinAvalia
{
    public partial class Avalia : System.Windows.Forms.Form
    {
        private int childFormNumber = 0;
        private RHTContext _context = new RHTContext();
        private Login _login;
        private Pessoa _pessoa;


        public Login Login
        {
            get => _login;
            set { _login = value; }
        }

        public Pessoa Pessoa
        {
            get => _pessoa;
            set =>_pessoa = value; 
        }

        public ToolStripStatusLabel LabUser
        {
            get => labUser;
            set => labUser = value;
        }

        public Avalia()
        {
            InitializeComponent();
        }

        public RHTContext Context
        {
            get => _context;
            set => _context = value;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            System.Windows.Forms.Form childForm = new System.Windows.Forms.Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form childForm = new FormPessoa(_context);
            childForm.Show();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void avaliacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form childForm = new FormAvaliacao(_context);
            childForm.Show();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void classificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form childForm = new FormClassificacao(_context);
            childForm.Show();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void Avalia_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void BtLogout_Click(object sender, EventArgs e)
        {
            _login.Visible = true;
            _login.LimpaCampos();
            this.Dispose();
        }

        private void Avalia_Load(object sender, EventArgs e)
        {
            if (_pessoa != null && _pessoa.TFuncao == TipoFuncao.ADMINISTRADOR)
            {
                cadastroToolStripMenuItem.Enabled = true;
            }
            else
            {
                cadastroToolStripMenuItem.Enabled = false;
            }
        }

        private void respostasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRespostas childForm = new FormRespostas(_context);
            childForm.Avaliador = _pessoa;
            childForm.Show();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;

        }
    }
}
