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
    public class RepositoryPessoa
    {
        private RHTContext _context;

        public RepositoryPessoa(RHTContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Salva os dasdos de uma pessoa no banco de dados 
        /// </summary>
        /// <param name="pessoa"></param>
        public void Save(Pessoa pessoa)
        {
            using (DbContextTransaction transaction =  _context.Database.BeginTransaction())
            {
                if (pessoa.Id != 0)
                {
                    _context.Entry(pessoa).State = EntityState.Modified;
                }
                else
                {
                    _context.Pessoas.Add(pessoa);
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
        /// Remove uma pessoa do banco de dados pelo Id repassado
        /// </summary>
        /// <param name="id">Id da pessoa</param>
        public void Remove(Int64 id)
        {
            using (DbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                Pessoa p = _context.Pessoas.Find(id);
                try
                {
                    _context.Pessoas.Remove(p);
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
        /// Busca uma pessoa pelo id repassado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pessoa FindById(Int64 id)
        {
            return _context.Pessoas.Find(id);
        }
        /// <summary>
        /// Lista todas as pessoas no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> FindAll()
        {
            return _context.Pessoas.OrderBy(pessoa => pessoa.Nome).ToList();
        }
        /// <summary>
        /// Busca por pessoas que contém em seu nome o termo repassado 
        /// </summary>
        /// <param name="nome">Parte do nome da pessoa</param>
        /// <returns>Lista de pessoas localizadas</returns>
        public List<Pessoa> FindByName(string nome)
        {
            String sql = String.Format("Select * from pessoa where nome like '%{0}%';", nome);
            return _context.Pessoas.SqlQuery(sql).ToList();
        }

        /// <summary>
        /// Busca por pessoas que não estão na lista de avaliados de uma avaliação, excluindo o avaliador.
        /// </summary>
        /// <param name="idAvaliacao">Id da avaliação</param>
        /// <returns>Lista de pessoas não avaliadas</returns>
        public List<Pessoa> FindPessoasNaoAvaliadaByIdAvaliacao(long idAvaliacao, long idAvaliador)
        {
            String SQL = String.Format("select pessoa.* from pessoa left join " +
             "(select pessoa.* from pessoa join pessoaavaliacao on pessoa.id = pessoaavaliacao.idpessoa where pessoaavaliacao.idavaliacao = {0} ) as p1 " +
             " on p1.id = pessoa.id where p1.id is null and pessoa.id != {1} and pessoa.TFuncao != {2}; ",
            idAvaliacao, idAvaliador,(int) TipoFuncao.ADMINISTRADOR);
            return this._context.Pessoas.SqlQuery(SQL).ToList();
        }
        /// <summary>
        /// Busca por uma pessoa apartir do login e senha repassados como paramentros
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Pessoa FindByLoginSenha(String login, String senha)
        {
            String SQL = String.Format("Select * from pessoa where login ={0} and senha ={1}", login, senha);
            var retorno = _context.Pessoas.SqlQuery(SQL);
            return (retorno == null) ? null : retorno.First();
        }

        /// <summary>
        /// Busca por uma pessoa pelo login desta
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Pessoa FindByLogin(string login)
        {
            String SQL = String.Format("Select * from pessoa where login ='{0}';", login);
            var pessoas = _context.Pessoas.SqlQuery(SQL).ToList();
            return (pessoas.Count == 0) ? null : pessoas.First();
        }
    }
}
