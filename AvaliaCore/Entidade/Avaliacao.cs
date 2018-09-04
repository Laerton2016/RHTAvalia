using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

/// <summary>
/// Classe encarregada de arquivar os dados de uma avaliação 
/// </summary>
namespace AvaliaCore.Entidade
{
    [Table("Avaliacao")]
    public class Avaliacao
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int64 _id;
        private Int64 _idAvaliador;
        private ICollection<Pergunta> _perguntas;
        private ICollection<PessoaAvaliacao> _avaliados;
        private String _descricao;
        public Avaliacao()
        {
            _perguntas = new HashSet<Pergunta>();
            _avaliados = new HashSet<PessoaAvaliacao>();
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public long IdAvaliador
        {
            get { return _idAvaliador; }
            set { _idAvaliador = value; }
        }

        

        public void AddPergunta(Pergunta pergunta)
        {
            _perguntas.Add(pergunta);
        }

        public void RemPergunta(Pergunta pergunta)
        {
            _perguntas.Remove(pergunta);
        }

        public virtual ICollection<Pergunta> Perguntas
        {
            get { return _perguntas; }
            set { _perguntas = value; }
        }

        public virtual ICollection<PessoaAvaliacao> Avaliados
        {
            get { return _avaliados; }
            set { _avaliados = value; }
        }

        public void AddAvaliado(Pessoa p)
        {
            _avaliados.Add(new PessoaAvaliacao() { Pessoa =  p, Avaliacao = this});
        }
        
        public void RemAvaliado(Pessoa p)
        {
            PessoaAvaliacao pessoaAvaliacaos = _avaliados.Where(avaliacao => avaliacao.Pessoa == p).First();
            _avaliados.Remove(pessoaAvaliacaos);
        }

        [ForeignKey("IdAvaliador")]
        public virtual Pessoa Avaliador { get; set; }

        
            
    }
}
