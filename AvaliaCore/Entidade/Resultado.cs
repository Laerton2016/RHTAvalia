using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace AvaliaCore.Entidade
{
    public class Resultado
    {
        private List<Peso> _pesos;
        private List<Pergunta> _perguntas;
        private List<Pessoa> _pessoas;
        private Int64 _idAvaliado;

        public Resultado(List<Pergunta> perguntas, Int64 idAvaliado = 0)
        {
            _perguntas = perguntas;
            _perguntas[0].Respostas.ForEach(r => _pessoas.Add(r.Avaliado));//Coletand a lista de pessoas
            _pesos = _perguntas[0].Avaliacao.Pesos.ToList();
            _idAvaliado = idAvaliado;
            GeraResultados();
        }

        [NotMapped]
        public List<Peso> Resultados => _pesos;

        private List<Peso> GeraResultados()
        {
            _pesos.ForEach(p => p.ResultaPeso = 0); //Zerando resultados

            foreach (Pergunta pergunta in _perguntas)
            {
                //Buscado qual o valor dos resultados da classificação atual da pergunta
                double valor = _pesos.First(p => p.Classificacao.Id == pergunta.IdClassificacao)
                    .ResultaPeso;
                if (pergunta.Tipo == TipoPergunta.GRAFICO)
                    if (_idAvaliado != 0)
                    {
                        pergunta.Respostas.ForEach(r => valor += r.Nota);
                    }
                    else
                    {
                        valor += pergunta.Respostas.First(r => r.IdPessoa == _idAvaliado).Nota;
                    }
                else
                {
                    if (_idAvaliado != 0)
                    {
                        pergunta.Respostas.ForEach(r => valor += (r.Selecionada.Positiva)?10:1);
                    }
                    else
                    {
                        Alternativa a = pergunta.Respostas.First(r => r.IdPessoa == _idAvaliado).Selecionada;
                        valor += (a.Positiva)?10:1;
                    }
                }
                //Repassando a soma dos valores
                _pesos.First(p => p.Classificacao.Id == pergunta.IdClassificacao)
                    .ResultaPeso = valor;
            }

            return _pesos;
        }
    }
}