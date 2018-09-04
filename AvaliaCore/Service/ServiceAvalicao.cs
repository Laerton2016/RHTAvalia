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
        private RepositoryAvalaicao _rp;
        private RepositoryPessoa _rpessoa;
        public ServiceAvalicao(RHTContext context)
        {
            _context = context;
            _rp = new RepositoryAvalaicao(context);
            _rpessoa = new RepositoryPessoa(context);
        }

        public void Save(Avaliacao a)
        {
            _rp.Save(a);
        }

        public void Remove(Avaliacao a)
        {
            _rp.Remove(a.Id);
        }

        public List<Avaliacao> AlList()
        {
            return _rp.FindAll();
        }

        public Avaliacao FindbyId(Int64 id)
        {
            return _rp.FindById(id);
        }

        public List<Pessoa> AllPessoas()
        {
            return _rpessoa.FindAll();
        }
        
    }
}
