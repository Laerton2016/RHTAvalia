using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADVCore.Service;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Persiste;
using Scheque.Uteis;

namespace AvaliaCore.Service
{
    public class PessoaService
    {
        
        private RepositoryPessoa _rp;
        public PessoaService(RHTContext context)
        {
            _rp = new RepositoryPessoa(context);
        }

        public void Save(Pessoa p)
        {
            if (p.Nome.Trim().Equals(""))
            {
                throw  new Exception("Nome de pessoa não pode ser em branco.");
            }
            if (ValidaDados.ExistCaracterEspeciais(p.Nome))
            {
                throw  new Exception("Nome de pessoa não pode conter carcateres especiais");
            }

            _rp.Save(p);
        }

        public void Remove(Pessoa p)
        {
            if (p.Id == 0)
            {
                throw  new Exception("Não é possível remover uma pessoa que ainda não foi cadastrada no sistema.");
            }
            _rp.Remove(p.Id);
        }

        public List<Pessoa> AllPessoas()
        {
            return _rp.FindAll();
        }

        public Pessoa FindById(Int64 id)
        {
            return _rp.FindById(id);
        }

        public List<Pessoa> FindByNome(String nome)
        {
            
            return _rp.FindByName(nome);
        }

        public bool LoginValido(String login)
        {
            return _rp.FindByLogin(login) == null;
        }
        /// <summary>
        /// Busca por uma pessa pelo login e senha repassado como paramentro
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Pessoa FindByLoginAndSenha(String login, String senha)
        {
            return _rp.FindByLoginSenha(login, senha);
        }

    }
}
