using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliaCore.Context;
using AvaliaCore.Entidade;

namespace AvaliaCore.Persiste
{
    public class RepositoryClassificacao
    {
        private RHTContext _context;

        public RepositoryClassificacao(RHTContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Persiste os dados de uma classificação no banco de dados
        /// </summary>
        /// <param name="classificacao"></param>
        public void Save(Classificacao classificacao)
        {
            using (DbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                if (classificacao.Id == 0)
                {
                    _context.Classificacaos.Add(classificacao);
                }
                else
                {
                    _context.Entry(classificacao).State = EntityState.Modified;
                }

                try
                {
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
        /// Remove os dados de uma classificação do banco de dados
        /// </summary>
        /// <param name="id">Id da transação a ser exlcuida</param>
        public void Remove(Int64 id)
        {
            using (DbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Classificacao c = _context.Classificacaos.Find(id);
                    _context.Classificacaos.Remove(c);
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
        /// Busca uma classificação apartir do id repassado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Classificacao FindById(Int64 id)
        {
            return _context.Classificacaos.Find(id);
        }
        /// <summary>
        /// Retorna todas as classificações existentes
        /// </summary>
        /// <returns></returns>
        public List<Classificacao> FinAll()
        {
            return _context.Classificacaos.ToList();
        }
    }
}
