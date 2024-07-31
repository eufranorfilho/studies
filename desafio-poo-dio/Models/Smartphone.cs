using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo_dio.Models
{
    public abstract class Smartphone
    {
        public string Numero{get;set;}
        private string Modelo{get;set;}
        private string Imei{get;set;}
        private int Memoria{get;set;}

        public Smartphone(){}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando agora!!");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Ligação recebida! pelo meu numero {Numero}");
        }

        public abstract string InstalarAplicativo(string nome);    
    }
}