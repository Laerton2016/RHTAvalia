﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliaCore.Context;
using AvaliaCore.Entidade;

namespace AvaliaCore.Persiste
{
    public class RepositoryAvalaicao
    {
        private RHTContext _context;

        public RepositoryAvalaicao(RHTContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Persiste os dados de uma avaliação no banco de dados
        /// </summary>
        /// <param name="avaliacao"></param>
        public void Save(Avaliacao avaliacao)
        {
            
            using (DbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                if (avaliacao.Id == 0)
                {
                    _context.Avaliacaos.Add(avaliacao);
                }
                else
                {
                    _context.Entry(avaliacao).State = EntityState.Modified;
                }

                try
                {
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
            }
        }
        /// <summary>
        /// Remove os dados de uma avaliação do banco de dados
        /// </summary>
        /// <param name="id"></param>
        public void Remove(Int64 id)
        {
            Avaliacao a = _context.Avaliacaos.Find(id);
            using (DbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Avaliacaos.Remove(a);
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw;
                }   
            }
        }
        /// <summary>
        /// Busca uma avaliação pelo id repassado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Avaliacao FindById(Int64 id)
        {
            return _context.Avaliacaos.Find(id);
        }
        /// <summary>
        /// Lista todas as avaliações registradas
        /// </summary>
        /// <returns></returns>
        public List<Avaliacao> FindAll()
        {
            return _context.Avaliacaos.ToList();
        }
        /// <summary>
        /// Lista todas as pessoas cuja a avaliação repassada já obteve resposta
        /// </summary>
        /// <param name="avaliacao"></param>
        /// <returns></returns>
        public List<Pessoa> FindPessasAvaliadas(Avaliacao avaliacao)
        {
            String sql = String.Format("select pessoa.* from pessoa left join ( select resposta.*, pergunta.Avaliacao_Id from resposta left join pergunta on resposta.IdPergunta = pergunta.Id) as respostas on pessoa.Id = respostas.IdPessoa where tipo = 1  respostas.Avaliacao_Id = {0};", avaliacao.Id);
            List<Pessoa> pessoas = _context.Pessoas.SqlQuery(sql).ToList();
            return pessoas ;
        }

        /// <summary>
        /// Busca por todas as pessoas ainda não avaliadas na avaliação
        /// </summary>
        /// <param name="avaliacao">Avaliação para ver a pessoas</param>
        /// <returns></returns>
        public List<Pessoa> FindPessoasNaoAvaliadas(Avaliacao avaliacao)
        {
            String sql =
                "select pessoa.* from pessoa left join ( select resposta.*, pergunta.Avaliacao_Id from resposta left join pergunta on resposta.IdPergunta = pergunta.Id) as respostas on pessoa.Id = respostas.IdPessoa where tipo = 1  respostas.Avaliacao_Id is null;";
            List<Pessoa> pessoas = _context.Pessoas.SqlQuery(sql).ToList();
            return pessoas;
        }

        /// <summary>
        /// Busca por todas as avalaições ainda não inicializada
        /// </summary>
        /// <returns></returns>
        public List<Avaliacao> FindAvaliacoesIniciadas()
        {
            String SQL = "select avaliacao.* from avaliacao left join (select pergunta.*, resposta.IdPergunta from pergunta left join resposta on resposta.IdPergunta = pergunta.Id ) as p "+
            "on avaliacao.id = p.Avaliacao_Id where p.IdPergunta is null group by avaliacao.Id; ";
            return _context.Avaliacaos.SqlQuery(SQL).ToList();
        }

        public List<Avaliacao> FindAvaliacoesFinalizadas()
        {
            String SQL = "select avaliacao.* from avaliacao left join (select pergunta.*, resposta.IdPergunta from pergunta left join resposta on resposta.IdPergunta = pergunta.Id ) as p "+
            "on avaliacao.id = p.Avaliacao_Id where p.IdPergunta is not null group by avaliacao.Id; "; 
            return _context.Avaliacaos.SqlQuery(SQL).ToList();
        }

        /// <summary>
        /// Retorna todas as avaliações não finalizadas de um usuário
        /// </summary>
        /// <param name="idPessoa"></param>
        /// <returns></returns>
        public List<Avaliacao> FindAvaliacoesIniciadasByPessoa(Int64 idPessoa)
        {
            String SQL = "select avaliacao.* from avaliacao left join (select pergunta.*, resposta.IdPergunta from pergunta left join resposta on resposta.IdPergunta = pergunta.Id ) as p " +
                         "on avaliacao.id = p.Avaliacao_Id where p.IdPergunta is null and avaliacao.idAvaliador = "+ idPessoa + " group by avaliacao.Id;";
            return _context.Avaliacaos.SqlQuery(SQL).ToList();
        }

        public List<Avaliacao> FindAvaliacoesFinalizadaByPessoa(Int64 idPessoa)
        {
            String SQL = "select avaliacao.* from avaliacao left join (select pergunta.*, resposta.IdPergunta from pergunta left join resposta on resposta.IdPergunta = pergunta.Id ) as p " +
                         "on avaliacao.id = p.Avaliacao_Id where p.IdPergunta is not null and avaliacao.idAvaliador = " + idPessoa + " group by avaliacao.Id;";
            return _context.Avaliacaos.SqlQuery(SQL).ToList();
        }
    }
}
