using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Classe encarregada de guardar os dados de uma classidicação
/// </summary>
namespace AvaliaCore.Entidade
{
    [Table("Classificacao")]

    public class Classificacao
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private String _descricao;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public override string ToString()
        {
            return Descricao.ToUpper();
        }
    }
}