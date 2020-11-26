using capgemini.ddd.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capgemini.ddd.Domain.Models
{
    public class Aluno : Base
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Contato { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int IdTurma { get; set; }

        public Turma Turma { get; set; }

        public Aluno(string nomeCompleto, string cPF, string contato, DateTime dataCadastro, bool ativo, int idTurma)
        {
            NomeCompleto = nomeCompleto;
            CPF = cPF;
            Contato = contato;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            IdTurma = idTurma;
        }
    }
}
