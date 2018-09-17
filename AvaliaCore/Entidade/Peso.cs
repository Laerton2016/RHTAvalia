using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaCore.Entidade
{
    [Table("Peso")]
    public class Peso
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private Int64 _idAvaliacao;
        private Int64 _idClassificacao;
        private Double _pesoAvaliativo;
        private Double _resultaPeso = 0;

        public long Id
        {
            get => _id;
            set => _id = value;
        }

        public long IdAvaliacao
        {
            get => _idAvaliacao;
            set => _idAvaliacao = value;
        }

        public long IdClassificacao
        {
            get => _idClassificacao;
            set => _idClassificacao = value;
        }

        public double PesoAvaliativo
        {
            get => _pesoAvaliativo;
            set => _pesoAvaliativo = value;
        }
        [ForeignKey("IdAvaliacao")]
        public virtual Avaliacao Avaliacao { get; set; }
        [ForeignKey("IdClassificacao")]
        public virtual Classificacao Classificacao { get; set; }

        [NotMapped]
        public string DescricaoClassificacao => Classificacao.Descricao;

        [NotMapped]
        public double ResultaPeso
        {
            get => _resultaPeso;
            set => _resultaPeso = value;
        }

        [NotMapped]
        public double ResultaAplicaPeso => _resultaPeso * _pesoAvaliativo;

    }
}
