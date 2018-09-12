using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Classe encarregada de armazenar os dados de uma pergunta 
/// </summary>
namespace AvaliaCore.Entidade
{
    [Table("Pergunta")]
    public class Pergunta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private String _questao;
        private Int64 _idClassificacao;
        private List<Alternativa> _alternativas = new List<Alternativa>();
        private TipoPergunta tipo;
        private String _descricaoConceitual;
        private Int64 _avaliacao_Id;

        public List<Alternativa> Alternativas
        {
            get { return _alternativas; }
            set { _alternativas = value; }
        }

        public TipoPergunta Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public long IdClassificacao
        {
            get { return _idClassificacao; }
            set { _idClassificacao = value; }
        }
        [ForeignKey("IdClassificacao")]
        public virtual Classificacao Classificacao { get; set; }

        public long Avaliacao_Id
        {
            get => _avaliacao_Id;
            set => _avaliacao_Id = value;
        }
        [ForeignKey("Avaliacao_Id")]
        public virtual Avaliacao Avaliacao
        {
            get;
            set;
        }
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Questao
        {
            get { return _questao; }
            set { _questao = value; }
        }

        public void AddAlternativa(Alternativa alternativa)
        {
            _alternativas.Add(alternativa);
        }

        public void RemAlternativa(Alternativa alternativa)
        {
            _alternativas.Remove(alternativa);
        }

        
        public string DescricaoConceitual
        {
            get
            {
                return _descricaoConceitual;
            } 
            set
            {
                _descricaoConceitual = value;
            } 
        }

        public override string ToString()
        {
            return Questao.ToUpper();
        }
    }

    public enum TipoPergunta
    {
        FORCADA, GRAFICO
    }
}