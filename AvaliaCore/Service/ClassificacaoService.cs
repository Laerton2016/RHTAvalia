using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADVCore.Service;
using AvaliaCore.Context;
using AvaliaCore.Entidade;
using AvaliaCore.Persiste;

namespace AvaliaCore.Service
{
    public class ClassificacaoService
    {
        private RepositoryClassificacao _rc;

        public ClassificacaoService(RHTContext context)
        {
            _rc = new RepositoryClassificacao(context);
        }

        public void Save(Classificacao classificacao)
        {
            if (ValidaDados.ExistCaracterEspeciais(classificacao.Descricao))
            {
                throw  new Exception("Descrição da classificação não pode conter caracteres especiais.");

            }
            _rc.Save(classificacao);
        }

        public void Remove(Int64 id)
        {
            _rc.Remove(id);
        }

        public Classificacao FindById(Int64 id)
        {
            if (id <= 0)
            {
                throw  new Exception("Id da classificação deve ser positivo e maior que zero.");
            }

            return _rc.FindById(id);
        }

        public List<Classificacao> FindAll()
        {
            return _rc.FinAll();
        }

    }
}
