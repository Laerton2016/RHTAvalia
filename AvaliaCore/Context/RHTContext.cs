using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public override int SaveChanges()
        {
            var orphanedResponses = ChangeTracker.Entries().Where(
                e => (e.State == EntityState.Modified || e.State == EntityState.Added) &&
                     e.Entity is PessoaAvaliacao &&
                     e.Reference("Avaliacao").CurrentValue == null );
            foreach (var orphanedResponse in orphanedResponses)
            {
                PessoaAvaliacaos.Remove(orphanedResponse.Entity as PessoaAvaliacao);
            }

            var pergs = ChangeTracker.Entries().Where(
                e => (e.State == EntityState.Modified || e.State == EntityState.Added) &&
                     e.Entity is Pergunta &&
                     e.Reference("Avaliacao").CurrentValue == null);
            foreach (var orphanedResponse in pergs)
            {
                Perguntas.Remove(orphanedResponse.Entity as Pergunta);
            }

            var alters = ChangeTracker.Entries().Where(
                e => (e.State == EntityState.Modified || e.State == EntityState.Added) &&
                     e.Entity is Alternativa &&
                     e.Reference("Pergunta").CurrentValue == null);
            foreach (var orphanedResponse in alters)
            {
                Alternativas.Remove(orphanedResponse.Entity as Alternativa);
            }

            var pesoss = ChangeTracker.Entries().Where(
                e => (e.State == EntityState.Modified || e.State == EntityState.Added) &&
                     e.Entity is Peso &&
                     e.Reference("Avaliacao").CurrentValue == null);
            foreach (var orphanedResponse in pesoss)
            {
                Pesos.Remove(orphanedResponse.Entity as Peso);
            }

            return base.SaveChanges();
        }
        
    }
}
