using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAvalia.Forms
{
    partial class AboutBox : System.Windows.Forms.Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBox_Load(object sender, EventArgs e)
        {
            textBoxDescription.Text = "Sistema de Avaliação de Desempenho \r\n\r\n" +
                                      "Conceito:\r\n" +
                                      "   De acordo com Lucena(1995, apud SOARES, 2007, p.2) as empresas têm uma preocupação permanente e natural com o desempenho humano e em como torná-lo mais produtivo, uma vez que os seus resultados são consequência desse desempenho. " +
                                      "   \r\nA avaliação de desempenho individual é prática cotidiana e instrumento de mensuração que procura integrar diferentes níveis organizacionais e promover a melhoria da performance de todas as pessoas da organização(LUCENA, 1995; BERGAMINI, 1999, apud SOARES, 2007, p.2). " +
                                      "\r\n\r\nQuem avalia: " +
                                      "   \r\n- O gestor com auxilio do RH." +
                                      "\r\n\r\nMétodos de avaliação:" +
                                      "   \r\n- Escalas gráficas  " +
                                      "   \r\n  * Mede o desempenho em geral por uma escala de nível. " +
                                      "   \r\n- Escolha forçada  " +
                                      "   \r\n  * Avalia o desempenho por meio de aspectos comportamentais." +
                                      "\r\n\r\nProposta da aplicação:" +
                                      "    \r\n- Utilizando os métodos de escala gráfica e escolha forçada, o gestor com o auxilio da equipe de RH, elabora um questionário, classificando as perguntas pelas características a serem avaliadas, definindo um peso para cada característica de acordo com o perfil da avaliação." +
                                      "\r\n\r\nOs resultados:" +
                                      "    \r\n- Resultado a avaliação de modo geral sobre toda a equipe avaliada;" +
                                      "    \r\n- Resultado individual da avaliação;" +
                                      "    \r\n- Comparativo de resultados entre os avaliados de acordo com a característica selecionada.";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
