using capgemini.ddd.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capgemini.ddd.Domain.Models
{
    public class Turma : Base
    {
        public string Horario { get; set; }
        public string Duracao { get; set; }
        public int? IdAluno { get; set; }
        //public int? IdInstrutor { get; set; }

        public Aluno Aluno { get; set; }
        //public Instrutor Instrutor { get; set; }

        public Turma(string horario, string duracao, int? idAluno)
        {
            Horario = horario;
            Duracao = duracao;
            IdAluno = idAluno;
        }
    }
}
