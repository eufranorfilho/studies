using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto02_dio.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get;set;}
        public Suite Suite {get;set;}
        public int DiasReservados {get;set;}

        public Reserva(){}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if( Suite.Capacidade >= hospedes.Count) 
            {
                Hospedes = hospedes;    
            } else
            {
                throw new ArgumentException("Capacidade de hospedes excedida para essa suite!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count;
        }

        public decimal CalcularValorHora()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;
            decimal desconto = 0.1m;
            if(DiasReservados >= 10)
            {
                return valor -= desconto * valor;
            } else 
            {
                return valor;
            }
        }
    }
}