using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto02_dio.Models
{
    public class Suite
    {
        public decimal ValorDiaria {get;set;}
        public int Capacidade {get;set;}
        public string TipoSuite {get;set;}

        public Suite(){}

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            ValorDiaria = valorDiaria;
            Capacidade = capacidade;
            TipoSuite = tipoSuite;
        }

    }
}