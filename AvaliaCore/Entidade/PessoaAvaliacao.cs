using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaCore.Entidade
{
    [Table("PessoaAvaliacao")]
    public class PessoaAvaliacao
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private Int64 _idPessoa;
        private Int64 _idAvaliacao;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public long IdPessoa
        {
            get { return _idPessoa; }
            set { _idPessoa = value; }
        }

        public long IdAvaliacao
        {
            get { return _idAvaliacao; }
            set { _idAvaliacao = value; }
        }
        [ForeignKey("IdPessoa")]
        public virtual Pessoa Pessoa { get; set; }

        [ForeignKey("IdAvaliacao")]
        public virtual Avaliacao Avaliacao { get; set; }
    }
}
