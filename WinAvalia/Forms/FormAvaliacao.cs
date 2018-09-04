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
using AvaliaCore.Service;
using SchequesWin.Forms;

namespace WinAvalia.Form
{
    public partial class FormAvaliacao : FormModelo
    {
        private ServiceAvalicao _avaliacao;
        
        public FormAvaliacao(RHTContext context)
        {
            InitializeComponent();
            _avaliacao = new ServiceAvalicao(context);
            MontaCobPessoas();
        }

        private void MontaCobPessoas()
        {
            cobPessoas.DataSource = null;
            
            cobPessoas.DataSource = _avaliacao.AllPessoas().OrderBy(p => p.Nome).ToList();
            cobPessoas.SelectedItem = null;
        }
    }
}
