using System;
using System.Collections.Generic;
using System.Text;

namespace ExercSec06_71
{
    class Estudante
    {
        public string nomeEstudante { get; set; }
        public string emailEstudante { get; set; }

        public Estudante(string nome, string email)
        {
            nomeEstudante = nome;
            emailEstudante = email;
        }

        public override string ToString()
        {
            return nomeEstudante + ", " + emailEstudante;
        }
    }
}
