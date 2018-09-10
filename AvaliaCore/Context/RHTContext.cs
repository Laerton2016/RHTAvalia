using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliaCore.Entidade;

namespace AvaliaCore.Context
{
    public class RHTContext: DbContext
    {
        public DbSet<Avaliacao> Avaliacaos { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<Classificacao> Classificacaos { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<PessoaAvaliacao> PessoaAvaliacaos { get; set; }
        public DbSet<Peso> Pesos { get; set; }


        
    }
}
