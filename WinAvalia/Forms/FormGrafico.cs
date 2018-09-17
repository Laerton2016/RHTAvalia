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
        public FormGrafico()
        {
            InitializeComponent();
            _service = new ServiceAvalicao(new RHTContext());
            _avalia = _service.FindbyId(1);
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

        private void GarficoLinha(String titulo, Int64 idCategoria)
        {
            charGeral.Titles.Clear();
            charGeral.Series.Clear();
            charGeral.Palette = ChartColorPalette.Pastel;
            charGeral.Titles.Add(titulo);
            Series s = charGeral.Series.Add("Categorias");
            s.ChartType = SeriesChartType.Bar;
            var result = _service.GeraResultados(_avalia);

           



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
    }
}
