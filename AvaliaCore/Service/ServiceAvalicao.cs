﻿using System;
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
    }
}
