using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Persiste;

namespace AvaliaCore.Service
{
    public class ServiceAvalicao
    {
        private RHTContext _context;
        private RepositoryAvalaicao _ra;
        private RepositoryPessoa _rpessoa;
        private RepositoryClassificacao _rc;
        public ServiceAvalicao(RHTContext context)
        {
            _context = context;
            _ra = new RepositoryAvalaicao(context);
            _rpessoa = new RepositoryPessoa(context);
            _rc = new RepositoryClassificacao(context);
        }

        public void Save(Avaliacao a)
        {
            _ra.Save(a);
        }

        public void Remove(Avaliacao a)
        {
            _ra.Remove(a.Id);
        }

        public List<Avaliacao> AlList()
        {
            return _ra.FindAll();
        }

        public Avaliacao FindbyId(Int64 id)
        {
            return _ra.FindById(id);
        }

        public List<Pessoa> AllPessoas()
        {
            return _rpessoa.FindAll();
        }

        public List<Pessoa> PessoasNaoAvaliadas(Int64 idAvaliacao, Int64 idAvaliador)
        {
            List<Pessoa> pessoas = _rpessoa.FindPessoasNaoAvaliadaByIdAvaliacao(idAvaliacao, idAvaliador);
            return pessoas;
        }
        /// <summary>
        /// Retorna todas as classificações cadastradas no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Classificacao> AllClassificacaos()
        {
            return _rc.FinAll();
        }
        /// <summary>
        /// Lista todas as avaliações abertas
        /// </summary>
        /// <returns></returns>
        public List<Avaliacao> FindAllAvaliacaosAbertas()
        {
            return _ra.FindAvaliacoesIniciadas();
        }
        /// <summary>
        /// Lista todas asavaliações fechadas
        /// </summary>
        /// <returns></returns>
        public List<Avaliacao> FindAllAvaliacaoFechadas()
        {
            return _ra.FindAvaliacoesFinalizadas();
        }

        public List<Avaliacao> AvaliacaoesByPessoaAbertas(Int64 id)
        {
            return _ra.FindAvaliacoesIniciadasByPessoa(id);
        }

        public List<Avaliacao> AvaliacoesByPessoaFechada(Int64 id)
        {
            return _ra.FindAvaliacoesFinalizadaByPessoa(id);
        }


        public List<Peso> GeraResultados(Avaliacao avaliacao, Int64 _idAvaliado = 0)
        {
            avaliacao.Pesos.ToList().ForEach(p => p.ResultaPeso = 0); //Zerando resultados

            foreach (Pergunta pergunta in avaliacao.Perguntas)
            {
                //Buscado qual o valor dos resultados da classificação atual da pergunta
                double valor = avaliacao.Pesos.First(p => p.Classificacao.Id == pergunta.IdClassificacao)
                    .ResultaPeso;
                if (pergunta.Tipo == TipoPergunta.GRAFICO)
                    if (_idAvaliado != 0)
                    {
                        
                        valor += pergunta.Respostas.First(r => r.IdPessoa == _idAvaliado).Nota;
                    }
                    else
                    {
                        pergunta.Respostas.ForEach(r => valor += r.Nota);
                    }
                else
                {
                    if (_idAvaliado != 0)
                    {
                        Alternativa a = pergunta.Respostas.First(r => r.IdPessoa == _idAvaliado).Selecionada;
                        valor += (a.Positiva) ? 10 : 1;
                        
                    }
                    else
                    {
                        pergunta.Respostas.ForEach(r => valor += (r.Selecionada.Positiva) ? 10 : 1);
                    }
                }
                //Repassando a soma dos valores
                avaliacao.Pesos.First(p => p.Classificacao.Id == pergunta.IdClassificacao)
                    .ResultaPeso = valor;
            }
            return avaliacao.Pesos.ToList();
        }
    }
}
