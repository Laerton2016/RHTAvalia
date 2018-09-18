using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Service;
using SchequesWin.Forms;
using Syncfusion.DataSource.Extensions;

namespace WinAvalia.Forms
{
    public partial class FormGrafico : FormModelo
    {
        private ServiceAvalicao _service;
        private Avaliacao _avalia;
        public FormGrafico(RHTContext context, Int64 id)
        {
            InitializeComponent();
            _service = new ServiceAvalicao(context);
            _avalia = _service.FindbyId(id);
            MontaCombs();
            GraficPie("Geral");
        }

        private void MontaCombs()
        {
            cobAvaliado.DataSource = null;
            cobAvaliado.DataSource = _avalia.Avaliados.Select(a => a.Pessoa).OrderBy(p => p.Nome).ToList();
            cobCategoria.DataSource = null;
            cobCategoria.DataSource = _avalia.Pesos.Select(p => p.Classificacao).OrderBy(c => c.Descricao).ToList();
            labAvaliador.Text = String.Format("Avaliação: {0} \r\nData da publicação: {1:dd/MM/yyyy} - Avaliador: {2}",
                _avalia.Descricao, _avalia.Data, _avalia.Avaliador.Nome);
        }

        private void GraficPie(String titulo, Int64 id =0)
        {
            charGeral.Titles.Clear();
            charGeral.Series.Clear();
            charGeral.Palette = ChartColorPalette.Pastel;
            charGeral.Titles.Add(titulo);

            Series s = charGeral.Series.Add("Categorias");
            s.ChartType = SeriesChartType.Pie;

            var result = _service.GeraResultados(_avalia, id);
            int i = 1;
            result.ForEach(
               p => s.Points.Add(new DataPoint()
               {
                   LegendText = i + " - "+ p.Classificacao.Descricao,
                   YValues= new double[] {p.ResultaAplicaPeso},
                   AxisLabel = i++.ToString()
               }));
        }

        private void GraficoLinha(String titulo, Int64 idCategoria)
        {
            charGeral.Titles.Clear();
            charGeral.Series.Clear();
            charGeral.Refresh();
            charGeral.Palette = ChartColorPalette.Pastel;
            charGeral.Titles.Add(titulo);
            Series s = charGeral.Series.Add("Pessoas");
            s.ChartType = SeriesChartType.Column;
            _avalia.Perguntas.First(p => p.Classificacao.Id == idCategoria).Respostas.ForEach(r => s.Points.Add(new DataPoint()
            {
                AxisLabel = r.Avaliado.Nome,
                YValues = new double[]
                {
                    ((r.Selecionada!=null)?((r.Selecionada.Positiva)?10:1):r.Nota) *
                     _avalia.Pesos.First(p => p.Classificacao.Id == idCategoria).PesoAvaliativo
                }
            }));
        }

        private void GraficoGeral(String titulo)
        {

            charGeral.Titles.Clear();
            charGeral.Series.Clear();
            charGeral.Refresh();

            charGeral.Palette = ChartColorPalette.Pastel;
            charGeral.Titles.Add(titulo);
            Series s = charGeral.Series.Add("Pessoas");
            s.ChartType = SeriesChartType.Column;

            _avalia.Avaliados.ForEach(a => s.Points.Add(new DataPoint()
            {
                AxisLabel = a.Pessoa.Nome,
                YValues = new double[1]
            }));
            

            foreach (DataPoint sp in s.Points)
            {
                
                List<Resposta> rep = new List<Resposta>();
                _avalia.Perguntas.Select(p => p.Respostas).ForEach(r => r.ForEach(r1 => rep.Add(r1)));
                rep.Where(r => r.Avaliado.Nome.Equals(sp.AxisLabel)).ForEach(r1 => sp.YValues[0] += ((r1.Selecionada != null) ? ((r1.Selecionada.Positiva) ? 10 : 1) : r1.Nota) *
                                                                                                      _avalia.Pesos.First(p => p.Classificacao.Id == r1.Questao.IdClassificacao).PesoAvaliativo);


            }
            /*s.Points.ForEach(sp =>
            _avalia.Perguntas.Select(p => p.Respostas).ForEach(r => r.Select(r2 => r2.Avaliado.Nome.Equals(sp.AxisLabel)).ForEach(r1 =>
                r.ForEach(r3 => sp.YValues[i++] += ((r3.Selecionada != null) ? ((r3.Selecionada.Positiva) ? 10 : 1) : r3.Nota) *
                                                   _avalia.Pesos.First(p => p.Classificacao.Id == r3.Questao.IdClassificacao).PesoAvaliativo)
                ))
                );*/


          /* _avalia.Perguntas.Select(p => p.Respostas).ForEach(r => r.ForEach( r1 => s.Points.Add(new DataPoint()
            {
                AxisLabel = r1.Avaliado.Nome,
                YValues = new double[]
                {
                    ((r1.Selecionada!=null)?((r1.Selecionada.Positiva)?10:1):r1.Nota) *
                    _avalia.Pesos.First(p => p.Classificacao.Id == r1.Questao.IdClassificacao).PesoAvaliativo
                }
            })));*/
            
        }

        private void btGeral_Click(object sender, EventArgs e)
        {
            GraficPie("Geral");
        }

        private void btAvaliado_Click(object sender, EventArgs e)
        {
            Pessoa p = (Pessoa) cobAvaliado.SelectedItem;
            GraficPie(p.Nome, p.Id);
        }

        private void btCategoria_Click(object sender, EventArgs e)
        {
            Classificacao c = (Classificacao) cobCategoria.SelectedItem;
            GraficPie("");
            GraficoLinha(c.Descricao, c.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraficPie("");
            GraficoGeral("Pontuação Geral");
        }
    }
}
