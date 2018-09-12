using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Classe encarregada de armazenar os dados de uma pessoa
/// </summary>
namespace AvaliaCore.Entidade
{
    [Table("Pessoa")]
    public class Pessoa
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private String _nome;
        private TipoPessoa _tipo;
        private TipoFuncao _tFuncao;
        private String _login;
        private String _senha;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Index("Index_login", IsUnique = true), MaxLength(50)]
        public string Login
        {
            get => _login;
            set => _login = value;
        }

        public string Senha
        {
            get => _senha;
            set => _senha = value;
        }

        public TipoFuncao TFuncao
        {
            get
            {
                return _tFuncao;
            }
            set
            {
                _tFuncao = value;
            } 
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public TipoPessoa Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public override string ToString()
        {
            return Nome.ToUpper();
        }
    }

    public enum TipoFuncao
    {
        GERENTE= 0, OPERARIO=1, SUBGERENTE=2,
        ADMINISTRADOR = 3
    }
}
