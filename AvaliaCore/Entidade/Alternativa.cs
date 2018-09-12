using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// Classe encarregada de guardar os dados de uma alternativa
/// </summary>
namespace AvaliaCore.Entidade
{
    [Table("Alternativa")]
    public class Alternativa
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private Int64 _idPergunta;
        private String _descricao;
        private bool _positiva;



        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public long IdPergunta
        {
            get { return _idPergunta; }
            set { _idPergunta = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public bool Positiva
        {
            get { return _positiva; }
            set { _positiva = value; }
        }

        [ForeignKey("IdPergunta")]
        public virtual Pergunta Pergunta { get; set; }

        public override string ToString()
        {
            return Descricao.ToUpper();
        }
    }
}