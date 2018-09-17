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
        private Int64? _idAlternativa;
        
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

        public long? IdAlternativa
        {
            get => _idAlternativa;
            set => _idAlternativa = value;
        }

        [ForeignKey("IdAlternativa")]
        public virtual Alternativa Selecionada
        {
            get ;
            set ;
        }

        [ForeignKey("IdPergunta")]
        public virtual Pergunta Questao { get; set; }

        [ForeignKey("IdPessoa")]
        public virtual Pessoa Avaliado { get; set; }

        public override string ToString()
        {
            String reposta = "";
            if (Selecionada == null)
            {
                reposta = Nota.ToString();
            }
            else
            {
                reposta = Selecionada.Descricao;
            }
            return reposta.ToUpper();
        }
    }
}