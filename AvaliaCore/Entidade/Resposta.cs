using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// Classe encarregada de arquivar os dados de uma respostas 
/// </summary>
namespace AvaliaCore.Entidade
{
    [Table("Resposta")]
    public class Resposta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private Int64 _idPergunta;
        private Int64 _idPessoa;
        private int _nota;
        private Alternativa _selecionada;

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

        public long IdPessoa
        {
            get { return _idPessoa; }
            set { _idPessoa = value; }
        }

        public int Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public Alternativa Selecionada
        {
            get { return _selecionada; }
            set { _selecionada = value; }
        }

        [ForeignKey("IdPergunta")]
        public virtual Pergunta Questao { get; set; }

        [ForeignKey("IdPessoa")]
        public virtual Pessoa Avaliado { get; set; }
    }
}