using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Persiste;
using AvaliaCore.Service;

namespace AvaliaCore
{
    class Program
    {
        static void Main(string[] args)
        {
            RHTContext context = new RHTContext();
            PessoaService ps = new PessoaService(context);
            var pessoas = ps.FindByNome("ful");
            pessoas.ForEach(p => Console.WriteLine(p.Nome));
            Console.ReadLine();

            /*
            RHTContext context = new RHTContext();
            RepositoryPessoa rp = new RepositoryPessoa(context);
            RepositoryAvalaicao ra = new RepositoryAvalaicao(context);
            RepositoryClassificacao rc = new RepositoryClassificacao(context);

            Avaliacao av = ra.FindById(1);
            Console.WriteLine("Avaliados");
            av.Avaliados.ToList().ForEach(avaliacao => Console.WriteLine(avaliacao.Pessoa.Nome));
            av.Perguntas.ToList().ForEach(pergunta => Console.WriteLine(pergunta.Questao + " - " + pergunta.Tipo));
            Console.ReadLine();
            //Crindo uma nova avaliação;
            /*
            Classificacao c = new Classificacao()
            {
                Descricao = "Desempenho"
            };

            Classificacao c1 = new Classificacao()
            {
                Descricao = "Comportamento"
            };
            rc.Save(c);
            rc.Save(c1);

            Avaliacao av = new Avaliacao()
            {
                Descricao = "Avaliação Geral de pessoal",
                Avaliador = new Pessoa()
                {
                    Nome = "Laerton Marques de Figueiredo",
                    Tipo = TipoPessoa.AVALIADOR
                },
            };
            av.AddPergunta(new Pergunta()
            {
                Classificacao = c1,
                Questao = "Cumpri sempre os prazos? Avalie de 0 a 10",
                Tipo = TipoPergunta.GRAFICO
            });
            Pergunta p = new Pergunta()
            {
                Classificacao = c,
                Questao = "A Como é a posição dela nas decisões do projeto?",
                Tipo = TipoPergunta.FORCADA
            };

            p.AddAlternativa(new Alternativa()
            {
                Descricao = "Sempre participa",
                Positiva = true
            });

            p.AddAlternativa(new Alternativa()
            {
                Descricao = "Numca participa",
                Positiva = false
            });

            av.AddPergunta(p);

            av.AddAvaliado(new Pessoa()
            {
                Nome = "Fulano de tal",
                Tipo = TipoPessoa.AVALIADO
            });

            ra.Save(av);*/
        }
    }
}
