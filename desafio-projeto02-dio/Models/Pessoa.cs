using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto02_dio.Models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(string nome){
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string Nome {get;set;}
        private string Sobrenome {get;set;}
    }
}